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
    public partial class login : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public login()
        {
            InitializeComponent();
            con = new MySqlConnection("Server = localhost; Database = stok_yonetimi; user = root; Pwd = 133030;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State != ConnectionState.Closed)
                {
                    
                }
                else
                {
                    MessageBox.Show("Maalesef Baðlantý Yapýlamadý...!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluþtu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM users where userName='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                if(user == "admin")
                {
                    (new adminScreen()).Show(); this.Hide();
                    MessageBox.Show("Giriþ Baþarýlý");
                }
                else
                {
                    (new userScreen()).Show(); this.Hide();
                    MessageBox.Show("Giriþ Baþarýlý");
                    
                }


            }
            else
            {
                MessageBox.Show("Hatalý Kullanýcý Adý veya Þifre Girdiniz.");
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
