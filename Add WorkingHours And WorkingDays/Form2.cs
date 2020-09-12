using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_WorkingHours_And_WorkingDays
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnWeekday_Click(object sender, EventArgs e)
        {
            WeekDay weekday = new WeekDay();
            weekday.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(weekday);
            weekday.Show();
        }

        private void btnWeekend_Click(object sender, EventArgs e)
        {
            WeekEnd weekend = new WeekEnd();
            weekend.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(weekend);
            weekend.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_And_Update_WHrs_And_WDys ed1 = new Edit_And_Update_WHrs_And_WDys();
            ed1.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(ed1);
            ed1.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(view);
            view.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
