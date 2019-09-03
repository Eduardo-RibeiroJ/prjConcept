﻿using System;
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
    public partial class frmPesCli : PrjConcept.Formularios.Sistema.frmPesquisa
    {
        public frmPesCli()
        {
            InitializeComponent();
        }
        private int _CodRetorno;
        private string _NomeRetorno;

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


        public override void ApertaSelecionar()
        {
            btnSelecionar.PerformClick();
        }
        private void frmPesCli_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter1.Fill(this.dB_ConceptDataSet2.Cliente);
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
                dB_ConceptBindingSource2.DataSource = ds.Cliente;
                dgvPesquisa.DataSource = dB_ConceptBindingSource2;

                //Config Das Colunas do DGV
                dgvPesquisa.Columns[0].HeaderText = "Cod.";
                dgvPesquisa.Columns[0].Width = 55;
                dgvPesquisa.Columns[1].HeaderText = "Nome";
                dgvPesquisa.Columns[1].Width = 290;
                dgvPesquisa.Columns[2].HeaderText = "Endereço";
                dgvPesquisa.Columns[2].Width = 170;
                dgvPesquisa.Columns[3].HeaderText = "N°";
                dgvPesquisa.Columns[3].Width = 50;
                dgvPesquisa.Columns[4].HeaderText = "Bairro";
                dgvPesquisa.Columns[4].Width = 150;
                dgvPesquisa.Columns[5].HeaderText = "CEP";
                dgvPesquisa.Columns[5].Width = 90;
                dgvPesquisa.Columns[6].HeaderText = "Complemento";
                dgvPesquisa.Columns[6].Width = 150;
                dgvPesquisa.Columns[7].HeaderText = "Cidade";
                dgvPesquisa.Columns[7].Width = 100;
                dgvPesquisa.Columns[8].HeaderText = "UF";
                dgvPesquisa.Columns[8].Width = 45;
                dgvPesquisa.Columns[9].HeaderText = "Tel";
                dgvPesquisa.Columns[9].Width = 140;
                dgvPesquisa.Columns[10].HeaderText = "Cel";
                dgvPesquisa.Columns[10].Width = 140;
                dgvPesquisa.Columns[11].HeaderText = "E-mail";
                dgvPesquisa.Columns[11].Width = 150;
                dgvPesquisa.Columns[12].HeaderText = "RG";
                dgvPesquisa.Columns[12].Width = 110;
                dgvPesquisa.Columns[13].HeaderText = "CPF";
                dgvPesquisa.Columns[13].Width = 130;
                dgvPesquisa.Columns[14].HeaderText = "Data Nasc.";
                dgvPesquisa.Columns[14].Width = 100;
                dgvPesquisa.Columns[15].HeaderText = "Sexo";
                dgvPesquisa.Columns[15].Width = 60;
                dgvPesquisa.Columns[16].HeaderText = "Obs";
                dgvPesquisa.Columns[16].Width = 200;

                //Carrega as combos com as colunas

                if (cmbColuna.Items.Count == 0)
                {
                    foreach (DataColumn coluna in ds.Cliente.Columns)
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
                dtGenerico = ds.Cliente;

                cmbColuna.Text = "Nome_Cli";
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
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvPesquisa.Rows.Count != 0)
            {
                _CodRetorno = (int)dgvPesquisa.CurrentRow.Cells["ID_Cli"].Value;
                _NomeRetorno = dgvPesquisa.CurrentRow.Cells["Nome_Cli"].Value.ToString();
                Close();
            }
            else
            {
                MessageBox.Show("Não há nenhum cliente selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            _CodRetorno = 0;
            _NomeRetorno = null;
            Close();
        }

    }
}
