namespace Formlar_arası_değişken_aktarımlı_oyun
{
    partial class Frmbaslangic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbaslangic));
            this.btnbasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnwasted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbasla
            // 
            this.btnbasla.BackColor = System.Drawing.Color.Red;
            this.btnbasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbasla.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbasla.Location = new System.Drawing.Point(502, 185);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(232, 175);
            this.btnbasla.TabIndex = 0;
            this.btnbasla.Text = "Sol";
            this.btnbasla.UseVisualStyleBackColor = false;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oyuna Başlamak İçin Sol Butona Tıkla";
            // 
            // btnwasted
            // 
            this.btnwasted.BackColor = System.Drawing.Color.Red;
            this.btnwasted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwasted.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnwasted.Location = new System.Drawing.Point(67, 185);
            this.btnwasted.Name = "btnwasted";
            this.btnwasted.Size = new System.Drawing.Size(232, 175);
            this.btnwasted.TabIndex = 0;
            this.btnwasted.Text = "Sağ";
            this.btnwasted.UseVisualStyleBackColor = false;
            this.btnwasted.Click += new System.EventHandler(this.btnwasted_Click);
            // 
            // Frmbaslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.btnwasted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbasla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmbaslangic";
            this.Text = "Başlangıç Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnwasted;
    }
}