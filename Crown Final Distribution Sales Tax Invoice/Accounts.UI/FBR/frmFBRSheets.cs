using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;
using Accounts.EL;
using Accounts.BLL;
using Accounts.Common;
using SpreadsheetLight;
using System.Diagnostics;


namespace Accounts.UI
{
    public partial class frmFBRSheets : MetroForm
    {
        public frmFBRSheets()
        {
            InitializeComponent();
        }
        private void frmFBRSheets_Load(object sender, EventArgs e)
        {
            this.grdTaxSheet.AutoGenerateColumns = false;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new FBRBLL();
            List<VouchersEL> list = manager.GetFBRReportsByDate(Operations.IdProject, Operations.BookNo, cbxSheets.SelectedIndex, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                grdTaxSheet.DataSource = list;
            }
            else
            {
                MessageBox.Show("No Data Found...");
                grdTaxSheet.DataSource = null;
            }

        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdTaxSheet.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdTaxSheet.Columns)
                {
                    if (column.Visible)
                    {
                        dt.Columns.Add(column.HeaderText);
                    }
                }

                //Add Header Rows....
                dt.Rows.Add();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dt.Rows[0][i] = dt.Columns[i].ColumnName; //"Account Name"; 
                }

                // Add Empty Row....
                dt.Rows.Add();
                for (int i = 0; i < grdTaxSheet.Columns.Count; i++)
                {
                    if (i != dt.Columns.Count)
                    {
                        dt.Rows[1][i] = "";
                    }
                    else
                    {
                        break;
                    }
                }

                foreach (DataGridViewRow row in grdTaxSheet.Rows)
                {
                    dt.Rows.Add();
                    int colindex = 0;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //if (cell.Value != null)
                        //{
                        if (cell.Visible)
                        {
                            //dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            dt.Rows[dt.Rows.Count - 1][colindex] = cell.Value ?? 0.ToString();
                            colindex++;
                        }
                        //}
                    }
                }

                SLDocument slExcelExport = new SLDocument();


                for (int i = 0; i < dt.Columns.Count; i++)
                {

                    slExcelExport.SetColumnWidth(i, 20);
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        slExcelExport.SetCellValue(j + 1, i + 1, dt.Rows[j].ItemArray[i].ToString());
                    }
                }
                slExcelExport.Save();

                Process.Start("FBRSheet.xlsx");
            }
        }
    }
}
