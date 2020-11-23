namespace InsightCoffe.Utilidades
{
    partial class PainelInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelInicial));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ferramentasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.notepadStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharTodosStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.consultasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RegPedidosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RegProdutosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RegClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarra = new System.Windows.Forms.StatusStrip();
            this.toolStrip_lblusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.xuiBusuario = new XanderUI.XUIButton();
            this.btnMostrarAplicações = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.bntMaximizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picIconeRelogio = new System.Windows.Forms.PictureBox();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.timerTempoReal = new System.Windows.Forms.Timer(this.components);
            this.panelAplicações = new System.Windows.Forms.Panel();
            this.btnComandas = new XanderUI.XUIButton();
            this.btnEdiçãoCliente = new XanderUI.XUIButton();
            this.btnProdutos = new XanderUI.XUIButton();
            this.btnVendas = new XanderUI.XUIButton();
            this.btnPagamento = new XanderUI.XUIButton();
            this.xuiCustomPictureBox1 = new XanderUI.XUICustomPictureBox();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.menuStrip.SuspendLayout();
            this.statusBarra.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeRelogio)).BeginInit();
            this.panelAplicações.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 50, 0, 2);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ferramentasMenu,
            this.consultasMenu,
            this.editMenu,
            this.viewMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(199, 97);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(464, 33);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // ferramentasMenu
            // 
            this.ferramentasMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.ferramentasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagamentoToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.toolStripSeparator2,
            this.notepadStripMenuItem4,
            this.toolStripSeparator1,
            this.fecharTodosStripMenuItem3,
            this.toolStripSeparator9});
            this.ferramentasMenu.Name = "ferramentasMenu";
            this.ferramentasMenu.Size = new System.Drawing.Size(130, 29);
            this.ferramentasMenu.Text = "&Ferramentas";
            // 
            // pagamentoToolStripMenuItem
            // 
            this.pagamentoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.pagamentoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pagamentoToolStripMenuItem.Image")));
            this.pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            this.pagamentoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.pagamentoToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.pagamentoToolStripMenuItem.Text = "Pagamento";
            this.pagamentoToolStripMenuItem.Click += new System.EventHandler(this.pagamentosToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.pedidosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidosToolStripMenuItem.Image")));
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.pedidosToolStripMenuItem.Text = "Pedido";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(245, 6);
            // 
            // notepadStripMenuItem4
            // 
            this.notepadStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.notepadStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("notepadStripMenuItem4.Image")));
            this.notepadStripMenuItem4.Name = "notepadStripMenuItem4";
            this.notepadStripMenuItem4.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.notepadStripMenuItem4.Size = new System.Drawing.Size(248, 30);
            this.notepadStripMenuItem4.Text = "Bloco de Notas";
            this.notepadStripMenuItem4.Click += new System.EventHandler(this.BlocoAnotaçõestoolStripMenuItem4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // fecharTodosStripMenuItem3
            // 
            this.fecharTodosStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.fecharTodosStripMenuItem3.Name = "fecharTodosStripMenuItem3";
            this.fecharTodosStripMenuItem3.Size = new System.Drawing.Size(248, 30);
            this.fecharTodosStripMenuItem3.Text = "Fec&har todos";
            this.fecharTodosStripMenuItem3.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(245, 6);
            // 
            // consultasMenu
            // 
            this.consultasMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.consultasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegPedidosToolStripMenuItem2,
            this.toolStripSeparator3,
            this.RegProdutosToolStripMenuItem1,
            this.RegClientToolStripMenuItem,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.toolStripSeparator5});
            this.consultasMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.consultasMenu.Name = "consultasMenu";
            this.consultasMenu.Size = new System.Drawing.Size(107, 29);
            this.consultasMenu.Text = "&Consultas";
            // 
            // RegPedidosToolStripMenuItem2
            // 
            this.RegPedidosToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.RegPedidosToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("RegPedidosToolStripMenuItem2.Image")));
            this.RegPedidosToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Black;
            this.RegPedidosToolStripMenuItem2.Name = "RegPedidosToolStripMenuItem2";
            this.RegPedidosToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F8)));
            this.RegPedidosToolStripMenuItem2.Size = new System.Drawing.Size(363, 30);
            this.RegPedidosToolStripMenuItem2.Text = "Registro de Pedido";
            this.RegPedidosToolStripMenuItem2.Click += new System.EventHandler(this.RegPedidostoolStripMenuItem2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(360, 6);
            // 
            // RegProdutosToolStripMenuItem1
            // 
            this.RegProdutosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.RegProdutosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("RegProdutosToolStripMenuItem1.Image")));
            this.RegProdutosToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.RegProdutosToolStripMenuItem1.Name = "RegProdutosToolStripMenuItem1";
            this.RegProdutosToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.RegProdutosToolStripMenuItem1.Size = new System.Drawing.Size(363, 30);
            this.RegProdutosToolStripMenuItem1.Text = "Registro de Produtos";
            this.RegProdutosToolStripMenuItem1.Click += new System.EventHandler(this.RegProdutostoolStripMenuItem1_Click);
            // 
            // RegClientToolStripMenuItem
            // 
            this.RegClientToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.RegClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RegClientToolStripMenuItem.Image")));
            this.RegClientToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.RegClientToolStripMenuItem.Name = "RegClientToolStripMenuItem";
            this.RegClientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.RegClientToolStripMenuItem.Size = new System.Drawing.Size(363, 30);
            this.RegClientToolStripMenuItem.Text = "Registro de Clientes";
            this.RegClientToolStripMenuItem.Click += new System.EventHandler(this.RegClientestoolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(360, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(363, 30);
            this.printToolStripMenuItem.Text = "Registro de Pagamentos";
            this.printToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(360, 6);
            this.toolStripSeparator5.Visible = false;
            // 
            // editMenu
            // 
            this.editMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEditarProduto,
            this.copyToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.toolStripSeparator6,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator7});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(74, 29);
            this.editMenu.Text = "&Editar";
            // 
            // toolStripEditarProduto
            // 
            this.toolStripEditarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.toolStripEditarProduto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEditarProduto.Image")));
            this.toolStripEditarProduto.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripEditarProduto.Name = "toolStripEditarProduto";
            this.toolStripEditarProduto.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.toolStripEditarProduto.Size = new System.Drawing.Size(276, 30);
            this.toolStripEditarProduto.Text = "&Produtos";
            this.toolStripEditarProduto.Click += new System.EventHandler(this.toolStripEditarProduto_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.copyToolStripMenuItem.Text = "&Comandas";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.ToolStripEditarComanda_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.undoToolStripMenuItem.Text = "&Clientes";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(273, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.cutToolStripMenuItem.Text = "&Limpar Comanda";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLimparComanda_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.pasteToolStripMenuItem.Text = "&Excluir Pagamento";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(273, 6);
            // 
            // viewMenu
            // 
            this.viewMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(71, 29);
            this.viewMenu.Text = "&Exibir";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.toolBarToolStripMenuItem.Text = "&Barra de Ferramentas";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.statusBarToolStripMenuItem.Text = "&Barra de Status";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(74, 29);
            this.helpMenu.Text = "&Ajuda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.contentsToolStripMenuItem.Text = "&Conteúdo";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(240, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.aboutToolStripMenuItem.Text = "&Sobre ... ...";
            // 
            // statusBarra
            // 
            this.statusBarra.BackColor = System.Drawing.Color.SaddleBrown;
            this.statusBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_lblusuario,
            this.toolStripStatusLabel1});
            this.statusBarra.Location = new System.Drawing.Point(0, 698);
            this.statusBarra.Name = "statusBarra";
            this.statusBarra.Size = new System.Drawing.Size(1186, 22);
            this.statusBarra.TabIndex = 2;
            this.statusBarra.Text = "StatusStrip";
            // 
            // toolStrip_lblusuario
            // 
            this.toolStrip_lblusuario.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip_lblusuario.ForeColor = System.Drawing.Color.Goldenrod;
            this.toolStrip_lblusuario.Name = "toolStrip_lblusuario";
            this.toolStrip_lblusuario.Size = new System.Drawing.Size(53, 17);
            this.toolStrip_lblusuario.Text = "Usuario: ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.panelCabecalho.Controls.Add(this.xuiBusuario);
            this.panelCabecalho.Controls.Add(this.btnMostrarAplicações);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Controls.Add(this.btnMinimizar);
            this.panelCabecalho.Controls.Add(this.menuStrip);
            this.panelCabecalho.Controls.Add(this.btnNormal);
            this.panelCabecalho.Controls.Add(this.bntMaximizar);
            this.panelCabecalho.Controls.Add(this.pictureBox1);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1186, 140);
            this.panelCabecalho.TabIndex = 0;
            // 
            // xuiBusuario
            // 
            this.xuiBusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiBusuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.xuiBusuario.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiBusuario.ButtonImage")));
            this.xuiBusuario.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiBusuario.ButtonText = "Usuario:";
            this.xuiBusuario.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(139)))), ((int)(((byte)(21)))));
            this.xuiBusuario.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiBusuario.CornerRadius = 5;
            this.xuiBusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBusuario.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBusuario.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(31)))));
            this.xuiBusuario.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.xuiBusuario.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.xuiBusuario.Location = new System.Drawing.Point(954, 34);
            this.xuiBusuario.Name = "xuiBusuario";
            this.xuiBusuario.Size = new System.Drawing.Size(220, 42);
            this.xuiBusuario.TabIndex = 63;
            this.xuiBusuario.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiBusuario.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBusuario.Click += new System.EventHandler(this.xuiBusuario_Click);
            // 
            // btnMostrarAplicações
            // 
            this.btnMostrarAplicações.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.btnMostrarAplicações.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarAplicações.BackgroundImage")));
            this.btnMostrarAplicações.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarAplicações.FlatAppearance.BorderSize = 0;
            this.btnMostrarAplicações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarAplicações.Location = new System.Drawing.Point(0, 26);
            this.btnMostrarAplicações.Name = "btnMostrarAplicações";
            this.btnMostrarAplicações.Size = new System.Drawing.Size(204, 114);
            this.btnMostrarAplicações.TabIndex = 1;
            this.btnMostrarAplicações.UseVisualStyleBackColor = false;
            this.btnMostrarAplicações.Click += new System.EventHandler(this.bntMostrarAplicações_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(1164, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 26);
            this.btnFechar.TabIndex = 6;
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
            this.btnMinimizar.Location = new System.Drawing.Point(1114, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 25);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.LeaveMinimizar);
            this.btnMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMinimizar);
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
            this.btnNormal.Location = new System.Drawing.Point(1139, 0);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(24, 25);
            this.btnNormal.TabIndex = 5;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            this.btnNormal.MouseLeave += new System.EventHandler(this.LeaveNormal);
            this.btnNormal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlNormal);
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
            this.bntMaximizar.Location = new System.Drawing.Point(1139, 0);
            this.bntMaximizar.Name = "bntMaximizar";
            this.bntMaximizar.Size = new System.Drawing.Size(24, 25);
            this.bntMaximizar.TabIndex = 55;
            this.bntMaximizar.UseVisualStyleBackColor = false;
            this.bntMaximizar.Visible = false;
            this.bntMaximizar.Click += new System.EventHandler(this.bntMaximizar_Click);
            this.bntMaximizar.MouseLeave += new System.EventHandler(this.LeaveMaximizar);
            this.bntMaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlMaximizar);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1186, 25);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // picIconeRelogio
            // 
            this.picIconeRelogio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picIconeRelogio.BackColor = System.Drawing.Color.Transparent;
            this.picIconeRelogio.Image = ((System.Drawing.Image)(resources.GetObject("picIconeRelogio.Image")));
            this.picIconeRelogio.Location = new System.Drawing.Point(102, 500);
            this.picIconeRelogio.Name = "picIconeRelogio";
            this.picIconeRelogio.Size = new System.Drawing.Size(47, 42);
            this.picIconeRelogio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconeRelogio.TabIndex = 66;
            this.picIconeRelogio.TabStop = false;
            // 
            // lblRelogio
            // 
            this.lblRelogio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.BackColor = System.Drawing.Color.Transparent;
            this.lblRelogio.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(37, 500);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(84, 42);
            this.lblRelogio.TabIndex = 0;
            this.lblRelogio.Text = "00:00";
            this.lblRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerTempoReal
            // 
            this.timerTempoReal.Enabled = true;
            this.timerTempoReal.Interval = 1000;
            // 
            // panelAplicações
            // 
            this.panelAplicações.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))));
            this.panelAplicações.Controls.Add(this.btnComandas);
            this.panelAplicações.Controls.Add(this.btnEdiçãoCliente);
            this.panelAplicações.Controls.Add(this.picIconeRelogio);
            this.panelAplicações.Controls.Add(this.lblRelogio);
            this.panelAplicações.Controls.Add(this.btnProdutos);
            this.panelAplicações.Controls.Add(this.btnVendas);
            this.panelAplicações.Controls.Add(this.btnPagamento);
            this.panelAplicações.Controls.Add(this.xuiCustomPictureBox1);
            this.panelAplicações.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAplicações.Location = new System.Drawing.Point(0, 140);
            this.panelAplicações.Name = "panelAplicações";
            this.panelAplicações.Size = new System.Drawing.Size(204, 558);
            this.panelAplicações.TabIndex = 1;
            this.panelAplicações.Visible = false;
            // 
            // btnComandas
            // 
            this.btnComandas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))));
            this.btnComandas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComandas.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnComandas.ButtonImage")));
            this.btnComandas.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnComandas.ButtonText = "Comandas";
            this.btnComandas.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.btnComandas.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(101)))), ((int)(((byte)(22)))));
            this.btnComandas.CornerRadius = 5;
            this.btnComandas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnComandas.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnComandas.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(151)))), ((int)(((byte)(52)))));
            this.btnComandas.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(91)))), ((int)(((byte)(12)))));
            this.btnComandas.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnComandas.Location = new System.Drawing.Point(6, 257);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(186, 69);
            this.btnComandas.TabIndex = 68;
            this.btnComandas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(81)))), ((int)(((byte)(2)))));
            this.btnComandas.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            // 
            // btnEdiçãoCliente
            // 
            this.btnEdiçãoCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))));
            this.btnEdiçãoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdiçãoCliente.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEdiçãoCliente.ButtonImage")));
            this.btnEdiçãoCliente.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnEdiçãoCliente.ButtonText = "Clientes";
            this.btnEdiçãoCliente.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.btnEdiçãoCliente.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(101)))), ((int)(((byte)(22)))));
            this.btnEdiçãoCliente.CornerRadius = 5;
            this.btnEdiçãoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEdiçãoCliente.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdiçãoCliente.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(151)))), ((int)(((byte)(52)))));
            this.btnEdiçãoCliente.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(91)))), ((int)(((byte)(12)))));
            this.btnEdiçãoCliente.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEdiçãoCliente.Location = new System.Drawing.Point(6, 332);
            this.btnEdiçãoCliente.Name = "btnEdiçãoCliente";
            this.btnEdiçãoCliente.Size = new System.Drawing.Size(186, 69);
            this.btnEdiçãoCliente.TabIndex = 67;
            this.btnEdiçãoCliente.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(81)))), ((int)(((byte)(2)))));
            this.btnEdiçãoCliente.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdiçãoCliente.Click += new System.EventHandler(this.btnEdiçãoCliente_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))));
            this.btnProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProdutos.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.ButtonImage")));
            this.btnProdutos.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnProdutos.ButtonText = "Produtos";
            this.btnProdutos.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.btnProdutos.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(101)))), ((int)(((byte)(22)))));
            this.btnProdutos.CornerRadius = 5;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnProdutos.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnProdutos.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(151)))), ((int)(((byte)(52)))));
            this.btnProdutos.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(91)))), ((int)(((byte)(12)))));
            this.btnProdutos.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnProdutos.Location = new System.Drawing.Point(6, 182);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(186, 69);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(81)))), ((int)(((byte)(2)))));
            this.btnProdutos.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnProdutos.Click += new System.EventHandler(this.bntProdutos_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))));
            this.btnVendas.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnVendas.ButtonImage")));
            this.btnVendas.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnVendas.ButtonText = "Pedidos";
            this.btnVendas.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.btnVendas.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(101)))), ((int)(((byte)(22)))));
            this.btnVendas.CornerRadius = 5;
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVendas.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnVendas.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(151)))), ((int)(((byte)(52)))));
            this.btnVendas.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(91)))), ((int)(((byte)(12)))));
            this.btnVendas.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnVendas.Location = new System.Drawing.Point(6, 106);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(186, 69);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(81)))), ((int)(((byte)(2)))));
            this.btnVendas.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnVendas.Click += new System.EventHandler(this.bntVendas_Click_1);
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))));
            this.btnPagamento.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPagamento.ButtonImage")));
            this.btnPagamento.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnPagamento.ButtonText = "Pagamentos";
            this.btnPagamento.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.btnPagamento.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(101)))), ((int)(((byte)(22)))));
            this.btnPagamento.CornerRadius = 5;
            this.btnPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPagamento.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPagamento.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(151)))), ((int)(((byte)(52)))));
            this.btnPagamento.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(91)))), ((int)(((byte)(12)))));
            this.btnPagamento.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPagamento.Location = new System.Drawing.Point(6, 29);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(186, 69);
            this.btnPagamento.TabIndex = 1;
            this.btnPagamento.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(81)))), ((int)(((byte)(2)))));
            this.btnPagamento.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPagamento.Click += new System.EventHandler(this.bntPagamento_Click_1);
            // 
            // xuiCustomPictureBox1
            // 
            this.xuiCustomPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xuiCustomPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.xuiCustomPictureBox1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(72)))));
            this.xuiCustomPictureBox1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.xuiCustomPictureBox1.FilterAlpha = 200;
            this.xuiCustomPictureBox1.FilterEnabled = true;
            this.xuiCustomPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xuiCustomPictureBox1.Image")));
            this.xuiCustomPictureBox1.IsElipse = false;
            this.xuiCustomPictureBox1.IsParallax = false;
            this.xuiCustomPictureBox1.Location = new System.Drawing.Point(30, 495);
            this.xuiCustomPictureBox1.Name = "xuiCustomPictureBox1";
            this.xuiCustomPictureBox1.Size = new System.Drawing.Size(127, 52);
            this.xuiCustomPictureBox1.TabIndex = 4;
            this.xuiCustomPictureBox1.Text = "xuiCustomPictureBox1";
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 5;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // PainelInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1186, 720);
            this.Controls.Add(this.panelAplicações);
            this.Controls.Add(this.statusBarra);
            this.Controls.Add(this.panelCabecalho);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PainelInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainelInicial";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PainelInicial_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusBarra.ResumeLayout(false);
            this.statusBarra.PerformLayout();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeRelogio)).EndInit();
            this.panelAplicações.ResumeLayout(false);
            this.panelAplicações.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusBarra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_lblusuario;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasMenu;
        private System.Windows.Forms.ToolStripMenuItem RegClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasMenu;
        private System.Windows.Forms.ToolStripMenuItem pagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.PictureBox picIconeRelogio;
        private System.Windows.Forms.Timer timerTempoReal;
        private System.Windows.Forms.Panel panelAplicações;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button bntMaximizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIButton btnProdutos;
        private XanderUI.XUIButton btnVendas;
        private XanderUI.XUIButton btnPagamento;
        private System.Windows.Forms.Button btnMostrarAplicações;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem notepadStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fecharTodosStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem RegPedidosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem RegProdutosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private XanderUI.XUIButton xuiBusuario;
        private XanderUI.XUICustomPictureBox xuiCustomPictureBox1;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private XanderUI.XUIButton btnEdiçãoCliente;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditarProduto;
        private XanderUI.XUIButton btnComandas;
    }
}



