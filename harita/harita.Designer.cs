
namespace harita
{
    partial class harita
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_long = new System.Windows.Forms.TextBox();
            this.button_map = new System.Windows.Forms.Button();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Btn_rota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(604, 532);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "latitude";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_lat
            // 
            this.txt_lat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_lat.Location = new System.Drawing.Point(820, 108);
            this.txt_lat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_lat.Name = "txt_lat";
            this.txt_lat.Size = new System.Drawing.Size(100, 22);
            this.txt_lat.TabIndex = 3;
            this.txt_lat.TextChanged += new System.EventHandler(this.txt_lat_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "longitude";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_long
            // 
            this.txt_long.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_long.Location = new System.Drawing.Point(820, 199);
            this.txt_long.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_long.Name = "txt_long";
            this.txt_long.Size = new System.Drawing.Size(100, 22);
            this.txt_long.TabIndex = 5;
            this.txt_long.TextChanged += new System.EventHandler(this.txt_long_TextChanged);
            // 
            // button_map
            // 
            this.button_map.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_map.Location = new System.Drawing.Point(845, 246);
            this.button_map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_map.Name = "button_map";
            this.button_map.Size = new System.Drawing.Size(101, 38);
            this.button_map.TabIndex = 6;
            this.button_map.Text = "load";
            this.button_map.UseVisualStyleBackColor = true;
            this.button_map.Click += new System.EventHandler(this.button_map_Click);
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(15, 14);
            this.map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(565, 507);
            this.map.TabIndex = 7;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            this.map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseDoubleClick);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPoint.Location = new System.Drawing.Point(627, 89);
            this.btnAddPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(115, 42);
            this.btnAddPoint.TabIndex = 8;
            this.btnAddPoint.Text = "ekleme butonu";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Location = new System.Drawing.Point(641, 185);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(101, 38);
            this.clear.TabIndex = 9;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Btn_rota
            // 
            this.Btn_rota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_rota.Location = new System.Drawing.Point(641, 260);
            this.Btn_rota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_rota.Name = "Btn_rota";
            this.Btn_rota.Size = new System.Drawing.Size(101, 38);
            this.Btn_rota.TabIndex = 10;
            this.Btn_rota.Text = "yol";
            this.Btn_rota.UseVisualStyleBackColor = true;
            this.Btn_rota.Click += new System.EventHandler(this.yol_Click);
            // 
            // harita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 532);
            this.Controls.Add(this.Btn_rota);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.map);
            this.Controls.Add(this.button_map);
            this.Controls.Add(this.txt_long);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "harita";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_long;
        private System.Windows.Forms.Button button_map;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Btn_rota;
    }
}

