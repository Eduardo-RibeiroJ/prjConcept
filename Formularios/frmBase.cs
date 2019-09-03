using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjConcept
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }
        public int nCodGenerico;
        public DataTable dtGenerico = new DataTable();



        public enum StatusCadastro
        {
            scIncluindo,
            scConsultando,
            scAlterando
        }
        public StatusCadastro sStatus;

        //Metodo para Piscar o label de erro da pesquisa
        bool ligaErro;
        public async void ErroPesquisa()
        {
            if (tmrErro.Enabled == false && txtParam1.Visible == true || tmrErro.Enabled == false && txtParam2.Visible == true)
            {
                ligaErro = true;
                while (ligaErro)
                {
                        tmrErro.Enabled = true;
                        await Task.Delay(600);
                        lblInfo.Visible = lblInfo.Visible == true ? false : true;
                    }
            }
        }

        //Metodo para Informacao
        public void LigaInfo()
        {
            if(tmrInfo.Enabled == false)
            {
                lblInfo.Visible = true;
                tmrInfo.Enabled = true;
            }
        }


        private void LimpaControles()
        {
            foreach (Control ctr in this.gpbCampos.Controls)
            {
                if (ctr is TextBox)
                    (ctr as TextBox).Text = "";
                if (ctr is MaskedTextBox)
                    (ctr as MaskedTextBox).Text ="";
                if (ctr is ComboBox)
                    (ctr as ComboBox).SelectedIndex = -1;
                if (ctr is ListBox)
                    (ctr as ListBox).SelectedIndex = -1;
                if (ctr is RadioButton)
                    (ctr as RadioButton).Checked = false;
                if (ctr is CheckBox)
                    (ctr as CheckBox).Checked = false;
                if (ctr is NumericUpDown)
                    (ctr as NumericUpDown).Value = 1;
            }
        }
        private void HabilitaDesabilitaControles(bool bValue)
        {
            //habilitar os botões

            //Novo - será habilitado somente quando for navegação
            btnIncluir.Enabled = (sStatus == StatusCadastro.scConsultando);

            //Salvar
            btnGravar.Enabled = (sStatus == StatusCadastro.scAlterando || sStatus == StatusCadastro.scIncluindo);

            //Excluir
            btnExcluir.Enabled = (sStatus == StatusCadastro.scConsultando);

            //Localizar
            btnPesquisar.Visible = (sStatus == StatusCadastro.scConsultando);

            //Cancelar
            btnCancelar.Enabled = (sStatus == StatusCadastro.scAlterando || sStatus == StatusCadastro.scIncluindo);

            //Fechar
            btnSair.Enabled = true;
        }

        private void EsconderPesquisa()
        {
            //Deixar o campo de pesquisa escondido
            if (pnlPesquisa.Visible == true)
            this.Height = this.Height - pnlPesquisa.Height;
            pnlPesquisa.Visible = false;
            txtParam1.Visible = false;
            txtParam2.Visible = false;
            Atualiza_Grid();

        }

        public virtual void CarregaValores()
        {

        }
        public virtual void Atualiza_Grid()
        {

        }

        public virtual bool Salvar()
        {
            return false;
        }
        public virtual bool Excluir()
        {
            return false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scIncluindo;
            HabilitaDesabilitaControles(true);
            tbcBase.SelectTab(1);
            btnIncluir.Text = "Incluindo";
            lblStatus.Text = "Incluindo novo cliente...";
            tabPage2.Text = "Incluindo";
            lblStatus.Visible = true;
            LimpaControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbcBase.SelectTab(0);
            sStatus = StatusCadastro.scConsultando;
            HabilitaDesabilitaControles(true);
            btnIncluir.Text = "Incluir";
            tabPage2.Text = "Alterar";
            lblStatus.Visible = false;
            LimpaControles();
            dB_ConceptDataSetbindingSource.Filter = "";
            errErro.Clear();
            
        }

        private void tbcBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcBase.SelectedIndex == 1)
            {
                if (sStatus == StatusCadastro.scIncluindo)
                {
                    btnIncluir.Text = "Incluindo";
                    lblStatus.Text = "Incluindo novo cliente...";
                    tabPage2.Text = "Incluindo";
                    lblStatus.Visible = true;
                    LimpaControles();
                    tbcBase.SelectNextControl(pnlPesquisa, true, true, true, true);
                    EsconderPesquisa();

                }
                else
                {
                    btnIncluir.Text = "Alterando";
                    lblStatus.Text = "Alterando cliente...";
                    tabPage2.Text = "Alterar";
                    lblStatus.Visible = true;
                    sStatus = StatusCadastro.scAlterando;
                    EsconderPesquisa();
                }
            }
            else
            {
                sStatus = StatusCadastro.scConsultando;
                btnIncluir.Text = "Incluir";
                tabPage2.Text = "Alterar";
                lblStatus.Visible = false;
            }
            HabilitaDesabilitaControles(true);
            dB_ConceptDataSetbindingSource.Filter = "";
            errErro.Clear();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Salvar())
            {
                Atualiza_Grid();
                //Quando for inclusão, seleciona a última linha do DataGridView
                if (sStatus == StatusCadastro.scAlterando)
                {
                    lblInfo.Text = "Cadastro alterado!"; lblInfo.ForeColor = Color.White;
                    LigaInfo();
                }
                else
                {
                    lblInfo.Text = "Cadastro salvo!"; lblInfo.ForeColor = Color.White;
                    LigaInfo();
                }
                tbcBase.SelectTab(0);
                if (sStatus == StatusCadastro.scIncluindo)
                    dB_ConceptDataSetbindingSource.Position = dB_ConceptDataSetbindingSource.Count - 1;
                sStatus = StatusCadastro.scConsultando;
                HabilitaDesabilitaControles(false);
                LigaInfo();
            }  
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            btnIncluir.Text = "Incluir";
            tabPage2.Text = "Alterar";
            sStatus = StatusCadastro.scConsultando;
            Atualiza_Grid();
            EsconderPesquisa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.Rows.Count > 0)
            {
                if (MessageBox.Show("Confirma a exclusão?", "Excluindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    if (Excluir())
                    {
                        sStatus = StatusCadastro.scConsultando;
                        Atualiza_Grid();
                        lblInfo.Text = "O cadastro foi excluído!"; lblInfo.ForeColor = Color.White;
                        LigaInfo();
                    }
                    else
                    {
                        MessageBox.Show("O registro não foi excluído, por favor verifique os erros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (pnlPesquisa.Visible == true)
            {
                this.Height = this.Height - pnlPesquisa.Height;
                txtParam1.Visible = false;
                txtParam2.Visible = false;
                pnlPesquisa.Visible = false;
                cmbBuscar.SelectedIndex = -1;
                dB_ConceptDataSetbindingSource.Filter = "";

            }
            else
            {
                this.Height = this.Height + pnlPesquisa.Height;
                pnlPesquisa.Visible = true;
                cmbBuscar.SelectedIndex = -1;
                txtParam1.Visible = false;
                txtParam2.Visible = false;
                txtParam1.Text = "";
                txtParam2.Text = "";
                cmbColuna.Focus();

            }
        }

        private void cmbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int indiceCampo = cmbColuna.SelectedIndex;
            string tipoCampo = this.dgvConsulta.Columns[indiceCampo].ValueType.ToString();
            if (tipoCampo.Trim() == "System.Int32")
            {
                cmbBuscar.Items.Clear();
                cmbBuscar.Items.Add("Todos");
                cmbBuscar.Items.Add("Igual a");
                cmbBuscar.Items.Add("Maior que");
                cmbBuscar.Items.Add("Menor que");
                cmbBuscar.Items.Add("Diferente de");
                cmbBuscar.Items.Add("Que esteja entre");
            }
            else if (tipoCampo.Trim() == "System.String")
            {
                cmbBuscar.Items.Clear();
                cmbBuscar.Items.Add("Todos");
                cmbBuscar.Items.Add("Que começa com");
                cmbBuscar.Items.Add("Que contém");
            }
            else
            {
                MessageBox.Show("Implemente código para outros tipos de campo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vFiltro = "";
            if (cmbBuscar.Text == "Todos")
            {
                txtParam1.Visible = false;
                txtParam1.Text = "";
                txtParam2.Visible = false;
                txtParam2.Text = "";

                vFiltro = "";
                dB_ConceptDataSetbindingSource.RemoveFilter();
                dB_ConceptDataSetbindingSource.Filter = vFiltro;
            }
            else if (cmbBuscar.Text == "Que esteja entre")
            {
                txtParam1.Visible = true;
                txtParam1.Text = "";
                txtParam1.Focus();
                txtParam2.Visible = true;
                txtParam2.Text = "";
            }
            else if (cmbBuscar.Text == "")
            {

            }
            else
            {
                txtParam1.Visible = true;
                txtParam1.Text = "";
                txtParam1.Focus();
                txtParam2.Visible = false;
                txtParam2.Text = "";
            }
        }

        private void txtParam1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtParam1.Visible == true && txtParam2.Visible == false)
                {
                    string vFiltro = "", vOperacao = "=", vCampo = "";

                    if (cmbBuscar.Text == "Todos")
                        cmbColuna.SelectedIndex = -1;
                    else if (cmbColuna.SelectedIndex == -1 || cmbBuscar.SelectedIndex == -1)
                    {
                        lblInfo.Text = "Preencha os campos corretamente!"; lblInfo.ForeColor = Color.Red;
                        ErroPesquisa();
                        return;
                    }
                    //Definido a operação
                    if (cmbBuscar.Text == "Igual a")
                        vOperacao = " = ";
                    else if (cmbBuscar.Text == "Maior que")
                        vOperacao = " >= ";
                    else if (cmbBuscar.Text == "Menor que")
                        vOperacao = " <= ";
                    else if (cmbBuscar.Text == "Diferente de")
                        vOperacao = " <> ";
                    //elimina apóstrofos caso existam
                    /*txtParametro1.Text = txtParametro1.Text.Replace("", "");
                    txtParametro2.Text = txtParametro2.Text.Replace("", "");*/
                    if (cmbBuscar.Text == "Todos")
                    {
                        vFiltro = "";
                    }
                    else
                    {
                        vCampo = cmbColuna.Text;
                        vFiltro = vCampo;
                        if (dtGenerico.Columns[cmbColuna.SelectedIndex].DataType.Name == "String")
                        {
                            if (cmbBuscar.Text == "Que começa com")
                                vFiltro = vFiltro + " like '" + txtParam1.Text + "%'";
                            else if (cmbBuscar.Text == "Que contém")
                                vFiltro = vFiltro + " like '%" + txtParam1.Text + "%'";
                        }
                        else if (dtGenerico.Columns[cmbColuna.SelectedIndex].DataType.Name == "Int32")
                        {
                            if (cmbBuscar.Text == "Que esteja entre")
                                vFiltro = vFiltro + ">=" + txtParam1.Text + "and" + vCampo + "<=" + txtParam2.Text;
                            else
                                vFiltro = vFiltro + vOperacao + "'" + txtParam1.Text + "'";
                        }
                    }
                    dB_ConceptDataSetbindingSource.RemoveFilter();
                    dB_ConceptDataSetbindingSource.Filter = vFiltro;
                }
            }
            catch (Exception)
            {

            }
        }
        private void txtParam2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtParam1.Text != "" && int.Parse(txtParam1.Text) >= 0)
                {
                    string vCampo = cmbColuna.Text;
                    string vFiltro = vCampo;
                    vFiltro = vFiltro + " >= " + txtParam1.Text + " and " + vCampo + " <= " + txtParam2.Text;
                    dB_ConceptDataSetbindingSource.RemoveFilter();
                    dB_ConceptDataSetbindingSource.Filter = vFiltro;

                }
                else
                {
                    lblInfo.Text = "Preencha os campos corretamente!"; lblInfo.ForeColor = Color.Red;
                    ErroPesquisa();
                }
            } catch (Exception)
            {

            }
        }

        //Timer para o erro na pesquisa
        private void tmrErro_Tick(object sender, EventArgs e)
        {
            tmrErro.Enabled = false;
            ligaErro = false;          
        }

        private void tmrInfo_Tick(object sender, EventArgs e)
        {
            tmrInfo.Enabled = false;
            lblInfo.Visible = false;
        }

        private void dgvConsulta_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvConsulta.Rows.Count > 0)
            {
                CarregaValores();
                nCodGenerico = (int)dgvConsulta.CurrentRow.Cells[0].Value;
                tbcBase.SelectTab(1);
            }
        }

        private void dgvConsulta_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvConsulta.Rows.Count != 0)
            {
                CarregaValores();
                try
                {
                    nCodGenerico = (int)dgvConsulta.CurrentRow.Cells[0].Value;
                }
                catch (Exception)
                {

                }
            }
            else
            {
                lblInfo.Text = "Não foi encontrado registros!"; lblInfo.ForeColor = Color.Red;
                ErroPesquisa();
            }
        }

        public void ApenasNums(KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        public void ApenasLetras(KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 08 && (Keys)e.KeyChar != Keys.Space)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
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

    }
}
