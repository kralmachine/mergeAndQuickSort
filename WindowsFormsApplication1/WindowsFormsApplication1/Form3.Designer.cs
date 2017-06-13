namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.btnDizi10000 = new System.Windows.Forms.Button();
            this.btnDizi1000 = new System.Windows.Forms.Button();
            this.btnDizi100 = new System.Windows.Forms.Button();
            this.btnDizi10 = new System.Windows.Forms.Button();
            this.btnDiziSiralama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDizi10000
            // 
            this.btnDizi10000.Location = new System.Drawing.Point(12, 124);
            this.btnDizi10000.Name = "btnDizi10000";
            this.btnDizi10000.Size = new System.Drawing.Size(146, 23);
            this.btnDizi10000.TabIndex = 9;
            this.btnDizi10000.Text = "DİZİ 10000";
            this.btnDizi10000.UseVisualStyleBackColor = true;
            this.btnDizi10000.Click += new System.EventHandler(this.btnDizi10000_Click);
            // 
            // btnDizi1000
            // 
            this.btnDizi1000.Location = new System.Drawing.Point(12, 95);
            this.btnDizi1000.Name = "btnDizi1000";
            this.btnDizi1000.Size = new System.Drawing.Size(146, 23);
            this.btnDizi1000.TabIndex = 8;
            this.btnDizi1000.Text = "DİZİ 1000";
            this.btnDizi1000.UseVisualStyleBackColor = true;
            this.btnDizi1000.Click += new System.EventHandler(this.btnDizi1000_Click);
            // 
            // btnDizi100
            // 
            this.btnDizi100.Location = new System.Drawing.Point(12, 66);
            this.btnDizi100.Name = "btnDizi100";
            this.btnDizi100.Size = new System.Drawing.Size(146, 23);
            this.btnDizi100.TabIndex = 7;
            this.btnDizi100.Text = "DİZİ 100";
            this.btnDizi100.UseVisualStyleBackColor = true;
            this.btnDizi100.Click += new System.EventHandler(this.btnDizi100_Click);
            // 
            // btnDizi10
            // 
            this.btnDizi10.Location = new System.Drawing.Point(12, 36);
            this.btnDizi10.Name = "btnDizi10";
            this.btnDizi10.Size = new System.Drawing.Size(146, 23);
            this.btnDizi10.TabIndex = 6;
            this.btnDizi10.Text = "DİZİ 10";
            this.btnDizi10.UseVisualStyleBackColor = true;
            this.btnDizi10.Click += new System.EventHandler(this.btnDizi10_Click);
            // 
            // btnDiziSiralama
            // 
            this.btnDiziSiralama.Location = new System.Drawing.Point(12, 6);
            this.btnDiziSiralama.Name = "btnDiziSiralama";
            this.btnDiziSiralama.Size = new System.Drawing.Size(146, 23);
            this.btnDiziSiralama.TabIndex = 5;
            this.btnDiziSiralama.Text = "DİZİ SIRALAMA";
            this.btnDiziSiralama.UseVisualStyleBackColor = true;
            this.btnDiziSiralama.Click += new System.EventHandler(this.btnDiziSiralama_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(170, 152);
            this.Controls.Add(this.btnDizi10000);
            this.Controls.Add(this.btnDizi1000);
            this.Controls.Add(this.btnDizi100);
            this.Controls.Add(this.btnDizi10);
            this.Controls.Add(this.btnDiziSiralama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALGORİTMA 3.ÖDEV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDizi10000;
        private System.Windows.Forms.Button btnDizi1000;
        private System.Windows.Forms.Button btnDizi100;
        private System.Windows.Forms.Button btnDizi10;
        private System.Windows.Forms.Button btnDiziSiralama;
    }
}