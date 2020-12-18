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
    public partial class FRM_ADD_DESER_TYPE : Form
    {
        bl.CLS_DESER deser = new bl.CLS_DESER();
        public FRM_ADD_DESER_TYPE()
        {
            InitializeComponent();
            this.dglist.DataSource = deser.searchdeser("");
        }

        private void FRM_ADD_DESER_TYPE_Load(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            this.txtid.Text = deser.GET_LAST_DESER_ID().Rows[0][0].ToString();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                
                 if (txtdes.Text == string.Empty) 
            {
                MessageBox.Show("الرجاء تاكد من اسم النوع ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             

            deser.ADD_DESER_TYPE(Convert.ToInt32(txtid.Text), txtdes.Text);
            MessageBox.Show("تم الحفظ بنجاح ", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dglist.DataSource = deser.searchdeser("");
             }
            catch{
                return;
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من عملية الحذف ", "حذف النوع ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                deser.DELETE_DERSRE(dglist.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.dglist.DataSource = deser.searchdeser("");
            }
            
        }
    }
}
