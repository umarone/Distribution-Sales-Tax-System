namespace Accounts.UI
{
    partial class frmStockReceipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatuMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblVouchersCount = new MetroFramework.Controls.MetroLabel();
            this.lblTotalVouchers = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblLastVoucherNo = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnPrintPurchaseInvoice = new MetroFramework.Controls.MetroTile();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnPrevious = new MetroFramework.Controls.MetroTile();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.tabPurchaseTransactions = new System.Windows.Forms.TabControl();
            this.tabLineItems = new System.Windows.Forms.TabPage();
            this.DgvStockReceipt = new Accounts.UI.TabDataGrid();
            this.ColIdVoucherDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpacking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEngineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChassisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleColors = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colVehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstIMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecondIMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNormalDiscountPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNormalDiscountFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBulkDiscountPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBulkDiscountFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTaxPayable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTaxPayableFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraSalesTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraSalesTaxFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtFreightAmount = new MetroFramework.Controls.MetroTextBox();
            this.lblFreight = new MetroFramework.Controls.MetroLabel();
            this.txtTotalSaleTaxAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtOtherTaxAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtSaleTaxAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtAmountafterDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtBulkDiscount = new MetroFramework.Controls.MetroTextBox();
            this.txtNormalDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtBillAmount = new MetroFramework.Controls.MetroTextBox();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.tabSalesTransactions = new System.Windows.Forms.TabPage();
            this.DgvPurchases = new Accounts.UI.TabDataGrid();
            this.ColIdDetailVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCreditor = new System.Windows.Forms.GroupBox();
            this.flowPurchasesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.txtCashClosingBalance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbxCashAccounts = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxTaxPayables = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbxNaturalAccounts = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddSupplier = new MetroFramework.Controls.MetroButton();
            this.txtCurrentBalance = new MetroFramework.Controls.MetroTextBox();
            this.btnViewDetail = new MetroFramework.Controls.MetroButton();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.SEditBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VDate = new MetroFramework.Controls.MetroDateTime();
            this.VEditBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtSheetNo = new MetroFramework.Controls.MetroTextBox();
            this.lblDiscription = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblBillNo = new MetroFramework.Controls.MetroLabel();
            this.lblVoucherNo = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.chkPosted = new MetroFramework.Controls.MetroCheckBox();
            this.txtBiltyNo = new MetroFramework.Controls.MetroTextBox();
            this.txtBillNo = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.flowMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabPurchaseTransactions.SuspendLayout();
            this.tabLineItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockReceipt)).BeginInit();
            this.tabSalesTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPurchases)).BeginInit();
            this.grpCreditor.SuspendLayout();
            this.flowPurchasesPanel.SuspendLayout();
            this.pnlCash.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatuMessage});
            this.statusStrip1.Location = new System.Drawing.Point(20, 722);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1154, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatuMessage
            // 
            this.lblStatuMessage.Name = "lblStatuMessage";
            this.lblStatuMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.metroPanel1);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnPrintPurchaseInvoice);
            this.pnlButtons.Controls.Add(this.btnNext);
            this.pnlButtons.Controls.Add(this.btnNew);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnPrevious);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Location = new System.Drawing.Point(3, 606);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1175, 48);
            this.pnlButtons.TabIndex = 25;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lblVouchersCount);
            this.metroPanel1.Controls.Add(this.lblTotalVouchers);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.lblLastVoucherNo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 6);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(489, 36);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblVouchersCount
            // 
            this.lblVouchersCount.AutoSize = true;
            this.lblVouchersCount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblVouchersCount.Location = new System.Drawing.Point(2, 4);
            this.lblVouchersCount.Name = "lblVouchersCount";
            this.lblVouchersCount.Size = new System.Drawing.Size(107, 19);
            this.lblVouchersCount.TabIndex = 2;
            this.lblVouchersCount.Text = "Total Vouchers :";
            // 
            // lblTotalVouchers
            // 
            this.lblTotalVouchers.AutoSize = true;
            this.lblTotalVouchers.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalVouchers.Location = new System.Drawing.Point(110, 6);
            this.lblTotalVouchers.Name = "lblTotalVouchers";
            this.lblTotalVouchers.Size = new System.Drawing.Size(17, 19);
            this.lblTotalVouchers.TabIndex = 2;
            this.lblTotalVouchers.Text = "0";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(236, 6);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(118, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Last Voucher No :";
            // 
            // lblLastVoucherNo
            // 
            this.lblLastVoucherNo.AutoSize = true;
            this.lblLastVoucherNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLastVoucherNo.Location = new System.Drawing.Point(365, 6);
            this.lblLastVoucherNo.Name = "lblLastVoucherNo";
            this.lblLastVoucherNo.Size = new System.Drawing.Size(17, 19);
            this.lblLastVoucherNo.TabIndex = 2;
            this.lblLastVoucherNo.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Location = new System.Drawing.Point(819, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 40);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrintPurchaseInvoice
            // 
            this.btnPrintPurchaseInvoice.ActiveControl = null;
            this.btnPrintPurchaseInvoice.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPrintPurchaseInvoice.Location = new System.Drawing.Point(735, 3);
            this.btnPrintPurchaseInvoice.Name = "btnPrintPurchaseInvoice";
            this.btnPrintPurchaseInvoice.Size = new System.Drawing.Size(83, 40);
            this.btnPrintPurchaseInvoice.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnPrintPurchaseInvoice.TabIndex = 15;
            this.btnPrintPurchaseInvoice.Text = "Print";
            this.btnPrintPurchaseInvoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintPurchaseInvoice.UseCustomBackColor = true;
            this.btnPrintPurchaseInvoice.UseSelectable = true;
            this.btnPrintPurchaseInvoice.Click += new System.EventHandler(this.btnPrintPurchaseInvoice_Click);
            // 
            // btnNext
            // 
            this.btnNext.ActiveControl = null;
            this.btnNext.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNext.Location = new System.Drawing.Point(651, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 40);
            this.btnNext.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNew
            // 
            this.btnNew.ActiveControl = null;
            this.btnNew.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNew.Location = new System.Drawing.Point(1071, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 40);
            this.btnNew.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New Voucher";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.UseCustomBackColor = true;
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.Location = new System.Drawing.Point(903, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 40);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.ActiveControl = null;
            this.btnPrevious.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPrevious.Location = new System.Drawing.Point(567, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(83, 40);
            this.btnPrevious.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrevious.UseCustomBackColor = true;
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClose.Location = new System.Drawing.Point(987, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 40);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabPurchaseTransactions
            // 
            this.tabPurchaseTransactions.Controls.Add(this.tabLineItems);
            this.tabPurchaseTransactions.Controls.Add(this.tabSalesTransactions);
            this.tabPurchaseTransactions.Location = new System.Drawing.Point(3, 136);
            this.tabPurchaseTransactions.Name = "tabPurchaseTransactions";
            this.tabPurchaseTransactions.SelectedIndex = 0;
            this.tabPurchaseTransactions.Size = new System.Drawing.Size(1175, 464);
            this.tabPurchaseTransactions.TabIndex = 3;
            this.tabPurchaseTransactions.SelectedIndexChanged += new System.EventHandler(this.tabPurchaseTransactions_SelectedIndexChanged);
            // 
            // tabLineItems
            // 
            this.tabLineItems.Controls.Add(this.DgvStockReceipt);
            this.tabLineItems.Controls.Add(this.txtTotalAmount);
            this.tabLineItems.Controls.Add(this.metroLabel6);
            this.tabLineItems.Controls.Add(this.txtFreightAmount);
            this.tabLineItems.Controls.Add(this.lblFreight);
            this.tabLineItems.Controls.Add(this.txtTotalSaleTaxAmount);
            this.tabLineItems.Controls.Add(this.metroLabel14);
            this.tabLineItems.Controls.Add(this.txtOtherTaxAmount);
            this.tabLineItems.Controls.Add(this.metroLabel12);
            this.tabLineItems.Controls.Add(this.txtSaleTaxAmount);
            this.tabLineItems.Controls.Add(this.metroLabel11);
            this.tabLineItems.Controls.Add(this.txtAmountafterDiscount);
            this.tabLineItems.Controls.Add(this.metroLabel10);
            this.tabLineItems.Controls.Add(this.txtBulkDiscount);
            this.tabLineItems.Controls.Add(this.txtNormalDiscount);
            this.tabLineItems.Controls.Add(this.metroLabel13);
            this.tabLineItems.Controls.Add(this.metroLabel9);
            this.tabLineItems.Controls.Add(this.txtBillAmount);
            this.tabLineItems.Controls.Add(this.lblTotal);
            this.tabLineItems.Location = new System.Drawing.Point(4, 25);
            this.tabLineItems.Name = "tabLineItems";
            this.tabLineItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabLineItems.Size = new System.Drawing.Size(1167, 435);
            this.tabLineItems.TabIndex = 0;
            this.tabLineItems.Text = "Line Items";
            this.tabLineItems.UseVisualStyleBackColor = true;
            // 
            // DgvStockReceipt
            // 
            this.DgvStockReceipt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvStockReceipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvStockReceipt.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStockReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvStockReceipt.ColumnHeadersHeight = 52;
            this.DgvStockReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdVoucherDetail,
            this.colIdItem,
            this.colItemNo,
            this.colItemName,
            this.colpacking,
            this.colDiemension,
            this.colCartons,
            this.colBatchNo,
            this.colExpiry,
            this.colEngineNo,
            this.colChassisNo,
            this.colVehicleModel,
            this.colVehicleColors,
            this.colVehicleNo,
            this.colFirstIMEI,
            this.colSecondIMEI,
            this.colQty,
            this.colBonus,
            this.colUnitPrice,
            this.colAmount,
            this.colNormalDiscountPercentage,
            this.colNormalDiscountFlat,
            this.colBulkDiscountPercentage,
            this.colBulkDiscountFlat,
            this.colDiscountAmount,
            this.colSaleTaxPayable,
            this.colSaleTaxPayableFlat,
            this.colExtraSalesTax,
            this.colExtraSalesTaxFlat,
            this.colNetAmount,
            this.colDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStockReceipt.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvStockReceipt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvStockReceipt.EnableHeadersVisualStyles = false;
            this.DgvStockReceipt.Location = new System.Drawing.Point(6, 8);
            this.DgvStockReceipt.MultiSelect = false;
            this.DgvStockReceipt.Name = "DgvStockReceipt";
            this.DgvStockReceipt.RowHeadersVisible = false;
            this.DgvStockReceipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvStockReceipt.Size = new System.Drawing.Size(1158, 290);
            this.DgvStockReceipt.TabIndex = 1;
            this.DgvStockReceipt.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DgvStockReceipt_CellBeginEdit);
            this.DgvStockReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockReceipt_CellClick);
            this.DgvStockReceipt.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockReceipt_CellEndEdit);
            this.DgvStockReceipt.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvStockReceipt_CellFormatting);
            this.DgvStockReceipt.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockReceipt_CellLeave);
            this.DgvStockReceipt.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvStockReceipt_CurrentCellDirtyStateChanged);
            this.DgvStockReceipt.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvStockReceipt_EditingControlShowing);
            this.DgvStockReceipt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvStockReceipt_KeyPress);
            // 
            // ColIdVoucherDetail
            // 
            this.ColIdVoucherDetail.HeaderText = "IdVoucherDetail";
            this.ColIdVoucherDetail.Name = "ColIdVoucherDetail";
            this.ColIdVoucherDetail.Visible = false;
            // 
            // colIdItem
            // 
            this.colIdItem.HeaderText = "IdItem";
            this.colIdItem.Name = "colIdItem";
            this.colIdItem.Visible = false;
            // 
            // colItemNo
            // 
            this.colItemNo.DataPropertyName = "AccountNo";
            this.colItemNo.HeaderText = "Product Code";
            this.colItemNo.Name = "colItemNo";
            this.colItemNo.Visible = false;
            // 
            // colItemName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colItemName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colItemName.HeaderText = "Product Discription";
            this.colItemName.Name = "colItemName";
            this.colItemName.Width = 180;
            // 
            // colpacking
            // 
            this.colpacking.HeaderText = "UOM";
            this.colpacking.Name = "colpacking";
            this.colpacking.ReadOnly = true;
            this.colpacking.Width = 90;
            // 
            // colDiemension
            // 
            this.colDiemension.HeaderText = "Dims";
            this.colDiemension.Name = "colDiemension";
            this.colDiemension.ReadOnly = true;
            this.colDiemension.Width = 58;
            // 
            // colCartons
            // 
            this.colCartons.HeaderText = "CTN";
            this.colCartons.Name = "colCartons";
            this.colCartons.Width = 90;
            // 
            // colBatchNo
            // 
            this.colBatchNo.HeaderText = "BatchNo";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.Width = 90;
            // 
            // colExpiry
            // 
            this.colExpiry.HeaderText = "Expiry";
            this.colExpiry.Name = "colExpiry";
            this.colExpiry.Width = 90;
            // 
            // colEngineNo
            // 
            this.colEngineNo.HeaderText = "Engine #";
            this.colEngineNo.Name = "colEngineNo";
            this.colEngineNo.Width = 80;
            // 
            // colChassisNo
            // 
            this.colChassisNo.HeaderText = "Chassis #";
            this.colChassisNo.Name = "colChassisNo";
            this.colChassisNo.Width = 80;
            // 
            // colVehicleModel
            // 
            this.colVehicleModel.HeaderText = "Model";
            this.colVehicleModel.Name = "colVehicleModel";
            this.colVehicleModel.Width = 80;
            // 
            // colVehicleColors
            // 
            this.colVehicleColors.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colVehicleColors.HeaderText = "Color";
            this.colVehicleColors.Items.AddRange(new object[] {
            "",
            "Red",
            "Black",
            "Blue",
            "Silver"});
            this.colVehicleColors.Name = "colVehicleColors";
            this.colVehicleColors.Width = 80;
            // 
            // colVehicleNo
            // 
            this.colVehicleNo.HeaderText = "Vehicle #";
            this.colVehicleNo.Name = "colVehicleNo";
            this.colVehicleNo.Width = 90;
            // 
            // colFirstIMEI
            // 
            this.colFirstIMEI.HeaderText = "IMEI #";
            this.colFirstIMEI.Name = "colFirstIMEI";
            // 
            // colSecondIMEI
            // 
            this.colSecondIMEI.HeaderText = "Second IMEI";
            this.colSecondIMEI.Name = "colSecondIMEI";
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Qty (CTN)";
            this.colQty.Name = "colQty";
            this.colQty.Width = 60;
            // 
            // colBonus
            // 
            this.colBonus.HeaderText = "Bonus";
            this.colBonus.Name = "colBonus";
            this.colBonus.Visible = false;
            this.colBonus.Width = 80;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "Amount";
            this.colUnitPrice.HeaderText = "T.P";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 50;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "qty*amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAmount.Width = 70;
            // 
            // colNormalDiscountPercentage
            // 
            this.colNormalDiscountPercentage.HeaderText = "Normal Disc(%)";
            this.colNormalDiscountPercentage.Name = "colNormalDiscountPercentage";
            this.colNormalDiscountPercentage.Width = 73;
            // 
            // colNormalDiscountFlat
            // 
            this.colNormalDiscountFlat.HeaderText = "Discount Flat";
            this.colNormalDiscountFlat.Name = "colNormalDiscountFlat";
            this.colNormalDiscountFlat.ReadOnly = true;
            this.colNormalDiscountFlat.Width = 62;
            // 
            // colBulkDiscountPercentage
            // 
            this.colBulkDiscountPercentage.HeaderText = "Bulk Disc(%)";
            this.colBulkDiscountPercentage.Name = "colBulkDiscountPercentage";
            this.colBulkDiscountPercentage.Width = 68;
            // 
            // colBulkDiscountFlat
            // 
            this.colBulkDiscountFlat.HeaderText = "Bulk Flat";
            this.colBulkDiscountFlat.Name = "colBulkDiscountFlat";
            this.colBulkDiscountFlat.ReadOnly = true;
            this.colBulkDiscountFlat.Width = 58;
            // 
            // colDiscountAmount
            // 
            this.colDiscountAmount.HeaderText = "Amount Excluding Taxes";
            this.colDiscountAmount.Name = "colDiscountAmount";
            this.colDiscountAmount.ReadOnly = true;
            this.colDiscountAmount.Width = 70;
            // 
            // colSaleTaxPayable
            // 
            this.colSaleTaxPayable.HeaderText = "Sale Tax(%)";
            this.colSaleTaxPayable.Name = "colSaleTaxPayable";
            this.colSaleTaxPayable.Width = 60;
            // 
            // colSaleTaxPayableFlat
            // 
            this.colSaleTaxPayableFlat.HeaderText = "Sales Tax Flat";
            this.colSaleTaxPayableFlat.Name = "colSaleTaxPayableFlat";
            this.colSaleTaxPayableFlat.ReadOnly = true;
            this.colSaleTaxPayableFlat.Width = 65;
            // 
            // colExtraSalesTax
            // 
            this.colExtraSalesTax.HeaderText = "Other Tax(%)";
            this.colExtraSalesTax.Name = "colExtraSalesTax";
            this.colExtraSalesTax.Width = 60;
            // 
            // colExtraSalesTaxFlat
            // 
            this.colExtraSalesTaxFlat.HeaderText = "Other Tax Flat";
            this.colExtraSalesTaxFlat.Name = "colExtraSalesTaxFlat";
            this.colExtraSalesTaxFlat.ReadOnly = true;
            this.colExtraSalesTaxFlat.Width = 65;
            // 
            // colNetAmount
            // 
            this.colNetAmount.HeaderText = "Amount Including Taxes";
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.ReadOnly = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDelete.HeaderText = "...";
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 50;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtTotalAmount.CustomButton.Image = null;
            this.txtTotalAmount.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtTotalAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalAmount.CustomButton.Name = "";
            this.txtTotalAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalAmount.CustomButton.TabIndex = 1;
            this.txtTotalAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalAmount.CustomButton.UseSelectable = true;
            this.txtTotalAmount.CustomButton.Visible = false;
            this.txtTotalAmount.Lines = new string[0];
            this.txtTotalAmount.Location = new System.Drawing.Point(1032, 404);
            this.txtTotalAmount.MaxLength = 32767;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.SelectionLength = 0;
            this.txtTotalAmount.SelectionStart = 0;
            this.txtTotalAmount.ShortcutsEnabled = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(132, 23);
            this.txtTotalAmount.TabIndex = 22;
            this.txtTotalAmount.UseCustomBackColor = true;
            this.txtTotalAmount.UseSelectable = true;
            this.txtTotalAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(898, 403);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(102, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Final Amount : ";
            // 
            // txtFreightAmount
            // 
            this.txtFreightAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtFreightAmount.CustomButton.Image = null;
            this.txtFreightAmount.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtFreightAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtFreightAmount.CustomButton.Name = "";
            this.txtFreightAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFreightAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFreightAmount.CustomButton.TabIndex = 1;
            this.txtFreightAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFreightAmount.CustomButton.UseSelectable = true;
            this.txtFreightAmount.CustomButton.Visible = false;
            this.txtFreightAmount.Lines = new string[0];
            this.txtFreightAmount.Location = new System.Drawing.Point(1032, 379);
            this.txtFreightAmount.MaxLength = 32767;
            this.txtFreightAmount.Name = "txtFreightAmount";
            this.txtFreightAmount.PasswordChar = '\0';
            this.txtFreightAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFreightAmount.SelectedText = "";
            this.txtFreightAmount.SelectionLength = 0;
            this.txtFreightAmount.SelectionStart = 0;
            this.txtFreightAmount.ShortcutsEnabled = true;
            this.txtFreightAmount.Size = new System.Drawing.Size(132, 23);
            this.txtFreightAmount.TabIndex = 22;
            this.txtFreightAmount.UseCustomBackColor = true;
            this.txtFreightAmount.UseSelectable = true;
            this.txtFreightAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFreightAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFreightAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFreigh_KeyPress);
            this.txtFreightAmount.Leave += new System.EventHandler(this.txtFreightAmount_Leave);
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFreight.Location = new System.Drawing.Point(896, 382);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(113, 19);
            this.lblFreight.TabIndex = 24;
            this.lblFreight.Text = "Freight Amount :";
            // 
            // txtTotalSaleTaxAmount
            // 
            this.txtTotalSaleTaxAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtTotalSaleTaxAmount.CustomButton.Image = null;
            this.txtTotalSaleTaxAmount.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtTotalSaleTaxAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalSaleTaxAmount.CustomButton.Name = "";
            this.txtTotalSaleTaxAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalSaleTaxAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalSaleTaxAmount.CustomButton.TabIndex = 1;
            this.txtTotalSaleTaxAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalSaleTaxAmount.CustomButton.UseSelectable = true;
            this.txtTotalSaleTaxAmount.CustomButton.Visible = false;
            this.txtTotalSaleTaxAmount.Lines = new string[0];
            this.txtTotalSaleTaxAmount.Location = new System.Drawing.Point(1031, 355);
            this.txtTotalSaleTaxAmount.MaxLength = 32767;
            this.txtTotalSaleTaxAmount.Name = "txtTotalSaleTaxAmount";
            this.txtTotalSaleTaxAmount.PasswordChar = '\0';
            this.txtTotalSaleTaxAmount.ReadOnly = true;
            this.txtTotalSaleTaxAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalSaleTaxAmount.SelectedText = "";
            this.txtTotalSaleTaxAmount.SelectionLength = 0;
            this.txtTotalSaleTaxAmount.SelectionStart = 0;
            this.txtTotalSaleTaxAmount.ShortcutsEnabled = true;
            this.txtTotalSaleTaxAmount.Size = new System.Drawing.Size(133, 23);
            this.txtTotalSaleTaxAmount.TabIndex = 22;
            this.txtTotalSaleTaxAmount.UseCustomBackColor = true;
            this.txtTotalSaleTaxAmount.UseSelectable = true;
            this.txtTotalSaleTaxAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalSaleTaxAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(896, 356);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(115, 19);
            this.metroLabel14.TabIndex = 24;
            this.metroLabel14.Text = "Taxable Amount :";
            // 
            // txtOtherTaxAmount
            // 
            this.txtOtherTaxAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtOtherTaxAmount.CustomButton.Image = null;
            this.txtOtherTaxAmount.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtOtherTaxAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtOtherTaxAmount.CustomButton.Name = "";
            this.txtOtherTaxAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOtherTaxAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOtherTaxAmount.CustomButton.TabIndex = 1;
            this.txtOtherTaxAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOtherTaxAmount.CustomButton.UseSelectable = true;
            this.txtOtherTaxAmount.CustomButton.Visible = false;
            this.txtOtherTaxAmount.Lines = new string[0];
            this.txtOtherTaxAmount.Location = new System.Drawing.Point(1031, 330);
            this.txtOtherTaxAmount.MaxLength = 32767;
            this.txtOtherTaxAmount.Name = "txtOtherTaxAmount";
            this.txtOtherTaxAmount.PasswordChar = '\0';
            this.txtOtherTaxAmount.ReadOnly = true;
            this.txtOtherTaxAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOtherTaxAmount.SelectedText = "";
            this.txtOtherTaxAmount.SelectionLength = 0;
            this.txtOtherTaxAmount.SelectionStart = 0;
            this.txtOtherTaxAmount.ShortcutsEnabled = true;
            this.txtOtherTaxAmount.Size = new System.Drawing.Size(133, 23);
            this.txtOtherTaxAmount.TabIndex = 22;
            this.txtOtherTaxAmount.UseCustomBackColor = true;
            this.txtOtherTaxAmount.UseSelectable = true;
            this.txtOtherTaxAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOtherTaxAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(896, 332);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(130, 19);
            this.metroLabel12.TabIndex = 24;
            this.metroLabel12.Text = "Other Tax Amount :";
            // 
            // txtSaleTaxAmount
            // 
            this.txtSaleTaxAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtSaleTaxAmount.CustomButton.Image = null;
            this.txtSaleTaxAmount.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtSaleTaxAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaleTaxAmount.CustomButton.Name = "";
            this.txtSaleTaxAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSaleTaxAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSaleTaxAmount.CustomButton.TabIndex = 1;
            this.txtSaleTaxAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSaleTaxAmount.CustomButton.UseSelectable = true;
            this.txtSaleTaxAmount.CustomButton.Visible = false;
            this.txtSaleTaxAmount.Lines = new string[0];
            this.txtSaleTaxAmount.Location = new System.Drawing.Point(1031, 306);
            this.txtSaleTaxAmount.MaxLength = 32767;
            this.txtSaleTaxAmount.Name = "txtSaleTaxAmount";
            this.txtSaleTaxAmount.PasswordChar = '\0';
            this.txtSaleTaxAmount.ReadOnly = true;
            this.txtSaleTaxAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSaleTaxAmount.SelectedText = "";
            this.txtSaleTaxAmount.SelectionLength = 0;
            this.txtSaleTaxAmount.SelectionStart = 0;
            this.txtSaleTaxAmount.ShortcutsEnabled = true;
            this.txtSaleTaxAmount.Size = new System.Drawing.Size(133, 23);
            this.txtSaleTaxAmount.TabIndex = 22;
            this.txtSaleTaxAmount.UseCustomBackColor = true;
            this.txtSaleTaxAmount.UseSelectable = true;
            this.txtSaleTaxAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSaleTaxAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(899, 306);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(124, 19);
            this.metroLabel11.TabIndex = 24;
            this.metroLabel11.Text = "Sales Tax Amount :";
            // 
            // txtAmountafterDiscount
            // 
            this.txtAmountafterDiscount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtAmountafterDiscount.CustomButton.Image = null;
            this.txtAmountafterDiscount.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtAmountafterDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountafterDiscount.CustomButton.Name = "";
            this.txtAmountafterDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmountafterDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmountafterDiscount.CustomButton.TabIndex = 1;
            this.txtAmountafterDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmountafterDiscount.CustomButton.UseSelectable = true;
            this.txtAmountafterDiscount.CustomButton.Visible = false;
            this.txtAmountafterDiscount.Lines = new string[0];
            this.txtAmountafterDiscount.Location = new System.Drawing.Point(143, 378);
            this.txtAmountafterDiscount.MaxLength = 32767;
            this.txtAmountafterDiscount.Name = "txtAmountafterDiscount";
            this.txtAmountafterDiscount.PasswordChar = '\0';
            this.txtAmountafterDiscount.ReadOnly = true;
            this.txtAmountafterDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmountafterDiscount.SelectedText = "";
            this.txtAmountafterDiscount.SelectionLength = 0;
            this.txtAmountafterDiscount.SelectionStart = 0;
            this.txtAmountafterDiscount.ShortcutsEnabled = true;
            this.txtAmountafterDiscount.Size = new System.Drawing.Size(165, 23);
            this.txtAmountafterDiscount.TabIndex = 22;
            this.txtAmountafterDiscount.UseCustomBackColor = true;
            this.txtAmountafterDiscount.UseSelectable = true;
            this.txtAmountafterDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmountafterDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(9, 379);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(129, 19);
            this.metroLabel10.TabIndex = 24;
            this.metroLabel10.Text = "Amount After Disc :";
            // 
            // txtBulkDiscount
            // 
            this.txtBulkDiscount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtBulkDiscount.CustomButton.Image = null;
            this.txtBulkDiscount.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtBulkDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtBulkDiscount.CustomButton.Name = "";
            this.txtBulkDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBulkDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBulkDiscount.CustomButton.TabIndex = 1;
            this.txtBulkDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBulkDiscount.CustomButton.UseSelectable = true;
            this.txtBulkDiscount.CustomButton.Visible = false;
            this.txtBulkDiscount.Lines = new string[0];
            this.txtBulkDiscount.Location = new System.Drawing.Point(143, 354);
            this.txtBulkDiscount.MaxLength = 32767;
            this.txtBulkDiscount.Name = "txtBulkDiscount";
            this.txtBulkDiscount.PasswordChar = '\0';
            this.txtBulkDiscount.ReadOnly = true;
            this.txtBulkDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBulkDiscount.SelectedText = "";
            this.txtBulkDiscount.SelectionLength = 0;
            this.txtBulkDiscount.SelectionStart = 0;
            this.txtBulkDiscount.ShortcutsEnabled = true;
            this.txtBulkDiscount.Size = new System.Drawing.Size(165, 23);
            this.txtBulkDiscount.TabIndex = 22;
            this.txtBulkDiscount.UseCustomBackColor = true;
            this.txtBulkDiscount.UseSelectable = true;
            this.txtBulkDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBulkDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNormalDiscount
            // 
            this.txtNormalDiscount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtNormalDiscount.CustomButton.Image = null;
            this.txtNormalDiscount.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtNormalDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtNormalDiscount.CustomButton.Name = "";
            this.txtNormalDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNormalDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNormalDiscount.CustomButton.TabIndex = 1;
            this.txtNormalDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNormalDiscount.CustomButton.UseSelectable = true;
            this.txtNormalDiscount.CustomButton.Visible = false;
            this.txtNormalDiscount.Lines = new string[0];
            this.txtNormalDiscount.Location = new System.Drawing.Point(143, 330);
            this.txtNormalDiscount.MaxLength = 32767;
            this.txtNormalDiscount.Name = "txtNormalDiscount";
            this.txtNormalDiscount.PasswordChar = '\0';
            this.txtNormalDiscount.ReadOnly = true;
            this.txtNormalDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNormalDiscount.SelectedText = "";
            this.txtNormalDiscount.SelectionLength = 0;
            this.txtNormalDiscount.SelectionStart = 0;
            this.txtNormalDiscount.ShortcutsEnabled = true;
            this.txtNormalDiscount.Size = new System.Drawing.Size(165, 23);
            this.txtNormalDiscount.TabIndex = 22;
            this.txtNormalDiscount.UseCustomBackColor = true;
            this.txtNormalDiscount.UseSelectable = true;
            this.txtNormalDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNormalDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(9, 354);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(100, 19);
            this.metroLabel13.TabIndex = 24;
            this.metroLabel13.Text = "Bulk Discount :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(10, 331);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(119, 19);
            this.metroLabel9.TabIndex = 24;
            this.metroLabel9.Text = "Normal Discount :";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtBillAmount.CustomButton.Image = null;
            this.txtBillAmount.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtBillAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillAmount.CustomButton.Name = "";
            this.txtBillAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBillAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBillAmount.CustomButton.TabIndex = 1;
            this.txtBillAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBillAmount.CustomButton.UseSelectable = true;
            this.txtBillAmount.CustomButton.Visible = false;
            this.txtBillAmount.Lines = new string[0];
            this.txtBillAmount.Location = new System.Drawing.Point(143, 306);
            this.txtBillAmount.MaxLength = 32767;
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.PasswordChar = '\0';
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillAmount.SelectedText = "";
            this.txtBillAmount.SelectionLength = 0;
            this.txtBillAmount.SelectionStart = 0;
            this.txtBillAmount.ShortcutsEnabled = true;
            this.txtBillAmount.Size = new System.Drawing.Size(165, 23);
            this.txtBillAmount.TabIndex = 22;
            this.txtBillAmount.UseCustomBackColor = true;
            this.txtBillAmount.UseSelectable = true;
            this.txtBillAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBillAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotal.Location = new System.Drawing.Point(10, 307);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 19);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Bill Amount :";
            // 
            // tabSalesTransactions
            // 
            this.tabSalesTransactions.Controls.Add(this.DgvPurchases);
            this.tabSalesTransactions.Location = new System.Drawing.Point(4, 25);
            this.tabSalesTransactions.Name = "tabSalesTransactions";
            this.tabSalesTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalesTransactions.Size = new System.Drawing.Size(1167, 435);
            this.tabSalesTransactions.TabIndex = 1;
            this.tabSalesTransactions.Text = "Transactions";
            this.tabSalesTransactions.UseVisualStyleBackColor = true;
            // 
            // DgvPurchases
            // 
            this.DgvPurchases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvPurchases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvPurchases.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvPurchases.ColumnHeadersHeight = 25;
            this.DgvPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdDetailVoucher,
            this.colIdAccount,
            this.colAccountNo,
            this.colAccountName,
            this.colClosingBalance,
            this.colDescription,
            this.colDebit,
            this.colCredit});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPurchases.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvPurchases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvPurchases.EnableHeadersVisualStyles = false;
            this.DgvPurchases.Location = new System.Drawing.Point(4, 6);
            this.DgvPurchases.MultiSelect = false;
            this.DgvPurchases.Name = "DgvPurchases";
            this.DgvPurchases.RowHeadersVisible = false;
            this.DgvPurchases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvPurchases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvPurchases.Size = new System.Drawing.Size(1157, 423);
            this.DgvPurchases.TabIndex = 26;
            this.DgvPurchases.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPurchases_CellEndEdit);
            this.DgvPurchases.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPurchases_CellLeave);
            this.DgvPurchases.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvPurchases_EditingControlShowing);
            // 
            // ColIdDetailVoucher
            // 
            this.ColIdDetailVoucher.HeaderText = "VoucherDetailId";
            this.ColIdDetailVoucher.Name = "ColIdDetailVoucher";
            this.ColIdDetailVoucher.Visible = false;
            // 
            // colIdAccount
            // 
            this.colIdAccount.HeaderText = "AccountId";
            this.colIdAccount.Name = "colIdAccount";
            this.colIdAccount.Visible = false;
            // 
            // colAccountNo
            // 
            this.colAccountNo.DataPropertyName = "AccountNo";
            this.colAccountNo.HeaderText = "Acc. #";
            this.colAccountNo.Name = "colAccountNo";
            this.colAccountNo.Visible = false;
            // 
            // colAccountName
            // 
            this.colAccountName.HeaderText = "A/C Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Width = 250;
            // 
            // colClosingBalance
            // 
            this.colClosingBalance.HeaderText = "Closing Balance";
            this.colClosingBalance.Name = "colClosingBalance";
            this.colClosingBalance.Width = 120;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Narration";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 385;
            // 
            // colDebit
            // 
            this.colDebit.HeaderText = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Width = 120;
            // 
            // colCredit
            // 
            this.colCredit.HeaderText = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Width = 120;
            // 
            // grpCreditor
            // 
            this.grpCreditor.BackColor = System.Drawing.Color.MistyRose;
            this.grpCreditor.Controls.Add(this.flowPurchasesPanel);
            this.grpCreditor.Controls.Add(this.btnAddSupplier);
            this.grpCreditor.Controls.Add(this.txtCurrentBalance);
            this.grpCreditor.Controls.Add(this.btnViewDetail);
            this.grpCreditor.Controls.Add(this.txtContact);
            this.grpCreditor.Controls.Add(this.SEditBox);
            this.grpCreditor.Controls.Add(this.metroLabel2);
            this.grpCreditor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreditor.Location = new System.Drawing.Point(3, 83);
            this.grpCreditor.Name = "grpCreditor";
            this.grpCreditor.Size = new System.Drawing.Size(1175, 47);
            this.grpCreditor.TabIndex = 0;
            this.grpCreditor.TabStop = false;
            this.grpCreditor.Text = "Supplier Information";
            // 
            // flowPurchasesPanel
            // 
            this.flowPurchasesPanel.Controls.Add(this.pnlCash);
            this.flowPurchasesPanel.Controls.Add(this.panel2);
            this.flowPurchasesPanel.Location = new System.Drawing.Point(883, 13);
            this.flowPurchasesPanel.Name = "flowPurchasesPanel";
            this.flowPurchasesPanel.Size = new System.Drawing.Size(153, 27);
            this.flowPurchasesPanel.TabIndex = 10;
            this.flowPurchasesPanel.Visible = false;
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.txtCashClosingBalance);
            this.pnlCash.Controls.Add(this.metroLabel3);
            this.pnlCash.Controls.Add(this.cbxCashAccounts);
            this.pnlCash.Location = new System.Drawing.Point(3, 3);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(144, 23);
            this.pnlCash.TabIndex = 10;
            // 
            // txtCashClosingBalance
            // 
            // 
            // 
            // 
            this.txtCashClosingBalance.CustomButton.Image = null;
            this.txtCashClosingBalance.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtCashClosingBalance.CustomButton.Name = "";
            this.txtCashClosingBalance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCashClosingBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCashClosingBalance.CustomButton.TabIndex = 1;
            this.txtCashClosingBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCashClosingBalance.CustomButton.UseSelectable = true;
            this.txtCashClosingBalance.CustomButton.Visible = false;
            this.txtCashClosingBalance.Lines = new string[0];
            this.txtCashClosingBalance.Location = new System.Drawing.Point(243, 8);
            this.txtCashClosingBalance.MaxLength = 32767;
            this.txtCashClosingBalance.Name = "txtCashClosingBalance";
            this.txtCashClosingBalance.PasswordChar = '\0';
            this.txtCashClosingBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCashClosingBalance.SelectedText = "";
            this.txtCashClosingBalance.SelectionLength = 0;
            this.txtCashClosingBalance.SelectionStart = 0;
            this.txtCashClosingBalance.ShortcutsEnabled = true;
            this.txtCashClosingBalance.Size = new System.Drawing.Size(142, 23);
            this.txtCashClosingBalance.TabIndex = 23;
            this.txtCashClosingBalance.UseSelectable = true;
            this.txtCashClosingBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCashClosingBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(6, 7);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Cash A/C :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // cbxCashAccounts
            // 
            this.cbxCashAccounts.FormattingEnabled = true;
            this.cbxCashAccounts.ItemHeight = 23;
            this.cbxCashAccounts.Location = new System.Drawing.Point(80, 4);
            this.cbxCashAccounts.Name = "cbxCashAccounts";
            this.cbxCashAccounts.Size = new System.Drawing.Size(161, 29);
            this.cbxCashAccounts.TabIndex = 0;
            this.cbxCashAccounts.UseSelectable = true;
            this.cbxCashAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxCashAccounts_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxTaxPayables);
            this.panel2.Controls.Add(this.metroLabel8);
            this.panel2.Controls.Add(this.cbxNaturalAccounts);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Location = new System.Drawing.Point(3, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 37);
            this.panel2.TabIndex = 10;
            // 
            // cbxTaxPayables
            // 
            this.cbxTaxPayables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTaxPayables.FormattingEnabled = true;
            this.cbxTaxPayables.ItemHeight = 23;
            this.cbxTaxPayables.Location = new System.Drawing.Point(450, 5);
            this.cbxTaxPayables.Name = "cbxTaxPayables";
            this.cbxTaxPayables.Size = new System.Drawing.Size(167, 29);
            this.cbxTaxPayables.TabIndex = 28;
            this.cbxTaxPayables.UseSelectable = true;
            this.cbxTaxPayables.SelectedIndexChanged += new System.EventHandler(this.cbxTaxPayables_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(345, 9);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(63, 19);
            this.metroLabel8.TabIndex = 29;
            this.metroLabel8.Text = "Tax A/C :";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // cbxNaturalAccounts
            // 
            this.cbxNaturalAccounts.FormattingEnabled = true;
            this.cbxNaturalAccounts.ItemHeight = 23;
            this.cbxNaturalAccounts.Location = new System.Drawing.Point(83, 5);
            this.cbxNaturalAccounts.Name = "cbxNaturalAccounts";
            this.cbxNaturalAccounts.Size = new System.Drawing.Size(161, 29);
            this.cbxNaturalAccounts.TabIndex = 0;
            this.cbxNaturalAccounts.UseSelectable = true;
            this.cbxNaturalAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxNaturalAccounts_SelectedIndexChanged);
            this.cbxNaturalAccounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxNaturalAccounts_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Debit A/C :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(740, 19);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(127, 23);
            this.btnAddSupplier.TabIndex = 26;
            this.btnAddSupplier.Text = "Add Supplier Account";
            this.btnAddSupplier.UseSelectable = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtCurrentBalance
            // 
            // 
            // 
            // 
            this.txtCurrentBalance.CustomButton.Image = null;
            this.txtCurrentBalance.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtCurrentBalance.CustomButton.Name = "";
            this.txtCurrentBalance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCurrentBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurrentBalance.CustomButton.TabIndex = 1;
            this.txtCurrentBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurrentBalance.CustomButton.UseSelectable = true;
            this.txtCurrentBalance.CustomButton.Visible = false;
            this.txtCurrentBalance.Lines = new string[0];
            this.txtCurrentBalance.Location = new System.Drawing.Point(445, 19);
            this.txtCurrentBalance.MaxLength = 32767;
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.PasswordChar = '\0';
            this.txtCurrentBalance.PromptText = "Current Balance";
            this.txtCurrentBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentBalance.SelectedText = "";
            this.txtCurrentBalance.SelectionLength = 0;
            this.txtCurrentBalance.SelectionStart = 0;
            this.txtCurrentBalance.ShortcutsEnabled = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(104, 23);
            this.txtCurrentBalance.TabIndex = 25;
            this.txtCurrentBalance.UseSelectable = true;
            this.txtCurrentBalance.WaterMark = "Current Balance";
            this.txtCurrentBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrentBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Location = new System.Drawing.Point(662, 19);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(77, 23);
            this.btnViewDetail.TabIndex = 27;
            this.btnViewDetail.Text = "View Detail";
            this.btnViewDetail.UseSelectable = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.CustomButton.Image = null;
            this.txtContact.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtContact.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.CustomButton.Name = "";
            this.txtContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContact.CustomButton.TabIndex = 1;
            this.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.CustomButton.UseSelectable = true;
            this.txtContact.CustomButton.Visible = false;
            this.txtContact.Lines = new string[0];
            this.txtContact.Location = new System.Drawing.Point(549, 19);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PromptText = "Contact";
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.ShortcutsEnabled = true;
            this.txtContact.Size = new System.Drawing.Size(112, 23);
            this.txtContact.TabIndex = 21;
            this.txtContact.UseSelectable = true;
            this.txtContact.WaterMark = "Contact";
            this.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SEditBox
            // 
            // 
            // 
            // 
            this.SEditBox.CustomButton.Image = null;
            this.SEditBox.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.SEditBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.SEditBox.CustomButton.Name = "";
            this.SEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SEditBox.CustomButton.TabIndex = 1;
            this.SEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SEditBox.CustomButton.UseSelectable = true;
            this.SEditBox.Lines = new string[0];
            this.SEditBox.Location = new System.Drawing.Point(90, 19);
            this.SEditBox.MaxLength = 32767;
            this.SEditBox.Name = "SEditBox";
            this.SEditBox.PasswordChar = '\0';
            this.SEditBox.PromptText = "Account Name Here";
            this.SEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SEditBox.SelectedText = "";
            this.SEditBox.SelectionLength = 0;
            this.SEditBox.SelectionStart = 0;
            this.SEditBox.ShortcutsEnabled = true;
            this.SEditBox.ShowButton = true;
            this.SEditBox.Size = new System.Drawing.Size(354, 23);
            this.SEditBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.SEditBox.TabIndex = 0;
            this.SEditBox.UseSelectable = true;
            this.SEditBox.WaterMark = "Account Name Here";
            this.SEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.SEditBox_ButtonClick);
            this.SEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SEditBox_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(7, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Credit A/C :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.VDate);
            this.groupBox1.Controls.Add(this.VEditBox);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtSheetNo);
            this.groupBox1.Controls.Add(this.lblDiscription);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.lblBillNo);
            this.groupBox1.Controls.Add(this.lblVoucherNo);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.chkPosted);
            this.groupBox1.Controls.Add(this.txtBiltyNo);
            this.groupBox1.Controls.Add(this.txtBillNo);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 74);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Information";
            // 
            // VDate
            // 
            this.VDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VDate.Location = new System.Drawing.Point(472, 18);
            this.VDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.VDate.Name = "VDate";
            this.VDate.Size = new System.Drawing.Size(135, 29);
            this.VDate.TabIndex = 22;
            // 
            // VEditBox
            // 
            // 
            // 
            // 
            this.VEditBox.CustomButton.Image = null;
            this.VEditBox.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.VEditBox.CustomButton.Name = "";
            this.VEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VEditBox.CustomButton.TabIndex = 1;
            this.VEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VEditBox.CustomButton.UseSelectable = true;
            this.VEditBox.Lines = new string[0];
            this.VEditBox.Location = new System.Drawing.Point(82, 22);
            this.VEditBox.MaxLength = 32767;
            this.VEditBox.Name = "VEditBox";
            this.VEditBox.PasswordChar = '\0';
            this.VEditBox.PromptText = "Purchase No";
            this.VEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VEditBox.SelectedText = "";
            this.VEditBox.SelectionLength = 0;
            this.VEditBox.SelectionStart = 0;
            this.VEditBox.ShortcutsEnabled = true;
            this.VEditBox.ShowButton = true;
            this.VEditBox.Size = new System.Drawing.Size(176, 23);
            this.VEditBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.VEditBox.TabIndex = 21;
            this.VEditBox.UseSelectable = true;
            this.VEditBox.WaterMark = "Purchase No";
            this.VEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.VEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.VEditBox_ButtonClick);
            this.VEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VEditBox_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(257, 23);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Sheet #";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // txtSheetNo
            // 
            // 
            // 
            // 
            this.txtSheetNo.CustomButton.Image = null;
            this.txtSheetNo.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtSheetNo.CustomButton.Name = "";
            this.txtSheetNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSheetNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSheetNo.CustomButton.TabIndex = 1;
            this.txtSheetNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSheetNo.CustomButton.UseSelectable = true;
            this.txtSheetNo.CustomButton.Visible = false;
            this.txtSheetNo.Lines = new string[0];
            this.txtSheetNo.Location = new System.Drawing.Point(317, 22);
            this.txtSheetNo.MaxLength = 32767;
            this.txtSheetNo.Name = "txtSheetNo";
            this.txtSheetNo.PasswordChar = '\0';
            this.txtSheetNo.PromptText = "Any Sheet No";
            this.txtSheetNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSheetNo.SelectedText = "";
            this.txtSheetNo.SelectionLength = 0;
            this.txtSheetNo.SelectionStart = 0;
            this.txtSheetNo.ShortcutsEnabled = true;
            this.txtSheetNo.Size = new System.Drawing.Size(107, 23);
            this.txtSheetNo.TabIndex = 1;
            this.txtSheetNo.UseSelectable = true;
            this.txtSheetNo.WaterMark = "Any Sheet No";
            this.txtSheetNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSheetNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSheetNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillNo_KeyPress);
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDiscription.Location = new System.Drawing.Point(1, 46);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(81, 19);
            this.lblDiscription.TabIndex = 19;
            this.lblDiscription.Text = "Discription :";
            this.lblDiscription.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(611, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Bilty No :";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBillNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBillNo.Location = new System.Drawing.Point(788, 23);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(55, 19);
            this.lblBillNo.TabIndex = 19;
            this.lblBillNo.Text = "Bill No :";
            this.lblBillNo.UseCustomBackColor = true;
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucherNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblVoucherNo.Location = new System.Drawing.Point(6, 24);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(72, 19);
            this.lblVoucherNo.TabIndex = 19;
            this.lblVoucherNo.Text = "Voucher #";
            this.lblVoucherNo.UseCustomBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(423, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 19);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date :";
            this.lblDate.UseCustomBackColor = true;
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.BackColor = System.Drawing.Color.Transparent;
            this.chkPosted.Checked = true;
            this.chkPosted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPosted.Location = new System.Drawing.Point(950, 26);
            this.chkPosted.Name = "chkPosted";
            this.chkPosted.Size = new System.Drawing.Size(59, 15);
            this.chkPosted.TabIndex = 18;
            this.chkPosted.Text = "Posted";
            this.chkPosted.UseCustomBackColor = true;
            this.chkPosted.UseSelectable = true;
            // 
            // txtBiltyNo
            // 
            // 
            // 
            // 
            this.txtBiltyNo.CustomButton.Image = null;
            this.txtBiltyNo.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtBiltyNo.CustomButton.Name = "";
            this.txtBiltyNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBiltyNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBiltyNo.CustomButton.TabIndex = 1;
            this.txtBiltyNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBiltyNo.CustomButton.UseSelectable = true;
            this.txtBiltyNo.CustomButton.Visible = false;
            this.txtBiltyNo.Lines = new string[0];
            this.txtBiltyNo.Location = new System.Drawing.Point(681, 22);
            this.txtBiltyNo.MaxLength = 32767;
            this.txtBiltyNo.Name = "txtBiltyNo";
            this.txtBiltyNo.PasswordChar = '\0';
            this.txtBiltyNo.PromptText = "Bilty No Here";
            this.txtBiltyNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBiltyNo.SelectedText = "";
            this.txtBiltyNo.SelectionLength = 0;
            this.txtBiltyNo.SelectionStart = 0;
            this.txtBiltyNo.ShortcutsEnabled = true;
            this.txtBiltyNo.Size = new System.Drawing.Size(107, 23);
            this.txtBiltyNo.TabIndex = 1;
            this.txtBiltyNo.UseSelectable = true;
            this.txtBiltyNo.WaterMark = "Bilty No Here";
            this.txtBiltyNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBiltyNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBiltyNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillNo_KeyPress);
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.CustomButton.Image = null;
            this.txtBillNo.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtBillNo.CustomButton.Name = "";
            this.txtBillNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBillNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBillNo.CustomButton.TabIndex = 1;
            this.txtBillNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBillNo.CustomButton.UseSelectable = true;
            this.txtBillNo.CustomButton.Visible = false;
            this.txtBillNo.Lines = new string[0];
            this.txtBillNo.Location = new System.Drawing.Point(846, 22);
            this.txtBillNo.MaxLength = 32767;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.PasswordChar = '\0';
            this.txtBillNo.PromptText = "Bill No";
            this.txtBillNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillNo.SelectedText = "";
            this.txtBillNo.SelectionLength = 0;
            this.txtBillNo.SelectionStart = 0;
            this.txtBillNo.ShortcutsEnabled = true;
            this.txtBillNo.Size = new System.Drawing.Size(100, 23);
            this.txtBillNo.TabIndex = 1;
            this.txtBillNo.UseSelectable = true;
            this.txtBillNo.WaterMark = "Bill No";
            this.txtBillNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBillNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBillNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillNo_KeyPress);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(844, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(82, 47);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(864, 22);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // flowMainPanel
            // 
            this.flowMainPanel.AutoSize = true;
            this.flowMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowMainPanel.Controls.Add(this.groupBox1);
            this.flowMainPanel.Controls.Add(this.grpCreditor);
            this.flowMainPanel.Controls.Add(this.tabPurchaseTransactions);
            this.flowMainPanel.Controls.Add(this.pnlButtons);
            this.flowMainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMainPanel.Location = new System.Drawing.Point(14, 57);
            this.flowMainPanel.Name = "flowMainPanel";
            this.flowMainPanel.Size = new System.Drawing.Size(1181, 657);
            this.flowMainPanel.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IdVoucherDetail";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IdItem";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Code";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Discription";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "CTN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "BatchNo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Expiry";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Engine #";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Chassis #";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Model";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Vehicle #";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 90;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "IMEI #";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 90;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Second IMEI";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn15.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn16.HeaderText = "Bonus";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 80;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn17.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 80;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "qty*amount";
            this.dataGridViewTextBoxColumn18.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn18.Width = 90;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "qty*amount";
            this.dataGridViewTextBoxColumn19.HeaderText = "Disc(%)";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn19.Width = 90;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Net Amount";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 65;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "VoucherDetailId";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Visible = false;
            this.dataGridViewTextBoxColumn21.Width = 75;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "AccountId";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Visible = false;
            this.dataGridViewTextBoxColumn22.Width = 75;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn23.HeaderText = "Acc. #";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "A/C Name";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Visible = false;
            this.dataGridViewTextBoxColumn24.Width = 250;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn25.HeaderText = "Closing Balance";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Visible = false;
            this.dataGridViewTextBoxColumn25.Width = 120;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn26.HeaderText = "Narration";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Visible = false;
            this.dataGridViewTextBoxColumn26.Width = 385;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.HeaderText = "Debit";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 120;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.HeaderText = "Credit";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 120;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.HeaderText = "Debit";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 120;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.HeaderText = "Credit";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 120;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.HeaderText = "Credit";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 120;
            // 
            // frmStockReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1194, 764);
            this.Controls.Add(this.flowMainPanel);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStockReceipt";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Goods Purchases Receipt Note";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmStockReceipt_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmStockReceipt_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tabPurchaseTransactions.ResumeLayout(false);
            this.tabLineItems.ResumeLayout(false);
            this.tabLineItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockReceipt)).EndInit();
            this.tabSalesTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPurchases)).EndInit();
            this.grpCreditor.ResumeLayout(false);
            this.grpCreditor.PerformLayout();
            this.flowPurchasesPanel.ResumeLayout(false);
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridView DgvStockReceipt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatuMessage;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButtons;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnNext;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnPrevious;
        private MetroFramework.Controls.MetroTile btnClose;
        private System.Windows.Forms.TabControl tabPurchaseTransactions;
        private System.Windows.Forms.TabPage tabLineItems;
        private TabDataGrid DgvStockReceipt;
        private MetroFramework.Controls.MetroTextBox txtBillAmount;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private System.Windows.Forms.TabPage tabSalesTransactions;
        private TabDataGrid DgvPurchases;
        private System.Windows.Forms.GroupBox grpCreditor;
        private MetroFramework.Controls.MetroButton btnAddSupplier;
        private MetroFramework.Controls.MetroTextBox txtCurrentBalance;
        private MetroFramework.Controls.MetroButton btnViewDetail;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private MetroFramework.Controls.MetroTextBox SEditBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowPurchasesPanel;
        private System.Windows.Forms.Panel pnlCash;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbxCashAccounts;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroComboBox cbxNaturalAccounts;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime VDate;
        private MetroFramework.Controls.MetroTextBox VEditBox;
        private MetroFramework.Controls.MetroLabel lblDiscription;
        private MetroFramework.Controls.MetroLabel lblBillNo;
        private MetroFramework.Controls.MetroLabel lblVoucherNo;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroCheckBox chkPosted;
        private MetroFramework.Controls.MetroTextBox txtBillNo;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private System.Windows.Forms.FlowLayoutPanel flowMainPanel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtBiltyNo;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblVouchersCount;
        private MetroFramework.Controls.MetroLabel lblTotalVouchers;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblLastVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdDetailVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtSheetNo;
        private MetroFramework.Controls.MetroTextBox txtTotalAmount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtFreightAmount;
        private MetroFramework.Controls.MetroLabel lblFreight;
        private MetroFramework.Controls.MetroTile btnPrintPurchaseInvoice;
        private MetroFramework.Controls.MetroTextBox txtCashClosingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private MetroFramework.Controls.MetroComboBox cbxTaxPayables;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtTotalSaleTaxAmount;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtOtherTaxAmount;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtSaleTaxAmount;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtAmountafterDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtBulkDiscount;
        private MetroFramework.Controls.MetroTextBox txtNormalDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdVoucherDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpacking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemension;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartons;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEngineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChassisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleModel;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVehicleColors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstIMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecondIMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNormalDiscountPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNormalDiscountFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBulkDiscountPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBulkDiscountFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTaxPayable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTaxPayableFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraSalesTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraSalesTaxFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}