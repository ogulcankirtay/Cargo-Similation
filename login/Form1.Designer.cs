
namespace login
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.kargo_takip_buton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_newpsw = new System.Windows.Forms.TextBox();
            this.txt_madi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kayit = new System.Windows.Forms.Button();
            this.s_dgstr = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.Label();
            this.txt_pasword = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.splitContainer1.Panel1.Controls.Add(this.kargo_takip_buton);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_newpsw);
            this.splitContainer1.Panel1.Controls.Add(this.txt_madi);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.kayit);
            this.splitContainer1.Panel1.Controls.Add(this.s_dgstr);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.user);
            this.splitContainer1.Panel1.Controls.Add(this.txt_pasword);
            this.splitContainer1.Panel1.Controls.Add(this.txt_username);
            this.splitContainer1.Panel1.Controls.Add(this.login);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1371, 750);
            this.splitContainer1.SplitterDistance = 456;
            this.splitContainer1.TabIndex = 0;
            // 
            // kargo_takip_buton
            // 
            this.kargo_takip_buton.BackColor = System.Drawing.SystemColors.Info;
            this.kargo_takip_buton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.kargo_takip_buton.ForeColor = System.Drawing.Color.Orange;
            this.kargo_takip_buton.Location = new System.Drawing.Point(265, 543);
            this.kargo_takip_buton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kargo_takip_buton.Name = "kargo_takip_buton";
            this.kargo_takip_buton.Size = new System.Drawing.Size(145, 36);
            this.kargo_takip_buton.TabIndex = 13;
            this.kargo_takip_buton.Text = "Kargo Takip";
            this.kargo_takip_buton.UseVisualStyleBackColor = false;
            this.kargo_takip_buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 306);
            this.label3.MinimumSize = new System.Drawing.Size(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "MüsteriAdi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 240);
            this.label2.MinimumSize = new System.Drawing.Size(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "YENİ ŞİFRE";
            // 
            // txt_newpsw
            // 
            this.txt_newpsw.BackColor = System.Drawing.SystemColors.Info;
            this.txt_newpsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newpsw.Location = new System.Drawing.Point(240, 219);
            this.txt_newpsw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_newpsw.Multiline = true;
            this.txt_newpsw.Name = "txt_newpsw";
            this.txt_newpsw.Size = new System.Drawing.Size(170, 41);
            this.txt_newpsw.TabIndex = 10;
            // 
            // txt_madi
            // 
            this.txt_madi.BackColor = System.Drawing.SystemColors.Info;
            this.txt_madi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_madi.Location = new System.Drawing.Point(240, 285);
            this.txt_madi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_madi.Multiline = true;
            this.txt_madi.Name = "txt_madi";
            this.txt_madi.Size = new System.Drawing.Size(170, 41);
            this.txt_madi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 440);
            this.label1.MinimumSize = new System.Drawing.Size(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 8;
            // 
            // kayit
            // 
            this.kayit.BackColor = System.Drawing.SystemColors.Info;
            this.kayit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.kayit.ForeColor = System.Drawing.Color.Orange;
            this.kayit.Location = new System.Drawing.Point(265, 472);
            this.kayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(145, 36);
            this.kayit.TabIndex = 7;
            this.kayit.Text = "Kayıt ol";
            this.kayit.UseVisualStyleBackColor = false;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // s_dgstr
            // 
            this.s_dgstr.BackColor = System.Drawing.SystemColors.Info;
            this.s_dgstr.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.s_dgstr.ForeColor = System.Drawing.Color.Orange;
            this.s_dgstr.Location = new System.Drawing.Point(265, 408);
            this.s_dgstr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s_dgstr.Name = "s_dgstr";
            this.s_dgstr.Size = new System.Drawing.Size(145, 43);
            this.s_dgstr.TabIndex = 6;
            this.s_dgstr.Text = "Sİfre degistir";
            this.s_dgstr.UseVisualStyleBackColor = false;
            this.s_dgstr.Click += new System.EventHandler(this.s_dgstr_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(164, 146);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(69, 85);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 17);
            this.user.TabIndex = 2;
            // 
            // txt_pasword
            // 
            this.txt_pasword.BackColor = System.Drawing.SystemColors.Info;
            this.txt_pasword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pasword.Location = new System.Drawing.Point(240, 155);
            this.txt_pasword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pasword.Multiline = true;
            this.txt_pasword.Name = "txt_pasword";
            this.txt_pasword.Size = new System.Drawing.Size(170, 41);
            this.txt_pasword.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Info;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Location = new System.Drawing.Point(240, 74);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(170, 41);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Info;
            this.login.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Orange;
            this.login.Location = new System.Drawing.Point(265, 350);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(145, 41);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(80, 49);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 800);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox txt_pasword;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button s_dgstr;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_newpsw;
        private System.Windows.Forms.TextBox txt_madi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kargo_takip_buton;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

