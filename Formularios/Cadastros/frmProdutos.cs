using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PrjConcept.Dados;
using PrjConcept.Dados.DB_ConceptDataSetTableAdapters;
using PrjConcept.Formularios.Sistema;

namespace PrjConcept.Formularios.Cadastros
{
    public partial class frmProdutos : PrjConcept.frmBase
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        int vCodForn = 1;
        public override void Atualiza_Grid()
        {
            try
            {
                this.Text = lblNomeTab.Text = "Produtos";
                DB_ConceptDataSet.ProdutoDataTable dt = new DB_ConceptDataSet.ProdutoDataTable();
                ProdutoTableAdapter ta = new ProdutoTableAdapter();
                // dt=ta.GetData
                DB_ConceptDataSet ds = new DB_ConceptDataSet();
                ta.Fill(ds.Produto);
                dB_ConceptDataSetbindingSource.DataSource = ds.Produto;
                dgvConsulta.DataSource = dB_ConceptDataSetbindingSource;

                //Config Das Colunas do DGV
                dgvConsulta.Columns[0].HeaderText = "Cod.";
                dgvConsulta.Columns[0].Width = 45;
                dgvConsulta.Columns[1].HeaderText = "Forn.";
                dgvConsulta.Columns[1].Width = 50;
                dgvConsulta.Columns[2].HeaderText = "Cod. Barras";
                dgvConsulta.Columns[2].Width = 150;
                dgvConsulta.Columns[3].HeaderText = "Produto";
                dgvConsulta.Columns[3].Width = 180;
                dgvConsulta.Columns[4].HeaderText = "Quant.";
                dgvConsulta.Columns[4].Width = 60;
                dgvConsulta.Columns[5].HeaderText = "Preço";
                dgvConsulta.Columns[5].Width = 90;
                dgvConsulta.Columns[5].DefaultCellStyle.Format = "C2";
                dgvConsulta.Columns[6].HeaderText = "Custo";
                dgvConsulta.Columns[6].Width = 90;
                dgvConsulta.Columns[6].DefaultCellStyle.Format = "C2";
                dgvConsulta.Columns[7].HeaderText = "Descrição";
                dgvConsulta.Columns[7].Width = 150;

                //Carrega as combos com as colunas

                if (cmbColuna.Items.Count == 0)
                {
                    foreach (DataColumn coluna in ds.Produto.Columns)
                    {
                        cmbColuna.Items.Add(coluna.ColumnName);
                    }
                }
                cmbColuna.SelectedIndex = 3;

                dtGenerico = ds.Produto;
                
            }
            catch (Exception)
            {

            }

        }

        public override void CarregaValores()
        {
            try
            {
                vCodForn = int.Parse(dgvConsulta.CurrentRow.Cells["ID_Forn"].Value.ToString());
                txtCodBarras.Text = dgvConsulta.CurrentRow.Cells["CodBarras_Prod"].Value.ToString();
                txtProd.Text = dgvConsulta.CurrentRow.Cells["Nome_Prod"].Value.ToString();
                txtEstoque.Text = dgvConsulta.CurrentRow.Cells["Quant_Prod"].Value.ToString();
                txtPreco.Text = dgvConsulta.CurrentRow.Cells["Preco_Prod"].Value.ToString();
                txtCusto.Text = dgvConsulta.CurrentRow.Cells["Custo_Prod"].Value.ToString();
                txtDesc.Text = dgvConsulta.CurrentRow.Cells["Desc_Prod"].Value.ToString();
                spnQuant.Value = 0;
                txtIDForn.Text = vCodForn.ToString();

                ProdutoTableAdapter taProd = new ProdutoTableAdapter();
                DB_ConceptDataSet.ProdutoDataTable dtProd = new DB_ConceptDataSet.ProdutoDataTable();

                dtProd = taProd.RetForn(Convert.ToInt32(txtIDForn.Text));
                if (dtProd.Rows.Count > 0)
                {
                    txtForn.Text = dtProd.Rows[0]["Nome_Forn"].ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        public override bool Salvar()
        {
            bool bSalvar = false;
            try
            {
                string vCodBarra;
                

                if (CaixasOK() == false)
                {
                    return false;
                }

                ProdutoTableAdapter ta = new ProdutoTableAdapter();

                if (txtCodBarras.Text == "")
                {
                    vCodBarra = null;
                }
                else
                {
                    vCodBarra = txtCodBarras.Text;
                }

                if (txtIDForn.Text == "")
                {
                    vCodForn = 1;
                }

                if (sStatus == StatusCadastro.scIncluindo)
                {
                    bSalvar = (ta.Insert(vCodForn, vCodBarra, txtProd.Text, (int)spnQuant.Value, decimal.Parse(txtPreco.Text), decimal.Parse(txtCusto.Text), txtDesc.Text) > 0);
                }
                else if (sStatus == StatusCadastro.scAlterando)
                {
                    bSalvar = (ta.Update(vCodForn, vCodBarra, txtProd.Text, (int)spnQuant.Value, decimal.Parse(txtPreco.Text), decimal.Parse(txtCusto.Text), txtDesc.Text, nCodGenerico) > 0);
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Algum campo foi inserido incorretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bSalvar;
        }
        public override bool Excluir()
        {
            bool bExcluir = false;
            ProdutoTableAdapter ta = new ProdutoTableAdapter();
            bExcluir = (ta.Delete(nCodGenerico) > 0);
            return bExcluir;
        }

        private void btnAddForn_Click(object sender, EventArgs e)
        {
            frmPesForn PesForn = new frmPesForn();
            PesForn.ShowDialog();

            if (PesForn.CodRetorno != 0 && PesForn.NomeRetorno != null)
            {
                vCodForn = PesForn.CodRetorno;
                txtForn.Text = PesForn.NomeRetorno.ToString();
                txtIDForn.Text = PesForn.CodRetorno.ToString();              

            }
        }

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNums(e);
        }

        private bool CaixasOK()
        {
            ProdutoTableAdapter taProd = new ProdutoTableAdapter();
            DB_ConceptDataSet.ProdutoDataTable dtProd = new DB_ConceptDataSet.ProdutoDataTable();

            dtProd = taProd.VerificaBarras(txtCodBarras.Text);

            if (dtProd.Rows.Count > 0 && btnIncluir.Text == "Incluindo")
            {
                errErro.SetError(txtCodBarras, "Este código de barras já existe");
                return false;
            }
            else
                errErro.SetError(txtCodBarras, "");
            
            if (txtProd.Text == "")
            {
                errErro.SetError(txtProd, "Insira o nome do produto");
                return false;
            }
            else
                errErro.SetError(txtProd, "");

            if (txtPreco.Text == "")
            {
                errErro.SetError(txtPreco, "Insira o preço");
                return false;
            }
            else
                errErro.SetError(txtPreco, "");

            if (txtCusto.Text == "")
            {
                errErro.SetError(txtCusto, "Insira o valor de custo");
                return false;
            }
            else
                errErro.SetError(txtCusto, "");

            return true;
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumseVir(e);
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumseVir(e);
        }

    }
}
