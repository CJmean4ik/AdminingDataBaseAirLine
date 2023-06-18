namespace AdminingDataBaseAirLine.UserControls.RoutsPanel
{
    partial class RoutsControlPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutsControlPanel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromWhereColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhereColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.fromWhereBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.routeId = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.arivalBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.departimeBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelOperationBtn = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.fromWhereColumn,
            this.WhereColumn,
            this.departmentColumn,
            this.arrivalColumn});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(648, 532);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idColumn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.idColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idColumn.FillWeight = 50F;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // fromWhereColumn
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.fromWhereColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fromWhereColumn.HeaderText = "Звідки";
            this.fromWhereColumn.Name = "fromWhereColumn";
            this.fromWhereColumn.ReadOnly = true;
            this.fromWhereColumn.Width = 120;
            // 
            // WhereColumn
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.WhereColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.WhereColumn.HeaderText = "Куди";
            this.WhereColumn.Name = "WhereColumn";
            this.WhereColumn.ReadOnly = true;
            this.WhereColumn.Width = 120;
            // 
            // departmentColumn
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.departmentColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.departmentColumn.FillWeight = 170F;
            this.departmentColumn.HeaderText = "Час вильоту";
            this.departmentColumn.Name = "departmentColumn";
            this.departmentColumn.ReadOnly = true;
            this.departmentColumn.Width = 180;
            // 
            // arrivalColumn
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.arrivalColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.arrivalColumn.FillWeight = 170F;
            this.arrivalColumn.HeaderText = "Час прибуття";
            this.arrivalColumn.Name = "arrivalColumn";
            this.arrivalColumn.ReadOnly = true;
            this.arrivalColumn.Width = 180;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 540);
            this.panel1.TabIndex = 2;
            // 
            // fromBox
            // 
            this.fromBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.fromBox.Location = new System.Drawing.Point(664, 147);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(185, 27);
            this.fromBox.TabIndex = 123;
            this.fromBox.Tag = "3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(664, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 5);
            this.panel2.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(664, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 122;
            this.label3.Text = "Звідки";
            // 
            // fromWhereBox
            // 
            this.fromWhereBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromWhereBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.fromWhereBox.Location = new System.Drawing.Point(664, 91);
            this.fromWhereBox.Name = "fromWhereBox";
            this.fromWhereBox.Size = new System.Drawing.Size(184, 27);
            this.fromWhereBox.TabIndex = 120;
            this.fromWhereBox.Tag = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel4.Location = new System.Drawing.Point(664, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 5);
            this.panel4.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label5.Location = new System.Drawing.Point(664, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 119;
            this.label5.Text = "Куди ";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.IdLabel.Location = new System.Drawing.Point(664, 20);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(24, 17);
            this.IdLabel.TabIndex = 127;
            this.IdLabel.Text = "ID";
            // 
            // routeId
            // 
            this.routeId.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.routeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.routeId.Location = new System.Drawing.Point(664, 40);
            this.routeId.Name = "routeId";
            this.routeId.Size = new System.Drawing.Size(185, 27);
            this.routeId.TabIndex = 125;
            this.routeId.Tag = "0";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel8.Location = new System.Drawing.Point(664, 67);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(185, 5);
            this.panel8.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(664, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 132;
            this.label2.Text = "Час вильоту";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel3.Location = new System.Drawing.Point(664, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 5);
            this.panel3.TabIndex = 131;
            // 
            // arivalBox
            // 
            this.arivalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arivalBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arivalBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.arivalBox.Location = new System.Drawing.Point(663, 262);
            this.arivalBox.Name = "arivalBox";
            this.arivalBox.Size = new System.Drawing.Size(185, 27);
            this.arivalBox.TabIndex = 128;
            this.arivalBox.Tag = "4";
            this.arivalBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.arivalBox_MouseDoubleClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel5.Location = new System.Drawing.Point(663, 289);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 5);
            this.panel5.TabIndex = 129;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(665, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 130;
            this.label4.Text = "Час прибуття";
            // 
            // departimeBox
            // 
            this.departimeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departimeBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departimeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.departimeBox.Location = new System.Drawing.Point(664, 203);
            this.departimeBox.Name = "departimeBox";
            this.departimeBox.Size = new System.Drawing.Size(185, 27);
            this.departimeBox.TabIndex = 133;
            this.departimeBox.Tag = "4";
            this.departimeBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.departimeBox_MouseDoubleClick);
            // 
            // updateButton
            // 
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.update;
            this.updateButton.Location = new System.Drawing.Point(665, 451);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(295, 40);
            this.updateButton.TabIndex = 136;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(665, 405);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(295, 40);
            this.addButton.TabIndex = 134;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.remove;
            this.removeButton.Location = new System.Drawing.Point(665, 497);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(295, 40);
            this.removeButton.TabIndex = 135;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelOperationBtn
            // 
            this.cancelOperationBtn.Enabled = false;
            this.cancelOperationBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cancelOperationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelOperationBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelOperationBtn.Image")));
            this.cancelOperationBtn.Location = new System.Drawing.Point(665, 367);
            this.cancelOperationBtn.Name = "cancelOperationBtn";
            this.cancelOperationBtn.Size = new System.Drawing.Size(72, 32);
            this.cancelOperationBtn.TabIndex = 138;
            this.cancelOperationBtn.UseVisualStyleBackColor = true;
            this.cancelOperationBtn.Click += new System.EventHandler(this.cancelOperationBtn_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.Window;
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.Location = new System.Drawing.Point(743, 367);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(72, 32);
            this.clearButton.TabIndex = 137;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // RoutsControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.cancelOperationBtn);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.arivalBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.departimeBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.routeId);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromWhereBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "RoutsControlPanel";
            this.Size = new System.Drawing.Size(972, 546);
            this.Load += new System.EventHandler(this.RoutsControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn fromWhereColumn;
        private DataGridViewTextBoxColumn WhereColumn;
        private DataGridViewTextBoxColumn departmentColumn;
        private DataGridViewTextBoxColumn arrivalColumn;
        private Panel panel1;
        private TextBox fromBox;
        private Panel panel2;
        private Label label3;
        private TextBox fromWhereBox;
        private Panel panel4;
        private Label label5;
        private Label IdLabel;
        private TextBox routeId;
        private Panel panel8;
        private Label label2;
        private Panel panel3;
        private TextBox arivalBox;
        private Panel panel5;
        private Label label4;
        private TextBox departimeBox;
        private Button updateButton;
        private Button addButton;
        private Button removeButton;
        private Button cancelOperationBtn;
        private Button clearButton;

        public TextBox RouteId { get => routeId; set => routeId = value; }
        public TextBox FromWhereBox { get => fromWhereBox; set => fromWhereBox = value; }
        public TextBox FromBox { get => fromBox; set => fromBox = value; }
        public TextBox ArivalBox { get => arivalBox; set => arivalBox = value; }
        public TextBox DepartimeBox { get => departimeBox; set => departimeBox = value; }
        public Button UpdateButton { get => updateButton; set => updateButton = value; }
        public Button AddButton { get => addButton; set => addButton = value; }
        public Button RemoveButton { get => removeButton; set => removeButton = value; }
    }
}
