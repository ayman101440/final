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
    
    public partial class FRM_SUM_COS_ACCUONT : Form
    {
        bl.CLS_MANY pay = new bl.CLS_MANY();
        public FRM_SUM_COS_ACCUONT()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();
            frm.ShowDialog();
            // if (frm.dgvcustomers.CurrentRow.Cells[5].Value is DBNull)

            this.id.Text = frm.dgvcustomers.CurrentRow.Cells[0].Value.ToString();
            this.txtname.Text = frm.dgvcustomers.CurrentRow.Cells[1].Value.ToString() + " " + frm.dgvcustomers.CurrentRow.Cells[2].Value.ToString();
                
            
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            int mony;
            int paym;
            int total;
            this.dgvmony.DataSource = pay.LASTPROC2(id.Text);
            this.dgvpayment.DataSource = pay.all_payments(id.Text);
            if (dgvmony.CurrentRow!=null)
                mony = Convert.ToInt32(dgvmony.CurrentRow.Cells[3].Value);
            else
                mony = 0;
            if (dgvpayment.CurrentRow != null)
                paym = Convert.ToInt32(dgvpayment.CurrentRow.Cells[3].Value);
            else
                paym = 0;
            if (paym > mony)
            {
                total = (mony - paym) * -1;
                txttotal.Text = (total).ToString();
                resalt.Text = "له";
                resalt.ForeColor = Color.Green;

            }
            else
            {
                total = (mony - paym);
                txttotal.Text = (total).ToString();
                resalt.Text = "عليه";
                resalt.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_SUM_COS_ACCUONT_Load(object sender, EventArgs e)
        {

        }
    }
}
