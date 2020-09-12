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

namespace Add_WorkingHours_And_WorkingDays
{
    public partial class WeekDay : Form
    {
        public WeekDay()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-J09JS6JN;Initial Catalog=WHoursAndWDays;Integrated Security=True");
        private void btnAddWeekDay_Click(object sender, EventArgs e)
        {
            String s = "";
             if (checkBox1.CheckState == CheckState.Checked)
             {
                 s += "Monday,";
             }
             if (checkBox2.CheckState == CheckState.Checked)
             {
                 s += "Tuesday,";
             }
             if (checkBox3.CheckState == CheckState.Checked)
             {
                 s += "Wednesday,";
             }
             if (checkBox4.CheckState == CheckState.Checked)
             {
                 s += "Thursday,";
             }
             if (checkBox5.CheckState == CheckState.Checked)
             {
                 s += "Friday,";
             }
             if (checkBox6.CheckState == CheckState.Checked)
             {
                 s += "Saturday,";
             }
             if (checkBox7.CheckState == CheckState.Checked)
             {
                 s += "Sunday,";
             }

            String p = "";
             if (checkBox8.CheckState == CheckState.Checked)
             {
                 p += "One Hour";
             }
             if (checkBox9.CheckState == CheckState.Checked)
             {
                 p += "Thirty Minutes";
             }

            con.Open();
            string query = "INSERT INTO tblWeekDay(TimetbaleType,WorkingDays,TotalWorkingDays,TimeSlot,TotalTimeSlot_hours,TotalTimeSlot_minutes) VALUES('" + "WeekDay" + "','" + s+ "','" + txtWeekdayWorkingDays.Text + "','" + p + "','" + txtWeedDayWorkingHours.Text + "','" + txtWeekDayWorkingMinutes.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted successfully");
            ClearData();
        }
     
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void WeekDay_Load(object sender, EventArgs e)
        {
            
        }
        private void ClearData()
        {
            txtWeekdayWorkingDays.Text = "";
            txtWeedDayWorkingHours.Text = "";
            txtWeekDayWorkingMinutes.Text = "";
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            checkBox5.CheckState = CheckState.Unchecked;
            checkBox6.CheckState = CheckState.Unchecked;
            checkBox7.CheckState = CheckState.Unchecked;
            checkBox8.CheckState = CheckState.Unchecked;
            checkBox9.CheckState = CheckState.Unchecked;


        }
    }
}
