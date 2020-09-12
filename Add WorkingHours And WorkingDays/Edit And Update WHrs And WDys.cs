using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Add_WorkingHours_And_WorkingDays
{
    public partial class Edit_And_Update_WHrs_And_WDys : Form
    {
        public Edit_And_Update_WHrs_And_WDys()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-J09JS6JN;Initial Catalog=WHoursAndWDays;Integrated Security=True");
        private void Edit_And_Update_WHrs_And_WDys_Load(object sender, EventArgs e)
        {
            
        }

        private void TimeTableType_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblWeekDay where TimetbaleType='"+comboBox1.SelectedItem.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
           

            foreach (DataRow dr in dt.Rows)
                
            {
                TimeTableType.Text = dr["TimetbaleType"].ToString();
                
                textBox1.Text = dr["TotalWorkingDays"].ToString();
                textBox2.Text = dr["TotalTimeSlot_hours"].ToString();
                textBox3.Text = dr["TotalTimeSlot_minutes"].ToString();

            }
            

            
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from tblWeekEnd where TimetbaleType='" + comboBox1.SelectedItem.ToString() + "'";
            cm.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cm);
            dad.Fill(dta);
           
            foreach (DataRow drt in dta.Rows)
            {
                TimeTableType.Text = drt["TimetbaleType"].ToString();
              
                textBox1.Text = drt["TotalWorkingDays"].ToString();
                textBox2.Text = drt["TotalTimeSlot_hours"].ToString();
                textBox3.Text = drt["TotalTimeSlot_minutes"].ToString();

            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           SqlCommand cd = new SqlCommand("update tblWeekDay set TimetbaleType = @timetabletype,TotalWorkingDays = @totalworkingdays,TotalTimeSlot_hours = @hours,TotalTimeSlot_minutes = @minutes   where TimetbaleType='" + comboBox1.SelectedItem.ToString() + "' ", con);
            con.Open();
            
            cd.Parameters.AddWithValue("@timetabletype", TimeTableType.Text);
            cd.Parameters.AddWithValue("@totalworkingdays", textBox1.Text);
            cd.Parameters.AddWithValue("@hours", textBox2.Text);
            cd.Parameters.AddWithValue("@minutes", textBox3.Text);
            cd.ExecuteNonQuery();
            
            con.Close();
            SqlCommand cmd = new SqlCommand("update tblWeekEnd set TimetbaleType = @timetabletype,TotalWorkingDays = @totalworkingdays,TotalTimeSlot_hours = @hours,TotalTimeSlot_minutes = @minutes   where TimetbaleType='" + comboBox1.SelectedItem.ToString() + "' ", con);
            con.Open();

            cmd.Parameters.AddWithValue("@timetabletype", TimeTableType.Text);
            cmd.Parameters.AddWithValue("@totalworkingdays", textBox1.Text);
            cmd.Parameters.AddWithValue("@hours", textBox2.Text);
            cmd.Parameters.AddWithValue("@minutes", textBox3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully!");
            con.Close();
            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete tblWeekDay where TimetbaleType='" + comboBox1.SelectedItem.ToString() + "'", con);
            SqlCommand cm = new SqlCommand("delete tblWeekEnd where TimetbaleType='" + comboBox1.SelectedItem.ToString() + "'", con);
            con.Open();
            
            cmd.ExecuteNonQuery();
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
            ClearData();
        }
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.CheckState = CheckState.Unchecked;
        }
    }
}
