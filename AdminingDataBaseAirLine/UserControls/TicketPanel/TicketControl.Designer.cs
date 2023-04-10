﻿namespace AdminingDataBaseAirLine.UserControls
{
    partial class TicketControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketControl));
            this.label2 = new System.Windows.Forms.Label();
            this.FlightLabel = new System.Windows.Forms.Label();
            this.flightField = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.Label();
            this.deparField = new System.Windows.Forms.Label();
            this.deparLabel = new System.Windows.Forms.Label();
            this.arrivalField = new System.Windows.Forms.Label();
            this.arrivalLabel = new System.Windows.Forms.Label();
            this.whereField = new System.Windows.Forms.Label();
            this.whereLabel = new System.Windows.Forms.Label();
            this.fromWField = new System.Windows.Forms.Label();
            this.fromWLabele = new System.Windows.Forms.Label();
            this.modelAirPlaneField = new System.Windows.Forms.Label();
            this.modelAirPlaneLabel = new System.Windows.Forms.Label();
            this.senderField = new System.Windows.Forms.Label();
            this.senderLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BarCodeBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BarCodeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Airline Ticket";
            // 
            // FlightLabel
            // 
            this.FlightLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FlightLabel.AutoSize = true;
            this.FlightLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.FlightLabel.Location = new System.Drawing.Point(3, 22);
            this.FlightLabel.Name = "FlightLabel";
            this.FlightLabel.Size = new System.Drawing.Size(100, 25);
            this.FlightLabel.TabIndex = 4;
            this.FlightLabel.Text = "№ Рейсу:";
            // 
            // flightField
            // 
            this.flightField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flightField.AutoSize = true;
            this.flightField.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flightField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.flightField.Location = new System.Drawing.Point(3, 46);
            this.flightField.Name = "flightField";
            this.flightField.Size = new System.Drawing.Size(45, 25);
            this.flightField.TabIndex = 4;
            this.flightField.Text = "___";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.priceLabel.Location = new System.Drawing.Point(386, 22);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceLabel.Size = new System.Drawing.Size(67, 25);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Ціна:";
            // 
            // priceField
            // 
            this.priceField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.priceField.AutoSize = true;
            this.priceField.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.priceField.Location = new System.Drawing.Point(386, 46);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(45, 25);
            this.priceField.TabIndex = 6;
            this.priceField.Text = "___";
            // 
            // deparField
            // 
            this.deparField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deparField.AutoSize = true;
            this.deparField.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deparField.ForeColor = System.Drawing.Color.Black;
            this.deparField.Location = new System.Drawing.Point(6, 159);
            this.deparField.Name = "deparField";
            this.deparField.Size = new System.Drawing.Size(45, 25);
            this.deparField.TabIndex = 7;
            this.deparField.Text = "___";
            // 
            // deparLabel
            // 
            this.deparLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deparLabel.AutoSize = true;
            this.deparLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deparLabel.ForeColor = System.Drawing.Color.Black;
            this.deparLabel.Location = new System.Drawing.Point(6, 136);
            this.deparLabel.Name = "deparLabel";
            this.deparLabel.Size = new System.Drawing.Size(155, 25);
            this.deparLabel.TabIndex = 8;
            this.deparLabel.Text = "Дата вильоту:";
            // 
            // arrivalField
            // 
            this.arrivalField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.arrivalField.AutoSize = true;
            this.arrivalField.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalField.ForeColor = System.Drawing.Color.Black;
            this.arrivalField.Location = new System.Drawing.Point(386, 159);
            this.arrivalField.Name = "arrivalField";
            this.arrivalField.Size = new System.Drawing.Size(45, 25);
            this.arrivalField.TabIndex = 9;
            this.arrivalField.Text = "___";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalLabel.ForeColor = System.Drawing.Color.Black;
            this.arrivalLabel.Location = new System.Drawing.Point(386, 136);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.arrivalLabel.Size = new System.Drawing.Size(166, 25);
            this.arrivalLabel.TabIndex = 10;
            this.arrivalLabel.Text = "Дата прибуття:";
            // 
            // whereField
            // 
            this.whereField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.whereField.AutoSize = true;
            this.whereField.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whereField.ForeColor = System.Drawing.Color.Black;
            this.whereField.Location = new System.Drawing.Point(386, 106);
            this.whereField.Name = "whereField";
            this.whereField.Size = new System.Drawing.Size(45, 25);
            this.whereField.TabIndex = 13;
            this.whereField.Text = "___";
            // 
            // whereLabel
            // 
            this.whereLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.whereLabel.AutoSize = true;
            this.whereLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whereLabel.ForeColor = System.Drawing.Color.Black;
            this.whereLabel.Location = new System.Drawing.Point(386, 82);
            this.whereLabel.Name = "whereLabel";
            this.whereLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.whereLabel.Size = new System.Drawing.Size(67, 25);
            this.whereLabel.TabIndex = 14;
            this.whereLabel.Text = "Куди:";
            // 
            // fromWField
            // 
            this.fromWField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fromWField.AutoSize = true;
            this.fromWField.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromWField.ForeColor = System.Drawing.Color.Black;
            this.fromWField.Location = new System.Drawing.Point(6, 106);
            this.fromWField.Name = "fromWField";
            this.fromWField.Size = new System.Drawing.Size(45, 25);
            this.fromWField.TabIndex = 11;
            this.fromWField.Text = "___";
            // 
            // fromWLabele
            // 
            this.fromWLabele.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fromWLabele.AutoSize = true;
            this.fromWLabele.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromWLabele.ForeColor = System.Drawing.Color.Black;
            this.fromWLabele.Location = new System.Drawing.Point(6, 82);
            this.fromWLabele.Name = "fromWLabele";
            this.fromWLabele.Size = new System.Drawing.Size(89, 25);
            this.fromWLabele.TabIndex = 12;
            this.fromWLabele.Text = "Звідки:";
            // 
            // modelAirPlaneField
            // 
            this.modelAirPlaneField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modelAirPlaneField.AutoSize = true;
            this.modelAirPlaneField.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelAirPlaneField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.modelAirPlaneField.Location = new System.Drawing.Point(6, 217);
            this.modelAirPlaneField.Name = "modelAirPlaneField";
            this.modelAirPlaneField.Size = new System.Drawing.Size(45, 25);
            this.modelAirPlaneField.TabIndex = 15;
            this.modelAirPlaneField.Text = "___";
            // 
            // modelAirPlaneLabel
            // 
            this.modelAirPlaneLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modelAirPlaneLabel.AutoSize = true;
            this.modelAirPlaneLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelAirPlaneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.modelAirPlaneLabel.Location = new System.Drawing.Point(6, 194);
            this.modelAirPlaneLabel.Name = "modelAirPlaneLabel";
            this.modelAirPlaneLabel.Size = new System.Drawing.Size(166, 25);
            this.modelAirPlaneLabel.TabIndex = 16;
            this.modelAirPlaneLabel.Text = "Модель літака:";
            // 
            // senderField
            // 
            this.senderField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.senderField.AutoSize = true;
            this.senderField.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senderField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.senderField.Location = new System.Drawing.Point(386, 217);
            this.senderField.Name = "senderField";
            this.senderField.Size = new System.Drawing.Size(45, 25);
            this.senderField.TabIndex = 17;
            this.senderField.Text = "___";
            // 
            // senderLabel
            // 
            this.senderLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.senderLabel.AutoSize = true;
            this.senderLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.senderLabel.Location = new System.Drawing.Point(386, 194);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.senderLabel.Size = new System.Drawing.Size(133, 25);
            this.senderLabel.TabIndex = 18;
            this.senderLabel.Text = "Відправник:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(742, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 257);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 257);
            this.panel4.TabIndex = 20;
            // 
            // BarCodeBox
            // 
            this.BarCodeBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BarCodeBox.Image = ((System.Drawing.Image)(resources.GetObject("BarCodeBox.Image")));
            this.BarCodeBox.Location = new System.Drawing.Point(609, 1);
            this.BarCodeBox.Name = "BarCodeBox";
            this.BarCodeBox.Size = new System.Drawing.Size(127, 256);
            this.BarCodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BarCodeBox.TabIndex = 21;
            this.BarCodeBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 10);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(237, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 103);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 10);
            this.panel1.TabIndex = 23;
            // 
            // TicketControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarCodeBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.senderField);
            this.Controls.Add(this.senderLabel);
            this.Controls.Add(this.modelAirPlaneField);
            this.Controls.Add(this.modelAirPlaneLabel);
            this.Controls.Add(this.whereField);
            this.Controls.Add(this.whereLabel);
            this.Controls.Add(this.fromWField);
            this.Controls.Add(this.fromWLabele);
            this.Controls.Add(this.arrivalField);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.deparField);
            this.Controls.Add(this.deparLabel);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.flightField);
            this.Controls.Add(this.FlightLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "TicketControl";
            this.Size = new System.Drawing.Size(747, 267);
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ticket_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.BarCodeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Fields
        private Label label2;
        private Label FlightLabel;
        private Label flightField;
        private Label priceLabel;
        private Label priceField;
        private Label deparField;
        private Label deparLabel;
        private Label arrivalField;
        private Label arrivalLabel;
        private Label whereField;
        private Label whereLabel;
        private Label fromWField;
        private Label fromWLabele;
        private Label modelAirPlaneField;
        private Label modelAirPlaneLabel;
        private Label senderField;
        private Label senderLabel;
        private Panel panel3;
        private Panel panel4;
        private PictureBox BarCodeBox;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        #endregion

        #region Properties

        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label FlightLabel1 { get => FlightLabel; set => FlightLabel = value; }
        public Label FlightField { get => flightField; set => flightField = value; }
        public Label PriceLabel { get => priceLabel; set => priceLabel = value; }
        public Label PriceField { get => priceField; set => priceField = value; }
        public Label DeparField { get => deparField; set => deparField = value; }
        public Label DeparLabel { get => deparLabel; set => deparLabel = value; }
        public Label ArrivalField { get => arrivalField; set => arrivalField = value; }
        public Label ArrivalLabel { get => arrivalLabel; set => arrivalLabel = value; }
        public Label WhereField { get => whereField; set => whereField = value; }
        public Label WhereLabel { get => whereLabel; set => whereLabel = value; }
        public Label FromWField { get => fromWField; set => fromWField = value; }
        public Label FromWLabele { get => fromWLabele; set => fromWLabele = value; }
        public Label ModelAirPlaneField { get => modelAirPlaneField; set => modelAirPlaneField = value; }
        public Label ModelAirPlaneLabel { get => modelAirPlaneLabel; set => modelAirPlaneLabel = value; }
        public Label SenderField { get => senderField; set => senderField = value; }
        public Label SenderLabel { get => senderLabel; set => senderLabel = value; }
        public Panel Panel3 { get => panel3; set => panel3 = value; }
        public Panel Panel4 { get => panel4; set => panel4 = value; }
        public PictureBox BarCodeBox1 { get => BarCodeBox; set => BarCodeBox = value; }
        public Panel Panel2 { get => panel2; set => panel2 = value; }
        public PictureBox PictureBox2 { get => pictureBox2; set => pictureBox2 = value; }
        #endregion
    }
}