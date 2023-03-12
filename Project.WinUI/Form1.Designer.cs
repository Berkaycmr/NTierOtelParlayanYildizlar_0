namespace Project.WinUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lstBookings = new System.Windows.Forms.ListBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFullRooms = new System.Windows.Forms.Button();
            this.btnEmptyRooms = new System.Windows.Forms.Button();
            this.btnPassiveCustomers = new System.Windows.Forms.Button();
            this.btnPassiveRezs = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.nmrCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnActiveCustomers = new System.Windows.Forms.Button();
            this.btnActiveBookings = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbOrders = new System.Windows.Forms.ComboBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tmrControl = new System.Windows.Forms.Timer(this.components);
            this.btnCleanRoom = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(287, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 973);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-18, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1527, 10);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(60, 68);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(60, 112);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(60, 152);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(60, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(59, 237);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Isim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "SoyIsim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "TC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tel No";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(129, 278);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(129, 34);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Müşteri Ekle";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lstRooms
            // 
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.Location = new System.Drawing.Point(802, 25);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(216, 303);
            this.lstRooms.TabIndex = 4;
            this.lstRooms.Click += new System.EventHandler(this.lstRooms_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(318, 25);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(216, 303);
            this.lstCustomers.TabIndex = 4;
            this.lstCustomers.Click += new System.EventHandler(this.lstCustomers_Click);
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // lstBookings
            // 
            this.lstBookings.FormattingEnabled = true;
            this.lstBookings.Location = new System.Drawing.Point(561, 25);
            this.lstBookings.Name = "lstBookings";
            this.lstBookings.Size = new System.Drawing.Size(216, 303);
            this.lstBookings.TabIndex = 4;
            this.lstBookings.Click += new System.EventHandler(this.lstBookings_Click);
            this.lstBookings.SelectedIndexChanged += new System.EventHandler(this.lstBookings_SelectedIndexChanged);
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(1051, 25);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(216, 303);
            this.lstOrders.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Müşteriler";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(558, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Rezervasyonlar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(799, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Odalar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1048, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Siparişler";
            // 
            // btnFullRooms
            // 
            this.btnFullRooms.Location = new System.Drawing.Point(930, 363);
            this.btnFullRooms.Name = "btnFullRooms";
            this.btnFullRooms.Size = new System.Drawing.Size(88, 23);
            this.btnFullRooms.TabIndex = 8;
            this.btnFullRooms.Text = "Meşgul Odalar";
            this.btnFullRooms.UseVisualStyleBackColor = true;
            this.btnFullRooms.Click += new System.EventHandler(this.btnFullRooms_Click);
            // 
            // btnEmptyRooms
            // 
            this.btnEmptyRooms.Location = new System.Drawing.Point(930, 334);
            this.btnEmptyRooms.Name = "btnEmptyRooms";
            this.btnEmptyRooms.Size = new System.Drawing.Size(88, 23);
            this.btnEmptyRooms.TabIndex = 8;
            this.btnEmptyRooms.Text = "Müsait Odalar";
            this.btnEmptyRooms.UseVisualStyleBackColor = true;
            this.btnEmptyRooms.Click += new System.EventHandler(this.btnEmptyRooms_Click);
            // 
            // btnPassiveCustomers
            // 
            this.btnPassiveCustomers.Location = new System.Drawing.Point(303, 333);
            this.btnPassiveCustomers.Name = "btnPassiveCustomers";
            this.btnPassiveCustomers.Size = new System.Drawing.Size(116, 37);
            this.btnPassiveCustomers.TabIndex = 9;
            this.btnPassiveCustomers.Text = "Pasif Müşterileri Getir";
            this.btnPassiveCustomers.UseVisualStyleBackColor = true;
            this.btnPassiveCustomers.Click += new System.EventHandler(this.btnPassiveCustomers_Click);
            // 
            // btnPassiveRezs
            // 
            this.btnPassiveRezs.Location = new System.Drawing.Point(303, 392);
            this.btnPassiveRezs.Name = "btnPassiveRezs";
            this.btnPassiveRezs.Size = new System.Drawing.Size(116, 37);
            this.btnPassiveRezs.TabIndex = 9;
            this.btnPassiveRezs.Text = "Pasif Rezervasyonları Getir";
            this.btnPassiveRezs.UseVisualStyleBackColor = true;
            this.btnPassiveRezs.Click += new System.EventHandler(this.btnPassiveRezs_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(254, 410);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 30);
            this.label15.TabIndex = 10;
            this.label15.Text = "1";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(12, 479);
            this.dtpCheckIn.MinDate = new System.DateTime(2023, 3, 12, 17, 18, 8, 0);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 11;
            this.dtpCheckIn.Value = new System.DateTime(2023, 3, 12, 17, 18, 8, 0);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(12, 532);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 11;
            // 
            // nmrCount
            // 
            this.nmrCount.Location = new System.Drawing.Point(12, 586);
            this.nmrCount.Name = "nmrCount";
            this.nmrCount.Size = new System.Drawing.Size(41, 20);
            this.nmrCount.TabIndex = 12;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(129, 640);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(129, 35);
            this.btnAddBooking.TabIndex = 13;
            this.btnAddBooking.Text = "Rezervasyon Yap";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 460);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Giriş Tarihi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 516);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Çıkış Tarihi";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 570);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Kişi Sayısı";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(254, 774);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 30);
            this.label19.TabIndex = 10;
            this.label19.Text = "2";
            // 
            // btnActiveCustomers
            // 
            this.btnActiveCustomers.Location = new System.Drawing.Point(425, 334);
            this.btnActiveCustomers.Name = "btnActiveCustomers";
            this.btnActiveCustomers.Size = new System.Drawing.Size(116, 37);
            this.btnActiveCustomers.TabIndex = 9;
            this.btnActiveCustomers.Text = "Aktif Müşterileri Getir";
            this.btnActiveCustomers.UseVisualStyleBackColor = true;
            this.btnActiveCustomers.Click += new System.EventHandler(this.btnActiveCustomers_Click);
            // 
            // btnActiveBookings
            // 
            this.btnActiveBookings.Location = new System.Drawing.Point(425, 393);
            this.btnActiveBookings.Name = "btnActiveBookings";
            this.btnActiveBookings.Size = new System.Drawing.Size(116, 37);
            this.btnActiveBookings.TabIndex = 9;
            this.btnActiveBookings.Text = "Aktif Rezervasyonları Getir";
            this.btnActiveBookings.UseVisualStyleBackColor = true;
            this.btnActiveBookings.Click += new System.EventHandler(this.btnActiveBookings_Click_1);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(540, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 499);
            this.label12.TabIndex = 0;
            this.label12.Text = "label1";
            // 
            // cmbOrders
            // 
            this.cmbOrders.FormattingEnabled = true;
            this.cmbOrders.Location = new System.Drawing.Point(318, 479);
            this.cmbOrders.Name = "cmbOrders";
            this.cmbOrders.Size = new System.Drawing.Size(163, 21);
            this.cmbOrders.TabIndex = 16;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(318, 516);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 17;
            this.btnAddOrder.Text = "Sipariş Ekle";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(507, 774);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 30);
            this.label13.TabIndex = 10;
            this.label13.Text = "3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(318, 463);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Sipariş Listesi";
            // 
            // tmrControl
            // 
            this.tmrControl.Interval = 3600000;
            this.tmrControl.Tick += new System.EventHandler(this.tmrControl_Tick);
            // 
            // btnCleanRoom
            // 
            this.btnCleanRoom.Location = new System.Drawing.Point(930, 392);
            this.btnCleanRoom.Name = "btnCleanRoom";
            this.btnCleanRoom.Size = new System.Drawing.Size(88, 23);
            this.btnCleanRoom.TabIndex = 19;
            this.btnCleanRoom.Text = "Oda Temizlendi";
            this.btnCleanRoom.UseVisualStyleBackColor = true;
            this.btnCleanRoom.Click += new System.EventHandler(this.btnCleanRoom_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPrice.Location = new System.Drawing.Point(558, 496);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(195, 43);
            this.lblTotalPrice.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(561, 480);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Toplam Ücret";
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Location = new System.Drawing.Point(557, 553);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(121, 53);
            this.btnTotalPrice.TabIndex = 22;
            this.btnTotalPrice.Text = "Rezervasyonun Ücretini Hesapla";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1456, 813);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnCleanRoom);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.cmbOrders);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.nmrCount);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnActiveBookings);
            this.Controls.Add(this.btnPassiveRezs);
            this.Controls.Add(this.btnActiveCustomers);
            this.Controls.Add(this.btnPassiveCustomers);
            this.Controls.Add(this.btnEmptyRooms);
            this.Controls.Add(this.btnFullRooms);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.lstBookings);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.lstRooms);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.ListBox lstBookings;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFullRooms;
        private System.Windows.Forms.Button btnEmptyRooms;
        private System.Windows.Forms.Button btnPassiveCustomers;
        private System.Windows.Forms.Button btnPassiveRezs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.NumericUpDown nmrCount;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnActiveCustomers;
        private System.Windows.Forms.Button btnActiveBookings;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbOrders;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer tmrControl;
        private System.Windows.Forms.Button btnCleanRoom;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnTotalPrice;
    }
}

