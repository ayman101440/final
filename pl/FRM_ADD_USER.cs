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
    public partial class FRM_ADD_USER : Form
    {
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtid.Text == string.Empty || txtpwd.Text == string.Empty
                || txtfullname.Text == string.Empty || txtpwdconfirm.Text == string.Empty)
            {
                MessageBox.Show("ادخل جميع البيانات  ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtpwd.Text != txtpwdconfirm.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة   ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnsave.Text == "حفظ المستخدم ")
            {

                bl.CLS user = new bl.CLS();
                user.ADD_USER(txtid.Text, txtfullname.Text, txtpwd.Text, cmbtype.Text);
                MessageBox.Show("تم انشاء المستخدم ", "اضافة مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnsave.Text == "تعديل المستخدم ")
            {
                bl.CLS user = new bl.CLS();
                user.EDIT_USER(txtid.Text, txtfullname.Text, txtpwd.Text, cmbtype.Text);
                MessageBox.Show("تم تعديل المستخدم ", "تعديل مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            txtid.Clear();
            txtpwd.Clear();
            txtpwdconfirm.Clear();
            txtfullname.Clear();
            
            txtid.Focus();


        }

        private void txtpwdconfirm_Validated(object sender, EventArgs e)
        {
            if (txtpwd.Text != txtpwdconfirm.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة   ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
