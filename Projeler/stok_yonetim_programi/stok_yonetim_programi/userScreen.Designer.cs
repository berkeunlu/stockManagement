namespace stok_yonetim_programi
{
    partial class userScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userScreen));
            this.userModule = new System.Windows.Forms.GroupBox();
            this.stokUpdateButton = new System.Windows.Forms.Button();
            this.stokAddButton = new System.Windows.Forms.Button();
            this.stokUrunAddButton = new System.Windows.Forms.Button();
            this.urunDepoBox = new System.Windows.Forms.TextBox();
            this.urunLabel = new System.Windows.Forms.Label();
            this.urunModuluGrid = new System.Windows.Forms.DataGridView();
            this.urunDesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunTypeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urunStokBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.urunCritBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stokSilButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunModuluGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userModule
            // 
            this.userModule.Controls.Add(this.stokSilButton);
            this.userModule.Controls.Add(this.pictureBox1);
            this.userModule.Controls.Add(this.urunDepoBox);
            this.userModule.Controls.Add(this.urunLabel);
            this.userModule.Controls.Add(this.stokUpdateButton);
            this.userModule.Controls.Add(this.button1);
            this.userModule.Controls.Add(this.label1);
            this.userModule.Controls.Add(this.urunCritBox);
            this.userModule.Controls.Add(this.urunDesBox);
            this.userModule.Controls.Add(this.label4);
            this.userModule.Controls.Add(this.urunStokBox);
            this.userModule.Controls.Add(this.label3);
            this.userModule.Controls.Add(this.urunTypeBox);
            this.userModule.Controls.Add(this.label2);
            this.userModule.Controls.Add(this.stokAddButton);
            this.userModule.Controls.Add(this.stokUrunAddButton);
            this.userModule.Controls.Add(this.urunModuluGrid);
            this.userModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userModule.Location = new System.Drawing.Point(12, 12);
            this.userModule.Name = "userModule";
            this.userModule.Size = new System.Drawing.Size(672, 412);
            this.userModule.TabIndex = 2;
            this.userModule.TabStop = false;
            this.userModule.Text = "Ürün Modülü";
            // 
            // stokUpdateButton
            // 
            this.stokUpdateButton.BackColor = System.Drawing.Color.Yellow;
            this.stokUpdateButton.FlatAppearance.BorderSize = 0;
            this.stokUpdateButton.Location = new System.Drawing.Point(390, 342);
            this.stokUpdateButton.Name = "stokUpdateButton";
            this.stokUpdateButton.Size = new System.Drawing.Size(142, 23);
            this.stokUpdateButton.TabIndex = 12;
            this.stokUpdateButton.Text = "Güncelle";
            this.stokUpdateButton.UseVisualStyleBackColor = false;
            this.stokUpdateButton.Click += new System.EventHandler(this.userUpdateButton_Click);
            // 
            // stokAddButton
            // 
            this.stokAddButton.BackColor = System.Drawing.Color.DarkOrange;
            this.stokAddButton.FlatAppearance.BorderSize = 0;
            this.stokAddButton.Location = new System.Drawing.Point(390, 313);
            this.stokAddButton.Name = "stokAddButton";
            this.stokAddButton.Size = new System.Drawing.Size(142, 23);
            this.stokAddButton.TabIndex = 11;
            this.stokAddButton.Text = "Stok Ekle";
            this.stokAddButton.UseVisualStyleBackColor = false;
            // 
            // stokUrunAddButton
            // 
            this.stokUrunAddButton.BackColor = System.Drawing.Color.LightGreen;
            this.stokUrunAddButton.FlatAppearance.BorderSize = 2;
            this.stokUrunAddButton.Location = new System.Drawing.Point(390, 284);
            this.stokUrunAddButton.Name = "stokUrunAddButton";
            this.stokUrunAddButton.Size = new System.Drawing.Size(142, 23);
            this.stokUrunAddButton.TabIndex = 10;
            this.stokUrunAddButton.Text = "Ürün Ekle";
            this.stokUrunAddButton.UseVisualStyleBackColor = false;
            this.stokUrunAddButton.Click += new System.EventHandler(this.userAddButton_Click);
            // 
            // urunDepoBox
            // 
            this.urunDepoBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.urunDepoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunDepoBox.Location = new System.Drawing.Point(6, 371);
            this.urunDepoBox.Name = "urunDepoBox";
            this.urunDepoBox.Size = new System.Drawing.Size(181, 22);
            this.urunDepoBox.TabIndex = 24;
            // 
            // urunLabel
            // 
            this.urunLabel.AutoSize = true;
            this.urunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunLabel.Location = new System.Drawing.Point(3, 352);
            this.urunLabel.Name = "urunLabel";
            this.urunLabel.Size = new System.Drawing.Size(46, 16);
            this.urunLabel.TabIndex = 15;
            this.urunLabel.Text = "Depo";
            // 
            // urunModuluGrid
            // 
            this.urunModuluGrid.AllowUserToAddRows = false;
            this.urunModuluGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.urunModuluGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.urunModuluGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunModuluGrid.Location = new System.Drawing.Point(6, 21);
            this.urunModuluGrid.Name = "urunModuluGrid";
            this.urunModuluGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.urunModuluGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.urunModuluGrid.Size = new System.Drawing.Size(660, 241);
            this.urunModuluGrid.TabIndex = 0;
            // 
            // urunDesBox
            // 
            this.urunDesBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.urunDesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunDesBox.Location = new System.Drawing.Point(6, 284);
            this.urunDesBox.Name = "urunDesBox";
            this.urunDesBox.Size = new System.Drawing.Size(181, 22);
            this.urunDesBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ürün Açıklaması";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // urunTypeBox
            // 
            this.urunTypeBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.urunTypeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunTypeBox.Location = new System.Drawing.Point(6, 327);
            this.urunTypeBox.Name = "urunTypeBox";
            this.urunTypeBox.Size = new System.Drawing.Size(181, 22);
            this.urunTypeBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cinsi";
            // 
            // urunStokBox
            // 
            this.urunStokBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.urunStokBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunStokBox.Location = new System.Drawing.Point(193, 284);
            this.urunStokBox.Name = "urunStokBox";
            this.urunStokBox.Size = new System.Drawing.Size(181, 22);
            this.urunStokBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(190, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Stoktaki Miktar";
            // 
            // urunCritBox
            // 
            this.urunCritBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.urunCritBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunCritBox.Location = new System.Drawing.Point(193, 327);
            this.urunCritBox.Name = "urunCritBox";
            this.urunCritBox.Size = new System.Drawing.Size(181, 22);
            this.urunCritBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(190, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Kritik Stok Miktarı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(193, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Resim Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stokSilButton
            // 
            this.stokSilButton.BackColor = System.Drawing.Color.IndianRed;
            this.stokSilButton.FlatAppearance.BorderSize = 0;
            this.stokSilButton.Location = new System.Drawing.Point(390, 372);
            this.stokSilButton.Name = "stokSilButton";
            this.stokSilButton.Size = new System.Drawing.Size(142, 23);
            this.stokSilButton.TabIndex = 34;
            this.stokSilButton.Text = "Sil";
            this.stokSilButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(12, 634);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // userScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1450, 668);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userModule);
            this.Name = "userScreen";
            this.Text = "Stok Yönetimi v0.5a";
            this.userModule.ResumeLayout(false);
            this.userModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunModuluGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox userModule;
        private System.Windows.Forms.Button stokUpdateButton;
        private System.Windows.Forms.Button stokAddButton;
        private System.Windows.Forms.Button stokUrunAddButton;
        private System.Windows.Forms.TextBox urunDepoBox;
        private System.Windows.Forms.Label urunLabel;
        private System.Windows.Forms.DataGridView urunModuluGrid;
        private System.Windows.Forms.TextBox urunCritBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urunStokBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urunTypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunDesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stokSilButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}