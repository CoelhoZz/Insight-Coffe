﻿namespace InsightCoffe.Utilidades
{
    partial class APSvendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APSvendas));
            this.label1 = new System.Windows.Forms.Label();
            this.mskBCodeBar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskBValortotal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskBCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskBNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelNCN = new System.Windows.Forms.Panel();
            this.mskBNome = new System.Windows.Forms.TextBox();
            this.btnLimparClient = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnterPedido = new System.Windows.Forms.Button();
            this.mskBRetirarItem = new System.Windows.Forms.MaskedTextBox();
            this.mskAdicionarItem = new System.Windows.Forms.MaskedTextBox();
            this.btnPular = new System.Windows.Forms.Button();
            this.comboBoxAdicionar = new System.Windows.Forms.ComboBox();
            this.btnLimparRetirar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.mskBValorItemRetirado = new System.Windows.Forms.MaskedTextBox();
            this.btnLimparAdicionar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSalvarPedido = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numUDQtdItemRetirar = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numUDQtdItemAdicionar = new System.Windows.Forms.NumericUpDown();
            this.mskBValorAdicionar = new System.Windows.Forms.MaskedTextBox();
            this.btnIncluirCampoCliente = new System.Windows.Forms.Button();
            this.comboBoxRetirar = new System.Windows.Forms.ComboBox();
            this.lsViewCarrinho = new System.Windows.Forms.ListBox();
            this.lblID = new System.Windows.Forms.Label();
            this.barraFormulario = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.bntMaximizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.panelNCN.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQtdItemRetirar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQtdItemAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registrar Pedidos";
            // 
            // mskBCodeBar
            // 
            this.mskBCodeBar.AllowDrop = true;
            this.mskBCodeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBCodeBar.BackColor = System.Drawing.Color.White;
            this.mskBCodeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBCodeBar.Location = new System.Drawing.Point(468, 42);
            this.mskBCodeBar.Name = "mskBCodeBar";
            this.mskBCodeBar.Size = new System.Drawing.Size(445, 26);
            this.mskBCodeBar.TabIndex = 1;
            this.mskBCodeBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CodigoBar);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo de barras:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(565, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo do Produto";
            // 
            // mskBValortotal
            // 
            this.mskBValortotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBValortotal.BackColor = System.Drawing.Color.White;
            this.mskBValortotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBValortotal.Location = new System.Drawing.Point(507, 565);
            this.mskBValortotal.Mask = "$";
            this.mskBValortotal.Name = "mskBValortotal";
            this.mskBValortotal.ReadOnly = true;
            this.mskBValortotal.Size = new System.Drawing.Size(214, 35);
            this.mskBValortotal.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(503, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Total";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome:";
            // 
            // mskBCPF
            // 
            this.mskBCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBCPF.BackColor = System.Drawing.Color.LightGray;
            this.mskBCPF.Enabled = false;
            this.mskBCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBCPF.Location = new System.Drawing.Point(108, 54);
            this.mskBCPF.Mask = "000,000,000-00";
            this.mskBCPF.Name = "mskBCPF";
            this.mskBCPF.Size = new System.Drawing.Size(144, 29);
            this.mskBCPF.TabIndex = 2;
            this.mskBCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskBCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CPF);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "CPF:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(267, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nascimento:";
            // 
            // mskBNascimento
            // 
            this.mskBNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBNascimento.BackColor = System.Drawing.Color.LightGray;
            this.mskBNascimento.Enabled = false;
            this.mskBNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBNascimento.Location = new System.Drawing.Point(385, 54);
            this.mskBNascimento.Mask = "00/00/0000";
            this.mskBNascimento.Name = "mskBNascimento";
            this.mskBNascimento.Size = new System.Drawing.Size(108, 29);
            this.mskBNascimento.TabIndex = 3;
            this.mskBNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskBNascimento.ValidatingType = typeof(System.DateTime);
            this.mskBNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Nascimeto);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(553, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Retirar item";
            // 
            // panelNCN
            // 
            this.panelNCN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNCN.AutoSize = true;
            this.panelNCN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelNCN.Controls.Add(this.mskBNome);
            this.panelNCN.Controls.Add(this.btnLimparClient);
            this.panelNCN.Controls.Add(this.mskBNascimento);
            this.panelNCN.Controls.Add(this.btnProcurar);
            this.panelNCN.Controls.Add(this.label8);
            this.panelNCN.Controls.Add(this.btnSalvar);
            this.panelNCN.Controls.Add(this.mskBCPF);
            this.panelNCN.Controls.Add(this.label5);
            this.panelNCN.Controls.Add(this.label7);
            this.panelNCN.Location = new System.Drawing.Point(473, 87);
            this.panelNCN.Name = "panelNCN";
            this.panelNCN.Size = new System.Drawing.Size(501, 125);
            this.panelNCN.TabIndex = 3;
            // 
            // mskBNome
            // 
            this.mskBNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBNome.BackColor = System.Drawing.Color.LightGray;
            this.mskBNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mskBNome.Enabled = false;
            this.mskBNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.mskBNome.Location = new System.Drawing.Point(108, 17);
            this.mskBNome.Name = "mskBNome";
            this.mskBNome.Size = new System.Drawing.Size(385, 29);
            this.mskBNome.TabIndex = 1;
            // 
            // btnLimparClient
            // 
            this.btnLimparClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimparClient.Enabled = false;
            this.btnLimparClient.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparClient.Location = new System.Drawing.Point(302, 93);
            this.btnLimparClient.Name = "btnLimparClient";
            this.btnLimparClient.Size = new System.Drawing.Size(84, 25);
            this.btnLimparClient.TabIndex = 5;
            this.btnLimparClient.Text = "Limpar";
            this.btnLimparClient.UseVisualStyleBackColor = false;
            this.btnLimparClient.Click += new System.EventHandler(this.btnLimparClient_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProcurar.Enabled = false;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(411, 93);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(84, 25);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(234, 93);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(67, 25);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDesconto
            // 
            this.lblDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.White;
            this.lblDesconto.Location = new System.Drawing.Point(587, 215);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(232, 20);
            this.lblDesconto.TabIndex = 77;
            this.lblDesconto.Text = "Você Ganhou um cappuchino!!";
            this.lblDesconto.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.lblDesconto);
            this.panel2.Controls.Add(this.btnEnterPedido);
            this.panel2.Controls.Add(this.mskBRetirarItem);
            this.panel2.Controls.Add(this.mskAdicionarItem);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnPular);
            this.panel2.Controls.Add(this.comboBoxAdicionar);
            this.panel2.Controls.Add(this.mskBCodeBar);
            this.panel2.Controls.Add(this.btnLimparRetirar);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.mskBValorItemRetirado);
            this.panel2.Controls.Add(this.btnLimparAdicionar);
            this.panel2.Controls.Add(this.btnAdicionar);
            this.panel2.Controls.Add(this.btnSalvarPedido);
            this.panel2.Controls.Add(this.btnCancelarPedido);
            this.panel2.Controls.Add(this.btnRetirar);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.numUDQtdItemRetirar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.numUDQtdItemAdicionar);
            this.panel2.Controls.Add(this.mskBValorAdicionar);
            this.panel2.Controls.Add(this.btnIncluirCampoCliente);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.mskBValortotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panelNCN);
            this.panel2.Controls.Add(this.comboBoxRetirar);
            this.panel2.Controls.Add(this.lsViewCarrinho);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Location = new System.Drawing.Point(6, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 679);
            this.panel2.TabIndex = 2;
            // 
            // btnEnterPedido
            // 
            this.btnEnterPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterPedido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnterPedido.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnterPedido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterPedido.Location = new System.Drawing.Point(919, 41);
            this.btnEnterPedido.Name = "btnEnterPedido";
            this.btnEnterPedido.Size = new System.Drawing.Size(60, 27);
            this.btnEnterPedido.TabIndex = 78;
            this.btnEnterPedido.Text = "Enter";
            this.btnEnterPedido.UseVisualStyleBackColor = false;
            this.btnEnterPedido.Click += new System.EventHandler(this.btnEnterPedido_Click);
            // 
            // mskBRetirarItem
            // 
            this.mskBRetirarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBRetirarItem.BackColor = System.Drawing.Color.White;
            this.mskBRetirarItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskBRetirarItem.Enabled = false;
            this.mskBRetirarItem.Font = new System.Drawing.Font("Swis721 Cn BT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBRetirarItem.Location = new System.Drawing.Point(490, 276);
            this.mskBRetirarItem.Name = "mskBRetirarItem";
            this.mskBRetirarItem.Size = new System.Drawing.Size(229, 34);
            this.mskBRetirarItem.TabIndex = 76;
            this.mskBRetirarItem.TextChanged += new System.EventHandler(this.TextChanged_mskRetirar);
            this.mskBRetirarItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_mskRetirar);
            // 
            // mskAdicionarItem
            // 
            this.mskAdicionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mskAdicionarItem.BackColor = System.Drawing.Color.White;
            this.mskAdicionarItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskAdicionarItem.Enabled = false;
            this.mskAdicionarItem.Font = new System.Drawing.Font("Swis721 Cn BT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAdicionarItem.Location = new System.Drawing.Point(490, 457);
            this.mskAdicionarItem.Name = "mskAdicionarItem";
            this.mskAdicionarItem.Size = new System.Drawing.Size(230, 34);
            this.mskAdicionarItem.TabIndex = 4;
            this.mskAdicionarItem.TextChanged += new System.EventHandler(this.TextChanged_mskAdicionar);
            this.mskAdicionarItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_mskAdicionar);
            // 
            // btnPular
            // 
            this.btnPular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPular.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPular.Enabled = false;
            this.btnPular.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPular.Location = new System.Drawing.Point(566, 72);
            this.btnPular.Name = "btnPular";
            this.btnPular.Size = new System.Drawing.Size(67, 25);
            this.btnPular.TabIndex = 2;
            this.btnPular.Text = "Pular";
            this.btnPular.UseVisualStyleBackColor = false;
            this.btnPular.Click += new System.EventHandler(this.btnPular_Click);
            // 
            // comboBoxAdicionar
            // 
            this.comboBoxAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAdicionar.BackColor = System.Drawing.Color.White;
            this.comboBoxAdicionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxAdicionar.Enabled = false;
            this.comboBoxAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdicionar.FormattingEnabled = true;
            this.comboBoxAdicionar.Location = new System.Drawing.Point(490, 455);
            this.comboBoxAdicionar.Name = "comboBoxAdicionar";
            this.comboBoxAdicionar.Size = new System.Drawing.Size(255, 37);
            this.comboBoxAdicionar.TabIndex = 4;
            this.comboBoxAdicionar.SelectionChangeCommitted += new System.EventHandler(this.SelectItem_cbBox);
            // 
            // btnLimparRetirar
            // 
            this.btnLimparRetirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparRetirar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimparRetirar.Enabled = false;
            this.btnLimparRetirar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimparRetirar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparRetirar.Location = new System.Drawing.Point(827, 315);
            this.btnLimparRetirar.Name = "btnLimparRetirar";
            this.btnLimparRetirar.Size = new System.Drawing.Size(132, 29);
            this.btnLimparRetirar.TabIndex = 13;
            this.btnLimparRetirar.Text = "Limpar";
            this.btnLimparRetirar.UseVisualStyleBackColor = false;
            this.btnLimparRetirar.Click += new System.EventHandler(this.btnLimparRetirar_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(870, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Valor";
            // 
            // mskBValorItemRetirado
            // 
            this.mskBValorItemRetirado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBValorItemRetirado.BackColor = System.Drawing.Color.White;
            this.mskBValorItemRetirado.Enabled = false;
            this.mskBValorItemRetirado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBValorItemRetirado.Location = new System.Drawing.Point(827, 274);
            this.mskBValorItemRetirado.Name = "mskBValorItemRetirado";
            this.mskBValorItemRetirado.Size = new System.Drawing.Size(132, 35);
            this.mskBValorItemRetirado.TabIndex = 11;
            // 
            // btnLimparAdicionar
            // 
            this.btnLimparAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparAdicionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimparAdicionar.Enabled = false;
            this.btnLimparAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimparAdicionar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAdicionar.Location = new System.Drawing.Point(828, 496);
            this.btnLimparAdicionar.Name = "btnLimparAdicionar";
            this.btnLimparAdicionar.Size = new System.Drawing.Size(132, 29);
            this.btnLimparAdicionar.TabIndex = 8;
            this.btnLimparAdicionar.Text = "Limpar";
            this.btnLimparAdicionar.UseVisualStyleBackColor = false;
            this.btnLimparAdicionar.Click += new System.EventHandler(this.btnLimparAdicionar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(490, 496);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(332, 29);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarPedido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvarPedido.Enabled = false;
            this.btnSalvarPedido.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarPedido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPedido.Location = new System.Drawing.Point(507, 621);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(214, 40);
            this.btnSalvarPedido.TabIndex = 14;
            this.btnSalvarPedido.Text = "Salvar Pedido";
            this.btnSalvarPedido.UseVisualStyleBackColor = false;
            this.btnSalvarPedido.Click += new System.EventHandler(this.btnSalvarPedido_Click);
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarPedido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelarPedido.Enabled = false;
            this.btnCancelarPedido.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarPedido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPedido.Location = new System.Drawing.Point(726, 621);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(144, 40);
            this.btnCancelarPedido.TabIndex = 15;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = false;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetirar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRetirar.Enabled = false;
            this.btnRetirar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(490, 315);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(331, 29);
            this.btnRetirar.TabIndex = 12;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(763, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Qtd.";
            // 
            // numUDQtdItemRetirar
            // 
            this.numUDQtdItemRetirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDQtdItemRetirar.BackColor = System.Drawing.Color.White;
            this.numUDQtdItemRetirar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUDQtdItemRetirar.Enabled = false;
            this.numUDQtdItemRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDQtdItemRetirar.Location = new System.Drawing.Point(749, 275);
            this.numUDQtdItemRetirar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQtdItemRetirar.Name = "numUDQtdItemRetirar";
            this.numUDQtdItemRetirar.Size = new System.Drawing.Size(70, 34);
            this.numUDQtdItemRetirar.TabIndex = 10;
            this.numUDQtdItemRetirar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQtdItemRetirar.ValueChanged += new System.EventHandler(this.numUDQtdItemRetirar_ValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(879, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Valor";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(770, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Qtd.";
            // 
            // numUDQtdItemAdicionar
            // 
            this.numUDQtdItemAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDQtdItemAdicionar.BackColor = System.Drawing.Color.White;
            this.numUDQtdItemAdicionar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUDQtdItemAdicionar.Enabled = false;
            this.numUDQtdItemAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDQtdItemAdicionar.Location = new System.Drawing.Point(752, 456);
            this.numUDQtdItemAdicionar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQtdItemAdicionar.Name = "numUDQtdItemAdicionar";
            this.numUDQtdItemAdicionar.Size = new System.Drawing.Size(70, 34);
            this.numUDQtdItemAdicionar.TabIndex = 5;
            this.numUDQtdItemAdicionar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQtdItemAdicionar.ValueChanged += new System.EventHandler(this.numUDQtdItemAdicionar_ValueChanged);
            // 
            // mskBValorAdicionar
            // 
            this.mskBValorAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBValorAdicionar.BackColor = System.Drawing.Color.White;
            this.mskBValorAdicionar.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskBValorAdicionar.Enabled = false;
            this.mskBValorAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBValorAdicionar.Location = new System.Drawing.Point(828, 455);
            this.mskBValorAdicionar.Name = "mskBValorAdicionar";
            this.mskBValorAdicionar.Size = new System.Drawing.Size(132, 35);
            this.mskBValorAdicionar.TabIndex = 6;
            // 
            // btnIncluirCampoCliente
            // 
            this.btnIncluirCampoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluirCampoCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncluirCampoCliente.Enabled = false;
            this.btnIncluirCampoCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirCampoCliente.Location = new System.Drawing.Point(493, 72);
            this.btnIncluirCampoCliente.Name = "btnIncluirCampoCliente";
            this.btnIncluirCampoCliente.Size = new System.Drawing.Size(67, 25);
            this.btnIncluirCampoCliente.TabIndex = 1;
            this.btnIncluirCampoCliente.Text = "Incluir";
            this.btnIncluirCampoCliente.UseVisualStyleBackColor = false;
            this.btnIncluirCampoCliente.Click += new System.EventHandler(this.btnIncluirCliente_Click);
            // 
            // comboBoxRetirar
            // 
            this.comboBoxRetirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRetirar.BackColor = System.Drawing.Color.White;
            this.comboBoxRetirar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxRetirar.Enabled = false;
            this.comboBoxRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRetirar.FormattingEnabled = true;
            this.comboBoxRetirar.Location = new System.Drawing.Point(490, 274);
            this.comboBoxRetirar.Name = "comboBoxRetirar";
            this.comboBoxRetirar.Size = new System.Drawing.Size(251, 37);
            this.comboBoxRetirar.TabIndex = 75;
            this.comboBoxRetirar.SelectionChangeCommitted += new System.EventHandler(this.SelectItemRetirar_cbBox);
            // 
            // lsViewCarrinho
            // 
            this.lsViewCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsViewCarrinho.BackColor = System.Drawing.Color.Moccasin;
            this.lsViewCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsViewCarrinho.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsViewCarrinho.FormattingEnabled = true;
            this.lsViewCarrinho.ItemHeight = 28;
            this.lsViewCarrinho.Location = new System.Drawing.Point(14, 42);
            this.lsViewCarrinho.Name = "lsViewCarrinho";
            this.lsViewCarrinho.Size = new System.Drawing.Size(441, 562);
            this.lsViewCarrinho.TabIndex = 77;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(518, 289);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 79;
            this.lblID.Text = "0";
            // 
            // barraFormulario
            // 
            this.barraFormulario.BackColor = System.Drawing.Color.SaddleBrown;
            this.barraFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraFormulario.Location = new System.Drawing.Point(0, 0);
            this.barraFormulario.Name = "barraFormulario";
            this.barraFormulario.Size = new System.Drawing.Size(1002, 25);
            this.barraFormulario.TabIndex = 54;
            this.barraFormulario.TabStop = false;
            this.barraFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.barraFormulario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.barraFormulario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
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
            this.btnFechar.Location = new System.Drawing.Point(980, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 26);
            this.btnFechar.TabIndex = 60;
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
            this.btnMinimizar.Location = new System.Drawing.Point(930, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 25);
            this.btnMinimizar.TabIndex = 59;
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
            this.bntMaximizar.Location = new System.Drawing.Point(955, -1);
            this.bntMaximizar.Name = "bntMaximizar";
            this.bntMaximizar.Size = new System.Drawing.Size(24, 25);
            this.bntMaximizar.TabIndex = 58;
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
            this.btnNormal.Location = new System.Drawing.Point(955, 0);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(24, 25);
            this.btnNormal.TabIndex = 61;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            this.btnNormal.MouseLeave += new System.EventHandler(this.LeaveNormal);
            this.btnNormal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlNormal);
            // 
            // APSvendas
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(1002, 716);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bntMaximizar);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.barraFormulario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "APSvendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelNCN.ResumeLayout(false);
            this.panelNCN.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQtdItemRetirar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQtdItemAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskBCodeBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskBValortotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskBCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskBNascimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelNCN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvarPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnLimparRetirar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskBValorItemRetirado;
        private System.Windows.Forms.Button btnLimparAdicionar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numUDQtdItemRetirar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUDQtdItemAdicionar;
        private System.Windows.Forms.MaskedTextBox mskBValorAdicionar;
        private System.Windows.Forms.Button btnIncluirCampoCliente;
        private System.Windows.Forms.PictureBox barraFormulario;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button bntMaximizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox comboBoxAdicionar;
        private System.Windows.Forms.Button btnPular;
        private System.Windows.Forms.Button btnLimparClient;
        private System.Windows.Forms.TextBox mskBNome;
        private System.Windows.Forms.MaskedTextBox mskAdicionarItem;
        private System.Windows.Forms.MaskedTextBox mskBRetirarItem;
        private System.Windows.Forms.ComboBox comboBoxRetirar;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.ListBox lsViewCarrinho;
        private System.Windows.Forms.Button btnEnterPedido;
        private System.Windows.Forms.Label lblID;
    }
}