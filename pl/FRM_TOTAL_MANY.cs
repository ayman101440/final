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
    public partial class FRM_TOTAL_MANY : Form
    {
        bl.CLS_MANY mony = new bl.CLS_MANY();
        public FRM_TOTAL_MANY()
        {
            InitializeComponent();
            this.dgvtotal.DataSource = mony.LASTPROC("");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvtotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtschrch_TextChanged(object sender, EventArgs e)
        {
            this.dgvtotal.DataSource = mony.LASTPROC(txtschrch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
