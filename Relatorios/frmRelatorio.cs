using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjConcept.Relatorios
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {

            cmbRelatorio.SelectedIndex = 0;
            this.relatorioTableAdapter.Fill(this.dB_ConceptDataSet.Relatorio);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void cmbRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRelatorio.Text == "Vendas")
            {
                /*frmVisualizarRelatorio f = new frmVisualizarRelatorio();
                f.Show();*/

            }
        }
    }
}
