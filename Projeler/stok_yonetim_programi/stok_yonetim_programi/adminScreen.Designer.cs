namespace stok_yonetim_programi
{
    partial class adminScreen
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
            this.userModule = new System.Windows.Forms.GroupBox();
            this.userUpdateButton = new System.Windows.Forms.Button();
            this.userSilButton = new System.Windows.Forms.Button();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.userAddButton = new System.Windows.Forms.Button();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userUsernameBox = new System.Windows.Forms.TextBox();
            this.soyisimBox = new System.Windows.Forms.TextBox();
            this.userPhoneBox = new System.Windows.Forms.TextBox();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.userEmailBox = new System.Windows.Forms.TextBox();
            this.userPhoneLabel = new System.Windows.Forms.Label();
            this.soyisimLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPasswordBox = new System.Windows.Forms.TextBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userUsernameLabel = new System.Windows.Forms.Label();
            this.kullanıcıModülüGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.stok_yonetimiDataSet = new stok_yonetim_programi.stok_yonetimiDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new stok_yonetim_programi.stok_yonetimiDataSetTableAdapters.usersTableAdapter();
            this.musteriModule = new System.Windows.Forms.GroupBox();
            this.custCompBox = new System.Windows.Forms.TextBox();
            this.custUpdateButton = new System.Windows.Forms.Button();
            this.custDelButton = new System.Windows.Forms.Button();
            this.custAddButton = new System.Windows.Forms.Button();
            this.custIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custLastnameBox = new System.Windows.Forms.TextBox();
            this.custNameBox = new System.Windows.Forms.TextBox();
            this.custPhoneBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.custEmailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.musteriModulüGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıModülüGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_yonetimiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.musteriModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriModulüGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // userModule
            // 
            this.userModule.Controls.Add(this.userUpdateButton);
            this.userModule.Controls.Add(this.userSilButton);
            this.userModule.Controls.Add(this.userIdBox);
            this.userModule.Controls.Add(this.userAddButton);
            this.userModule.Controls.Add(this.userNameBox);
            this.userModule.Controls.Add(this.label1);
            this.userModule.Controls.Add(this.userUsernameBox);
            this.userModule.Controls.Add(this.soyisimBox);
            this.userModule.Controls.Add(this.userPhoneBox);
            this.userModule.Controls.Add(this.userEmailLabel);
            this.userModule.Controls.Add(this.userEmailBox);
            this.userModule.Controls.Add(this.userPhoneLabel);
            this.userModule.Controls.Add(this.soyisimLabel);
            this.userModule.Controls.Add(this.userNameLabel);
            this.userModule.Controls.Add(this.userPasswordBox);
            this.userModule.Controls.Add(this.userPasswordLabel);
            this.userModule.Controls.Add(this.userUsernameLabel);
            this.userModule.Controls.Add(this.kullanıcıModülüGrid);
            this.userModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userModule.Location = new System.Drawing.Point(12, 12);
            this.userModule.Name = "userModule";
            this.userModule.Size = new System.Drawing.Size(540, 412);
            this.userModule.TabIndex = 1;
            this.userModule.TabStop = false;
            this.userModule.Text = "Kullanıcı Modülü";
            this.userModule.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // userUpdateButton
            // 
            this.userUpdateButton.BackColor = System.Drawing.Color.Yellow;
            this.userUpdateButton.FlatAppearance.BorderSize = 0;
            this.userUpdateButton.Location = new System.Drawing.Point(390, 342);
            this.userUpdateButton.Name = "userUpdateButton";
            this.userUpdateButton.Size = new System.Drawing.Size(142, 23);
            this.userUpdateButton.TabIndex = 12;
            this.userUpdateButton.Text = "Güncelle";
            this.userUpdateButton.UseVisualStyleBackColor = false;
            this.userUpdateButton.Click += new System.EventHandler(this.userUpdateButton_Click);
            // 
            // userSilButton
            // 
            this.userSilButton.BackColor = System.Drawing.Color.IndianRed;
            this.userSilButton.FlatAppearance.BorderSize = 0;
            this.userSilButton.Location = new System.Drawing.Point(390, 372);
            this.userSilButton.Name = "userSilButton";
            this.userSilButton.Size = new System.Drawing.Size(142, 23);
            this.userSilButton.TabIndex = 11;
            this.userSilButton.Text = "Sil";
            this.userSilButton.UseVisualStyleBackColor = false;
            this.userSilButton.Click += new System.EventHandler(this.silButon_Click);
            // 
            // userIdBox
            // 
            this.userIdBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIdBox.Location = new System.Drawing.Point(390, 284);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(142, 22);
            this.userIdBox.TabIndex = 27;
            // 
            // userAddButton
            // 
            this.userAddButton.BackColor = System.Drawing.Color.LightGreen;
            this.userAddButton.FlatAppearance.BorderSize = 0;
            this.userAddButton.Location = new System.Drawing.Point(390, 313);
            this.userAddButton.Name = "userAddButton";
            this.userAddButton.Size = new System.Drawing.Size(142, 23);
            this.userAddButton.TabIndex = 10;
            this.userAddButton.Text = "Ekle";
            this.userAddButton.UseVisualStyleBackColor = false;
            this.userAddButton.Click += new System.EventHandler(this.userAddButton_Click);
            // 
            // userNameBox
            // 
            this.userNameBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameBox.Location = new System.Drawing.Point(202, 284);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(173, 22);
            this.userNameBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(387, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "User Id";
            // 
            // userUsernameBox
            // 
            this.userUsernameBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userUsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userUsernameBox.Location = new System.Drawing.Point(6, 328);
            this.userUsernameBox.Name = "userUsernameBox";
            this.userUsernameBox.Size = new System.Drawing.Size(182, 22);
            this.userUsernameBox.TabIndex = 25;
            // 
            // soyisimBox
            // 
            this.soyisimBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.soyisimBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soyisimBox.Location = new System.Drawing.Point(6, 284);
            this.soyisimBox.Name = "soyisimBox";
            this.soyisimBox.Size = new System.Drawing.Size(181, 22);
            this.soyisimBox.TabIndex = 24;
            // 
            // userPhoneBox
            // 
            this.userPhoneBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userPhoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPhoneBox.Location = new System.Drawing.Point(202, 328);
            this.userPhoneBox.Name = "userPhoneBox";
            this.userPhoneBox.Size = new System.Drawing.Size(173, 22);
            this.userPhoneBox.TabIndex = 23;
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userEmailLabel.Location = new System.Drawing.Point(199, 353);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(52, 16);
            this.userEmailLabel.TabIndex = 21;
            this.userEmailLabel.Text = "E-Mail";
            // 
            // userEmailBox
            // 
            this.userEmailBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userEmailBox.Location = new System.Drawing.Point(202, 372);
            this.userEmailBox.Name = "userEmailBox";
            this.userEmailBox.Size = new System.Drawing.Size(173, 22);
            this.userEmailBox.TabIndex = 20;
            // 
            // userPhoneLabel
            // 
            this.userPhoneLabel.AutoSize = true;
            this.userPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userPhoneLabel.Location = new System.Drawing.Point(199, 309);
            this.userPhoneLabel.Name = "userPhoneLabel";
            this.userPhoneLabel.Size = new System.Drawing.Size(61, 16);
            this.userPhoneLabel.TabIndex = 19;
            this.userPhoneLabel.Text = "Telefon";
            // 
            // soyisimLabel
            // 
            this.soyisimLabel.AutoSize = true;
            this.soyisimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisimLabel.Location = new System.Drawing.Point(199, 265);
            this.soyisimLabel.Name = "soyisimLabel";
            this.soyisimLabel.Size = new System.Drawing.Size(63, 16);
            this.soyisimLabel.TabIndex = 17;
            this.soyisimLabel.Text = "Soyisim";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameLabel.Location = new System.Drawing.Point(3, 265);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(36, 16);
            this.userNameLabel.TabIndex = 15;
            this.userNameLabel.Text = "İsim";
            this.userNameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // userPasswordBox
            // 
            this.userPasswordBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPasswordBox.Location = new System.Drawing.Point(6, 372);
            this.userPasswordBox.Name = "userPasswordBox";
            this.userPasswordBox.Size = new System.Drawing.Size(181, 22);
            this.userPasswordBox.TabIndex = 14;
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userPasswordLabel.Location = new System.Drawing.Point(3, 353);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(40, 16);
            this.userPasswordLabel.TabIndex = 9;
            this.userPasswordLabel.Text = "Şifre";
            // 
            // userUsernameLabel
            // 
            this.userUsernameLabel.AutoSize = true;
            this.userUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userUsernameLabel.Location = new System.Drawing.Point(3, 309);
            this.userUsernameLabel.Name = "userUsernameLabel";
            this.userUsernameLabel.Size = new System.Drawing.Size(93, 16);
            this.userUsernameLabel.TabIndex = 8;
            this.userUsernameLabel.Text = "Kullanıcı Adı";
            this.userUsernameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // kullanıcıModülüGrid
            // 
            this.kullanıcıModülüGrid.AllowUserToAddRows = false;
            this.kullanıcıModülüGrid.AllowUserToDeleteRows = false;
            this.kullanıcıModülüGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullanıcıModülüGrid.Location = new System.Drawing.Point(6, 21);
            this.kullanıcıModülüGrid.Name = "kullanıcıModülüGrid";
            this.kullanıcıModülüGrid.ReadOnly = true;
            this.kullanıcıModülüGrid.Size = new System.Drawing.Size(526, 241);
            this.kullanıcıModülüGrid.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 430);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(786, 267);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Depo Modülü";
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(804, 430);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 267);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rapor Modülü";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(1108, 720);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stok_yonetimiDataSet
            // 
            this.stok_yonetimiDataSet.DataSetName = "stok_yonetimiDataSet";
            this.stok_yonetimiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.stok_yonetimiDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // musteriModule
            // 
            this.musteriModule.Controls.Add(this.custCompBox);
            this.musteriModule.Controls.Add(this.custUpdateButton);
            this.musteriModule.Controls.Add(this.custDelButton);
            this.musteriModule.Controls.Add(this.custAddButton);
            this.musteriModule.Controls.Add(this.custIdBox);
            this.musteriModule.Controls.Add(this.label2);
            this.musteriModule.Controls.Add(this.custLastnameBox);
            this.musteriModule.Controls.Add(this.custNameBox);
            this.musteriModule.Controls.Add(this.custPhoneBox);
            this.musteriModule.Controls.Add(this.label3);
            this.musteriModule.Controls.Add(this.custEmailBox);
            this.musteriModule.Controls.Add(this.label4);
            this.musteriModule.Controls.Add(this.label5);
            this.musteriModule.Controls.Add(this.label6);
            this.musteriModule.Controls.Add(this.label8);
            this.musteriModule.Controls.Add(this.musteriModulüGrid);
            this.musteriModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriModule.Location = new System.Drawing.Point(558, 12);
            this.musteriModule.Name = "musteriModule";
            this.musteriModule.Size = new System.Drawing.Size(540, 412);
            this.musteriModule.TabIndex = 29;
            this.musteriModule.TabStop = false;
            this.musteriModule.Text = "Müşteri Modülü";
            // 
            // custCompBox
            // 
            this.custCompBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.custCompBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custCompBox.Location = new System.Drawing.Point(5, 372);
            this.custCompBox.Name = "custCompBox";
            this.custCompBox.Size = new System.Drawing.Size(182, 22);
            this.custCompBox.TabIndex = 30;
            // 
            // custUpdateButton
            // 
            this.custUpdateButton.BackColor = System.Drawing.Color.Yellow;
            this.custUpdateButton.FlatAppearance.BorderSize = 0;
            this.custUpdateButton.Location = new System.Drawing.Point(392, 327);
            this.custUpdateButton.Name = "custUpdateButton";
            this.custUpdateButton.Size = new System.Drawing.Size(142, 23);
            this.custUpdateButton.TabIndex = 12;
            this.custUpdateButton.Text = "Güncelle";
            this.custUpdateButton.UseVisualStyleBackColor = false;
            // 
            // custDelButton
            // 
            this.custDelButton.BackColor = System.Drawing.Color.IndianRed;
            this.custDelButton.FlatAppearance.BorderSize = 0;
            this.custDelButton.Location = new System.Drawing.Point(392, 371);
            this.custDelButton.Name = "custDelButton";
            this.custDelButton.Size = new System.Drawing.Size(142, 23);
            this.custDelButton.TabIndex = 11;
            this.custDelButton.Text = "Sil";
            this.custDelButton.UseVisualStyleBackColor = false;
            // 
            // custAddButton
            // 
            this.custAddButton.BackColor = System.Drawing.Color.LightGreen;
            this.custAddButton.FlatAppearance.BorderSize = 0;
            this.custAddButton.Location = new System.Drawing.Point(392, 283);
            this.custAddButton.Name = "custAddButton";
            this.custAddButton.Size = new System.Drawing.Size(142, 23);
            this.custAddButton.TabIndex = 10;
            this.custAddButton.Text = "Ekle";
            this.custAddButton.UseVisualStyleBackColor = false;
            // 
            // custIdBox
            // 
            this.custIdBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.custIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custIdBox.Location = new System.Drawing.Point(202, 284);
            this.custIdBox.Name = "custIdBox";
            this.custIdBox.Size = new System.Drawing.Size(173, 22);
            this.custIdBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(199, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "User Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // custLastnameBox
            // 
            this.custLastnameBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.custLastnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custLastnameBox.Location = new System.Drawing.Point(5, 328);
            this.custLastnameBox.Name = "custLastnameBox";
            this.custLastnameBox.Size = new System.Drawing.Size(182, 22);
            this.custLastnameBox.TabIndex = 25;
            // 
            // custNameBox
            // 
            this.custNameBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.custNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custNameBox.Location = new System.Drawing.Point(6, 284);
            this.custNameBox.Name = "custNameBox";
            this.custNameBox.Size = new System.Drawing.Size(181, 22);
            this.custNameBox.TabIndex = 24;
            // 
            // custPhoneBox
            // 
            this.custPhoneBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.custPhoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custPhoneBox.Location = new System.Drawing.Point(202, 328);
            this.custPhoneBox.Name = "custPhoneBox";
            this.custPhoneBox.Size = new System.Drawing.Size(173, 22);
            this.custPhoneBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(199, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "E-Mail";
            // 
            // custEmailBox
            // 
            this.custEmailBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.custEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custEmailBox.Location = new System.Drawing.Point(202, 372);
            this.custEmailBox.Name = "custEmailBox";
            this.custEmailBox.Size = new System.Drawing.Size(173, 22);
            this.custEmailBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(199, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Soyisim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "İsim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Firma Adı";
            // 
            // musteriModulüGrid
            // 
            this.musteriModulüGrid.AllowUserToAddRows = false;
            this.musteriModulüGrid.AllowUserToDeleteRows = false;
            this.musteriModulüGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriModulüGrid.Location = new System.Drawing.Point(6, 21);
            this.musteriModulüGrid.Name = "musteriModulüGrid";
            this.musteriModulüGrid.ReadOnly = true;
            this.musteriModulüGrid.Size = new System.Drawing.Size(526, 241);
            this.musteriModulüGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1104, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 412);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Modülü";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(5, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 22);
            this.textBox1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(392, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(392, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(392, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Ekle";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(202, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 22);
            this.textBox2.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(199, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "User Id";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(5, 328);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 22);
            this.textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(6, 284);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 22);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(202, 328);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 22);
            this.textBox5.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(199, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "E-Mail";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(202, 372);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(173, 22);
            this.textBox6.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(199, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(3, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Soyisim";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(3, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "İsim";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(3, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Firma Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(526, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // adminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1652, 751);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.musteriModule);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.userModule);
            this.Name = "adminScreen";
            this.Text = "adminScreen";
            this.Load += new System.EventHandler(this.adminScreen_Load);
            this.userModule.ResumeLayout(false);
            this.userModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıModülüGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_yonetimiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.musteriModule.ResumeLayout(false);
            this.musteriModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriModulüGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userModule;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView kullanıcıModülüGrid;
        private stok_yonetimiDataSet stok_yonetimiDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private stok_yonetimiDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userPasswordBox;
        private System.Windows.Forms.Button userUpdateButton;
        private System.Windows.Forms.Button userSilButton;
        private System.Windows.Forms.Button userAddButton;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Label userUsernameLabel;
        private System.Windows.Forms.Label userEmailLabel;
        private System.Windows.Forms.TextBox userEmailBox;
        private System.Windows.Forms.Label userPhoneLabel;
        private System.Windows.Forms.Label soyisimLabel;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox userUsernameBox;
        private System.Windows.Forms.TextBox soyisimBox;
        private System.Windows.Forms.TextBox userPhoneBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.GroupBox musteriModule;
        private System.Windows.Forms.Button custUpdateButton;
        private System.Windows.Forms.Button custDelButton;
        private System.Windows.Forms.Button custAddButton;
        private System.Windows.Forms.TextBox custIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custLastnameBox;
        private System.Windows.Forms.TextBox custNameBox;
        private System.Windows.Forms.TextBox custPhoneBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custEmailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView musteriModulüGrid;
        private System.Windows.Forms.TextBox custCompBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}