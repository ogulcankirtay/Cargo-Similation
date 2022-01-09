using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace harita
{

    public partial class harita : Form
    {

        private List<PointLatLng> points;


        public harita()
        {
            InitializeComponent();
            points = new List<PointLatLng>();

            points = new List<PointLatLng>();
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(40.766666, 29.916668);//Kocaeli
            //map.Position = new PointLatLng(-25.974134, 32.593042);
            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.Zoom = 20; // baslangic zoomu
        }



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

        private void txt_long_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_lat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            //points.Add(new PointLatLng(Convert.ToDouble(txt_lat.Text), Convert.ToDouble(txt_long.Text)));
        }

        private void clear_Click(object sender, EventArgs e)
        {
            points.Clear();
        }

        private void yol_Click(object sender, EventArgs e)
        {
            GoogleMapProvider.Instance.ApiKey = "AIzaSyA6ndV-9Dz8ylPrpLFBrcZOOZJuUboIX5E";
            /*
            var rota = GoogleMapProvider.Instance.GetRoute(points[0], points[1], false, false, 14);
            var r = new GMapRoute(rota.Points, "Benim Rotam");

            var rotalar = new GMapOverlay("rotalar");
            rotalar.Routes.Add(r);
            map.Overlays.Add(rotalar);
            Console.WriteLine(points[0]);
            map.MapProvider = GMapProviders.GoogleMap;
            string a = "" + rota.Distance;
            Console.WriteLine(a);


            map.Zoom--;
            map.Zoom++;*/

            //rota.Stroke = new Pen(Color.Red);

            //a.Distanece.Text() = rota.Distance + "km";

            
            MapRoute rota;
            GMapRoute r;
            GMapOverlay rotalar;
            for (int i = 0; i < (points.Count-1); i++)
            {
                if ( points[i] != null)
                {
                    rota = GoogleMapProvider.Instance
                    .GetRoute( points[i],  points[i + 1], false, false, 14);
                    r = new GMapRoute(rota.Points, "My Route")
                    {
                        Stroke = new Pen(Color.Red, 5)
                    };

                    rotalar = new GMapOverlay("rotalar");
                    rotalar.Routes.Add(r);
                    map.Overlays.Add(rotalar);
                    map.Zoom--;
                    map.Zoom++;
                }
            }
            






        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //daş düşebilü
            }
        }

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //MessageBox.Show(e.X + " " + e.Y);
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


            }
        }

    }
}