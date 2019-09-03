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
    public partial class frmClientes : PrjConcept.frmBase
    {
        public frmClientes()
        {
            InitializeComponent();
            
        }

        public override void Atualiza_Grid()
        {
            try
            {
                
                this.Text = lblNomeTab.Text = "Clientes";
                DB_ConceptDataSet.ClienteDataTable dt = new DB_ConceptDataSet.ClienteDataTable();
                ClienteTableAdapter ta = new ClienteTableAdapter();
                // dt=ta.GetData
                DB_ConceptDataSet ds = new DB_ConceptDataSet();
                
                ta.Fill(ds.Cliente);
                
                dB_ConceptDataSetbindingSource.DataSource = ds.Cliente;
                dgvConsulta.DataSource = dB_ConceptDataSetbindingSource;
                //Config Das Colunas do DGV
                dgvConsulta.Columns[0].HeaderText = "Cod.";
                dgvConsulta.Columns[0].Width = 45;
                dgvConsulta.Columns[1].HeaderText = "Nome";
                dgvConsulta.Columns[1].Width = 200;
                dgvConsulta.Columns[2].HeaderText = "Endereço";
                dgvConsulta.Columns[2].Width = 150;
                dgvConsulta.Columns[3].HeaderText = "N°";
                dgvConsulta.Columns[3].Width = 50;
                dgvConsulta.Columns[4].HeaderText = "Bairro";
                dgvConsulta.Columns[4].Width = 150;
                dgvConsulta.Columns[5].HeaderText = "CEP";
                dgvConsulta.Columns[5].Width = 85;
                dgvConsulta.Columns[6].HeaderText = "Complemento";
                dgvConsulta.Columns[6].Width = 150;
                dgvConsulta.Columns[7].HeaderText = "Cidade";
                dgvConsulta.Columns[7].Width = 100;
                dgvConsulta.Columns[8].HeaderText = "UF";
                dgvConsulta.Columns[8].Width = 35;
                dgvConsulta.Columns[9].HeaderText = "Tel";
                dgvConsulta.Columns[9].Width = 125;                
                dgvConsulta.Columns[10].HeaderText = "Cel";
                dgvConsulta.Columns[10].Width = 125;
                dgvConsulta.Columns[11].HeaderText = "E-mail";
                dgvConsulta.Columns[11].Width = 150;
                dgvConsulta.Columns[12].HeaderText = "RG";
                dgvConsulta.Columns[12].Width = 100;
                dgvConsulta.Columns[13].HeaderText = "CPF";
                dgvConsulta.Columns[13].Width = 110;
                dgvConsulta.Columns[14].HeaderText = "Data Nasc.";
                dgvConsulta.Columns[14].Width = 105;
                dgvConsulta.Columns[15].HeaderText = "Sexo";
                dgvConsulta.Columns[15].Width = 50;
                dgvConsulta.Columns[16].HeaderText = "Obs";
                dgvConsulta.Columns[16].Width = 200;




                //Carrega as combos com as colunas

                if (cmbColuna.Items.Count == 0)
                {
                    foreach (DataColumn coluna in ds.Cliente.Columns)
                    {
                        cmbColuna.Items.Add(coluna.ColumnName);
                    }
                }

                cmbColuna.SelectedIndex = 1;

                dtGenerico = ds.Cliente;

            }
            catch (Exception)
            {
               
            }

        }
        public override void CarregaValores()
        {
            string sex;
            try
            {
                txtNome.Text = dgvConsulta.CurrentRow.Cells["Nome_Cli"].Value.ToString();
                txtEnd.Text = dgvConsulta.CurrentRow.Cells["End_Cli"].Value.ToString();
                txtNum.Text = dgvConsulta.CurrentRow.Cells["Num_Cli"].Value.ToString();
                txtBairro.Text = dgvConsulta.CurrentRow.Cells["Bairro_Cli"].Value.ToString();
                mskCEP.Text = dgvConsulta.CurrentRow.Cells["CEP_Cli"].Value.ToString();
                txtComp.Text = dgvConsulta.CurrentRow.Cells["Comp_Cli"].Value.ToString();
                txtCidade.Text = dgvConsulta.CurrentRow.Cells["Cidade_Cli"].Value.ToString();
                txtUF.Text = dgvConsulta.CurrentRow.Cells["UF_Cli"].Value.ToString();
                mskTel.Text = dgvConsulta.CurrentRow.Cells["Tel_Cli"].Value.ToString();
                mskCel.Text = dgvConsulta.CurrentRow.Cells["Cel_Cli"].Value.ToString();
                txtEmail.Text = dgvConsulta.CurrentRow.Cells["Email_Cli"].Value.ToString();
                txtRG.Text = dgvConsulta.CurrentRow.Cells["RG_Cli"].Value.ToString();
                mskCPF.Text = dgvConsulta.CurrentRow.Cells["CPF_Cli"].Value.ToString();
                mskDataNasc.Text = dgvConsulta.CurrentRow.Cells["DataNasc_Cli"].Value.ToString();
                if (dgvConsulta.CurrentRow.Cells["Sexo_Cli"].Value.ToString() == "f")
                    sex = "Feminino";
                else
                    sex = "Masculino";
                cmbSexo.Text = sex;
                txtObs.Text = dgvConsulta.CurrentRow.Cells["Obs_Cli"].Value.ToString();

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

                string sexo;
                if (cmbSexo.Text == "Feminino")
                {
                    sexo = "f";
                }
                else
                {
                    sexo = "m";
                }

                ClienteTableAdapter ta = new ClienteTableAdapter();
                if (sStatus == StatusCadastro.scIncluindo)
                {
                    bSalvar = (ta.Insert(txtNome.Text, txtEnd.Text, int.Parse(txtNum.Text), txtBairro.Text, mskCEP.Text, txtComp.Text, txtCidade.Text, txtUF.Text, mskTel.Text, mskCel.Text, txtEmail.Text, txtRG.Text, mskCPF.Text, DateTime.Parse(mskDataNasc.Text), sexo, txtObs.Text) > 0);
                }
                else if (sStatus == StatusCadastro.scAlterando)
                {
                    if (nCodGenerico == 1)
                    {
                        MessageBox.Show("Não é possível alterar cadastros do sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return bSalvar;
                    }
                    bSalvar = (ta.Update(txtNome.Text, txtEnd.Text, int.Parse(txtNum.Text), txtBairro.Text, mskCEP.Text, txtComp.Text, txtCidade.Text, txtUF.Text, mskTel.Text, mskCel.Text, txtEmail.Text, txtRG.Text, mskCPF.Text, DateTime.Parse(mskDataNasc.Text), sexo, txtObs.Text, nCodGenerico) > 0);
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
            if (nCodGenerico == 1)
            {
                MessageBox.Show("Não é possível excluir cadastros do sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return bExcluir;
            }
            ClienteTableAdapter ta = new ClienteTableAdapter();
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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLetras(e);
        }

        private bool CaixasOK()
        {

            if (txtNome.Text == "")
            {
                errErro.SetError(txtNome, "Insira o nome do cliente");
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
                errErro.SetError(txtNum, "Insira o número da residência");
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


            if (mskCel.MaskCompleted == false)
            {
                errErro.SetError(mskCel, "Insira um número de telefone");
                return false;
            }
            else
                errErro.SetError(mskCel, "");

            if (txtRG.Text == "")
            {
                errErro.SetError(txtRG, "Insira o RG");
                return false;
            }
            else
                errErro.SetError(txtRG, "");

            if (mskCPF.MaskCompleted == false)
            {
                errErro.SetError(mskCPF, "Insira o CPF");
                return false;
            }
            else
                errErro.SetError(mskCPF, "");

            ClienteTableAdapter taCli = new ClienteTableAdapter();
            DB_ConceptDataSet.ClienteDataTable dtCli = new DB_ConceptDataSet.ClienteDataTable();

            dtCli = taCli.VerificaCPF(mskCPF.Text);

            if (dtCli.Rows.Count > 0 && btnIncluir.Text == "Incluindo")
            {
                errErro.SetError(mskCPF, "Este cliente já está cadastrado!");
                return false;
            }
            else
                errErro.SetError(mskCPF, "");

            if (mskDataNasc.MaskCompleted == false)
            {
                errErro.SetError(mskDataNasc, "Insira a data de nascimento");
                return false;
            }
            else
                errErro.SetError(mskDataNasc, "");

            if (cmbSexo.Text == "")
            {
                errErro.SetError(cmbSexo, "Insira o sexo");
                return false;
            }
            else
                errErro.SetError(cmbSexo, "");

            return true;
        }

    }

}
