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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TicketButton = new System.Windows.Forms.Button();
            this.FlightButton = new System.Windows.Forms.Button();
            this.PassengerButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(216, 633);
            this.BackPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(212, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 55);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TicketButton
            // 
            this.TicketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.TicketButton.FlatAppearance.BorderSize = 0;
            this.TicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketButton.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TicketButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TicketButton.Location = new System.Drawing.Point(3, 192);
            this.TicketButton.Name = "TicketButton";
            this.TicketButton.Size = new System.Drawing.Size(213, 79);
            this.TicketButton.TabIndex = 1;
            this.TicketButton.Text = "Білети";
            this.TicketButton.UseVisualStyleBackColor = false;
            this.TicketButton.Click += new System.EventHandler(this.TicketButton_Click);
            // 
            // FlightButton
            // 
            this.FlightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.FlightButton.FlatAppearance.BorderSize = 0;
            this.FlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightButton.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FlightButton.Location = new System.Drawing.Point(0, 277);
            this.FlightButton.Name = "FlightButton";
            this.FlightButton.Size = new System.Drawing.Size(216, 79);
            this.FlightButton.TabIndex = 2;
            this.FlightButton.Text = "Рейси";
            this.FlightButton.UseVisualStyleBackColor = false;
            this.FlightButton.Click += new System.EventHandler(this.FlightButton_Click);
            // 
            // PassengerButton
            // 
            this.PassengerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.PassengerButton.FlatAppearance.BorderSize = 0;
            this.PassengerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerButton.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassengerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PassengerButton.Location = new System.Drawing.Point(1, 362);
            this.PassengerButton.Name = "PassengerButton";
            this.PassengerButton.Size = new System.Drawing.Size(215, 79);
            this.PassengerButton.TabIndex = 3;
            this.PassengerButton.Text = "Пасажири";
            this.PassengerButton.UseVisualStyleBackColor = false;
            this.PassengerButton.Click += new System.EventHandler(this.PassengerButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrdersButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OrdersButton.Location = new System.Drawing.Point(0, 447);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(216, 79);
            this.OrdersButton.TabIndex = 4;
            this.OrdersButton.Text = "Замовлення";
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.AccountButton.FlatAppearance.BorderSize = 0;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AccountButton.Location = new System.Drawing.Point(0, 554);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(215, 79);
            this.AccountButton.TabIndex = 5;
            this.AccountButton.Text = "Особистий Кабінет";
            this.AccountButton.UseVisualStyleBackColor = false;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel BackPanel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button TicketButton;
        private Button FlightButton;
        private Button AccountButton;
        private Button OrdersButton;
        private Button PassengerButton;
    }
}