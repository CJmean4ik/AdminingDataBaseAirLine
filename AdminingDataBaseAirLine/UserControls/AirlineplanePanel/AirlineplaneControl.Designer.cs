namespace AdminingDataBaseAirLine.UserControls.AirlineplanePanel
{
    partial class AirlineplaneControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirlineplaneControl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromWhereColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhereColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InRaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airplaneSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.airplaneIdBox = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.IdLabel = new System.Windows.Forms.Label();
            this.airlinePlaneIdBox = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.airlineBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.airplaneModelBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.capacityAirplaneBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ownerAirlineBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.airplaneTypeBox = new System.Windows.Forms.ComboBox();
            this.inFlightBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelOperationBtn = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.senderColumn,
            this.fromWhereColumn,
            this.WhereColumn,
            this.departmentColumn,
            this.arrivalColumn,
            this.InRaceColumn,
            this.airplaneSender});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(5, 0);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1036, 501);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(1036, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 366);
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
            // senderColumn
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.senderColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.senderColumn.FillWeight = 150F;
            this.senderColumn.HeaderText = "Авіакомпанія";
            this.senderColumn.Name = "senderColumn";
            this.senderColumn.ReadOnly = true;
            this.senderColumn.Width = 170;
            // 
            // fromWhereColumn
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.fromWhereColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fromWhereColumn.HeaderText = "ID літака";
            this.fromWhereColumn.Name = "fromWhereColumn";
            this.fromWhereColumn.ReadOnly = true;
            // 
            // WhereColumn
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.WhereColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.WhereColumn.HeaderText = "Тип літака";
            this.WhereColumn.Name = "WhereColumn";
            this.WhereColumn.ReadOnly = true;
            this.WhereColumn.Width = 150;
            // 
            // departmentColumn
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.departmentColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.departmentColumn.FillWeight = 170F;
            this.departmentColumn.HeaderText = "Вмісткість";
            this.departmentColumn.Name = "departmentColumn";
            this.departmentColumn.ReadOnly = true;
            // 
            // arrivalColumn
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.arrivalColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.arrivalColumn.FillWeight = 170F;
            this.arrivalColumn.HeaderText = "Модель літака";
            this.arrivalColumn.Name = "arrivalColumn";
            this.arrivalColumn.ReadOnly = true;
            this.arrivalColumn.Width = 180;
            // 
            // InRaceColumn
            // 
            this.InRaceColumn.HeaderText = "В рейсі";
            this.InRaceColumn.Name = "InRaceColumn";
            this.InRaceColumn.ReadOnly = true;
            // 
            // airplaneSender
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.airplaneSender.DefaultCellStyle = dataGridViewCellStyle8;
            this.airplaneSender.FillWeight = 150F;
            this.airplaneSender.HeaderText = "Країна власник";
            this.airplaneSender.Name = "airplaneSender";
            this.airplaneSender.ReadOnly = true;
            this.airplaneSender.Width = 190;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1048, 504);
            this.panel1.MinimumSize = new System.Drawing.Size(1036, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 369);
            this.panel1.TabIndex = 2;
            // 
            // airplaneIdBox
            // 
            this.airplaneIdBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airplaneIdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.airplaneIdBox.Location = new System.Drawing.Point(7, 469);
            this.airplaneIdBox.Name = "airplaneIdBox";
            this.airplaneIdBox.Size = new System.Drawing.Size(88, 27);
            this.airplaneIdBox.TabIndex = 79;
            this.airplaneIdBox.Tag = "0";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel11.Location = new System.Drawing.Point(7, 496);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(88, 5);
            this.panel11.TabIndex = 80;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.IdLabel.Location = new System.Drawing.Point(6, 392);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(24, 17);
            this.IdLabel.TabIndex = 76;
            this.IdLabel.Text = "ID";
            // 
            // airlinePlaneIdBox
            // 
            this.airlinePlaneIdBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airlinePlaneIdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.airlinePlaneIdBox.Location = new System.Drawing.Point(6, 412);
            this.airlinePlaneIdBox.Name = "airlinePlaneIdBox";
            this.airlinePlaneIdBox.Size = new System.Drawing.Size(89, 27);
            this.airlinePlaneIdBox.TabIndex = 74;
            this.airlinePlaneIdBox.Tag = "0";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel8.Location = new System.Drawing.Point(6, 439);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(89, 5);
            this.panel8.TabIndex = 75;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel6.Location = new System.Drawing.Point(510, 436);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(185, 5);
            this.panel6.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label6.Location = new System.Drawing.Point(512, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Тип літака";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.nameLabel.Location = new System.Drawing.Point(510, 449);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 17);
            this.nameLabel.TabIndex = 73;
            this.nameLabel.Text = "Авіакомпанія";
            // 
            // airlineBox
            // 
            this.airlineBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airlineBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airlineBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.airlineBox.Location = new System.Drawing.Point(510, 469);
            this.airlineBox.Name = "airlineBox";
            this.airlineBox.Size = new System.Drawing.Size(185, 27);
            this.airlineBox.TabIndex = 81;
            this.airlineBox.Tag = "3";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel7.Location = new System.Drawing.Point(510, 496);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(185, 5);
            this.panel7.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(7, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "ID літака";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(311, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 95;
            this.label2.Text = "В рейсі?";
            // 
            // airplaneModelBox
            // 
            this.airplaneModelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airplaneModelBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airplaneModelBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.airplaneModelBox.Location = new System.Drawing.Point(113, 468);
            this.airplaneModelBox.Name = "airplaneModelBox";
            this.airplaneModelBox.Size = new System.Drawing.Size(185, 27);
            this.airplaneModelBox.TabIndex = 93;
            this.airplaneModelBox.Tag = "3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(113, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 5);
            this.panel2.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel3.Location = new System.Drawing.Point(311, 436);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 5);
            this.panel3.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(113, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 90;
            this.label3.Text = "Вмісткість";
            // 
            // capacityAirplaneBox
            // 
            this.capacityAirplaneBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.capacityAirplaneBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.capacityAirplaneBox.Location = new System.Drawing.Point(113, 412);
            this.capacityAirplaneBox.Name = "capacityAirplaneBox";
            this.capacityAirplaneBox.Size = new System.Drawing.Size(184, 27);
            this.capacityAirplaneBox.TabIndex = 88;
            this.capacityAirplaneBox.Tag = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel4.Location = new System.Drawing.Point(113, 439);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 5);
            this.panel4.TabIndex = 89;
            // 
            // ownerAirlineBox
            // 
            this.ownerAirlineBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ownerAirlineBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ownerAirlineBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.ownerAirlineBox.Location = new System.Drawing.Point(310, 469);
            this.ownerAirlineBox.Name = "ownerAirlineBox";
            this.ownerAirlineBox.Size = new System.Drawing.Size(185, 27);
            this.ownerAirlineBox.TabIndex = 84;
            this.ownerAirlineBox.Tag = "4";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.panel5.Location = new System.Drawing.Point(310, 496);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 5);
            this.panel5.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(312, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Країна власник";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.label5.Location = new System.Drawing.Point(113, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Модель літака";
            // 
            // airplaneTypeBox
            // 
            this.airplaneTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.airplaneTypeBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airplaneTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.airplaneTypeBox.FormattingEnabled = true;
            this.airplaneTypeBox.Items.AddRange(new object[] {
            "Wide-body jet airliner"});
            this.airplaneTypeBox.Location = new System.Drawing.Point(510, 409);
            this.airplaneTypeBox.Name = "airplaneTypeBox";
            this.airplaneTypeBox.Size = new System.Drawing.Size(185, 27);
            this.airplaneTypeBox.TabIndex = 96;
            this.airplaneTypeBox.Tag = "6";
            // 
            // inFlightBox
            // 
            this.inFlightBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inFlightBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inFlightBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.inFlightBox.FormattingEnabled = true;
            this.inFlightBox.Items.AddRange(new object[] {
            "Так",
            "Ні"});
            this.inFlightBox.Location = new System.Drawing.Point(311, 409);
            this.inFlightBox.Name = "inFlightBox";
            this.inFlightBox.Size = new System.Drawing.Size(184, 27);
            this.inFlightBox.TabIndex = 97;
            this.inFlightBox.Tag = "6";
            // 
            // updateButton
            // 
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.update;
            this.updateButton.Location = new System.Drawing.Point(920, 445);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(53, 56);
            this.updateButton.TabIndex = 100;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(864, 445);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(53, 56);
            this.addButton.TabIndex = 98;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Image = global::AdminingDataBaseAirLine.Properties.Resources.remove;
            this.removeButton.Location = new System.Drawing.Point(976, 445);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(53, 56);
            this.removeButton.TabIndex = 99;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelOperationBtn
            // 
            this.cancelOperationBtn.Enabled = false;
            this.cancelOperationBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cancelOperationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelOperationBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelOperationBtn.Image")));
            this.cancelOperationBtn.Location = new System.Drawing.Point(792, 469);
            this.cancelOperationBtn.Name = "cancelOperationBtn";
            this.cancelOperationBtn.Size = new System.Drawing.Size(57, 32);
            this.cancelOperationBtn.TabIndex = 102;
            this.cancelOperationBtn.UseVisualStyleBackColor = true;
            this.cancelOperationBtn.Click += new System.EventHandler(this.cancelOperationBtn_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(126)))), ((int)(((byte)(245)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.Window;
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.Location = new System.Drawing.Point(715, 469);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(56, 32);
            this.clearButton.TabIndex = 101;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AirlineplaneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inFlightBox);
            this.Controls.Add(this.airplaneTypeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.airplaneModelBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capacityAirplaneBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ownerAirlineBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.airlineBox);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.airplaneIdBox);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.airlinePlaneIdBox);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.cancelOperationBtn);
            this.Controls.Add(this.clearButton);
            this.Name = "AirlineplaneControl";
            this.Size = new System.Drawing.Size(1045, 508);
            this.Load += new System.EventHandler(this.AirlineplaneControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox airplaneIdBox;
        private Panel panel11;
        private Label IdLabel;
        private TextBox airlinePlaneIdBox;
        private Panel panel8;
        private Panel panel6;
        private Label label6;
        private Label nameLabel;
        private TextBox airlineBox;
        private Panel panel7;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn senderColumn;
        private DataGridViewTextBoxColumn fromWhereColumn;
        private DataGridViewTextBoxColumn WhereColumn;
        private DataGridViewTextBoxColumn departmentColumn;
        private DataGridViewTextBoxColumn arrivalColumn;
        private DataGridViewTextBoxColumn InRaceColumn;
        private DataGridViewTextBoxColumn airplaneSender;
        private Label label1;
        private Label label2;
        private TextBox airplaneModelBox;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private TextBox capacityAirplaneBox;
        private Panel panel4;
        private TextBox ownerAirlineBox;
        private Panel panel5;
        private Label label4;
        private Label label5;
        private ComboBox airplaneTypeBox;
        private ComboBox inFlightBox;
        private Button updateButton;
        private Button addButton;
        private Button removeButton;
        private Button cancelOperationBtn;
        private Button clearButton;

        public TextBox AirplaneIdBox { get => airplaneIdBox; set => airplaneIdBox = value; }
        public TextBox AirlinePlaneIdBox { get => airlinePlaneIdBox; set => airlinePlaneIdBox = value; }
        public TextBox AirplaneModelBox { get => airplaneModelBox; set => airplaneModelBox = value; }
        public TextBox CapacityAirplaneBox { get => capacityAirplaneBox; set => capacityAirplaneBox = value; }
        public ComboBox AirplaneTypeBox { get => airplaneTypeBox; set => airplaneTypeBox = value; }
        public ComboBox InFlightBox { get => inFlightBox; set => inFlightBox = value; }
        public TextBox AirlineBox { get => airlineBox; set => airlineBox = value; }
        public TextBox OwnerAirlineBox { get => ownerAirlineBox; set => ownerAirlineBox = value; }
        public Button UpdateButton { get => updateButton; set => updateButton = value; }
        public Button AddButton { get => addButton; set => addButton = value; }
        public Button RemoveButton { get => removeButton; set => removeButton = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
    }
}
