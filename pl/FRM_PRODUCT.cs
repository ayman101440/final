using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace WindowsFormsApplication10.pl
{
    public partial class FRM_PRODUCT : Form
    {
        private static FRM_PRODUCT frm;
        static void frm_Formclosed(object sender, FormClosedEventArgs e)
        {

            frm = null;

        }

        public static FRM_PRODUCT getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCT();
                    frm.FormClosed += new FormClosedEventHandler(frm_Formclosed);

                }
                return frm;
            }




        }

        bl.CLS_PRODUCTS prd = new bl.CLS_PRODUCTS();
        public FRM_PRODUCT()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource=prd.GET_ALL_PRODUCTS();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.searchProduct(txtSearch.Text);
            this.dataGridView1.DataSource = Dt;
        }

        private void FRM_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT1 frm = new FRM_ADD_PRODUCT1();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.deleteproduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحذف بنجاح ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            else
            {
                MessageBox.Show("تم الغاء العملية بنجاح ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT1 frm = new FRM_ADD_PRODUCT1();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtqte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            frm.txtprice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تعديل المنتج " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnok.Text = "تعديل";
            frm.state = "update";
            frm.txtRef.ReadOnly = true;
            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pb.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_PREVEW frm = new FRM_PREVEW();
            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           rpt.rpt_prd_single myreprt = new rpt.rpt_prd_single();
           myreprt.SetParameterValue("@id", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            rpt.FRM_RPT_PRODUCT myform = new rpt.FRM_RPT_PRODUCT();
            myform.crystalReportViewer1.ReportSource = myreprt;
            myform.ShowDialog();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {

            rpt.rpt_all_product myreprt = new rpt.rpt_all_product();
            rpt.FRM_RPT_PRODUCT myform = new rpt.FRM_RPT_PRODUCT();
            myform.crystalReportViewer1.ReportSource = myreprt;
            myform.ShowDialog();
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            rpt.rpt_all_product myreprt = new rpt.rpt_all_product();

            ExportOptions export = new ExportOptions();

            DiskFileDestinationOptions dfoptiuns = new DiskFileDestinationOptions();
            ExportFormatOptions excelformat = new ExcelFormatOptions(); 
            dfoptiuns.DiskFileName = @"E:\productslist.xls";
            export = myreprt.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;

            export.ExportFormatType = ExportFormatType.Excel;
            export.ExportFormatOptions = excelformat; 
            export.ExportDestinationOptions = dfoptiuns;
            myreprt.Export();
            MessageBox.Show("تم حفظ الملف بنجاح الى المسار ","حفظ", MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
