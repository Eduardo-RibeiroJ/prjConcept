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

namespace PrjConcept.Formularios.Sistema
{
    public partial class frmPesDebito : PrjConcept.Formularios.Sistema.frmPesquisa
    {
        public frmPesDebito()
        {
            InitializeComponent();
            Atualiza_Grid();
        }
        int vIdDeb, vIdCompra;
        DateTime vDataCompra, vPrazoDeb;
        decimal vTotalCompra, vDeb1, vDeb2, vDeb3, vDeb4;
        string vPossuiDeb, vNomeCli;




        private void PesDebito_Load(object sender, EventArgs e)
        {
            this.Text = lblNomeTab.Text = "Débitos";
        }

        public override void Atualiza_Grid()
        {
            try
            {
                DB_ConceptDataSet.DebitoDataTable dtDeb = new DB_ConceptDataSet.DebitoDataTable();
                DebitoTableAdapter taDeb = new DebitoTableAdapter();
                DB_ConceptDataSet ds = new DB_ConceptDataSet();
                dtDeb = taDeb.VerificaDebitos();
                dB_ConceptBindingSource2.DataSource = dtDeb;

                dgvPesquisa.DataSource = dB_ConceptBindingSource2;

                dgvPesquisa.Columns[8].DisplayIndex = 0;
                dgvPesquisa.Columns[7].DisplayIndex = 1;
                dgvPesquisa.Columns[10].DisplayIndex = 8;
                dgvPesquisa.Columns[0].DisplayIndex = 10;
                dgvPesquisa.Columns[1].DisplayIndex = 9;
                dgvPesquisa.Columns[9].DisplayIndex = 7;
                dgvPesquisa.Columns[6].DisplayIndex = 6;
                dgvPesquisa.Columns[0].Width = 0;
                dgvPesquisa.Columns[1].Width = 0;


                dgvPesquisa.Columns[8].HeaderText = "Nome";
                dgvPesquisa.Columns[8].Width = 220;
                dgvPesquisa.Columns[9].HeaderText = "Total Compra";
                dgvPesquisa.Columns[9].Width = 130;
                dgvPesquisa.Columns[9].DefaultCellStyle.Format = "C2";
                dgvPesquisa.Columns[10].HeaderText = "Data Compra";
                dgvPesquisa.Columns[10].Width = 140;
                dgvPesquisa.Columns[2].HeaderText = "Aberto";
                dgvPesquisa.Columns[2].Width = 70;
                dgvPesquisa.Columns[3].HeaderText = "1º Parcela";
                dgvPesquisa.Columns[3].Width = 105;
                dgvPesquisa.Columns[3].DefaultCellStyle.Format = "C2";
                dgvPesquisa.Columns[4].HeaderText = "2º Parcela";
                dgvPesquisa.Columns[4].Width = 105;
                dgvPesquisa.Columns[4].DefaultCellStyle.Format = "C2";
                dgvPesquisa.Columns[5].HeaderText = "3º Parcela";
                dgvPesquisa.Columns[5].Width = 105;
                dgvPesquisa.Columns[5].DefaultCellStyle.Format = "C2";
                dgvPesquisa.Columns[6].HeaderText = "4º Parcela";
                dgvPesquisa.Columns[6].Width = 105;
                dgvPesquisa.Columns[6].DefaultCellStyle.Format = "C2";
                dgvPesquisa.Columns[7].HeaderText = "Vencimento";
                dgvPesquisa.Columns[7].Width = 115;

                //Carrega as combos com as colunas

                VerificaVencimento();

                if (cmbColuna.Items.Count == 0)
                {
                    /*foreach (DataColumn coluna in taDeb.VerificaDebitos().Columns)
                    {
                        cmbColuna.Items.Add(coluna.ColumnName);
                    }*/
                    cmbColuna.Items.Add("Nome_Cli");
                    cmbColuna.Items.Add("Vencimento");
                    cmbColuna.Items.Add("Possui_Debito");
                    cmbColuna.Items.Add("Data_Compra");
                }


                dgvPesquisa.Rows[0].Selected = false;

                dtGenerico = taDeb.VerificaDebitos();

                cmbColuna.Text = "Possui_Debito";
                cmbBuscar.SelectedItem = "Sim";


            }
            catch (Exception)
            {

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PegarDados()
        {
            vIdDeb = Convert.ToInt32(dgvPesquisa.CurrentRow.Cells[0].Value);
            vIdCompra = Convert.ToInt32(dgvPesquisa.CurrentRow.Cells[1].Value);
            vPossuiDeb = dgvPesquisa.CurrentRow.Cells[2].Value.ToString();
            vDeb1 = Convert.ToDecimal(dgvPesquisa.CurrentRow.Cells[3].Value);
            vDeb2 = Convert.ToDecimal(dgvPesquisa.CurrentRow.Cells[4].Value);
            vDeb3 = Convert.ToDecimal(dgvPesquisa.CurrentRow.Cells[5].Value);
            vDeb4 = Convert.ToDecimal(dgvPesquisa.CurrentRow.Cells[6].Value);
            vPrazoDeb = Convert.ToDateTime(dgvPesquisa.CurrentRow.Cells[7].Value);
            vNomeCli = dgvPesquisa.CurrentRow.Cells[8].Value.ToString();
            vTotalCompra = Convert.ToDecimal(dgvPesquisa.CurrentRow.Cells[9].Value);
            vDataCompra = Convert.ToDateTime(dgvPesquisa.CurrentRow.Cells[10].Value);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(dgvPesquisa.CurrentRow.Cells["Possui_Debito"].Value.ToString() == "nao")
            {
                MessageBox.Show("Não há débitos pendentes.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvPesquisa.Rows.Count != 0)
            {
                PegarDados();
                frmAlterarDeb AltDeb = new frmAlterarDeb(vIdDeb, vIdCompra, vPossuiDeb, vNomeCli, vTotalCompra, vDataCompra, vDeb1, vDeb2, vDeb3, vDeb4, vPrazoDeb);
                AltDeb.ShowDialog();
                Atualiza_Grid();
            }
        }
        public override void ApertaSelecionar()
        {
            btnSelecionar.PerformClick();
        }

        public override void VerificaVencimento()
        {
            int QuantLinhas = dgvPesquisa.Rows.Count;
            for (int i = 0; i < QuantLinhas; i++)
            {
                if (Convert.ToDateTime(dgvPesquisa.Rows[i].Cells[7].Value) < DateTime.Now)
                {
                    dgvPesquisa.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
                }
                if(dgvPesquisa.Rows[i].Cells[2].Value.ToString() == "nao")
                {
                    dgvPesquisa.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
    }
}
