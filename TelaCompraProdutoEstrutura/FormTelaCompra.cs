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
    public partial class FormTelaCompra : Form
    {
        private FormMercado Mercado = null;

        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        public FormTelaCompra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckCartaoDeCredito(object sender, EventArgs e)
        {
            maskedTextBoxNumeroDoCartao.Enabled = radioButtonCartaoDeCredito.Checked;
            maskedTextBoxValidade.Enabled = radioButtonCartaoDeCredito.Checked;
            maskedTextBoxCvv.Enabled = radioButtonCartaoDeCredito.Checked;
            textBoxNomeDoTitular.Enabled = radioButtonCartaoDeCredito.Checked;
            maskedTextBoxCpfOuCnpjDoTitular.Enabled = radioButtonCartaoDeCredito.Checked;
            maskedTextBoxNumeroDoCartao2.Enabled = false;
            maskedTextBoxValidade2.Enabled = false;
            maskedTextBoxCvv2.Enabled = false;
            textBoxNomeDoTitular2.Enabled = false;
            maskedTextBoxCpfOuCnpjDoTitular2.Enabled = false;
            maskedTextBoxNumeroDoCartao2.Text = "";
            maskedTextBoxValidade2.Text = "";
            maskedTextBoxCvv2.Text = "";
            textBoxNomeDoTitular2.Text = "";
            maskedTextBoxCpfOuCnpjDoTitular2.Text = "";
            maskedTextBoxNumeroDoCartao2.Mask = "";
            maskedTextBoxValidade2.Mask = "";
            maskedTextBoxCvv2.Mask = "";
            maskedTextBoxCpfOuCnpjDoTitular2.Mask = "";
            labelCodigoDoPix.Visible = false;
        }

        private void CheckCartaoDeDebito(object sender, EventArgs e)
        {
            maskedTextBoxNumeroDoCartao2.Enabled = radioButtonCartaoDeDebito.Checked;
            maskedTextBoxValidade2.Enabled = radioButtonCartaoDeDebito.Checked;
            maskedTextBoxCvv2.Enabled = radioButtonCartaoDeDebito.Checked;
            textBoxNomeDoTitular2.Enabled = radioButtonCartaoDeDebito.Checked;
            maskedTextBoxCpfOuCnpjDoTitular2.Enabled = radioButtonCartaoDeDebito.Checked;
            maskedTextBoxNumeroDoCartao.Enabled = false;
            maskedTextBoxValidade.Enabled = false;
            maskedTextBoxCvv.Enabled = false;
            textBoxNomeDoTitular.Enabled = false;
            maskedTextBoxCpfOuCnpjDoTitular.Enabled = false;
            maskedTextBoxNumeroDoCartao.Text = "";
            maskedTextBoxValidade.Text = "";
            maskedTextBoxCvv.Text = "";
            textBoxNomeDoTitular.Text = "";
            maskedTextBoxCpfOuCnpjDoTitular.Text = "";
            maskedTextBoxNumeroDoCartao.Mask = "";
            maskedTextBoxValidade.Mask = "";
            maskedTextBoxCvv.Mask = "";
            maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
            labelCodigoDoPix.Visible = false;
        }

        private void CheckPix(object sender, EventArgs e)
        {
            labelCodigoDoPix.Visible = radioButtonPix.Checked;
            maskedTextBoxNumeroDoCartao.Enabled = false;
            maskedTextBoxValidade.Enabled = false;
            maskedTextBoxCvv.Enabled = false;
            textBoxNomeDoTitular.Enabled = false;
            maskedTextBoxCpfOuCnpjDoTitular.Enabled = false;
            maskedTextBoxNumeroDoCartao.Text = "";
            maskedTextBoxValidade.Text = "";
            maskedTextBoxCvv.Text = "";
            textBoxNomeDoTitular.Text = "";
            maskedTextBoxCpfOuCnpjDoTitular.Text = "";
            maskedTextBoxNumeroDoCartao.Mask = "";
            maskedTextBoxValidade.Mask = "";
            maskedTextBoxCvv.Mask = "";
            maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
            maskedTextBoxNumeroDoCartao2.Enabled = false;
            maskedTextBoxValidade2.Enabled = false;
            maskedTextBoxCvv2.Enabled = false;
            textBoxNomeDoTitular2.Enabled = false;
            maskedTextBoxCpfOuCnpjDoTitular2.Enabled = false;
            maskedTextBoxNumeroDoCartao2.Text = "";
            maskedTextBoxValidade2.Text = "";
            maskedTextBoxCvv2.Text = "";
            textBoxNomeDoTitular2.Text = "";
            maskedTextBoxCpfOuCnpjDoTitular2.Text = "";
            maskedTextBoxNumeroDoCartao2.Mask = "";
            maskedTextBoxValidade2.Mask = "";
            maskedTextBoxCvv2.Mask = "";
            maskedTextBoxCpfOuCnpjDoTitular2.Mask = "";
        }

        private void CheckSim(object sender, EventArgs e)
        {
            textBoxRua.Enabled = radioButtonSim.Checked;
            textBoxNumero.Enabled = radioButtonSim.Checked;
            textBoxBairro.Enabled = radioButtonSim.Checked;
            maskedTextBoxCep.Enabled = radioButtonSim.Checked;
        }

        private void CheckNao(object sender, EventArgs e)
        {
            textBoxRua.Enabled = false;
            textBoxNumero.Enabled = false;
            textBoxBairro.Enabled = false;
            maskedTextBoxCep.Enabled = false;
            textBoxRua.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            maskedTextBoxCep.Text = "";
            maskedTextBoxCep.Mask = "";
        }

        private void ConfirmarCompra(object sender, EventArgs e)
        {
            if (radioButtonCartaoDeCredito.Checked == false && radioButtonCartaoDeDebito.Checked == false && radioButtonPix.Checked == false && radioButtonSim.Checked == false && radioButtonNao.Checked == false)
            {
                MessageBox.Show("Escolha uma das Formas de Pagamento e se deseja Entrega Domiciliar para poder efetivar a compra");
            }
            if (radioButtonSim.Checked == false && radioButtonNao.Checked == false)
            {
                if (radioButtonCartaoDeCredito.Checked || radioButtonCartaoDeDebito.Checked || radioButtonPix.Checked)
                {
                    MessageBox.Show("Escolha se deseja Entrega Domiciliar para poder efetivar a compra");
                }
            }
            if (radioButtonCartaoDeCredito.Checked == false && radioButtonCartaoDeDebito.Checked == false && radioButtonPix.Checked == false)
            {
                if (radioButtonSim.Checked || radioButtonNao.Checked)
                {
                    MessageBox.Show("Escolha uma das Formas de Pagamento para poder efetivar a compra");
                }
            }
            if (radioButtonCartaoDeCredito.Checked)
            {
                if (maskedTextBoxNumeroDoCartao.Text == "" || maskedTextBoxValidade.Text == "" || maskedTextBoxCvv.Text == "" || textBoxNomeDoTitular.Text == "" || maskedTextBoxCpfOuCnpjDoTitular.Text == "")
                {
                    MessageBox.Show("Faltam Dados para Serem Preenchidos do Cartão de Crédito");
                }
            }
            if (radioButtonCartaoDeDebito.Checked)
            {
                if (maskedTextBoxNumeroDoCartao2.Text == "" || maskedTextBoxValidade2.Text == "" || maskedTextBoxCvv2.Text == "" || textBoxNomeDoTitular2.Text == "" || maskedTextBoxCpfOuCnpjDoTitular2.Text == "")
                {
                    MessageBox.Show("Faltam Dados para Serem Preenchidos do Cartão de Débito");
                }
            }
            if (radioButtonSim.Checked)
            {
                if (textBoxRua.Text == "" || textBoxNumero.Text == "" || textBoxBairro.Text == "" || maskedTextBoxCep.Text == "")
                {
                    MessageBox.Show("Faltam Dados para Serem Preenchidos da Entrega Domiciliar");
                }
            }
            if (radioButtonCartaoDeCredito.Checked)
            {
                if(maskedTextBoxNumeroDoCartao.Text != "")
                {
                    if (maskedTextBoxNumeroDoCartao.Text.Length == 16)
                    {
                        maskedTextBoxNumeroDoCartao.Mask = "0000,0000,0000,0000";
              
                    }
                    else
                    {
                        MessageBox.Show("Erro no Número do Cartão");
                        maskedTextBoxNumeroDoCartao.Text = "";
                    }
                }
            }
            if (radioButtonCartaoDeCredito.Checked)
            {
                if(maskedTextBoxValidade.Text != "")
                {
                    if (maskedTextBoxValidade.Text.Length == 4)
                    {
                        maskedTextBoxValidade.Mask = "00/00";
                    }
                    else
                    {
                        MessageBox.Show("Erro na Validade");
                        maskedTextBoxValidade.Text = "";
                    }
                }
            }
            if (radioButtonCartaoDeCredito.Checked)
            {
                if (maskedTextBoxCvv.Text != "")
                {
                    if (maskedTextBoxCvv.Text.Length == 4)
                    {
                        maskedTextBoxCvv.Mask = "0000";
                    }
                    else
                    {
                        MessageBox.Show("Erro no CVV");
                        maskedTextBoxCvv.Text = "";
                    }
                }
            }
            if (radioButtonCartaoDeCredito.Checked)
            {
                if (maskedTextBoxCpfOuCnpjDoTitular.Text != "")
                {
                    if (maskedTextBoxCpfOuCnpjDoTitular.Text.Length == 11)
                    {
                        maskedTextBoxCpfOuCnpjDoTitular.Mask = "000,000,000-00";
                    }
                    else if (maskedTextBoxCpfOuCnpjDoTitular.Text.Length == 14)
                    {
                        maskedTextBoxCpfOuCnpjDoTitular.Mask = "00,000,000/0000-00";
                    }
                    else
                    {
                        MessageBox.Show("Erro no CPF ou CNPJ do Titular");
                        maskedTextBoxCpfOuCnpjDoTitular.Text = "";
                    }
                }
            }
            if (radioButtonCartaoDeDebito.Checked)
            {
                if (maskedTextBoxNumeroDoCartao2.Text != "")
                {
                    if (maskedTextBoxNumeroDoCartao2.Text.Length == 16)
                    {
                        maskedTextBoxNumeroDoCartao2.Mask = "0000,0000,0000,0000";
                    }
                    else
                    {
                        MessageBox.Show("Erro no Número do Cartão");
                    }
                }
            }
            if (radioButtonCartaoDeDebito.Checked)
            {
                if (maskedTextBoxValidade2.Text != "")
                {
                    if (maskedTextBoxValidade2.Text.Length == 4)
                    {
                        maskedTextBoxValidade2.Mask = "00/00";
                    }
                    else
                    {
                        MessageBox.Show("Erro na Validade");
                    }
                }
            }
            if (radioButtonCartaoDeDebito.Checked)
            {
                if (maskedTextBoxCvv2.Text != "")
                {
                    if (maskedTextBoxCvv2.Text.Length == 4)
                    {
                        maskedTextBoxCvv2.Mask = "0000";
                    }
                    else
                    {
                        MessageBox.Show("Erro no CVV");
                    }
                }
            }
            if (radioButtonCartaoDeDebito.Checked)
            {
                if (maskedTextBoxCpfOuCnpjDoTitular2.Text != "")
                {
                    if (maskedTextBoxCpfOuCnpjDoTitular2.Text.Length == 11)
                    {
                        maskedTextBoxCpfOuCnpjDoTitular2.Mask = "000,000,000-00";
                    }
                    else if (maskedTextBoxCpfOuCnpjDoTitular2.Text.Length == 14)
                    {
                        maskedTextBoxCpfOuCnpjDoTitular2.Mask = "00,000,000/0000-00";
                    }
                    else
                    {
                        MessageBox.Show("Erro no CPF ou CNPJ do Titular");
                    }
                }
            }
            if (radioButtonSim.Checked)
            {
                if (maskedTextBoxCep.Text != "")
                {
                    if (maskedTextBoxCep.Text.Length == 8)
                    {
                        maskedTextBoxCep.Mask = "00000-000";
                    }
                    else
                    {
                        MessageBox.Show("Erro no CEP");
                    }
                }
            }
            if (radioButtonCartaoDeCredito.Checked)
            {
                if (maskedTextBoxNumeroDoCartao.Text != "" && maskedTextBoxValidade.Text != "" && maskedTextBoxCvv.Text != "" && textBoxNomeDoTitular.Text != "" && maskedTextBoxCpfOuCnpjDoTitular.Text != "")
                {
                    if (radioButtonSim.Checked)
                    {
                        if (textBoxRua.Text != "" && textBoxNumero.Text != "" && textBoxBairro.Text != "" && maskedTextBoxCep.Text != "")
                        {
                            MessageBox.Show("Compra efetivada com Sucesso");
                            maskedTextBoxNumeroDoCartao.Text = "";
                            maskedTextBoxValidade.Text = "";
                            maskedTextBoxCvv.Text = "";
                            textBoxNomeDoTitular.Text = "";
                            maskedTextBoxCpfOuCnpjDoTitular.Text = "";
                            maskedTextBoxNumeroDoCartao.Mask = "";
                            maskedTextBoxValidade.Mask = "";
                            maskedTextBoxCvv.Mask = "";
                            maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
                        }
                    }
                    if (radioButtonNao.Checked)
                    {
                        MessageBox.Show("Compra efetivada com Sucesso");
                        maskedTextBoxNumeroDoCartao.Text = "";
                        maskedTextBoxValidade.Text = "";
                        maskedTextBoxCvv.Text = "";
                        textBoxNomeDoTitular.Text = "";
                        maskedTextBoxCpfOuCnpjDoTitular.Text = "";
                        maskedTextBoxNumeroDoCartao.Mask = "";
                        maskedTextBoxValidade.Mask = "";
                        maskedTextBoxCvv.Mask = "";
                        maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
                    }
                }
            }
            if (radioButtonCartaoDeDebito.Checked)
            {
                if (maskedTextBoxNumeroDoCartao2.Text != "" && maskedTextBoxValidade2.Text != "" && maskedTextBoxCvv2.Text != "" && textBoxNomeDoTitular2.Text != "" && maskedTextBoxCpfOuCnpjDoTitular2.Text != "")
                {
                    if (radioButtonSim.Checked)
                    {
                        if (textBoxRua.Text != "" && textBoxNumero.Text != "" && textBoxBairro.Text != "" && maskedTextBoxCep.Text != "")
                        {
                            MessageBox.Show("Compra efetivada com Sucesso");
                        }
                    }
                    if (radioButtonNao.Checked)
                    {
                        MessageBox.Show("Compra efetivada com Sucesso");
                    }
                }
            }
            if (radioButtonPix.Checked)
            {
                    if (radioButtonSim.Checked)
                    {
                        if (textBoxRua.Text != "" && textBoxNumero.Text != "" && textBoxBairro.Text != "" && maskedTextBoxCep.Text != "")
                        {
                            MessageBox.Show("Compra efetivada com Sucesso");
                        }
                    }
                    if (radioButtonNao.Checked)
                    {
                        MessageBox.Show("Compra efetivada com Sucesso");
                    }     
            }
        }

        private void maskedTextBoxCpfOuCnpjDoTitular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBoxCpfOuCnpjDoTitular_MaskChanged(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBoxNumeroDoCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxCvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBoxNomeDoTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CharWord(e);
        }

        private void maskedTextBoxCpfOuCnpjDoTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxNumeroDoCartao2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxValidade2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxCvv2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBoxNomeDoTitular2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CharWord(e);
        }

        private void maskedTextBoxCpfOuCnpjDoTitular2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBoxRua_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CharWord(e);
        }

        private void textBoxBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CharWord(e);
        }

        private void maskedTextBoxCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBoxQtdCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxNumeroDoCartao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxNumeroDoCartao.Mask = "";
            }
        }

        private void maskedTextBoxNumeroDoCartao_Click(object sender, EventArgs e)
        {
          
        }

        private void maskedTextBoxValidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxValidade.Mask = "";
            }
        }

        private void maskedTextBoxCvv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxCvv.Mask = "";
            }
        }

        private void maskedTextBoxCpfOuCnpjDoTitular_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Mercado == null)
            {
                Mercado = new FormMercado();
            }
            Mercado.Show();
            Mercado.setCompra(this);
            this.Hide();
        }

        private void QtdCompra(object sender, EventArgs e)
        {
            double valoratual = Convert.ToDouble(labelValor.Text);
            int qtdnova = int.Parse(textBoxQtdCompra.Text);
            double novovalor = (valoratual * qtdnova);
            labelNovoValor.Text = Convert.ToString(novovalor);
        }
    }
}
