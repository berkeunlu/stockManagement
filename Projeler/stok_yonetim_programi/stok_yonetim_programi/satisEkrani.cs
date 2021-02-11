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
    public partial class satisEkrani : Form
    {

        MySqlConnection con = new MySqlConnection("Server = localhost; Database = stok_yonetimi; user = root; Pwd = 133030;");
        MySqlCommand cmd;

        void musteriGrid()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select customerId, name from customers", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            musteriDataGrid.DataSource = dt;
            con.Close();
            musteriDataGrid.Columns[0].HeaderText = "Müşteri ID'si";
            musteriDataGrid.Columns[0].Width = 80;
            musteriDataGrid.Columns[1].HeaderText = "Müşteri İsmi";
            musteriDataGrid.Columns[1].Width = 80;
        }

        void urunlerGrid()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select urunId, aciklama, miktar from urunler", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            urunlerDataGrid.DataSource = dt;
            urunlerDataGrid.Columns[0].HeaderText = "Ürün ID";
            urunlerDataGrid.Columns[0].Width = 60;
            urunlerDataGrid.Columns[1].HeaderText = "Ürün Açıklaması";
            urunlerDataGrid.Columns[1].Width = 130;
            urunlerDataGrid.Columns[2].HeaderText = "Stoktaki Miktar";
            urunlerDataGrid.Columns[2].Width = 80;
            con.Close();
        }

        public satisEkrani()
        {
            InitializeComponent();
            musteriGrid();
            urunlerGrid();
        }

        private void urunlerDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in urunlerDataGrid.SelectedRows)
            {
                urunIdBox.Text = row.Cells[0].Value.ToString();

                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT resim FROM urunler WHERE urunId = " + urunIdBox.Text + "";
                byte[] bytes = (byte[])cmd.ExecuteScalar();
                using (var byteStream = new MemoryStream(bytes))
                {
                    pictureBox1.Image = new Bitmap(byteStream);
                }
                con.Close();
                pictureBox1.Refresh();

            }
        }

        private void alisExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void musteriDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in musteriDataGrid.SelectedRows)
            {
                custIdBox.Text = row.Cells[0].Value.ToString();
            }
        }

        private void urunFiyatBox_TextChanged(object sender, EventArgs e)
        {
            if (urunAdetBox.Text != "" && urunFiyatBox.Text != "")
            {
                toplamFiyatBox.Text = (Convert.ToInt32(urunFiyatBox.Text) * Convert.ToInt32(urunAdetBox.Text)).ToString();
            }
        }

        private void urunAdetBox_TextChanged(object sender, EventArgs e)
        {
            if (urunAdetBox.Text != "" && urunFiyatBox.Text != "")
            {
                toplamFiyatBox.Text = (Convert.ToInt32(urunFiyatBox.Text) * Convert.ToInt32(urunAdetBox.Text)).ToString();
            }
        }

        private void alisSellButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT stokhareketleri (islem, t_mNumarası, urunId, urunMiktarı, urunFiyatı, urunToplam) VALUES ('Satış','" + custIdBox.Text + "','" + urunIdBox.Text + "','" + urunAdetBox.Text + "','" + urunFiyatBox.Text + "','" + toplamFiyatBox.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE urunler SET miktar = (miktar - " + urunAdetBox.Text + ") WHERE urunId = '" + urunIdBox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            urunlerGrid();
        }
    }
}
