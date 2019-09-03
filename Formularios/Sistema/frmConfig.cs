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
using PrjConcept.Formularios.Modelos;
using PrjConcept.Formularios.Sistema;

namespace PrjConcept.Formularios.Sistema
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            frmCriarBackup frmbak = new frmCriarBackup();
            frmbak.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frmPrincipal frmprin = new frmPrincipal();
            if (frmprin.lblIdFunc.Text == "01")
            {
                frmFuncionarios frmFunc = new frmFuncionarios();
                frmFunc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Apenas o Administrador pode manipular o cadastro de funcionários.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSobre frmsSobre = new frmSobre();
            frmsSobre.ShowDialog();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Eduardo\Desktop\Sistema\Manual do usuario.pdf");
        }
    }
}
