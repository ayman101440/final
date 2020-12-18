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
    public partial class FRM_SUB_LIST : Form
    {
        bl.CLS_SUB sub = new bl.CLS_SUB();
        public FRM_SUB_LIST()
        {
            InitializeComponent();
            this.dgvcustomers.DataSource = sub.GET_ALL_sub();
           
        }

        private void FRM_SUB_LIST_Load(object sender, EventArgs e)
        {

        }

        private void dgvcustomers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
