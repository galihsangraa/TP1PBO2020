namespace Pembelian
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbuname = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labeluname = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.labelpass);
            this.panel1.Controls.Add(this.labeluname);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.tbpass);
            this.panel1.Controls.Add(this.tbuname);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 351);
            this.panel1.TabIndex = 24;
            // 
            // btnlogin
            // 
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(164, 250);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(225, 39);
            this.btnlogin.TabIndex = 29;
            this.btnlogin.Text = "L O G I N";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // tbpass
            // 
            this.tbpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbpass.ForeColor = System.Drawing.Color.DimGray;
            this.tbpass.Location = new System.Drawing.Point(182, 192);
            this.tbpass.Multiline = true;
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(192, 30);
            this.tbpass.TabIndex = 28;
            // 
            // tbuname
            // 
            this.tbuname.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbuname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbuname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuname.ForeColor = System.Drawing.Color.DimGray;
            this.tbuname.Location = new System.Drawing.Point(182, 120);
            this.tbuname.Multiline = true;
            this.tbuname.Name = "tbuname";
            this.tbuname.Size = new System.Drawing.Size(192, 30);
            this.tbuname.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(131, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 260);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // labeluname
            // 
            this.labeluname.AutoSize = true;
            this.labeluname.BackColor = System.Drawing.Color.White;
            this.labeluname.Location = new System.Drawing.Point(238, 93);
            this.labeluname.Name = "labeluname";
            this.labeluname.Size = new System.Drawing.Size(68, 13);
            this.labeluname.TabIndex = 30;
            this.labeluname.Text = "USERNAME";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.BackColor = System.Drawing.Color.White;
            this.labelpass.Location = new System.Drawing.Point(238, 167);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(70, 13);
            this.labelpass.TabIndex = 31;
            this.labelpass.Text = "PASSWORD";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(594, 375);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbuname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Label labeluname;
    }
}

