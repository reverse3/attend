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
    public partial class ViewAttendanceForm : Form
    {
        private int loggedInTeacherNum;

        public ViewAttendanceForm(int teacherNum)
        {
            InitializeComponent();
            loggedInTeacherNum = teacherNum;
            LoadAttendance();
        }

        private void LoadAttendance()
        {
          
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listBoxAttendance.Items.Clear();  // Clear previous data

            string connstring = "Server=localhost;Database=attendance;Uid=root;";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string sqlQuery = "SELECT student_name, date, status FROM attendance WHERE TeacherNum=@teacherNum";
                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@teacherNum", loggedInTeacherNum);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Retrieve the date and ensure it includes the time
                            DateTime date = Convert.ToDateTime(reader["date"]);
                            string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");  // Format to show both date and time (hours, minutes, seconds)

                            // Add to the list box
                            listBoxAttendance.Items.Add($"{reader["student_name"]} - {formattedDate} - {reader["status"]}");
                        }
                    }
                }
            }
        }


    }

}
