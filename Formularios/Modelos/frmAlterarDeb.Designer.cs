namespace PrjConcept.Formularios.Sistema
{
    partial class frmAlterarDeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarDeb));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvDebito = new System.Windows.Forms.DataGridView();
            this.clnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomeTab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPreco = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReceber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebito)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.Location = new System.Drawing.Point(340, 382);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 45);
            this.btnVoltar.TabIndex = 52;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // dgvDebito
            // 
            this.dgvDebito.AllowUserToAddRows = false;
            this.dgvDebito.AllowUserToDeleteRows = false;
            this.dgvDebito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDebito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnValor,
            this.clnVencimento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDebito.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDebito.Enabled = false;
            this.dgvDebito.Location = new System.Drawing.Point(33, 62);
            this.dgvDebito.MultiSelect = false;
            this.dgvDebito.Name = "dgvDebito";
            this.dgvDebito.ReadOnly = true;
            this.dgvDebito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDebito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebito.Size = new System.Drawing.Size(272, 123);
            this.dgvDebito.TabIndex = 47;
            // 
            // clnValor
            // 
            this.clnValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Format = "C2";
            this.clnValor.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnValor.Frozen = true;
            this.clnValor.HeaderText = "Valor";
            this.clnValor.Name = "clnValor";
            this.clnValor.ReadOnly = true;
            this.clnValor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnVencimento
            // 
            this.clnVencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnVencimento.Frozen = true;
            this.clnVencimento.HeaderText = "Vencimento";
            this.clnVencimento.Name = "clnVencimento";
            this.clnVencimento.ReadOnly = true;
            this.clnVencimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnVencimento.Width = 130;
            // 
            // lblNomeTab
            // 
            this.lblNomeTab.AutoSize = true;
            this.lblNomeTab.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTab.ForeColor = System.Drawing.Color.White;
            this.lblNomeTab.Location = new System.Drawing.Point(26, 9);
            this.lblNomeTab.Name = "lblNomeTab";
            this.lblNomeTab.Size = new System.Drawing.Size(272, 42);
            this.lblNomeTab.TabIndex = 45;
            this.lblNomeTab.Text = "Acertar Débito";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.lblPreco);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 113);
            this.panel1.TabIndex = 51;
            // 
            // lblPreco
            // 
            this.lblPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPreco.Location = new System.Drawing.Point(168, 14);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(288, 81);
            this.lblPreco.TabIndex = 36;
            this.lblPreco.Text = "0,00";
            this.lblPreco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 58);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total:";
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnReceber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceber.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReceber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnReceber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.btnReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceber.ForeColor = System.Drawing.Color.White;
            this.btnReceber.Image = ((System.Drawing.Image)(resources.GetObject("btnReceber.Image")));
            this.btnReceber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReceber.Location = new System.Drawing.Point(324, 62);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(133, 123);
            this.btnReceber.TabIndex = 55;
            this.btnReceber.Text = "Receber Parcela";
            this.btnReceber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReceber.UseVisualStyleBackColor = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // frmAlterarDeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(494, 446);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvDebito);
            this.Controls.Add(this.lblNomeTab);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlterarDeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarDeb";
            this.Load += new System.EventHandler(this.frmAlterarDeb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvDebito;
        public System.Windows.Forms.Label lblNomeTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnVencimento;
    }
}