namespace InsightCoffe.Utilidades
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
            this.lsViewCarrinho = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.panelNCN = new System.Windows.Forms.Panel();
            this.mskBNome = new System.Windows.Forms.TextBox();
            this.btnLimparClient = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mskRetirarItem = new System.Windows.Forms.MaskedTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.mskAdcionarItem = new System.Windows.Forms.MaskedTextBox();
            this.btnPular = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.mskBCodeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBCodeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBCodeBar.Location = new System.Drawing.Point(342, 53);
            this.mskBCodeBar.Name = "mskBCodeBar";
            this.mskBCodeBar.Size = new System.Drawing.Size(520, 26);
            this.mskBCodeBar.TabIndex = 1;
            this.mskBCodeBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_CodigoBar);
            this.mskBCodeBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CodigoBar);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 58);
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
            this.label3.Location = new System.Drawing.Point(555, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo do Produto";
            // 
            // mskBValortotal
            // 
            this.mskBValortotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBValortotal.Enabled = false;
            this.mskBValortotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBValortotal.Location = new System.Drawing.Point(482, 431);
            this.mskBValortotal.Mask = "$";
            this.mskBValortotal.Name = "mskBValortotal";
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
            this.label4.Location = new System.Drawing.Point(478, 404);
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
            this.label5.Location = new System.Drawing.Point(37, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome:";
            // 
            // mskBCPF
            // 
            this.mskBCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBCPF.Enabled = false;
            this.mskBCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBCPF.Location = new System.Drawing.Point(99, 56);
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
            this.label7.Location = new System.Drawing.Point(49, 62);
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
            this.label8.Location = new System.Drawing.Point(264, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nascimento:";
            // 
            // mskBNascimento
            // 
            this.mskBNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBNascimento.Enabled = false;
            this.mskBNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBNascimento.Location = new System.Drawing.Point(382, 56);
            this.mskBNascimento.Mask = "00/00/0000";
            this.mskBNascimento.Name = "mskBNascimento";
            this.mskBNascimento.Size = new System.Drawing.Size(108, 29);
            this.mskBNascimento.TabIndex = 3;
            this.mskBNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskBNascimento.ValidatingType = typeof(System.DateTime);
            this.mskBNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Nascimeto);
            // 
            // lsViewCarrinho
            // 
            this.lsViewCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsViewCarrinho.HideSelection = false;
            this.lsViewCarrinho.Location = new System.Drawing.Point(11, 19);
            this.lsViewCarrinho.Name = "lsViewCarrinho";
            this.lsViewCarrinho.Size = new System.Drawing.Size(389, 508);
            this.lsViewCarrinho.TabIndex = 48;
            this.lsViewCarrinho.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(563, 174);
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
            this.panelNCN.Location = new System.Drawing.Point(416, 27);
            this.panelNCN.Name = "panelNCN";
            this.panelNCN.Size = new System.Drawing.Size(529, 125);
            this.panelNCN.TabIndex = 3;
            // 
            // mskBNome
            // 
            this.mskBNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mskBNome.Enabled = false;
            this.mskBNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.mskBNome.Location = new System.Drawing.Point(99, 19);
            this.mskBNome.Name = "mskBNome";
            this.mskBNome.Size = new System.Drawing.Size(391, 29);
            this.mskBNome.TabIndex = 1;
            // 
            // btnLimparClient
            // 
            this.btnLimparClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparClient.Enabled = false;
            this.btnLimparClient.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparClient.Location = new System.Drawing.Point(298, 97);
            this.btnLimparClient.Name = "btnLimparClient";
            this.btnLimparClient.Size = new System.Drawing.Size(84, 25);
            this.btnLimparClient.TabIndex = 5;
            this.btnLimparClient.Text = "Limpar";
            this.btnLimparClient.UseVisualStyleBackColor = true;
            this.btnLimparClient.Click += new System.EventHandler(this.btnLimparClient_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.Enabled = false;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(407, 97);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(84, 25);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(230, 97);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(67, 25);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.mskAdcionarItem);
            this.panel2.Controls.Add(this.mskRetirarItem);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.btnPular);
            this.panel2.Controls.Add(this.comboBox1);
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
            this.panel2.Controls.Add(this.lsViewCarrinho);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.mskBValortotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panelNCN);
            this.panel2.Location = new System.Drawing.Point(19, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 545);
            this.panel2.TabIndex = 2;
            // 
            // mskRetirarItem
            // 
            this.mskRetirarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mskRetirarItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskRetirarItem.Font = new System.Drawing.Font("GeoSlab703 MdCn BT", 18F);
            this.mskRetirarItem.Location = new System.Drawing.Point(443, 192);
            this.mskRetirarItem.Name = "mskRetirarItem";
            this.mskRetirarItem.Size = new System.Drawing.Size(253, 29);
            this.mskRetirarItem.TabIndex = 77;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Font = new System.Drawing.Font("GeoSlab703 MdCn BT", 18F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(440, 188);
            this.comboBox2.MaxDropDownItems = 4;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(274, 37);
            this.comboBox2.TabIndex = 76;
            // 
            // mskAdcionarItem
            // 
            this.mskAdcionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mskAdcionarItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskAdcionarItem.Font = new System.Drawing.Font("GeoSlab703 MdCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAdcionarItem.Location = new System.Drawing.Point(446, 303);
            this.mskAdcionarItem.Name = "mskAdcionarItem";
            this.mskAdcionarItem.Size = new System.Drawing.Size(250, 29);
            this.mskAdcionarItem.TabIndex = 75;
            this.mskAdcionarItem.TextChanged += new System.EventHandler(this.TextChanged_mskBox);
            this.mskAdcionarItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_MskAdicionar);
            // 
            // btnPular
            // 
            this.btnPular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPular.Enabled = false;
            this.btnPular.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPular.Location = new System.Drawing.Point(501, 14);
            this.btnPular.Name = "btnPular";
            this.btnPular.Size = new System.Drawing.Size(67, 25);
            this.btnPular.TabIndex = 2;
            this.btnPular.Text = "Pular";
            this.btnPular.UseVisualStyleBackColor = true;
            this.btnPular.Click += new System.EventHandler(this.btnPular_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("GeoSlab703 MdCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(443, 299);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(271, 37);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnLimparRetirar
            // 
            this.btnLimparRetirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparRetirar.Enabled = false;
            this.btnLimparRetirar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparRetirar.Location = new System.Drawing.Point(775, 231);
            this.btnLimparRetirar.Name = "btnLimparRetirar";
            this.btnLimparRetirar.Size = new System.Drawing.Size(153, 29);
            this.btnLimparRetirar.TabIndex = 13;
            this.btnLimparRetirar.Text = "Limpar";
            this.btnLimparRetirar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(839, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Valor";
            // 
            // mskBValorItemRetirado
            // 
            this.mskBValorItemRetirado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBValorItemRetirado.Enabled = false;
            this.mskBValorItemRetirado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBValorItemRetirado.Location = new System.Drawing.Point(796, 188);
            this.mskBValorItemRetirado.Name = "mskBValorItemRetirado";
            this.mskBValorItemRetirado.Size = new System.Drawing.Size(132, 35);
            this.mskBValorItemRetirado.TabIndex = 11;
            // 
            // btnLimparAdicionar
            // 
            this.btnLimparAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparAdicionar.Enabled = false;
            this.btnLimparAdicionar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAdicionar.Location = new System.Drawing.Point(778, 342);
            this.btnLimparAdicionar.Name = "btnLimparAdicionar";
            this.btnLimparAdicionar.Size = new System.Drawing.Size(150, 29);
            this.btnLimparAdicionar.TabIndex = 8;
            this.btnLimparAdicionar.Text = "Limpar";
            this.btnLimparAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(443, 342);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(329, 29);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarPedido.Enabled = false;
            this.btnSalvarPedido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPedido.Location = new System.Drawing.Point(482, 487);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(214, 40);
            this.btnSalvarPedido.TabIndex = 14;
            this.btnSalvarPedido.Text = "Salvar Pedido";
            this.btnSalvarPedido.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarPedido.Enabled = false;
            this.btnCancelarPedido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPedido.Location = new System.Drawing.Point(701, 487);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(144, 40);
            this.btnCancelarPedido.TabIndex = 15;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetirar.Enabled = false;
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(440, 231);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(329, 29);
            this.btnRetirar.TabIndex = 12;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(734, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Qtd.";
            // 
            // numUDQtdItemRetirar
            // 
            this.numUDQtdItemRetirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDQtdItemRetirar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUDQtdItemRetirar.Enabled = false;
            this.numUDQtdItemRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDQtdItemRetirar.Location = new System.Drawing.Point(720, 189);
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
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(846, 285);
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
            this.label6.Location = new System.Drawing.Point(739, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Qtd.";
            // 
            // numUDQtdItemAdicionar
            // 
            this.numUDQtdItemAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDQtdItemAdicionar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUDQtdItemAdicionar.Enabled = false;
            this.numUDQtdItemAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDQtdItemAdicionar.Location = new System.Drawing.Point(720, 300);
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
            this.numUDQtdItemAdicionar.ValueChanged += new System.EventHandler(this.ValueChanged_QtdAdicionar);
            // 
            // mskBValorAdicionar
            // 
            this.mskBValorAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mskBValorAdicionar.Enabled = false;
            this.mskBValorAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskBValorAdicionar.Location = new System.Drawing.Point(796, 299);
            this.mskBValorAdicionar.Name = "mskBValorAdicionar";
            this.mskBValorAdicionar.Size = new System.Drawing.Size(132, 35);
            this.mskBValorAdicionar.TabIndex = 6;
            // 
            // btnIncluirCampoCliente
            // 
            this.btnIncluirCampoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluirCampoCliente.Enabled = false;
            this.btnIncluirCampoCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirCampoCliente.Location = new System.Drawing.Point(428, 14);
            this.btnIncluirCampoCliente.Name = "btnIncluirCampoCliente";
            this.btnIncluirCampoCliente.Size = new System.Drawing.Size(67, 25);
            this.btnIncluirCampoCliente.TabIndex = 1;
            this.btnIncluirCampoCliente.Text = "Incluir";
            this.btnIncluirCampoCliente.UseVisualStyleBackColor = true;
            this.btnIncluirCampoCliente.Click += new System.EventHandler(this.btnIncluirPedido_Click);
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
            this.bntMaximizar.Location = new System.Drawing.Point(955, 0);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1002, 647);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskBCodeBar);
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
        private System.Windows.Forms.ListView lsViewCarrinho;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPular;
        private System.Windows.Forms.Button btnLimparClient;
        private System.Windows.Forms.TextBox mskBNome;
        private System.Windows.Forms.MaskedTextBox mskAdcionarItem;
        private System.Windows.Forms.MaskedTextBox mskRetirarItem;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}