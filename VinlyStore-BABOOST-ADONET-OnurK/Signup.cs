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

    public partial class Signup : Form
    {
        UserLoginRepo _userLoginRepo;
        public Signup()
        {
            InitializeComponent();
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_userLoginRepo.CheckUser(txtMail.Text))
                {
                    MessageBox.Show("This Mail adress exist");
                    return;
                }
                User user = new User();
                user = _userLoginRepo.RegisterUser(txtMail.Text,txtPhone.Text,txtFirstName.Text,txtLastName.Text,txtPass.Text);
                if (user != null)
                {

                    MainPage mainForm = new MainPage();
                    mainForm.LoggedInUser = user;
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

        private void Signup_Load(object sender, EventArgs e)
        {
            _userLoginRepo = new UserLoginRepo();
        }
    }
}
