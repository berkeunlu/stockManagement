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
                    MessageBox.Show("Maalesef Ba�lant� Yap�lamad�...!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Olu�tu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    adminScreen adminForm = new adminScreen();
                    this.Hide();
                    MessageBox.Show("Y�netici Giri�i Ba�ar�l�!");
                    adminForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    userScreen userForm = new userScreen();
                    this.Hide();
                    MessageBox.Show("Giri� Ba�ar�l�!");
                    userForm.ShowDialog();
                    this.Close();
                }


            }
            else
            {
                MessageBox.Show("Hatal� Kullan�c� Ad� veya �ifre Girdiniz.");
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
