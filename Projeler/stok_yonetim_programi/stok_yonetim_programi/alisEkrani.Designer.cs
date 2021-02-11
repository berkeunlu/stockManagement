namespace stok_yonetim_programi
{
    partial class alisEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toplamFiyatBox = new System.Windows.Forms.TextBox();
            this.alisExitButton = new System.Windows.Forms.Button();
            this.urunlerDataGrid = new System.Windows.Forms.DataGridView();
            this.tedarikciDataGrid = new System.Windows.Forms.DataGridView();
            this.Tedarikçi = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.urunFiyatBox = new System.Windows.Forms.TextBox();
            this.alisAddButton = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.urunIdBox = new System.Windows.Forms.TextBox();
            this.supIdBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.urunAdetBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.toplamFiyatBox);
            this.groupBox3.Controls.Add(this.alisExitButton);
            this.groupBox3.Controls.Add(this.urunlerDataGrid);
            this.groupBox3.Controls.Add(this.tedarikciDataGrid);
            this.groupBox3.Controls.Add(this.Tedarikçi);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.urunFiyatBox);
            this.groupBox3.Controls.Add(this.alisAddButton);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.urunIdBox);
            this.groupBox3.Controls.Add(this.supIdBox);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.urunAdetBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 606);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alış Modülü";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(532, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Toplam\r\nFiyatı";
            // 
            // toplamFiyatBox
            // 
            this.toplamFiyatBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.toplamFiyatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toplamFiyatBox.Location = new System.Drawing.Point(535, 296);
            this.toplamFiyatBox.Name = "toplamFiyatBox";
            this.toplamFiyatBox.Size = new System.Drawing.Size(89, 22);
            this.toplamFiyatBox.TabIndex = 30;
            // 
            // alisExitButton
            // 
            this.alisExitButton.BackColor = System.Drawing.Color.IndianRed;
            this.alisExitButton.FlatAppearance.BorderSize = 0;
            this.alisExitButton.Location = new System.Drawing.Point(536, 538);
            this.alisExitButton.Name = "alisExitButton";
            this.alisExitButton.Size = new System.Drawing.Size(90, 62);
            this.alisExitButton.TabIndex = 29;
            this.alisExitButton.Text = "Çıkış";
            this.alisExitButton.UseVisualStyleBackColor = false;
            this.alisExitButton.Click += new System.EventHandler(this.alisExitButton_Click);
            // 
            // urunlerDataGrid
            // 
            this.urunlerDataGrid.AllowUserToAddRows = false;
            this.urunlerDataGrid.AllowUserToDeleteRows = false;
            this.urunlerDataGrid.AllowUserToResizeColumns = false;
            this.urunlerDataGrid.AllowUserToResizeRows = false;
            this.urunlerDataGrid.BackgroundColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.urunlerDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.urunlerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDataGrid.GridColor = System.Drawing.Color.Cornsilk;
            this.urunlerDataGrid.Location = new System.Drawing.Point(216, 21);
            this.urunlerDataGrid.Name = "urunlerDataGrid";
            this.urunlerDataGrid.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.urunlerDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.urunlerDataGrid.Size = new System.Drawing.Size(314, 579);
            this.urunlerDataGrid.TabIndex = 29;
            this.urunlerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunlerDataGrid_CellContentClick);
            this.urunlerDataGrid.SelectionChanged += new System.EventHandler(this.urunlerDataGrid_SelectionChanged);
            // 
            // tedarikciDataGrid
            // 
            this.tedarikciDataGrid.AllowUserToAddRows = false;
            this.tedarikciDataGrid.AllowUserToDeleteRows = false;
            this.tedarikciDataGrid.AllowUserToResizeColumns = false;
            this.tedarikciDataGrid.AllowUserToResizeRows = false;
            this.tedarikciDataGrid.BackgroundColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tedarikciDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tedarikciDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikciDataGrid.GridColor = System.Drawing.Color.Cornsilk;
            this.tedarikciDataGrid.Location = new System.Drawing.Point(6, 21);
            this.tedarikciDataGrid.Name = "tedarikciDataGrid";
            this.tedarikciDataGrid.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tedarikciDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tedarikciDataGrid.Size = new System.Drawing.Size(204, 579);
            this.tedarikciDataGrid.TabIndex = 0;
            this.tedarikciDataGrid.SelectionChanged += new System.EventHandler(this.tedarikciDataGrid_SelectionChanged);
            // 
            // Tedarikçi
            // 
            this.Tedarikçi.AutoSize = true;
            this.Tedarikçi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tedarikçi.Location = new System.Drawing.Point(532, 21);
            this.Tedarikçi.Name = "Tedarikçi";
            this.Tedarikçi.Size = new System.Drawing.Size(74, 32);
            this.Tedarikçi.TabIndex = 15;
            this.Tedarikçi.Text = "Tedarikçi\r\nID";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(532, 81);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 32);
            this.label26.TabIndex = 8;
            this.label26.Text = "Ürün\r\nID";
            // 
            // urunFiyatBox
            // 
            this.urunFiyatBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.urunFiyatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunFiyatBox.Location = new System.Drawing.Point(535, 236);
            this.urunFiyatBox.Name = "urunFiyatBox";
            this.urunFiyatBox.Size = new System.Drawing.Size(89, 22);
            this.urunFiyatBox.TabIndex = 24;
            this.urunFiyatBox.TextChanged += new System.EventHandler(this.fiyatTextChanged);
            // 
            // alisAddButton
            // 
            this.alisAddButton.BackColor = System.Drawing.Color.LightGreen;
            this.alisAddButton.FlatAppearance.BorderSize = 0;
            this.alisAddButton.Location = new System.Drawing.Point(536, 470);
            this.alisAddButton.Name = "alisAddButton";
            this.alisAddButton.Size = new System.Drawing.Size(90, 62);
            this.alisAddButton.TabIndex = 10;
            this.alisAddButton.Text = "Ürünü Al";
            this.alisAddButton.UseVisualStyleBackColor = false;
            this.alisAddButton.Click += new System.EventHandler(this.alisAddButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(532, 141);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 32);
            this.label25.TabIndex = 9;
            this.label25.Text = "Alınacak\r\nÜrün Miktarı";
            // 
            // urunIdBox
            // 
            this.urunIdBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.urunIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunIdBox.Location = new System.Drawing.Point(535, 116);
            this.urunIdBox.Name = "urunIdBox";
            this.urunIdBox.Size = new System.Drawing.Size(89, 22);
            this.urunIdBox.TabIndex = 25;
            // 
            // supIdBox
            // 
            this.supIdBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.supIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supIdBox.Location = new System.Drawing.Point(536, 56);
            this.supIdBox.Name = "supIdBox";
            this.supIdBox.Size = new System.Drawing.Size(89, 22);
            this.supIdBox.TabIndex = 26;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(532, 201);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 32);
            this.label23.TabIndex = 17;
            this.label23.Text = "Birim\r\nFiyatı";
            // 
            // urunAdetBox
            // 
            this.urunAdetBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.urunAdetBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunAdetBox.Location = new System.Drawing.Point(535, 176);
            this.urunAdetBox.Name = "urunAdetBox";
            this.urunAdetBox.Size = new System.Drawing.Size(89, 22);
            this.urunAdetBox.TabIndex = 14;
            this.urunAdetBox.TextChanged += new System.EventHandler(this.miktarTextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(536, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // alisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(661, 630);
            this.Controls.Add(this.groupBox3);
            this.Name = "alisEkrani";
            this.Text = "alisEkrani";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button alisAddButton;
        private System.Windows.Forms.TextBox supIdBox;
        private System.Windows.Forms.TextBox urunIdBox;
        private System.Windows.Forms.TextBox urunFiyatBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label Tedarikçi;
        private System.Windows.Forms.TextBox urunAdetBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView tedarikciDataGrid;
        private System.Windows.Forms.Button alisExitButton;
        private System.Windows.Forms.DataGridView urunlerDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toplamFiyatBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}