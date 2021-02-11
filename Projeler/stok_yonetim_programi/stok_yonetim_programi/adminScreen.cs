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

        void kritikGrid()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from urunler WHERE(kritikMiktar >= miktar)", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            kritikGridView.DataSource = dt;
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
        void tedarikciGrid()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from supplier", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            tedarikciModulüGrid.DataSource = dt;
            con.Close();
        }

        void depoGridA()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from depos", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            depoModGridA.DataSource = dt;
            con.Close();
        }

        void depoGridB()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from urunler", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            depoModGridB.DataSource = dt;
            con.Close();
        }

        public adminScreen()
        {
            InitializeComponent();
            userGrid();
            musteriGrid();
            tedarikciGrid();
            depoGridA();
            depoGridB();
            kritikGrid();

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
           
            this.usersTableAdapter1.Fill(this.dataSetTest.users);
            

        }

        private void label1_Click_1(object sender, EventArgs e)
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

        private void custAddButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT customers (name, LastName, companyName, email, phone) VALUES ( '"+custNameBox.Text+"','"+custLastnameBox.Text+"','"+custCompBox.Text+"','"+custEmailBox.Text+"','"+custPhoneBox.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            musteriGrid();
        }

        private void custUpdateButton_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText =  "UPDATE customers SET name = '"+custNameBox.Text+"', LastName = '"+custLastnameBox.Text+"',  companyName = '"+custCompBox.Text+"',  email = '"+custEmailBox.Text+"', phone = '"+custPhoneBox.Text+"'  WHERE customerId=" + custIdBox.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            musteriGrid();
        }

        private void custDelButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM customers WHERE customerId=" + custIdBox.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            musteriGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT supplier (supName, supEmail, supPhone) VALUES ('" + supCompnameBox.Text + "','" + supEmailBox.Text + "','" + supPhoneBox.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            tedarikciGrid();
        }

        private void supUpdateButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE supplier SET supName = '" + supCompnameBox.Text + "', supEmail = '" + supEmailBox.Text + "',  supPhone = '" +supPhoneBox.Text + "' WHERE supId=" + supIdBox.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            tedarikciGrid();
        }

        private void supDeleteButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM supplier WHERE supId=" + supIdBox.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            tedarikciGrid();
        }

        private void depoAddButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT depos (depoName, depoAdress, depoPhone) VALUES ('"+depoNameBox.Text+"','"+depoAdressBox.Text+"','"+depoPhoneBox.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            depoGridA();
        }

        private void depoUpdateButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE depos SET depoName = '"+depoNameBox.Text+"', depoAdress = '"+depoAdressBox.Text+"',  depoPhone = '"+depoPhoneBox.Text+"'WHERE depoId="+depoIdBox.Text+"";
            cmd.ExecuteNonQuery();
            con.Close();
            depoGridA();
        }

        private void depoDelButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM depos WHERE depoId=" + depoIdBox.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            depoGridA();
        }

        private void depoModGridB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;
            String Value = this.depoModGridB.Rows[RowNo].Cells[0].Value.ToString();
            con.Open();            
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT resim FROM urunler WHERE urunId = "+Value+"";
            byte[] bytes = (byte[])cmd.ExecuteScalar();
            using (var byteStream = new MemoryStream(bytes))
            {
                pictureBox1.Image = new Bitmap(byteStream);
            }
            con.Close();
            pictureBox1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE urunler SET depo = '" + transferBoxB.Text + "' WHERE urunId = '" + transferIdBox.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            depoGridB();

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void listUptButton_Click(object sender, EventArgs e)
        {
            kritikGrid();
        }
    }
}
