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
    public partial class FRM_USRES_LIST : Form
    {
        bl.CLS login = new bl.CLS();
        public FRM_USRES_LIST()
        {
            InitializeComponent();
            this.dgvusers.DataSource = login.searchusres("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.btnsave.Text = "حفظ المستخدم ";
            frm.ShowDialog();
            this.dgvusers.DataSource = login.searchusres("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.txtid.Text = dgvusers.CurrentRow.Cells[0].Value.ToString();
            frm.txtfullname.Text = dgvusers.CurrentRow.Cells[1].Value.ToString();
            frm.txtpwd.Text = dgvusers.CurrentRow.Cells[2].Value.ToString();
            frm.txtpwdconfirm.Text = dgvusers.CurrentRow.Cells[2].Value.ToString();
            frm.cmbtype.Text = dgvusers.CurrentRow.Cells[3].Value.ToString();
            frm.btnsave.Text = "تعديل المستخدم ";
            frm.ShowDialog();
            this.dgvusers.DataSource = login.searchusres("");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvusers.DataSource = login.searchusres(txtSearch.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من عملية الحذف ", "حذف المستخدم ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                login.DELETE_USER(dgvusers.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.dgvusers.DataSource = login.searchusres("");
            }
        }
    }
}
