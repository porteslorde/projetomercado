using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaCompraProdutoEstrutura
{
    public partial class FormMercado : Form
    {
        private FormTelaCompra CompraProduto = new FormTelaCompra();

        public void setCompra(FormTelaCompra CompraProduto)
        {
            this.CompraProduto = CompraProduto;
        }
        public FormMercado()
        {
            InitializeComponent();
        }

        private void ComprarCafePilao(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setMercado(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/cafe7.png";
            CompraProduto.labelProduto.Text = labelCafePilao.Text;
            CompraProduto.labelValor.Text = labelValor770.Text;
        }
    }
}
