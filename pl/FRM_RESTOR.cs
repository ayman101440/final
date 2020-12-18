using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication10.pl
{
    public partial class FRM_RESTOR : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-50SF8F9; Database= master; Integrated Security =true ");
        SqlCommand cmd;
        public FRM_RESTOR()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BACKUP FILE (*.bak)|*.bak";
            openFileDialog1.Title = "SELECT BACKUP FILE";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfilename.Text = openFileDialog1.FileName;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {/*
//this.Cursor = Cursors.WaitCursor;
                con.Open();
                string dd = txtfilename.Text;
               // string strquery = "USE [master]RESTORE DATABASE [centra] FROM  DISK = N'"+txtfilename.Text+"' WITH  FILE = 1,  NOUNLOAD,  STATS = 10";
               
               string strquery = " ALTER Database centra SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database centra From Disk='" + dd + "'";
                cmd = new SqlCommand(strquery, con);
               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم استعادة نسخة احتياطية بنجاح ", "استعادة نسخ احتياطي  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  this.Cursor = Cursors.Default;
          * 
          * */

            try
            {
                con.Open();
                this.Cursor = Cursors.WaitCursor;
                string sqlStmt2 = string.Format("ALTER DATABASE [centra] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [centra] FROM DISK='" + txtfilename.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [centra] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                MessageBox.Show("تم استعادة نسخة احتياطية بنجاح ", "استعادة نسخ احتياطي  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
