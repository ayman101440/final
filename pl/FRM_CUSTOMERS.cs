using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication10.pl
{
    public partial class FRM_CUSTOMERS : Form
    {
        bl.CLS_CUSTOMERS cust = new bl.CLS_CUSTOMERS();
        int id, position;
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            this.dglist.DataSource = cust.GET_ALL_CUSTOMERS();
            dglist.Columns[0].Visible = false;
            dglist.Columns[5].Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] picture;
                if (pbox.Image == null)
                {
                    picture = new byte[0];
                    cust.ADD_CUSTOMER(txtfirstname.Text, txtlastname.Text, txttel.Text, txtemail.Text, picture, "without_image");
                    MessageBox.Show("تمت اضافة العميل بنجاح ", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dglist.DataSource = cust.GET_ALL_CUSTOMERS();
                }
                else
                {

                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    picture = ms.ToArray();

                    cust.ADD_CUSTOMER(txtfirstname.Text, txtlastname.Text, txttel.Text, txtemail.Text, picture, "with_image");
                    MessageBox.Show("تمت اضافة العميل بنجاح ", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dglist.DataSource = cust.GET_ALL_CUSTOMERS();
                }
            }
            catch
            {
                return;

            }
            finally
            {
                btnadd.Enabled = false;
                btnnew.Enabled = true;
            }
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF; *.BMP";
            if (op.ShowDialog() == DialogResult.OK)
                pbox.Image = Image.FromFile(op.FileName);
            btnadd.Focus();
        }

        private void FRM_CUSTOMERS_Load(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txttel.Clear();
            pbox.Image = null;
            txtfirstname.Focus();
            btnadd.Enabled = true;
            btnnew.Enabled = false;

        }

        private void txtfirstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtlastname.Focus();

            }
        }

        private void txtlastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txttel.Focus();

            }
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtemail.Focus();

            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbox.Focus();

            }
        }

        private void dglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dglist_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pbox.Image = null;
                id =Convert.ToInt32(dglist.CurrentRow.Cells[0].Value);
                this.txtfirstname.Text = dglist.CurrentRow.Cells[1].Value.ToString();
                this.txtlastname.Text = dglist.CurrentRow.Cells[2].Value.ToString();
                this.txttel.Text = dglist.CurrentRow.Cells[3].Value.ToString();
                this.txtemail.Text = dglist.CurrentRow.Cells[4].Value.ToString();
                byte[] picture = (byte[])dglist.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(picture);
                pbox.Image = Image.FromStream(ms);
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
                byte[] picture;
                if (pbox.Image == null)
                {
                    picture = new byte[0];
                    cust.EDIT_CUSTOMER(txtfirstname.Text, txtlastname.Text, txttel.Text, txtemail.Text, picture, "without_image",id);
                    MessageBox.Show("تمت تعديل بيانات العميل بنجاح ", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dglist.DataSource = cust.GET_ALL_CUSTOMERS();
                }
                else
                {

                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    picture = ms.ToArray();

                    cust.EDIT_CUSTOMER(txtfirstname.Text, txtlastname.Text, txttel.Text, txtemail.Text, picture, "with_image",id);
                    MessageBox.Show("تمت تعديل بيانات العميل بنجاح ", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dglist.DataSource = cust.GET_ALL_CUSTOMERS();
                }
            }
            catch
            {
                return;

            }
        
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

                cust.DELETE_CUSTOMER(id);
                MessageBox.Show("تم حذف العميل بنجاح ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dglist.DataSource = cust.GET_ALL_CUSTOMERS();
               
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            dglist.DataSource = cust.search_CUSTOMER(txtsearch.Text);
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button10_Click(sender, e);

            }
        }
        void navigate(int index)
        {
            try
            {

                pbox.Image = null;

                DataRowCollection drc = cust.GET_ALL_CUSTOMERS().Rows;
                id =Convert.ToInt32( drc[index][0]);
                txtfirstname.Text = drc[index][1].ToString();
                txtlastname.Text = drc[index][2].ToString();
                txttel.Text = drc[index][3].ToString();
                txtemail.Text = drc[index][4].ToString();
                byte[] picture = (byte[])drc[index][5];
                MemoryStream ms = new MemoryStream(picture);
                pbox.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }



        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            navigate(0);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            position = cust.GET_ALL_CUSTOMERS().Rows.Count - 1;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (position == cust.GET_ALL_CUSTOMERS().Rows.Count-1   )
            {
                MessageBox.Show("هذا هو اخر عنصر ");
                return;
            }
            position += 1;
            navigate(position);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
