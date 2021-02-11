using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace stok_yonetim_programi
{
    public partial class alisEkrani : Form
    {
        MySqlConnection con = new MySqlConnection("Server = localhost; Database = stok_yonetimi; user = root; Pwd = 133030;");
        MySqlCommand cmd;

        void tedarikciGrid()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select supId, supName from supplier", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            tedarikciDataGrid.DataSource = dt;
            con.Close();
            tedarikciDataGrid.Columns[0].HeaderText = "Tedarikçi ID'si";
            tedarikciDataGrid.Columns[0].Width = 80;
            tedarikciDataGrid.Columns[1].HeaderText = "Tedarikçi İsmi";
            tedarikciDataGrid.Columns[1].Width = 80;
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
        }

        public alisEkrani()
        {
            InitializeComponent();
            tedarikciGrid();
            urunlerGrid();
        }

        private void alisAddButton_Click(object sender, EventArgs e)
        {

        }

        private void alisExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunlerDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in urunlerDataGrid.SelectedRows)
            {
                urunIdBox.Text = row.Cells[0].Value.ToString();
            }
        }


        private void tedarikciDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tedarikciDataGrid.SelectedRows)
            {
                supIdBox.Text = row.Cells[0].Value.ToString();
            }
        }

        private void tedarikciDataGrid_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tedarikciDataGrid.SelectedRows)
            {
                supIdBox.Text = row.Cells[0].Value.ToString();
            }
        }
  

        private void fiyatTextChanged(object sender, EventArgs e)
        {
            if (urunAdetBox.Text != "" && urunFiyatBox.Text != "")
            {
                toplamFiyatBox.Text = (Convert.ToInt32(urunFiyatBox.Text) * Convert.ToInt32(urunAdetBox.Text)).ToString();
            }
        }

        private void miktarTextChanged(object sender, EventArgs e)
        {
            if (urunAdetBox.Text != "" && urunFiyatBox.Text != "")
            {
                toplamFiyatBox.Text = (Convert.ToInt32(urunFiyatBox.Text) * Convert.ToInt32(urunAdetBox.Text)).ToString();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
