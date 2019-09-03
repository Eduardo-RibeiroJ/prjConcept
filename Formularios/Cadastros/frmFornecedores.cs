using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PrjConcept.Dados;
using PrjConcept.Dados.DB_ConceptDataSetTableAdapters;

namespace PrjConcept.Formularios.Cadastros
{
    public partial class frmFornecedores : PrjConcept.frmBase
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        public override void Atualiza_Grid()
        {
            try
            {
                this.Text = lblNomeTab.Text = "Fornecedores";
                DB_ConceptDataSet.FornecedorDataTable dt = new DB_ConceptDataSet.FornecedorDataTable();
                FornecedorTableAdapter ta = new FornecedorTableAdapter();
                // dt=ta.GetData
                DB_ConceptDataSet ds = new DB_ConceptDataSet();
                ta.Fill(ds.Fornecedor);
                dB_ConceptDataSetbindingSource.DataSource = ds.Fornecedor;
                dgvConsulta.DataSource = dB_ConceptDataSetbindingSource;

                //Config Das Colunas do DGV
                dgvConsulta.Columns[0].HeaderText = "Cod.";
                dgvConsulta.Columns[0].Width = 45;
                dgvConsulta.Columns[1].HeaderText = "Fornecedor";
                dgvConsulta.Columns[1].Width = 200;
                dgvConsulta.Columns[2].HeaderText = "Endereço";
                dgvConsulta.Columns[2].Width = 150;
                dgvConsulta.Columns[3].HeaderText = "N°";
                dgvConsulta.Columns[3].Width = 50;
                dgvConsulta.Columns[4].HeaderText = "CEP";
                dgvConsulta.Columns[4].Width = 85;
                dgvConsulta.Columns[5].HeaderText = "Bairro";
                dgvConsulta.Columns[5].Width = 150;
                dgvConsulta.Columns[6].HeaderText = "Complemento";
                dgvConsulta.Columns[6].Width = 150;
                dgvConsulta.Columns[7].HeaderText = "Cidade";
                dgvConsulta.Columns[7].Width = 110;
                dgvConsulta.Columns[8].HeaderText = "UF";
                dgvConsulta.Columns[8].Width = 35;
                dgvConsulta.Columns[9].HeaderText = "Tel";
                dgvConsulta.Columns[9].Width = 125;
                dgvConsulta.Columns[10].HeaderText = "Cel";
                dgvConsulta.Columns[10].Width = 125;
                dgvConsulta.Columns[11].HeaderText = "E-mail";
                dgvConsulta.Columns[11].Width = 150;
                dgvConsulta.Columns[12].HeaderText = "CNPJ";
                dgvConsulta.Columns[12].Width = 140;
                dgvConsulta.Columns[13].HeaderText = "Vendedores";
                dgvConsulta.Columns[13].Width = 170;
                dgvConsulta.Columns[14].HeaderText = "Obs.";
                dgvConsulta.Columns[14].Width = 200;

                //Carrega as combos com as colunas

                if (cmbColuna.Items.Count == 0)
                {
                    foreach (DataColumn coluna in ds.Fornecedor.Columns)
                    {
                        cmbColuna.Items.Add(coluna.ColumnName);
                    }
                }

                cmbColuna.SelectedIndex = 1;
                dtGenerico = ds.Fornecedor;

            }
            catch (Exception)
            {

            }

        }
        public override void CarregaValores()
        {
            try
            {
                txtNome.Text = dgvConsulta.CurrentRow.Cells["Nome_Forn"].Value.ToString();
                txtEnd.Text = dgvConsulta.CurrentRow.Cells["End_Forn"].Value.ToString();
                txtNum.Text = dgvConsulta.CurrentRow.Cells["Num_Forn"].Value.ToString();
                mskCEP.Text = dgvConsulta.CurrentRow.Cells["CEP_Forn"].Value.ToString();
                txtBairro.Text = dgvConsulta.CurrentRow.Cells["Bairro_Forn"].Value.ToString();
                txtComp.Text = dgvConsulta.CurrentRow.Cells["Comp_Forn"].Value.ToString();
                txtCidade.Text = dgvConsulta.CurrentRow.Cells["Cidade_Forn"].Value.ToString();
                txtUF.Text = dgvConsulta.CurrentRow.Cells["UF_Forn"].Value.ToString();
                mskTel.Text = dgvConsulta.CurrentRow.Cells["Tel_Forn"].Value.ToString();
                mskCel.Text = dgvConsulta.CurrentRow.Cells["Cel_Forn"].Value.ToString();
                txtEmail.Text = dgvConsulta.CurrentRow.Cells["Email_Forn"].Value.ToString();
                mskCNPJ.Text = dgvConsulta.CurrentRow.Cells["CNPJ_Forn"].Value.ToString();
                txtVend.Text = dgvConsulta.CurrentRow.Cells["Vendedores_Forn"].Value.ToString();
                txtObs.Text = dgvConsulta.CurrentRow.Cells["Obs_Forn"].Value.ToString();

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
            if (CaixasOK() == false)
            {
                return false;
            }

            FornecedorTableAdapter ta = new FornecedorTableAdapter();
            if (sStatus == StatusCadastro.scIncluindo)
            {
                bSalvar = (ta.Insert(txtNome.Text, txtEnd.Text, int.Parse(txtNum.Text), mskCEP.Text, txtBairro.Text, txtComp.Text, txtCidade.Text, txtUF.Text, mskTel.Text, mskCel.Text, txtEmail.Text, mskCNPJ.Text, txtVend.Text, txtObs.Text) > 0);
            }
            else if (sStatus == StatusCadastro.scAlterando)
            {
                if (nCodGenerico == 1)
                {
                    MessageBox.Show("Não é possível alterar cadastros do sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return bSalvar;
                }
                bSalvar = (ta.Update(txtNome.Text, txtEnd.Text, int.Parse(txtNum.Text), mskCEP.Text, txtBairro.Text, txtComp.Text, txtCidade.Text, txtUF.Text, mskTel.Text, mskCel.Text, txtEmail.Text, mskCNPJ.Text, txtVend.Text, txtObs.Text, nCodGenerico) > 0);
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
            FornecedorTableAdapter ta = new FornecedorTableAdapter();
            bExcluir = (ta.Delete(nCodGenerico) > 0);
            return bExcluir;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNums(e);
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLetras(e);
        }


        private bool CaixasOK()
        {

            if (txtNome.Text == "")
            {
                errErro.SetError(txtNome, "Insira o nome do fornecedor");
                return false;
            }
            else
                errErro.SetError(txtNome, "");

            if (txtEnd.Text == "")
            {
                errErro.SetError(txtEnd, "Insira o endereço");
                return false;
            }
            else
                errErro.SetError(txtEnd, "");

            if (txtNum.Text == "")
            {
                errErro.SetError(txtNum, "Insira o número");
                return false;
            }
            else
                errErro.SetError(txtNum, "");

            if (txtBairro.Text == "")
            {
                errErro.SetError(txtBairro, "Insira o nome do bairro");
                return false;
            }
            else
                errErro.SetError(txtBairro, "");

            if (mskCEP.MaskCompleted == false)
            {
                errErro.SetError(mskCEP, "Insira o CEP");
                return false;
            }
            else
                errErro.SetError(mskCEP, "");

            if (txtCidade.Text == "")
            {
                errErro.SetError(txtCidade, "Insira a cidade");
                return false;
            }
            else
                errErro.SetError(txtCidade, "");

            if (txtUF.Text == "")
            {
                errErro.SetError(txtUF, "Insira o estado");
                return false;
            }
            else
                errErro.SetError(txtUF, "");

            if (mskTel.MaskCompleted == false)
            {
                errErro.SetError(mskTel, "Insira um número de telefone");
                return false;
            }
            else
                errErro.SetError(mskTel, "");

            if (mskCNPJ.MaskCompleted == false)
            {
                errErro.SetError(mskCNPJ, "Insira o CPNJ");
                return false;
            }
            else
                errErro.SetError(mskCNPJ, "");

            FornecedorTableAdapter taForn = new FornecedorTableAdapter();
            DB_ConceptDataSet.FornecedorDataTable dtForn = new DB_ConceptDataSet.FornecedorDataTable();

            dtForn = taForn.VerificaCNPJ(mskCNPJ.Text);

            if (dtForn.Rows.Count > 0 && btnIncluir.Text == "Incluindo")
            {
                errErro.SetError(mskCNPJ, "Este fornecedor já está cadastrado!");
                return false;
            }
            else
                errErro.SetError(mskCNPJ, "");

            return true;
        }
    }
}
