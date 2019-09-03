namespace PrjConcept.Formularios.Sistema
{
    partial class frmPesProd
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
            this.produtoTableAdapter1 = new PrjConcept.Dados.DB_ConceptDataSetTableAdapters.ProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // produtoTableAdapter1
            // 
            this.produtoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPesProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(908, 598);
            this.Name = "frmPesProd";
            this.Load += new System.EventHandler(this.frmPesProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Dados.DB_ConceptDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter1;
    }
}
