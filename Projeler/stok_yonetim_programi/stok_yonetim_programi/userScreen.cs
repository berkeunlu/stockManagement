using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace stok_yonetim_programi
{
    public partial class userScreen : Form
    {

        MySqlConnection con = new MySqlConnection("Server = localhost; Database = stok_yonetimi; user = root; Pwd = 133030;");
        MySqlCommand cmd;

        void urunGrid()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from urunler", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            urunModuluGrid.DataSource = dt;
            con.Close();
            urunModuluGrid.Columns[0].HeaderText = "Ürün ID";
            urunModuluGrid.Columns[0].Width = 60;
            urunModuluGrid.Columns[1].HeaderText = "Ürün Açıklaması";
            urunModuluGrid.Columns[1].Width = 130;
            urunModuluGrid.Columns[2].HeaderText = "Ürün Cinsi";
            urunModuluGrid.Columns[2].Width = 60;
            urunModuluGrid.Columns[3].HeaderText = "Bulunduğu Depo";
            urunModuluGrid.Columns[3].Width = 80;
            urunModuluGrid.Columns[4].HeaderText = "Stoktaki Miktar";
            urunModuluGrid.Columns[4].Width = 80;
            urunModuluGrid.Columns[5].HeaderText = "Kritik  Miktar";
            urunModuluGrid.Columns[5].Width = 80;
            urunModuluGrid.Columns[6].HeaderText = "resim";
            urunModuluGrid.Columns[6].Width = 125;
        }

        public userScreen()
        {
            InitializeComponent();
            textBox1.Text = "C:/github_repos/tekDers/kaynaklar/images/1024px - No_image_available.svg.png";

            urunGrid();
        }

        private void userAddButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT urunler(aciklama, cins, depo, miktar, kritikMiktar, resim) VALUES('"+urunDesBox.Text+"', '"+urunTypeBox.Text+"', '"+urunDepoBox.Text+"', "+urunStokBox.Text+", "+urunCritBox.Text+ ",(@file))";
            cmd.Parameters.AddWithValue("@file", File.ReadAllBytes(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            urunGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userUpdateButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE urunler SET aciklama = '" + urunDesBox.Text + "', cins = '" + urunTypeBox.Text + "',  depo = '" + urunDepoBox.Text + "', miktar = '" + urunStokBox.Text + "', kritikMiktar = '" + urunCritBox.Text + "', resim = (@file)  WHERE urunId= '" + urunIdBox.Text + "'";
            cmd.Parameters.AddWithValue("@file", File.ReadAllBytes(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            urunGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Image File";
                openFileDialog.InitialDirectory =
                             Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void stokSilButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM urunler WHERE urunId=" + urunIdBox.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            urunGrid();
        }

        private void stokAddButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE urunler SET miktar = (miktar+"+addStokBox.Text+") WHERE urunId = "+urunIdBox.Text+"";
            cmd.ExecuteNonQuery();
            con.Close();
            urunGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            alisEkrani alisForm = new alisEkrani();
            alisForm.ShowDialog();
        }

        private void satisEkraniPic_Click(object sender, EventArgs e)
        {
            satisEkrani satisForm = new satisEkrani();
            satisForm.ShowDialog();
        }

        private void urunModuluGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in urunModuluGrid.SelectedRows)
            {
                urunIdBox.Text = row.Cells[0].Value.ToString();
                urunDesBox.Text = row.Cells[1].Value.ToString();
                urunTypeBox.Text = row.Cells[2].Value.ToString();
                urunDepoBox.Text = row.Cells[3].Value.ToString();
                urunStokBox.Text = row.Cells[4].Value.ToString();
                urunCritBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void gridUpdButton_Click(object sender, EventArgs e)
        {
            urunGrid();
        }
    }
}
