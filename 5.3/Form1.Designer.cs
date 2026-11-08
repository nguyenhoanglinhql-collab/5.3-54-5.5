namespace _5._3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;
        private Panel headerPanel = null!;
        private Label appTitleLabel = null!;
        private Label appSubtitleLabel = null!;
        private TabControl mainTabs = null!;
        private TabPage posTabPage = null!;
        private TabPage menuTabPage = null!;
        private SplitContainer posSplitContainer = null!;
        private TableLayoutPanel tableLayoutPanel = null!;
        private Panel tableHeadingPanel = null!;
        private Label tableHeadingLabel = null!;
        private Label tableLegendLabel = null!;
        private FlowLayoutPanel _tablePanel = null!;
        private Button previewTableButton1 = null!;
        private Button previewTableButton2 = null!;
        private Button previewTableButton3 = null!;
        private Button previewTableButton4 = null!;
        private Button previewTableButton5 = null!;
        private Button previewTableButton6 = null!;
        private TableLayoutPanel orderLayoutPanel = null!;
        private Label _currentTableLabel = null!;
        private TableLayoutPanel orderEditorPanel = null!;
        private Label orderCategoryLabel = null!;
        private ComboBox _orderCategoryCombo = null!;
        private Label orderMenuLabel = null!;
        private ComboBox _orderMenuCombo = null!;
        private Label orderQuantityLabel = null!;
        private NumericUpDown _orderQuantityInput = null!;
        private Button addOrderButton = null!;
        private DataGridView _orderGrid = null!;
        private TableLayoutPanel footerPanel = null!;
        private Label _totalLabel = null!;
        private FlowLayoutPanel orderActionsPanel = null!;
        private Button removeOrderButton = null!;
        private ComboBox _transferTargetCombo = null!;
        private Button transferButton = null!;
        private Button payButton = null!;
        private TableLayoutPanel menuLayoutPanel = null!;
        private Label menuHeadingLabel = null!;
        private TableLayoutPanel menuEditorPanel = null!;
        private Panel menuNameFieldPanel = null!;
        private Label menuNameLabel = null!;
        private TextBox _menuNameInput = null!;
        private Panel menuCategoryFieldPanel = null!;
        private Label menuCategoryLabel = null!;
        private ComboBox _menuCategoryInput = null!;
        private Panel menuPriceFieldPanel = null!;
        private Label menuPriceLabel = null!;
        private NumericUpDown _menuPriceInput = null!;
        private FlowLayoutPanel menuActionsPanel = null!;
        private Button addMenuButton = null!;
        private Button updateMenuButton = null!;
        private Button deleteMenuButton = null!;
        private Panel newCategoryFieldPanel = null!;
        private Label newCategoryLabel = null!;
        private TextBox _newCategoryInput = null!;
        private Button addCategoryButton = null!;
        private Label menuHintLabel = null!;
        private DataGridView _menuGrid = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            appSubtitleLabel = new Label();
            appTitleLabel = new Label();
            mainTabs = new TabControl();
            posTabPage = new TabPage();
            posSplitContainer = new SplitContainer();
            tableLayoutPanel = new TableLayoutPanel();
            tableHeadingPanel = new Panel();
            tableLegendLabel = new Label();
            tableHeadingLabel = new Label();
            _tablePanel = new FlowLayoutPanel();
            previewTableButton1 = new Button();
            previewTableButton2 = new Button();
            previewTableButton3 = new Button();
            previewTableButton4 = new Button();
            previewTableButton5 = new Button();
            previewTableButton6 = new Button();
            orderLayoutPanel = new TableLayoutPanel();
            _currentTableLabel = new Label();
            orderEditorPanel = new TableLayoutPanel();
            orderCategoryLabel = new Label();
            _orderCategoryCombo = new ComboBox();
            orderMenuLabel = new Label();
            _orderMenuCombo = new ComboBox();
            orderQuantityLabel = new Label();
            _orderQuantityInput = new NumericUpDown();
            addOrderButton = new Button();
            _orderGrid = new DataGridView();
            footerPanel = new TableLayoutPanel();
            _totalLabel = new Label();
            orderActionsPanel = new FlowLayoutPanel();
            removeOrderButton = new Button();
            _transferTargetCombo = new ComboBox();
            transferButton = new Button();
            payButton = new Button();
            menuTabPage = new TabPage();
            menuLayoutPanel = new TableLayoutPanel();
            menuHeadingLabel = new Label();
            menuEditorPanel = new TableLayoutPanel();
            menuNameFieldPanel = new Panel();
            _menuNameInput = new TextBox();
            menuNameLabel = new Label();
            menuCategoryFieldPanel = new Panel();
            _menuCategoryInput = new ComboBox();
            menuCategoryLabel = new Label();
            menuPriceFieldPanel = new Panel();
            _menuPriceInput = new NumericUpDown();
            menuPriceLabel = new Label();
            menuActionsPanel = new FlowLayoutPanel();
            addMenuButton = new Button();
            updateMenuButton = new Button();
            deleteMenuButton = new Button();
            newCategoryFieldPanel = new Panel();
            _newCategoryInput = new TextBox();
            newCategoryLabel = new Label();
            addCategoryButton = new Button();
            _menuGrid = new DataGridView();
            menuHintLabel = new Label();
            headerPanel.SuspendLayout();
            mainTabs.SuspendLayout();
            posTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)posSplitContainer).BeginInit();
            posSplitContainer.Panel1.SuspendLayout();
            posSplitContainer.Panel2.SuspendLayout();
            posSplitContainer.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            tableHeadingPanel.SuspendLayout();
            _tablePanel.SuspendLayout();
            orderLayoutPanel.SuspendLayout();
            orderEditorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_orderQuantityInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_orderGrid).BeginInit();
            footerPanel.SuspendLayout();
            orderActionsPanel.SuspendLayout();
            menuTabPage.SuspendLayout();
            menuLayoutPanel.SuspendLayout();
            menuEditorPanel.SuspendLayout();
            menuNameFieldPanel.SuspendLayout();
            menuCategoryFieldPanel.SuspendLayout();
            menuPriceFieldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_menuPriceInput).BeginInit();
            menuActionsPanel.SuspendLayout();
            newCategoryFieldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_menuGrid).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(35, 48, 65);
            headerPanel.Controls.Add(appSubtitleLabel);
            headerPanel.Controls.Add(appTitleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(24, 10, 20, 10);
            headerPanel.Size = new Size(1280, 74);
            headerPanel.TabIndex = 1;
            // 
            // appSubtitleLabel
            // 
            appSubtitleLabel.AutoSize = true;
            appSubtitleLabel.ForeColor = Color.FromArgb(198, 208, 220);
            appSubtitleLabel.Location = new Point(48, 54);
            appSubtitleLabel.Name = "appSubtitleLabel";
            appSubtitleLabel.Size = new Size(167, 20);
            appSubtitleLabel.TabIndex = 0;
            appSubtitleLabel.Text = "Quản lý bàn và gọi món";
            // 
            // appTitleLabel
            // 
            appTitleLabel.AutoSize = true;
            appTitleLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            appTitleLabel.ForeColor = Color.White;
            appTitleLabel.Location = new Point(44, 18);
            appTitleLabel.Name = "appTitleLabel";
            appTitleLabel.Size = new Size(168, 45);
            appTitleLabel.TabIndex = 1;
            appTitleLabel.Text = "CAFE POS";
            // 
            // mainTabs
            // 
            mainTabs.Controls.Add(posTabPage);
            mainTabs.Controls.Add(menuTabPage);
            mainTabs.Dock = DockStyle.Fill;
            mainTabs.Location = new Point(0, 74);
            mainTabs.Name = "mainTabs";
            mainTabs.Padding = new Point(16, 6);
            mainTabs.SelectedIndex = 0;
            mainTabs.Size = new Size(1280, 686);
            mainTabs.TabIndex = 0;
            // 
            // posTabPage
            // 
            posTabPage.BackColor = Color.FromArgb(245, 247, 250);
            posTabPage.Controls.Add(posSplitContainer);
            posTabPage.Location = new Point(4, 35);
            posTabPage.Name = "posTabPage";
            posTabPage.Padding = new Padding(10);
            posTabPage.Size = new Size(1272, 647);
            posTabPage.TabIndex = 0;
            posTabPage.Text = "Bán hàng";
            // 
            // posSplitContainer
            // 
            posSplitContainer.BackColor = Color.FromArgb(245, 247, 250);
            posSplitContainer.Dock = DockStyle.Fill;
            posSplitContainer.FixedPanel = FixedPanel.Panel1;
            posSplitContainer.Location = new Point(10, 10);
            posSplitContainer.Name = "posSplitContainer";
            // 
            // posSplitContainer.Panel1
            // 
            posSplitContainer.Panel1.Controls.Add(tableLayoutPanel);
            posSplitContainer.Panel1MinSize = 300;
            // 
            // posSplitContainer.Panel2
            // 
            posSplitContainer.Panel2.Controls.Add(orderLayoutPanel);
            posSplitContainer.Panel2MinSize = 500;
            posSplitContainer.Size = new Size(1252, 627);
            posSplitContainer.SplitterDistance = 420;
            posSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.White;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(tableHeadingPanel, 0, 0);
            tableLayoutPanel.Controls.Add(_tablePanel, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(6);
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(420, 627);
            tableLayoutPanel.TabIndex = 0;
            // 
            // tableHeadingPanel
            // 
            tableHeadingPanel.Controls.Add(tableLegendLabel);
            tableHeadingPanel.Controls.Add(tableHeadingLabel);
            tableHeadingPanel.Dock = DockStyle.Fill;
            tableHeadingPanel.Location = new Point(9, 9);
            tableHeadingPanel.Name = "tableHeadingPanel";
            tableHeadingPanel.Size = new Size(402, 78);
            tableHeadingPanel.TabIndex = 0;
            // 
            // tableLegendLabel
            // 
            tableLegendLabel.AutoSize = true;
            tableLegendLabel.ForeColor = Color.FromArgb(90, 100, 112);
            tableLegendLabel.Location = new Point(5, 38);
            tableLegendLabel.Name = "tableLegendLabel";
            tableLegendLabel.Size = new Size(153, 20);
            tableLegendLabel.TabIndex = 0;
            tableLegendLabel.Text = "● Trống     ● Có khách";
            // 
            // tableHeadingLabel
            // 
            tableHeadingLabel.AutoSize = true;
            tableHeadingLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            tableHeadingLabel.ForeColor = Color.FromArgb(35, 48, 65);
            tableHeadingLabel.Location = new Point(4, 2);
            tableHeadingLabel.Name = "tableHeadingLabel";
            tableHeadingLabel.Size = new Size(134, 35);
            tableHeadingLabel.TabIndex = 1;
            tableHeadingLabel.Text = "Sơ đồ bàn";
            // 
            // _tablePanel
            // 
            _tablePanel.AutoScroll = true;
            _tablePanel.BackColor = Color.White;
            _tablePanel.Controls.Add(previewTableButton1);
            _tablePanel.Controls.Add(previewTableButton2);
            _tablePanel.Controls.Add(previewTableButton3);
            _tablePanel.Controls.Add(previewTableButton4);
            _tablePanel.Controls.Add(previewTableButton5);
            _tablePanel.Controls.Add(previewTableButton6);
            _tablePanel.Dock = DockStyle.Fill;
            _tablePanel.Location = new Point(9, 93);
            _tablePanel.Name = "_tablePanel";
            _tablePanel.Padding = new Padding(2);
            _tablePanel.Size = new Size(402, 525);
            _tablePanel.TabIndex = 1;
            // 
            // previewTableButton1
            // 
            previewTableButton1.BackColor = Color.FromArgb(55, 155, 105);
            previewTableButton1.FlatStyle = FlatStyle.Flat;
            previewTableButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            previewTableButton1.ForeColor = Color.White;
            previewTableButton1.Location = new Point(9, 9);
            previewTableButton1.Margin = new Padding(7);
            previewTableButton1.Name = "previewTableButton1";
            previewTableButton1.Size = new Size(174, 82);
            previewTableButton1.TabIndex = 0;
            previewTableButton1.Text = "Bàn 01\nTrống";
            previewTableButton1.UseVisualStyleBackColor = false;
            // 
            // previewTableButton2
            // 
            previewTableButton2.BackColor = Color.FromArgb(55, 155, 105);
            previewTableButton2.FlatStyle = FlatStyle.Flat;
            previewTableButton2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            previewTableButton2.ForeColor = Color.White;
            previewTableButton2.Location = new Point(197, 9);
            previewTableButton2.Margin = new Padding(7);
            previewTableButton2.Name = "previewTableButton2";
            previewTableButton2.Size = new Size(174, 82);
            previewTableButton2.TabIndex = 1;
            previewTableButton2.Text = "Bàn 02\nTrống";
            previewTableButton2.UseVisualStyleBackColor = false;
            // 
            // previewTableButton3
            // 
            previewTableButton3.BackColor = Color.FromArgb(55, 155, 105);
            previewTableButton3.FlatStyle = FlatStyle.Flat;
            previewTableButton3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            previewTableButton3.ForeColor = Color.White;
            previewTableButton3.Location = new Point(9, 105);
            previewTableButton3.Margin = new Padding(7);
            previewTableButton3.Name = "previewTableButton3";
            previewTableButton3.Size = new Size(174, 82);
            previewTableButton3.TabIndex = 2;
            previewTableButton3.Text = "Bàn 03\nTrống";
            previewTableButton3.UseVisualStyleBackColor = false;
            // 
            // previewTableButton4
            // 
            previewTableButton4.BackColor = Color.FromArgb(55, 155, 105);
            previewTableButton4.FlatStyle = FlatStyle.Flat;
            previewTableButton4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            previewTableButton4.ForeColor = Color.White;
            previewTableButton4.Location = new Point(197, 105);
            previewTableButton4.Margin = new Padding(7);
            previewTableButton4.Name = "previewTableButton4";
            previewTableButton4.Size = new Size(174, 82);
            previewTableButton4.TabIndex = 3;
            previewTableButton4.Text = "Bàn 04\nTrống";
            previewTableButton4.UseVisualStyleBackColor = false;
            // 
            // previewTableButton5
            // 
            previewTableButton5.BackColor = Color.FromArgb(55, 155, 105);
            previewTableButton5.FlatStyle = FlatStyle.Flat;
            previewTableButton5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            previewTableButton5.ForeColor = Color.White;
            previewTableButton5.Location = new Point(9, 201);
            previewTableButton5.Margin = new Padding(7);
            previewTableButton5.Name = "previewTableButton5";
            previewTableButton5.Size = new Size(174, 82);
            previewTableButton5.TabIndex = 4;
            previewTableButton5.Text = "Bàn 05\nTrống";
            previewTableButton5.UseVisualStyleBackColor = false;
            // 
            // previewTableButton6
            // 
            previewTableButton6.BackColor = Color.FromArgb(55, 155, 105);
            previewTableButton6.FlatStyle = FlatStyle.Flat;
            previewTableButton6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            previewTableButton6.ForeColor = Color.White;
            previewTableButton6.Location = new Point(197, 201);
            previewTableButton6.Margin = new Padding(7);
            previewTableButton6.Name = "previewTableButton6";
            previewTableButton6.Size = new Size(174, 82);
            previewTableButton6.TabIndex = 5;
            previewTableButton6.Text = "Bàn 06\nTrống";
            previewTableButton6.UseVisualStyleBackColor = false;
            // 
            // orderLayoutPanel
            // 
            orderLayoutPanel.ColumnCount = 1;
            orderLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            orderLayoutPanel.Controls.Add(_currentTableLabel, 0, 0);
            orderLayoutPanel.Controls.Add(orderEditorPanel, 0, 1);
            orderLayoutPanel.Controls.Add(_orderGrid, 0, 2);
            orderLayoutPanel.Controls.Add(footerPanel, 0, 3);
            orderLayoutPanel.Dock = DockStyle.Fill;
            orderLayoutPanel.Location = new Point(0, 0);
            orderLayoutPanel.Name = "orderLayoutPanel";
            orderLayoutPanel.Padding = new Padding(12, 6, 6, 6);
            orderLayoutPanel.RowCount = 4;
            orderLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            orderLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            orderLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            orderLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            orderLayoutPanel.Size = new Size(828, 627);
            orderLayoutPanel.TabIndex = 0;
            // 
            // _currentTableLabel
            // 
            _currentTableLabel.Dock = DockStyle.Fill;
            _currentTableLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            _currentTableLabel.ForeColor = Color.FromArgb(35, 48, 65);
            _currentTableLabel.Location = new Point(15, 6);
            _currentTableLabel.Name = "_currentTableLabel";
            _currentTableLabel.Size = new Size(804, 54);
            _currentTableLabel.TabIndex = 0;
            _currentTableLabel.Text = "Bàn 01  |  Bàn trống";
            _currentTableLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // orderEditorPanel
            // 
            orderEditorPanel.ColumnCount = 4;
            orderEditorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            orderEditorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            orderEditorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            orderEditorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            orderEditorPanel.Controls.Add(orderCategoryLabel, 0, 0);
            orderEditorPanel.Controls.Add(_orderCategoryCombo, 0, 1);
            orderEditorPanel.Controls.Add(orderMenuLabel, 1, 0);
            orderEditorPanel.Controls.Add(_orderMenuCombo, 1, 1);
            orderEditorPanel.Controls.Add(orderQuantityLabel, 2, 0);
            orderEditorPanel.Controls.Add(_orderQuantityInput, 2, 1);
            orderEditorPanel.Controls.Add(addOrderButton, 3, 1);
            orderEditorPanel.Dock = DockStyle.Fill;
            orderEditorPanel.Location = new Point(15, 63);
            orderEditorPanel.Name = "orderEditorPanel";
            orderEditorPanel.RowCount = 2;
            orderEditorPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            orderEditorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            orderEditorPanel.Size = new Size(804, 76);
            orderEditorPanel.TabIndex = 1;
            // 
            // orderCategoryLabel
            // 
            orderCategoryLabel.AutoSize = true;
            orderCategoryLabel.Dock = DockStyle.Fill;
            orderCategoryLabel.Location = new Point(3, 0);
            orderCategoryLabel.Name = "orderCategoryLabel";
            orderCategoryLabel.Size = new Size(144, 24);
            orderCategoryLabel.TabIndex = 0;
            orderCategoryLabel.Text = "Danh mục";
            // 
            // _orderCategoryCombo
            // 
            _orderCategoryCombo.Dock = DockStyle.Fill;
            _orderCategoryCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _orderCategoryCombo.Location = new Point(3, 27);
            _orderCategoryCombo.Name = "_orderCategoryCombo";
            _orderCategoryCombo.Size = new Size(144, 28);
            _orderCategoryCombo.TabIndex = 1;
            // 
            // orderMenuLabel
            // 
            orderMenuLabel.AutoSize = true;
            orderMenuLabel.Dock = DockStyle.Fill;
            orderMenuLabel.Location = new Point(153, 0);
            orderMenuLabel.Name = "orderMenuLabel";
            orderMenuLabel.Size = new Size(463, 24);
            orderMenuLabel.TabIndex = 2;
            orderMenuLabel.Text = "Món";
            // 
            // _orderMenuCombo
            // 
            _orderMenuCombo.DisplayMember = "Name";
            _orderMenuCombo.Dock = DockStyle.Fill;
            _orderMenuCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _orderMenuCombo.Location = new Point(153, 27);
            _orderMenuCombo.Name = "_orderMenuCombo";
            _orderMenuCombo.Size = new Size(463, 28);
            _orderMenuCombo.TabIndex = 3;
            // 
            // orderQuantityLabel
            // 
            orderQuantityLabel.AutoSize = true;
            orderQuantityLabel.Dock = DockStyle.Fill;
            orderQuantityLabel.Location = new Point(622, 0);
            orderQuantityLabel.Name = "orderQuantityLabel";
            orderQuantityLabel.Size = new Size(69, 24);
            orderQuantityLabel.TabIndex = 4;
            orderQuantityLabel.Text = "Số lượng";
            // 
            // _orderQuantityInput
            // 
            _orderQuantityInput.Dock = DockStyle.Fill;
            _orderQuantityInput.Location = new Point(622, 27);
            _orderQuantityInput.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            _orderQuantityInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            _orderQuantityInput.Name = "_orderQuantityInput";
            _orderQuantityInput.Size = new Size(69, 27);
            _orderQuantityInput.TabIndex = 5;
            _orderQuantityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // addOrderButton
            // 
            addOrderButton.BackColor = Color.FromArgb(42, 135, 95);
            addOrderButton.Dock = DockStyle.Fill;
            addOrderButton.FlatStyle = FlatStyle.Flat;
            addOrderButton.ForeColor = Color.White;
            addOrderButton.Location = new Point(697, 27);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(104, 46);
            addOrderButton.TabIndex = 6;
            addOrderButton.Text = "Thêm món";
            addOrderButton.UseVisualStyleBackColor = false;
            // 
            // _orderGrid
            // 
            _orderGrid.AllowUserToAddRows = false;
            _orderGrid.AllowUserToDeleteRows = false;
            _orderGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _orderGrid.BackgroundColor = Color.White;
            _orderGrid.BorderStyle = BorderStyle.None;
            _orderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _orderGrid.Dock = DockStyle.Fill;
            _orderGrid.Location = new Point(15, 145);
            _orderGrid.MultiSelect = false;
            _orderGrid.Name = "_orderGrid";
            _orderGrid.ReadOnly = true;
            _orderGrid.RowHeadersVisible = false;
            _orderGrid.RowHeadersWidth = 51;
            _orderGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _orderGrid.Size = new Size(804, 331);
            _orderGrid.TabIndex = 2;
            // 
            // footerPanel
            // 
            footerPanel.ColumnCount = 1;
            footerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            footerPanel.Controls.Add(_totalLabel, 0, 0);
            footerPanel.Controls.Add(orderActionsPanel, 0, 1);
            footerPanel.Dock = DockStyle.Fill;
            footerPanel.Location = new Point(15, 482);
            footerPanel.Name = "footerPanel";
            footerPanel.RowCount = 2;
            footerPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            footerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            footerPanel.Size = new Size(804, 136);
            footerPanel.TabIndex = 3;
            // 
            // _totalLabel
            // 
            _totalLabel.Dock = DockStyle.Fill;
            _totalLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            _totalLabel.ForeColor = Color.FromArgb(35, 48, 65);
            _totalLabel.Location = new Point(3, 0);
            _totalLabel.Name = "_totalLabel";
            _totalLabel.Size = new Size(798, 42);
            _totalLabel.TabIndex = 0;
            _totalLabel.Text = "Tổng cộng: 0 ₫";
            _totalLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // orderActionsPanel
            // 
            orderActionsPanel.Controls.Add(removeOrderButton);
            orderActionsPanel.Controls.Add(_transferTargetCombo);
            orderActionsPanel.Controls.Add(transferButton);
            orderActionsPanel.Controls.Add(payButton);
            orderActionsPanel.Dock = DockStyle.Fill;
            orderActionsPanel.Location = new Point(3, 45);
            orderActionsPanel.Name = "orderActionsPanel";
            orderActionsPanel.Size = new Size(798, 88);
            orderActionsPanel.TabIndex = 1;
            orderActionsPanel.WrapContents = false;
            // 
            // removeOrderButton
            // 
            removeOrderButton.AutoSize = true;
            removeOrderButton.BackColor = Color.FromArgb(210, 145, 47);
            removeOrderButton.ForeColor = Color.White;
            removeOrderButton.Location = new Point(3, 3);
            removeOrderButton.Name = "removeOrderButton";
            removeOrderButton.Size = new Size(79, 30);
            removeOrderButton.TabIndex = 0;
            removeOrderButton.Text = "Xóa món";
            removeOrderButton.UseVisualStyleBackColor = false;
            // 
            // _transferTargetCombo
            // 
            _transferTargetCombo.DisplayMember = "Name";
            _transferTargetCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _transferTargetCombo.FormattingEnabled = true;
            _transferTargetCombo.Location = new Point(88, 3);
            _transferTargetCombo.Name = "_transferTargetCombo";
            _transferTargetCombo.Size = new Size(125, 28);
            _transferTargetCombo.TabIndex = 1;
            // 
            // transferButton
            // 
            transferButton.AutoSize = true;
            transferButton.BackColor = Color.FromArgb(65, 105, 150);
            transferButton.ForeColor = Color.White;
            transferButton.Location = new Point(219, 3);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(96, 30);
            transferButton.TabIndex = 2;
            transferButton.Text = "Chuyển bàn";
            transferButton.UseVisualStyleBackColor = false;
            // 
            // payButton
            // 
            payButton.AutoSize = true;
            payButton.BackColor = Color.FromArgb(42, 135, 95);
            payButton.ForeColor = Color.White;
            payButton.Location = new Point(321, 3);
            payButton.Name = "payButton";
            payButton.Size = new Size(93, 30);
            payButton.TabIndex = 3;
            payButton.Text = "Thanh toán";
            payButton.UseVisualStyleBackColor = false;
            // 
            // menuTabPage
            // 
            menuTabPage.BackColor = Color.FromArgb(245, 247, 250);
            menuTabPage.Controls.Add(menuLayoutPanel);
            menuTabPage.Location = new Point(4, 35);
            menuTabPage.Name = "menuTabPage";
            menuTabPage.Padding = new Padding(14);
            menuTabPage.Size = new Size(1272, 647);
            menuTabPage.TabIndex = 1;
            menuTabPage.Text = "Quản lý thực đơn";
            // 
            // menuLayoutPanel
            // 
            menuLayoutPanel.ColumnCount = 1;
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuLayoutPanel.Controls.Add(menuHeadingLabel, 0, 0);
            menuLayoutPanel.Controls.Add(menuEditorPanel, 0, 1);
            menuLayoutPanel.Controls.Add(_menuGrid, 0, 2);
            menuLayoutPanel.Dock = DockStyle.Fill;
            menuLayoutPanel.Location = new Point(14, 14);
            menuLayoutPanel.Name = "menuLayoutPanel";
            menuLayoutPanel.RowCount = 3;
            menuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            menuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            menuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            menuLayoutPanel.Size = new Size(1244, 619);
            menuLayoutPanel.TabIndex = 0;
            // 
            // menuHeadingLabel
            // 
            menuHeadingLabel.Dock = DockStyle.Fill;
            menuHeadingLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            menuHeadingLabel.ForeColor = Color.FromArgb(35, 48, 65);
            menuHeadingLabel.Location = new Point(3, 0);
            menuHeadingLabel.Name = "menuHeadingLabel";
            menuHeadingLabel.Size = new Size(1238, 54);
            menuHeadingLabel.TabIndex = 0;
            menuHeadingLabel.Text = "Quản lý danh mục và thực đơn";
            menuHeadingLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuEditorPanel
            // 
            menuEditorPanel.ColumnCount = 8;
            menuEditorPanel.ColumnStyles.Add(new ColumnStyle());
            menuEditorPanel.ColumnStyles.Add(new ColumnStyle());
            menuEditorPanel.ColumnStyles.Add(new ColumnStyle());
            menuEditorPanel.ColumnStyles.Add(new ColumnStyle());
            menuEditorPanel.ColumnStyles.Add(new ColumnStyle());
            menuEditorPanel.ColumnStyles.Add(new ColumnStyle());
            menuEditorPanel.ColumnStyles.Add(new ColumnStyle());
            menuEditorPanel.ColumnStyles.Add(new ColumnStyle());
            menuEditorPanel.Controls.Add(menuNameFieldPanel, 0, 0);
            menuEditorPanel.Controls.Add(menuCategoryFieldPanel, 1, 0);
            menuEditorPanel.Controls.Add(menuPriceFieldPanel, 2, 0);
            menuEditorPanel.Controls.Add(menuActionsPanel, 3, 0);
            menuEditorPanel.Controls.Add(newCategoryFieldPanel, 4, 0);
            menuEditorPanel.Controls.Add(addCategoryButton, 5, 0);
            menuEditorPanel.Dock = DockStyle.Fill;
            menuEditorPanel.Location = new Point(3, 57);
            menuEditorPanel.Name = "menuEditorPanel";
            menuEditorPanel.RowCount = 1;
            menuEditorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            menuEditorPanel.Size = new Size(1238, 122);
            menuEditorPanel.TabIndex = 1;
            // 
            // menuNameFieldPanel
            // 
            menuNameFieldPanel.Controls.Add(_menuNameInput);
            menuNameFieldPanel.Controls.Add(menuNameLabel);
            menuNameFieldPanel.Location = new Point(3, 3);
            menuNameFieldPanel.Name = "menuNameFieldPanel";
            menuNameFieldPanel.Size = new Size(228, 62);
            menuNameFieldPanel.TabIndex = 0;
            // 
            // _menuNameInput
            // 
            _menuNameInput.Location = new Point(0, 22);
            _menuNameInput.Name = "_menuNameInput";
            _menuNameInput.Size = new Size(220, 27);
            _menuNameInput.TabIndex = 1;
            // 
            // menuNameLabel
            // 
            menuNameLabel.AutoSize = true;
            menuNameLabel.ForeColor = Color.FromArgb(90, 100, 112);
            menuNameLabel.Location = new Point(2, 0);
            menuNameLabel.Name = "menuNameLabel";
            menuNameLabel.Size = new Size(66, 20);
            menuNameLabel.TabIndex = 0;
            menuNameLabel.Text = "Tên món";
            // 
            // menuCategoryFieldPanel
            // 
            menuCategoryFieldPanel.Controls.Add(_menuCategoryInput);
            menuCategoryFieldPanel.Controls.Add(menuCategoryLabel);
            menuCategoryFieldPanel.Location = new Point(237, 3);
            menuCategoryFieldPanel.Name = "menuCategoryFieldPanel";
            menuCategoryFieldPanel.Size = new Size(158, 62);
            menuCategoryFieldPanel.TabIndex = 1;
            // 
            // _menuCategoryInput
            // 
            _menuCategoryInput.DropDownStyle = ComboBoxStyle.DropDownList;
            _menuCategoryInput.FormattingEnabled = true;
            _menuCategoryInput.Location = new Point(0, 22);
            _menuCategoryInput.Name = "_menuCategoryInput";
            _menuCategoryInput.Size = new Size(150, 28);
            _menuCategoryInput.TabIndex = 1;
            // 
            // menuCategoryLabel
            // 
            menuCategoryLabel.AutoSize = true;
            menuCategoryLabel.ForeColor = Color.FromArgb(90, 100, 112);
            menuCategoryLabel.Location = new Point(2, 0);
            menuCategoryLabel.Name = "menuCategoryLabel";
            menuCategoryLabel.Size = new Size(76, 20);
            menuCategoryLabel.TabIndex = 0;
            menuCategoryLabel.Text = "Danh mục";
            // 
            // menuPriceFieldPanel
            // 
            menuPriceFieldPanel.Controls.Add(_menuPriceInput);
            menuPriceFieldPanel.Controls.Add(menuPriceLabel);
            menuPriceFieldPanel.Location = new Point(401, 3);
            menuPriceFieldPanel.Name = "menuPriceFieldPanel";
            menuPriceFieldPanel.Size = new Size(138, 62);
            menuPriceFieldPanel.TabIndex = 2;
            // 
            // _menuPriceInput
            // 
            _menuPriceInput.Location = new Point(0, 22);
            _menuPriceInput.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            _menuPriceInput.Name = "_menuPriceInput";
            _menuPriceInput.Size = new Size(130, 27);
            _menuPriceInput.TabIndex = 1;
            _menuPriceInput.ThousandsSeparator = true;
            // 
            // menuPriceLabel
            // 
            menuPriceLabel.AutoSize = true;
            menuPriceLabel.ForeColor = Color.FromArgb(90, 100, 112);
            menuPriceLabel.Location = new Point(2, 0);
            menuPriceLabel.Name = "menuPriceLabel";
            menuPriceLabel.Size = new Size(85, 20);
            menuPriceLabel.TabIndex = 0;
            menuPriceLabel.Text = "Đơn giá (₫)";
            // 
            // menuActionsPanel
            // 
            menuActionsPanel.Controls.Add(addMenuButton);
            menuActionsPanel.Controls.Add(updateMenuButton);
            menuActionsPanel.Controls.Add(deleteMenuButton);
            menuActionsPanel.Location = new Point(545, 3);
            menuActionsPanel.Name = "menuActionsPanel";
            menuActionsPanel.Size = new Size(320, 62);
            menuActionsPanel.TabIndex = 3;
            // 
            // addMenuButton
            // 
            addMenuButton.AutoSize = true;
            addMenuButton.BackColor = Color.FromArgb(42, 135, 95);
            addMenuButton.ForeColor = Color.White;
            addMenuButton.Location = new Point(3, 3);
            addMenuButton.Name = "addMenuButton";
            addMenuButton.Size = new Size(92, 30);
            addMenuButton.TabIndex = 0;
            addMenuButton.Text = "Thêm món";
            addMenuButton.UseVisualStyleBackColor = false;
            // 
            // updateMenuButton
            // 
            updateMenuButton.AutoSize = true;
            updateMenuButton.BackColor = Color.FromArgb(65, 105, 150);
            updateMenuButton.ForeColor = Color.White;
            updateMenuButton.Location = new Point(101, 3);
            updateMenuButton.Name = "updateMenuButton";
            updateMenuButton.Size = new Size(112, 30);
            updateMenuButton.TabIndex = 1;
            updateMenuButton.Text = "Cập nhật món";
            updateMenuButton.UseVisualStyleBackColor = false;
            // 
            // deleteMenuButton
            // 
            deleteMenuButton.AutoSize = true;
            deleteMenuButton.BackColor = Color.FromArgb(180, 65, 65);
            deleteMenuButton.ForeColor = Color.White;
            deleteMenuButton.Location = new Point(219, 3);
            deleteMenuButton.Name = "deleteMenuButton";
            deleteMenuButton.Size = new Size(79, 30);
            deleteMenuButton.TabIndex = 2;
            deleteMenuButton.Text = "Xóa món";
            deleteMenuButton.UseVisualStyleBackColor = false;
            // 
            // newCategoryFieldPanel
            // 
            newCategoryFieldPanel.Controls.Add(_newCategoryInput);
            newCategoryFieldPanel.Controls.Add(newCategoryLabel);
            newCategoryFieldPanel.Location = new Point(871, 3);
            newCategoryFieldPanel.Name = "newCategoryFieldPanel";
            newCategoryFieldPanel.Size = new Size(158, 62);
            newCategoryFieldPanel.TabIndex = 4;
            // 
            // _newCategoryInput
            // 
            _newCategoryInput.Location = new Point(0, 22);
            _newCategoryInput.Name = "_newCategoryInput";
            _newCategoryInput.Size = new Size(150, 27);
            _newCategoryInput.TabIndex = 1;
            // 
            // newCategoryLabel
            // 
            newCategoryLabel.AutoSize = true;
            newCategoryLabel.ForeColor = Color.FromArgb(90, 100, 112);
            newCategoryLabel.Location = new Point(2, 0);
            newCategoryLabel.Name = "newCategoryLabel";
            newCategoryLabel.Size = new Size(106, 20);
            newCategoryLabel.TabIndex = 0;
            newCategoryLabel.Text = "Danh mục mới";
            // 
            // addCategoryButton
            // 
            addCategoryButton.AutoSize = true;
            addCategoryButton.BackColor = Color.FromArgb(90, 105, 120);
            addCategoryButton.ForeColor = Color.White;
            addCategoryButton.Location = new Point(1035, 3);
            addCategoryButton.Name = "addCategoryButton";
            addCategoryButton.Size = new Size(128, 30);
            addCategoryButton.TabIndex = 5;
            addCategoryButton.Text = "Thêm danh mục";
            addCategoryButton.UseVisualStyleBackColor = false;
            // 
            // _menuGrid
            // 
            _menuGrid.AllowUserToAddRows = false;
            _menuGrid.AllowUserToDeleteRows = false;
            _menuGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _menuGrid.BackgroundColor = Color.White;
            _menuGrid.BorderStyle = BorderStyle.None;
            _menuGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _menuGrid.Dock = DockStyle.Fill;
            _menuGrid.Location = new Point(3, 185);
            _menuGrid.MultiSelect = false;
            _menuGrid.Name = "_menuGrid";
            _menuGrid.ReadOnly = true;
            _menuGrid.RowHeadersVisible = false;
            _menuGrid.RowHeadersWidth = 51;
            _menuGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _menuGrid.Size = new Size(1238, 431);
            _menuGrid.TabIndex = 2;
            // 
            // menuHintLabel
            // 
            menuHintLabel.Location = new Point(0, 0);
            menuHintLabel.Name = "menuHintLabel";
            menuHintLabel.Size = new Size(100, 23);
            menuHintLabel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 760);
            Controls.Add(mainTabs);
            Controls.Add(headerPanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafe POS | Quản lý quán cafe";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainTabs.ResumeLayout(false);
            posTabPage.ResumeLayout(false);
            posSplitContainer.Panel1.ResumeLayout(false);
            posSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)posSplitContainer).EndInit();
            posSplitContainer.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableHeadingPanel.ResumeLayout(false);
            tableHeadingPanel.PerformLayout();
            _tablePanel.ResumeLayout(false);
            orderLayoutPanel.ResumeLayout(false);
            orderEditorPanel.ResumeLayout(false);
            orderEditorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_orderQuantityInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)_orderGrid).EndInit();
            footerPanel.ResumeLayout(false);
            orderActionsPanel.ResumeLayout(false);
            orderActionsPanel.PerformLayout();
            menuTabPage.ResumeLayout(false);
            menuLayoutPanel.ResumeLayout(false);
            menuEditorPanel.ResumeLayout(false);
            menuEditorPanel.PerformLayout();
            menuNameFieldPanel.ResumeLayout(false);
            menuNameFieldPanel.PerformLayout();
            menuCategoryFieldPanel.ResumeLayout(false);
            menuCategoryFieldPanel.PerformLayout();
            menuPriceFieldPanel.ResumeLayout(false);
            menuPriceFieldPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_menuPriceInput).EndInit();
            menuActionsPanel.ResumeLayout(false);
            menuActionsPanel.PerformLayout();
            newCategoryFieldPanel.ResumeLayout(false);
            newCategoryFieldPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_menuGrid).EndInit();
            ResumeLayout(false);
        }
    }
}