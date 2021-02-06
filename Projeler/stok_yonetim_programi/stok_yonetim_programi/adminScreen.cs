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


    public partial class adminScreen : Form
    {
        MySqlConnection con = new MySqlConnection("Server = localhost; Database = stok_yonetimi; user = root; Pwd = 133030;");
        MySqlCommand cmd;
        
        void userGrid()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from users", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            kullanıcıModülüGrid.DataSource = dt;
            con.Close();
        }
        void musteriGrid()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from customers", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            musteriModulüGrid.DataSource = dt;
            con.Close();
        }
        public adminScreen()
        {
            InitializeComponent();
            userGrid();
            musteriGrid();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void adminScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stok_yonetimiDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.stok_yonetimiDataSet.users);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userAddButton_Click(object sender, EventArgs e)
        {
            string username = userUsernameBox.Text;
            string pass = userPasswordBox.Text;
            string user = userNameBox.Text;
            string lastname = soyisimBox.Text;
            string phone = userPhoneBox.Text;
            string email = userEmailBox.Text;
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT users (userName, password, isim, soyisim, email, telefon) VALUES ( '"+username+"','"+pass+"','"+user+"','"+lastname+"','"+email+"','"+phone+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            userGrid();

        }

        private void silButon_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM users WHERE PersonId="+userIdBox.Text+"";
            cmd.ExecuteNonQuery();
            con.Close();
            userGrid();
        }

        private void userUpdateButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE users SET userName = '"+userUsernameBox.Text+"', password = '"+userPasswordBox.Text+"',  isim = '"+userNameBox.Text+"',  soyisim = '"+soyisimBox.Text+"',  email = '"+userEmailBox.Text+"',  telefon = '"+userPhoneBox.Text+"' WHERE PersonId="+userIdBox.Text+"";
            cmd.ExecuteNonQuery();
            con.Close();
            userGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
