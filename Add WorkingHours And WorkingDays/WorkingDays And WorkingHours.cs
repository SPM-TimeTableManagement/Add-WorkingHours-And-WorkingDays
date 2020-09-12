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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWeekend_Click(object sender, EventArgs e)
        {
          /*  WeekEnd weekend = new WeekEnd();
            weekend.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(weekend);
            weekend.Show();*/
        }

        private void btnWeekday_Click(object sender, EventArgs e)
        {
          /*  WeekDay weekday = new WeekDay();
            weekday.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(weekday);
            weekday.Show();*/
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*Edit_And_Update_WHrs_And_WDys ed1 = new Edit_And_Update_WHrs_And_WDys();
            ed1.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(ed1);
            ed1.Show();*/
        }

        private void btnView_Click(object sender, EventArgs e)
        {/*
            View view = new View();
            view.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(view);
            view.Show();*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnwrk_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            panelnav.Controls.Clear();
            panelnav.Controls.Add(f2);
            f2.Show();
        }

        private void navpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
