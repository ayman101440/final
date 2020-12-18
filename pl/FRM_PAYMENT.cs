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
    public partial class FRM_PAYMENT : Form
    {
        bl.CLS_MANY pay = new bl.CLS_MANY ();
        public FRM_PAYMENT()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
             FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();
            frm.ShowDialog();
           // if (frm.dgvcustomers.CurrentRow.Cells[5].Value is DBNull)
               
                this.id.Text = frm.dgvcustomers.CurrentRow.Cells[0].Value.ToString();
                this.txtfirstname.Text = frm.dgvcustomers.CurrentRow.Cells[1].Value.ToString() + " " + frm.dgvcustomers.CurrentRow.Cells[2].Value.ToString();
                txtmony.Focus();
            
            
           



        }

      

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (id.Text == string.Empty)
            {
                MessageBox.Show("الرجاء اختيار العميل ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                button1.Focus();
                return;

            }
            if (txtmony.Text == string.Empty)
            {
                MessageBox.Show("الرجاء كتابة المبلغ ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtmony.Focus(); 
                return;
                
            }
           
            pay.ADD_PAYMENT(Convert.ToInt32(id.Text),
                       txtmony.Text, dtmtime.Value, txtnots.Text);

            MessageBox.Show("تم الاضافة بنجاح ", "عملية الاضافة ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnnew.Enabled = true;
            btnadd.Enabled = false;
            button1.Enabled = false;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            id.Clear();
            txtfirstname.Clear();
            txtmony.Clear();
            txtnots.Clear();
            
            btnadd.Enabled = true;
            btnnew.Enabled = false;
        }

        private void FRM_PAYMENT_Load(object sender, EventArgs e)
        {
            btnnew.Focus();
        }
        
    }
}
