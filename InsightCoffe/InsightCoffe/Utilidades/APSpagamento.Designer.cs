namespace InsightCoffe.Utilidades
{
    partial class APSpagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APSpagamento));
            this.picBBarra = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.mskSituação = new System.Windows.Forms.MaskedTextBox();
            this.lsViewCarrinho = new System.Windows.Forms.ListBox();
            this.btnEnterPedido = new System.Windows.Forms.Button();
            this.mskBCodeBar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.panelNCN = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskBNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskBCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEndSale = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.bntMaximizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBBarra)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelNCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBBarra
            // 
            this.picBBarra.BackColor = System.Drawing.Color.SaddleBrown;
            this.picBBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBBarra.Location = new System.Drawing.Point(0, 0);
            this.picBBarra.Name = "picBBarra";
            this.picBBarra.Size = new System.Drawing.Size(519, 25);
            this.picBBarra.TabIndex = 15;
            this.picBBarra.TabStop = false;
            this.picBBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.picBBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.picBBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pagamento";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.mskBCodeBar);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.mskSituação);
            this.panel1.Controls.Add(this.lsViewCarrinho);
            this.panel1.Controls.Add(this.btnEnterPedido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mskValorTotal);
            this.panel1.Controls.Add(this.panelNCN);
            this.panel1.Controls.Add(this.btnEndSale);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(8, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 594);
            this.panel1.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(229, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 35);
            this.button1.TabIndex = 92;
            this.button1.Text = "Imprimir NFC-e";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mskSituação
            // 
            this.mskSituação.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mskSituação.BackColor = System.Drawing.Color.Moccasin;
            this.mskSituação.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSituação.Location = new System.Drawing.Point(19, 493);
            this.mskSituação.Name = "mskSituação";
            this.mskSituação.Size = new System.Drawing.Size(204, 35);
            this.mskSituação.TabIndex = 91;
            // 
            // lsViewCarrinho
            // 
            this.lsViewCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsViewCarrinho.BackColor = System.Drawing.Color.Moccasin;
            this.lsViewCarrinho.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsViewCarrinho.FormattingEnabled = true;
            this.lsViewCarrinho.ItemHeight = 28;
            this.lsViewCarrinho.Location = new System.Drawing.Point(19, 176);
            this.lsViewCarrinho.Name = "lsViewCarrinho";
            this.lsViewCarrinho.Size = new System.Drawing.Size(466, 312);
            this.lsViewCarrinho.TabIndex = 90;
            // 
            // btnEnterPedido
            // 
            this.btnEnterPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterPedido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnterPedido.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnterPedido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterPedido.Location = new System.Drawing.Point(425, 28);
            this.btnEnterPedido.Name = "btnEnterPedido";
            this.btnEnterPedido.Size = new System.Drawing.Size(60, 27);
            this.btnEnterPedido.TabIndex = 81;
            this.btnEnterPedido.Text = "Enter";
            this.btnEnterPedido.UseVisualStyleBackColor = false;
            this.btnEnterPedido.Click += new System.EventHandler(this.btnEnterPedido_Click);
            // 
            // mskBCodeBar
            // 
            this.mskBCodeBar.AllowDrop = true;
            this.mskBCodeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBCodeBar.BackColor = System.Drawing.Color.White;
            this.mskBCodeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBCodeBar.Location = new System.Drawing.Point(171, 29);
            this.mskBCodeBar.Name = "mskBCodeBar";
            this.mskBCodeBar.Size = new System.Drawing.Size(248, 26);
            this.mskBCodeBar.TabIndex = 79;
            this.mskBCodeBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CodigoBar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Codigo de barras:";
            // 
            // mskValorTotal
            // 
            this.mskValorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValorTotal.Location = new System.Drawing.Point(356, 494);
            this.mskValorTotal.Mask = "$";
            this.mskValorTotal.Name = "mskValorTotal";
            this.mskValorTotal.Size = new System.Drawing.Size(129, 35);
            this.mskValorTotal.TabIndex = 25;
            this.mskValorTotal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedValorCompra_MaskInputRejected);
            // 
            // panelNCN
            // 
            this.panelNCN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNCN.AutoSize = true;
            this.panelNCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.panelNCN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNCN.Controls.Add(this.lblData);
            this.panelNCN.Controls.Add(this.label1);
            this.panelNCN.Controls.Add(this.mskBNome);
            this.panelNCN.Controls.Add(this.label5);
            this.panelNCN.Controls.Add(this.mskBCPF);
            this.panelNCN.Controls.Add(this.label7);
            this.panelNCN.Location = new System.Drawing.Point(19, 83);
            this.panelNCN.Name = "panelNCN";
            this.panelNCN.Size = new System.Drawing.Size(466, 92);
            this.panelNCN.TabIndex = 88;
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Moccasin;
            this.lblData.Location = new System.Drawing.Point(275, 55);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(175, 19);
            this.lblData.TabIndex = 88;
            this.lblData.Text = "00/00/0000 00:00";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 87;
            this.label1.Text = "Data:";
            // 
            // mskBNome
            // 
            this.mskBNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskBNome.BackColor = System.Drawing.Color.LightGray;
            this.mskBNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mskBNome.Enabled = false;
            this.mskBNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.mskBNome.Location = new System.Drawing.Point(71, 10);
            this.mskBNome.Name = "mskBNome";
            this.mskBNome.Size = new System.Drawing.Size(372, 29);
            this.mskBNome.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 85;
            this.label5.Text = "Nome:";
            // 
            // mskBCPF
            // 
            this.mskBCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskBCPF.BackColor = System.Drawing.Color.LightGray;
            this.mskBCPF.Enabled = false;
            this.mskBCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBCPF.Location = new System.Drawing.Point(71, 47);
            this.mskBCPF.Mask = "000,000,000-00";
            this.mskBCPF.Name = "mskBCPF";
            this.mskBCPF.Size = new System.Drawing.Size(144, 29);
            this.mskBCPF.TabIndex = 83;
            this.mskBCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 86;
            this.label7.Text = "CPF:";
            // 
            // btnEndSale
            // 
            this.btnEndSale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEndSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEndSale.FlatAppearance.BorderSize = 0;
            this.btnEndSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndSale.Location = new System.Drawing.Point(19, 534);
            this.btnEndSale.Name = "btnEndSale";
            this.btnEndSale.Size = new System.Drawing.Size(204, 35);
            this.btnEndSale.TabIndex = 28;
            this.btnEndSale.Text = "Encerrar Compra";
            this.btnEndSale.UseVisualStyleBackColor = false;
            this.btnEndSale.Click += new System.EventHandler(this.btnEndSale_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 89;
            this.label4.Text = "Valor Total:";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnFechar.FlatAppearance.BorderSize = 5;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.Location = new System.Drawing.Point(496, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 26);
            this.btnFechar.TabIndex = 91;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseLeave += new System.EventHandler(this.LeaveFechar);
            this.btnFechar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlFechar);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnMinimizar.FlatAppearance.BorderSize = 5;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(452, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 25);
            this.btnMinimizar.TabIndex = 90;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.LeaveMinimizar);
            this.btnMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMinimizar);
            // 
            // bntMaximizar
            // 
            this.bntMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMaximizar.BackColor = System.Drawing.Color.SaddleBrown;
            this.bntMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntMaximizar.BackgroundImage")));
            this.bntMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.bntMaximizar.FlatAppearance.BorderSize = 6;
            this.bntMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bntMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.bntMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMaximizar.Location = new System.Drawing.Point(475, 0);
            this.bntMaximizar.Name = "bntMaximizar";
            this.bntMaximizar.Size = new System.Drawing.Size(24, 25);
            this.bntMaximizar.TabIndex = 89;
            this.bntMaximizar.UseVisualStyleBackColor = false;
            this.bntMaximizar.Click += new System.EventHandler(this.bntMaximizar_Click);
            this.bntMaximizar.MouseLeave += new System.EventHandler(this.LeaveMaximizar);
            this.bntMaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMaximizar);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNormal.BackgroundImage")));
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnNormal.FlatAppearance.BorderSize = 5;
            this.btnNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Location = new System.Drawing.Point(475, -1);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(24, 25);
            this.btnNormal.TabIndex = 92;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            this.btnNormal.MouseLeave += new System.EventHandler(this.LeaveNormal);
            this.btnNormal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlNormal);
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(201, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 93;
            // 
            // APSpagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(519, 628);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntMaximizar);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.picBBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "APSpagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.Load += new System.EventHandler(this.APSpagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBBarra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelNCN.ResumeLayout(false);
            this.panelNCN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBBarra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnterPedido;
        private System.Windows.Forms.MaskedTextBox mskBCodeBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskValorTotal;
        private System.Windows.Forms.Panel panelNCN;
        private System.Windows.Forms.TextBox mskBNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskBCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEndSale;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button bntMaximizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.ListBox lsViewCarrinho;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskSituação;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
    }
}