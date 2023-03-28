using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.Config;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.FormConfiguration;
using AdminingDataBaseAirLine.UserControls.Data;

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
            this.warningExistLabel = new System.Windows.Forms.Label();
            this.underliningPanel7 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.underliningPanel8 = new System.Windows.Forms.Panel();
            this.underliningPanel6 = new System.Windows.Forms.Panel();
            this.underliningPanel5 = new System.Windows.Forms.Panel();
            this.underliningPanel4 = new System.Windows.Forms.Panel();
            this.underliningPanel3 = new System.Windows.Forms.Panel();
            this.underliningPanel2 = new System.Windows.Forms.Panel();
            this.underliningPanel1 = new System.Windows.Forms.Panel();
            this.airPlaneLabel = new System.Windows.Forms.Label();
            this.senderLabel = new System.Windows.Forms.Label();
            this.deparLabel = new System.Windows.Forms.Label();
            this.arivalLabel = new System.Windows.Forms.Label();
            this.fromWhereLabel = new System.Windows.Forms.Label();
            this.whereLabel = new System.Windows.Forms.Label();
            this.FlightLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTicketBox = new System.Windows.Forms.TextBox();
            this.numberTicketBox = new System.Windows.Forms.TextBox();
            this.airplaneTicketBox = new System.Windows.Forms.ComboBox();
            this.senderTicketBox = new System.Windows.Forms.ComboBox();
            this.departTicketBox = new System.Windows.Forms.ComboBox();
            this.arivalTicketBox = new System.Windows.Forms.ComboBox();
            this.fromWhereTicketBox = new System.Windows.Forms.ComboBox();
            this.whereTicketBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ticketDataLoad = new System.Windows.Forms.Label();
            this.BackPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ticketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
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
            this.panel1.Size = new System.Drawing.Size(1153, 37);
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
            this.collapseButton.Location = new System.Drawing.Point(1080, 0);
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
            this.closeButton.Location = new System.Drawing.Point(1114, 0);
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
            this.ThemeButton.Location = new System.Drawing.Point(967, 0);
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
            this.flowTicketPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTicketPanel.Location = new System.Drawing.Point(3, -1);
            this.flowTicketPanel.Name = "flowTicketPanel";
            this.flowTicketPanel.Size = new System.Drawing.Size(770, 575);
            this.flowTicketPanel.TabIndex = 2;
            this.flowTicketPanel.WrapContents = false;
            // 
            // ticketPanel
            // 
            this.ticketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketPanel.Controls.Add(this.warningExistLabel);
            this.ticketPanel.Controls.Add(this.underliningPanel7);
            this.ticketPanel.Controls.Add(this.AddButton);
            this.ticketPanel.Controls.Add(this.underliningPanel8);
            this.ticketPanel.Controls.Add(this.underliningPanel6);
            this.ticketPanel.Controls.Add(this.underliningPanel5);
            this.ticketPanel.Controls.Add(this.underliningPanel4);
            this.ticketPanel.Controls.Add(this.underliningPanel3);
            this.ticketPanel.Controls.Add(this.underliningPanel2);
            this.ticketPanel.Controls.Add(this.underliningPanel1);
            this.ticketPanel.Controls.Add(this.airPlaneLabel);
            this.ticketPanel.Controls.Add(this.senderLabel);
            this.ticketPanel.Controls.Add(this.deparLabel);
            this.ticketPanel.Controls.Add(this.arivalLabel);
            this.ticketPanel.Controls.Add(this.fromWhereLabel);
            this.ticketPanel.Controls.Add(this.whereLabel);
            this.ticketPanel.Controls.Add(this.FlightLabel);
            this.ticketPanel.Controls.Add(this.priceLabel);
            this.ticketPanel.Controls.Add(this.priceTicketBox);
            this.ticketPanel.Controls.Add(this.numberTicketBox);
            this.ticketPanel.Controls.Add(this.flowTicketPanel);
            this.ticketPanel.Controls.Add(this.airplaneTicketBox);
            this.ticketPanel.Controls.Add(this.senderTicketBox);
            this.ticketPanel.Controls.Add(this.departTicketBox);
            this.ticketPanel.Controls.Add(this.arivalTicketBox);
            this.ticketPanel.Controls.Add(this.fromWhereTicketBox);
            this.ticketPanel.Controls.Add(this.whereTicketBox);
            this.ticketPanel.Location = new System.Drawing.Point(118, 57);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(1108, 575);
            this.ticketPanel.TabIndex = 3;
            this.ticketPanel.Visible = false;
            // 
            // warningExistLabel
            // 
            this.warningExistLabel.AutoSize = true;
            this.warningExistLabel.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warningExistLabel.ForeColor = System.Drawing.Color.Red;
            this.warningExistLabel.Location = new System.Drawing.Point(812, 352);
            this.warningExistLabel.Name = "warningExistLabel";
            this.warningExistLabel.Size = new System.Drawing.Size(240, 21);
            this.warningExistLabel.TabIndex = 24;
            this.warningExistLabel.Text = "Такий квиток вже існує!";
            this.warningExistLabel.Visible = false;
            // 
            // underliningPanel7
            // 
            this.underliningPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel7.Location = new System.Drawing.Point(779, 340);
            this.underliningPanel7.Name = "underliningPanel7";
            this.underliningPanel7.Size = new System.Drawing.Size(121, 6);
            this.underliningPanel7.TabIndex = 20;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.Location = new System.Drawing.Point(812, 511);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(260, 62);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "додати новий білет";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // underliningPanel8
            // 
            this.underliningPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel8.Location = new System.Drawing.Point(972, 340);
            this.underliningPanel8.Name = "underliningPanel8";
            this.underliningPanel8.Size = new System.Drawing.Size(121, 6);
            this.underliningPanel8.TabIndex = 19;
            // 
            // underliningPanel6
            // 
            this.underliningPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel6.Location = new System.Drawing.Point(972, 238);
            this.underliningPanel6.Name = "underliningPanel6";
            this.underliningPanel6.Size = new System.Drawing.Size(121, 6);
            this.underliningPanel6.TabIndex = 19;
            // 
            // underliningPanel5
            // 
            this.underliningPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel5.Location = new System.Drawing.Point(779, 238);
            this.underliningPanel5.Name = "underliningPanel5";
            this.underliningPanel5.Size = new System.Drawing.Size(121, 6);
            this.underliningPanel5.TabIndex = 19;
            // 
            // underliningPanel4
            // 
            this.underliningPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel4.Location = new System.Drawing.Point(972, 152);
            this.underliningPanel4.Name = "underliningPanel4";
            this.underliningPanel4.Size = new System.Drawing.Size(121, 6);
            this.underliningPanel4.TabIndex = 19;
            // 
            // underliningPanel3
            // 
            this.underliningPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel3.Location = new System.Drawing.Point(779, 152);
            this.underliningPanel3.Name = "underliningPanel3";
            this.underliningPanel3.Size = new System.Drawing.Size(121, 6);
            this.underliningPanel3.TabIndex = 19;
            // 
            // underliningPanel2
            // 
            this.underliningPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel2.Location = new System.Drawing.Point(972, 74);
            this.underliningPanel2.Name = "underliningPanel2";
            this.underliningPanel2.Size = new System.Drawing.Size(121, 6);
            this.underliningPanel2.TabIndex = 19;
            // 
            // underliningPanel1
            // 
            this.underliningPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.underliningPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.underliningPanel1.Location = new System.Drawing.Point(779, 74);
            this.underliningPanel1.Name = "underliningPanel1";
            this.underliningPanel1.Size = new System.Drawing.Size(121, 6);
            this.underliningPanel1.TabIndex = 19;
            // 
            // airPlaneLabel
            // 
            this.airPlaneLabel.AutoSize = true;
            this.airPlaneLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airPlaneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.airPlaneLabel.Location = new System.Drawing.Point(779, 265);
            this.airPlaneLabel.Name = "airPlaneLabel";
            this.airPlaneLabel.Size = new System.Drawing.Size(89, 50);
            this.airPlaneLabel.TabIndex = 14;
            this.airPlaneLabel.Text = "Модель\r\nлітака:";
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.senderLabel.Location = new System.Drawing.Point(972, 261);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.senderLabel.Size = new System.Drawing.Size(133, 50);
            this.senderLabel.TabIndex = 15;
            this.senderLabel.Text = "Авіа-комп\r\nвідправник:";
            // 
            // deparLabel
            // 
            this.deparLabel.AutoSize = true;
            this.deparLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deparLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.deparLabel.Location = new System.Drawing.Point(779, 185);
            this.deparLabel.Name = "deparLabel";
            this.deparLabel.Size = new System.Drawing.Size(111, 25);
            this.deparLabel.TabIndex = 10;
            this.deparLabel.Text = "Відп-ння:";
            // 
            // arivalLabel
            // 
            this.arivalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arivalLabel.AutoSize = true;
            this.arivalLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arivalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.arivalLabel.Location = new System.Drawing.Point(972, 185);
            this.arivalLabel.Name = "arivalLabel";
            this.arivalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.arivalLabel.Size = new System.Drawing.Size(100, 25);
            this.arivalLabel.TabIndex = 11;
            this.arivalLabel.Text = "Прибутя:";
            // 
            // fromWhereLabel
            // 
            this.fromWhereLabel.AutoSize = true;
            this.fromWhereLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromWhereLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.fromWhereLabel.Location = new System.Drawing.Point(779, 98);
            this.fromWhereLabel.Name = "fromWhereLabel";
            this.fromWhereLabel.Size = new System.Drawing.Size(89, 25);
            this.fromWhereLabel.TabIndex = 6;
            this.fromWhereLabel.Text = "Звідки:";
            // 
            // whereLabel
            // 
            this.whereLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.whereLabel.AutoSize = true;
            this.whereLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whereLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.whereLabel.Location = new System.Drawing.Point(972, 98);
            this.whereLabel.Name = "whereLabel";
            this.whereLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.whereLabel.Size = new System.Drawing.Size(67, 25);
            this.whereLabel.TabIndex = 7;
            this.whereLabel.Text = "Куди:";
            // 
            // FlightLabel
            // 
            this.FlightLabel.AutoSize = true;
            this.FlightLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.FlightLabel.Location = new System.Drawing.Point(779, 22);
            this.FlightLabel.Name = "FlightLabel";
            this.FlightLabel.Size = new System.Drawing.Size(100, 25);
            this.FlightLabel.TabIndex = 6;
            this.FlightLabel.Text = "№ Рейсу:";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.priceLabel.Location = new System.Drawing.Point(972, 22);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceLabel.Size = new System.Drawing.Size(67, 25);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Ціна:";
            // 
            // priceTicketBox
            // 
            this.priceTicketBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTicketBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTicketBox.Location = new System.Drawing.Point(972, 48);
            this.priceTicketBox.Name = "priceTicketBox";
            this.priceTicketBox.Size = new System.Drawing.Size(121, 26);
            this.priceTicketBox.TabIndex = 4;
            // 
            // numberTicketBox
            // 
            this.numberTicketBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numberTicketBox.BackColor = System.Drawing.SystemColors.Window;
            this.numberTicketBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberTicketBox.Location = new System.Drawing.Point(779, 48);
            this.numberTicketBox.Name = "numberTicketBox";
            this.numberTicketBox.Size = new System.Drawing.Size(121, 26);
            this.numberTicketBox.TabIndex = 3;
            // 
            // airplaneTicketBox
            // 
            this.airplaneTicketBox.DropDownHeight = 100;
            this.airplaneTicketBox.DropDownWidth = 120;
            this.airplaneTicketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.airplaneTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airplaneTicketBox.FormattingEnabled = true;
            this.airplaneTicketBox.IntegralHeight = false;
            this.airplaneTicketBox.Location = new System.Drawing.Point(779, 314);
            this.airplaneTicketBox.Name = "airplaneTicketBox";
            this.airplaneTicketBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.airplaneTicketBox.Size = new System.Drawing.Size(121, 33);
            this.airplaneTicketBox.TabIndex = 22;
            // 
            // senderTicketBox
            // 
            this.senderTicketBox.DropDownHeight = 100;
            this.senderTicketBox.DropDownWidth = 120;
            this.senderTicketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.senderTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senderTicketBox.FormattingEnabled = true;
            this.senderTicketBox.IntegralHeight = false;
            this.senderTicketBox.Location = new System.Drawing.Point(972, 313);
            this.senderTicketBox.Name = "senderTicketBox";
            this.senderTicketBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.senderTicketBox.Size = new System.Drawing.Size(121, 33);
            this.senderTicketBox.TabIndex = 23;
            // 
            // departTicketBox
            // 
            this.departTicketBox.DropDownHeight = 100;
            this.departTicketBox.DropDownWidth = 120;
            this.departTicketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departTicketBox.FormattingEnabled = true;
            this.departTicketBox.IntegralHeight = false;
            this.departTicketBox.Location = new System.Drawing.Point(779, 211);
            this.departTicketBox.Name = "departTicketBox";
            this.departTicketBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.departTicketBox.Size = new System.Drawing.Size(121, 33);
            this.departTicketBox.TabIndex = 25;
            // 
            // arivalTicketBox
            // 
            this.arivalTicketBox.DropDownHeight = 100;
            this.arivalTicketBox.DropDownWidth = 120;
            this.arivalTicketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arivalTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arivalTicketBox.FormattingEnabled = true;
            this.arivalTicketBox.IntegralHeight = false;
            this.arivalTicketBox.Location = new System.Drawing.Point(972, 211);
            this.arivalTicketBox.Name = "arivalTicketBox";
            this.arivalTicketBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.arivalTicketBox.Size = new System.Drawing.Size(121, 33);
            this.arivalTicketBox.TabIndex = 28;
            // 
            // fromWhereTicketBox
            // 
            this.fromWhereTicketBox.DropDownHeight = 100;
            this.fromWhereTicketBox.DropDownWidth = 120;
            this.fromWhereTicketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromWhereTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromWhereTicketBox.FormattingEnabled = true;
            this.fromWhereTicketBox.IntegralHeight = false;
            this.fromWhereTicketBox.Location = new System.Drawing.Point(779, 125);
            this.fromWhereTicketBox.Name = "fromWhereTicketBox";
            this.fromWhereTicketBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fromWhereTicketBox.Size = new System.Drawing.Size(121, 33);
            this.fromWhereTicketBox.TabIndex = 27;
            // 
            // whereTicketBox
            // 
            this.whereTicketBox.DropDownHeight = 100;
            this.whereTicketBox.DropDownWidth = 120;
            this.whereTicketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whereTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whereTicketBox.FormattingEnabled = true;
            this.whereTicketBox.IntegralHeight = false;
            this.whereTicketBox.Location = new System.Drawing.Point(972, 125);
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
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1238, 643);
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
            this.panel1.ResumeLayout(false);
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
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
        private TextBox numberTicketBox;
        private TextBox priceTicketBox;
        private Label FlightLabel;
        private Label priceLabel;
        private Label ticketDataLoad;
        private Label fromWhereLabel;
        private Label whereLabel;
        private Label deparLabel;
        private Label arivalLabel;
        private Label airPlaneLabel;
        private Label senderLabel;
        private Panel underliningPanel8;
        private Panel underliningPanel6;
        private Panel underliningPanel5;
        private Panel underliningPanel4;
        private Panel underliningPanel3;
        private Panel underliningPanel2;
        private Panel underliningPanel1;
        private Button AddButton;
        private MenuStrip menuStrip1;
        private ComboBox airplaneTicketBox;
        private Panel panel2;
        private Panel underliningPanel7;
        private ComboBox senderTicketBox;
        private Label warningExistLabel;
        private Button AirlineButton;
        private ComboBox departTicketBox;
        private ComboBox arivalTicketBox;
        private ComboBox fromWhereTicketBox;
        private ComboBox whereTicketBox;
        private Button AirplaneButton;

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


