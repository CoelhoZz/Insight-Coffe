using InsightCoffe.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightCoffe.Utilidades
{
    public partial class APSprodutos : Form
    {
        public PainelInicial Start { get; set; }

        public APSprodutos(PainelInicial start, List<Produto> produtos)
        {
            InitializeComponent();
            this.Start = start;
        }

        //--------------------------------------Mover formulario--------------------------------------------
        Point DragCursor;
        Point DragForm;
        bool Dragging;
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }
        //-------------------------------------end-Mover formulario---------------------------------------

        //-----------------------------start-Adicionar Pesquisar e Editar  PRODUTOS-------------------------
        public int codigo;
        public string descricao, quantidade;
        public double valor;

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            
            if (txbDescricao.Text == "" || txbQuantidade.Text == "" || txbValor.Text == "")
                MessageBox.Show("Insira todos os campos necessarios para o cadastro", "Aviso!");
            else
            {
                codigo = Convert.ToInt32(txbCodigo.Text);
                descricao = txbDescricao.Text;
                quantidade = txbQuantidade.Text;
                valor = Convert.ToDouble(txbValor.Text);
                Start.Adicionar_produto(valor, quantidade, descricao, codigo);
                alterarCamposPara_origin();
            }
        }

        //--------------------------------------------------------Adicionar
        private void button1_Click(object sender, EventArgs e)
        {
            //Habilitando Botão
            btnCancelar.Enabled = true;

            //Desabilitando Botão
            btnPesquisar.Enabled = false;
            btnAdicionar.Enabled = false;

            //Desabilitando Campos
            txbCodigo.Enabled = false;

            int i = 1;
            foreach(Produto produto in Start.produtos)
            {
                if (i == produto.ID)
                    i++;
                else
                {
                    txbCodigo.Text = i.ToString();
                    alterarCamposEmFuncao_btnAdicionar();
                    return;
                }
            }
            txbCodigo.Text = (i++).ToString();
            alterarCamposEmFuncao_btnAdicionar();
        }

        private void picBExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        //---------------------------------------------------------------Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(txbCodigo.Text == "" || txbCodigo.Text == "0")
            {
                MessageBox.Show("Digite um numero valido para pesquisar");
            }
            else
            {
                foreach(Produto produto in Start.produtos)
                {
                    if((codigo = Convert.ToInt32(txbCodigo.Text)) == produto.ID)
                    {
                        alterarCamposEmFunca_btnPesquisar();

                        //Escreve os dados nos campos
                        txbDescricao.Text = produto.Descricao;
                        txbQuantidade.Text = produto.Quantidade;
                        txbValor.Text = produto.Valor.ToString();
                        return;
                    }
                }
                MessageBox.Show("Numero de ID não existe");
            }
        }

        //------------------------------------------------------Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo editar esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            codigo = Convert.ToInt32(txbCodigo.Text);
            descricao = txbDescricao.Text;
            quantidade = txbQuantidade.Text;
            valor = Convert.ToDouble(txbValor.Text);
            Start.Editar_produto(valor, quantidade, descricao, codigo);
            alterarCamposPara_origin();
        }

        //---------------------------------------------------------Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alterarCamposPara_origin();
        }
        //----------------------------------end-Adicionar Pesquisar e Editar  PRODUTOS---------------------------------

        //-------------------------------------------Metodos utilizaveis-----------------------------------------------
        void alterarCamposPara_origin()
        {
            //Habilitando Botões 
            btnAdicionar.Enabled = true;
            btnPesquisar.Enabled = true;

            //Desabilitando Botões
            btnEditar.Enabled = false;
            bntCadastrar.Enabled = false;
            btnCancelar.Enabled = false;

            //Habilitando campos
            txbCodigo.Enabled = true;

            //Desabilitando campos
            txbDescricao.Enabled = false;
            txbQuantidade.Enabled = false;
            txbValor.Enabled = false;

            //Limpando campos
            txbCodigo.Clear();
            txbDescricao.Clear();
            txbQuantidade.Clear();
            txbValor.Clear();
        }

        void alterarCamposEmFunca_btnPesquisar()
        {
            //Habilita botão
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;

            //Desabilita botão
            btnAdicionar.Enabled = false;

            //Habilita Campos
            txbDescricao.Enabled = true;
            txbQuantidade.Enabled = true;
            txbValor.Enabled = true;

            //Desabilita Campos
            txbCodigo.Enabled = false;
        }

        void alterarCamposEmFuncao_btnAdicionar()
        {
            txbValor.Enabled = true;
            txbQuantidade.Enabled = true;
            txbDescricao.Enabled = true;
            bntCadastrar.Enabled = true;
        }

        //--------------------------------------------------------------------------------------------------------------

        //--------------------------------------------start Exibição de Produtos----------------------------------------
        private void APSprodutos_Load(object sender, EventArgs e)
        {
            dtGridView.DataSource = Start.produtos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtGridView.DataSource = null;
            dtGridView.DataSource = Start.produtos;
        }
        //---------------------------------------------end Exibição de Produtos------------------------------------------
    }
}
