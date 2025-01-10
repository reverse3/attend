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
    public partial class AddAttendanceForm : Form
    {
        private int loggedInTeacherNum;

        public AddAttendanceForm(int teacherNum)
        {
            InitializeComponent();
            loggedInTeacherNum = teacherNum;
        }

        private void btnSubmitAttendance_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSubmitAttendance_Click_1(object sender, EventArgs e)
        {
            string connstring = "Server=localhost;Database=attendance;Uid=root;";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string sqlInsert = "INSERT INTO attendance (student_name, date, status, section_id, TeacherNum) VALUES (@student_name, @date, @status, @section_id, @teacherNum)";
                using (MySqlCommand cmd = new MySqlCommand(sqlInsert, con))
                {
                    cmd.Parameters.AddWithValue("@student_name", txtStudentName.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@status", comboStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@section_id", Convert.ToInt32(txtSectionID.Text));
                    cmd.Parameters.AddWithValue("@teacherNum", loggedInTeacherNum);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Attendance Recorded Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error: Attendance not recorded.");
                    }
                    this.Close();
                }
            }
        }

        private void txtSectionID_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
