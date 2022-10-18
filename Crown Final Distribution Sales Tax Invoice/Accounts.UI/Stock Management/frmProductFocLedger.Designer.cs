namespace Accounts.UI
{
    partial class frmProductFocLedger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDashed = new MetroFramework.Controls.MetroLabel();
            this.grdProductLedger = new System.Windows.Forms.DataGridView();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.PEditBox = new MetroFramework.Controls.MetroTextBox();
            this.btnProductReport = new System.Windows.Forms.Button();
            this.chkFocByDate = new System.Windows.Forms.CheckBox();
            this.chkFocByCustomer = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.btnLoadByDate = new System.Windows.Forms.Button();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.txtAccount = new MetroFramework.Controls.MetroTextBox();
            this.lbl = new MetroFramework.Controls.MetroLabel();
            this.btnLoadByCustomer = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductLedger)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDashed
            // 
            this.lblDashed.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDashed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDashed.Location = new System.Drawing.Point(24, 52);
            this.lblDashed.Name = "lblDashed";
            this.lblDashed.Size = new System.Drawing.Size(578, 23);
            this.lblDashed.TabIndex = 0;
            this.lblDashed.Text = "---------------------------------------------------------------------------------" +
    "-------------";
            this.lblDashed.UseCustomForeColor = true;
            // 
            // grdProductLedger
            // 
            this.grdProductLedger.AllowUserToAddRows = false;
            this.grdProductLedger.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.grdProductLedger.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProductLedger.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdProductLedger.ColumnHeadersHeight = 25;
            this.grdProductLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDescription,
            this.colType,
            this.colDate,
            this.colAccountName,
            this.colUnits,
            this.colClosing});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProductLedger.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdProductLedger.EnableHeadersVisualStyles = false;
            this.grdProductLedger.Location = new System.Drawing.Point(3, 102);
            this.grdProductLedger.Name = "grdProductLedger";
            this.grdProductLedger.ReadOnly = true;
            this.grdProductLedger.RowHeadersVisible = false;
            this.grdProductLedger.Size = new System.Drawing.Size(674, 388);
            this.grdProductLedger.TabIndex = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(24, 78);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 19);
            this.metroLabel10.TabIndex = 14;
            this.metroLabel10.Text = "Product :";
            // 
            // PEditBox
            // 
            // 
            // 
            // 
            this.PEditBox.CustomButton.Image = null;
            this.PEditBox.CustomButton.Location = new System.Drawing.Point(363, 1);
            this.PEditBox.CustomButton.Name = "";
            this.PEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PEditBox.CustomButton.TabIndex = 1;
            this.PEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PEditBox.CustomButton.UseSelectable = true;
            this.PEditBox.Lines = new string[0];
            this.PEditBox.Location = new System.Drawing.Point(90, 78);
            this.PEditBox.MaxLength = 32767;
            this.PEditBox.Name = "PEditBox";
            this.PEditBox.PasswordChar = '\0';
            this.PEditBox.PromptText = "Product Here";
            this.PEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PEditBox.SelectedText = "";
            this.PEditBox.SelectionLength = 0;
            this.PEditBox.SelectionStart = 0;
            this.PEditBox.ShortcutsEnabled = true;
            this.PEditBox.ShowButton = true;
            this.PEditBox.Size = new System.Drawing.Size(385, 23);
            this.PEditBox.TabIndex = 13;
            this.PEditBox.UseSelectable = true;
            this.PEditBox.WaterMark = "Product Here";
            this.PEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.PEditBox_ButtonClick);
            this.PEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PEditBox_KeyPress);
            // 
            // btnProductReport
            // 
            this.btnProductReport.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProductReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductReport.ForeColor = System.Drawing.Color.Black;
            this.btnProductReport.Location = new System.Drawing.Point(481, 78);
            this.btnProductReport.Name = "btnProductReport";
            this.btnProductReport.Size = new System.Drawing.Size(101, 25);
            this.btnProductReport.TabIndex = 15;
            this.btnProductReport.Text = "Load Report";
            this.btnProductReport.UseVisualStyleBackColor = false;
            this.btnProductReport.Click += new System.EventHandler(this.btnProductReport_Click);
            // 
            // chkFocByDate
            // 
            this.chkFocByDate.AutoSize = true;
            this.chkFocByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFocByDate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkFocByDate.Location = new System.Drawing.Point(90, 108);
            this.chkFocByDate.Name = "chkFocByDate";
            this.chkFocByDate.Size = new System.Drawing.Size(101, 20);
            this.chkFocByDate.TabIndex = 16;
            this.chkFocByDate.Text = "Foc By Date";
            this.chkFocByDate.UseVisualStyleBackColor = true;
            this.chkFocByDate.CheckedChanged += new System.EventHandler(this.chkFocByDate_CheckedChanged);
            // 
            // chkFocByCustomer
            // 
            this.chkFocByCustomer.AutoSize = true;
            this.chkFocByCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFocByCustomer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkFocByCustomer.Location = new System.Drawing.Point(194, 108);
            this.chkFocByCustomer.Name = "chkFocByCustomer";
            this.chkFocByCustomer.Size = new System.Drawing.Size(129, 20);
            this.chkFocByCustomer.TabIndex = 16;
            this.chkFocByCustomer.Text = "Foc By Customer";
            this.chkFocByCustomer.UseVisualStyleBackColor = true;
            this.chkFocByCustomer.CheckedChanged += new System.EventHandler(this.chkFocByCustomer_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.pnlDate);
            this.flowLayoutPanel1.Controls.Add(this.pnlCustomer);
            this.flowLayoutPanel1.Controls.Add(this.grdProductLedger);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(680, 493);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.metroLabel2);
            this.pnlDate.Controls.Add(this.metroLabel1);
            this.pnlDate.Controls.Add(this.dtEnd);
            this.pnlDate.Controls.Add(this.dtStart);
            this.pnlDate.Controls.Add(this.btnLoadByDate);
            this.pnlDate.Location = new System.Drawing.Point(3, 3);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(574, 54);
            this.pnlDate.TabIndex = 0;
            this.pnlDate.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroLabel2.Location = new System.Drawing.Point(234, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "To :";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroLabel1.Location = new System.Drawing.Point(8, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "From :";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(276, 13);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(172, 29);
            this.dtEnd.TabIndex = 0;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(74, 12);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(148, 29);
            this.dtStart.TabIndex = 0;
            // 
            // btnLoadByDate
            // 
            this.btnLoadByDate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoadByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadByDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadByDate.ForeColor = System.Drawing.Color.Black;
            this.btnLoadByDate.Location = new System.Drawing.Point(461, 17);
            this.btnLoadByDate.Name = "btnLoadByDate";
            this.btnLoadByDate.Size = new System.Drawing.Size(101, 25);
            this.btnLoadByDate.TabIndex = 15;
            this.btnLoadByDate.Text = "Load Report";
            this.btnLoadByDate.UseVisualStyleBackColor = false;
            this.btnLoadByDate.Click += new System.EventHandler(this.btnLoadByDate_Click);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.txtAccount);
            this.pnlCustomer.Controls.Add(this.lbl);
            this.pnlCustomer.Controls.Add(this.btnLoadByCustomer);
            this.pnlCustomer.Location = new System.Drawing.Point(3, 63);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(574, 33);
            this.pnlCustomer.TabIndex = 1;
            this.pnlCustomer.Visible = false;
            // 
            // txtAccount
            // 
            // 
            // 
            // 
            this.txtAccount.CustomButton.Image = null;
            this.txtAccount.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.txtAccount.CustomButton.Name = "";
            this.txtAccount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccount.CustomButton.TabIndex = 1;
            this.txtAccount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccount.CustomButton.UseSelectable = true;
            this.txtAccount.Lines = new string[0];
            this.txtAccount.Location = new System.Drawing.Point(84, 3);
            this.txtAccount.MaxLength = 32767;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccount.SelectedText = "";
            this.txtAccount.SelectionLength = 0;
            this.txtAccount.SelectionStart = 0;
            this.txtAccount.ShortcutsEnabled = true;
            this.txtAccount.ShowButton = true;
            this.txtAccount.Size = new System.Drawing.Size(364, 23);
            this.txtAccount.TabIndex = 13;
            this.txtAccount.UseSelectable = true;
            this.txtAccount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccount.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtAccount_ButtonClick);
            this.txtAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PEditBox_KeyPress);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(8, 3);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(73, 19);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "Customer :";
            // 
            // btnLoadByCustomer
            // 
            this.btnLoadByCustomer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoadByCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadByCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadByCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnLoadByCustomer.Location = new System.Drawing.Point(461, 5);
            this.btnLoadByCustomer.Name = "btnLoadByCustomer";
            this.btnLoadByCustomer.Size = new System.Drawing.Size(101, 25);
            this.btnLoadByCustomer.TabIndex = 15;
            this.btnLoadByCustomer.Text = "Load Report";
            this.btnLoadByCustomer.UseVisualStyleBackColor = false;
            this.btnLoadByCustomer.Click += new System.EventHandler(this.btnLoadByCustomer_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.HeaderText = "Descriptoin";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AccountType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StockOnHandDate";
            dataGridViewCellStyle7.Format = "d";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AccountName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Account Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 160;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn5.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Closing";
            this.dataGridViewTextBoxColumn6.HeaderText = "Available Stock";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "Value";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Avg / Unit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Total Avg Value";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 140;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDescription.HeaderText = "Descriptoin";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 130;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "AccountType";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 80;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "StockOnHandDate";
            dataGridViewCellStyle4.Format = "d";
            this.colDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "AccountName";
            this.colAccountName.HeaderText = "Account Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 160;
            // 
            // colUnits
            // 
            this.colUnits.DataPropertyName = "Qty";
            this.colUnits.HeaderText = "Qty";
            this.colUnits.Name = "colUnits";
            this.colUnits.ReadOnly = true;
            // 
            // colClosing
            // 
            this.colClosing.HeaderText = "Closing Stock";
            this.colClosing.Name = "colClosing";
            this.colClosing.ReadOnly = true;
            // 
            // frmProductFocLedger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(724, 645);
            this.Controls.Add(this.chkFocByCustomer);
            this.Controls.Add(this.chkFocByDate);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.PEditBox);
            this.Controls.Add(this.btnProductReport);
            this.Controls.Add(this.lblDashed);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HelpButton = true;
            this.Name = "frmProductFocLedger";
            this.Text = "Product FOC Ledger";
            this.Load += new System.EventHandler(this.frmProductLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductLedger)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDashed;
        private System.Windows.Forms.DataGridView grdProductLedger;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox PEditBox;
        private System.Windows.Forms.Button btnProductReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.CheckBox chkFocByDate;
        private System.Windows.Forms.CheckBox chkFocByCustomer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private System.Windows.Forms.Button btnLoadByDate;
        private System.Windows.Forms.Panel pnlCustomer;
        private MetroFramework.Controls.MetroTextBox txtAccount;
        private MetroFramework.Controls.MetroLabel lbl;
        private System.Windows.Forms.Button btnLoadByCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosing;
    }
}