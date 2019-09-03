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
    public partial class frmFuncionarios : PrjConcept.frmBase
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }
        string vSenha;
            public override void Atualiza_Grid()
            {
                try
                {
                    this.Text = lblNomeTab.Text = "Funcionários";
                    DB_ConceptDataSet.FuncionarioDataTable dt = new DB_ConceptDataSet.FuncionarioDataTable();
                    FuncionarioTableAdapter ta = new FuncionarioTableAdapter();
                    // dt=ta.GetData
                    DB_ConceptDataSet ds = new DB_ConceptDataSet();
                    ta.Fill(ds.Funcionario);
                    dB_ConceptDataSetbindingSource.DataSource = ds.Funcionario;
                    dgvConsulta.DataSource = dB_ConceptDataSetbindingSource;

                    //Config Das Colunas do DGV
                    dgvConsulta.Columns[0].HeaderText = "Cod.";
                    dgvConsulta.Columns[0].Width = 45;
                    dgvConsulta.Columns[1].HeaderText = "Nome";
                    dgvConsulta.Columns[1].Width = 200;
                    dgvConsulta.Columns[2].HeaderText = "Login";
                    dgvConsulta.Columns[2].Width = 150;
                    dgvConsulta.Columns[3].Visible = false;

                    dtGenerico = ds.Funcionario;
                    errErro.Clear();
                }
                catch (Exception)
                {

                }

            }
            public override void CarregaValores()
            {
                try
                {
                    txtNome.Text = dgvConsulta.CurrentRow.Cells["Nome_Func"].Value.ToString();
                    txtLogin.Text = dgvConsulta.CurrentRow.Cells["Login_Func"].Value.ToString();
                    txtSenha1.Text = "";
                    txtSenha2.Text = "";
                }
                catch (Exception)
                {

                }
            }

            public override bool Salvar()
            {
                bool bSalvar = false;
                if (CaixasOK() == false)
                {
                    return false;
                }
                    
                    FuncionarioTableAdapter ta = new FuncionarioTableAdapter();
                    if (sStatus == StatusCadastro.scIncluindo)
                    {

                        bSalvar = (ta.Insert(txtNome.Text, txtLogin.Text, vSenha) > 0);
                    }
                    else if (sStatus == StatusCadastro.scAlterando)
                    {
                        if (nCodGenerico == 1)
                        {
                            MessageBox.Show("Não é possível alterar cadastros do sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return bSalvar;
                        }
                        bSalvar = (ta.Update(txtNome.Text, txtLogin.Text, vSenha, nCodGenerico) > 0);
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
                    FuncionarioTableAdapter ta = new FuncionarioTableAdapter();
                    bExcluir = (ta.Delete(nCodGenerico) > 0);
                    return bExcluir;
            }

            private bool CaixasOK()
            {
                if (txtNome.Text == "")
                {
                    errErro.SetError(txtNome, "Insira um nome");
                    return false;
                }
                else
                    errErro.SetError(txtNome, "");

                FuncionarioTableAdapter taFunc = new FuncionarioTableAdapter();
                DB_ConceptDataSet.FuncionarioDataTable dtFunc = new DB_ConceptDataSet.FuncionarioDataTable();

                dtFunc = taFunc.VerificaNome(txtNome.Text);

                if (dtFunc.Rows.Count > 0 && dtFunc.Rows[0]["Nome_Func"].ToString() == txtNome.Text && btnIncluir.Text == "Incluindo")
                {
                    errErro.SetError(txtNome, "Nome de usuário já existente");
                    return false;
                }
                else
                    errErro.SetError(txtNome, "");

                if (txtLogin.Text == "")
                {
                    errErro.SetError(txtLogin, "Insira um login");
                    return false;
                }
                else
                    errErro.SetError(txtLogin, "");

                dtFunc = taFunc.VerificaLogin(txtLogin.Text);

                if (dtFunc.Rows.Count > 0 && btnIncluir.Text == "Incluindo" && dtFunc.Rows[0]["Login_Func"].ToString() == txtLogin.Text)
                {
                    errErro.SetError(txtLogin, "Login já existente");
                    return false;
                }
                else errErro.SetError(txtLogin, "");

                if (txtSenha1.Text == "")
                {
                    errErro.SetError(txtSenha1, "Insira uma senha");
                    return false;
                }
                else
                    vSenha = txtSenha1.Text;
                    errErro.SetError(txtSenha1, "");

                if (txtSenha2.Text == "")
                {
                    errErro.SetError(txtSenha2, "Repita a senha");
                    return false;
                }
                else
                    errErro.SetError(txtSenha2, "");

                if(txtSenha1.Text != txtSenha2.Text)
                {
                    MessageBox.Show("As senhas inseridas devem ser iguais!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errErro.SetError(txtSenha1, "As senhas devem ser iguais");
                    errErro.SetError(txtSenha2, "As senhas devem ser iguais");
                    txtSenha1.Clear();
                    txtSenha2.Clear();
                    return false;
                }


                return true;
            }
        }
    }
