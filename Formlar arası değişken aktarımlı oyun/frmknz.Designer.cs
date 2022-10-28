namespace Formlar_arası_değişken_aktarımlı_oyun
{
    partial class frmknz
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
            this.btnKolay = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnZor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKolay
            // 
            this.btnKolay.BackColor = System.Drawing.Color.DarkBlue;
            this.btnKolay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKolay.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKolay.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnKolay.Location = new System.Drawing.Point(63, 54);
            this.btnKolay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKolay.Name = "btnKolay";
            this.btnKolay.Size = new System.Drawing.Size(422, 60);
            this.btnKolay.TabIndex = 0;
            this.btnKolay.Text = "Kolay";
            this.btnKolay.UseVisualStyleBackColor = false;
            this.btnKolay.Click += new System.EventHandler(this.btnKolay_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.DarkBlue;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNormal.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNormal.Location = new System.Drawing.Point(63, 118);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(422, 60);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnZor
            // 
            this.btnZor.BackColor = System.Drawing.Color.DarkBlue;
            this.btnZor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZor.ForeColor = System.Drawing.Color.Red;
            this.btnZor.Location = new System.Drawing.Point(63, 183);
            this.btnZor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZor.Name = "btnZor";
            this.btnZor.Size = new System.Drawing.Size(422, 60);
            this.btnZor.TabIndex = 2;
            this.btnZor.Text = "Zor";
            this.btnZor.UseVisualStyleBackColor = false;
            this.btnZor.Click += new System.EventHandler(this.btnZor_Click);
            // 
            // frmknz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 294);
            this.Controls.Add(this.btnZor);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnKolay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmknz";
            this.Text = "frmknz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKolay;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnZor;
    }
}