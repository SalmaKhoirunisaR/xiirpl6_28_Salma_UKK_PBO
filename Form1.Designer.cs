namespace ziekoSkincare
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewImageColumn();
            Column7 = new DataGridViewTextBoxColumn();
            id_product = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nama = new TextBox();
            label3 = new Label();
            stock = new TextBox();
            label4 = new Label();
            label5 = new Label();
            category = new TextBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            btn_simpan = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            txt_seacrh = new TextBox();
            label7 = new Label();
            harga = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(26, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1070, 424);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 64;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Nama Barang";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 143;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            Column3.DefaultCellStyle = dataGridViewCellStyle1;
            Column3.HeaderText = "Kadaluarsa";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 133;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Stock";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 91;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Category";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 120;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Image";
            Column6.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Harga";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 96;
            // 
            // id_product
            // 
            id_product.Location = new Point(26, 59);
            id_product.Multiline = true;
            id_product.Name = "id_product";
            id_product.Size = new Size(214, 46);
            id_product.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 118);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "Nama";
            // 
            // nama
            // 
            nama.Location = new Point(26, 146);
            nama.Multiline = true;
            nama.Name = "nama";
            nama.Size = new Size(214, 46);
            nama.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(753, 31);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 6;
            label3.Text = "Image";
            // 
            // stock
            // 
            stock.Location = new Point(266, 144);
            stock.Multiline = true;
            stock.Name = "stock";
            stock.Size = new Size(214, 46);
            stock.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 116);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 8;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 31);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 10;
            label5.Text = "Category";
            // 
            // category
            // 
            category.Location = new Point(266, 59);
            category.Multiline = true;
            category.Name = "category";
            category.Size = new Size(214, 46);
            category.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.Location = new Point(753, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(515, 159);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(206, 31);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 118);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 13;
            label6.Text = "Kadaluarsa";
            // 
            // btn_simpan
            // 
            btn_simpan.Location = new Point(929, 57);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(112, 34);
            btn_simpan.TabIndex = 14;
            btn_simpan.Text = "Save";
            btn_simpan.UseVisualStyleBackColor = true;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(929, 128);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 15;
            btn_update.Text = "Edit";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(929, 207);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_seacrh
            // 
            txt_seacrh.Location = new Point(26, 239);
            txt_seacrh.Multiline = true;
            txt_seacrh.Name = "txt_seacrh";
            txt_seacrh.Size = new Size(703, 46);
            txt_seacrh.TabIndex = 17;
            txt_seacrh.TextChanged += txt_seacrh_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 211);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 18;
            label7.Text = "Search";
            // 
            // harga
            // 
            harga.Location = new Point(515, 59);
            harga.Multiline = true;
            harga.Name = "harga";
            harga.Size = new Size(214, 46);
            harga.TabIndex = 19;
            harga.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(515, 31);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 20;
            label8.Text = "Harga";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1120, 727);
            Controls.Add(label8);
            Controls.Add(harga);
            Controls.Add(label7);
            Controls.Add(txt_seacrh);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_simpan);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(category);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(stock);
            Controls.Add(label2);
            Controls.Add(nama);
            Controls.Add(label1);
            Controls.Add(id_product);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "ZiekoSkincare";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox id_product;
        private Label label1;
        private Label label2;
        private TextBox nama;
        private Label label3;
        private TextBox stock;
        private Label label4;
        private Label label5;
        private TextBox category;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Button btn_simpan;
        private Button btn_update;
        private Button btn_delete;
        private TextBox txt_seacrh;
        private Label label7;
        private TextBox harga;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}