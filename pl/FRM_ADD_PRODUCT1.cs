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
    public partial class FRM_ADD_PRODUCT1 : Form
    {
        public string state = "add";
        bl.CLS_PRODUCTS prd = new bl.CLS_PRODUCTS();

        public FRM_ADD_PRODUCT1()
        {
            InitializeComponent();
            cmbCategories.DataSource = prd.GET_ALL_CATEGORIES();

            cmbCategories.DisplayMember = "description_cat";
            cmbCategories.ValueMember = "id_cat";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور| *.jpge;*.gif;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "add")
                {
                    MemoryStream ms = new MemoryStream();
                    pb.Image.Save(ms, pb.Image.RawFormat);
                    byte[] byteimage = ms.ToArray();

                    prd.ADD_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtDes.Text
                        , txtRef.Text, Convert.ToInt32(txtqte.Text), txtprice.Text, byteimage);
                    MessageBox.Show("تم الاضافة بنجاح ", "عملية الاضافة ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pb.Image.Save(ms, pb.Image.RawFormat);
                    byte[] byteimage = ms.ToArray();

                    prd.UPDATE_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtDes.Text
                        , txtRef.Text, Convert.ToInt32(txtqte.Text), txtprice.Text, byteimage);
                    MessageBox.Show("تم التعديل بنجاح ", "عملية الاضافة ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FRM_PRODUCT.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            }
            catch
            {
                MessageBox.Show("تاكد من جمبع البانات بالشكل الصحيه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
                return;
               // MessageBox.Show("تاكد من جمبع البانات بالشكل الصحيه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prd.verifyproductid(txtRef.Text);
                if (Dt.Rows.Count > 0)
                {

                    MessageBox.Show("الرقم موجود  ", "تنبية  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;

                }
            }

        }

        private void FRM_ADD_PRODUCT1_Load(object sender, EventArgs e)
        {

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
