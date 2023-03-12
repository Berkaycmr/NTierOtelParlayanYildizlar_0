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
    public partial class main : Form
    {
        bool sidebareExpand;
        public main()
        {
            InitializeComponent();
        }

        private void tmrSlider_Tick(object sender, EventArgs e)
        {
            if (sidebareExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebareExpand = false;
                    tmrSidebar.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebareExpand = true;
                    tmrSidebar.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrSidebar.Start();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = false;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
