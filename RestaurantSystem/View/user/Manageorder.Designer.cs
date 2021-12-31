namespace RestaurantSystem.View.user
{
    partial class Manageorder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manageorder));
            this.tabControlPrint = new System.Windows.Forms.TabControl();
            this.tabManageOrder = new System.Windows.Forms.TabPage();
            this.dataGridViewOrder = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewOrders = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.BillColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBillNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewTempCart = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.TempID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tabControlPrint.SuspendLayout();
            this.tabManageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTempCart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrint
            // 
            this.tabControlPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPrint.Controls.Add(this.tabManageOrder);
            this.tabControlPrint.Controls.Add(this.tabPage2);
            this.tabControlPrint.Controls.Add(this.tabPage1);
            this.tabControlPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPrint.Location = new System.Drawing.Point(24, 57);
            this.tabControlPrint.Name = "tabControlPrint";
            this.tabControlPrint.SelectedIndex = 0;
            this.tabControlPrint.Size = new System.Drawing.Size(881, 505);
            this.tabControlPrint.TabIndex = 0;
            // 
            // tabManageOrder
            // 
            this.tabManageOrder.BackColor = System.Drawing.Color.Transparent;
            this.tabManageOrder.Controls.Add(this.dataGridViewOrder);
            this.tabManageOrder.Controls.Add(this.label2);
            this.tabManageOrder.Controls.Add(this.txtBillNumber);
            this.tabManageOrder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabManageOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManageOrder.Location = new System.Drawing.Point(4, 25);
            this.tabManageOrder.Name = "tabManageOrder";
            this.tabManageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageOrder.Size = new System.Drawing.Size(873, 476);
            this.tabManageOrder.TabIndex = 0;
            this.tabManageOrder.Text = "Manage Order (Print)";
            this.tabManageOrder.Click += new System.EventHandler(this.tabManageOrder_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Product,
            this.Price,
            this.Qty,
            this.SubTotal,
            this.Gross,
            this.Vat,
            this.Discount,
            this.Net,
            this.Print});
            this.dataGridViewOrder.Location = new System.Drawing.Point(44, 134);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.Size = new System.Drawing.Size(789, 294);
            this.dataGridViewOrder.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewOrder.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewOrder.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewOrder.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewOrder.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewOrder.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewOrder.TabIndex = 33;
            this.dataGridViewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "ord_bill_number";
            this.ID.HeaderText = "Bill ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 74;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Product.DataPropertyName = "pro_name";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 86;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Price.DataPropertyName = "pro_price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 69;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Qty.DataPropertyName = "ordit_quantity";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 60;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SubTotal.DataPropertyName = "ordit_amount";
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 92;
            // 
            // Gross
            // 
            this.Gross.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gross.DataPropertyName = "ord_gross_amount";
            this.Gross.HeaderText = "Gross Amt";
            this.Gross.Name = "Gross";
            this.Gross.ReadOnly = true;
            this.Gross.Width = 103;
            // 
            // Vat
            // 
            this.Vat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Vat.DataPropertyName = "ord_vat_amount";
            this.Vat.HeaderText = "VAT";
            this.Vat.Name = "Vat";
            this.Vat.ReadOnly = true;
            this.Vat.Width = 62;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Discount.DataPropertyName = "ord_discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 92;
            // 
            // Net
            // 
            this.Net.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Net.DataPropertyName = "ord_net_amount";
            this.Net.HeaderText = "Net Amt";
            this.Net.Name = "Net";
            this.Net.ReadOnly = true;
            this.Net.Width = 89;
            // 
            // Print
            // 
            this.Print.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Print.DefaultCellStyle = dataGridViewCellStyle1;
            this.Print.HeaderText = "Action";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Print.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Print.Text = "Print";
            this.Print.UseColumnTextForButtonValue = true;
            this.Print.Width = 79;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Search by Bill number";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBillNumber.Location = new System.Drawing.Point(50, 72);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(228, 27);
            this.txtBillNumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBillNumber.StateCommon.Border.Rounding = 6;
            this.txtBillNumber.TabIndex = 31;
            this.txtBillNumber.TextChanged += new System.EventHandler(this.txtBillNumber_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.dataGridViewOrders);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtSearchBillNumber);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(873, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders (Delete)";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillColumn,
            this.GrossColumn,
            this.VatColumn,
            this.DiscountColumn,
            this.NetColumn,
            this.Cashier,
            this.DeleteColumn});
            this.dataGridViewOrders.Location = new System.Drawing.Point(79, 132);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.Size = new System.Drawing.Size(721, 294);
            this.dataGridViewOrders.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewOrders.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewOrders.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewOrders.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewOrders.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewOrders.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewOrders.TabIndex = 36;
            this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellClick);
            // 
            // BillColumn
            // 
            this.BillColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BillColumn.DataPropertyName = "ord_bill_number";
            this.BillColumn.HeaderText = "Bill ID";
            this.BillColumn.Name = "BillColumn";
            this.BillColumn.ReadOnly = true;
            this.BillColumn.Width = 74;
            // 
            // GrossColumn
            // 
            this.GrossColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GrossColumn.DataPropertyName = "ord_gross_amount";
            this.GrossColumn.HeaderText = "Gross Amt";
            this.GrossColumn.Name = "GrossColumn";
            this.GrossColumn.ReadOnly = true;
            this.GrossColumn.Width = 103;
            // 
            // VatColumn
            // 
            this.VatColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VatColumn.DataPropertyName = "ord_vat_amount";
            this.VatColumn.HeaderText = "VAT";
            this.VatColumn.Name = "VatColumn";
            this.VatColumn.ReadOnly = true;
            this.VatColumn.Width = 62;
            // 
            // DiscountColumn
            // 
            this.DiscountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiscountColumn.DataPropertyName = "ord_discount";
            this.DiscountColumn.HeaderText = "Discount";
            this.DiscountColumn.Name = "DiscountColumn";
            this.DiscountColumn.ReadOnly = true;
            this.DiscountColumn.Width = 92;
            // 
            // NetColumn
            // 
            this.NetColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NetColumn.DataPropertyName = "ord_net_amount";
            this.NetColumn.HeaderText = "Net Amt";
            this.NetColumn.Name = "NetColumn";
            this.NetColumn.ReadOnly = true;
            this.NetColumn.Width = 89;
            // 
            // Cashier
            // 
            this.Cashier.DataPropertyName = "Cashier";
            this.Cashier.HeaderText = "Cashier";
            this.Cashier.Name = "Cashier";
            this.Cashier.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteColumn.HeaderText = "Action";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 79;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search by Bill number";
            // 
            // txtSearchBillNumber
            // 
            this.txtSearchBillNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchBillNumber.Location = new System.Drawing.Point(79, 68);
            this.txtSearchBillNumber.Name = "txtSearchBillNumber";
            this.txtSearchBillNumber.Size = new System.Drawing.Size(228, 27);
            this.txtSearchBillNumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchBillNumber.StateCommon.Border.Rounding = 6;
            this.txtSearchBillNumber.TabIndex = 34;
            this.txtSearchBillNumber.TextChanged += new System.EventHandler(this.txtSearchBillNumber_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.dataGridViewTempCart);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(873, 476);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Temp Cart (Restore)";
            // 
            // dataGridViewTempCart
            // 
            this.dataGridViewTempCart.AllowUserToAddRows = false;
            this.dataGridViewTempCart.AllowUserToDeleteRows = false;
            this.dataGridViewTempCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTempCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTempCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TempID,
            this.UniqueID,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.Restore});
            this.dataGridViewTempCart.Location = new System.Drawing.Point(75, 79);
            this.dataGridViewTempCart.Name = "dataGridViewTempCart";
            this.dataGridViewTempCart.ReadOnly = true;
            this.dataGridViewTempCart.Size = new System.Drawing.Size(625, 356);
            this.dataGridViewTempCart.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewTempCart.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewTempCart.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewTempCart.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewTempCart.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewTempCart.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTempCart.TabIndex = 37;
            this.dataGridViewTempCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTempCart_CellClick);
            // 
            // TempID
            // 
            this.TempID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TempID.DataPropertyName = "temp_id";
            this.TempID.HeaderText = "Temp ID";
            this.TempID.Name = "TempID";
            this.TempID.ReadOnly = true;
            this.TempID.Width = 82;
            // 
            // UniqueID
            // 
            this.UniqueID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UniqueID.DataPropertyName = "uniqueID";
            this.UniqueID.HeaderText = "Unique ID";
            this.UniqueID.Name = "UniqueID";
            this.UniqueID.ReadOnly = true;
            this.UniqueID.Width = 91;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductID.DataPropertyName = "pro_id";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 95;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductName.DataPropertyName = "pro_name";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 118;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Quantity.DataPropertyName = "pro_quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 93;
            // 
            // Restore
            // 
            this.Restore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Restore.DefaultCellStyle = dataGridViewCellStyle3;
            this.Restore.HeaderText = "Action";
            this.Restore.Name = "Restore";
            this.Restore.ReadOnly = true;
            this.Restore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Restore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Restore.Text = "Restore";
            this.Restore.UseColumnTextForButtonValue = true;
            this.Restore.Width = 79;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 0;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // Manageorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(935, 588);
            this.Controls.Add(this.tabControlPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Manageorder";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manageorder";
            this.Load += new System.EventHandler(this.Manageorder_Load);
            this.tabControlPrint.ResumeLayout(false);
            this.tabManageOrder.ResumeLayout(false);
            this.tabManageOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTempCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlPrint;
        private System.Windows.Forms.TabPage tabManageOrder;
        private System.Windows.Forms.TabPage tabPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Net;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBillNumber;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewOrders;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchBillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashier;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.TabPage tabPage1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewTempCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn Restore;
    }
}