using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.Config;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.FormConfiguration;
using AdminingDataBaseAirLine.UserControls.Data;
using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Themes;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.BackPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AirplaneButton = new System.Windows.Forms.Button();
            this.AirlineButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.PassengerButton = new System.Windows.Forms.Button();
            this.FlightButton = new System.Windows.Forms.Button();
            this.TicketButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.collapseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.ThemeButton = new System.Windows.Forms.Button();
            this.flowTicketPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SortingButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.underliningPanel1 = new System.Windows.Forms.Panel();
            this.erorLabel = new System.Windows.Forms.Label();
            this.underliningPanel7 = new System.Windows.Forms.Panel();
            this.underliningPanel8 = new System.Windows.Forms.Panel();
            this.underliningPanel4 = new System.Windows.Forms.Panel();
            this.underliningPanel3 = new System.Windows.Forms.Panel();
            this.underliningPanel2 = new System.Windows.Forms.Panel();
            this.airPlaneLabel = new System.Windows.Forms.Label();
            this.senderLabel = new System.Windows.Forms.Label();
            this.fromWhereLabel = new System.Windows.Forms.Label();
            this.whereLabel = new System.Windows.Forms.Label();
            this.FlightLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTicketBox = new System.Windows.Forms.TextBox();
            this.numberTicketBox = new System.Windows.Forms.TextBox();
            this.airplaneTicketBox = new System.Windows.Forms.ComboBox();
            this.senderTicketBox = new System.Windows.Forms.ComboBox();
            this.fromWhereTicketBox = new System.Windows.Forms.ComboBox();
            this.whereTicketBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ticketDataLoad = new System.Windows.Forms.Label();
            this.SlideTicketTimer = new System.Windows.Forms.Timer(this.components);
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.ticketPanel.SuspendLayout();
            this.slidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.BackPanel.Controls.Add(this.pictureBox1);
            this.BackPanel.Controls.Add(this.AirplaneButton);
            this.BackPanel.Controls.Add(this.AirlineButton);
            this.BackPanel.Controls.Add(this.AccountButton);
            this.BackPanel.Controls.Add(this.OrdersButton);
            this.BackPanel.Controls.Add(this.PassengerButton);
            this.BackPanel.Controls.Add(this.FlightButton);
            this.BackPanel.Controls.Add(this.TicketButton);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(85, 643);
            this.BackPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 50);
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
            this.AirplaneButton.Image = ((System.Drawing.Image)(resources.GetObject("AirplaneButton.Image")));
            this.AirplaneButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AirplaneButton.Location = new System.Drawing.Point(0, 430);
            this.AirplaneButton.Name = "AirplaneButton";
            this.AirplaneButton.Size = new System.Drawing.Size(85, 65);
            this.AirplaneButton.TabIndex = 7;
            this.AirplaneButton.Text = "Літаки";
            this.AirplaneButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.AirlineButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AirlineButton.Location = new System.Drawing.Point(0, 363);
            this.AirlineButton.Name = "AirlineButton";
            this.AirlineButton.Size = new System.Drawing.Size(85, 65);
            this.AirlineButton.TabIndex = 6;
            this.AirlineButton.Text = "Авіак-нії";
            this.AirlineButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AirlineButton.UseVisualStyleBackColor = false;
            this.AirlineButton.Click += new System.EventHandler(this.AirlineButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.AccountButton.FlatAppearance.BorderSize = 0;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AccountButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.settings_white;
            this.AccountButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AccountButton.Location = new System.Drawing.Point(0, 604);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccountButton.Size = new System.Drawing.Size(85, 39);
            this.AccountButton.TabIndex = 5;
            this.AccountButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AccountButton.UseVisualStyleBackColor = false;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrdersButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OrdersButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.orders_white;
            this.OrdersButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OrdersButton.Location = new System.Drawing.Point(-3, 298);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(88, 65);
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
            this.PassengerButton.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassengerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PassengerButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.pass_white;
            this.PassengerButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PassengerButton.Location = new System.Drawing.Point(0, 234);
            this.PassengerButton.Name = "PassengerButton";
            this.PassengerButton.Size = new System.Drawing.Size(85, 65);
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
            this.FlightButton.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FlightButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.route_white;
            this.FlightButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FlightButton.Location = new System.Drawing.Point(0, 170);
            this.FlightButton.Name = "FlightButton";
            this.FlightButton.Size = new System.Drawing.Size(85, 65);
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
            this.TicketButton.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TicketButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TicketButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.ticket_white;
            this.TicketButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TicketButton.Location = new System.Drawing.Point(0, 106);
            this.TicketButton.Name = "TicketButton";
            this.TicketButton.Size = new System.Drawing.Size(85, 65);
            this.TicketButton.TabIndex = 1;
            this.TicketButton.Text = "Білети";
            this.TicketButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TicketButton.UseVisualStyleBackColor = false;
            this.TicketButton.Click += new System.EventHandler(this.TicketButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.collapseButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.ThemeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(85, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 37);
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
            this.collapseButton.Location = new System.Drawing.Point(1034, 0);
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
            this.closeButton.Location = new System.Drawing.Point(1068, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(39, 37);
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
            this.ThemeButton.Location = new System.Drawing.Point(921, 0);
            this.ThemeButton.Name = "ThemeButton";
            this.ThemeButton.Size = new System.Drawing.Size(39, 37);
            this.ThemeButton.TabIndex = 0;
            this.ThemeButton.UseVisualStyleBackColor = false;
            this.ThemeButton.Click += new System.EventHandler(this.ChangeTheme);
            // 
            // flowTicketPanel
            // 
            this.flowTicketPanel.AutoScroll = true;
            this.flowTicketPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowTicketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowTicketPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTicketPanel.Location = new System.Drawing.Point(3, 3);
            this.flowTicketPanel.Name = "flowTicketPanel";
            this.flowTicketPanel.Size = new System.Drawing.Size(773, 535);
            this.flowTicketPanel.TabIndex = 2;
            this.flowTicketPanel.WrapContents = false;
            this.flowTicketPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowTicketPanel_Paint);
            // 
            // ticketPanel
            // 
            this.ticketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketPanel.Controls.Add(this.slidePanel);
            this.ticketPanel.Controls.Add(this.underliningPanel1);
            this.ticketPanel.Controls.Add(this.erorLabel);
            this.ticketPanel.Controls.Add(this.underliningPanel7);
            this.ticketPanel.Controls.Add(this.underliningPanel8);
            this.ticketPanel.Controls.Add(this.underliningPanel4);
            this.ticketPanel.Controls.Add(this.underliningPanel3);
            this.ticketPanel.Controls.Add(this.underliningPanel2);
            this.ticketPanel.Controls.Add(this.airPlaneLabel);
            this.ticketPanel.Controls.Add(this.senderLabel);
            this.ticketPanel.Controls.Add(this.fromWhereLabel);
            this.ticketPanel.Controls.Add(this.whereLabel);
            this.ticketPanel.Controls.Add(this.FlightLabel);
            this.ticketPanel.Controls.Add(this.priceLabel);
            this.ticketPanel.Controls.Add(this.priceTicketBox);
            this.ticketPanel.Controls.Add(this.numberTicketBox);
            this.ticketPanel.Controls.Add(this.flowTicketPanel);
            this.ticketPanel.Controls.Add(this.airplaneTicketBox);
            this.ticketPanel.Controls.Add(this.senderTicketBox);
            this.ticketPanel.Controls.Add(this.fromWhereTicketBox);
            this.ticketPanel.Controls.Add(this.whereTicketBox);
            this.ticketPanel.Location = new System.Drawing.Point(103, 60);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(1078, 574);
            this.ticketPanel.TabIndex = 3;
            this.ticketPanel.Visible = false;
            this.ticketPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ticketPanel_Paint);
            // 
            // slidePanel
            // 
            this.slidePanel.Controls.Add(this.button1);
            this.slidePanel.Controls.Add(this.RemoveButton);
            this.slidePanel.Controls.Add(this.SortingButton);
            this.slidePanel.Controls.Add(this.AddButton);
            this.slidePanel.Controls.Add(this.FilterButton);
            this.slidePanel.Controls.Add(this.UpdateButton);
            this.slidePanel.Location = new System.Drawing.Point(777, 3);
            this.slidePanel.MaximumSize = new System.Drawing.Size(348, 95);
            this.slidePanel.MinimumSize = new System.Drawing.Size(300, 15);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(300, 15);
            this.slidePanel.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::AdminingDataBaseAirLine.Properties.Resources.angle_small_down;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 15);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RemoveButton.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.RemoveButton.FlatAppearance.BorderSize = 2;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.Location = new System.Drawing.Point(121, -46);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(53, 42);
            this.RemoveButton.TabIndex = 31;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SortingButton
            // 
            this.SortingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SortingButton.BackColor = System.Drawing.SystemColors.Control;
            this.SortingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.SortingButton.FlatAppearance.BorderSize = 2;
            this.SortingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortingButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortingButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SortingButton.Image = ((System.Drawing.Image)(resources.GetObject("SortingButton.Image")));
            this.SortingButton.Location = new System.Drawing.Point(239, -45);
            this.SortingButton.Name = "SortingButton";
            this.SortingButton.Size = new System.Drawing.Size(53, 42);
            this.SortingButton.TabIndex = 33;
            this.SortingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SortingButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.add;
            this.AddButton.Location = new System.Drawing.Point(3, -46);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(53, 42);
            this.AddButton.TabIndex = 20;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FilterButton.BackColor = System.Drawing.SystemColors.Control;
            this.FilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.FilterButton.FlatAppearance.BorderSize = 2;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.Location = new System.Drawing.Point(180, -46);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(53, 42);
            this.FilterButton.TabIndex = 32;
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateButton.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.UpdateButton.FlatAppearance.BorderSize = 2;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.Location = new System.Drawing.Point(62, -46);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(53, 42);
            this.UpdateButton.TabIndex = 30;
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // underliningPanel1
            // 
            this.underliningPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underliningPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel1.Location = new System.Drawing.Point(782, 329);
            this.underliningPanel1.Name = "underliningPanel1";
            this.underliningPanel1.Size = new System.Drawing.Size(121, 8);
            this.underliningPanel1.TabIndex = 19;
            // 
            // erorLabel
            // 
            this.erorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.erorLabel.AutoSize = true;
            this.erorLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erorLabel.ForeColor = System.Drawing.Color.Red;
            this.erorLabel.Location = new System.Drawing.Point(782, 521);
            this.erorLabel.Name = "erorLabel";
            this.erorLabel.Size = new System.Drawing.Size(40, 17);
            this.erorLabel.TabIndex = 29;
            this.erorLabel.Text = "EROR";
            this.erorLabel.Visible = false;
            // 
            // underliningPanel7
            // 
            this.underliningPanel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underliningPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel7.Location = new System.Drawing.Point(782, 506);
            this.underliningPanel7.Name = "underliningPanel7";
            this.underliningPanel7.Size = new System.Drawing.Size(121, 8);
            this.underliningPanel7.TabIndex = 20;
            // 
            // underliningPanel8
            // 
            this.underliningPanel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underliningPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel8.Location = new System.Drawing.Point(937, 509);
            this.underliningPanel8.Name = "underliningPanel8";
            this.underliningPanel8.Size = new System.Drawing.Size(121, 8);
            this.underliningPanel8.TabIndex = 19;
            // 
            // underliningPanel4
            // 
            this.underliningPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underliningPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel4.Location = new System.Drawing.Point(937, 410);
            this.underliningPanel4.Name = "underliningPanel4";
            this.underliningPanel4.Size = new System.Drawing.Size(121, 8);
            this.underliningPanel4.TabIndex = 19;
            // 
            // underliningPanel3
            // 
            this.underliningPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underliningPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel3.Location = new System.Drawing.Point(782, 407);
            this.underliningPanel3.Name = "underliningPanel3";
            this.underliningPanel3.Size = new System.Drawing.Size(121, 8);
            this.underliningPanel3.TabIndex = 19;
            // 
            // underliningPanel2
            // 
            this.underliningPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underliningPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel2.Location = new System.Drawing.Point(937, 332);
            this.underliningPanel2.Name = "underliningPanel2";
            this.underliningPanel2.Size = new System.Drawing.Size(121, 8);
            this.underliningPanel2.TabIndex = 19;
            // 
            // airPlaneLabel
            // 
            this.airPlaneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.airPlaneLabel.AutoSize = true;
            this.airPlaneLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airPlaneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.airPlaneLabel.Location = new System.Drawing.Point(782, 431);
            this.airPlaneLabel.Name = "airPlaneLabel";
            this.airPlaneLabel.Size = new System.Drawing.Size(89, 50);
            this.airPlaneLabel.TabIndex = 14;
            this.airPlaneLabel.Text = "Модель\r\nлітака:";
            // 
            // senderLabel
            // 
            this.senderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senderLabel.AutoSize = true;
            this.senderLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.senderLabel.Location = new System.Drawing.Point(937, 430);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.senderLabel.Size = new System.Drawing.Size(133, 50);
            this.senderLabel.TabIndex = 15;
            this.senderLabel.Text = "Авіа-комп\r\nвідправник:";
            // 
            // fromWhereLabel
            // 
            this.fromWhereLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromWhereLabel.AutoSize = true;
            this.fromWhereLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromWhereLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.fromWhereLabel.Location = new System.Drawing.Point(782, 353);
            this.fromWhereLabel.Name = "fromWhereLabel";
            this.fromWhereLabel.Size = new System.Drawing.Size(89, 25);
            this.fromWhereLabel.TabIndex = 6;
            this.fromWhereLabel.Text = "Звідки:";
            // 
            // whereLabel
            // 
            this.whereLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whereLabel.AutoSize = true;
            this.whereLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whereLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.whereLabel.Location = new System.Drawing.Point(937, 356);
            this.whereLabel.Name = "whereLabel";
            this.whereLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.whereLabel.Size = new System.Drawing.Size(67, 25);
            this.whereLabel.TabIndex = 7;
            this.whereLabel.Text = "Куди:";
            // 
            // FlightLabel
            // 
            this.FlightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlightLabel.AutoSize = true;
            this.FlightLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.FlightLabel.Location = new System.Drawing.Point(782, 277);
            this.FlightLabel.Name = "FlightLabel";
            this.FlightLabel.Size = new System.Drawing.Size(100, 25);
            this.FlightLabel.TabIndex = 6;
            this.FlightLabel.Text = "№ Рейсу:";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.priceLabel.Location = new System.Drawing.Point(937, 280);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceLabel.Size = new System.Drawing.Size(67, 25);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Ціна:";
            // 
            // priceTicketBox
            // 
            this.priceTicketBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTicketBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTicketBox.Location = new System.Drawing.Point(937, 306);
            this.priceTicketBox.Name = "priceTicketBox";
            this.priceTicketBox.Size = new System.Drawing.Size(121, 26);
            this.priceTicketBox.TabIndex = 4;
            // 
            // numberTicketBox
            // 
            this.numberTicketBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberTicketBox.BackColor = System.Drawing.SystemColors.Window;
            this.numberTicketBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberTicketBox.Location = new System.Drawing.Point(782, 303);
            this.numberTicketBox.Name = "numberTicketBox";
            this.numberTicketBox.Size = new System.Drawing.Size(121, 26);
            this.numberTicketBox.TabIndex = 3;
            // 
            // airplaneTicketBox
            // 
            this.airplaneTicketBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.airplaneTicketBox.DropDownHeight = 100;
            this.airplaneTicketBox.DropDownWidth = 120;
            this.airplaneTicketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.airplaneTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airplaneTicketBox.FormattingEnabled = true;
            this.airplaneTicketBox.IntegralHeight = false;
            this.airplaneTicketBox.Location = new System.Drawing.Point(782, 480);
            this.airplaneTicketBox.Name = "airplaneTicketBox";
            this.airplaneTicketBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.airplaneTicketBox.Size = new System.Drawing.Size(121, 33);
            this.airplaneTicketBox.TabIndex = 22;
            // 
            // senderTicketBox
            // 
            this.senderTicketBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senderTicketBox.DropDownHeight = 100;
            this.senderTicketBox.DropDownWidth = 120;
            this.senderTicketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.senderTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senderTicketBox.FormattingEnabled = true;
            this.senderTicketBox.IntegralHeight = false;
            this.senderTicketBox.Location = new System.Drawing.Point(937, 482);
            this.senderTicketBox.Name = "senderTicketBox";
            this.senderTicketBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.senderTicketBox.Size = new System.Drawing.Size(121, 33);
            this.senderTicketBox.TabIndex = 23;
            // 
            // fromWhereTicketBox
            // 
            this.fromWhereTicketBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromWhereTicketBox.DropDownHeight = 100;
            this.fromWhereTicketBox.DropDownWidth = 120;
            this.fromWhereTicketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromWhereTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromWhereTicketBox.FormattingEnabled = true;
            this.fromWhereTicketBox.IntegralHeight = false;
            this.fromWhereTicketBox.Location = new System.Drawing.Point(782, 380);
            this.fromWhereTicketBox.Name = "fromWhereTicketBox";
            this.fromWhereTicketBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fromWhereTicketBox.Size = new System.Drawing.Size(121, 33);
            this.fromWhereTicketBox.TabIndex = 27;
            // 
            // whereTicketBox
            // 
            this.whereTicketBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whereTicketBox.DropDownHeight = 100;
            this.whereTicketBox.DropDownWidth = 120;
            this.whereTicketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whereTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whereTicketBox.FormattingEnabled = true;
            this.whereTicketBox.IntegralHeight = false;
            this.whereTicketBox.Location = new System.Drawing.Point(937, 383);
            this.whereTicketBox.Name = "whereTicketBox";
            this.whereTicketBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.whereTicketBox.Size = new System.Drawing.Size(121, 33);
            this.whereTicketBox.TabIndex = 26;
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
            // ticketDataLoad
            // 
            this.ticketDataLoad.AutoSize = true;
            this.ticketDataLoad.Font = new System.Drawing.Font("JetBrains Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketDataLoad.ForeColor = System.Drawing.Color.Silver;
            this.ticketDataLoad.Location = new System.Drawing.Point(398, 288);
            this.ticketDataLoad.Name = "ticketDataLoad";
            this.ticketDataLoad.Size = new System.Drawing.Size(506, 49);
            this.ticketDataLoad.TabIndex = 4;
            this.ticketDataLoad.Text = "Завантаження даних... ";
            this.ticketDataLoad.Visible = false;
            // 
            // SlideTicketTimer
            // 
            this.SlideTicketTimer.Interval = 10;
            this.SlideTicketTimer.Tick += new System.EventHandler(this.SlideTicketTimer_Tick);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1192, 643);
            this.Controls.Add(this.ticketPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.ticketDataLoad);
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
            this.slidePanel.ResumeLayout(false);
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
                .SetWhiteImage(Resources.ticket_white)
                .SetBlueImage(Resources.ticket_blue)
                .SetDarkImage(Resources.ticket_dark)
                .Build(),

                ["flightButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(FlightButton)
                .SetWhiteImage(Resources.route_white)
                .SetBlueImage(Resources.route_blue)
                .SetDarkImage(Resources.route_dark)
                .Build(),


                ["passengerButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(PassengerButton)
                .SetWhiteImage(Resources.pass_white)
                .SetBlueImage(Resources.pass_blue)
                .SetDarkImage(Resources.pass_dark)
                .Build(),

                ["ordersButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(OrdersButton)
                .SetWhiteImage(Resources.orders_white)
                .SetBlueImage(Resources.orders_blue)
                .SetDarkImage(Resources.orders_dark)
                .Build(),

                ["accountButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(AccountButton)
                .SetWhiteImage(Resources.settings_white)
                .SetBlueImage(Resources.settings_blue)
                .SetDarkImage(Resources.settings_dark)
                .Build(),

                ["airlineButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(AirlineButton)
                .SetWhiteImage(Resources.airline_white)
                .SetBlueImage(Resources.airline_blue)
                .SetDarkImage(Resources.airline_dark)
                .Build(),

                ["airplaneButtonOpen"] = new ButtonPropertyBuilder()
                .SetIsOpen(false)
                .SetButton(AirplaneButton)
                .SetWhiteImage(Resources.airplane_white)
                .SetBlueImage(Resources.airplane_blue)
                .SetDarkImage(Resources.airplane_dark)
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
        private Label FlightLabel;
        private Label priceLabel;
        private Label ticketDataLoad;
        private Label fromWhereLabel;
        private Label whereLabel;
        private Label airPlaneLabel;
        private Label senderLabel;
        private Panel underliningPanel8;
        private Panel underliningPanel4;
        private Panel underliningPanel3;
        private Panel underliningPanel2;
        private Panel underliningPanel1;
        private Button AddButton;
        private MenuStrip menuStrip1;
        private Button AirlineButton;
        private Panel panel2;
        private Panel underliningPanel7;
        private TextBox numberTicketBox;
        private TextBox priceTicketBox;
        private ComboBox airplaneTicketBox;
        private ComboBox senderTicketBox;
        private ComboBox fromWhereTicketBox;
        private ComboBox whereTicketBox;
        private Button AirplaneButton;
        private PictureBox pictureBox1;
        private Label erorLabel;
        private Button UpdateButton;
        private Button RemoveButton;
        private Button FilterButton;
        private Panel slidePanel;
        private Button button1;
        private Button SortingButton;
        private System.Windows.Forms.Timer SlideTicketTimer;

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
        public ComboBox AirplaneTicketBox { get => airplaneTicketBox; set => airplaneTicketBox = value; }
        public ComboBox SenderTicketBox { get => senderTicketBox; set => senderTicketBox = value; }
        public ComboBox FromWhereTicketBox { get => fromWhereTicketBox; set => fromWhereTicketBox = value; }
        public ComboBox WhereTicketBox { get => whereTicketBox; set => whereTicketBox = value; }
        public TextBox NumberTicketBox { get => numberTicketBox; set => numberTicketBox = value; }
        public TextBox PriceTicketBox { get => priceTicketBox; set => priceTicketBox = value; }
        public Button AddButton1 { get => AddButton; set => AddButton = value; }
        public Label ErorLabel { get => erorLabel; set => erorLabel = value; }
        public Button UpdateButton1 { get => UpdateButton; set => UpdateButton = value; }
        public Button RemoveButton1 { get => RemoveButton; set => RemoveButton = value; }
    }
}


