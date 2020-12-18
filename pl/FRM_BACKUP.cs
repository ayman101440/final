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
    public partial class FRM_BACKUP : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-50SF8F9; Database= centra; Integrated Security =true ");
        SqlCommand cmd;
     


        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfilename.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string filename = txtfilename.Text + "centra" + DateTime.Now.ToShortDateString().Replace('/','-')
              +"---"  + DateTime.Now.ToLongTimeString().Replace(':','-');
            string strquery = "Backup Database centra to Disk='" + filename + ".bak'";
            cmd = new SqlCommand(strquery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم انشاء نسخة احتياطية بنجاح ", "نسخ احتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);
           this.Cursor = Cursors.Default;
        }
        
           
           
           

          
    }
}
