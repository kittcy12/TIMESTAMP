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
    public partial class Lock : Form
    {
        DB_Connector cons = new DB_Connector();
       
        public Lock()
        {
            InitializeComponent();
            TextBox ent = new TextBox();
        }


        private void Lock_Load(object sender, EventArgs e)
        {
            lblcheckpass.Hide();
            

        }
       
        private void txtusername_Click(object sender, EventArgs e)
        {
            lblcheckpass.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader data = null;
                string name;
                data = cons.getThatLogin(txtusername.Text, txtpassword.Text);

                if (data != null)
                {
                    MySqlDataReader locate = null;
                    locate = cons.getFile_Location("1");

                    if (locate != null)
                    {
                        MessageBox.Show("Welcome " + data["admin_name"].ToString() + "!!!");
                        name = data["admin_id"].ToString();
                        this.Hide();
                        Main_Form mains = new Main_Form(data);
                        mains.ShowDialog();
                    }
                    else
                    {

                        add_file_path add = new add_file_path(data["admin_name"].ToString());
                        add.ShowDialog();
                        Main_Form mains = new Main_Form(data);
                        mains.ShowDialog();
                        this.Hide();
                    }

                }
                else
                {
                    lblcheckpass.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
