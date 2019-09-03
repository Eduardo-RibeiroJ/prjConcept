using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjConcept.Dados;
using PrjConcept.Dados.DB_ConceptDataSetTableAdapters;
using PrjConcept.Formularios.Sistema;
using PrjConcept.Formularios.Cadastros;

namespace PrjConcept
{
    public partial class frmVendas : Form
    {
        public frmVendas(int idFunc)
        {
            InitializeComponent();
            vIdFunc = idFunc;
        }

        int vID_VendaAtual, vIdFunc, vCliente;
        decimal vValorTotal, vValorProd, vTroco, vDesconto;
        private decimal vValorDebito = 0;
        bool vEnterOk = false;

        private void frmVendas_Load(object sender, EventArgs e)
        {
            //Deixar pronto para vender
            CarregaGridItens();
            if (dgvProdutos.RowCount > 0)
            {
                btnCancelar.PerformClick();
            }
            CompraTableAdapter taCompra = new CompraTableAdapter();
            vID_VendaAtual = Convert.ToInt32(taCompra.Ultimo_Pedido()) + 1;
            lblCodVenda.Text = vID_VendaAtual.ToString();
            cmbPagamento.SelectedIndex = 0;
            txtBarra.Select();


        }

        private void CarregaGridItens()
        {
            CompraTempTableAdapter taCompraTemp = new CompraTempTableAdapter();
            dgvProdutos.DataSource = taCompraTemp.GetData();


            dgvProdutos.Columns[0].Visible = false;
            dgvProdutos.Columns[1].HeaderText = "Cod.";
            dgvProdutos.Columns[1].Width = 70;
            dgvProdutos.Columns[2].HeaderText = "Produto";
            dgvProdutos.Columns[2].Width = 318;
            dgvProdutos.Columns[3].HeaderText = "Quant.";
            dgvProdutos.Columns[3].Width = 70;
            dgvProdutos.Columns[4].HeaderText = "Valor";
            dgvProdutos.Columns[4].Width = 110;
            dgvProdutos.Columns[4].DefaultCellStyle.Format = "C2";

        }

        private void Limpa_Campos_Item()
        {
            txtBarra.Text = "";
            txtidProd.Text = "";
            txtnomeProd.Text = "";
            spnQuant.Value = 1;
            txtPreco.Text = "0,00";
            mskTroco.Text = "0,00";
            txtValorRec.Text = "0,00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount < 1)
            {
                MessageBox.Show("Não há itens para vender.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtIdCli.Visible == false)
            {
                vCliente = 1;
            }
            else
            {
                vCliente = int.Parse(txtIdCli.Text);
            }
            //Gerar Debito ou não
            if (mskTroco.Text == "Débito")
            {
                if (vCliente == 1)
                {
                    MessageBox.Show("Não é possível realizar vendas com\ndébitos sem possuir um cliente!\n\n\nSelecione um cliente, ou receba o valor inteiro da venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                vValorDebito = vValorTotal - Convert.ToDecimal(txtValorRec.Text);
                MessageBox.Show("Será gerado um débito no valor de R$ " + vValorDebito + ".\n\nEscolha a quantidade de parcelas e a data de vencimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                

                //Chamar o Form Debitos para pegar os dados
                frmDebitos frmdebitos = new frmDebitos(vValorDebito);
                frmdebitos.ShowDialog();

                if (frmdebitos.Parcela1Retorno != 0)
                {
                    //Salvando os Debitos
                    SalvarCompra();

                    DebitoTableAdapter taDebito = new DebitoTableAdapter();
                    taDebito.Insert(vID_VendaAtual, "sim", frmdebitos.Parcela1Retorno, frmdebitos.Parcela2Retorno, frmdebitos.Parcela3Retorno, frmdebitos.Parcela4Retorno, Convert.ToDateTime(frmdebitos.DataVencRetorno));
                }
                else
                {
                    return;
                }
            }
            else
            {
                vValorDebito = 0;
                SalvarCompra();
            }

            if (mskTroco.Text != "Débito" && Convert.ToDecimal(mskTroco.Text) > 0)
            {
                MessageBox.Show("Venda concluída!\n\nTroco no valor de R$ " + mskTroco.Text +".", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Venda concluída!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnCancelar.PerformClick();
            txtBarra.Select();
        }

        private void SalvarCompra()
        {
            //Salvar compra
            string vFormaPag;
            if (cmbPagamento.SelectedIndex == 0)
            {
                vFormaPag = "DIN";
            }
            else if (cmbPagamento.SelectedIndex == 1)
            {
                vFormaPag = "DEB";
            }
            else
            {
                vFormaPag = "CRE";
            }
            //************************************************************************Pegar o ID do Func no BD


                    //Salvando a Compra
                    CompraTableAdapter taCompra = new CompraTableAdapter();

                    taCompra.Insert(vCliente, vIdFunc, vValorTotal, vValorDebito, DateTime.Now, vFormaPag);

                    //Salvando os itens, e tirando a quantidade do estoque
                    ItensCompraTableAdapter taItens = new ItensCompraTableAdapter();
                    ProdutoTableAdapter taProd = new ProdutoTableAdapter();

                    int vCodProd, vQuantProd;
                    for (int i = 0; i <= dgvProdutos.RowCount - 1; i++)
                    {
                        vCodProd = (int)dgvProdutos.Rows[i].Cells["ID_Prod"].Value;
                        vQuantProd = (int)dgvProdutos.Rows[i].Cells["Quant_ItensCompra"].Value;

                        taProd.Acerta_Saldo_Saida(vQuantProd, vCodProd);

                        taItens.Insert(vCodProd, vID_VendaAtual, vQuantProd);

                        
                    }

        }
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            if(txtnomeProd.Text == "")
            {
                lblInfo.Text = "Escolha um produto para adicionar!";
                LigaInfo();
                return;
            }

            //Grava item na tabela temporária
            vValorProd = decimal.Parse(txtPreco.Text) * Convert.ToInt32(spnQuant.Value);
            bool vAchouIgual = false;
            CompraTempTableAdapter taCompraTemp = new CompraTempTableAdapter();
            
                for (int i = 0; i <= dgvProdutos.RowCount - 1; i++)
                {
                    if (Convert.ToInt32(dgvProdutos.Rows[i].Cells["ID_Prod"].Value) == Convert.ToInt32(txtidProd.Text))
                    {
                        vAchouIgual = true;
                        taCompraTemp.SomarQuantidade(Convert.ToInt32(spnQuant.Value), vValorProd, Convert.ToInt32(dgvProdutos.Rows[i].Cells["ID_Prod"].Value));
                    }
                }

                if (vAchouIgual == false)
                {
                    taCompraTemp.Insert(vID_VendaAtual, int.Parse(txtidProd.Text), txtnomeProd.Text, Convert.ToInt32(spnQuant.Value), vValorProd);
                }

            Limpa_Campos_Item();
            CarregaGridItens();
            
            vValorTotal = vValorTotal + vValorProd;
            lblPreco.Text = (vValorTotal).ToString("R$ ###,##0.00");

            lblInfo.Text = "Produto adicionado!";
            LigaInfo();
            txtBarra.Select();
        }

        private void btnRemovProd_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.Rows.Count > 0)
            {
                CompraTempTableAdapter taCompraTemp = new CompraTempTableAdapter();
                int vCodProd = (int)dgvProdutos.CurrentRow.Cells["ID_Prod"].Value;
                vValorProd = (decimal)dgvProdutos.CurrentRow.Cells["PrecoTotal_Prod"].Value;
                string vProd = dgvProdutos.CurrentRow.Cells["Nome_Prod"].Value.ToString();
                int vQuantProd = (int)dgvProdutos.CurrentRow.Cells["Quant_ItensCompra"].Value;

                taCompraTemp.Delete(vID_VendaAtual, vCodProd, vProd, vQuantProd, vValorProd);
                Limpa_Campos_Item();
                CarregaGridItens();
                vValorTotal = vValorTotal - vValorProd;
                lblPreco.Text = (vValorTotal).ToString("R$ ###,##0.00");
                lblInfo.Text = "Produto removido!";
                LigaInfo();
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            frmPesCli PesCli = new frmPesCli();
            PesCli.ShowDialog();

            if (PesCli.CodRetorno != 0 && PesCli.NomeRetorno != null)
            {
                txtIdCli.Visible = true;
                txtNomeCli.Visible = true;
                lblIdCli.Visible = true;
                lblNomeCli.Visible = true;
                txtIdCli.Text = PesCli.CodRetorno.ToString();
                txtNomeCli.Text = PesCli.NomeRetorno.ToString();
                btnAddCliente.Enabled = false;
                lblInfo.Text = "Cliente adicionado!";
                LigaInfo();
            }
        }

        private void btnPesProd_Click(object sender, EventArgs e)
        {
            frmPesProd PesProd = new frmPesProd();
            PesProd.ShowDialog();

            if (PesProd.CodRetorno != 0 && PesProd.NomeRetorno != null)
            {
                txtidProd.Text = "";
                txtnomeProd.Text = "";
                txtBarra.Text = "";
                txtidProd.Text = PesProd.CodRetorno.ToString();
                txtnomeProd.Text = PesProd.NomeRetorno.ToString();
                txtPreco.Text = PesProd.PrecoRetorno.ToString();
            }
        }

        private void txtidProd_Leave(object sender, EventArgs e)
        {

            ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
            DB_ConceptDataSet.ProdutoDataTable dtProduto = new DB_ConceptDataSet.ProdutoDataTable();

            if(txtidProd.Text == "")
            {
                txtnomeProd.Text = "";
                txtPreco.Text = "0,00";
                spnQuant.Value = 1;

                return;
            }

                dtProduto = taProduto.ProcuraProduto(int.Parse(txtidProd.Text));

                if(dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Produto não cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtidProd.Text = "";
                    txtidProd.Focus();
                }
                else
                {
                    txtnomeProd.Text = dtProduto.Rows[0]["Nome_Prod"].ToString();
                    txtPreco.Text = dtProduto.Rows[0]["Preco_Prod"].ToString();
                    spnQuant.Focus();
                }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtBarra.Text = "";
            txtIdCli.Text = "";
            txtNomeCli.Text = "";
            txtNomeCli.Visible = false;
            txtIdCli.Visible = false;
            lblIdCli.Visible = false;
            lblNomeCli.Visible = false;
            btnAddCliente.Enabled = true;
            txtidProd.Text = "";
            txtnomeProd.Text = "";
            spnQuant.Value = 1;
            txtPreco.Text = "0,00";
            cmbPagamento.SelectedIndex = 0;
            txtValorRec.Text = "0,00";
            lblPreco.Text = "R$ 0,00";
            ApagarTabela();
            CarregaGridItens();
            mskTroco.Text = "0,00";
            vValorTotal = 0;
            frmVendas_Load(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            ApagarTabela();
        }
        
        private void ApagarTabela()
        {
            CompraTempTableAdapter taCompraTemp = new CompraTempTableAdapter();
            taCompraTemp.ApagarTabela();
        }
        
        private void AtualizaTroco()
        {
            if (txtValorRec.Text != "")
                vTroco = decimal.Parse(txtValorRec.Text) - vValorTotal;
            if(vTroco < 0)
            {
                mskTroco.Text = "Débito";
            }
            else
            {
                mskTroco.Text = vTroco.ToString();
            }
        }

        private void tmrInfo_Tick(object sender, EventArgs e)
        {
            tmrInfo.Enabled = false;
            lblInfo.Visible = false;
        }
        public void LigaInfo()
        {
            if (tmrInfo.Enabled == false)
            {
                lblInfo.Visible = true;
                tmrInfo.Enabled = true;
            }
        }
        public decimal ValorDebRetorno
        {
            get { return vValorDebito; }
            set { vValorDebito = value; }
        }

        private void lblPreco_TextChanged(object sender, EventArgs e)
        {
            AtualizaTroco();
        }

        private void txtidProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 08 && (Keys)e.KeyChar != Keys.Enter)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                if(txtidProd.Text == "")
                {
                    return;
                }
                if(vEnterOk == true)
                {
                    spnQuant.Focus();
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtidProd.Text = "";
                    txtBarra.Text = "";
                    txtBarra.Focus();
                }
            }
        }

        private void txtidProd_TextChanged(object sender, EventArgs e)
        {
            ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
            DB_ConceptDataSet.ProdutoDataTable dtProduto = new DB_ConceptDataSet.ProdutoDataTable();
            vEnterOk = false;

            if (txtidProd.Text == "")
            {
                txtnomeProd.Text = "";
                txtPreco.Text = "0,00";
                spnQuant.Value = 1;
                return;
            }

            dtProduto = taProduto.ProcuraProduto(int.Parse(txtidProd.Text));

            if (dtProduto.Rows.Count == 0)
            {
                txtnomeProd.Text = "";
                txtPreco.Text = "0,00";
                spnQuant.Value = 1;
                return;
            }


                
                txtnomeProd.Text = dtProduto.Rows[0]["Nome_Prod"].ToString();
                txtPreco.Text = dtProduto.Rows[0]["Preco_Prod"].ToString();
                vEnterOk = true;
        }

        private void spnQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAddProd.PerformClick();
            }
        }

        private void txtBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 08 && (Keys)e.KeyChar != Keys.Enter)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
                DB_ConceptDataSet.ProdutoDataTable dtProduto = new DB_ConceptDataSet.ProdutoDataTable();

                dtProduto = taProduto.VerificaBarras(txtBarra.Text);

                if(dtProduto.Rows.Count > 0)
                {
                    txtidProd.Text = dtProduto.Rows[0]["ID_Prod"].ToString();
                    txtidProd.Focus();
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBarra.Text = "";
                    txtBarra.Focus();
                }
            }
        }

        public void ApenasNumseVir(KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && (e.KeyChar != ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtValorRec_TextChanged(object sender, EventArgs e)
        {
            if (txtValorRec.Text == "")
            {
                txtValorRec.Text = "0,00";
            }
            AtualizaTroco();
        }

        private void txtValorRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumseVir(e);
        }

        private void txtBarra_Leave(object sender, EventArgs e)
        {
            txtBarra.Text = "";
        }
    }
}
