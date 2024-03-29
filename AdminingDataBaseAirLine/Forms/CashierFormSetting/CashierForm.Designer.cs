﻿using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.FormConfiguration;
using AdminingDataBaseAirLine.ControlConfigs;

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
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AirplaneButton = new System.Windows.Forms.Button();
            this.AirlineButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.PassengerButton = new System.Windows.Forms.Button();
            this.FlightButton = new System.Windows.Forms.Button();
            this.TicketButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.collapseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataLoad = new System.Windows.Forms.Label();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.BackPanel.Controls.Add(this.label1);
            this.BackPanel.Controls.Add(this.panel4);
            this.BackPanel.Controls.Add(this.panel3);
            this.BackPanel.Controls.Add(this.pictureBox1);
            this.BackPanel.Controls.Add(this.AirplaneButton);
            this.BackPanel.Controls.Add(this.AirlineButton);
            this.BackPanel.Controls.Add(this.OrdersButton);
            this.BackPanel.Controls.Add(this.PassengerButton);
            this.BackPanel.Controls.Add(this.FlightButton);
            this.BackPanel.Controls.Add(this.TicketButton);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(182, 643);
            this.BackPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Панель управління";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(16, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 5);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(16, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 5);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AirplaneButton
            // 
            this.AirplaneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.AirplaneButton.FlatAppearance.BorderSize = 0;
            this.AirplaneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AirplaneButton.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AirplaneButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AirplaneButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.bookSeats_white;
            this.AirplaneButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AirplaneButton.Location = new System.Drawing.Point(0, 391);
            this.AirplaneButton.Name = "AirplaneButton";
            this.AirplaneButton.Size = new System.Drawing.Size(182, 43);
            this.AirplaneButton.TabIndex = 7;
            this.AirplaneButton.Tag = " ";
            this.AirplaneButton.Text = "  Бронювання місць";
            this.AirplaneButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AirplaneButton.UseVisualStyleBackColor = false;
            this.AirplaneButton.Click += new System.EventHandler(this.AirplaneButton_Click);
            // 
            // AirlineButton
            // 
            this.AirlineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.AirlineButton.FlatAppearance.BorderSize = 0;
            this.AirlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AirlineButton.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AirlineButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AirlineButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.airline_white;
            this.AirlineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AirlineButton.Location = new System.Drawing.Point(0, 304);
            this.AirlineButton.Name = "AirlineButton";
            this.AirlineButton.Size = new System.Drawing.Size(182, 43);
            this.AirlineButton.TabIndex = 6;
            this.AirlineButton.Text = "  Авіакомпанії";
            this.AirlineButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AirlineButton.UseVisualStyleBackColor = false;
            this.AirlineButton.Click += new System.EventHandler(this.AirlineButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrdersButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OrdersButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.orders_white;
            this.OrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersButton.Location = new System.Drawing.Point(0, 348);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(182, 43);
            this.OrdersButton.TabIndex = 4;
            this.OrdersButton.Text = "  Замовлення";
            this.OrdersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // PassengerButton
            // 
            this.PassengerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.PassengerButton.FlatAppearance.BorderSize = 0;
            this.PassengerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerButton.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassengerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PassengerButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.people_white;
            this.PassengerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengerButton.Location = new System.Drawing.Point(0, 262);
            this.PassengerButton.Name = "PassengerButton";
            this.PassengerButton.Size = new System.Drawing.Size(182, 43);
            this.PassengerButton.TabIndex = 3;
            this.PassengerButton.Text = "  Пасажири";
            this.PassengerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PassengerButton.UseVisualStyleBackColor = false;
            this.PassengerButton.Click += new System.EventHandler(this.PassengerButton_Click);
            // 
            // FlightButton
            // 
            this.FlightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.FlightButton.FlatAppearance.BorderSize = 0;
            this.FlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightButton.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FlightButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.route_white;
            this.FlightButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FlightButton.Location = new System.Drawing.Point(0, 219);
            this.FlightButton.Name = "FlightButton";
            this.FlightButton.Size = new System.Drawing.Size(182, 43);
            this.FlightButton.TabIndex = 2;
            this.FlightButton.Text = "  Рейси";
            this.FlightButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FlightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FlightButton.UseVisualStyleBackColor = false;
            this.FlightButton.Click += new System.EventHandler(this.FlightButton_Click);
            // 
            // TicketButton
            // 
            this.TicketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.TicketButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TicketButton.FlatAppearance.BorderSize = 0;
            this.TicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketButton.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TicketButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TicketButton.Image = ((System.Drawing.Image)(resources.GetObject("TicketButton.Image")));
            this.TicketButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TicketButton.Location = new System.Drawing.Point(0, 176);
            this.TicketButton.Name = "TicketButton";
            this.TicketButton.Size = new System.Drawing.Size(182, 43);
            this.TicketButton.TabIndex = 1;
            this.TicketButton.Tag = "Білети";
            this.TicketButton.Text = "  Білети";
            this.TicketButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TicketButton.UseVisualStyleBackColor = false;
            this.TicketButton.Click += new System.EventHandler(this.TicketButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.collapseButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(182, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 37);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1084, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 38);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.closeButton_Click);
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
            this.collapseButton.Location = new System.Drawing.Point(1051, 0);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(33, 37);
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
            this.closeButton.Location = new System.Drawing.Point(1133, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(39, 37);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 5);
            this.panel2.TabIndex = 20;
            // 
            // DataLoad
            // 
            this.DataLoad.AutoSize = true;
            this.DataLoad.Font = new System.Drawing.Font("JetBrains Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataLoad.ForeColor = System.Drawing.Color.Silver;
            this.DataLoad.Location = new System.Drawing.Point(576, 298);
            this.DataLoad.Name = "DataLoad";
            this.DataLoad.Size = new System.Drawing.Size(506, 49);
            this.DataLoad.TabIndex = 4;
            this.DataLoad.Text = "Завантаження даних... ";
            this.DataLoad.Visible = false;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1308, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.DataLoad);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
    
        public Dictionary<string, ButtonProperty> GetButtonProperties()
        {
            return new Dictionary<string, ButtonProperty>()
            {
                ["ticketButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(TicketButton)
                .SetWhiteImage(Resources.ticket_airline_white)
                .SetBlueImage(Resources.ticket_airline_blue)
                .Build(),

                ["flightButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(FlightButton)
                .SetWhiteImage(Resources.route_white)
                .SetBlueImage(Resources.route_blue)
                .Build(),


                ["passengerButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(PassengerButton)
                .SetWhiteImage(Resources.people_white)
                .SetBlueImage(Resources.people_blue)
                .Build(),

                ["ordersButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(OrdersButton)
                .SetWhiteImage(Resources.orders_white)
                .SetBlueImage(Resources.orders_blue)
                .Build(),             

                ["airlineButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(AirlineButton)
                .SetWhiteImage(Resources.airline_white)
                .SetBlueImage(Resources.airline_blue)
                .Build(),

                ["airplaneButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(AirplaneButton)
                .SetWhiteImage(Resources.bookSeats_white)
                .SetBlueImage(Resources.bookSeats_blue)
                .Build()

            };

        }
        public static ControlConfiguration GetConfiguration()
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

      

       




        private Panel BackPanel;
        private Panel panel1;
        private Button TicketButton;
        private Button FlightButton;
        private Button OrdersButton;
        private Button PassengerButton;
        private Button collapseButton;
        private Button closeButton;
        private Label DataLoad;
        private MenuStrip menuStrip1;
        private Button AirlineButton;
        private Panel panel2;
        private Button AirplaneButton;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Panel panel4;
        private Panel panel3;

        public Panel BackPanel_P { get => BackPanel; set => BackPanel = value; }
        public Panel Panel_P { get => panel1; set => panel1 = value; }
        public Button Ticket_P { get => TicketButton; set => TicketButton = value; }
        public Button FlightButton_P { get => FlightButton; set => FlightButton = value; }
        public Button OrdersButton1_P { get => OrdersButton; set => OrdersButton = value; }
        public Button PassengerButton_P { get => PassengerButton; set => PassengerButton = value; }
        public Button CollapseButton { get => collapseButton; set => collapseButton = value; }
        public Button CloseButton { get => closeButton; set => closeButton = value; }
 
    }
}


