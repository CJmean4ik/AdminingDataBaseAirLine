using AdminingDataBaseAirLine.Forms.ButtonSettings;
using AdminingDataBaseAirLine.Properties;

namespace AdminingDataBaseAirLine.Forms
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
            this.BackPanel.Size = new System.Drawing.Size(101, 651);
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
            this.AccountButton.Location = new System.Drawing.Point(0, 576);
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
            this.panel1.Size = new System.Drawing.Size(1091, 39);
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
            this.collapseButton.Location = new System.Drawing.Point(1018, 0);
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
            this.closeButton.Location = new System.Drawing.Point(1052, 0);
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
            this.ThemeButton.Location = new System.Drawing.Point(905, 0);
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
            this.flowTicketPanel.Location = new System.Drawing.Point(15, 8);
            this.flowTicketPanel.Name = "flowTicketPanel";
            this.flowTicketPanel.Size = new System.Drawing.Size(767, 597);
            this.flowTicketPanel.TabIndex = 2;
            this.flowTicketPanel.Visible = false;
            this.flowTicketPanel.WrapContents = false;
            this.flowTicketPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowTicketPanel_Paint);
            // 
            // ticketPanel
            // 
            this.ticketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketPanel.Controls.Add(this.flowTicketPanel);
            this.ticketPanel.Location = new System.Drawing.Point(132, 45);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(783, 606);
            this.ticketPanel.TabIndex = 3;
            this.ticketPanel.Visible = false;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1185, 651);
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
            this.ResumeLayout(false);

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


