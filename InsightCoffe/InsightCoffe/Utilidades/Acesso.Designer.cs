namespace InsightCoffe
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConectar = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBMinimize = new System.Windows.Forms.PictureBox();
            this.picBExit = new System.Windows.Forms.PictureBox();
            this.picBBarra = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(22, 185);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(184, 59);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Entrar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(33, 126);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(160, 25);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Click += new System.EventHandler(this.Click_pass);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.Silver;
            this.tbUsername.Location = new System.Drawing.Point(33, 78);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(160, 25);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.Text = "Username";
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsername.Click += new System.EventHandler(this.Click_user);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // picBMinimize
            // 
            this.picBMinimize.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picBMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picBMinimize.Image")));
            this.picBMinimize.Location = new System.Drawing.Point(176, 8);
            this.picBMinimize.Name = "picBMinimize";
            this.picBMinimize.Size = new System.Drawing.Size(20, 22);
            this.picBMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMinimize.TabIndex = 9;
            this.picBMinimize.TabStop = false;
            this.picBMinimize.Click += new System.EventHandler(this.picBMinimize_Click);
            // 
            // picBExit
            // 
            this.picBExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picBExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBExit.Image = ((System.Drawing.Image)(resources.GetObject("picBExit.Image")));
            this.picBExit.Location = new System.Drawing.Point(200, 8);
            this.picBExit.Name = "picBExit";
            this.picBExit.Size = new System.Drawing.Size(20, 22);
            this.picBExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBExit.TabIndex = 7;
            this.picBExit.TabStop = false;
            this.picBExit.Click += new System.EventHandler(this.picBExit_Click);
            // 
            // picBBarra
            // 
            this.picBBarra.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picBBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBBarra.Location = new System.Drawing.Point(0, -1);
            this.picBBarra.Name = "picBBarra";
            this.picBBarra.Size = new System.Drawing.Size(229, 54);
            this.picBBarra.TabIndex = 6;
            this.picBBarra.TabStop = false;
            this.picBBarra.Click += new System.EventHandler(this.Form_click);
            this.picBBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.picBBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.picBBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "__________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "__________________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBMinimize);
            this.Controls.Add(this.picBExit);
            this.Controls.Add(this.picBBarra);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form_click);
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBBarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBMinimize;
        private System.Windows.Forms.PictureBox picBExit;
        private System.Windows.Forms.PictureBox picBBarra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

