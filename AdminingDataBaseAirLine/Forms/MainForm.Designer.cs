namespace AdminingDataBaseAirLine
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label4 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.panelPass = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelName2 = new System.Windows.Forms.Panel();
            this.panelPass2 = new System.Windows.Forms.Panel();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.closeButton = new System.Windows.Forms.Button();
            this.ShowPasswordBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordMistake = new System.Windows.Forms.Label();
            this.nameMistake = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(38, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Увійдіть у систему";
            // 
            // UserNameBox
            // 
            this.UserNameBox.BackColor = System.Drawing.SystemColors.Control;
            this.UserNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameBox.Font = new System.Drawing.Font("JetBrains Mono Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.UserNameBox.Location = new System.Drawing.Point(49, 223);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(278, 28);
            this.UserNameBox.TabIndex = 1;
            this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panelName.Location = new System.Drawing.Point(39, 223);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(10, 28);
            this.panelName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(49, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ім\'я користувача";
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("JetBrains Mono Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.PasswordBox.Location = new System.Drawing.Point(51, 329);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(275, 28);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // panelPass
            // 
            this.panelPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panelPass.Location = new System.Drawing.Point(39, 329);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(10, 32);
            this.panelPass.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(50, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ваш пароль";
            // 
            // panelName2
            // 
            this.panelName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panelName2.Location = new System.Drawing.Point(39, 249);
            this.panelName2.Name = "panelName2";
            this.panelName2.Size = new System.Drawing.Size(292, 5);
            this.panelName2.TabIndex = 5;
            // 
            // panelPass2
            // 
            this.panelPass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panelPass2.Location = new System.Drawing.Point(39, 357);
            this.panelPass2.Name = "panelPass2";
            this.panelPass2.Size = new System.Drawing.Size(292, 5);
            this.panelPass2.TabIndex = 6;
            // 
            // LogInBtn
            // 
            this.LogInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.LogInBtn.FlatAppearance.BorderSize = 0;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("JetBrains Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LogInBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogInBtn.Image")));
            this.LogInBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogInBtn.Location = new System.Drawing.Point(38, 442);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(292, 67);
            this.LogInBtn.TabIndex = 7;
            this.LogInBtn.Text = "УВІЙТИ";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(210, 424);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Забули пароль?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(324, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(43, 35);
            this.closeButton.TabIndex = 9;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ShowPasswordBtn
            // 
            this.ShowPasswordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPasswordBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowPasswordBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ShowPasswordBtn.CausesValidation = false;
            this.ShowPasswordBtn.FlatAppearance.BorderSize = 0;
            this.ShowPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ShowPasswordBtn.Image = global::AdminingDataBaseAirLine.Properties.Resources.eye_crossed;
            this.ShowPasswordBtn.Location = new System.Drawing.Point(295, 321);
            this.ShowPasswordBtn.Name = "ShowPasswordBtn";
            this.ShowPasswordBtn.Size = new System.Drawing.Size(35, 36);
            this.ShowPasswordBtn.TabIndex = 10;
            this.ShowPasswordBtn.TabStop = false;
            this.ShowPasswordBtn.UseVisualStyleBackColor = false;
            this.ShowPasswordBtn.Click += new System.EventHandler(this.ShowPasswordBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panelName);
            this.panel1.Controls.Add(this.panelName2);
            this.panel1.Controls.Add(this.passwordMistake);
            this.panel1.Controls.Add(this.nameMistake);
            this.panel1.Controls.Add(this.ShowPasswordBtn);
            this.panel1.Controls.Add(this.UserNameBox);
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.panelPass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.LogInBtn);
            this.panel1.Controls.Add(this.panelPass2);
            this.panel1.Location = new System.Drawing.Point(466, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 519);
            this.panel1.TabIndex = 16;
            // 
            // passwordMistake
            // 
            this.passwordMistake.AutoSize = true;
            this.passwordMistake.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordMistake.ForeColor = System.Drawing.Color.Silver;
            this.passwordMistake.Location = new System.Drawing.Point(49, 365);
            this.passwordMistake.Name = "passwordMistake";
            this.passwordMistake.Size = new System.Drawing.Size(128, 17);
            this.passwordMistake.TabIndex = 12;
            this.passwordMistake.Text = "Невірний пароль";
            this.passwordMistake.Visible = false;
            // 
            // nameMistake
            // 
            this.nameMistake.AutoSize = true;
            this.nameMistake.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameMistake.ForeColor = System.Drawing.Color.Silver;
            this.nameMistake.Location = new System.Drawing.Point(49, 254);
            this.nameMistake.Name = "nameMistake";
            this.nameMistake.Size = new System.Drawing.Size(224, 34);
            this.nameMistake.TabIndex = 11;
            this.nameMistake.Text = "Невірне ім\'я або \r\nтакого користувача не існує";
            this.nameMistake.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(63, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ця система допомагає керувати \r\nкасирам базою данних через зручний інтерфейс";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(76, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Раді вас знову бачити";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(76, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 49);
            this.label1.TabIndex = 17;
            this.label1.Text = "З поверненям";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(162, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 127);
            this.label3.TabIndex = 18;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox UserNameBox;
        private Panel panelName;
        private TextBox PasswordBox;
        private Panel panelPass;
        private Panel panelName2;
        private Panel panelPass2;
        private Button LogInBtn;
        private Label nameMistake;
        private Label passwordMistake;
        private LinkLabel linkLabel1;
        private Button closeButton;
        private Button ShowPasswordBtn;
        private Panel panel1;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;

        public TextBox UserNameBox1 { get => UserNameBox; set => UserNameBox = value; }
        public Panel PanelName { get => panelName; set => panelName = value; }
        public TextBox PasswordBox1 { get => PasswordBox; set => PasswordBox = value; }
        public Panel PanelPass { get => panelPass; set => panelPass = value; }
        public Panel PanelName2 { get => panelName2; set => panelName2 = value; }
        public Panel PanelPass2 { get => panelPass2; set => panelPass2 = value; }
        public Button LogInBtn1 { get => LogInBtn; set => LogInBtn = value; }
        public Label NameMistake { get => nameMistake; set => nameMistake = value; }
        public Label PasswordMistake { get => passwordMistake; set => passwordMistake = value; }
    }
}