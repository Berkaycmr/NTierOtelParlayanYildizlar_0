namespace Project.WinUI
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlReservation = new System.Windows.Forms.Panel();
            this.btnReservation = new System.Windows.Forms.Button();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.tmrSidebar = new System.Windows.Forms.Timer(this.components);
            this.aboutPage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.pnlReservation.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.aboutPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidebar.Controls.Add(this.pnlMenu);
            this.sidebar.Controls.Add(this.pnlHome);
            this.sidebar.Controls.Add(this.pnlReservation);
            this.sidebar.Controls.Add(this.pnlCustomer);
            this.sidebar.Controls.Add(this.pnlAbout);
            this.sidebar.Controls.Add(this.pnlExit);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Font = new System.Drawing.Font("Impact", 10.25F);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 638);
            this.sidebar.MinimumSize = new System.Drawing.Size(48, 638);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 638);
            this.sidebar.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Location = new System.Drawing.Point(3, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(197, 70);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblMenu.Location = new System.Drawing.Point(73, 26);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(42, 19);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "MENU";
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 50);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnHome);
            this.pnlHome.Location = new System.Drawing.Point(3, 79);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(200, 37);
            this.pnlHome.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Impact", 10.25F);
            this.btnHome.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-25, -6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(254, 52);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "                                HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlReservation
            // 
            this.pnlReservation.Controls.Add(this.btnReservation);
            this.pnlReservation.Location = new System.Drawing.Point(3, 122);
            this.pnlReservation.Name = "pnlReservation";
            this.pnlReservation.Size = new System.Drawing.Size(200, 37);
            this.pnlReservation.TabIndex = 4;
            // 
            // btnReservation
            // 
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Impact", 10.25F);
            this.btnReservation.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Location = new System.Drawing.Point(-25, -6);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReservation.Size = new System.Drawing.Size(254, 52);
            this.btnReservation.TabIndex = 3;
            this.btnReservation.Text = "                                RESERVATION";
            this.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.btnCustomer);
            this.pnlCustomer.Location = new System.Drawing.Point(3, 165);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(200, 37);
            this.pnlCustomer.TabIndex = 5;
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Impact", 10.25F);
            this.btnCustomer.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(-25, -6);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(254, 52);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "                                CUSTOMER";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.btnAbout);
            this.pnlAbout.Location = new System.Drawing.Point(3, 208);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(200, 37);
            this.pnlAbout.TabIndex = 5;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Impact", 10.25F);
            this.btnAbout.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(-25, -6);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(254, 52);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "                                ABOUT";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.btnExit);
            this.pnlExit.Location = new System.Drawing.Point(3, 251);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(200, 37);
            this.pnlExit.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Impact", 10.25F);
            this.btnExit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-25, -6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(254, 52);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "                                EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmrSidebar
            // 
            this.tmrSidebar.Interval = 10;
            this.tmrSidebar.Tick += new System.EventHandler(this.tmrSlider_Tick);
            // 
            // aboutPage
            // 
            this.aboutPage.Controls.Add(this.label4);
            this.aboutPage.Controls.Add(this.label3);
            this.aboutPage.Controls.Add(this.label2);
            this.aboutPage.Controls.Add(this.label1);
            this.aboutPage.Location = new System.Drawing.Point(218, 73);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Size = new System.Drawing.Size(619, 511);
            this.aboutPage.TabIndex = 4;
            this.aboutPage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ASDASDSADADADSAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ASDASDSADADADSAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ASDASDSADADADSAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ASDASDSADADADSAD";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(836, 626);
            this.Controls.Add(this.aboutPage);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.sidebar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlReservation.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlAbout.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.aboutPage.ResumeLayout(false);
            this.aboutPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Timer tmrSidebar;
        private System.Windows.Forms.Panel pnlReservation;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel aboutPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}