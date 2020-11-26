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
    public partial class Main_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        MySqlDataReader admindata;
        DB_Connector cons = new DB_Connector();
        string roles;
        string id;
        public Main_Form( MySqlDataReader data)
        {

            InitializeComponent();
            StartTimer();

            //fetching admin_id
            admindata = data;
            
        }

 System.Windows.Forms.Timer timer1 = null;
        private void StartTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //txtServerDateTime.Caption = "Server Date & Time: " + DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString();
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void btnscan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            //Main_Form mains = new Main_Form(null);
            scanform scan = new scanform(id);
            scan.ShowDialog();

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutProgram about = new AboutProgram();
            about.ShowDialog();
        }

        private void record_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            view_record opens = new view_record();
            opens.ShowDialog();
           
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            id = admindata["admin_id"].ToString();
            roles = admindata["admin_role"].ToString();

            if ( roles == "admin")
            {
                adminpage.Visible = true;
            }

            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Main_Form mainform = new Main_Form(null);
            Time_OUT scan = new Time_OUT(id);
            scan.ShowDialog();
            mainform.Close();
     
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add_role clicks = new add_role();
            clicks.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Close();
            this.Hide();
            Lock logout = new Lock();
            logout.ShowDialog();
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}
