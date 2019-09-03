namespace PrjConcept.Formularios.Cadastros
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.spnQuant = new System.Windows.Forms.NumericUpDown();
            this.txtForn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddForn = new System.Windows.Forms.Button();
            this.txtIDForn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSetbindingSource)).BeginInit();
            this.tbcBase.SuspendLayout();
            this.gpbCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSet1)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_ConceptDataSetbindingSource
            // 
            this.dB_ConceptDataSetbindingSource.Filter = "";
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnIncluir.Text = "Alterando";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            // 
            // txtParam2
            // 
            this.toolTip1.SetToolTip(this.txtParam2, "Insira um parâmetro para pesquisar");
            // 
            // txtParam1
            // 
            this.toolTip1.SetToolTip(this.txtParam1, "Insira um parâmetro para pesquisar");
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            // 
            // gpbCampos
            // 
            this.gpbCampos.Controls.Add(this.txtEstoque);
            this.gpbCampos.Controls.Add(this.label10);
            this.gpbCampos.Controls.Add(this.txtIDForn);
            this.gpbCampos.Controls.Add(this.btnAddForn);
            this.gpbCampos.Controls.Add(this.txtForn);
            this.gpbCampos.Controls.Add(this.label9);
            this.gpbCampos.Controls.Add(this.spnQuant);
            this.gpbCampos.Controls.Add(this.txtDesc);
            this.gpbCampos.Controls.Add(this.label6);
            this.gpbCampos.Controls.Add(this.txtCusto);
            this.gpbCampos.Controls.Add(this.label5);
            this.gpbCampos.Controls.Add(this.txtPreco);
            this.gpbCampos.Controls.Add(this.label8);
            this.gpbCampos.Controls.Add(this.label7);
            this.gpbCampos.Controls.Add(this.txtProd);
            this.gpbCampos.Controls.Add(this.label4);
            this.gpbCampos.Controls.Add(this.txtCodBarras);
            this.gpbCampos.Controls.Add(this.label3);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Location = new System.Drawing.Point(0, 424);
            // 
            // txtPreco
            // 
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Location = new System.Drawing.Point(126, 123);
            this.txtPreco.MaxLength = 12;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(92, 27);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Preço        R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Adicionar";
            // 
            // txtProd
            // 
            this.txtProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProd.Location = new System.Drawing.Point(126, 60);
            this.txtProd.MaxLength = 50;
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(240, 27);
            this.txtProd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Produto";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodBarras.Location = new System.Drawing.Point(147, 29);
            this.txtCodBarras.MaxLength = 30;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(219, 27);
            this.txtCodBarras.TabIndex = 0;
            this.txtCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarras_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cod. de Barras";
            // 
            // txtCusto
            // 
            this.txtCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCusto.Location = new System.Drawing.Point(126, 155);
            this.txtCusto.MaxLength = 12;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(92, 27);
            this.txtCusto.TabIndex = 4;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Custo        R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Location = new System.Drawing.Point(520, 30);
            this.txtDesc.MaxLength = 40;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(266, 54);
            this.txtDesc.TabIndex = 5;
            // 
            // spnQuant
            // 
            this.spnQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spnQuant.Location = new System.Drawing.Point(288, 92);
            this.spnQuant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spnQuant.Name = "spnQuant";
            this.spnQuant.Size = new System.Drawing.Size(79, 27);
            this.spnQuant.TabIndex = 2;
            this.toolTip1.SetToolTip(this.spnQuant, "Adicionar quantidade ao estoque");
            // 
            // txtForn
            // 
            this.txtForn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForn.Enabled = false;
            this.txtForn.Location = new System.Drawing.Point(584, 92);
            this.txtForn.Name = "txtForn";
            this.txtForn.Size = new System.Drawing.Size(202, 27);
            this.txtForn.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Fornecedor";
            // 
            // btnAddForn
            // 
            this.btnAddForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.btnAddForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddForn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddForn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnAddForn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnAddForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddForn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddForn.ForeColor = System.Drawing.Color.White;
            this.btnAddForn.Image = ((System.Drawing.Image)(resources.GetObject("btnAddForn.Image")));
            this.btnAddForn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddForn.Location = new System.Drawing.Point(614, 140);
            this.btnAddForn.Name = "btnAddForn";
            this.btnAddForn.Size = new System.Drawing.Size(172, 54);
            this.btnAddForn.TabIndex = 7;
            this.btnAddForn.Text = "Adicionar Fornecedor";
            this.btnAddForn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddForn.UseVisualStyleBackColor = false;
            this.btnAddForn.Click += new System.EventHandler(this.btnAddForn_Click);
            // 
            // txtIDForn
            // 
            this.txtIDForn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDForn.Enabled = false;
            this.txtIDForn.Location = new System.Drawing.Point(520, 92);
            this.txtIDForn.Name = "txtIDForn";
            this.txtIDForn.Size = new System.Drawing.Size(58, 27);
            this.txtIDForn.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Estoque";
            // 
            // txtEstoque
            // 
            this.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoque.Location = new System.Drawing.Point(126, 92);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(64, 27);
            this.txtEstoque.TabIndex = 28;
            this.toolTip1.SetToolTip(this.txtEstoque, "Quantidade atual em estoque");
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(906, 556);
            this.Name = "frmProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSetbindingSource)).EndInit();
            this.tbcBase.ResumeLayout(false);
            this.gpbCampos.ResumeLayout(false);
            this.gpbCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSet1)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnQuant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown spnQuant;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtForn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddForn;
        public System.Windows.Forms.TextBox txtIDForn;
        public System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label10;
    }
}
