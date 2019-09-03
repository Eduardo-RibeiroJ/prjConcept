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
    public partial class frmAlterarDeb : Form
    {
        decimal Deb1, Deb2, Deb3, Deb4, vTotal;
        int IdDeb, IdCompra;
        string PossuiDeb, NomeCli;
        DateTime DataCompra, PrazoDeb;
        public frmAlterarDeb(int vIdDeb, int vIdCompra, string vPossuiDeb, string vNomeCli, decimal vTotalCompra, DateTime vDataCompra, decimal vDeb1, decimal vDeb2, decimal vDeb3, decimal vDeb4, DateTime vPrazoDeb)
        {
            InitializeComponent();
            vTotal = vDeb1 + vDeb2 + vDeb3 + vDeb4;
            lblPreco.Text = vTotal.ToString("R$ ###,##0.00");
            IdDeb = vIdDeb; IdCompra = vIdCompra;
            Deb1 = vDeb1; Deb2 = vDeb2; Deb3 = vDeb3; Deb4 = vDeb4;
            PossuiDeb = vPossuiDeb; NomeCli = vNomeCli;
            DataCompra = vDataCompra;
            PrazoDeb = vPrazoDeb;
            DataCompra = vDataCompra;
        }

        private void frmAlterarDeb_Load(object sender, EventArgs e)
        {
            AtualizaTabela();
        }

        private void AtualizaTabela()
        {
            dgvDebito.Rows.Clear();
            if(Deb1 > 0)
            {
                dgvDebito.Rows.Add(Deb1, PrazoDeb.ToShortDateString());
            }

            if (Deb2 > 0 && Deb1 > 0)
            {
                dgvDebito.Rows.Add(Deb2, PrazoDeb.AddMonths(1).ToShortDateString());
            }
            else if (Deb2 > 0 && Deb1 == 0)
            {
                dgvDebito.Rows.Add(Deb2, PrazoDeb.ToShortDateString());
            }

            if (Deb3 > 0 && Deb2 > 0 && Deb1 > 0)
            {
                dgvDebito.Rows.Add(Deb3, PrazoDeb.AddMonths(2).ToShortDateString());
            }
            else if (Deb3 > 0 && Deb2 > 0 && Deb1 == 0)
            {
                dgvDebito.Rows.Add(Deb3, PrazoDeb.AddMonths(1).ToShortDateString());
            }
            else if (Deb3 > 0 && Deb2 == 0 && Deb1 == 0)
            {
                dgvDebito.Rows.Add(Deb3, PrazoDeb.ToShortDateString());
            }

            if (Deb4 > 0 && Deb3 > 0 && Deb2 > 0 && Deb1 > 0)
            {
                dgvDebito.Rows.Add(Deb4, PrazoDeb.AddMonths(3).ToShortDateString());
            }
            else if (Deb4 > 0 && Deb3 > 0 && Deb2 > 0 && Deb1 == 0)
            {
                dgvDebito.Rows.Add(Deb4, PrazoDeb.AddMonths(2).ToShortDateString());
            }
            else if (Deb4 > 0 && Deb3 > 0 && Deb2 == 0 && Deb1 == 0)
            {
                dgvDebito.Rows.Add(Deb4, PrazoDeb.AddMonths(1).ToShortDateString());
            }
            else if (Deb4 > 0 && Deb3 == 0 && Deb2 == 0 && Deb1 == 0)
            {
                dgvDebito.Rows.Add(Deb4, PrazoDeb.ToShortDateString());
            }
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            if (dgvDebito.RowCount < 1)
            {
                MessageBox.Show("Não há mais débitos pendentes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if(dgvDebito.RowCount == 1)
            {
                PossuiDeb = "nao";
            }
            else
            {
                PossuiDeb = "sim";
            }
            if(Deb1 > 0)
            {
                Deb1 = 0;
            }
            else if(Deb2 >0)
            {
                Deb2 = 0;
            }
            else if(Deb3 > 0)
            {
                Deb3 = 0;
            }
            else
            {
                Deb4 = 0;
            }
            DebitoTableAdapter taDebito = new DebitoTableAdapter();
            taDebito.Update(IdCompra, PossuiDeb, Deb1, Deb2, Deb3, Deb4, PrazoDeb.AddMonths(1), IdDeb);

            string vValor = dgvDebito.CurrentRow.Cells[0].Value.ToString();
            string vVenc = dgvDebito.CurrentRow.Cells[1].Value.ToString();
            MessageBox.Show("Valor da parcela: R$ " + vValor + "\nVencimento: " + vVenc + "\n\nParcela paga com sucesso!", "Parcela paga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDebito.RowCount < 1)
            {
                return;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
