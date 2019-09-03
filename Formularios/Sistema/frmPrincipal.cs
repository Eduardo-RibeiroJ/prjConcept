using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjConcept.Formularios.Cadastros;
using PrjConcept.Formularios.Sistema;
using System.Diagnostics;
using PrjConcept.Relatorios;
namespace PrjConcept
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnClientes_Click(object sender, EventArgs e)
        {
            bool aberto = false;
            foreach (Form frm in this.MdiChildren)
            {

                if (frm is frmClientes)
                {
                    frm.BringToFront();
                    aberto = true;
                }
            }
            if (!aberto)
            {
                pctLogo.Visible = false;
                frmClientes clientes = new frmClientes();
                clientes.MdiParent = this;
                clientes.Show();
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            bool aberto = false;
            foreach (Form frm in this.MdiChildren)
            {

                if (frm is frmVendas)
                {
                    frm.BringToFront();
                    aberto = true;
                }
            }
            if (!aberto)
            {
                pctLogo.Visible = false;
                int IdFunc = Convert.ToInt32(lblIdFunc.Text);
                frmVendas vendas = new frmVendas(IdFunc);
                vendas.MdiParent = this;
                vendas.Show();
            }
        }

        private void btnForn_Click(object sender, EventArgs e)
        {
            bool aberto = false;
            foreach (Form frm in this.MdiChildren)
            {

                if (frm is frmFornecedores)
                {
                    frm.BringToFront();
                    aberto = true;
                }
            }
            if (!aberto)
            {
                pctLogo.Visible = false;
                frmFornecedores forns = new frmFornecedores();
                forns.MdiParent = this;
                forns.Show();
            }
        }

        private void btnDebitos_Click(object sender, EventArgs e)
        {
            bool aberto = false;
            foreach (Form frm in this.MdiChildren)
            {

                if (frm is frmPesDebito)
                {
                    frm.BringToFront();
                    aberto = true;
                }
            }
            if (!aberto)
            {
                pctLogo.Visible = false;
                frmPesDebito debs = new frmPesDebito();
                debs.MdiParent = this;
                debs.Show();
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            bool aberto = false;
            foreach (Form frm in this.MdiChildren)
            {

                if (frm is frmProdutos)
                {
                    frm.BringToFront();
                    aberto = true;
                }
            }
            if (!aberto)
            {
                pctLogo.Visible = false;
                frmProdutos prods = new frmProdutos();
                prods.MdiParent = this;
                prods.Show();
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            bool aberto = false;
            foreach (Form frm in this.MdiChildren)
            {

                if (frm is frmConfig)
                {
                    frm.BringToFront();
                    aberto = true;
                }
            }
            if (!aberto)
            {
                pctLogo.Visible = false;
                frmConfig conf = new frmConfig();
                conf.MdiParent = this;
                conf.Show();
            }
        }

        private void tmrRelogio_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Today.ToShortDateString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool Maximizado = false;
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            
            if (Maximizado == false)
            {
                this.WindowState = FormWindowState.Maximized;
                Maximizado = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Maximizado = false;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            bool aberto = false;
            foreach (Form frm in this.MdiChildren)
            {

                if (frm is frmRelatorio)
                {
                    frm.BringToFront();
                    aberto = true;
                }
            }
            if (!aberto)
            {
                pctLogo.Visible = false;
                frmRelatorio relat = new frmRelatorio();
                relat.MdiParent = this;
                relat.Show();
            }
        }
        }
    }
