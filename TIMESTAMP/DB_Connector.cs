using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TIMESTAMP
{
    public class DB_Connector
    {
        public MySqlConnection getConnection()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;database=bisu_time_stamp;uid=root;pwd=03231979"))
            {
                try
                {
                    con.Open();
                    return con;
                }
                catch
                {
                    return null;
                }
            }
        }



        public MySqlDataReader getThatLogin(string user, string passw)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String querry = "SELECT *  FROM `admin` WHERE `admin_user` = '" + user + "' AND `admin_password` = '" + passw + "'";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    MySqlDataReader read = null;
                    read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        return read;
                    }
                    else
                    {
                        return null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public MySqlDataReader getFile_Location(string id)
        {
     
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String locate = "SELECT *  FROM `file_path` WHERE `file_id` = '" + id + "' AND `file_location` != '" + null + "'";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(locate, con);
                    MySqlDataReader read = null;
                    read = cmd.ExecuteReader();
                    if (read.Read())
                    {return read;}
                    else
                    { return null;}

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

  public void save_path(string path)
        {
            using (getConnection())
            {
                try
                {
                    MessageBox.Show("FILE PATH: " + path);
                    MySqlConnection cons = getConnection();
                   String save = "UPDATE `bisu_time_stamp`.`file_path` SET `file_location` = '" + path +"' WHERE `file_id` = 1 ";
                   // String save = "UPDATE `bisu_time_stamp`.`file_path` SET `file_location` = '" + path + "' WHERE `file_id` = 1 ";
                    MySqlCommand cmds = new MySqlCommand(save, cons);
                    cons.Open();
                    cmds.ExecuteNonQuery();
                    cons.Close();

                }
                catch { }
            }

        }
        public MySqlDataReader Get_ID(string admin_id)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String querry = "SELECT *  FROM `admin` WHERE `admin_id` = '" + admin_id +  "'";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    MySqlDataReader read = null;
                    read = cmd.ExecuteReader();
                    if (read.Read())
                    {return read;}
                    else
                    {return null;}
                }
                catch (Exception ex)
                {MessageBox.Show(ex.Message);
                    return null;}}
        }
        public MySqlDataReader View_Record(string id)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String querry = "SELECT *  FROM `student_log` WHERE `student_id` = '" + id + "'";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    MySqlDataReader read = null;
                    read = cmd.ExecuteReader();
                    if (read.Read())
                    { return read; }
                    else
                    { return null; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public MySqlDataReader Verify_ID(string id)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String querry = "SELECT * FROM `student_list` WHERE `student_id` = '" + id + "'";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    MySqlDataReader read = null;
                    read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        return read;
                    }
                    else
                    {
                        return null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public MySqlDataReader chkstatus(string id, int stat)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    String chkstat = "SELECT *  FROM `student_list` WHERE `student_id` = '" + id + "' AND `log_status` = '" + stat +"'";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(chkstat, con);
                    MySqlDataReader read = null;
                    read = cmd.ExecuteReader();
                    if (read.Read())
                    {return read;}
                    else
                    { return null;}

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }

        }
        public void add_roles(string name, string user, string pass, string role)
        {
            using (getConnection())
            {
                try
                {
                    
                        MySqlConnection cons = getConnection();
                        String querries = "INSERT INTO `bisu_time_stamp`.`admin` (`admin_id`, `admin_name`, `admin_user`, `admin_password`, `admin_role`) VALUES (' ' ,'" + name + "', '" + user + "', '" + pass + "' , '" + role + "');";
                        MySqlCommand cmds = new MySqlCommand(querries, cons);
                        cons.Open();
                        cmds.ExecuteNonQuery();
                        cons.Close();
                      
                    


                }
                catch { }
            }

        }

       public void scan_in(string id, string time_in, string time_out,string guard_id)
        {
            using (getConnection())
            {
                try
                {
                        MySqlDataReader stats = null;
                        stats = chkstatus(id, 0);
                        if (stats != null)
                        {
                            MySqlConnection cons = getConnection();
                            String querries = "INSERT INTO `bisu_time_stamp`.`student_log` (`log_no`, `student_id`, `log_in`, `log_out`, `log_date`, `log_guard_id_in`, `log_guard_id_out`) VALUES (' ' ," + id + ", '" + time_in + "', '" + time_out + "', '" + DateTime.Now.ToString("MMM d, yyyy") + "', '" + guard_id + "' , '" + null + "');";
                            MySqlCommand cmds = new MySqlCommand(querries, cons);
                            cons.Open();
                            update_status(1, id);
                            cmds.ExecuteNonQuery();
                            cons.Close();
                        }
                        else {MessageBox.Show("LOGGED IN TWICE!");}
                        

                }
                catch{}
            }
           
            }
       public void scan_out(string id, string time_out, string guard_id)
       {
           using (getConnection())
           {
               try
               {

                   MySqlDataReader stats = null;
                   stats = chkstatus(id, 1);
                       if (stats!= null)
                       {
                           MySqlConnection cons = getConnection();
                           String upd_out = "UPDATE `bisu_time_stamp`.`student_log` SET `log_out` = '" + time_out + "', `log_guard_id_out` = '" + guard_id +"' WHERE `student_id` = '" + id + "' AND `log_out` = '" + null + "'";
                           MySqlCommand updte = new MySqlCommand(upd_out, cons);
                           cons.Open();
                           update_status(0, id);
                           updte.ExecuteNonQuery();
                           cons.Close();
                       }
                       else
                       { MessageBox.Show("NOT YET LOGGED IN!");}

                   
               }
               catch { }
 
           }
       }

       public void update_status(int stats, string id)
                {
                    using (getConnection())
                    {
                        try
                        {
                            MySqlConnection cons = getConnection();
                            String upd_status = "UPDATE `bisu_time_stamp`.`student_list` SET `log_status` = '"+stats+"' WHERE `student_id` = '" + id + "'";
                            MySqlCommand updte = new MySqlCommand(upd_status, cons);
                            cons.Open();
                            updte.ExecuteNonQuery();
                            cons.Close();
                        }
                        catch { }
                    }
                }
        }


    }
