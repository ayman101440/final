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
    public partial class FRM_MINES_PRODUCT : Form
    {
        bl.CLS_ALL_RPT_ allrpt = new bl.CLS_ALL_RPT_();
        public FRM_MINES_PRODUCT()
        {
            InitializeComponent();
        }

        private void FRM_MINES_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int order_id = Convert.ToInt32(textBox1.Text);
            rpt.rptminesprodictd report = new rpt.rptminesprodictd();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            report.SetDataSource(allrpt.verfqtymains(order_id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
               // MessageBox.Show("ادخل ارقام ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
