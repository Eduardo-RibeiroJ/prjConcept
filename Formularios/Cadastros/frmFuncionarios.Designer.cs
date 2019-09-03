namespace PrjConcept.Formularios.Cadastros
{
    partial class frmFuncionarios
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
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSetbindingSource)).BeginInit();
            this.tbcBase.SuspendLayout();
            this.gpbCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSet1)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
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
            this.btnPesquisar.Enabled = false;
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
            this.gpbCampos.Controls.Add(this.txtSenha2);
            this.gpbCampos.Controls.Add(this.label8);
            this.gpbCampos.Controls.Add(this.lblSenha);
            this.gpbCampos.Controls.Add(this.txtSenha1);
            this.gpbCampos.Controls.Add(this.txtLogin);
            this.gpbCampos.Controls.Add(this.label4);
            this.gpbCampos.Controls.Add(this.txtNome);
            this.gpbCampos.Controls.Add(this.label3);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Location = new System.Drawing.Point(0, 424);
            // 
            // txtSenha2
            // 
            this.txtSenha2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha2.Location = new System.Drawing.Point(515, 76);
            this.txtSenha2.MaxLength = 12;
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(102, 27);
            this.txtSenha2.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtSenha2, "Repita a senha");
            this.txtSenha2.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Repita a senha";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(403, 47);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 20);
            this.lblSenha.TabIndex = 17;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha1
            // 
            this.txtSenha1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha1.Location = new System.Drawing.Point(515, 45);
            this.txtSenha1.MaxLength = 12;
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.Size = new System.Drawing.Size(102, 27);
            this.txtSenha1.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtSenha1, "Máximo 12 caracteres");
            this.txtSenha1.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(217, 76);
            this.txtLogin.MaxLength = 12;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(98, 27);
            this.txtLogin.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtLogin, "Máximo 15 caracteres");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(217, 45);
            this.txtNome.MaxLength = 15;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(117, 27);
            this.txtNome.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtNome, "Máximo 15 caracteres");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome";
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(906, 556);
            this.Name = "frmFuncionarios";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
    }
}
