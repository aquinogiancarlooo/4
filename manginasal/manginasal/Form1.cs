using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
namespace manginasal
{
    public partial class Form1 : Form
    {
         public String urole = "";
        string mycon = "datasource = localhost; Database= dbkiosk;username=root";
        homepagecs hp = new homepagecs();
        dbcon dc = new dbcon();
    
        public void getuserrole(){
        
         try{
         
           string query = "select userrole from tbadmin where username = '" + username.Text + "'and password = '" + password.Text +"'";
           MySqlConnection Myconn = new MySqlConnection(mycon);
           MySqlCommand command = new MySqlCommand(query, Myconn);
             Myconn.Open();
             MySqlDataReader reader = command.ExecuteReader();

         
             while(reader.Read()){
             urole = reader.GetString("userrole");
             
             }
         
         }catch (Exception ex)
         {
         MessageBox.Show(ex.Message);
         }
        }


        public Form1()
        {
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void LOGIN_Click(object sender, EventArgs e)
        {
                if (username.Text.Equals("") || password.Text.Equals(""))
            {

                MessageBox.Show("Do not leave blank fields");

            }
            else
                {
                dc.connect();
                dc.cmd = new MySqlCommand("Select * from tbadmin where username = @username and password = @password", dc.con);
                dc.cmd.Parameters.Add(new MySqlParameter("username", username.Text));
                dc.cmd.Parameters.Add(new MySqlParameter("password", password.Text));

                dc.dr = dc.cmd.ExecuteReader();
                if(dc.dr.Read()){
                    MessageBox.Show("Welcome", "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getuserrole();

                
                    if (urole.Equals("admin"))
                    {
                         hp.inventory.Enabled = false;
                         hp.records.Enabled = false;
                         hp.sales.Enabled = false;
                         hp.queing.Enabled = false;

                    }
                    else if (urole.Equals("manager"))
                    {
                        hp.admin.Enabled = false;
                        hp.queing.Enabled = false;

                    }
                    else if (urole.Equals("cashier"))
                    {
                        hp.admin.Enabled = false;
                        hp.sales.Enabled = false;
                        hp.inventory.Enabled = false;


                    }
                        
                    this.Hide();
                    hp.Show();

                  }
                else{
                        MessageBox.Show("Invalid Username or PAssword", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                dc.Disconnect();





                }

            
            
            
            }
        }
    }

