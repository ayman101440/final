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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            txtserver.Text = Properties.Settings.Default.server;
            txtdatabase.Text = Properties.Settings.Default.database;
            if (Properties.Settings.Default.database == "SQL")
            {
                rbsql.Checked = true;
                txtid.Text = Properties.Settings.Default.id;
                txtpwd.Text = Properties.Settings.Default.password;

            }
            else
            {

                rbwindows.Checked = true;
                txtid.Clear();
                txtpwd.Clear();
                txtid.ReadOnly = true;
                txtpwd.ReadOnly = true;

            }
             }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = txtserver.Text;
            Properties.Settings.Default.database = txtdatabase.Text;
            Properties.Settings.Default.mode = rbsql.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.id = txtid.Text;
            Properties.Settings.Default.password = txtpwd.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ", "اتصال", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rbsql_CheckedChanged(object sender, EventArgs e)
        {
            txtid.ReadOnly = false;
            txtpwd.ReadOnly = false;
        }

        private void rbwindows_CheckedChanged(object sender, EventArgs e)
        {
            txtid.ReadOnly = true;
            txtpwd.ReadOnly = true;
        }

        private void btneixt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
