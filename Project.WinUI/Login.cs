using Project.BLL.GenericRepository.ConcRep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Login : Form
    {
        AppUserRepository rep;
        public Login()
        {
            InitializeComponent();
            rep = new AppUserRepository();
            lblLogin.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rep.Any(x=>x.UserName==txtUserName.Text && x.Password==txtPassword.Text))
            {


                Loading loading = new Loading();
                loading.Show();
                this.Hide();

            }
            else
            {
                lblLogin.Visible = true;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
