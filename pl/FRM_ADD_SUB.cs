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
    public partial class FRM_ADD_SUB : Form
    {
        bl.CLS_SUB sub = new bl.CLS_SUB();
        int id, position;
        public FRM_ADD_SUB()
        {
            InitializeComponent();
            this.dglist.DataSource = sub.GET_ALL_sub();
        }
        void navigate(int index)
        {
            try
            {

               

                DataRowCollection drc = sub.GET_ALL_sub().Rows;
                id = Convert.ToInt32(drc[index][0]);
                txtfirstname.Text = drc[index][1].ToString();
                txtlastname.Text = drc[index][2].ToString();
                txttel.Text = drc[index][3].ToString();
                txtemail.Text = drc[index][4].ToString();
               
            }
            catch
            {
                return;
            }



        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txttel.Clear();
           
            txtfirstname.Focus();
            btnadd.Enabled = true;
            btnnew.Enabled = false;
          /*  txtfirstname.Enabled = true;
            txtfirstname.Focus();*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
            sub.ADD_sub(txtfirstname.Text, txtlastname.Text, txttel.Text, txtemail.Text);
            MessageBox.Show("تمت اضافة العميل بنجاح ", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dglist.DataSource = sub.GET_ALL_sub();
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_ADD_SUB_Load(object sender, EventArgs e)
        {

        }
       

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("العميل المراد حذفه غير موجود ");
                return;
            }
            if (MessageBox.Show("هل انت متاكد من عملية الحذف ", "حذف العميل ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                sub.DELETE_SUB(id);
                MessageBox.Show("تم حذف العميل بنجاح ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dglist.DataSource = sub.GET_ALL_sub();

            }
        }

        private void dglist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dglist_DoubleClick(object sender, EventArgs e)
        {
            
            try
            {
                
                id = Convert.ToInt32(dglist.CurrentRow.Cells[0].Value);
                this.txtfirstname.Text = dglist.CurrentRow.Cells[1].Value.ToString();
                this.txtlastname.Text = dglist.CurrentRow.Cells[2].Value.ToString();
                this.txttel.Text = dglist.CurrentRow.Cells[3].Value.ToString();
                this.txtemail.Text = dglist.CurrentRow.Cells[4].Value.ToString();
              
               
            }
            catch
            {
                return;
            }
        
        }

        private void btneidt_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("العميل المراد تعديله  غير موجود ");
                    return;
                }
                          
            
               sub.EDIT_SUB(txtfirstname.Text, txtlastname.Text, txttel.Text, txtemail.Text,id);
               MessageBox.Show("تمت تعديل بيانات العميل بنجاح ", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.dglist.DataSource = sub.GET_ALL_sub();
               

            }
            catch
            {
                return;

            }
        
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dglist.DataSource = sub.search_sub(txtsearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (position == sub.GET_ALL_sub().Rows.Count - 1)
            {
                MessageBox.Show("هذا هو اخر عنصر ");
                return;
            }
            position += 1;
            navigate(position);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (position == 0)
            {
                MessageBox.Show("هذا هو اول عنصر ");
                return;
            }
            position -= 1;
            navigate(position);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            position = sub.GET_ALL_sub().Rows.Count - 1;
            navigate(position);
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            navigate(0);
        }
        }
    }

