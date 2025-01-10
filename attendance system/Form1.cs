using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "Server=localhost;Database=attendance;Uid=root;";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();

                    string sqlLogin = "SELECT TeacherNum FROM registration WHERE username=@username AND password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(sqlLogin, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int teacherNum = Convert.ToInt32(result);
                            MessageBox.Show("Login successful!");

                            // Open Dashboard and pass TeacherNum
                            Dashboard dashboard = new Dashboard(teacherNum);
                            this.Hide();
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
    }
}
