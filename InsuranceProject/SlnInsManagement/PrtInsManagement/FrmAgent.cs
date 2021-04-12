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
    public partial class FrmAgent : Form
    {
        public FrmAgent()
        {
            InitializeComponent();
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            tAgent x = new tAgent();
            //ID識別項目<不用打???x.fAgentID = txtAgentID.Text;
            x.fFirstName = txtAgtFrtname.Text;
            x.fLastName = txtAgtLstname.Text;
            x.fAge = txtAgtAge.Text;
            //xgender如何用兩個小圈圈點選?
            x.fOccupation = txtOccupation.Text;
            x.fContact = txtAgtContact.Text;
            x.fAgentEmail = txtBoxAgentEmail.Text;
            x.fPassword = txtBoxPassword.Text;

            dbINSManagementDataContext db = new dbINSManagementDataContext();
            db.tAgent.InsertOnSubmit(x);
            db.SubmitChanges();

            MessageBox.Show("資料新增成功");
            refresh();
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            dbINSManagementDataContext db = new dbINSManagementDataContext();
            string fFirstname = txtAgtFrtname.Text;
            var st = (from s in db.tAgent where s.fAgentID == int.Parse(txtAgentID.Text) select s).First();
            st.fFirstName = txtAgtFrtname.Text;
            st.fLastName = txtAgtLstname.Text;
            st.fAgentEmail = txtBoxAgentEmail.Text;
            st.fGender = comboBox1.Text;
            st.fAge = txtAgtAge.Text;
            st.fOccupation = txtOccupation.Text;
            st.fContact =txtAgtContact.Text;
            db.SubmitChanges();
            MessageBox.Show("Successfully Updated.");
            refresh();


        }


        private void btn查詢_Click(object sender, EventArgs e)
        {
            dbINSManagementDataContext db = new dbINSManagementDataContext();
            tAgent s = db.tAgent.FirstOrDefault(p => (p.fAgentID == (Convert.ToInt32(txtAgentID.Text))) );
           
            if (s==null)
            {
                MessageBox.Show("查無此人");
                return;
            }

           var st = from t in db.tAgent 
              where t.fAgentID == s.fAgentID
               select t;
            dataGridView_Agent.DataSource = st;

        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            if (dataGridView_Agent.SelectedRows.Count == 0)
            {
                MessageBox.Show("請指定要刪除的資料");
                return;
            }
            if (MessageBox.Show("確定要刪除嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            int fId = Convert.ToInt32(dataGridView_Agent.SelectedRows[0].Cells[0].Value.ToString());
                //下面的pk改為fID;
            dbINSManagementDataContext db = new dbINSManagementDataContext();
            tAgent data = db.tAgent.FirstOrDefault(p => p.fAgentID == fId);

            if (data != null)
            {
                db.tAgent.DeleteOnSubmit(data);
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
            var table = from t in db.tAgent
                        select new {
                            AgentID=t.fAgentID,
                            FirstName = t.fFirstName,
                            LastName=t.fLastName,
                            Position=t.fOccupation,
                            Email=t.fAgentEmail,
                            Contact=t.fContact

                        };

            dataGridView_Agent.DataSource = table;

           // setGridViewStyle();
        }

        private void setGridViewStyle()
        {
            dataGridView_Agent.Columns[0].Width = 100;
            dataGridView_Agent.Columns[1].Width = 100;
            dataGridView_Agent.Columns[2].Width = 100;
            dataGridView_Agent.Columns[3].Width = 100;
            dataGridView_Agent.Columns[4].Width = 100;
            dataGridView_Agent.Columns[5].Width = 100;
            dataGridView_Agent.Columns[6].Width = 100;
            dataGridView_Agent.Columns[7].Width = 100;
            dataGridView_Agent.Columns[8].Width = 0;



            bool isColorChanged = true;
            foreach (DataGridViewRow r in dataGridView_Agent.Rows)
            {
                //r.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
                r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.LightBlue;
                isColorChanged = !isColorChanged;
            }
        }

        
    }
}
