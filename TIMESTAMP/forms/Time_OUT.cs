using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TIMESTAMP
{
    public partial class Time_OUT : Form
    {
        DB_Connector cons = new DB_Connector();
        Timer t = new Timer();
        string loc;
        public Time_OUT(string id)
        {
            InitializeComponent();
            lblguard.Text = id;
        }
        private void Time_OUT_Load(object sender, EventArgs e)
        {
            MySqlDataReader path = cons.getFile_Location("1");
            loc = path["file_location"].ToString();
            label6.Text = loc;
            //timer interval
            t.Interval = 1000; // 1 second

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }
        private void t_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            lbl_time.Text = clock;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.Gray;
            btnlogout.Text = "Verifying ID . ";
            //VERIFY ID
            MySqlDataReader read = null;
            read = cons.Verify_ID(txtbarcode.Text);
            if (read != null)
            {
                btnlogout.Text = "Logging out . . ";
                pictureBox1.BackgroundImage = Image.FromFile(loc + "\\" + txtbarcode.Text + ".jpg");
                txtname.Text = read["student_fname"].ToString() + " " + read["student_mname"].ToString() + " " + read["student_lname"].ToString();
                txtcourse.Text = read["student_course"].ToString();
                txtdept.Text = read["student_dept"].ToString();
                txtYS.Text = read["student_year"].ToString() + " - " + read["student_section"].ToString();
                cons.scan_out(txtbarcode.Text, DateTime.Now.ToString("HH" + ":" + "mm"), lblguard.Text);
                txtbarcode.Text = "";
                btnlogout.Text = "Logout";            }
            else 
            {
                lblinvalid.Show();
            }
            lblinvalid.Hide();
            btnlogout.BackColor = Color.Gray;
        }




    }
}
