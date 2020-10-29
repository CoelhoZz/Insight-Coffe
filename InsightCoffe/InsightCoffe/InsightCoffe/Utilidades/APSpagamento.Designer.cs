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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEndSale = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedValorCompra = new System.Windows.Forms.MaskedTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedBBuscarPedido = new System.Windows.Forms.MaskedTextBox();
            this.picBBarra = new System.Windows.Forms.PictureBox();
            this.btnPedidoPago = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(13, 372);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(430, 36);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEndSale
            // 
            this.btnEndSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEndSale.FlatAppearance.BorderSize = 0;
            this.btnEndSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndSale.Location = new System.Drawing.Point(148, 315);
            this.btnEndSale.Name = "btnEndSale";
            this.btnEndSale.Size = new System.Drawing.Size(119, 51);
            this.btnEndSale.TabIndex = 28;
            this.btnEndSale.Text = "Encerrar Compra";
            this.btnEndSale.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(10, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Valor Total da Compra";
            // 
            // maskedValorCompra
            // 
            this.maskedValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedValorCompra.Location = new System.Drawing.Point(13, 321);
            this.maskedValorCompra.Mask = "$";
            this.maskedValorCompra.Name = "maskedValorCompra";
            this.maskedValorCompra.Size = new System.Drawing.Size(129, 35);
            this.maskedValorCompra.TabIndex = 25;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.treeView1.Location = new System.Drawing.Point(13, 109);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(429, 177);
            this.treeView1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Buscar Pedido:";
            // 
            // maskedBBuscarPedido
            // 
            this.maskedBBuscarPedido.Location = new System.Drawing.Point(133, 71);
            this.maskedBBuscarPedido.Name = "maskedBBuscarPedido";
            this.maskedBBuscarPedido.Size = new System.Drawing.Size(301, 20);
            this.maskedBBuscarPedido.TabIndex = 20;
            // 
            // picBBarra
            // 
            this.picBBarra.BackColor = System.Drawing.Color.SaddleBrown;
            this.picBBarra.Location = new System.Drawing.Point(-1, 0);
            this.picBBarra.Name = "picBBarra";
            this.picBBarra.Size = new System.Drawing.Size(455, 28);
            this.picBBarra.TabIndex = 15;
            this.picBBarra.TabStop = false;
            this.picBBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.picBBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.picBBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // btnPedidoPago
            // 
            this.btnPedidoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPedidoPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedidoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoPago.Location = new System.Drawing.Point(289, 315);
            this.btnPedidoPago.Name = "btnPedidoPago";
            this.btnPedidoPago.Size = new System.Drawing.Size(153, 51);
            this.btnPedidoPago.TabIndex = 30;
            this.btnPedidoPago.Text = "Pedido Pago";
            this.btnPedidoPago.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pagamento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.btnMinimizar.Location = new System.Drawing.Point(380, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 25);
            this.btnMinimizar.TabIndex = 57;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnNormal.Location = new System.Drawing.Point(405, 1);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(24, 25);
            this.btnNormal.TabIndex = 58;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(431, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 26);
            this.btnFechar.TabIndex = 59;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnMaximizar.FlatAppearance.BorderSize = 5;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(405, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(24, 25);
            this.btnMaximizar.TabIndex = 60;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // APSpagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(454, 420);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnPedidoPago);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEndSale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedValorCompra);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedBBuscarPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "APSpagamento";
            this.Text = "APSpagamento";
            this.Load += new System.EventHandler(this.APSpagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBBarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEndSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedValorCompra;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedBBuscarPedido;
        private System.Windows.Forms.PictureBox picBBarra;
        private System.Windows.Forms.Button btnPedidoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMaximizar;
    }
}