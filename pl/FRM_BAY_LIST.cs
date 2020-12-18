using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace WindowsFormsApplication10.pl
{
    public partial class FRM_BAY_LIST : Form
    {
        bl.CLS_BAY bay = new bl.CLS_BAY();
        DataTable dt = new DataTable();
        public FRM_BAY_LIST()
        {
            InitializeComponent();
            txtsalesman.Text = Program.salesman;
            createdatatable();
           // resizedgv();
        }
        void calculaemount()
        {
            if (txtprice.Text != string.Empty && txtqty.Text != string.Empty)
            {
                //  Convert.ToDouble(txtprice.Text) * Convert.ToInt32(txtqty.Text);
                txtamoumt.Text = (Convert.ToDouble(txtprice.Text) * Convert.ToInt32(txtqty.Text)).ToString();
            }
        }

        void calcultotalaemount()
        {
            if (txtdiscount.Text != string.Empty && txtamoumt.Text != string.Empty)
            {
               
                double amount = Convert.ToDouble(txtamoumt.Text);
                double totalamount = amount ;
                txttotalamount.Text = totalamount.ToString();
            }

        }

        void clearboxes()
        {
            txtidproduct.Clear();
            txtnameproduct.Clear();
            txtprice.Clear();
            txtqty.Clear();
            txtamoumt.Clear();
            txtdiscount.Text = "0";
            txttotalamount.Clear();
            btnbrowse.Focus();
        }
        void cleardata()
        {
            txtorderid.Clear();
            txtdesorder.Clear();
           //txtsalesman.Clear();
            dtorder.ResetText();
            txtcustomerid.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txttel.Clear();
            txtemail.Clear();
            clearboxes();
            dt.Clear();
            txtsuntotals.Clear();
            pbox.Image = null;
            dgvproducts.DataSource = null;
            btnadd.Enabled = false;
            btnnew.Enabled = true;
           
            btnprint.Enabled = true;
        }
        void createdatatable()
        {
            dt.Columns.Add("رقم المنتج ");
            dt.Columns.Add("اسم المنتج ");
            dt.Columns.Add("سعر المنتج ");
            dt.Columns.Add("الكمية ");
            dt.Columns.Add("المبلغ  ");
            dt.Columns.Add("الخصم)%(  ");
            dt.Columns.Add("الاجمالي ");

            dgvproducts.DataSource = dt;

            /* لاضافة زر داخل اداه الداتا قرايد فيو 
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "اختيار المنتج ";
            btn.Text = "البحث ";
            btn.UseColumnTextForButtonValue = true;
            dgvproducts.Columns.Insert(0,btn);*/
        }
        void resizedgv()
        {
           /* this.dgvproducts.RowHeadersWidth = 93;
             this.dgvproducts.Columns[0].Width = 104;
              this.dgvproducts.Columns[1].Width = 180;
              this.dgvproducts.Columns[2].Width = 99;
              this.dgvproducts.Columns[3].Width = 99;
              this.dgvproducts.Columns[4].Width = 99;
              this.dgvproducts.Columns[5].Width = 99;
              this.dgvproducts.Columns[6].Width = 120;*/
        }
      

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            clearboxes();
            FRM_PRODUCTS_LIST frm = new FRM_PRODUCTS_LIST();

            frm.ShowDialog();
            this.txtidproduct.Text = frm.dgvproduts.CurrentRow.Cells[0].Value.ToString();
            this.txtnameproduct.Text = frm.dgvproduts.CurrentRow.Cells[1].Value.ToString();
            this.txtprice.Text = frm.dgvproduts.CurrentRow.Cells[3].Value.ToString();
            txtqty.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvproducts.Rows.RemoveAt(dgvproducts.CurrentRow.Index);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            this.txtorderid.Text = bay.GET_LAST_BAY_ID().Rows[0][0].ToString();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
             if (txtorderid.Text == string.Empty) 
            {
                MessageBox.Show("الرجاء تاكد من رقم الفاتورة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          /*  if (txtdesorder.Text == string.Empty)
            {
                MessageBox.Show("الرجاء تاكد من اضافة وصف الفاتورة ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/
            if (dgvproducts.Rows.Count==1)
            {
                MessageBox.Show("الرجاء تاكد من اضافة المنتجات ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtcustomerid.Text == string.Empty) 
            {
                MessageBox.Show("الرجاء تاكد من رقم المورد وبياناته", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }





            bay.ADD_BAY(Convert.ToInt32(txtorderid.Text), dtorder.Value, Convert.ToInt32(txtcustomerid.Text), txtsalesman.Text, txtsuntotals.Text);

            for (int i = 0; i < dgvproducts.Rows.Count-1; i++)
            {
              
                bay.ADD_BAY_DETAILS(dgvproducts.Rows[i].Cells[0].Value.ToString(),
                                        Convert.ToInt32(txtorderid.Text),
                                        Convert.ToInt32( dgvproducts.Rows[i].Cells[3].Value),
                                        dgvproducts.Rows[i].Cells[2].Value.ToString(),
                                        dgvproducts.Rows[i].Cells[6].Value.ToString());



            }

            MessageBox.Show("تمت عملية الحفظ بنجاح ", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cleardata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_SUB_LIST frm = new FRM_SUB_LIST();
            frm.ShowDialog();
            
               
                this.txtcustomerid.Text = frm.dgvcustomers.CurrentRow.Cells[0].Value.ToString();
                this.txtfirstname.Text = frm.dgvcustomers.CurrentRow.Cells[1].Value.ToString();
                this.txtlastname.Text = frm.dgvcustomers.CurrentRow.Cells[2].Value.ToString();
                this.txttel.Text = frm.dgvcustomers.CurrentRow.Cells[3].Value.ToString();
                this.txtemail.Text = frm.dgvcustomers.CurrentRow.Cells[4].Value.ToString();
               
            
           




        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_KeyUp(object sender, KeyEventArgs e)
        {
            calculaemount();
            calcultotalaemount();
        }

        private void txtqty_KeyUp(object sender, KeyEventArgs e)
        {
            calculaemount();
            calcultotalaemount();
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalsepartor = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != decimalsepartor)
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtprice.Text != string.Empty)
            {
                txtqty.Focus();

            }
        }

        private void txtdiscount_KeyUp(object sender, KeyEventArgs e)
        {
            calcultotalaemount();
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                {

                    if (dgvproducts.Rows[i].Cells[0].Value.ToString() == txtidproduct.Text)
                    {
                        MessageBox.Show("هذا المنتج تم ادخاله مسبقا ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                }
               
                DataRow r = dt.NewRow();
                r[0] = txtidproduct.Text;
                r[1] = txtnameproduct.Text;
                r[2] = txtprice.Text;
                r[3] = txtqty.Text;
                r[4] = txtamoumt.Text;
                r[5] = txtdiscount.Text;
                r[6] = txttotalamount.Text;


                dt.Rows.Add(r);
                dgvproducts.DataSource = dt;
                clearboxes();
                txtsuntotals.Text =
                    (from DataGridViewRow row in dgvproducts.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqty.Text != string.Empty)
            {
                txtdiscount.Focus();

            }
        }

        private void dgvproducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtsuntotals.Text =
                  (from DataGridViewRow row in dgvproducts.Rows
                   where row.Cells[6].FormattedValue.ToString() != string.Empty
                   select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            
        }

        private void dgvproducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtidproduct.Text = this.dgvproducts.CurrentRow.Cells[0].Value.ToString();
                txtnameproduct.Text = this.dgvproducts.CurrentRow.Cells[1].Value.ToString();
                txtprice.Text = this.dgvproducts.CurrentRow.Cells[2].Value.ToString();
                txtqty.Text = this.dgvproducts.CurrentRow.Cells[3].Value.ToString();
                txtamoumt.Text = this.dgvproducts.CurrentRow.Cells[4].Value.ToString();
                txtdiscount.Text = this.dgvproducts.CurrentRow.Cells[5].Value.ToString();
                txttotalamount.Text = this.dgvproducts.CurrentRow.Cells[6].Value.ToString();
                dgvproducts.Rows.RemoveAt(dgvproducts.CurrentRow.Index);
                txtqty.Focus();
            }
            catch
            {
                return;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int bay_id = Convert.ToInt32(bay.GET_LAST_BAY_ROF_PRINT().Rows[0][0]);
            rpt.rpt_bay report = new rpt.rpt_bay();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            report.SetDataSource(bay.GETBAYDETAILS(bay_id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();

            this.Cursor = Cursors.Default;
        }
        }
        }
    

