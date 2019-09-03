namespace PrjConcept.Formularios.Sistema
{
    partial class frmPesDebito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesDebito));
            this.debitoTableAdapter1 = new PrjConcept.Dados.DB_ConceptDataSetTableAdapters.DebitoTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptBindingSource2)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParam2
            // 
            this.txtParam2.Location = new System.Drawing.Point(781, 106);
            this.toolTip1.SetToolTip(this.txtParam2, "Insira um parâmetro para pesquisar");
            // 
            // txtParam1
            // 
            this.txtParam1.Location = new System.Drawing.Point(517, 106);
            this.toolTip1.SetToolTip(this.txtParam1, "Insira um parâmetro para pesquisar");
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Location = new System.Drawing.Point(240, 106);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(448, 360);
            this.lblInfo.Size = new System.Drawing.Size(420, 39);
            // 
            // cmbColuna
            // 
            this.cmbColuna.Location = new System.Drawing.Point(32, 106);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 81);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(236, 81);
            // 
            // lblNomeTab
            // 
            this.lblNomeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.lblNomeTab.Location = new System.Drawing.Point(44, 67);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.FlatAppearance.BorderSize = 0;
            this.btnSelecionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnSelecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnSelecionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionar.Image")));
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelecionar.Location = new System.Drawing.Point(643, 402);
            this.btnSelecionar.Size = new System.Drawing.Size(100, 85);
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(770, 402);
            this.btnCancelar.Size = new System.Drawing.Size(100, 85);
            this.btnCancelar.Text = "Fechar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSair.Location = new System.Drawing.Point(871, 0);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Size = new System.Drawing.Size(906, 155);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.panel1.Size = new System.Drawing.Size(906, 35);
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(709, 106);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(517, 106);
            // 
            // debitoTableAdapter1
            // 
            this.debitoTableAdapter1.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 93);
            this.panel2.TabIndex = 18;
            // 
            // frmPesDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(906, 556);
            this.Controls.Add(this.panel2);
            this.Name = "frmPesDebito";
            this.Load += new System.EventHandler(this.PesDebito_Load);
            this.Controls.SetChildIndex(this.lblTel, 0);
            this.Controls.SetChildIndex(this.lblCel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.pnlPesquisa, 0);
            this.Controls.SetChildIndex(this.lblNomeTab, 0);
            this.Controls.SetChildIndex(this.btnSelecionar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptBindingSource2)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Dados.DB_ConceptDataSetTableAdapters.DebitoTableAdapter debitoTableAdapter1;
        private System.Windows.Forms.Panel panel2;

    }
}
