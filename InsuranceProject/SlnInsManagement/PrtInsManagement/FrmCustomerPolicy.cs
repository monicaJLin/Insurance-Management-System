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
    public partial class FrmCustomerPolicy : Form
    {
        
        public FrmCustomerPolicy()
        {
            InitializeComponent();
        }


        private void btn新增_Click(object sender, EventArgs e)
        {
            tCustomerPolicy z = new tCustomerPolicy();
            //z.fCustomerPolicyID = txtCPolicyID.Text;
            z.fCustomerID = txtCustomerID.Text;
            z.fFirstName = txtFrtName.Text;
            z.fLastName = txtLstName.Text;
            z.fPolicyType = comboBox1.Text;
            z.fPeriod_StartDate = dateTimePicker1.Value;
            z.fPolicy_FiscalPeriod = comboBox2.Text;
            z.fAgentID = txtAgentID.Text;

            dbINSManagementDataContext db = new dbINSManagementDataContext();
            db.tCustomerPolicy.InsertOnSubmit(z);
            db.SubmitChanges();
            MessageBox.Show("資料新增成功");
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            dbINSManagementDataContext db = new dbINSManagementDataContext();
            
            var st = (from s in db.tCustomerPolicy where s.fCustomerPolicyID == int.Parse(txtCPolicyID.Text) select s).First();
            st.fCustomerPolicyID = int.Parse(txtCPolicyID.Text);
            st.fCustomerID = txtCustomerID.Text;
            st.fFirstName = txtFrtName.Text;
            st.fLastName = txtLstName.Text;
            st.fPeriod_StartDate = dateTimePicker1.Value;
            st.fPolicyType = comboBox1.Text;
            st.fPolicy_FiscalPeriod = comboBox2.Text;
            st.fAgentID = txtAgentID.Text;

            db.SubmitChanges();
            MessageBox.Show("Successfully Updated.");
            refresh();

        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            if(dataGridView_PolicyDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("請指定要刪除的資料");
                return;
            }

            if (MessageBox.Show("確定要刪除嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            int fId = Convert.ToInt32(dataGridView_PolicyDetails.SelectedRows[0].Cells[0].Value.ToString());
            //下面的pk改為fID;
            dbINSManagementDataContext db = new dbINSManagementDataContext();
            tCustomerINS data = db.tCustomerINS.FirstOrDefault(p => p.fCustomerID == fId);

            if (data != null)
            {
                db.tCustomerINS.DeleteOnSubmit(data);
                db.SubmitChanges();
            }

            refresh();

        }

        private void refresh()
        {
            dbINSManagementDataContext db = new dbINSManagementDataContext();
            var table = from t in db.tCustomerPolicy
                        select t;

            dataGridView_PolicyDetails.DataSource = table.ToList();

            setGridViewStyle();
        }

        private void setGridViewStyle()
        {
            dataGridView_PolicyDetails.Columns[0].Width = 100;
            dataGridView_PolicyDetails.Columns[1].Width = 100;
            dataGridView_PolicyDetails.Columns[2].Width = 200;
            dataGridView_PolicyDetails.Columns[3].Width = 200;
            dataGridView_PolicyDetails.Columns[4].Width = 100;
            dataGridView_PolicyDetails.Columns[5].Width = 100;
            dataGridView_PolicyDetails.Columns[6].Width = 200;
            dataGridView_PolicyDetails.Columns[7].Width = 100;
            bool isColorChanged = true;
            foreach (DataGridViewRow r in dataGridView_PolicyDetails.Rows)
            {
                //r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.LightBlue;
                isColorChanged = !isColorChanged;
            }
        }

        private void btn重整_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn查詢_Click(object sender, EventArgs e)
        {
            dbINSManagementDataContext db = new dbINSManagementDataContext();
            var st = from s in db.tCustomerPolicy 
                     where s.fCustomerPolicyID ==int.Parse(txtCPolicyID.Text) 
                     select s;
        }
    }
}
