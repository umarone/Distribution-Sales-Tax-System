namespace Accounts.UI
{
    partial class frmCurrentStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrentStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.CbxCategories = new MetroFramework.Controls.MetroComboBox();
            this.lblProductDiscription = new MetroFramework.Controls.MetroLabel();
            this.grdCurrentStock = new Accounts.UI.TabDataGrid();
            this.ColIdCurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpacking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDimension = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colBoxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPieces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBonusUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTaxPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTaxFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraTaxPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraTaxFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxableAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrentStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Location = new System.Drawing.Point(1058, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 52);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSave.TileImage")));
            this.btnSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CbxCategories
            // 
            this.CbxCategories.BackColor = System.Drawing.SystemColors.Info;
            this.CbxCategories.FormattingEnabled = true;
            this.CbxCategories.ItemHeight = 23;
            this.CbxCategories.Location = new System.Drawing.Point(84, 72);
            this.CbxCategories.Name = "CbxCategories";
            this.CbxCategories.Size = new System.Drawing.Size(402, 29);
            this.CbxCategories.TabIndex = 15;
            this.CbxCategories.UseCustomBackColor = true;
            this.CbxCategories.UseSelectable = true;
            this.CbxCategories.SelectedIndexChanged += new System.EventHandler(this.CbxCategories_SelectedIndexChanged);
            // 
            // lblProductDiscription
            // 
            this.lblProductDiscription.AutoSize = true;
            this.lblProductDiscription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblProductDiscription.Location = new System.Drawing.Point(9, 75);
            this.lblProductDiscription.Name = "lblProductDiscription";
            this.lblProductDiscription.Size = new System.Drawing.Size(72, 19);
            this.lblProductDiscription.TabIndex = 25;
            this.lblProductDiscription.Text = "Category :";
            // 
            // grdCurrentStock
            // 
            this.grdCurrentStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdCurrentStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCurrentStock.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCurrentStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdCurrentStock.ColumnHeadersHeight = 45;
            this.grdCurrentStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdCurrentStock,
            this.colIdItem,
            this.colItemNo,
            this.colItemName,
            this.colpacking,
            this.colDimension,
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
            this.colBoxes,
            this.colPieces,
            this.colBonusUnit,
            this.colFinalQuantity,
            this.colUnitPrice,
            this.colTotalAmount,
            this.colSaleTaxPercentage,
            this.colSaleTaxFlat,
            this.colExtraTaxPercentage,
            this.colExtraTaxFlat,
            this.colTaxableAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCurrentStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdCurrentStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdCurrentStock.EnableHeadersVisualStyles = false;
            this.grdCurrentStock.Location = new System.Drawing.Point(10, 107);
            this.grdCurrentStock.MultiSelect = false;
            this.grdCurrentStock.Name = "grdCurrentStock";
            this.grdCurrentStock.RowHeadersVisible = false;
            this.grdCurrentStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdCurrentStock.Size = new System.Drawing.Size(1185, 385);
            this.grdCurrentStock.TabIndex = 26;
            this.grdCurrentStock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCurrentStock_CellEndEdit);
            this.grdCurrentStock.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCurrentStock_CellLeave);
            this.grdCurrentStock.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdCurrentStock_EditingControlShowing);
            // 
            // ColIdCurrentStock
            // 
            this.ColIdCurrentStock.HeaderText = "IdCurrentStock";
            this.ColIdCurrentStock.Name = "ColIdCurrentStock";
            this.ColIdCurrentStock.Visible = false;
            // 
            // colIdItem
            // 
            this.colIdItem.DataPropertyName = "IdItem";
            this.colIdItem.HeaderText = "IdItem";
            this.colIdItem.Name = "colIdItem";
            this.colIdItem.Visible = false;
            // 
            // colItemNo
            // 
            this.colItemNo.DataPropertyName = "ItemNo";
            this.colItemNo.HeaderText = "Product Code";
            this.colItemNo.Name = "colItemNo";
            this.colItemNo.Visible = false;
            // 
            // colItemName
            // 
            this.colItemName.DataPropertyName = "ItemName";
            this.colItemName.HeaderText = "Product Discription";
            this.colItemName.Name = "colItemName";
            this.colItemName.Width = 250;
            // 
            // colpacking
            // 
            this.colpacking.DataPropertyName = "PackingSize";
            this.colpacking.HeaderText = "UOM";
            this.colpacking.Name = "colpacking";
            this.colpacking.ReadOnly = true;
            this.colpacking.Visible = false;
            this.colpacking.Width = 70;
            // 
            // colDimension
            // 
            this.colDimension.HeaderText = "Dims";
            this.colDimension.Name = "colDimension";
            this.colDimension.ReadOnly = true;
            this.colDimension.Width = 60;
            // 
            // colCartons
            // 
            this.colCartons.DataPropertyName = "TotalCartons";
            this.colCartons.HeaderText = "CTN";
            this.colCartons.Name = "colCartons";
            this.colCartons.Width = 90;
            // 
            // colBatchNo
            // 
            this.colBatchNo.DataPropertyName = "BatchNo";
            this.colBatchNo.HeaderText = "BatchNo";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.Width = 90;
            // 
            // colExpiry
            // 
            this.colExpiry.DataPropertyName = "Expiry";
            this.colExpiry.HeaderText = "Expiry";
            this.colExpiry.Name = "colExpiry";
            this.colExpiry.Width = 90;
            // 
            // colEngineNo
            // 
            this.colEngineNo.DataPropertyName = "EngineNo";
            this.colEngineNo.HeaderText = "Engine #";
            this.colEngineNo.Name = "colEngineNo";
            this.colEngineNo.Width = 80;
            // 
            // colChassisNo
            // 
            this.colChassisNo.DataPropertyName = "ChasisNo";
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
            this.colVehicleNo.DataPropertyName = "VehicleNo";
            this.colVehicleNo.HeaderText = "Vehicle #";
            this.colVehicleNo.Name = "colVehicleNo";
            this.colVehicleNo.Width = 90;
            // 
            // colFirstIMEI
            // 
            this.colFirstIMEI.DataPropertyName = "FirstIMEI";
            this.colFirstIMEI.HeaderText = "IMEI No";
            this.colFirstIMEI.Name = "colFirstIMEI";
            // 
            // colSecondIMEI
            // 
            this.colSecondIMEI.DataPropertyName = "SecondIMEI";
            this.colSecondIMEI.HeaderText = "Second IMEI";
            this.colSecondIMEI.Name = "colSecondIMEI";
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Qty (CTN)";
            this.colQty.Name = "colQty";
            this.colQty.Width = 10;
            // 
            // colBoxes
            // 
            this.colBoxes.HeaderText = "Boxes";
            this.colBoxes.Name = "colBoxes";
            this.colBoxes.Width = 55;
            // 
            // colPieces
            // 
            this.colPieces.HeaderText = "Pieces";
            this.colPieces.Name = "colPieces";
            this.colPieces.Width = 60;
            // 
            // colBonusUnit
            // 
            this.colBonusUnit.HeaderText = "Bonus";
            this.colBonusUnit.Name = "colBonusUnit";
            this.colBonusUnit.Width = 60;
            // 
            // colFinalQuantity
            // 
            this.colFinalQuantity.HeaderText = "Final Quantity";
            this.colFinalQuantity.Name = "colFinalQuantity";
            this.colFinalQuantity.ReadOnly = true;
            this.colFinalQuantity.Width = 70;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "Amount";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 60;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.DataPropertyName = "qty*amount";
            this.colTotalAmount.HeaderText = "Amount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            this.colTotalAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTotalAmount.Width = 85;
            // 
            // colSaleTaxPercentage
            // 
            this.colSaleTaxPercentage.HeaderText = "Sale Tax(%)";
            this.colSaleTaxPercentage.Name = "colSaleTaxPercentage";
            this.colSaleTaxPercentage.Width = 65;
            // 
            // colSaleTaxFlat
            // 
            this.colSaleTaxFlat.HeaderText = "Flat Sale Tax";
            this.colSaleTaxFlat.Name = "colSaleTaxFlat";
            this.colSaleTaxFlat.Width = 55;
            // 
            // colExtraTaxPercentage
            // 
            this.colExtraTaxPercentage.HeaderText = "Extra Tax(%)";
            this.colExtraTaxPercentage.Name = "colExtraTaxPercentage";
            this.colExtraTaxPercentage.Width = 65;
            // 
            // colExtraTaxFlat
            // 
            this.colExtraTaxFlat.HeaderText = "Flat Extra Tax";
            this.colExtraTaxFlat.Name = "colExtraTaxFlat";
            this.colExtraTaxFlat.Width = 55;
            // 
            // colTaxableAmount
            // 
            this.colTaxableAmount.HeaderText = "Taxable Amount";
            this.colTaxableAmount.Name = "colTaxableAmount";
            this.colTaxableAmount.Width = 85;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCurrentStock";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdItem";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdItem";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Code";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Discription";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PackingSize";
            this.dataGridViewTextBoxColumn5.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Dims";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TotalCartons";
            this.dataGridViewTextBoxColumn7.HeaderText = "CTN";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BatchNo";
            this.dataGridViewTextBoxColumn8.HeaderText = "BatchNo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Expiry";
            this.dataGridViewTextBoxColumn9.HeaderText = "Expiry";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 90;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "EngineNo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Engine #";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ChasisNo";
            this.dataGridViewTextBoxColumn11.HeaderText = "Chassis #";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Model";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "VehicleNo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Vehicle #";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 90;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FirstIMEI";
            this.dataGridViewTextBoxColumn14.HeaderText = "IMEI No";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SecondIMEI";
            this.dataGridViewTextBoxColumn15.HeaderText = "Second IMEI";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn16.HeaderText = "Qty (CTN)";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 10;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Boxes";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 80;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Pieces";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 80;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Bonus";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Final Quantity";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn21.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 90;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "qty*amount";
            this.dataGridViewTextBoxColumn22.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmCurrentStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1202, 582);
            this.Controls.Add(this.grdCurrentStock);
            this.Controls.Add(this.lblProductDiscription);
            this.Controls.Add(this.CbxCategories);
            this.Controls.Add(this.btnSave);
            this.Name = "frmCurrentStock";
            this.Text = "Add Current Stock";
            this.Load += new System.EventHandler(this.frmCurrentStock_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCurrentStock_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrentStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroComboBox CbxCategories;
        private MetroFramework.Controls.MetroLabel lblProductDiscription;
        private TabDataGrid grdCurrentStock;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCurrentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpacking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDimension;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPieces;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBonusUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTaxPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTaxFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraTaxPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraTaxFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxableAmount;
    }
}