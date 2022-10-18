namespace Accounts.UI
{
    partial class frmFBRSheets
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.cbxSheets = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.grdTaxSheet = new System.Windows.Forms.DataGridView();
            this.btnLoad = new MetroFramework.Controls.MetroTile();
            this.btnExport = new MetroFramework.Controls.MetroTile();
            this.colNTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValueofSalesExcludingSalesTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFurtherTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaxSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel1.Location = new System.Drawing.Point(32, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "From :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(83, 76);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(146, 29);
            this.dtStart.TabIndex = 1;
            // 
            // cbxSheets
            // 
            this.cbxSheets.FormattingEnabled = true;
            this.cbxSheets.ItemHeight = 23;
            this.cbxSheets.Items.AddRange(new object[] {
            "",
            "Exempt Items",
            "Third Schedule Items",
            "Standart Items"});
            this.cbxSheets.Location = new System.Drawing.Point(560, 77);
            this.cbxSheets.Name = "cbxSheets";
            this.cbxSheets.Size = new System.Drawing.Size(173, 29);
            this.cbxSheets.TabIndex = 2;
            this.cbxSheets.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel2.Location = new System.Drawing.Point(255, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "To :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(302, 76);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(152, 29);
            this.dtEnd.TabIndex = 1;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel3.Location = new System.Drawing.Point(471, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Sheet Type :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.MistyRose;
            this.metroPanel1.Controls.Add(this.btnLoad);
            this.metroPanel1.Controls.Add(this.btnExport);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1082, 58);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // grdTaxSheet
            // 
            this.grdTaxSheet.BackgroundColor = System.Drawing.Color.Linen;
            this.grdTaxSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaxSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNTN,
            this.colNIC,
            this.colBuyerName,
            this.colBuyerType,
            this.colDocumentType,
            this.colDocumentNo,
            this.colDocumentDate,
            this.colRate,
            this.colUOM,
            this.colValueofSalesExcludingSalesTax,
            this.colSaleTax,
            this.colFurtherTax,
            this.colTotal});
            this.grdTaxSheet.EnableHeadersVisualStyles = false;
            this.grdTaxSheet.Location = new System.Drawing.Point(23, 121);
            this.grdTaxSheet.Name = "grdTaxSheet";
            this.grdTaxSheet.Size = new System.Drawing.Size(1082, 484);
            this.grdTaxSheet.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.ActiveControl = null;
            this.btnLoad.Location = new System.Drawing.Point(734, 11);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 38);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExport
            // 
            this.btnExport.ActiveControl = null;
            this.btnExport.Location = new System.Drawing.Point(840, 11);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(104, 38);
            this.btnExport.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.UseSelectable = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // colNTN
            // 
            this.colNTN.DataPropertyName = "NTN";
            this.colNTN.HeaderText = "Buyer NTN";
            this.colNTN.Name = "colNTN";
            // 
            // colNIC
            // 
            this.colNIC.DataPropertyName = "Cnic";
            this.colNIC.HeaderText = "Buyer NIC";
            this.colNIC.Name = "colNIC";
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "PersonName";
            this.colBuyerName.HeaderText = "Buyer Name";
            this.colBuyerName.Name = "colBuyerName";
            // 
            // colBuyerType
            // 
            this.colBuyerType.DataPropertyName = "PersonType";
            this.colBuyerType.HeaderText = "Buyer Type";
            this.colBuyerType.Name = "colBuyerType";
            // 
            // colDocumentType
            // 
            this.colDocumentType.DataPropertyName = "VoucherType";
            this.colDocumentType.HeaderText = "Document Type";
            this.colDocumentType.Name = "colDocumentType";
            // 
            // colDocumentNo
            // 
            this.colDocumentNo.DataPropertyName = "VoucherNo";
            this.colDocumentNo.HeaderText = "Document No";
            this.colDocumentNo.Name = "colDocumentNo";
            // 
            // colDocumentDate
            // 
            this.colDocumentDate.DataPropertyName = "VDate";
            this.colDocumentDate.HeaderText = "Document Date";
            this.colDocumentDate.Name = "colDocumentDate";
            // 
            // colRate
            // 
            this.colRate.DataPropertyName = "UnitPrice";
            this.colRate.HeaderText = "Rate";
            this.colRate.Name = "colRate";
            // 
            // colUOM
            // 
            this.colUOM.DataPropertyName = "PackingSize";
            this.colUOM.HeaderText = "UOM";
            this.colUOM.Name = "colUOM";
            // 
            // colValueofSalesExcludingSalesTax
            // 
            this.colValueofSalesExcludingSalesTax.DataPropertyName = "DiscountAmount";
            this.colValueofSalesExcludingSalesTax.HeaderText = "Value of Sales Excluding Sales Tax";
            this.colValueofSalesExcludingSalesTax.Name = "colValueofSalesExcludingSalesTax";
            // 
            // colSaleTax
            // 
            this.colSaleTax.DataPropertyName = "SaleTaxFlatAmount";
            this.colSaleTax.HeaderText = "Sales Tax/ FED in ST Mode";
            this.colSaleTax.Name = "colSaleTax";
            // 
            // colFurtherTax
            // 
            this.colFurtherTax.DataPropertyName = "OtherTaxFlatAmount";
            this.colFurtherTax.HeaderText = "Further Tax";
            this.colFurtherTax.Name = "colFurtherTax";
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "TotalAmountAfterTax";
            this.colTotal.HeaderText = "Total Value of Sales";
            this.colTotal.Name = "colTotal";
            // 
            // frmFBRSheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 628);
            this.Controls.Add(this.grdTaxSheet);
            this.Controls.Add(this.cbxSheets);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmFBRSheets";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "FBR Tax Sheets";
            this.Load += new System.EventHandler(this.frmFBRSheets_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTaxSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroComboBox cbxSheets;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnLoad;
        private MetroFramework.Controls.MetroTile btnExport;
        private System.Windows.Forms.DataGridView grdTaxSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValueofSalesExcludingSalesTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFurtherTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}