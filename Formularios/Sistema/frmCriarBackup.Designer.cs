namespace PrjConcept.Formularios.Sistema
{
    partial class frmCriarBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarBackup));
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomeTab = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocalCriar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocalRest = new System.Windows.Forms.TextBox();
            this.btnRestBak = new System.Windows.Forms.Button();
            this.btnPesSalva = new System.Windows.Forms.Button();
            this.btnPesRest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackgroundImage = global::PrjConcept.Properties.Resources.nfechar1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(420, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(63, 63);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.lblNomeTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 63);
            this.panel1.TabIndex = 29;
            // 
            // lblNomeTab
            // 
            this.lblNomeTab.AutoSize = true;
            this.lblNomeTab.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTab.ForeColor = System.Drawing.Color.White;
            this.lblNomeTab.Location = new System.Drawing.Point(14, 12);
            this.lblNomeTab.Name = "lblNomeTab";
            this.lblNomeTab.Size = new System.Drawing.Size(135, 39);
            this.lblNomeTab.TabIndex = 3;
            this.lblNomeTab.Text = "Backup";
            // 
            // btnBackup
            // 
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))));
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.Location = new System.Drawing.Point(0, 231);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(483, 50);
            this.btnBackup.TabIndex = 30;
            this.btnBackup.Text = "  Criar";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNomeArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeArquivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeArquivo.ForeColor = System.Drawing.Color.White;
            this.txtNomeArquivo.Location = new System.Drawing.Point(46, 114);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.ReadOnly = true;
            this.txtNomeArquivo.Size = new System.Drawing.Size(358, 29);
            this.txtNomeArquivo.TabIndex = 31;
            this.txtNomeArquivo.Text = "Backup.bak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome do arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Local";
            // 
            // txtLocalCriar
            // 
            this.txtLocalCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtLocalCriar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalCriar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalCriar.ForeColor = System.Drawing.Color.White;
            this.txtLocalCriar.Location = new System.Drawing.Point(46, 184);
            this.txtLocalCriar.Name = "txtLocalCriar";
            this.txtLocalCriar.ReadOnly = true;
            this.txtLocalCriar.Size = new System.Drawing.Size(358, 29);
            this.txtLocalCriar.TabIndex = 33;
            this.txtLocalCriar.Text = "C:\\Backups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Arquivo de restauração";
            // 
            // txtLocalRest
            // 
            this.txtLocalRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtLocalRest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalRest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalRest.ForeColor = System.Drawing.Color.White;
            this.txtLocalRest.Location = new System.Drawing.Point(46, 341);
            this.txtLocalRest.Name = "txtLocalRest";
            this.txtLocalRest.ReadOnly = true;
            this.txtLocalRest.Size = new System.Drawing.Size(358, 29);
            this.txtLocalRest.TabIndex = 35;
            // 
            // btnRestBak
            // 
            this.btnRestBak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestBak.FlatAppearance.BorderSize = 0;
            this.btnRestBak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))));
            this.btnRestBak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnRestBak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestBak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestBak.ForeColor = System.Drawing.Color.White;
            this.btnRestBak.Image = ((System.Drawing.Image)(resources.GetObject("btnRestBak.Image")));
            this.btnRestBak.Location = new System.Drawing.Point(0, 394);
            this.btnRestBak.Name = "btnRestBak";
            this.btnRestBak.Size = new System.Drawing.Size(483, 50);
            this.btnRestBak.TabIndex = 37;
            this.btnRestBak.Text = "  Restaurar";
            this.btnRestBak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestBak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestBak.UseVisualStyleBackColor = false;
            this.btnRestBak.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPesSalva
            // 
            this.btnPesSalva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesSalva.BackgroundImage")));
            this.btnPesSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesSalva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesSalva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesSalva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.btnPesSalva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnPesSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesSalva.Location = new System.Drawing.Point(410, 185);
            this.btnPesSalva.Name = "btnPesSalva";
            this.btnPesSalva.Size = new System.Drawing.Size(28, 28);
            this.btnPesSalva.TabIndex = 38;
            this.btnPesSalva.UseVisualStyleBackColor = true;
            this.btnPesSalva.Click += new System.EventHandler(this.btnPesProd_Click);
            // 
            // btnPesRest
            // 
            this.btnPesRest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesRest.BackgroundImage")));
            this.btnPesRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesRest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.btnPesRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnPesRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesRest.Location = new System.Drawing.Point(410, 341);
            this.btnPesRest.Name = "btnPesRest";
            this.btnPesRest.Size = new System.Drawing.Size(28, 28);
            this.btnPesRest.TabIndex = 39;
            this.btnPesRest.UseVisualStyleBackColor = true;
            this.btnPesRest.Click += new System.EventHandler(this.btnPesRest_Click);
            // 
            // frmCriarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(483, 484);
            this.Controls.Add(this.btnPesRest);
            this.Controls.Add(this.btnPesSalva);
            this.Controls.Add(this.btnRestBak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocalRest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocalCriar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCriarBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCriarBackup";
            this.Load += new System.EventHandler(this.frmCriarBackup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblNomeTab;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocalCriar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocalRest;
        private System.Windows.Forms.Button btnRestBak;
        private System.Windows.Forms.Button btnPesSalva;
        private System.Windows.Forms.Button btnPesRest;
    }
}