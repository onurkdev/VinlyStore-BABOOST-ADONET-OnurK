using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinlyStore_BABOOST_ADONET_OnurK
{
    using Repo;
    using VinlyStore_BABOOST_ADONET_OnurK.Entities;

    public partial class LoginScreeen : Form
    {
        UserLoginRepo _userLoginRepo;
        public LoginScreeen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user = _userLoginRepo.LoginUser(txtMail.Text, txtPassword.Text);
                if (user!=null) {
                
                MainPage mainForm = new MainPage();
                mainForm.LoggedInUser= user;
                mainForm.ShowDialog();
                
                this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed Please Check Credentials");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LoginScreeen_Load(object sender, EventArgs e)
        {
            _userLoginRepo = new UserLoginRepo();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
