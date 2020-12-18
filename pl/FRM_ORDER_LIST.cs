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
    public partial class FRM_ORDER_LIST : Form
    {
        bl.CLS_ORDERS order = new bl.CLS_ORDERS();
        public FRM_ORDER_LIST()
        {
            InitializeComponent();
            this.dgvorder.DataSource = order.searchorders("");

        }

        private void btnsev_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int order_id =Convert.ToInt32( dgvorder.CurrentRow.Cells[0].Value);
            rpt.rpt_orders report = new rpt.rpt_orders();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            report.SetDataSource(order.GETORDERDETAILS(order_id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvorder.DataSource = order.searchorders(txtSearch.Text);
            }
            catch 
            
            {
                return;
            }
        }

        private void FRM_ORDER_LIST_Load(object sender, EventArgs e)
        {

        }
    }
}
