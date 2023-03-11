using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ziekoSkincare
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = Koneksi.getConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable getDataFilm()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM skincare", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public void filldataTable()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowTemplate.Height = 200;
            dataGridView1.DataSource = getDataFilm();
            Column1.DataPropertyName = "id";
            Column2.DataPropertyName = "nama_barang";
            Column3.DataPropertyName = "kadaluarsa";
            Column4.DataPropertyName = "stock";
            Column5.DataPropertyName = "category";
            Column6.DataPropertyName = "image";
            Column7.DataPropertyName = "harga";
        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update skincare SET id = @id := (@id+1); " +
                "ALTER TABLE skincare AUTO_INCREMENT = 1;");
            script.Execute();
        }

        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM skincare WHERE CONCAT (nama_barang, kadaluarsa, stock, category, harga) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
            id_product.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            nama.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            stock.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            category.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            harga.Text = dataGridView1.Rows[id].Cells[6].Value.ToString();

            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openimage = new OpenFileDialog();
            if (openimage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openimage.FileName);
            }
        }

        private void txt_seacrh_TextChanged(object sender, EventArgs e)
        {
            searchData(txt_seacrh.Text);
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            // Convert image to byte array
            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }
            MySqlCommand cmd;

            try
            {
                resetIncrement();

                string Kadaluarsa = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "insert into skincare(nama_barang, kadaluarsa, stock, category, image, harga) VALUE (@nama_barang, @kadaluarsa, @stock, @category, @image, @harga)";
                cmd.Parameters.AddWithValue("@nama_barang", nama.Text);
                cmd.Parameters.AddWithValue("@kadaluarsa", Kadaluarsa);
                cmd.Parameters.AddWithValue("@stock", stock.Text);
                cmd.Parameters.AddWithValue("@category", category.Text);
                cmd.Parameters.AddWithValue("@image", imageData);
                cmd.Parameters.AddWithValue("@harga", harga.Text);

                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error karena = " + ex);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Convert image to byte array
            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }
            string Kadaluarsa = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            MySqlCommand cmd;
            try
            {
                resetIncrement();

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE skincare SET nama_barang=@nama_barang,kadaluarsa=@kadaluarsa,stock=@stock,category=@category,image=@image,harga=@harga where id=@id";
                cmd.Parameters.AddWithValue("@id", id_product.Text);
                cmd.Parameters.AddWithValue("@nama_barang", nama.Text);
                cmd.Parameters.AddWithValue("@kadaluarsa", Kadaluarsa);
                cmd.Parameters.AddWithValue("@stock", stock.Text);
                cmd.Parameters.AddWithValue("@category", category.Text);
                cmd.Parameters.AddWithValue("@image", imageData);
                cmd.Parameters.AddWithValue("@harga", harga.Text);

                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error karena = " + ex);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "DELETE FROM skincare WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", id_product.Text);
            cmd.ExecuteNonQuery();

            koneksi.Close();
            filldataTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}