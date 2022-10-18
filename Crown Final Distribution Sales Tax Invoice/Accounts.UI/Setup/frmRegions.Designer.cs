namespace Accounts.UI
{
    partial class frmRegions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.txtRegionCode = new MetroFramework.Controls.MetroTextBox();
            this.txtRegionName = new MetroFramework.Controls.MetroTextBox();
            this.grdRegions = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ProjectStartDate = new MetroFramework.Controls.MetroDateTime();
            this.cbxCities = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.chkStore = new MetroFramework.Controls.MetroCheckBox();
            this.lblProjectStartDate = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbxRegiontype = new MetroFramework.Controls.MetroComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegions)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(357, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 35);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtRegionCode
            // 
            // 
            // 
            // 
            this.txtRegionCode.CustomButton.Image = null;
            this.txtRegionCode.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtRegionCode.CustomButton.Name = "";
            this.txtRegionCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRegionCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRegionCode.CustomButton.TabIndex = 1;
            this.txtRegionCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRegionCode.CustomButton.UseSelectable = true;
            this.txtRegionCode.CustomButton.Visible = false;
            this.txtRegionCode.Lines = new string[0];
            this.txtRegionCode.Location = new System.Drawing.Point(243, 115);
            this.txtRegionCode.MaxLength = 32767;
            this.txtRegionCode.Name = "txtRegionCode";
            this.txtRegionCode.PasswordChar = '\0';
            this.txtRegionCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRegionCode.SelectedText = "";
            this.txtRegionCode.SelectionLength = 0;
            this.txtRegionCode.SelectionStart = 0;
            this.txtRegionCode.ShortcutsEnabled = true;
            this.txtRegionCode.Size = new System.Drawing.Size(249, 23);
            this.txtRegionCode.TabIndex = 1;
            this.txtRegionCode.UseSelectable = true;
            this.txtRegionCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegionCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRegionName
            // 
            // 
            // 
            // 
            this.txtRegionName.CustomButton.Image = null;
            this.txtRegionName.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtRegionName.CustomButton.Name = "";
            this.txtRegionName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRegionName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRegionName.CustomButton.TabIndex = 1;
            this.txtRegionName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRegionName.CustomButton.UseSelectable = true;
            this.txtRegionName.CustomButton.Visible = false;
            this.txtRegionName.Lines = new string[0];
            this.txtRegionName.Location = new System.Drawing.Point(243, 139);
            this.txtRegionName.MaxLength = 32767;
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.PasswordChar = '\0';
            this.txtRegionName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRegionName.SelectedText = "";
            this.txtRegionName.SelectionLength = 0;
            this.txtRegionName.SelectionStart = 0;
            this.txtRegionName.ShortcutsEnabled = true;
            this.txtRegionName.Size = new System.Drawing.Size(249, 23);
            this.txtRegionName.TabIndex = 2;
            this.txtRegionName.UseSelectable = true;
            this.txtRegionName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegionName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grdRegions
            // 
            this.grdRegions.AllowUserToAddRows = false;
            this.grdRegions.AllowUserToDeleteRows = false;
            this.grdRegions.AllowUserToResizeRows = false;
            this.grdRegions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdRegions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdRegions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdRegions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRegions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdRegions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdRegion,
            this.colRegionCode,
            this.colRegionName,
            this.colRegionType,
            this.colProjectName,
            this.colStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdRegions.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdRegions.EnableHeadersVisualStyles = false;
            this.grdRegions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdRegions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdRegions.Location = new System.Drawing.Point(34, 297);
            this.grdRegions.Name = "grdRegions";
            this.grdRegions.ReadOnly = true;
            this.grdRegions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRegions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdRegions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdRegions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRegions.Size = new System.Drawing.Size(626, 204);
            this.grdRegions.TabIndex = 8;
            this.grdRegions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRegions_CellDoubleClick);
            this.grdRegions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdRegions_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(144, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Region Code :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(144, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Region Name :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(177, 88);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "City :";
            // 
            // ProjectStartDate
            // 
            this.ProjectStartDate.Location = new System.Drawing.Point(243, 194);
            this.ProjectStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.ProjectStartDate.Name = "ProjectStartDate";
            this.ProjectStartDate.Size = new System.Drawing.Size(249, 29);
            this.ProjectStartDate.TabIndex = 4;
            // 
            // cbxCities
            // 
            this.cbxCities.FormattingEnabled = true;
            this.cbxCities.ItemHeight = 23;
            this.cbxCities.Location = new System.Drawing.Point(243, 84);
            this.cbxCities.Name = "cbxCities";
            this.cbxCities.Size = new System.Drawing.Size(249, 29);
            this.cbxCities.TabIndex = 0;
            this.cbxCities.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.chkStore);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(243, 225);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(249, 29);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // chkStore
            // 
            this.chkStore.AutoSize = true;
            this.chkStore.Location = new System.Drawing.Point(23, 6);
            this.chkStore.Name = "chkStore";
            this.chkStore.Size = new System.Drawing.Size(66, 15);
            this.chkStore.TabIndex = 2;
            this.chkStore.Text = "InActive";
            this.chkStore.UseSelectable = true;
            // 
            // lblProjectStartDate
            // 
            this.lblProjectStartDate.AutoSize = true;
            this.lblProjectStartDate.Location = new System.Drawing.Point(140, 192);
            this.lblProjectStartDate.Name = "lblProjectStartDate";
            this.lblProjectStartDate.Size = new System.Drawing.Size(97, 19);
            this.lblProjectStartDate.TabIndex = 4;
            this.lblProjectStartDate.Text = "Creation Date :";
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(243, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSave.TileImage")));
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(144, 166);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Region Type :";
            // 
            // cbxRegiontype
            // 
            this.cbxRegiontype.FormattingEnabled = true;
            this.cbxRegiontype.ItemHeight = 23;
            this.cbxRegiontype.Items.AddRange(new object[] {
            "",
            "Metropolitan Area",
            "Village Area"});
            this.cbxRegiontype.Location = new System.Drawing.Point(243, 163);
            this.cbxRegiontype.Name = "cbxRegiontype";
            this.cbxRegiontype.Size = new System.Drawing.Size(249, 29);
            this.cbxRegiontype.TabIndex = 3;
            this.cbxRegiontype.UseSelectable = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdRegion";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdRegion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RegionCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Region Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RegionName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Region Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn4.HeaderText = "City Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn5.HeaderText = "City Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // colIdRegion
            // 
            this.colIdRegion.DataPropertyName = "IdRegion";
            this.colIdRegion.HeaderText = "IdRegion";
            this.colIdRegion.Name = "colIdRegion";
            this.colIdRegion.ReadOnly = true;
            this.colIdRegion.Visible = false;
            // 
            // colRegionCode
            // 
            this.colRegionCode.DataPropertyName = "RegionCode";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colRegionCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRegionCode.HeaderText = "Region Code";
            this.colRegionCode.Name = "colRegionCode";
            this.colRegionCode.ReadOnly = true;
            this.colRegionCode.Width = 80;
            // 
            // colRegionName
            // 
            this.colRegionName.DataPropertyName = "RegionName";
            this.colRegionName.HeaderText = "Region Name";
            this.colRegionName.Name = "colRegionName";
            this.colRegionName.ReadOnly = true;
            this.colRegionName.Width = 180;
            // 
            // colRegionType
            // 
            this.colRegionType.DataPropertyName = "RegionSubType";
            this.colRegionType.HeaderText = "Type";
            this.colRegionType.Name = "colRegionType";
            this.colRegionType.ReadOnly = true;
            this.colRegionType.Width = 150;
            // 
            // colProjectName
            // 
            this.colProjectName.DataPropertyName = "CityName";
            this.colProjectName.HeaderText = "City Name";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.ReadOnly = true;
            this.colProjectName.Width = 120;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "IsActive";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 50;
            // 
            // frmRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.cbxRegiontype);
            this.Controls.Add(this.cbxCities);
            this.Controls.Add(this.ProjectStartDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRegionCode);
            this.Controls.Add(this.lblProjectStartDate);
            this.Controls.Add(this.txtRegionName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.grdRegions);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.KeyPreview = true;
            this.Name = "frmRegions";
            this.Text = "Regions / Area Setup";
            this.Load += new System.EventHandler(this.frmRegions_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRegions_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grdRegions)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTextBox txtRegionCode;
        private MetroFramework.Controls.MetroTextBox txtRegionName;
        private MetroFramework.Controls.MetroGrid grdRegions;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime ProjectStartDate;
        private MetroFramework.Controls.MetroComboBox cbxCities;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox chkStore;
        private MetroFramework.Controls.MetroLabel lblProjectStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbxRegiontype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
    }
}