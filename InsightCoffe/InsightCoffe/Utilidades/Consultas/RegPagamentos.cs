﻿using InsightCoffe.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightCoffe.Utilidades.Consultas
{
    public partial class RegPagamentos : Form
    {
        PainelInicial Inicial;

        public RegPagamentos(PainelInicial inicial, List<Pagamentos> pagamentos)
        {
            InitializeComponent();
            this.Inicial = inicial;
        }
       //mover form
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

        //-------------------------------------------------------------------
        //-------------------------------botao start ------------------------
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Inicial.TelaRegPagamento = false;
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //-------------------------------end---------------------------------
        //-------------------------------method start------------------------

        private void RegPagamentos_Load_1(object sender, EventArgs e)
        {
            Mostrar_lista();
        }

        private void Mostrar_lista()
        {
            foreach (var item in Inicial.armazenaPedido)
            {
                listVRegistroPagamento.Items.Add(new ListViewItem(new string[] { item.ID.ToString(), item.CodigoUsado.ToString(), item.Cliente, item.DataeHora, item.Situacao, item.Valor.ToString() }));
            }

        }

        //-------------------------------end --------------------------------
        //Leave
        private void LeaveMinimizar(object sender, EventArgs e)
        {
            btnMinimizar.FlatAppearance.BorderColor = Color.SaddleBrown;
        }
        private void LeaveFechar(object sender, EventArgs e)
        {
            btnFechar.FlatAppearance.BorderColor = Color.SaddleBrown;
        }
        //Mouse move em cima
        private void controlFechar(object sender, MouseEventArgs e)
        {
            btnFechar.FlatAppearance.BorderColor = Color.Red;
        }
        private void controlMinimizar(object sender, MouseEventArgs e)
        {
            btnMinimizar.FlatAppearance.BorderColor = Color.Gainsboro;
        }
    }
}
