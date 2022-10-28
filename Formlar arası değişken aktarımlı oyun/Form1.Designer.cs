namespace Formlar_arası_değişken_aktarımlı_oyun
{
    partial class Frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            this.ScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnvur = new System.Windows.Forms.Button();
            this.prgrsbrCan = new System.Windows.Forms.ProgressBar();
            this.prgrsbrYemek = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrihtimal = new System.Windows.Forms.Timer(this.components);
            this.prgrsbrDusmanCan = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblihtimal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollBar1
            // 
            this.ScrollBar1.Location = new System.Drawing.Point(44, 22);
            this.ScrollBar1.Maximum = 99;
            this.ScrollBar1.Name = "ScrollBar1";
            this.ScrollBar1.Size = new System.Drawing.Size(506, 34);
            this.ScrollBar1.TabIndex = 1;
            // 
            // btnvur
            // 
            this.btnvur.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvur.Location = new System.Drawing.Point(662, 22);
            this.btnvur.Name = "btnvur";
            this.btnvur.Size = new System.Drawing.Size(92, 67);
            this.btnvur.TabIndex = 2;
            this.btnvur.Text = "Vur";
            this.btnvur.UseVisualStyleBackColor = true;
            this.btnvur.Click += new System.EventHandler(this.btnvur_Click);
            // 
            // prgrsbrCan
            // 
            this.prgrsbrCan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.prgrsbrCan.ForeColor = System.Drawing.Color.Red;
            this.prgrsbrCan.Location = new System.Drawing.Point(439, 370);
            this.prgrsbrCan.Name = "prgrsbrCan";
            this.prgrsbrCan.Size = new System.Drawing.Size(316, 55);
            this.prgrsbrCan.TabIndex = 3;
            this.prgrsbrCan.Value = 100;
            // 
            // prgrsbrYemek
            // 
            this.prgrsbrYemek.BackColor = System.Drawing.Color.White;
            this.prgrsbrYemek.ForeColor = System.Drawing.Color.Red;
            this.prgrsbrYemek.Location = new System.Drawing.Point(44, 370);
            this.prgrsbrYemek.Name = "prgrsbrYemek";
            this.prgrsbrYemek.Size = new System.Drawing.Size(311, 55);
            this.prgrsbrYemek.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tmrihtimal
            // 
            this.tmrihtimal.Enabled = true;
            this.tmrihtimal.Interval = 1;
            this.tmrihtimal.Tick += new System.EventHandler(this.tmrihtimal_Tick);
            // 
            // prgrsbrDusmanCan
            // 
            this.prgrsbrDusmanCan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.prgrsbrDusmanCan.ForeColor = System.Drawing.Color.Red;
            this.prgrsbrDusmanCan.Location = new System.Drawing.Point(253, 75);
            this.prgrsbrDusmanCan.Name = "prgrsbrDusmanCan";
            this.prgrsbrDusmanCan.Size = new System.Drawing.Size(291, 39);
            this.prgrsbrDusmanCan.TabIndex = 7;
            this.prgrsbrDusmanCan.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Açlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 52);
            this.label2.TabIndex = 10;
            this.label2.Text = "Can";
            // 
            // lblihtimal
            // 
            this.lblihtimal.AutoSize = true;
            this.lblihtimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblihtimal.Location = new System.Drawing.Point(568, 30);
            this.lblihtimal.Name = "lblihtimal";
            this.lblihtimal.Size = new System.Drawing.Size(0, 29);
            this.lblihtimal.TabIndex = 6;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(796, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgrsbrDusmanCan);
            this.Controls.Add(this.lblihtimal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prgrsbrYemek);
            this.Controls.Add(this.prgrsbrCan);
            this.Controls.Add(this.btnvur);
            this.Controls.Add(this.ScrollBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm1";
            this.Text = "Nyan Cat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar ScrollBar1;
        private System.Windows.Forms.Button btnvur;
        private System.Windows.Forms.ProgressBar prgrsbrCan;
        private System.Windows.Forms.ProgressBar prgrsbrYemek;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrihtimal;
        private System.Windows.Forms.ProgressBar prgrsbrDusmanCan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblihtimal;
    }
}

