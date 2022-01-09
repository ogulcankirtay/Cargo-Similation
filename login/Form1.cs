using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class Form1 : Form
    {
        MySqlConnection MyCon;
        public string username;
        
        public Form1()
        {
            
            InitializeComponent();
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Port = 3306;
            conn_string.UserID = "root";
            conn_string.Password = "123456";
            conn_string.Database = "KARGO_Dagitim_Db";
            MyCon = new MySqlConnection(conn_string.ToString());
            username="saaaaaaaaaaaaaaaa"+txt_username.Text;
            Console.WriteLine(txt_username.Text);
            Console.WriteLine(username);
            username = txt_username.Text;
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {         
            try
            {
                MyCon.Open();
                
                
                // string qry = "INSERT INTO KARGO_Dagitim_Db.Musteri(MüsteriID,KargoID,MüsteriAdi,MüsteriLokasyonX,MüsteriLokasyonY)VALUES ('1','1','1','1','1');";
                string qry = "SELECT * FROM KARGO_Dagitim_Db.Musteri Where KARGO_Dagitim_Db.Musteri.username='" + txt_username.Text + "';";
               
                MySqlCommand MyComand2 = new MySqlCommand(qry, MyCon);
                MySqlDataReader myreader;

                myreader = MyComand2.ExecuteReader();
                
                while (myreader.Read())
                {
                    if (txt_username.Text != null & txt_pasword.Text != null)
                    {


                        if (txt_username.Text.ToString().Equals(myreader.GetString("username")) & txt_pasword.Text.ToString().Equals(myreader.GetString("psw")))
                        {
                            username = "" + txt_username.Text;
                            label1.Text = ""+username;
                            harita.harita hrt = new harita.harita();
                            hrt.username = ""+txt_username.Text;
                            hrt.ShowDialog();
                            // this.Hide();
                            
                        }
                       
                      
                    }
                    
                }
                MyCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }


        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void s_dgstr_Click(object sender, EventArgs e)
        {
            try
            {
                MyCon.Open();
                int m_id = 0;
                string qryara = "SELECT * FROM KARGO_Dagitim_Db.Musteri where username='"+txt_username.Text+"';";
                MySqlCommand MyComand2 = new MySqlCommand(qryara, MyCon);
                MySqlDataReader myreader;

                myreader = MyComand2.ExecuteReader();
                while (myreader.Read())
                {

                    m_id = Convert.ToInt32(myreader.GetString("MüsteriID"));
                }
              
                MyCon.Close();
                string qry= "UPDATE KARGO_Dagitim_Db.Musteri SET  psw='" + txt_newpsw.Text+ "' WHERE MüsteriID='" + m_id+"';";
                Console.WriteLine(qry);
                MySqlCommand MyCommand2 = new MySqlCommand(qry, MyCon);
                MySqlDataReader MyReader2;
                MyCon.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void kayit_Click(object sender, EventArgs e)
        {
            try
            {
                MyCon.Open();
                int m_id=0;
                string qryara = "SELECT * FROM KARGO_Dagitim_Db.Musteri;";
                MySqlCommand MyComand2 = new MySqlCommand(qryara, MyCon);
                MySqlDataReader myreader;
                
                myreader = MyComand2.ExecuteReader();
                while(myreader.Read())
                {
                    
                  m_id= Convert.ToInt32(myreader.GetString("MüsteriID"))+1;
                }
                MyCon.Close();

                MyCon.Open();
                string qry = "INSERT INTO KARGO_Dagitim_Db.Musteri(MüsteriID,KargoID,MüsteriAdi,MüsteriLokasyonX,MüsteriLokasyonY,username,psw)VALUES ('"+m_id+ "','0','" + txt_madi.Text + "','1','1','" + txt_username.Text+"','"+txt_pasword.Text+"');";
                Console.WriteLine(qry);
                MySqlCommand MyComand = new MySqlCommand(qry, MyCon);
                myreader = MyComand.ExecuteReader();
                MyCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 a = new Form2();
                a.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

     
    }
    
}
