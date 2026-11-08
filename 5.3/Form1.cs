using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace _5._3
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối đến XAMPP MySQL
        private readonly string connString = "Server=localhost;Database=CafePOSDB;Uid=root;Pwd=";

        private readonly List<CafeTable> _tables = [];
        private readonly List<MenuItem> _menu = [];
        private readonly List<string> _categories = [];
        private int _selectedTableId = 1;
        private int _nextMenuId = 1;

        private int? _editingMenuId;

        public Form1()
        {
            InitializeComponent();
            WireUiEvents();
            LoadDataFromDatabase();
            RefreshAllViews();
        }

        private void WireUiEvents()
        {
            _orderCategoryCombo.SelectedIndexChanged += orderCategoryCombo_SelectedIndexChanged;
            addOrderButton.Click += addOrderButton_Click;
            removeOrderButton.Click += removeOrderButton_Click;
            transferButton.Click += transferButton_Click;
            payButton.Click += payButton_Click;
            addMenuButton.Click += addMenuButton_Click;
            updateMenuButton.Click += updateMenuButton_Click;
            deleteMenuButton.Click += deleteMenuButton_Click;
            addCategoryButton.Click += addCategoryButton_Click;
            _menuGrid.SelectionChanged += menuGrid_SelectionChanged;
        }

        // Hàm nạp dữ liệu từ cơ sở dữ liệu CafePOSDB trên XAMPP
        private void LoadDataFromDatabase()
        {
            _categories.Clear();
            _menu.Clear();
            _tables.Clear();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // 1. Load Danh mục
                    string qCategory = "SELECT TenDanhMuc FROM DanhMuc";
                    MySqlDataAdapter daCat = new MySqlDataAdapter(qCategory, conn);
                    DataTable dtCat = new DataTable();
                    daCat.Fill(dtCat);
                    foreach (DataRow row in dtCat.Rows)
                    {
                        _categories.Add(row["TenDanhMuc"].ToString() ?? string.Empty);
                    }

                    // 2. Load Món ăn (kết nối MonAn và DanhMuc)
                    string qMenu = @"SELECT m.MaMon, m.TenMon, d.TenDanhMuc, m.DonGia 
                                     FROM MonAn m JOIN DanhMuc d ON m.MaDanhMuc = d.MaDanhMuc";
                    MySqlDataAdapter daMenu = new MySqlDataAdapter(qMenu, conn);
                    DataTable dtMenu = new DataTable();
                    daMenu.Fill(dtMenu);
                    foreach (DataRow row in dtMenu.Rows)
                    {
                        int id = Convert.ToInt32(row["MaMon"]);
                        string name = row["TenMon"].ToString() ?? string.Empty;
                        string cat = row["TenDanhMuc"].ToString() ?? string.Empty;
                        decimal price = Convert.ToDecimal(row["DonGia"]);
                        _menu.Add(new MenuItem(id, name, cat, price));
                        if (id >= _nextMenuId) _nextMenuId = id + 1;
                    }

                    // 3. Load Bàn ăn
                    string qTable = "SELECT MaBan, TenBan, TrangThai FROM BanAn";
                    using (MySqlCommand cmd = new MySqlCommand(qTable, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maBan = reader.GetInt32("MaBan");
                            string tenBan = reader.GetString("TenBan");
                            _tables.Add(new CafeTable(maBan, tenBan));
                        }
                    }

                    // Nếu CSDL chưa có bàn nào, khởi tạo mặc định 6 bàn
                    if (_tables.Count == 0)
                    {
                        for (var i = 1; i <= 6; i++)
                        {
                            _tables.Add(new CafeTable(i, $"Bàn {i:00}"));
                        }
                    }

                    if (_tables.Count > 0)
                    {
                        _selectedTableId = _tables[0].Id;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL XAMPP: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshAllViews()
        {
            if (_orderCategoryCombo != null)
            {
                _orderCategoryCombo.DataSource = null;
                _orderCategoryCombo.DataSource = _categories.ToList();
            }
            RefreshOrderMenuItems();
            RefreshMenuCategoryInput();
            RefreshMenuGrid();
            RefreshCurrentOrder();
        }

        private void RefreshOrderMenuItems()
        {
            if (_orderMenuCombo is null || _orderCategoryCombo is null)
            {
                return;
            }

            var category = _orderCategoryCombo.SelectedItem as string;
            _orderMenuCombo.DataSource = null;
            _orderMenuCombo.DataSource = _menu.Where(item => item.Category == category).ToList();
            _orderMenuCombo.DisplayMember = nameof(MenuItem.Name);
            _orderMenuCombo.ValueMember = nameof(MenuItem.Id);
        }

        private void RefreshMenuCategoryInput()
        {
            if (_menuCategoryInput == null) return;
            var selectedCategory = _menuCategoryInput.SelectedItem as string;
            _menuCategoryInput.DataSource = null;
            _menuCategoryInput.DataSource = _categories.ToList();
            if (selectedCategory is not null && _categories.Contains(selectedCategory))
            {
                _menuCategoryInput.SelectedItem = selectedCategory;
            }
        }

        private void RefreshMenuGrid()
        {
            if (_menuGrid == null) return;
            _menuGrid.DataSource = _menu.Select(item => new MenuRow(item.Id, item.Name, item.Category, item.Price)).ToList();
            SetGridHeaders(_menuGrid, (nameof(MenuRow.Id), "Mã món"), (nameof(MenuRow.Name), "Tên món"), (nameof(MenuRow.Category), "Danh mục"), (nameof(MenuRow.Price), "Đơn giá"));
            if (_menuGrid.Columns.Contains(nameof(MenuRow.Price)))
            {
                _menuGrid.Columns[nameof(MenuRow.Price)].DefaultCellStyle.Format = "N0";
            }
            _menuGrid.ClearSelection();
            _editingMenuId = null;
        }

        private void RefreshCurrentOrder()
        {
            if (_currentTableLabel == null || _orderGrid == null || _totalLabel == null) return;

            var table = GetSelectedTable();
            _currentTableLabel.Text = $"{table.Name}  |  {(table.Order.Count == 0 ? "Bàn trống" : "Đang phục vụ")}";

            if (_orderGrid.DataSource is not DataTable data)
            {
                data = new DataTable();
                data.Columns.Add("Tên món", typeof(string));
                data.Columns.Add("Số lượng", typeof(int));
                data.Columns.Add("Đơn giá", typeof(decimal));
                data.Columns.Add("Thành tiền", typeof(decimal));
                _orderGrid.DataSource = data;
            }

            data.Rows.Clear();
            foreach (var line in table.Order)
            {
                data.Rows.Add(line.Name, line.Quantity, line.Price, line.Price * line.Quantity);
            }

            if (_orderGrid.Columns.Contains("Đơn giá"))
            {
                _orderGrid.Columns["Đơn giá"].DefaultCellStyle.Format = "N0";
            }
            if (_orderGrid.Columns.Contains("Thành tiền"))
            {
                _orderGrid.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
            }

            _totalLabel.Text = $"Tổng cộng: {table.Order.Sum(line => line.Price * line.Quantity):N0} ₫";
            RefreshTables();
            RefreshTransferTargets();
        }

        private void RefreshTables()
        {
            if (_tablePanel == null) return;
            foreach (Control control in _tablePanel.Controls.Cast<Control>().ToArray())
            {
                control.Dispose();
            }
            _tablePanel.Controls.Clear();
            foreach (var table in _tables)
            {
                var occupied = table.Order.Count > 0;
                var button = new Button
                {
                    Width = 174,
                    Height = 82,
                    Margin = new Padding(7),
                    Text = $"{table.Name}\n{(occupied ? "Có khách" : "Trống")}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = occupied ? Color.FromArgb(190, 75, 70) : Color.FromArgb(55, 155, 105),
                    FlatStyle = FlatStyle.Flat,
                    Tag = table.Id
                };
                button.FlatAppearance.BorderSize = table.Id == _selectedTableId ? 3 : 1;
                button.FlatAppearance.BorderColor = table.Id == _selectedTableId ? Color.FromArgb(255, 190, 65) : Color.White;
                button.Click += (_, _) => SelectTable((int)button.Tag);
                _tablePanel.Controls.Add(button);
            }
        }

        private void RefreshTransferTargets()
        {
            if (_transferTargetCombo == null) return;
            var targets = _tables.Where(table => table.Id != _selectedTableId && table.Order.Count == 0).ToList();
            _transferTargetCombo.DataSource = null;
            _transferTargetCombo.DataSource = targets;
            _transferTargetCombo.DisplayMember = nameof(CafeTable.Name);
            _transferTargetCombo.ValueMember = nameof(CafeTable.Id);
        }

        private void SelectTable(int tableId)
        {
            _selectedTableId = tableId;
            RefreshCurrentOrder();
        }

        private void AddOrderItem()
        {
            if (_orderMenuCombo?.SelectedItem is not MenuItem item)
            {
                MessageBox.Show("Danh mục này chưa có món.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var table = GetSelectedTable();
            var quantity = _orderQuantityInput != null ? (int)_orderQuantityInput.Value : 1;
            var existing = table.Order.FirstOrDefault(line => line.MenuId == item.Id);
            if (existing is null)
            {
                table.Order.Add(new OrderLine(item.Id, item.Name, quantity, item.Price));
            }
            else
            {
                existing.Quantity += quantity;
            }
            RefreshCurrentOrder();
        }

        private void RemoveSelectedOrderItem()
        {
            if (_orderGrid?.CurrentRow is null)
            {
                return;
            }

            var index = _orderGrid.CurrentRow.Index;
            var order = GetSelectedTable().Order;
            if (index >= 0 && index < order.Count)
            {
                order.RemoveAt(index);
                RefreshCurrentOrder();
            }
        }

        // =========================================================================
        // HÀM THANH TOÁN: ĐẨY DỮ LIỆU XUỐNG BẢNG HoaDon VÀ ChiTietHoaDon TRÊN MYSQL
        // =========================================================================
        private void PayCurrentTable()
        {
            var table = GetSelectedTable();
            if (table.Order.Count == 0)
            {
                MessageBox.Show("Bàn chưa có món để thanh toán.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var total = table.Order.Sum(line => line.Price * line.Quantity);
            var result = MessageBox.Show($"Xác nhận thanh toán {total:N0} ₫ cho {table.Name}?", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Lưu hóa đơn xuống MySQL với Transaction đảm bảo đồng bộ
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Thêm vào bảng HoaDon và lấy về mã hóa đơn vừa sinh tự động
                    string insertHD = "INSERT INTO HoaDon (MaBan, GioVao, GioRa, TongTien, TrangThai) VALUES (@MaBan, NOW(), NOW(), @TongTien, 1); SELECT LAST_INSERT_ID();";
                    long maHoaDon = 0;
                    using (MySqlCommand cmd = new MySqlCommand(insertHD, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@MaBan", table.Id);
                        cmd.Parameters.AddWithValue("@TongTien", total);
                        maHoaDon = Convert.ToInt64(cmd.ExecuteScalar());
                    }

                    // 2. Thêm từng món vào bảng ChiTietHoaDon
                    foreach (var line in table.Order)
                    {
                        string insertCT = "INSERT INTO ChiTietHoaDon (MaHoaDon, MaMon, SoLuong, DonGia) VALUES (@MaHD, @MaMon, @SL, @Gia)";
                        using (MySqlCommand cmdCT = new MySqlCommand(insertCT, conn, trans))
                        {
                            cmdCT.Parameters.AddWithValue("@MaHD", maHoaDon);
                            cmdCT.Parameters.AddWithValue("@MaMon", line.MenuId);
                            cmdCT.Parameters.AddWithValue("@SL", line.Quantity);
                            cmdCT.Parameters.AddWithValue("@Gia", line.Price);
                            cmdCT.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi thanh toán CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            table.Order.Clear();
            RefreshCurrentOrder();
            MessageBox.Show("Thanh toán thành công và đã lưu vào CSDL!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TransferCurrentOrder()
        {
            var source = GetSelectedTable();
            if (source.Order.Count == 0 || _transferTargetCombo?.SelectedItem is not CafeTable target)
            {
                MessageBox.Show("Chọn bàn đang có khách và một bàn trống để chuyển.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            target.Order.AddRange(source.Order);
            source.Order.Clear();
            _selectedTableId = target.Id;
            RefreshCurrentOrder();
        }

        private void AddMenuItem()
        {
            if (!TryReadMenuFields(out var name, out var category, out var price))
            {
                return;
            }

            int maDanhMuc = 1;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmdGet = new MySqlCommand("SELECT MaDanhMuc FROM DanhMuc WHERE TenDanhMuc = @Ten", conn))
                {
                    cmdGet.Parameters.AddWithValue("@Ten", category);
                    object res = cmdGet.ExecuteScalar();
                    if (res != null) maDanhMuc = Convert.ToInt32(res);
                }

                string query = "INSERT INTO MonAn (TenMon, MaDanhMuc, DonGia) VALUES (@Ten, @MaDM, @Gia); SELECT LAST_INSERT_ID();";
                using (MySqlCommand cmdIns = new MySqlCommand(query, conn))
                {
                    cmdIns.Parameters.AddWithValue("@Ten", name);
                    cmdIns.Parameters.AddWithValue("@MaDM", maDanhMuc);
                    cmdIns.Parameters.AddWithValue("@Gia", price);
                    long newId = Convert.ToInt64(cmdIns.ExecuteScalar());
                    _nextMenuId = (int)newId + 1;
                }
            }

            _menu.Add(new MenuItem(_nextMenuId - 1, name, category, price));
            RefreshMenuGrid();
            RefreshOrderMenuItems();
            ResetMenuEditor();
        }

        private void UpdateMenuItem()
        {
            if (_editingMenuId is null)
            {
                MessageBox.Show("Chọn món trong danh sách trước khi cập nhật.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!TryReadMenuFields(out var name, out var category, out var price))
            {
                return;
            }

            int maDanhMuc = 1;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmdGet = new MySqlCommand("SELECT MaDanhMuc FROM DanhMuc WHERE TenDanhMuc = @Ten", conn))
                {
                    cmdGet.Parameters.AddWithValue("@Ten", category);
                    object res = cmdGet.ExecuteScalar();
                    if (res != null) maDanhMuc = Convert.ToInt32(res);
                }

                string query = "UPDATE MonAn SET TenMon = @Ten, MaDanhMuc = @MaDM, DonGia = @Gia WHERE MaMon = @Id";
                using (MySqlCommand cmdUp = new MySqlCommand(query, conn))
                {
                    cmdUp.Parameters.AddWithValue("@Ten", name);
                    cmdUp.Parameters.AddWithValue("@MaDM", maDanhMuc);
                    cmdUp.Parameters.AddWithValue("@Gia", price);
                    cmdUp.Parameters.AddWithValue("@Id", _editingMenuId.Value);
                    cmdUp.ExecuteNonQuery();
                }
            }

            var item = _menu.FirstOrDefault(menuItem => menuItem.Id == _editingMenuId.Value);
            if (item is not null)
            {
                item.Name = name;
                item.Category = category;
                item.Price = price;
            }
            RefreshMenuGrid();
            RefreshOrderMenuItems();
            ResetMenuEditor();
        }

        private void DeleteMenuItem()
        {
            if (_editingMenuId is null)
            {
                MessageBox.Show("Chọn món trong danh sách trước khi xóa.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM MonAn WHERE MaMon = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", _editingMenuId.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            _menu.RemoveAll(item => item.Id == _editingMenuId.Value);
            RefreshMenuGrid();
            RefreshOrderMenuItems();
            ResetMenuEditor();
        }

        private void AddCategory()
        {
            var category = _newCategoryInput?.Text.Trim() ?? string.Empty;
            if (category.Length == 0)
            {
                MessageBox.Show("Tên danh mục không được để trống.", "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_categories.Contains(category, StringComparer.CurrentCultureIgnoreCase))
            {
                MessageBox.Show("Danh mục này đã tồn tại.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO DanhMuc (TenDanhMuc) VALUES (@Ten)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ten", category);
                    cmd.ExecuteNonQuery();
                }
            }

            _categories.Add(category);
            RefreshMenuCategoryInput();
            if (_menuCategoryInput != null) _menuCategoryInput.SelectedItem = category;
            if (_orderCategoryCombo != null)
            {
                _orderCategoryCombo.DataSource = null;
                _orderCategoryCombo.DataSource = _categories.ToList();
                _orderCategoryCombo.SelectedItem = category;
            }
            if (_newCategoryInput != null) _newCategoryInput.Clear();
        }

        private bool TryReadMenuFields(out string name, out string category, out decimal price)
        {
            name = _menuNameInput?.Text.Trim() ?? string.Empty;
            category = _menuCategoryInput?.SelectedItem as string ?? string.Empty;
            price = _menuPriceInput != null ? _menuPriceInput.Value : 0;
            if (name.Length == 0)
            {
                MessageBox.Show("Tên món không được để trống.", "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (price < 0)
            {
                MessageBox.Show("Đơn giá không được là số âm.", "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (category.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục.", "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadSelectedMenuItem()
        {
            if (_menuGrid?.CurrentRow?.DataBoundItem is not MenuRow row)
            {
                return;
            }

            _editingMenuId = row.Id;
            if (_menuNameInput != null) _menuNameInput.Text = row.Name;
            if (_menuCategoryInput != null) _menuCategoryInput.SelectedItem = row.Category;
            if (_menuPriceInput != null) _menuPriceInput.Value = Math.Clamp(row.Price, _menuPriceInput.Minimum, _menuPriceInput.Maximum);
        }

        private void ResetMenuEditor()
        {
            if (_menuNameInput != null) _menuNameInput.Clear();
            if (_menuPriceInput != null) _menuPriceInput.Value = 0;
            _editingMenuId = null;
            if (_menuGrid != null) _menuGrid.ClearSelection();
        }

        private CafeTable GetSelectedTable() => _tables.First(table => table.Id == _selectedTableId);

        private static void SetGridHeaders(DataGridView grid, params (string Name, string Header)[] headers)
        {
            foreach (var (name, header) in headers)
            {
                if (grid.Columns.Contains(name))
                {
                    grid.Columns[name].HeaderText = header;
                }
            }
        }

        private sealed class CafeTable(int id, string name)
        {
            public int Id { get; } = id;
            public string Name { get; } = name;
            public List<OrderLine> Order { get; } = [];
        }

        private sealed class MenuItem(int id, string name, string category, decimal price)
        {
            public int Id { get; } = id;
            public string Name { get; set; } = name;
            public string Category { get; set; } = category;
            public decimal Price { get; set; } = price;
        }

        private sealed class OrderLine(int menuId, string name, int quantity, decimal price)
        {
            public int MenuId { get; } = menuId;
            public string Name { get; } = name;
            public int Quantity { get; set; } = quantity;
            public decimal Price { get; } = price;
        }

        private sealed record MenuRow(int Id, string Name, string Category, decimal Price);

        private void orderCategoryCombo_SelectedIndexChanged(object? sender, EventArgs e) => RefreshOrderMenuItems();
        private void addOrderButton_Click(object? sender, EventArgs e) => AddOrderItem();
        private void removeOrderButton_Click(object? sender, EventArgs e) => RemoveSelectedOrderItem();
        private void transferButton_Click(object? sender, EventArgs e) => TransferCurrentOrder();
        private void payButton_Click(object? sender, EventArgs e) => PayCurrentTable();
        private void addMenuButton_Click(object? sender, EventArgs e) => AddMenuItem();
        private void updateMenuButton_Click(object? sender, EventArgs e) => UpdateMenuItem();
        private void deleteMenuButton_Click(object? sender, EventArgs e) => DeleteMenuItem();
        private void addCategoryButton_Click(object? sender, EventArgs e) => AddCategory();
        private void menuGrid_SelectionChanged(object? sender, EventArgs e) => LoadSelectedMenuItem();

        private void _orderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}