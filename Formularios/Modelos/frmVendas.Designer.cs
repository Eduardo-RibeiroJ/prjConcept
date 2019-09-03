namespace PrjConcept
{
    partial class frmVendas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.lblPreco = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnomeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarra = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBarraTit = new System.Windows.Forms.Label();
            this.pctIcone = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnPesProd = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.spnQuant = new System.Windows.Forms.NumericUpDown();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCodVenda = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pnlPag = new System.Windows.Forms.Panel();
            this.txtValorRec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTroco = new System.Windows.Forms.MaskedTextBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemovProd = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dB_ConceptDataSet1 = new PrjConcept.Dados.DB_ConceptDataSet();
            this.compraTableAdapter1 = new PrjConcept.Dados.DB_ConceptDataSetTableAdapters.CompraTableAdapter();
            this.tmrInfo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).BeginInit();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnQuant)).BeginInit();
            this.pnlPag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPreco
            // 
            this.lblPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPreco.Location = new System.Drawing.Point(287, 461);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(360, 81);
            this.lblPreco.TabIndex = 34;
            this.lblPreco.Text = "R$ 0,00";
            this.lblPreco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreco.TextChanged += new System.EventHandler(this.lblPreco_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Troco";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Valor Recebido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(145, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 58);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total:";
            // 
            // cmbPagamento
            // 
            this.cmbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPagamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPagamento.FormattingEnabled = true;
            this.cmbPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito"});
            this.cmbPagamento.Location = new System.Drawing.Point(44, 45);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(200, 28);
            this.cmbPagamento.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Pagamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProdutos.Location = new System.Drawing.Point(35, 193);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(612, 232);
            this.dgvProdutos.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quant.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome Produto";
            // 
            // txtnomeProd
            // 
            this.txtnomeProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeProd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeProd.Location = new System.Drawing.Point(111, 79);
            this.txtnomeProd.Name = "txtnomeProd";
            this.txtnomeProd.ReadOnly = true;
            this.txtnomeProd.Size = new System.Drawing.Size(355, 27);
            this.txtnomeProd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Prod.";
            // 
            // txtidProd
            // 
            this.txtidProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidProd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidProd.Location = new System.Drawing.Point(35, 79);
            this.txtidProd.MaxLength = 7;
            this.txtidProd.Name = "txtidProd";
            this.txtidProd.Size = new System.Drawing.Size(59, 27);
            this.txtidProd.TabIndex = 1;
            this.txtidProd.TextChanged += new System.EventHandler(this.txtidProd_TextChanged);
            this.txtidProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidProd_KeyPress);
            this.txtidProd.Leave += new System.EventHandler(this.txtidProd_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busca por Barra";
            // 
            // txtBarra
            // 
            this.txtBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarra.Location = new System.Drawing.Point(35, 28);
            this.txtBarra.MaxLength = 30;
            this.txtBarra.Name = "txtBarra";
            this.txtBarra.Size = new System.Drawing.Size(173, 27);
            this.txtBarra.TabIndex = 0;
            this.txtBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarra_KeyPress);
            this.txtBarra.Leave += new System.EventHandler(this.txtBarra_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lblBarraTit);
            this.panel1.Controls.Add(this.pctIcone);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 35);
            this.panel1.TabIndex = 4;
            // 
            // lblBarraTit
            // 
            this.lblBarraTit.AutoSize = true;
            this.lblBarraTit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraTit.ForeColor = System.Drawing.Color.White;
            this.lblBarraTit.Location = new System.Drawing.Point(41, 9);
            this.lblBarraTit.Name = "lblBarraTit";
            this.lblBarraTit.Size = new System.Drawing.Size(69, 21);
            this.lblBarraTit.TabIndex = 21;
            this.lblBarraTit.Text = "Vendas";
            this.lblBarraTit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctIcone
            // 
            this.pctIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctIcone.BackgroundImage")));
            this.pctIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctIcone.Location = new System.Drawing.Point(6, 3);
            this.pctIcone.Name = "pctIcone";
            this.pctIcone.Size = new System.Drawing.Size(30, 30);
            this.pctIcone.TabIndex = 9;
            this.pctIcone.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::PrjConcept.Properties.Resources.nfechar1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(937, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(35, 35);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDados.Controls.Add(this.lblCodVenda);
            this.pnlDados.Controls.Add(this.txtPreco);
            this.pnlDados.Controls.Add(this.btnPesProd);
            this.pnlDados.Controls.Add(this.btnAddCliente);
            this.pnlDados.Controls.Add(this.lbl);
            this.pnlDados.Controls.Add(this.spnQuant);
            this.pnlDados.Controls.Add(this.lblNomeCli);
            this.pnlDados.Controls.Add(this.txtNomeCli);
            this.pnlDados.Controls.Add(this.lblIdCli);
            this.pnlDados.Controls.Add(this.txtIdCli);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.txtBarra);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.txtidProd);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.txtnomeProd);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.btnAddProd);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.label11);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDados.ForeColor = System.Drawing.Color.White;
            this.pnlDados.Location = new System.Drawing.Point(0, 35);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(972, 119);
            this.pnlDados.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(618, 80);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(75, 27);
            this.txtPreco.TabIndex = 27;
            this.txtPreco.Text = "0,00";
            // 
            // btnPesProd
            // 
            this.btnPesProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesProd.BackgroundImage")));
            this.btnPesProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.btnPesProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnPesProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesProd.Location = new System.Drawing.Point(472, 78);
            this.btnPesProd.Name = "btnPesProd";
            this.btnPesProd.Size = new System.Drawing.Size(28, 28);
            this.btnPesProd.TabIndex = 26;
            this.btnPesProd.UseVisualStyleBackColor = true;
            this.btnPesProd.Click += new System.EventHandler(this.btnPesProd_Click);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCliente.FlatAppearance.BorderSize = 0;
            this.btnAddCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.btnAddCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCliente.Image")));
            this.btnAddCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCliente.Location = new System.Drawing.Point(850, 27);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddCliente.Size = new System.Drawing.Size(79, 79);
            this.btnAddCliente.TabIndex = 25;
            this.btnAddCliente.Text = "Cliente";
            this.btnAddCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // spnQuant
            // 
            this.spnQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spnQuant.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnQuant.Location = new System.Drawing.Point(523, 79);
            this.spnQuant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnQuant.Name = "spnQuant";
            this.spnQuant.Size = new System.Drawing.Size(54, 27);
            this.spnQuant.TabIndex = 3;
            this.spnQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spnQuant_KeyPress);
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(325, 7);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(100, 20);
            this.lblNomeCli.TabIndex = 20;
            this.lblNomeCli.Text = "Nome Cliente";
            this.lblNomeCli.Visible = false;
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCli.Enabled = false;
            this.txtNomeCli.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(328, 28);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(365, 27);
            this.txtNomeCli.TabIndex = 19;
            this.txtNomeCli.Visible = false;
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCli.Location = new System.Drawing.Point(262, 7);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(48, 20);
            this.lblIdCli.TabIndex = 18;
            this.lblIdCli.Text = "ID Cli.";
            this.lblIdCli.Visible = false;
            // 
            // txtIdCli
            // 
            this.txtIdCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCli.Enabled = false;
            this.txtIdCli.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCli.Location = new System.Drawing.Point(265, 28);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(45, 27);
            this.txtIdCli.TabIndex = 17;
            this.txtIdCli.Visible = false;
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnAddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProd.FlatAppearance.BorderSize = 0;
            this.btnAddProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.btnAddProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProd.Image")));
            this.btnAddProd.Location = new System.Drawing.Point(728, 28);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddProd.Size = new System.Drawing.Size(79, 79);
            this.btnAddProd.TabIndex = 12;
            this.btnAddProd.Text = "Adicionar";
            this.btnAddProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(592, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "R$";
            // 
            // lblCodVenda
            // 
            this.lblCodVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodVenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodVenda.Location = new System.Drawing.Point(858, 4);
            this.lblCodVenda.Name = "lblCodVenda";
            this.lblCodVenda.Size = new System.Drawing.Size(70, 15);
            this.lblCodVenda.TabIndex = 22;
            this.lblCodVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(781, 4);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(71, 15);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Cod. Venda:";
            // 
            // pnlPag
            // 
            this.pnlPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlPag.Controls.Add(this.txtValorRec);
            this.pnlPag.Controls.Add(this.label4);
            this.pnlPag.Controls.Add(this.mskTroco);
            this.pnlPag.Controls.Add(this.btnConcluir);
            this.pnlPag.Controls.Add(this.btnCancelar);
            this.pnlPag.Controls.Add(this.label13);
            this.pnlPag.Controls.Add(this.cmbPagamento);
            this.pnlPag.Controls.Add(this.label9);
            this.pnlPag.Controls.Add(this.label12);
            this.pnlPag.Controls.Add(this.label7);
            this.pnlPag.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPag.ForeColor = System.Drawing.Color.White;
            this.pnlPag.Location = new System.Drawing.Point(684, 154);
            this.pnlPag.Name = "pnlPag";
            this.pnlPag.Size = new System.Drawing.Size(288, 402);
            this.pnlPag.TabIndex = 6;
            // 
            // txtValorRec
            // 
            this.txtValorRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorRec.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRec.Location = new System.Drawing.Point(116, 204);
            this.txtValorRec.MaxLength = 7;
            this.txtValorRec.Name = "txtValorRec";
            this.txtValorRec.Size = new System.Drawing.Size(129, 50);
            this.txtValorRec.TabIndex = 5;
            this.txtValorRec.Text = "0,00";
            this.txtValorRec.TextChanged += new System.EventHandler(this.txtValorRec_TextChanged);
            this.txtValorRec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorRec_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 45);
            this.label4.TabIndex = 35;
            this.label4.Text = "R$";
            // 
            // mskTroco
            // 
            this.mskTroco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.mskTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTroco.Enabled = false;
            this.mskTroco.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mskTroco.Location = new System.Drawing.Point(116, 111);
            this.mskTroco.Name = "mskTroco";
            this.mskTroco.Size = new System.Drawing.Size(94, 43);
            this.mskTroco.TabIndex = 34;
            this.mskTroco.Text = "0,00";
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluir.FlatAppearance.BorderSize = 0;
            this.btnConcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.btnConcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnConcluir.Image")));
            this.btnConcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConcluir.Location = new System.Drawing.Point(44, 278);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConcluir.Size = new System.Drawing.Size(110, 110);
            this.btnConcluir.TabIndex = 30;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(165, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(80, 80);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 37);
            this.label7.TabIndex = 36;
            this.label7.Text = "R$";
            // 
            // btnRemovProd
            // 
            this.btnRemovProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemovProd.FlatAppearance.BorderSize = 0;
            this.btnRemovProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.btnRemovProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnRemovProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovProd.ForeColor = System.Drawing.Color.White;
            this.btnRemovProd.Image = ((System.Drawing.Image)(resources.GetObject("btnRemovProd.Image")));
            this.btnRemovProd.Location = new System.Drawing.Point(36, 432);
            this.btnRemovProd.Name = "btnRemovProd";
            this.btnRemovProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemovProd.Size = new System.Drawing.Size(80, 80);
            this.btnRemovProd.TabIndex = 22;
            this.btnRemovProd.Text = "Remover";
            this.btnRemovProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemovProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemovProd.UseVisualStyleBackColor = true;
            this.btnRemovProd.Click += new System.EventHandler(this.btnRemovProd_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(330, 428);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(317, 23);
            this.lblInfo.TabIndex = 35;
            this.lblInfo.Text = "Produto Adicionado!";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInfo.Visible = false;
            // 
            // dB_ConceptDataSet1
            // 
            this.dB_ConceptDataSet1.DataSetName = "DB_ConceptDataSet";
            this.dB_ConceptDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraTableAdapter1
            // 
            this.compraTableAdapter1.ClearBeforeFill = true;
            // 
            // tmrInfo
            // 
            this.tmrInfo.Interval = 4000;
            this.tmrInfo.Tick += new System.EventHandler(this.tmrInfo_Tick);
            // 
            // frmVendas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(972, 556);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.pnlPag);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRemovProd);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).EndInit();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnQuant)).EndInit();
            this.pnlPag.ResumeLayout(false);
            this.pnlPag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ConceptDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRemovProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnomeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarra;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label lblCodVenda;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.TextBox txtIdCli;
        private System.Windows.Forms.NumericUpDown spnQuant;
        private System.Windows.Forms.Panel pnlPag;
        private System.Windows.Forms.MaskedTextBox mskTroco;
        private System.Windows.Forms.Button btnAddCliente;
        private Dados.DB_ConceptDataSet dB_ConceptDataSet1;
        public System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnPesProd;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtPreco;
        private Dados.DB_ConceptDataSetTableAdapters.CompraTableAdapter compraTableAdapter1;
        private System.Windows.Forms.Timer tmrInfo;
        private System.Windows.Forms.PictureBox pctIcone;
        private System.Windows.Forms.Label lblBarraTit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValorRec;
    }
}