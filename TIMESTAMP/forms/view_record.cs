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
    public partial class view_record : Form
    {
        DB_Connector cons = new DB_Connector();
        public view_record()
        {

            InitializeComponent();

        }

        private void view_record_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            MySqlDataReader search = null;
            search = cons.View_Record(txtstud_id.Text);



        }
    }
}
