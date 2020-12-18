using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10.pl
{
    public partial class FRM_BAY : Form
    {
        bl.CLS_BAY bay = new bl.CLS_BAY();
        public FRM_BAY()
        {
            InitializeComponent();
            this.dgvorder.DataSource = bay.searchbay("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvorder.DataSource = bay.searchbay(txtSearch.Text);
            }
            catch
            {
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int bay_id = Convert.ToInt32(dgvorder.CurrentRow.Cells[0].Value);
            rpt.rpt_bay report = new rpt.rpt_bay();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            report.SetDataSource(bay.GETBAYDETAILS(bay_id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();

            this.Cursor = Cursors.Default;
        }
    }
}
