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
    
    public partial class FRM_LOGIN : Form
    {
        bl.CLS log = new bl.CLS();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.login(txtid.Text, txtpwo.Text);
            if (Dt.Rows.Count > 0)
            {
               
                if (Dt.Rows[0][2].ToString() == "مدير")
                {
                   
                    // MessageBox.Show("login sacces");
                    FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                    // FRM_MAIN.getMainForm.ملفToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.انشاءنسخةاحطياطيةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                   // FRM_MAIN.getMainForm.التقاريرToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المشترياتToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.الموردينToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.الصندوقToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المبيعاتToolStripMenuItem.Enabled = true;
                    
                    
                    FRM_MAIN.getMainForm.استعادةنسخةاحطياطيةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Visible = true;
                    
                    Program.salesman = Dt.Rows[0]["fullname"].ToString();
                   
                    this.Close();
                    MessageBox.Show("نم تسجيل الدخول بنجاح ","حاله الدخول");
                }
                else if (Dt.Rows[0][2].ToString() == "موظف")
                {
                   
                    // MessageBox.Show("login sacces");
                    FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                    // FRM_MAIN.getMainForm.ملفToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.انشاءنسخةاحطياطيةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Visible = false;
                    FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                   // FRM_MAIN.getMainForm.التقاريرToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.استعادةنسخةاحطياطيةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المشترياتToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.الموردينToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.الصندوقToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المبيعاتToolStripMenuItem.Enabled = true;
                    Program.salesman = Dt.Rows[0]["fullname"].ToString();

                    
                   
                    this.Close();
                    MessageBox.Show("نم تسجيل الدخول بنجاح ", "حاله الدخول");
                }
            }
            else
             {
                 MessageBox.Show("تاكد من صحة البيانات المدخله ","خطاء في تسجيل الدخول ");
            }

        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
            btnlogin.Focus();
        }
    }
}
