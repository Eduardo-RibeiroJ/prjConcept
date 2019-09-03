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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void TmrSplash_Tick(object sender, EventArgs e)
        {
            Hide();
            frmLogin login = new frmLogin();
            login.Show();
            TmrSplash.Enabled = false;
            this.Hide();
        }
    }
}
