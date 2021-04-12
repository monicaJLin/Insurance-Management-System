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
    public partial class FrmCustomer : Form
    {
       
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            tCustomerINS y = new tCustomerINS();
            //ID識別項目<不用打???x.fAgentID = txtAgentID.Text;
            y.fFirstName = txtFrtName.Text;
            y.fLastName = txtLstName.Text;
            y.fDOB = dateTimePicker1.Value;
            y.fState = txtState.Text;
            y.fCity = txtCity.Text;
            y.fAddress = txtAddress.Text;
            y.fZipcode = txtzip.Text;
            y.fGender = comboBox1.Text; 
            y.fOccupation = txtOccupation.Text;
            y.fContactPhone =txtContactPhone.Text;
            y.fDegree = txtDegree.Text;
            y.fDriverLicense = txtDL.Text;

            dbINSManagementDataContext db = new dbINSManagementDataContext();
            db.tCustomerINS.InsertOnSubmit(y);
            db.SubmitChanges();

            MessageBox.Show("資料新增成功");
            refresh();
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            dbINSManagementDataContext db = new dbINSManagementDataContext();
            string fFirstname =txtFrtName.Text;
            var st = (from s in db.tCustomerINS where s.fCustomerID == int.Parse(txtCustomerID.Text) select s).First();
            st.fFirstName= txtFrtName.Text;
            st.fLastName = txtLstName.Text;
            st.fAddress = txtAddress.Text;
            st.fGender = comboBox1.Text;
            st.fAgentName = txtAgentName.Text;
            st.fOccupation = txtOccupation.Text;
            st.fCity = txtCity.Text;
            st.fContactPhone = txtContactPhone.Text;
            st.fDegree = txtDegree.Text;
            st.fDriverLicense = txtDL.Text;
            st.fGender = comboBox1.Text;
            st.fState = txtState.Text;
            st.fZipcode = txtzip.Text;
            st.fDOB = dateTimePicker1.Value;

            db.SubmitChanges();
            MessageBox.Show("Successfully Updated.");
            refresh();
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            if (dataGridView_CustomerDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("請指定要刪除的資料");
                return;
            }
            if (MessageBox.Show("確定要刪除嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            int fId = Convert.ToInt32(dataGridView_CustomerDetails.SelectedRows[0].Cells[0].Value.ToString());
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

        private void btn重整_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            dbINSManagementDataContext db = new dbINSManagementDataContext();
            var table = from t in db.tCustomerINS
                        select t;

            dataGridView_CustomerDetails.DataSource = table.ToList();

            setGridViewStyle();
        }

        private void setGridViewStyle()
        {
            dataGridView_CustomerDetails.Columns[0].Width = 70;
            dataGridView_CustomerDetails.Columns[1].Width = 100;
            dataGridView_CustomerDetails.Columns[2].Width = 100;
            dataGridView_CustomerDetails.Columns[3].Width = 105;
            dataGridView_CustomerDetails.Columns[4].Width = 40;
            dataGridView_CustomerDetails.Columns[5].Width = 80;
            dataGridView_CustomerDetails.Columns[6].Width = 45;
            dataGridView_CustomerDetails.Columns[7].Width = 130;
            dataGridView_CustomerDetails.Columns[8].Width = 250;
            dataGridView_CustomerDetails.Columns[9].Width = 80;
            dataGridView_CustomerDetails.Columns[10].Width = 120;
            dataGridView_CustomerDetails.Columns[11].Width = 150;
            dataGridView_CustomerDetails.Columns[12].Width = 200;
            bool isColorChanged = true;
            foreach (DataGridViewRow r in dataGridView_CustomerDetails.Rows)
            {
                //r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.LightBlue;
                isColorChanged = !isColorChanged;
            }
        }

        private void btn查詢_Click(object sender, EventArgs e)
        {
            dbINSManagementDataContext db = new dbINSManagementDataContext();
            var st = from s in db.tCustomerINS
                        where s.fCustomerID == int.Parse(txtCustomerID.Text)
                        select s;
            dataGridView_CustomerDetails.DataSource = st;
        }
    }

}
