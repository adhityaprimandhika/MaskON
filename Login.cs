using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MaskON
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        //untuk check apakah akun telah terdaftar
        private bool ValidateUser(string username, string password)
        {
            DBModel db = new DBModel();
            var query = from Account in db.Accounts where Account.Username == username && Account.Password == password select Account;
            if (query.Any())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Your account not register yet");
                return false;
            }
        }

        //button register
        private void btn_Login_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        //button login
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tb_Login_Username.Text != "" && tb_Login_Password.Text != "")
            {
                if (ValidateUser(tb_Login_Username.Text, tb_Login_Password.Text))
                {
                    if (rb_Donatur.Checked)
                    {
                        DonateMask donate = new DonateMask();
                        MessageBox.Show("Login Succeed");
                        donate.Show();
                        this.Close();
                    }
                    else if (rb_Penerima.Checked)
                    {
                        ReceiveMask receive = new ReceiveMask();
                        MessageBox.Show("Login Succeed");
                        receive.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill your information correctly");
            }
        }

    }
}