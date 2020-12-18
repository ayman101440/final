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
    public partial class FRM_ORDERS : Form
    {
        bl.CLS_ORDERS order = new bl.CLS_ORDERS();
        DataTable dt = new DataTable();

        
         
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
            if (txtdiscount.Text != string.Empty && txtamoumt.Text!=string.Empty)
            {
                double discount = Convert.ToDouble(txtdiscount.Text);
                  double amount = Convert.ToDouble(txtamoumt.Text);
                  double totalamount=amount-(amount*(discount/100));
                    txttotalamount.Text=totalamount.ToString();
            }

        }

        void clearboxes()

        {
            txtidproduct.Clear();
            txtnameproduct.Clear();
            txtprice.Clear();
            txtqty.Clear();
            txtamoumt.Clear();
            txtdiscount.Text="0";
            txttotalamount.Clear();
            btnbrowse.Focus();
        }
        void cleardata()
        {
            txtorderid.Clear();
            txtdesorder.Clear();
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
            total_paid.Clear();
            rest_price.Clear();
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
            this.dgvproducts.RowHeadersWidth = 93;
          /* this.dgvproducts.Columns[0].Width = 104;
            this.dgvproducts.Columns[1].Width = 180;
            this.dgvproducts.Columns[2].Width = 99;
            this.dgvproducts.Columns[3].Width = 99;
            this.dgvproducts.Columns[4].Width = 99;
            this.dgvproducts.Columns[5].Width = 99;
            this.dgvproducts.Columns[6].Width = 120;*/
        }

        public FRM_ORDERS()
        {
            InitializeComponent();
            createdatatable();
            resizedgv();
            txtsalesman.Text = Program.salesman;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            this.txtorderid.Text = order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
            btnbrowse.Enabled = true;
            btnprint.Enabled = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();
            frm.ShowDialog();
            if (frm.dgvcustomers.CurrentRow.Cells[5].Value is DBNull)
            {
                MessageBox.Show("هذا العميل ليست لدية صورة");
               
                this.txtcustomerid.Text = frm.dgvcustomers.CurrentRow.Cells[0].Value.ToString();
                this.txtfirstname.Text = frm.dgvcustomers.CurrentRow.Cells[1].Value.ToString();
                this.txtlastname.Text = frm.dgvcustomers.CurrentRow.Cells[2].Value.ToString();
                this.txttel.Text = frm.dgvcustomers.CurrentRow.Cells[3].Value.ToString();
                this.txtemail.Text = frm.dgvcustomers.CurrentRow.Cells[4].Value.ToString();
                pbox.Image = null;
                return;
            
            }
            this.txtcustomerid.Text = frm.dgvcustomers.CurrentRow.Cells[0].Value.ToString();
            this.txtfirstname.Text = frm.dgvcustomers.CurrentRow.Cells[1].Value.ToString();
            this.txtlastname.Text = frm.dgvcustomers.CurrentRow.Cells[2].Value.ToString();
            this.txttel.Text = frm.dgvcustomers.CurrentRow.Cells[3].Value.ToString();
            this.txtemail.Text = frm.dgvcustomers.CurrentRow.Cells[4].Value.ToString();
            byte [] custpicture=(byte[])frm.dgvcustomers.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(custpicture);
            pbox.Image = Image.FromStream(ms);




        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            clearboxes();
            FRM_PRODUCTS_LIST frm = new FRM_PRODUCTS_LIST();
            
            frm.ShowDialog();
            this.txtidproduct.Text = frm.dgvproduts.CurrentRow.Cells[0].Value.ToString();
            this.txtnameproduct.Text = frm.dgvproduts.CurrentRow.Cells[1].Value.ToString();
            this.txtprice.Text = frm.dgvproduts.CurrentRow.Cells[3].Value.ToString();
            txtqty.Focus();
          
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&& e.KeyChar!=8)
            {
                e.Handled = true;
            }
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

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqty.Text != string.Empty)
            {
                txtdiscount.Focus();

            }
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

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtdiscount_KeyUp(object sender, KeyEventArgs e)
        {
            calcultotalaemount();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (order.verfqty(txtidproduct.Text, Convert.ToInt32(txtqty.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("هذا الكمية  غير متاحة  ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                {

                    if (dgvproducts.Rows[i].Cells[0].Value.ToString() == txtidproduct.Text)
                    {
                        MessageBox.Show("هذا المنتج تم ادخاله مسبقا ","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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

        private void txtorderid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {

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

        private void dgvproducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtsuntotals.Text =
                   (from DataGridViewRow row in dgvproducts.Rows
                    where row.Cells[6].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvproducts_DoubleClick(sender, e);
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvproducts.Rows.RemoveAt(dgvproducts.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
            {
                dgvproducts.Rows.RemoveAt(dgvproducts.Rows[i].Index);

            }*/
            dt.Clear();
            dgvproducts.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvproducts.Rows.RemoveAt(dgvproducts.CurrentRow.Index);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
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
                if (dgvproducts.Rows.Count == 1)
                {
                    MessageBox.Show("الرجاء تاكد من اضافة المنتجات ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtcustomerid.Text == string.Empty)
                {
                    MessageBox.Show("الرجاء تاكد من رقم العميل وبياناته", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (total_paid.Text == string.Empty)
                {
                    MessageBox.Show("الرجاء تاكد من حاله تسديد العميل ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    total_paid.Focus();
                }

                order.ADD_ORDER(Convert.ToInt32(txtorderid.Text), dtorder.Value.Date, dtorder.Value, Convert.ToInt32(txtcustomerid.Text), txtdesorder.Text, txtsalesman.Text, txtsuntotals.Text, total_paid.Text, rest_price.Text);

                for (int i = 0; i < dgvproducts.Rows.Count - 1; i++)
                {
                    order.ADD_ORDER_DETAILS(dgvproducts.Rows[i].Cells[0].Value.ToString(),
                                            Convert.ToInt32(txtorderid.Text),
                                            Convert.ToInt32(dgvproducts.Rows[i].Cells[3].Value),
                                            dgvproducts.Rows[i].Cells[2].Value.ToString(),
                                            Convert.ToInt32(dgvproducts.Rows[i].Cells[5].Value),
                                            dgvproducts.Rows[i].Cells[4].Value.ToString(),
                                            dgvproducts.Rows[i].Cells[6].Value.ToString());



                }

                MessageBox.Show("تمت عملية الحفظ بنجاح ", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
            }
            catch
            {
                MessageBox.Show("تاكد من اضافة الاصناف وجميع المعلومات بطريقة صحيحة ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int order_id = Convert.ToInt32(order.GET_LAST_ORDER_ROF_PRINT().Rows[0][0]);
            rpt.rpt_orders report = new rpt.rpt_orders();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            report.SetDataSource(order.GETORDERDETAILS(order_id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void txtsalesman_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void total_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            
        }

        private void total_paid_KeyUp(object sender, KeyEventArgs e)
        {
            if (total_paid.Text != string.Empty)
            {
                if (total_paid.Text != txtsuntotals.Text || total_paid.Text != "")
                    rest_price.Text = (Convert.ToInt32(txtsuntotals.Text) - Convert.ToInt32(total_paid.Text)).ToString();
                else
                    rest_price.Text = txtsuntotals.Text;
            }
            else
            {
                rest_price.Text = txtsuntotals.Text;
            }
        }

        private void txtsuntotals_TextChanged(object sender, EventArgs e)
        {
            rest_price.Text = txtsuntotals.Text;
        }

        
        
        
    }
}
