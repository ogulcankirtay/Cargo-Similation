using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace harita
{

    public partial class harita : Form
    {
        MySqlConnection MyCon;
        double[,] a = new double[11, 11];

        int[] visited = new int[10];
        int al, b, u, v, i, j, ne = 1;
        double min, mincost = 0;
        double noktaX;
        double noktaY;
        GMapRoute r;
        GMapOverlay rotalar;
        private List<PointLatLng> points;
        public List<PointLatLng> DbPoints;

        

        MapRoute rota;
        public harita()
        {
            InitializeComponent();
            points = new List<PointLatLng>();
            //DbPoints = new List<PointLatLng>();

            GoogleMapProvider.Instance.ApiKey = "AIzaSyBsXlKdJSNqOR72p8OnAqMVMcMRPzi1v6o";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(40.766666, 29.916668);//Kocaeli

            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.Zoom = 20; // baslangic zoomu
            noktaX = 40.82198;
            noktaY = 29.92368;
            var point = (new PointLatLng(noktaX, noktaY));
            points.Add(new PointLatLng(Convert.ToDouble(noktaX), Convert.ToDouble(noktaY)));
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_small);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

            
     


            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Port = 3306;
            conn_string.UserID = "root";
            conn_string.Password = "123456";
            conn_string.Database = "KARGO_Dagitim_Db";
            MyCon = new MySqlConnection(conn_string.ToString());


            //VERİ TABANI  

            try
            {
                MyCon.Open();


               
                string qry = "SELECT * FROM KARGO_Dagitim_Db.Musteri ;";

                MySqlCommand MyComand2 = new MySqlCommand(qry, MyCon);
                MySqlDataReader myreader;

                myreader = MyComand2.ExecuteReader();

                while (myreader.Read())
                {
                    double locX= Convert.ToDouble(myreader.GetString("MüsteriLokasyonX"));
                    double locY=Convert.ToDouble(myreader.GetString("MüsteriLokasyonY"));

                    points.Add(new PointLatLng(Convert.ToDouble(locX), Convert.ToDouble(locY)));



                    var point2 = (new PointLatLng(locX, locY));
                    var markers2 = new GMapOverlay("markers");
                    var marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.red_small);
                    markers.Markers.Add(marker2);
                    map.Overlays.Add(markers2);





                }
                MyCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            //VERİ TABANI


        }
        public string username;


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_map_Click(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txt_lat.Text);
            double longt = Convert.ToDouble(txt_long.Text);
            map.Position = new PointLatLng(lat, longt);
            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.Zoom = 10; // baslangic zoomu

            PointLatLng point = new PointLatLng(lat, longt);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);

            map.Overlays.Add(markers);



        }


        private void btnAddPoint_Click(object sender, EventArgs e)
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

                    m_id = Convert.ToInt32(myreader.GetString("MüsteriID"));
                }
                MyCon.Close();

                MyCon.Open();


                string qry = "update  kargo_dagitim_db.musteri set MüsteriLokasyonX='" + txt_lat.Text.ToString().Replace(",", ".") + "', MüsteriLokasyonY='" +txt_long.Text.ToString().Replace(",", ".") + "' where MüsteriID='" + m_id + "';";
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

        private void clear_Click(object sender, EventArgs e)
        {
            rotalar.Routes.Remove(r);
            map.Overlays.Remove(rotalar);
            
        }

        private void yol_Click(object sender, EventArgs e)
        {
            //login.harita1 h = new login.harita1();
            //h.ShowDialog();
            kısayol();
        }

   

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;
                points.Add(new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng)));
                txt_lat.Text = lat + "";
                txt_long.Text = lng + "";
                // load location
                map.Position = point;
                //Adding marker
                var markers = new GMapOverlay("markers");
                var marker = new GMarkerGoogle(point, GMarkerGoogleType.red_small);
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);
                // veri tabanı
                login.Form1 a = new login.Form1();
                Console.WriteLine(username);

                try
                {
                    MyCon.Open();
                    int m_id = 0;
                    string qryara = "SELECT * FROM KARGO_Dagitim_Db.Musteri where username='"+username+"';";
                    MySqlCommand MyComand2 = new MySqlCommand(qryara, MyCon);
                    MySqlDataReader myreader;

                    myreader = MyComand2.ExecuteReader();
                    while (myreader.Read())
                    {

                        m_id = Convert.ToInt32(myreader.GetString("MüsteriID")) ;
                    }
                    MyCon.Close();

                    MyCon.Open();
                    
                   
                    string qry = "update  kargo_dagitim_db.musteri set MüsteriLokasyonX='" + lat.ToString().Replace(",", ".") + "', MüsteriLokasyonY='" + lng.ToString().Replace(",", ".") + "' where MüsteriID='" + m_id+"';";
                    Console.WriteLine(qry);
                    MySqlCommand MyComand = new MySqlCommand(qry, MyCon);
                    myreader = MyComand.ExecuteReader();
                    MyCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
                //veri tabanı



            }
        }
            public void kısayol() {
                u = 0;
                v = 0;
                al = 0;
                b = 0;


                for (i = 0; i < points.ToArray().Length; i++)
                {
                    for (j = 0; j < points.ToArray().Length; j++)
                    {
                        a[i, j] = Math.Pow(Math.Pow(Convert.ToDouble(points[j].Lat) - Convert.ToDouble(points[i].Lat), 2) + Math.Pow(Convert.ToDouble(points[j].Lng) - Convert.ToDouble(points[i].Lng), 2), 0.5);

                    }
                }

                for (i = 0; i < points.ToArray().Length; i++)
                {
                    visited[i] = 0;
                }
                for (i = 0; i < points.ToArray().Length; i++)

                    for (j = 0; j < points.ToArray().Length; j++)

                    {



                        if (a[i, j] == 0)

                            a[i, j] = int.MaxValue;

                    }

                visited[0] = 1;

                Console.WriteLine("\n");

                while (ne < points.ToArray().Length)

                {

                    for (i = 0, min = int.MaxValue; i < points.ToArray().Length; i++)

                        for (j = 0; j < points.ToArray().Length; j++)

                            if (a[i, j] < min)

                                if (visited[i] != 0)
                                {

                                    min = a[i, j];

                                    al = u = i;

                                    b = v = j;

                                }


                    if (visited[u] == 0 || visited[v] == 0)

                    {
                        Console.WriteLine("\n Edge " + (ne++) + ":(" + al + " " + b + ") cost:" + min);

                       

                        for (int i = 0; i < (points.Count - 1); i++)
                        {
                            if (points[i] != null)
                            {
                                rota = GoogleMapProvider.Instance
                                .GetRoute(points[al], points[b], false, false, 14);
                                r = new GMapRoute(rota.Points, "My Route")
                                {
                                    Stroke = new Pen(Color.Red, 5)

                                };

                                rotalar = new GMapOverlay("rotalar");
                                rotalar.Routes.Add(r);
                                map.Overlays.Add(rotalar);
                                map.ZoomAndCenterRoutes(null);
                                

                            }
                        }

                      



                        mincost += min;

                        visited[b] = 1;

                    }

                    a[al, b] = a[b, al] = int.MaxValue;

                }

                Console.WriteLine("\n Minimun cost=" + mincost);
                ne = 1;

            }
        }

    } 