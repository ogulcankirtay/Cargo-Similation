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
    public partial class Form2 : Form
    {
        MySqlConnection MyCon;
        public Form2()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Port = 3306;
            conn_string.UserID = "root";
            conn_string.Password = "123456";
            conn_string.Database = "KARGO_Dagitim_Db";
            MyCon = new MySqlConnection(conn_string.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                MyCon.Open();
                string qry = "SELECT * FROM KARGO_Dagitim_Db.Musteri;";
                MySqlCommand MyComand2 = new MySqlCommand(qry, MyCon);
                MySqlDataReader myreader;

                myreader = MyComand2.ExecuteReader();
                if (listView1.Columns != null) {
                    listView1.Items.Clear();
                }
                 while (myreader.Read())
                 {

                    Console.WriteLine(myreader.GetString("MüsteriAdi") + " " + myreader.GetString("MüsteriLokasyonX") + " " + myreader.GetString("MüsteriLokasyonY"));
                    
                    string[] bilgiler = { myreader.GetString("MüsteriAdi"), myreader.GetString("MüsteriLokasyonX"), myreader.GetString("MüsteriLokasyonY") };
                    listView1.Items.Add(new ListViewItem(bilgiler));
                   
                }
                MyCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MyCon.Open();
                int m_id = 0;
                string qryara = "SELECT * FROM KARGO_Dagitim_Db.Musteri;";
                MySqlCommand MyComand2 = new MySqlCommand(qryara, MyCon);
                MySqlDataReader myreader;

                myreader = MyComand2.ExecuteReader();
                while (myreader.Read())
                {

                    m_id = Convert.ToInt32(myreader.GetString("MüsteriID")) + 1;
                }
                MyCon.Close();

                MyCon.Open();
                string qry = "INSERT INTO KARGO_Dagitim_Db.Musteri(MüsteriID,KargoID,MüsteriAdi,MüsteriLokasyonX,MüsteriLokasyonY,username,psw)VALUES ('" + m_id + "','0','" + ad.Text + "','"+textBoxlat.Text.Replace(",",".")+"','"+textBoxlng.Text.Replace(",",".")+"','" + "admin"+m_id + "','" +"1" + "');";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MyCon.Open();


                // string qry = "INSERT INTO KARGO_Dagitim_Db.Musteri(MüsteriID,KargoID,MüsteriAdi,MüsteriLokasyonX,MüsteriLokasyonY)VALUES ('1','1','1','1','1');";
                string qry = "delete  from kargo_dagitim_db.musteri where MüsteriAdi='" + ad.Text + "';";
                Console.WriteLine(qry);
                MySqlCommand MyComand2 = new MySqlCommand(qry, MyCon);
                MySqlDataReader myreader;

                myreader = MyComand2.ExecuteReader();
                while (myreader.Read()) { }
                MyCon.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
