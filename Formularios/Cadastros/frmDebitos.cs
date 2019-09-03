using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjConcept.Formularios.Cadastros
{
    public partial class frmDebitos : Form
    {
        public frmDebitos(decimal vValorDeb)
        {
            InitializeComponent();
            ValorDeb = vValorDeb;
            lblPreco.Text = vValorDeb.ToString("R$ ###,##0.00");
        }
        decimal vSomaParc, ValorDeb;
        private string _DataVencRetorno;
        private decimal _Parcela1Ret, _Parcela2Ret, _Parcela3Ret, _Parcela4Ret;

        public string DataVencRetorno
        {
            get { return _DataVencRetorno; }
            set { _DataVencRetorno = value; }
        }

        public decimal Parcela1Retorno
        {
            get { return _Parcela1Ret; }
            set { _Parcela1Ret = value; }
        }
        public decimal Parcela2Retorno
        {
            get { return _Parcela2Ret; }
            set { _Parcela2Ret = value; }
        }
        public decimal Parcela3Retorno
        {
            get { return _Parcela3Ret; }
            set { _Parcela3Ret = value; }
        }
        public decimal Parcela4Retorno
        {
            get { return _Parcela4Ret; }
            set { _Parcela4Ret = value; }
        }

        //frmVendas frmvendas = new frmVendas();
        decimal vTotal, vDividido;
        DateTime vDataPrazo = DateTime.Today;

        private void frmDebitos_Load(object sender, EventArgs e)
        {
            vDataPrazo = vDataPrazo.AddMonths(1);
            vTotal = ValorDeb;
            vDividido  = ValorDeb;
            dtpVencimento.Value = vDataPrazo;
            AtualizaTabela();
            dgvDebito.Rows[1].Visible = false;
            dgvDebito.Rows[2].Visible = false;
            dgvDebito.Rows[3].Visible = false;
        }

        private void spnParcelas_ValueChanged(object sender, EventArgs e)
        {
            if (spnParcelas.Value == 2)
            {
                vDividido = vTotal / 2;
                AtualizaTabela();
                dgvDebito.Rows[1].Visible = true;
                dgvDebito.Rows[2].Visible = false;
                dgvDebito.Rows[3].Visible = false;

            }
            else if (spnParcelas.Value == 3)
            {
                vDividido = vTotal / 3;
                AtualizaTabela();
                dgvDebito.Rows[1].Visible = true;
                dgvDebito.Rows[2].Visible = true;
                dgvDebito.Rows[3].Visible = false;
            }
            else if (spnParcelas.Value == 4)
            {
                vDividido = vTotal / 4;
                AtualizaTabela();
                dgvDebito.Rows[1].Visible = true;
                dgvDebito.Rows[2].Visible = true;
                dgvDebito.Rows[3].Visible = true;
            }
            else
            {
                vDividido = vTotal;
                AtualizaTabela();
                dgvDebito.Rows[1].Visible = false;
                dgvDebito.Rows[2].Visible = false;
                dgvDebito.Rows[3].Visible = false;
            }

        }
         private void AtualizaTabela()
        {
            dgvDebito.Rows.Clear();
            dgvDebito.Rows.Add(vDividido, vDataPrazo.ToShortDateString());
            dgvDebito.Rows.Add(vDividido, vDataPrazo.AddMonths(1).ToShortDateString());
            dgvDebito.Rows.Add(vDividido, vDataPrazo.AddMonths(2).ToShortDateString());
            dgvDebito.Rows.Add(vDividido, vDataPrazo.AddMonths(3).ToShortDateString());

        
        }

         private void dtpVencimento_ValueChanged(object sender, EventArgs e)
         {
             if (dtpVencimento.Value > DateTime.Today.AddDays(15))
             {
                 vDataPrazo = dtpVencimento.Value;
                 AtualizaTabela();
                 spnParcelas_ValueChanged(sender, e);
                 lblInfo.Visible = false;
             }
             else
             {
                 dtpVencimento.Value = DateTime.Today.AddDays(15);
                 lblInfo.Text = "A data mínima deve ser daqui a 15 dias!";
                 lblInfo.Visible = true;
             }
         }

         private void btnSelecionar_Click(object sender, EventArgs e)
         {
             SomarParcelas();
             if (vSomaParc == ValorDeb)
             {
                 _DataVencRetorno = dtpVencimento.Value.ToShortDateString().ToString();

                 _Parcela1Ret = Convert.ToDecimal(dgvDebito.Rows[0].Cells[0].Value);
                 _Parcela2Ret = 0;
                 _Parcela3Ret = 0;
                 _Parcela4Ret = 0;

                 if (dgvDebito.Rows[1].Visible == true)
                 {
                     _Parcela2Ret = Convert.ToDecimal(dgvDebito.Rows[1].Cells[0].Value);
                 }
                 if (dgvDebito.Rows[2].Visible == true)
                 {
                     _Parcela3Ret = Convert.ToDecimal(dgvDebito.Rows[2].Cells[0].Value);
                 }
                 if (dgvDebito.Rows[3].Visible == true)
                 {
                     _Parcela4Ret = Convert.ToDecimal(dgvDebito.Rows[3].Cells[0].Value);
                 }

                 Close();
             }
             else
             {
                 lblInfo.Text = "As parcelas devem ser a soma do total!";
                 lblInfo.Visible = true;
             }
         }

         private void btnCancelar_Click(object sender, EventArgs e)
         {
             _Parcela1Ret = 0;
             Close();
         }
        private void SomarParcelas()
         {
            try
            {
             vSomaParc = Convert.ToDecimal(dgvDebito.Rows[0].Cells[0].Value);
             if (dgvDebito.Rows[1].Visible == true)
             {
                 vSomaParc = vSomaParc + Convert.ToDecimal(dgvDebito.Rows[1].Cells[0].Value);
             }
             if (dgvDebito.Rows[2].Visible == true)
             {
                 vSomaParc = vSomaParc + Convert.ToDecimal(dgvDebito.Rows[2].Cells[0].Value);
             }
             if (dgvDebito.Rows[3].Visible == true)
             {
                 vSomaParc = vSomaParc + Convert.ToDecimal(dgvDebito.Rows[3].Cells[0].Value);
             }
            }catch(Exception e)
            {
                MessageBox.Show("Insira um valor válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
    }
}
