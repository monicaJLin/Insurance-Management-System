using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrtInsManagement
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

       

        private void tsbtn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbtnAgent_Click(object sender, EventArgs e)
        {
            FrmAgent AForm = new FrmAgent();
            AForm.MdiParent = this;
            AForm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin Form = new FrmLogin();
            Form.ShowDialog();
        }

        private void tsbtn_Customer_Click(object sender, EventArgs e)
        {
            FrmCustomer CForm = new FrmCustomer();
            CForm.MdiParent = this;
            CForm.Show();
        }

        private void tsbtn_CustomerPolicy_Click(object sender, EventArgs e)
        {
            FrmCustomerPolicy CPForm = new FrmCustomerPolicy();
            CPForm.MdiParent = this;
            CPForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmBilling BillingForm = new FrmBilling();
            BillingForm.MdiParent = this;
            BillingForm.Show();
        }
    }
}
