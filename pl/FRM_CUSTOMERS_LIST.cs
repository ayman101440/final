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
    public partial class FRM_CUSTOMERS_LIST : Form
    {
        bl.CLS_CUSTOMERS cust = new bl.CLS_CUSTOMERS();

        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();
            this.dgvcustomers.DataSource = cust.GET_ALL_CUSTOMERS();
            this.dgvcustomers.Columns[0].Visible = false;
            this.dgvcustomers.Columns[5].Visible = false;
        }

        private void dgvcustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcustomers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
