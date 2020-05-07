using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskON
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //button login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            // makai username & password dari bagian Account.cs
            Account account = new Account();
            account.Username = boxUsername.Text;
            account.Password = boxPassword.Text;
  
            if (account.Login(account.Username, account.Password))
            {
                MessageBox.Show("Login akun anda berhasil!");
                new Tipe().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login telah gagal, silahkan cek kembali password atau registrasi.");
            }
        }

        //button register
        private void btnRegister_Click(object sender, EventArgs e)
        {
            new boxRegister().Show();
            this.Hide();
        }
    }
}
