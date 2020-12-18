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
    
    public partial class FRM_PRODUCTS_LIST : Form
    {
        bl.CLS_PRODUCTS prd = new bl.CLS_PRODUCTS();
        public FRM_PRODUCTS_LIST()
        {
            InitializeComponent();
            this.dgvproduts.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void dgvproduts_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.searchProductname(txtSearch.Text);
            this.dgvproduts.DataSource = Dt;
        }
    }
}
