namespace _25prjeflimarsivi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkayıt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkatagori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btntamekran = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnhakkımızda = new System.Windows.Forms.Button();
            this.btnrenk = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flim Arşiv Otamasyonu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1146, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkayıt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtlink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtkatagori);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 495);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Flim";
            // 
            // btnkayıt
            // 
            this.btnkayıt.Location = new System.Drawing.Point(98, 182);
            this.btnkayıt.Name = "btnkayıt";
            this.btnkayıt.Size = new System.Drawing.Size(131, 31);
            this.btnkayıt.TabIndex = 8;
            this.btnkayıt.Text = "Kaydet";
            this.btnkayıt.UseVisualStyleBackColor = true;
            this.btnkayıt.Click += new System.EventHandler(this.btnkayıt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Link :";
            // 
            // txtlink
            // 
            this.txtlink.Location = new System.Drawing.Point(98, 145);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(183, 31);
            this.txtlink.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Katagori :";
            // 
            // txtkatagori
            // 
            this.txtkatagori.Location = new System.Drawing.Point(98, 103);
            this.txtkatagori.Name = "txtkatagori";
            this.txtkatagori.Size = new System.Drawing.Size(183, 31);
            this.txtkatagori.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Flim Ad :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnexit);
            this.groupBox4.Controls.Add(this.btnrenk);
            this.groupBox4.Controls.Add(this.btnhakkımızda);
            this.groupBox4.Controls.Add(this.btntamekran);
            this.groupBox4.Location = new System.Drawing.Point(6, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 203);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlem Butonları";
            // 
            // btntamekran
            // 
            this.btntamekran.Location = new System.Drawing.Point(31, 46);
            this.btntamekran.Name = "btntamekran";
            this.btntamekran.Size = new System.Drawing.Size(207, 31);
            this.btntamekran.TabIndex = 1;
            this.btntamekran.Text = "Tam Ekran";
            this.btntamekran.UseVisualStyleBackColor = true;
            this.btntamekran.Click += new System.EventHandler(this.btntamekran_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(98, 55);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(183, 31);
            this.txtad.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(314, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 495);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flim listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(281, 465);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webBrowser1);
            this.groupBox3.Location = new System.Drawing.Point(607, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(692, 495);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(686, 465);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnhakkımızda
            // 
            this.btnhakkımızda.Location = new System.Drawing.Point(31, 83);
            this.btnhakkımızda.Name = "btnhakkımızda";
            this.btnhakkımızda.Size = new System.Drawing.Size(207, 31);
            this.btnhakkımızda.TabIndex = 2;
            this.btnhakkımızda.Text = "Hakkımızda";
            this.btnhakkımızda.UseVisualStyleBackColor = true;
            this.btnhakkımızda.Click += new System.EventHandler(this.btnhakkımızda_Click);
            // 
            // btnrenk
            // 
            this.btnrenk.Location = new System.Drawing.Point(31, 120);
            this.btnrenk.Name = "btnrenk";
            this.btnrenk.Size = new System.Drawing.Size(207, 31);
            this.btnrenk.TabIndex = 3;
            this.btnrenk.Text = "Renk Değiştir";
            this.btnrenk.UseVisualStyleBackColor = true;
            this.btnrenk.Click += new System.EventHandler(this.btnrenk_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(31, 157);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(207, 31);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Çıkış";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1311, 631);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnkayıt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkatagori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btntamekran;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnrenk;
        private System.Windows.Forms.Button btnhakkımızda;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

