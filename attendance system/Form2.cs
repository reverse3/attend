using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "Server=localhost;Database=attendance;Uid=root;";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();


                string sqlInsert = "INSERT INTO `registration` (`username`, `password`, `email`) VALUES (@username, @password, @email)";
                MySqlCommand cmd = new MySqlCommand(sqlInsert, con);

                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                int value = cmd.ExecuteNonQuery();
                if (value > 0)
                {
                    MessageBox.Show("Account created successfully!");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Error!");
                }


            }
            catch (Exception)
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
