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
    public partial class add_role : Form
    {
        DB_Connector cons = new DB_Connector();
        public add_role()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           DialogResult d;
            d = MessageBox.Show("Are you sure you want to save?","ADMIN", MessageBoxButtons.YesNo, MessageBoxIcon.Information);      
            if ( d == DialogResult.Yes)
            {
                cons.add_roles(txtname.Text, txtusername.Text, txtpass.Text, cmbrole.Text);
                MessageBox.Show("SAVED!!", "ADMIN");

            }

        }

        private void add_role_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
