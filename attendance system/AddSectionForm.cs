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

namespace WindowsFormsApp1
{
    public partial class AddSectionForm : Form
    {
        private Dashboard _dashboard; // Reference to Dashboard Form
        private int loggedInTeacherNum;

        public AddSectionForm(Dashboard dashboard, int teacherNum)
        {
            InitializeComponent();
            _dashboard = dashboard;
            loggedInTeacherNum = teacherNum;
        }

        private void btnSaveSection_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connstring = "Server=localhost;Database=attendance;Uid=root;";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();

                    // Insert Section with TeacherNum
                    string sqlInsert = "INSERT INTO section (section_name, TeacherNum) VALUES (@section_name, @teacherNum)";
                    using (MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, con))
                    {
                        cmdInsert.Parameters.AddWithValue("@section_name", txtSectionName.Text);
                        cmdInsert.Parameters.AddWithValue("@teacherNum", loggedInTeacherNum);

                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Section added successfully!");

                        // Update the dashboard ListBox
                        _dashboard.LoadSections();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}




