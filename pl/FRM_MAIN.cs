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
    public partial class FRM_MAIN : Form
    {
        private static FRM_MAIN frm;
        static void frm_Formclosed(object sender, FormClosedEventArgs e)
        {

            frm = null;

        }
        public static FRM_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed+=new  FormClosedEventHandler(frm_Formclosed);

                }
                return frm;
            }
            
       


        }
        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            
            this.المنتوجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.استعادةنسخةاحطياطيةToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحطياطيةToolStripMenuItem.Enabled = false;
            this.المشترياتToolStripMenuItem.Enabled = false;
            this.الموردينToolStripMenuItem.Enabled = false;
            this.الصندوقToolStripMenuItem.Enabled = false;
            this.المبيعاتToolStripMenuItem.Enabled = false;

          //  this.التقاريرToolStripMenuItem.Enabled = false;
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

           
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();

        }

        private void اضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT1 frm = new FRM_ADD_PRODUCT1();
            frm.ShowDialog();
        }

        private void ادارةالمنتوجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCT frm = new FRM_PRODUCT();
            frm.ShowDialog();

        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES frm = new FRM_CATEGORIES();
            frm.ShowDialog();

        }

        private void اضافةعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS frm = new FRM_CUSTOMERS();
            frm.ShowDialog();
        }

        private void اضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.ShowDialog();
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USRES_LIST frm = new FRM_USRES_LIST();
            frm.ShowDialog();
        }

        private void انشاءنسخةاحطياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void استعادةنسخةاحطياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTOR frm = new FRM_RESTOR();
            frm.ShowDialog();
            //MessageBox.Show("قريبا ");
        }

        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void اعداداتالاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CONFIG frm = new  FRM_CONFIG();
            frm.ShowDialog();
        }

        private void اضافهموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_SUB frm = new FRM_ADD_SUB();
            frm.ShowDialog();
        }

        private void فاتورةشراءجديدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BAY_LIST frm = new FRM_BAY_LIST();
            frm.ShowDialog();
        }

        private void ادارةالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BAY frm = new FRM_BAY();
            frm.ShowDialog();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void حولالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ABOUT frm = new FRM_ABOUT();
            frm.ShowDialog();
        }

        private void المصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void انواعالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_DESER_TYPE frm = new FRM_ADD_DESER_TYPE();
            frm.ShowDialog();
        }

        private void مصروفهجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_DESER frm = new FRM_DESER();
            frm.ShowDialog();
        }

        private void الاصنافالناقصةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void تقريرالمنتجاتالناقصةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void كشفحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SUM_COS_ACCUONT frm = new FRM_SUM_COS_ACCUONT();
            frm.ShowDialog();
        }

        private void سندقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PAYMENT frm = new FRM_PAYMENT();
            frm.ShowDialog();
        }

        private void FRM_MAIN_Click(object sender, EventArgs e)
        {

            
        }

        private void FRM_MAIN_DoubleClick(object sender, EventArgs e)
        {

           
        }

        private void FRM_MAIN_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void FRM_MAIN_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void FRM_MAIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void FRM_MAIN_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void FRM_MAIN_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void FRM_MAIN_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void FRM_MAIN_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void حساباتاليوميةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_DAYLY frm = new FRM_DAYLY();
            frm.ShowDialog();
        }

        private void الحساباتالشهريةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_MANTHEY frm = new FRM_MANTHEY();
            frm.ShowDialog();
        }

        private void اضافةبيعجديدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.ShowDialog();
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FRM_ORDER_LIST frm = new FRM_ORDER_LIST();
            frm.ShowDialog();
        }

        private void تقاريرالمنتجاتالناقصةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void المشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_REPORT_ALL frm = new FRM_REPORT_ALL();
            frm.ShowDialog();
        }

        private void حركةالصندوقToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
