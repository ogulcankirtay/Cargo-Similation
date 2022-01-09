
namespace login
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lbllng = new System.Windows.Forms.Label();
            this.latlbl = new System.Windows.Forms.Label();
            this.textBoxlng = new System.Windows.Forms.TextBox();
            this.textBoxlat = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.Görüntüle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MüsteriAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MüsteriLokasyonX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MüsteriLokasyonY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.DarkGreen;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lbllng);
            this.splitContainer1.Panel2.Controls.Add(this.latlbl);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxlng);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxlat);
            this.splitContainer1.Panel2.Controls.Add(this.ad);
            this.splitContainer1.Panel2.Controls.Add(this.sil);
            this.splitContainer1.Panel2.Controls.Add(this.ekle);
            this.splitContainer1.Panel2.Controls.Add(this.Görüntüle);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(933, 549);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "AD";
            // 
            // lbllng
            // 
            this.lbllng.AutoSize = true;
            this.lbllng.Location = new System.Drawing.Point(11, 396);
            this.lbllng.Name = "lbllng";
            this.lbllng.Size = new System.Drawing.Size(27, 17);
            this.lbllng.TabIndex = 8;
            this.lbllng.Text = "lng";
            // 
            // latlbl
            // 
            this.latlbl.AutoSize = true;
            this.latlbl.Location = new System.Drawing.Point(11, 327);
            this.latlbl.Name = "latlbl";
            this.latlbl.Size = new System.Drawing.Size(23, 17);
            this.latlbl.TabIndex = 7;
            this.latlbl.Text = "lat";
            // 
            // textBoxlng
            // 
            this.textBoxlng.Location = new System.Drawing.Point(63, 377);
            this.textBoxlng.Multiline = true;
            this.textBoxlng.Name = "textBoxlng";
            this.textBoxlng.Size = new System.Drawing.Size(109, 36);
            this.textBoxlng.TabIndex = 6;
            // 
            // textBoxlat
            // 
            this.textBoxlat.Location = new System.Drawing.Point(63, 324);
            this.textBoxlat.Multiline = true;
            this.textBoxlat.Name = "textBoxlat";
            this.textBoxlat.Size = new System.Drawing.Size(109, 36);
            this.textBoxlat.TabIndex = 5;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(63, 262);
            this.ad.Multiline = true;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(109, 36);
            this.ad.TabIndex = 4;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(351, 439);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(99, 23);
            this.sil.TabIndex = 3;
            this.sil.Text = "sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.button3_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(73, 439);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(99, 23);
            this.ekle.TabIndex = 2;
            this.ekle.Text = "ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // Görüntüle
            // 
            this.Görüntüle.Location = new System.Drawing.Point(216, 439);
            this.Görüntüle.Name = "Görüntüle";
            this.Görüntüle.Size = new System.Drawing.Size(99, 23);
            this.Görüntüle.TabIndex = 1;
            this.Görüntüle.Text = "Görüntüle";
            this.Görüntüle.UseVisualStyleBackColor = true;
            this.Görüntüle.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MüsteriAdi,
            this.MüsteriLokasyonX,
            this.MüsteriLokasyonY});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(63, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(465, 138);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MüsteriAdi
            // 
            this.MüsteriAdi.Text = "MüsteriAdi";
            this.MüsteriAdi.Width = 129;
            // 
            // MüsteriLokasyonX
            // 
            this.MüsteriLokasyonX.Text = "MüsteriLokasyonX";
            this.MüsteriLokasyonX.Width = 140;
            // 
            // MüsteriLokasyonY
            // 
            this.MüsteriLokasyonY.Text = "MüsteriLokasyonY";
            this.MüsteriLokasyonY.Width = 147;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 549);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Görüntüle;
        private System.Windows.Forms.ColumnHeader MüsteriAdi;
        private System.Windows.Forms.ColumnHeader MüsteriLokasyonX;
        private System.Windows.Forms.ColumnHeader MüsteriLokasyonY;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label lbllng;
        private System.Windows.Forms.Label latlbl;
        private System.Windows.Forms.TextBox textBoxlng;
        private System.Windows.Forms.TextBox textBoxlat;
        private System.Windows.Forms.Label label1;
    }
}