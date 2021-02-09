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
        }

        public userScreen()
        {
            InitializeComponent();

            urunGrid();
        }

        private void userAddButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT urunler(aciklama, cins, depo, miktar, kritikMiktar, resim) VALUES('"+urunDesBox.Text+"', '"+urunTypeBox.Text+"', '"+urunDepoBox.Text+"', '"+urunStokBox.Text+"', '"+urunCritBox.Text+ "',(@file))";
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Image File";
                openFileDialog.InitialDirectory =
                             Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                openFileDialog.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
                textBox1.Text = openFileDialog.FileName;
            }
        }
    }
}
