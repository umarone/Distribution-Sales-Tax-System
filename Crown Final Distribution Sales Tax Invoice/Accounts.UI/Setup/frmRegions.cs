using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.EL;
using Accounts.Common;
using Accounts.BLL;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmRegions : MetroForm
    {
        #region Variables
        Int64 IdRegion = 0;
        Int64 IdCompany = 0;
        #endregion
        #region Form Events And Methods
        public frmRegions()
        {
            InitializeComponent();
        }
        private void frmRegions_Load(object sender, EventArgs e)
        {
            this.grdRegions.AutoGenerateColumns = false;
            FillRegions();
            //FillProjects();
            FillCities();
        }
        private void frmRegions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                clearControls();
            }
        }
        #endregion
        #region Simple Methods
        private void FillCities()
        {
            var manager = new CityBLL();
            List<CityEL> list = manager.GetAllCities();
            if (list.Count > 0)
            {
                list.RemoveAll(x => x.IsActive == false);
                list.Insert(0, new CityEL() { IdCity = 0, CityName = "Select City" });
                cbxCities.DataSource = list;
                cbxCities.DisplayMember = "CityName";
                cbxCities.ValueMember = "IdCity";
                cbxCities.SelectedIndex = 0;
            }
        }
        //private void FillRegions()
        //{
        //    var manager = new RegionBLL();
        //    List<RegionEL> list = manager.List();
        //    if (list.Count > 0)
        //    {
        //        list.Insert(0, new RegionEL() { IdRegion = Guid.Empty, RegionName = "Select Region" });
        //        cbxRegions.DataSource = list;
        //        cbxRegions.DisplayMember = "RegionName";
        //        cbxRegions.ValueMember = "IdRegion";
        //        cbxRegions.SelectedIndex = 0;
        //    }
        //    else
        //        grdProjects.DataSource = null;

        //}
        private void FillRegions()
        {
            var manager = new RegionsBLL();
            List<RegionsEL> list = manager.GetAllRegions();
            if (list.Count > 0)
            {
                grdRegions.DataSource = list;
            }
            else
                grdRegions.DataSource = null;
        }
        private bool ValidateProject()
        {
            bool status = true;
            if (txtRegionName.Text == string.Empty)
            {
                status = false;
            }
            if (cbxCities.SelectedIndex == 0)
            {
                status = false;
            }
            return status;
        }
        private void clearControls()
        {
            cbxCities.SelectedIndex = 0;
            IdRegion = 0;
            txtRegionCode.Text = string.Empty;
            txtRegionName.Text = string.Empty;
        }
        #endregion
        #region Grid Events And Methods
        private void grdRegions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                IdRegion = Validation.GetSafeLong(grdRegions.Rows[e.RowIndex].Cells["colIdRegion"].Value);
                GetRegion(IdRegion);
                txtRegionName.Focus();
            }
        }
        private void grdRegions_KeyPress(object sender, KeyPressEventArgs e)
        {
            IdRegion = Validation.GetSafeLong(grdRegions.CurrentRow.Cells["colIdRegion"].Value);
            GetRegion(IdRegion);
            txtRegionName.Focus();
        }
        private void GetRegion(Int64 IdRegion)
        {
            var manager = new RegionsBLL();
            RegionsEL obj = manager.GetRegionById(IdRegion)[0];
            if (obj != null)
            {
                txtRegionCode.Text = obj.RegionCode.ToString();
                txtRegionName.Text = obj.RegionName;
                cbxCities.SelectedValue = obj.IdCity;
                cbxRegiontype.SelectedIndex = obj.RegionType;
                //cbxRegions.SelectedValue = obj.IdRegion;
            }
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateProject())
            {
                var manager = new RegionsBLL();
                RegionsEL obj = new RegionsEL();

                if (IdRegion == 0)
                {
                    obj.IdRegion = 0;
                }
                else
                {
                    obj.IdRegion = IdRegion;
                }
                //obj.IdRegion = Validation.GetSafeGuid(cbxRegions.SelectedValue);
                obj.IdCity = Validation.GetSafeLong(cbxCities.SelectedValue);
                obj.RegionCode = Validation.GetSafeString(txtRegionCode.Text);
                obj.RegionName = Validation.GetSafeString(txtRegionName.Text.Trim());
                if (cbxRegiontype.SelectedIndex == 1)
                    obj.RegionType = 1;
                else
                    obj.RegionType = 2;
                obj.CreatedDateTime = ProjectStartDate.Value;
                obj.ClosedDate = ProjectStartDate.Value;
                obj.IsActive = true;
                obj.Discription = "";
                if (IdRegion == 0)
                {
                    if (manager.CreateRegion(obj).IsSuccess)
                    {
                        clearControls();
                        FillCities();
                        FillRegions();
                    }
                }
                else
                {
                    if (manager.UpdateRegion(obj).IsSuccess)
                    {
                        clearControls();
                        FillCities();
                        FillRegions();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill Fields");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new RegionsBLL();
            if (manager.DeleteRegion(IdRegion).IsSuccess)
            {
                clearControls();
            }
        }
        #endregion
    }
}
