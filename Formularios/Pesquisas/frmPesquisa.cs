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

namespace PrjConcept.Formularios.Sistema
{
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        public DataTable dtGenerico = new DataTable();

        //Metodo para Piscar o label de erro da pesquisa
        public void ErroPesquisa()
        {
            if (tmrErro.Enabled == false)
            {
                lblInfo.Visible = true;
                tmrErro.Enabled = true;
            }
        }

        public virtual void Atualiza_Grid()
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            Atualiza_Grid();
        }

        public virtual void ApertaSelecionar()
        {

        }
        public virtual void VerificaVencimento()
        {

        }

        private void cmbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int indiceCampo = cmbColuna.SelectedIndex;
            string indiceCampo = cmbColuna.Text;

            if (cmbColuna.Text == "Nome")
                indiceCampo = "Nome_Cli";
            else if (cmbColuna.Text == "Vencimento")
                indiceCampo = "Prazo_Debito";

            string tipoCampo = this.dgvPesquisa.Columns[indiceCampo].ValueType.ToString();

            if (tipoCampo.Trim() == "System.Int32")
            {
                cmbBuscar.Items.Clear();
                cmbBuscar.Items.Add("Todos");
                cmbBuscar.Items.Add("Igual a");
                cmbBuscar.Items.Add("Maior que");
                cmbBuscar.Items.Add("Menor que");
                cmbBuscar.Items.Add("Diferente de");
                cmbBuscar.Items.Add("Que esteja entre");
                dtp1.Visible = false;
                dtp2.Visible = false;
            }
            else if (tipoCampo.Trim() == "System.String")
            {
                if (cmbColuna.Text == "Possui_Debito")
                {
                    cmbBuscar.Items.Clear();
                    cmbBuscar.Items.Add("Sim");
                    cmbBuscar.Items.Add("Não");
                    txtParam1.Visible = false;
                    txtParam1.Text = "";
                    txtParam2.Visible = false;
                    txtParam2.Text = "";
                    dtp1.Visible = false;
                    dtp2.Visible = false;
                }
                else
                {
                    cmbBuscar.Items.Clear();
                    cmbBuscar.Items.Add("Todos");
                    cmbBuscar.Items.Add("Que começa com");
                    cmbBuscar.Items.Add("Que contém");
                    dtp1.Visible = false;
                    dtp2.Visible = false;
                }
            }
            else if(tipoCampo.Trim() == "System.DateTime")
            {
                cmbBuscar.Items.Clear();
                txtParam1.Visible = false;
                txtParam1.Text = "";
                txtParam2.Visible = false;
                txtParam2.Text = "";
                dtp1.Visible = true;
                cmbBuscar.Items.Add("Do dia / Até dia");
                cmbBuscar.SelectedIndex = 0;
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
                dB_ConceptBindingSource2.RemoveFilter();
                dB_ConceptBindingSource2.Filter = vFiltro;
                VerificaVencimento();
            }
            else if(cmbBuscar.Text == "Do dia / Até dia")
            {
                txtParam1.Visible = false;
                txtParam1.Text = "";
                txtParam2.Visible = false;
                txtParam2.Text = "";
                //Mostrar dtp
            }
                    else if(cmbBuscar.Text == "Sim")
                    {
                        vFiltro = "Possui_Debito like 's%'";

                        dB_ConceptBindingSource2.RemoveFilter();
                        dB_ConceptBindingSource2.Filter = vFiltro;
                        VerificaVencimento();
                    }
                    else if (cmbBuscar.Text == "Não")
                    {
                        vFiltro = "Possui_Debito like 'n%'";
                        dB_ConceptBindingSource2.RemoveFilter();
                        dB_ConceptBindingSource2.Filter = vFiltro;
                        VerificaVencimento();
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
                    string vFiltro = "", vOperacao = "=", vCampo = "", vTipoCampo;

                    vTipoCampo = cmbColuna.Text;
                    if (cmbColuna.Text == "Nome")
                        vTipoCampo = "Nome_Cli";
                    else if (cmbColuna.Text == "Vencimento")
                        vTipoCampo = "Prazo_Debito";

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
                        if (dtGenerico.Columns[vTipoCampo].DataType.Name == "String")
                        {
                            if (cmbBuscar.Text == "Que começa com")
                                vFiltro = vFiltro + " like '" + txtParam1.Text + "%'";
                            else if (cmbBuscar.Text == "Que contém")
                                vFiltro = vFiltro + " like '%" + txtParam1.Text + "%'";
                        }
                        else if (dtGenerico.Columns[vTipoCampo].DataType.Name == "Int32")
                        {
                            if (cmbBuscar.Text == "Que esteja entre")
                            {
                                if (txtParam2.Text != "" && int.Parse(txtParam2.Text) >= 0)
                                {
                                    vFiltro = vFiltro + " >= " + txtParam1.Text + " and " + vCampo + " <= " + txtParam2.Text;


                                }
                                else
                                {
                                    lblInfo.Text = "Preencha os campos corretamente!"; lblInfo.ForeColor = Color.Red;
                                    ErroPesquisa();
                                }
                            }
                        }
                        dB_ConceptBindingSource2.RemoveFilter();
                        dB_ConceptBindingSource2.Filter = vFiltro;
                        VerificaVencimento();
                    }
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
                    dB_ConceptBindingSource2.RemoveFilter();
                    dB_ConceptBindingSource2.Filter = vFiltro;
                    VerificaVencimento();

                }
                else
                {
                    lblInfo.Text = "Preencha os campos corretamente!"; lblInfo.ForeColor = Color.Red;
                    ErroPesquisa();
                }
            }
            catch (Exception)
            {

            }
        }

        private void tmrErro_Tick(object sender, EventArgs e)
        {
            tmrErro.Enabled = false;
            lblInfo.Visible = false;
        }

        private void dgvPesquisa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPesquisa.Rows.Count == 0)
            {

                lblInfo.Text = "Não foi encontrado registros!"; lblInfo.ForeColor = Color.Red;
                ErroPesquisa();
                lblTel.Visible = false;
                lblCel.Visible = false;
                return;
            }
            if (lblNomeTab.Text == "Débitos")
            {
                ClienteTableAdapter taCli = new ClienteTableAdapter();
                DB_ConceptDataSet.ClienteDataTable dtCli = new DB_ConceptDataSet.ClienteDataTable();

                dtCli = taCli.PegaTel(dgvPesquisa.CurrentRow.Cells["Nome_Cli"].Value.ToString());
                string vTel = dtCli.Rows[0]["Tel_Cli"].ToString();
                string vCel = dtCli.Rows[0]["Cel_Cli"].ToString();

                if (dgvPesquisa.CurrentRow.Cells["Possui_Debito"].Value.ToString() == "sim")
                {
                    lblTel.Visible = true;
                    lblTel.Text = "Tel: " + vTel;
                    if (vCel != null && vCel != "(  )     -    ")
                    {
                        lblCel.Visible = true;
                        lblCel.Text = "Cel: " + vCel;
                    }
                    else{
                        lblCel.Visible = false;
                }
                }
                else
                {
                    lblTel.Visible = false;
                    lblCel.Visible = false;
                }
            }
        }

        private void dgvPesquisa_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPesquisa.Rows.Count != 0)
                ApertaSelecionar();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                    string vCampo = cmbColuna.Text;
                    if (cmbColuna.Text == "Nome")
                        vCampo = "Nome_Cli";
                    else if (cmbColuna.Text == "Vencimento")
                        vCampo = "Prazo_Debito";

                    string vFiltro = vCampo;
                    vFiltro = vFiltro + " >= '" + dtp1.Value.ToShortDateString() + "' and " + vCampo + " <= '" + dtp2.Value.ToShortDateString() + "'";
                    dB_ConceptBindingSource2.RemoveFilter();
                    dB_ConceptBindingSource2.Filter = vFiltro;
                    VerificaVencimento();

            }
            catch (Exception)
            {

            }
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            if (dtp2.Visible == false)
            {
                dtp2.Visible = true;
            }
            else
            {
                try
                {
                    string vCampo = cmbColuna.Text;

                    if (cmbColuna.Text == "Nome")
                        vCampo = "Nome_Cli";
                    else if (cmbColuna.Text == "Vencimento")
                        vCampo = "Prazo_Debito";

                    string vFiltro = vCampo;
                    vFiltro = vFiltro + " >= '" + dtp1.Value.ToShortDateString() + "' and " + vCampo + " <= '" + dtp2.Value.ToShortDateString() + "'";
                    dB_ConceptBindingSource2.RemoveFilter();
                    dB_ConceptBindingSource2.Filter = vFiltro;
                    VerificaVencimento();

                }
                catch (Exception)
                {

                }
            }

        }

        private void txtParam2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


    }
}
