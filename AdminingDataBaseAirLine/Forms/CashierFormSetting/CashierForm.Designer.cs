﻿using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.ControlConfigs;
using AdminingDataBaseAirLine.UserControls;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.FormConfiguration;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.BackPanel = new System.Windows.Forms.Panel();
            this.AccountButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.PassengerButton = new System.Windows.Forms.Button();
            this.FlightButton = new System.Windows.Forms.Button();
            this.TicketButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.collapseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.ThemeButton = new System.Windows.Forms.Button();
            this.flowTicketPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FlightLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTicketBox = new System.Windows.Forms.TextBox();
            this.numberTicketBox = new System.Windows.Forms.TextBox();
            this.ticketDataLoad = new System.Windows.Forms.Label();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.ticketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.BackPanel.Controls.Add(this.AccountButton);
            this.BackPanel.Controls.Add(this.OrdersButton);
            this.BackPanel.Controls.Add(this.PassengerButton);
            this.BackPanel.Controls.Add(this.FlightButton);
            this.BackPanel.Controls.Add(this.TicketButton);
            this.BackPanel.Controls.Add(this.pictureBox1);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(101, 686);
            this.BackPanel.TabIndex = 0;
            // 
            // AccountButton
            // 
            this.AccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.AccountButton.FlatAppearance.BorderSize = 0;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AccountButton.Image = ((System.Drawing.Image)(resources.GetObject("AccountButton.Image")));
            this.AccountButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AccountButton.Location = new System.Drawing.Point(0, 607);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccountButton.Size = new System.Drawing.Size(101, 79);
            this.AccountButton.TabIndex = 5;
            this.AccountButton.Text = "Особистий Кабінет";
            this.AccountButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AccountButton.UseVisualStyleBackColor = false;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrdersButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdersButton.Image")));
            this.OrdersButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OrdersButton.Location = new System.Drawing.Point(0, 466);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(101, 104);
            this.OrdersButton.TabIndex = 4;
            this.OrdersButton.Text = "Замовлення";
            this.OrdersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // PassengerButton
            // 
            this.PassengerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.PassengerButton.FlatAppearance.BorderSize = 0;
            this.PassengerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerButton.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassengerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PassengerButton.Image = ((System.Drawing.Image)(resources.GetObject("PassengerButton.Image")));
            this.PassengerButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PassengerButton.Location = new System.Drawing.Point(0, 362);
            this.PassengerButton.Name = "PassengerButton";
            this.PassengerButton.Size = new System.Drawing.Size(101, 98);
            this.PassengerButton.TabIndex = 3;
            this.PassengerButton.Text = "Пасажири";
            this.PassengerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PassengerButton.UseVisualStyleBackColor = false;
            this.PassengerButton.Click += new System.EventHandler(this.PassengerButton_Click);
            // 
            // FlightButton
            // 
            this.FlightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.FlightButton.FlatAppearance.BorderSize = 0;
            this.FlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightButton.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FlightButton.Image = ((System.Drawing.Image)(resources.GetObject("FlightButton.Image")));
            this.FlightButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FlightButton.Location = new System.Drawing.Point(0, 261);
            this.FlightButton.Name = "FlightButton";
            this.FlightButton.Size = new System.Drawing.Size(101, 95);
            this.FlightButton.TabIndex = 2;
            this.FlightButton.Text = "Рейси";
            this.FlightButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FlightButton.UseVisualStyleBackColor = false;
            this.FlightButton.Click += new System.EventHandler(this.FlightButton_Click);
            // 
            // TicketButton
            // 
            this.TicketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.TicketButton.FlatAppearance.BorderSize = 0;
            this.TicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketButton.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TicketButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TicketButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.ticket_white;
            this.TicketButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TicketButton.Location = new System.Drawing.Point(0, 158);
            this.TicketButton.Name = "TicketButton";
            this.TicketButton.Size = new System.Drawing.Size(101, 97);
            this.TicketButton.TabIndex = 1;
            this.TicketButton.Text = "Білети";
            this.TicketButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TicketButton.UseVisualStyleBackColor = false;
            this.TicketButton.Click += new System.EventHandler(this.TicketButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.collapseButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.ThemeButton);
            this.panel1.Location = new System.Drawing.Point(94, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 39);
            this.panel1.TabIndex = 1;
            // 
            // collapseButton
            // 
            this.collapseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.collapseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.collapseButton.FlatAppearance.BorderSize = 0;
            this.collapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.collapseButton.Image = ((System.Drawing.Image)(resources.GetObject("collapseButton.Image")));
            this.collapseButton.Location = new System.Drawing.Point(1039, 0);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(33, 39);
            this.collapseButton.TabIndex = 3;
            this.collapseButton.UseVisualStyleBackColor = false;
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1073, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(39, 39);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ThemeButton
            // 
            this.ThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.ThemeButton.FlatAppearance.BorderSize = 0;
            this.ThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ThemeButton.Image = ((System.Drawing.Image)(resources.GetObject("ThemeButton.Image")));
            this.ThemeButton.Location = new System.Drawing.Point(926, 0);
            this.ThemeButton.Name = "ThemeButton";
            this.ThemeButton.Size = new System.Drawing.Size(39, 39);
            this.ThemeButton.TabIndex = 0;
            this.ThemeButton.UseVisualStyleBackColor = false;
            this.ThemeButton.Click += new System.EventHandler(this.ChangeTheme);
            // 
            // flowTicketPanel
            // 
            this.flowTicketPanel.AutoScroll = true;
            this.flowTicketPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowTicketPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTicketPanel.Location = new System.Drawing.Point(3, -1);
            this.flowTicketPanel.Name = "flowTicketPanel";
            this.flowTicketPanel.Size = new System.Drawing.Size(770, 606);
            this.flowTicketPanel.TabIndex = 2;
            this.flowTicketPanel.Visible = false;
            this.flowTicketPanel.WrapContents = false;
            // 
            // ticketPanel
            // 
            this.ticketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketPanel.Controls.Add(this.textBox2);
            this.ticketPanel.Controls.Add(this.textBox3);
            this.ticketPanel.Controls.Add(this.FlightLabel);
            this.ticketPanel.Controls.Add(this.priceLabel);
            this.ticketPanel.Controls.Add(this.priceTicketBox);
            this.ticketPanel.Controls.Add(this.numberTicketBox);
            this.ticketPanel.Controls.Add(this.flowTicketPanel);
            this.ticketPanel.Location = new System.Drawing.Point(118, 67);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(1062, 607);
            this.ticketPanel.TabIndex = 3;
            this.ticketPanel.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(930, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 33);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(779, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 33);
            this.textBox3.TabIndex = 8;
            // 
            // FlightLabel
            // 
            this.FlightLabel.AutoSize = true;
            this.FlightLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.FlightLabel.Location = new System.Drawing.Point(779, 23);
            this.FlightLabel.Name = "FlightLabel";
            this.FlightLabel.Size = new System.Drawing.Size(100, 25);
            this.FlightLabel.TabIndex = 6;
            this.FlightLabel.Text = "№ Рейсу:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.priceLabel.Location = new System.Drawing.Point(930, 23);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceLabel.Size = new System.Drawing.Size(67, 25);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Ціна:";
            // 
            // priceTicketBox
            // 
            this.priceTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTicketBox.Location = new System.Drawing.Point(930, 51);
            this.priceTicketBox.Name = "priceTicketBox";
            this.priceTicketBox.Size = new System.Drawing.Size(121, 33);
            this.priceTicketBox.TabIndex = 4;
            // 
            // numberTicketBox
            // 
            this.numberTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberTicketBox.Location = new System.Drawing.Point(779, 51);
            this.numberTicketBox.Name = "numberTicketBox";
            this.numberTicketBox.Size = new System.Drawing.Size(121, 33);
            this.numberTicketBox.TabIndex = 3;
            // 
            // ticketDataLoad
            // 
            this.ticketDataLoad.AutoSize = true;
            this.ticketDataLoad.Font = new System.Drawing.Font("JetBrains Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketDataLoad.ForeColor = System.Drawing.Color.Silver;
            this.ticketDataLoad.Location = new System.Drawing.Point(398, 307);
            this.ticketDataLoad.Name = "ticketDataLoad";
            this.ticketDataLoad.Size = new System.Drawing.Size(506, 49);
            this.ticketDataLoad.TabIndex = 4;
            this.ticketDataLoad.Text = "Завантаження даних... ";
            this.ticketDataLoad.Visible = false;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1206, 686);
            this.Controls.Add(this.ticketDataLoad);
            this.Controls.Add(this.ticketPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.BackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Dictionary<string, ButtonProperty> GetButtonProperties()
        {
             return new Dictionary<string, ButtonProperty>()
            {
                ["ticketButtonOpen"] = new ButtonPropertyBuilder()
                 .SetIsOpen(false)
                 .SetButton(TicketButton)
                 .SetWhiteImage(Resources.ticket_white)
                 .SetBlueImage(Resources.ticket_blue)
                 .SetDarkImage(Resources.ticket_dark)
                 .Build(),

                ["flightButtonOpen"] = new ButtonPropertyBuilder()
                 .SetIsOpen(false)
                 .SetButton(FlightButton)
                 .SetWhiteImage(Resources.flight_white)
                 .SetBlueImage(Resources.flight_blue)
                 .SetDarkImage(Resources.flight_dark)
                 .Build(),


                ["passengerButtonOpen"] = new ButtonPropertyBuilder()
                 .SetIsOpen(false)
                 .SetButton(PassengerButton)
                 .SetWhiteImage(Resources.pass_white)
                 .SetBlueImage(Resources.passenger_blue)
                 .SetDarkImage(Resources.pass_dark)
                 .Build(),

                ["ordersButtonOpen"] = new ButtonPropertyBuilder()
                 .SetIsOpen(false)
                 .SetButton(OrdersButton)
                 .SetWhiteImage(Resources.order_white)
                 .SetBlueImage(Resources.receipt_blue)
                 .SetDarkImage(Resources.order_dark)
                 .Build(),

                 ["accountButtonOpen"] = new ButtonPropertyBuilder()
                 .SetIsOpen(false)
                 .SetButton(AccountButton)
                 .SetWhiteImage(Resources.profile_white)
                 .SetBlueImage(Resources.profile_blue)
                 .SetDarkImage(Resources.profile_dark)
                 .Build()
             };

    }
        public ControlConfiguration GetConfiguration()
        {
            return new ControlConfigurationBuilder()
                .SetPanelColor(Color.FromArgb(80, 81, 249), Color.FromArgb(10, 126, 245))
                .SetControlColor(Color.FromArgb(41, 41, 51), Color.FromName("Control"))
                .SetLabelFColor(Color.FromArgb(80, 81, 249), Color.FromArgb(10, 126, 245))
                .SetLabelSColor(Color.FromArgb(95, 99, 136), Color.Black)
                .Build();
        }
        public CashierFormConfiguration GetFormConfiguration()
        {
            return new CashierFormConfigurationBuilder()
                .SetDarkColor(Color.FromArgb(20, 21, 23), Color.FromArgb(30, 31, 36))
                .SetWhiteColor(Color.FromName("Control"))
                .SetBlueColor(Color.FromArgb(10, 126, 245))
                .SetPurpleColor(Color.FromArgb(80, 81, 249))
                .Build();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel BackPanel;
        private Panel panel1;
        private Button TicketButton;
        private Button FlightButton;
        private Button AccountButton;
        private Button OrdersButton;
        private Button PassengerButton;
        private Button ThemeButton;
        private Button collapseButton;
        private Button closeButton;
        private FlowLayoutPanel flowTicketPanel;
        private Panel ticketPanel;
        private TextBox numberTicketBox;
        private TextBox priceTicketBox;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label FlightLabel;
        private Label priceLabel;
        private Label ticketDataLoad;

        public Panel BackPanel_P { get => BackPanel; set => BackPanel = value; }
        public Panel Panel_P { get => panel1; set => panel1 = value; }
        public Button Ticket_P { get => TicketButton; set => TicketButton = value; }
        public Button FlightButton_P { get => FlightButton; set => FlightButton = value; }
        public Button AccountButton_P { get => AccountButton; set => AccountButton = value; }
        public Button OrdersButton1_P { get => OrdersButton; set => OrdersButton = value; }
        public Button PassengerButton_P { get => PassengerButton; set => PassengerButton = value; }
        public Button ThemeButton_P { get => ThemeButton; set => ThemeButton = value; }
        public Button CollapseButton { get => collapseButton; set => collapseButton = value; }
        public Button CloseButton { get => closeButton; set => closeButton = value; }
        public FlowLayoutPanel FlowTicketPanel { get => flowTicketPanel; set => flowTicketPanel = value; }
        public Panel TicketPanel { get => ticketPanel; set => ticketPanel = value; }
    }
}


