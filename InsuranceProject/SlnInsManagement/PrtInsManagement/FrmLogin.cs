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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        bool isClosed = true;

        private void btn取消_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
        private void btn登入_Click(object sender, EventArgs e)
        {
           if (!TxtBoxCode.Text.Equals(LblCode.Text))
                    {
                    return;
                     }
                
            tAgent user = (new dbINSManagementDataContext()).tAgent.FirstOrDefault(
               p => p.fAgentEmail.Equals(txtbox_註冊時的帳號.Text) && p.fPassword.Equals(txtbox_密碼.Text));
            if (user != null)
            {
                isClosed = false;
                Close();
                return;
            }
            MessageBox.Show("Invalid Password or Username.");
            
        }
        private void FrnLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isClosed;
        }







        private void pic重新給驗證碼_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            LblCode.Text = convertToEnglish(rand.Next(0, 13)) +
                convertToEnglish(rand.Next(0, 13)) +
                convertToEnglish(rand.Next(0, 13)) +
                convertToEnglish(rand.Next(0, 13));
        }
        private string convertToEnglish(int p)
        {
            if (p == 10)
                return "A";
            if (p == 11)
                return "B";
            if (p == 12)
                return "C";
            return p.ToString();

        }




    }
}
