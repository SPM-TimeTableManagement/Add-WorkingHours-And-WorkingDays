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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {
            
        }
        private void GetWorkingDaysAndHours()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-J09JS6JN;Initial Catalog=WHoursAndWDays;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from tblWeekEnd where TimetbaleType = '" + comboBox1.SelectedItem.ToString() + "'", con);
            SqlCommand cm = new SqlCommand("Select * from tblWeekDay where TimetbaleType = '" + comboBox1.SelectedItem.ToString() + "'", con);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter dad = new SqlDataAdapter();

            da.SelectCommand = cmd;
            dad.SelectCommand = cm;

            DataTable dt = new DataTable();
           

            da.Fill(dt);
            dad.Fill(dt);

            DataGridView.DataSource = dt;
           

            con.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetWorkingDaysAndHours();
        }
    }
}
