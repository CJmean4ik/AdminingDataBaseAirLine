﻿using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
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
            this.arivalTicketBox = new System.Windows.Forms.TextBox();
            this.departTicketBox = new System.Windows.Forms.TextBox();
            this.deparLabel = new System.Windows.Forms.Label();
            this.arivalLabel = new System.Windows.Forms.Label();
            this.whereTicketBox = new System.Windows.Forms.TextBox();
            this.fromWhereTicketBox = new System.Windows.Forms.TextBox();
            this.fromWhereLabel = new System.Windows.Forms.Label();
            this.whereLabel = new System.Windows.Forms.Label();
            this.FlightLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTicketBox = new System.Windows.Forms.TextBox();
            this.numberTicketBox = new System.Windows.Forms.TextBox();
            this.airplaneTicketBox = new System.Windows.Forms.ComboBox();
            this.senderTicketBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.BackPanel.Size = new System.Drawing.Size(101, 643);
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
            this.AccountButton.Location = new System.Drawing.Point(0, 569);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccountButton.Size = new System.Drawing.Size(101, 74);
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
            this.OrdersButton.Location = new System.Drawing.Point(0, 437);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(101, 98);
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
            this.PassengerButton.Location = new System.Drawing.Point(0, 339);
            this.PassengerButton.Name = "PassengerButton";
            this.PassengerButton.Size = new System.Drawing.Size(101, 92);
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
            this.FlightButton.Location = new System.Drawing.Point(0, 245);
            this.FlightButton.Name = "FlightButton";
            this.FlightButton.Size = new System.Drawing.Size(101, 89);
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
            this.TicketButton.Location = new System.Drawing.Point(0, 148);
            this.TicketButton.Name = "TicketButton";
            this.TicketButton.Size = new System.Drawing.Size(101, 91);
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
            this.pictureBox1.Size = new System.Drawing.Size(91, 82);
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
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 37);
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
            this.collapseButton.Location = new System.Drawing.Point(1065, 0);
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
            this.closeButton.Location = new System.Drawing.Point(1099, 0);
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
            this.ThemeButton.Location = new System.Drawing.Point(952, 0);
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
            this.flowTicketPanel.Visible = false;
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
            this.ticketPanel.Controls.Add(this.arivalTicketBox);
            this.ticketPanel.Controls.Add(this.departTicketBox);
            this.ticketPanel.Controls.Add(this.deparLabel);
            this.ticketPanel.Controls.Add(this.arivalLabel);
            this.ticketPanel.Controls.Add(this.whereTicketBox);
            this.ticketPanel.Controls.Add(this.fromWhereTicketBox);
            this.ticketPanel.Controls.Add(this.fromWhereLabel);
            this.ticketPanel.Controls.Add(this.whereLabel);
            this.ticketPanel.Controls.Add(this.FlightLabel);
            this.ticketPanel.Controls.Add(this.priceLabel);
            this.ticketPanel.Controls.Add(this.priceTicketBox);
            this.ticketPanel.Controls.Add(this.numberTicketBox);
            this.ticketPanel.Controls.Add(this.flowTicketPanel);
            this.ticketPanel.Controls.Add(this.airplaneTicketBox);
            this.ticketPanel.Controls.Add(this.senderTicketBox);
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
            // arivalTicketBox
            // 
            this.arivalTicketBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arivalTicketBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arivalTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arivalTicketBox.Location = new System.Drawing.Point(972, 213);
            this.arivalTicketBox.Name = "arivalTicketBox";
            this.arivalTicketBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.arivalTicketBox.Size = new System.Drawing.Size(121, 26);
            this.arivalTicketBox.TabIndex = 13;
            this.arivalTicketBox.DoubleClick += new System.EventHandler(this.arivalTicketBox_DoubleClick);
            // 
            // departTicketBox
            // 
            this.departTicketBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departTicketBox.Location = new System.Drawing.Point(779, 213);
            this.departTicketBox.Name = "departTicketBox";
            this.departTicketBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.departTicketBox.Size = new System.Drawing.Size(121, 26);
            this.departTicketBox.TabIndex = 12;
            this.departTicketBox.DoubleClick += new System.EventHandler(this.departTicketBox_DoubleClick);
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
            // whereTicketBox
            // 
            this.whereTicketBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.whereTicketBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.whereTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whereTicketBox.Location = new System.Drawing.Point(972, 126);
            this.whereTicketBox.Name = "whereTicketBox";
            this.whereTicketBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.whereTicketBox.Size = new System.Drawing.Size(121, 26);
            this.whereTicketBox.TabIndex = 9;
            // 
            // fromWhereTicketBox
            // 
            this.fromWhereTicketBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromWhereTicketBox.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromWhereTicketBox.Location = new System.Drawing.Point(779, 126);
            this.fromWhereTicketBox.Name = "fromWhereTicketBox";
            this.fromWhereTicketBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.fromWhereTicketBox.Size = new System.Drawing.Size(121, 26);
            this.fromWhereTicketBox.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private TextBox whereTicketBox;
        private TextBox fromWhereTicketBox;
        private Label FlightLabel;
        private Label priceLabel;
        private Label ticketDataLoad;
        private Label fromWhereLabel;
        private Label whereLabel;
        private TextBox arivalTicketBox;
        private TextBox departTicketBox;
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


