using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIMESTAMP
{
    public partial class add_file_path : Form
    {
        DB_Connector cons = new DB_Connector();
        string admin_name;
        public add_file_path(string name)
        {
            
            InitializeComponent();
           
            this.admin_name = name;
        }

        private void add_file_path_Load(object sender, EventArgs e)
        {

            lbl_instruction.Text = "Hello! " + admin_name + " Please select the file path of the student's photos!";
        }



        private void btnopen_Click(object sender, EventArgs e)
        {
         
            if (btnopen.Text == "Open")
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowserDialog1.SelectedPath;
                    path = path.Replace(@"\", @"\\");
                    txtpath.Text = path;
                    //txtpath.Text = folderBrowserDialog1.SelectedPath;
                   
                    btnopen.Text = "Save";
                }
            }
            else
            {
                string path = folderBrowserDialog1.SelectedPath;
                path = path.Replace(@"\", @"\\");
                cons.save_path(path);
                this.Close();
            }
           
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }
    }
}
