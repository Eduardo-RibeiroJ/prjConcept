using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjConcept.Dados.DB_ConceptDataSetTableAdapters;
using PrjConcept.Dados;

namespace PrjConcept
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        int vErros = 0;

        private bool CaixasOK()
        {
            if (txtUsuario.Text == "")
            {
                errErro.SetError(txtUsuario, "Insira seu usuário!");
                return false;
            }
            else
                errErro.SetError(txtUsuario, "");

            if (txtSenha.Text == "")
            {
                errErro.SetError(txtSenha, "Insira sua senha!");
                return false;
            }
            else
                errErro.SetError(txtSenha, "");
            return true;
        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if(CaixasOK())
            {
                DB_ConceptDataSet.FuncionarioDataTable dtFuncionario;
                FuncionarioTableAdapter taFuncionario = new FuncionarioTableAdapter();

                dtFuncionario = taFuncionario.VerificaFunc(txtUsuario.Text, txtSenha.Text);

                if(dtFuncionario.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    vErros++;
                    if(vErros ==3)
                    {
                        MessageBox.Show("Número de tentativas esgotado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        taFuncionario.Dispose();
                        this.Close();
                    }
                }
                else
                {
                  
                    frmPrincipal principal = new frmPrincipal();
                    principal.lblNomeFunc.Text = dtFuncionario.Rows[0]["Nome_Func"].ToString();
                    principal.lblIdFunc.Text = dtFuncionario.Rows[0]["ID_Func"].ToString();

                    principal.Show();
                    this.Hide();


                }
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogar.PerformClick();
            }
        }
    }
}
