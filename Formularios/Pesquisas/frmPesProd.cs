using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PrjConcept.Dados;
using PrjConcept.Dados.DB_ConceptDataSetTableAdapters;


namespace PrjConcept.Formularios.Sistema
{
    public partial class frmPesProd : PrjConcept.Formularios.Sistema.frmPesquisa
    {
        public frmPesProd()
        {
            InitializeComponent();
        }
        private int _CodRetorno;
        private string _NomeRetorno;
        private decimal _PrecoRetorno;

        public int CodRetorno
        {
            get { return _CodRetorno; }
            set { _CodRetorno = value; }
        }

        public string NomeRetorno
        {
            get { return _NomeRetorno; }
            set { _NomeRetorno = value; }
        }

        public decimal PrecoRetorno
        {
            get { return _PrecoRetorno; }
            set { _PrecoRetorno = value; }
        }

        public override void ApertaSelecionar()
        {
            btnSelecionar.PerformClick();
        }

        private void frmPesProd_Load(object sender, EventArgs e)
        {
            this.produtoTableAdapter1.Fill(this.dB_ConceptDataSet2.Produto);
        }

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
                dB_ConceptBindingSource2.DataSource = ds.Produto;
                dgvPesquisa.DataSource = dB_ConceptBindingSource2;

                //Config Das Colunas do DGV
                dgvPesquisa.Columns[0].HeaderText = "Cod.";
                dgvPesquisa.Columns[0].Width = 55;
                dgvPesquisa.Columns[1].HeaderText = "Forn.";
                dgvPesquisa.Columns[1].Width = 55;
                dgvPesquisa.Columns[2].Visible = false;
                dgvPesquisa.Columns[3].HeaderText = "Produto";
                dgvPesquisa.Columns[3].Width = 350;
                dgvPesquisa.Columns[4].HeaderText = "Quant.";
                dgvPesquisa.Columns[4].Width = 70;
                dgvPesquisa.Columns[5].HeaderText = "Preço";
                dgvPesquisa.Columns[5].Width = 100;
                dgvPesquisa.Columns[5].DefaultCellStyle.Format = "C2";
                dgvPesquisa.Columns[6].HeaderText = "Custo";
                dgvPesquisa.Columns[6].Width = 100;
                dgvPesquisa.Columns[6].DefaultCellStyle.Format = "C2";
                dgvPesquisa.Columns[7].HeaderText = "Descrição";
                dgvPesquisa.Columns[7].Width = 250;

                //Carrega as combos com as colunas

                if (cmbColuna.Items.Count == 0)
                {
                    foreach (DataColumn coluna in ds.Produto.Columns)
                    {
                        cmbColuna.Items.Add(coluna.ColumnName);
                    }
                }

                /*if (cmbColuna.Items.Count == 0)
                {
                    for (int i = 0; i < 17; i++)
                    {
                        cmbColuna.Items.Add(dgvConsulta.Columns[i].HeaderText);

                    }
                }*/
                dtGenerico = ds.Produto;

                cmbColuna.Text = "Nome_Prod";
                cmbBuscar.SelectedItem = "Que começa com";
                txtParam1.Visible = true;

            }
            catch (Exception)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _CodRetorno = 0;
            _NomeRetorno = null;
            _PrecoRetorno = 0;
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvPesquisa.Rows.Count != 0)
            {
                _CodRetorno = (int)dgvPesquisa.CurrentRow.Cells["ID_Prod"].Value;
                _NomeRetorno = dgvPesquisa.CurrentRow.Cells["Nome_Prod"].Value.ToString();
                _PrecoRetorno = (decimal)dgvPesquisa.CurrentRow.Cells["Preco_Prod"].Value;
                Close();
            }
            else
            {
                MessageBox.Show("Não há nenhum produto selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
