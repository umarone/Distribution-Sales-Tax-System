using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;
using Accounts.BLL;
using Accounts.EL;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmProductFocLedger : MetroForm
    {
        #region Variables
        frmFindProducts frmfindstock;
        frmFindAccounts frmfindaccounts;
        Int64? IdItem;
        string AccountNo;
        #endregion
        #region Form Methods And Variables
        public frmProductFocLedger()
        {
            InitializeComponent();
        }
        private void frmProductLedger_Load(object sender, EventArgs e)
        {
            this.grdProductLedger.AutoGenerateColumns = false;
        }
        #endregion
        #region Cutom Controls Events
        private void PEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                e.Handled = true;
                frmfindstock = new frmFindProducts();
                frmfindstock.SearchText = e.KeyChar.ToString();
                frmfindstock.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmfindstock_ExecuteFindPorudctsEvent);
                frmfindstock.ShowDialog();
            }
        }
        private void PEditBox_ButtonClick(object sender, EventArgs e)
        {
            frmfindstock = new frmFindProducts();
            frmfindstock.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmfindstock_ExecuteFindPorudctsEvent);
            frmfindstock.ShowDialog();
        }
        void frmfindstock_ExecuteFindPorudctsEvent(object Sender, ItemsEL oelItems) 
        {
            PEditBox.Text = oelItems.ItemName;
            IdItem = oelItems.IdItem;
        }
        #endregion
        #region Button Events
        private void btnProductReport_Click(object sender, EventArgs e)
        {            
            var manager = new ItemsBLL();
            List<ItemsEL> list = manager.GetProductFocLedger(IdItem);
            if (list.Count > 0)
            {
                PopulateLedger(list);
            }
            else
                MessageBox.Show("No Foc Ledger Found For This Product...");
        }
        private void btnLoadByDate_Click(object sender, EventArgs e)
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = manager.GetProductFocLedgerByDate(IdItem,dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                PopulateLedger(list);
            }
            else
                MessageBox.Show("No Foc Ledger Found For This Product Within These Dates...");
        }
        private void btnLoadByCustomer_Click(object sender, EventArgs e)
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = manager.GetProductFocLedgerByCustomer(IdItem, AccountNo);
            if (list.Count > 0)
            {
                PopulateLedger(list);
            }
            else
                MessageBox.Show("No Foc Ledger Found For This Product and Customer...");
        }
        private void PopulateLedger(List<ItemsEL> list)
        {
            decimal DebitStock = 0, CreditStock = 0, Balance = 0, Qty = 0, TotalValue = 0;
            if (list.Count > 0)
            {
                list.RemoveAll(x => x.Qty == 0);
                grdProductLedger.DataSource = list;
                for (int i = 0; i < list.Count; i++)
                {
                    if (Validation.GetSafeString(grdProductLedger.Rows[i].Cells["colType"].Value) == "In")
                    {
                        DebitStock = Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value);
                        Balance += DebitStock;
                        grdProductLedger.Rows[i].Cells["colClosing"].Value = Balance;//.ToString() + " KG";
                        Qty += Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value);

                    }
                    if (Validation.GetSafeString(grdProductLedger.Rows[i].Cells["colType"].Value) == "Out")
                    {
                        CreditStock = Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value);
                        Balance += CreditStock;
                        grdProductLedger.Rows[i].Cells["colClosing"].Value = Balance.ToString();
                        Qty += Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value);
                    }

                    //TotalValue += Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colValue"].Value);
                    //if (Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value) != 0)
                    //{
                    //    grdProductLedger.Rows[i].Cells["colPerUnitAvg"].Value = Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colValue"].Value) / Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value);
                    //}
                    //if (Qty > 0)
                    //{
                    //    //grdTanneryStockReport.Rows[i].Cells["colPerUnitAvg"].Value = (TotalValue / Qty).ToString("0.00");
                    //    grdProductLedger.Rows[i].Cells["colStockBalance"].Value = (Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colPerUnitAvg"].Value) * Balance).ToString("0.00");
                    //}
                }
            }
        }
        private void txtAccount_ButtonClick(object sender, EventArgs e)
        {
            frmfindaccounts = new frmFindAccounts();
            frmfindaccounts.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmfindaccounts_ExecuteFindAccountEvent);
            frmfindaccounts.ShowDialog();
        }
        void frmfindaccounts_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            AccountNo = oelAccount.AccountNo;
            txtAccount.Text = oelAccount.AccountName;
        }
        #endregion        
        #region CheckBoxes Events
        private void chkFocByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFocByDate.Checked)
            {
                pnlDate.Visible = true;
                chkFocByCustomer.Checked = false;
                pnlCustomer.Visible = false;
                grdProductLedger.DataSource = null;
                txtAccount.Text = string.Empty;
            }
            else
            {
                pnlDate.Visible = false;
                chkFocByCustomer.Checked = false;
                pnlCustomer.Visible = false;
                grdProductLedger.DataSource = null;
                txtAccount.Text = string.Empty;
            }
        }
        private void chkFocByCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFocByCustomer.Checked)
            {
                chkFocByDate.Checked = false;
                pnlDate.Visible = false;
                pnlCustomer.Visible = true;
                grdProductLedger.DataSource = null;
            }
            else
            {
                pnlDate.Visible = false;
                chkFocByCustomer.Checked = false;
                pnlCustomer.Visible = false;
                grdProductLedger.DataSource = null;
                txtAccount.Text = string.Empty;
            }
        }
        #endregion
    }
}
