using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;



namespace WindowsFormsApplication10.pl
{
    public partial class FRM_CATEGORIES : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server=DESKTOP-50SF8F9; Database= centra; Integrated Security =true ");
        SqlDataAdapter da;
        DataTable dt= new DataTable();
        SqlCommandBuilder cmdb;

        BindingManagerBase bmb;

        public FRM_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select id_cat as 'رقم الصنف',description_cat as 'اسم الصنف' from categores", sqlcon);
            da.Fill(dt);
            dglist.DataSource = dt;
            txtid.DataBindings.Add("text", dt, "رقم الصنف");
            txtdes.DataBindings.Add("text", dt, "اسم الصنف");
            bmb = this.BindingContext[dt];
            lblposition.Text = (bmb.Position+ 1)+ "/" + bmb.Count;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_CATEGORIES_Load(object sender, EventArgs e)
        {

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnprevitus_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
            int id =Convert.ToInt32( dt.Rows[dt.Rows.Count-1][0])+1;
            txtid.Text = id.ToString();
            txtdes.Focus();


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الحفظ بنجاح ", "اضافة ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnadd.Enabled = false;
            btnnew.Enabled = true;
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الحذف بنجاح ", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;
           
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم التعديل بنجاح ", "تعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;
      
              }

        private void btnprintall_Click(object sender, EventArgs e)
        {
            rpt.rpt_all_categories rpt = new rpt.rpt_all_categories();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();


          

          
        }

        private void btnprintsingle_Click(object sender, EventArgs e)
        {
            rpt.rpt_single_category rpt = new rpt.rpt_single_category();
            rpt.FRM_RPT_PRODUCT frm = new rpt.FRM_RPT_PRODUCT();
            rpt.SetParameterValue("@id", Convert.ToInt32(txtid.Text));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            
        }

        private void exporttobdfall_Click(object sender, EventArgs e)
        {

            rpt.rpt_all_categories myreprt = new rpt.rpt_all_categories();

            ExportOptions export = new ExportOptions();

            DiskFileDestinationOptions dfoptiuns = new DiskFileDestinationOptions();
            PdfFormatOptions pdfformat = new PdfFormatOptions();
            dfoptiuns.DiskFileName = @"E:\categorieslist.pdf";
            export = myreprt.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;

            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfformat;
            export.ExportDestinationOptions = dfoptiuns;
            myreprt.Refresh();
            myreprt.Export();
            MessageBox.Show("تم حفظ الملف بنجاح الى المسار ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exporttobdfcarrent_Click(object sender, EventArgs e)
        {
            rpt.rpt_single_category myreprt = new rpt.rpt_single_category();

            ExportOptions export = new ExportOptions();

            DiskFileDestinationOptions dfoptiuns = new DiskFileDestinationOptions();
            PdfFormatOptions pdfformat = new PdfFormatOptions();
            dfoptiuns.DiskFileName = @"E:\categorylist.pdf";
            export = myreprt.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;

            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfformat;
            export.ExportDestinationOptions = dfoptiuns;
            myreprt.SetParameterValue("@id", Convert.ToInt32(txtid.Text));
           // myreprt.Refresh();
            myreprt.Export();
            MessageBox.Show("تم حفظ الملف بنجاح الى المسار ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
        }

        private void dglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
