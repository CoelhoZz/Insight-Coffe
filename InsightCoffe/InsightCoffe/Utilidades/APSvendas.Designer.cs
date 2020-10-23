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
            this.maskedBCodeBar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskTBCodigoDeBarras = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedBNome = new System.Windows.Forms.MaskedTextBox();
            this.maskedBCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedBNascimento = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedBRetirarItem = new System.Windows.Forms.MaskedTextBox();
            this.panelNCN = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedBValorItem = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numUDQtdItem = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedBQtdCode = new System.Windows.Forms.NumericUpDown();
            this.maskedBValorCode = new System.Windows.Forms.MaskedTextBox();
            this.btnExistente = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.bntMaximizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.panelNCN.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQtdItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskedBQtdCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // maskedBCodeBar
            // 
            this.maskedBCodeBar.AllowDrop = true;
            this.maskedBCodeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedBCodeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedBCodeBar.Location = new System.Drawing.Point(342, 53);
            this.maskedBCodeBar.Name = "maskedBCodeBar";
            this.maskedBCodeBar.Size = new System.Drawing.Size(517, 26);
            this.maskedBCodeBar.TabIndex = 5;
            this.maskedBCodeBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_CodigoBar);
            this.maskedBCodeBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CodigoBar);
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
            // maskTBCodigoDeBarras
            // 
            this.maskTBCodigoDeBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskTBCodigoDeBarras.Enabled = false;
            this.maskTBCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTBCodigoDeBarras.Location = new System.Drawing.Point(500, 283);
            this.maskTBCodigoDeBarras.Name = "maskTBCodigoDeBarras";
            this.maskTBCodigoDeBarras.Size = new System.Drawing.Size(181, 35);
            this.maskTBCodigoDeBarras.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(537, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo do Produto";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(500, 435);
            this.maskedTextBox2.Mask = "$";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(181, 35);
            this.maskedTextBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(496, 408);
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
            // maskedBNome
            // 
            this.maskedBNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedBNome.Enabled = false;
            this.maskedBNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedBNome.Location = new System.Drawing.Point(108, 18);
            this.maskedBNome.Name = "maskedBNome";
            this.maskedBNome.Size = new System.Drawing.Size(385, 29);
            this.maskedBNome.TabIndex = 18;
            // 
            // maskedBCPF
            // 
            this.maskedBCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedBCPF.Enabled = false;
            this.maskedBCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedBCPF.Location = new System.Drawing.Point(108, 54);
            this.maskedBCPF.Mask = "000,000,000-00";
            this.maskedBCPF.Name = "maskedBCPF";
            this.maskedBCPF.Size = new System.Drawing.Size(144, 29);
            this.maskedBCPF.TabIndex = 20;
            this.maskedBCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CPF);
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
            // maskedBNascimento
            // 
            this.maskedBNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedBNascimento.Enabled = false;
            this.maskedBNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedBNascimento.Location = new System.Drawing.Point(385, 54);
            this.maskedBNascimento.Mask = "00/00/0000";
            this.maskedBNascimento.Name = "maskedBNascimento";
            this.maskedBNascimento.Size = new System.Drawing.Size(108, 29);
            this.maskedBNascimento.TabIndex = 22;
            this.maskedBNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(414, 508);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(559, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Retirar item";
            // 
            // maskedBRetirarItem
            // 
            this.maskedBRetirarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedBRetirarItem.Enabled = false;
            this.maskedBRetirarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedBRetirarItem.Location = new System.Drawing.Point(500, 172);
            this.maskedBRetirarItem.Name = "maskedBRetirarItem";
            this.maskedBRetirarItem.Size = new System.Drawing.Size(181, 35);
            this.maskedBRetirarItem.TabIndex = 49;
            // 
            // panelNCN
            // 
            this.panelNCN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNCN.AutoSize = true;
            this.panelNCN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelNCN.Controls.Add(this.maskedBNascimento);
            this.panelNCN.Controls.Add(this.maskedBNome);
            this.panelNCN.Controls.Add(this.label8);
            this.panelNCN.Controls.Add(this.maskedBCPF);
            this.panelNCN.Controls.Add(this.label5);
            this.panelNCN.Controls.Add(this.label7);
            this.panelNCN.Location = new System.Drawing.Point(443, 27);
            this.panelNCN.Name = "panelNCN";
            this.panelNCN.Size = new System.Drawing.Size(501, 100);
            this.panelNCN.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.btnProcurar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.maskedBValorItem);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.numUDQtdItem);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.maskedBQtdCode);
            this.panel2.Controls.Add(this.maskedBValorCode);
            this.panel2.Controls.Add(this.btnExistente);
            this.panel2.Controls.Add(this.btnNovoCliente);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.maskedBRetirarItem);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.maskTBCodigoDeBarras);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.maskedTextBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panelNCN);
            this.panel2.Location = new System.Drawing.Point(18, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 545);
            this.panel2.TabIndex = 53;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.Enabled = false;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(849, 116);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(84, 25);
            this.btnProcurar.TabIndex = 77;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(776, 116);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(67, 25);
            this.btnSalvar.TabIndex = 76;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(763, 212);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 29);
            this.button6.TabIndex = 75;
            this.button6.Text = "Limpar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(806, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Valor";
            // 
            // maskedBValorItem
            // 
            this.maskedBValorItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedBValorItem.Enabled = false;
            this.maskedBValorItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedBValorItem.Location = new System.Drawing.Point(763, 171);
            this.maskedBValorItem.Mask = "$";
            this.maskedBValorItem.Name = "maskedBValorItem";
            this.maskedBValorItem.Size = new System.Drawing.Size(132, 35);
            this.maskedBValorItem.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(763, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 72;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(500, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 29);
            this.button4.TabIndex = 71;
            this.button4.Text = "Adicionar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(479, 487);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(214, 40);
            this.button7.TabIndex = 56;
            this.button7.Text = "Salvar Pedido";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(698, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 40);
            this.button3.TabIndex = 57;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(500, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 29);
            this.button5.TabIndex = 62;
            this.button5.Text = "Retirar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(701, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Qtd.";
            // 
            // numUDQtdItem
            // 
            this.numUDQtdItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDQtdItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUDQtdItem.Enabled = false;
            this.numUDQtdItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDQtdItem.Location = new System.Drawing.Point(687, 172);
            this.numUDQtdItem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQtdItem.Name = "numUDQtdItem";
            this.numUDQtdItem.Size = new System.Drawing.Size(70, 34);
            this.numUDQtdItem.TabIndex = 69;
            this.numUDQtdItem.Value = new decimal(new int[] {
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
            this.label10.Location = new System.Drawing.Point(806, 266);
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
            this.label6.Location = new System.Drawing.Point(701, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Qtd.";
            // 
            // maskedBQtdCode
            // 
            this.maskedBQtdCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedBQtdCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedBQtdCode.Enabled = false;
            this.maskedBQtdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedBQtdCode.Location = new System.Drawing.Point(687, 283);
            this.maskedBQtdCode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maskedBQtdCode.Name = "maskedBQtdCode";
            this.maskedBQtdCode.Size = new System.Drawing.Size(70, 34);
            this.maskedBQtdCode.TabIndex = 65;
            this.maskedBQtdCode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maskedBValorCode
            // 
            this.maskedBValorCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedBValorCode.Enabled = false;
            this.maskedBValorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedBValorCode.Location = new System.Drawing.Point(763, 282);
            this.maskedBValorCode.Mask = "$";
            this.maskedBValorCode.Name = "maskedBValorCode";
            this.maskedBValorCode.Size = new System.Drawing.Size(132, 35);
            this.maskedBValorCode.TabIndex = 64;
            // 
            // btnExistente
            // 
            this.btnExistente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExistente.Enabled = false;
            this.btnExistente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistente.Location = new System.Drawing.Point(563, 10);
            this.btnExistente.Name = "btnExistente";
            this.btnExistente.Size = new System.Drawing.Size(75, 25);
            this.btnExistente.TabIndex = 63;
            this.btnExistente.Text = "Existente";
            this.btnExistente.UseVisualStyleBackColor = true;
            this.btnExistente.Click += new System.EventHandler(this.btnExistente_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoCliente.Enabled = false;
            this.btnNovoCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.Location = new System.Drawing.Point(490, 11);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(67, 25);
            this.btnNovoCliente.TabIndex = 62;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 25);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
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
            this.btnFechar.Location = new System.Drawing.Point(977, -1);
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
            this.btnMinimizar.Location = new System.Drawing.Point(927, 0);
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
            this.bntMaximizar.Location = new System.Drawing.Point(952, 0);
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
            this.btnNormal.Location = new System.Drawing.Point(952, 0);
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
            this.ClientSize = new System.Drawing.Size(999, 647);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedBCodeBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bntMaximizar);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "APSvendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Pedidos";
            this.panelNCN.ResumeLayout(false);
            this.panelNCN.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQtdItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskedBQtdCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedBCodeBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskTBCodigoDeBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedBNome;
        private System.Windows.Forms.MaskedTextBox maskedBCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedBNascimento;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedBRetirarItem;
        private System.Windows.Forms.Panel panelNCN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedBValorItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numUDQtdItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown maskedBQtdCode;
        private System.Windows.Forms.MaskedTextBox maskedBValorCode;
        private System.Windows.Forms.Button btnExistente;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button bntMaximizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnSalvar;
    }
}