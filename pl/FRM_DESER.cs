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
   
   
    public partial class FRM_DESER : Form
    {
        bl.CLS_DESER deser = new bl.CLS_DESER();
        public FRM_DESER()
        {
            InitializeComponent();
            cmbdesertype.DataSource = deser.GET_ALL_DESER();

            cmbdesertype.DisplayMember = "deser_name";
            cmbdesertype.ValueMember = "deser_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_DESER_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{


                deser.ADD_DESER( Convert.ToInt32(txtid.Text), txtprice.Text
                        , dtpdeser.Value, txtDes.Text, Convert.ToInt32(cmbdesertype.SelectedValue));
                    MessageBox.Show("تم الاضافة بنجاح ", "عملية الاضافة ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtid.Clear();
                    txtprice.Clear();
                    txtDes.Clear();
                    txtid.Focus();


                
                   
            }
            catch
            {
                MessageBox.Show("تاكد من جمبع البانات بالشكل الصحيه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
                // MessageBox.Show("تاكد من جمبع البانات بالشكل الصحيه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
      
        }
    }
}
