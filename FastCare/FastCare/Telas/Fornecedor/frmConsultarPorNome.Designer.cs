namespace FastCare.Telas.Fornecedor
{
    partial class frmConsultarPorNome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPorNome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.ImgBack = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.id_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_forn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_forn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_forn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insc_estadual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(264, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 21);
            this.label1.TabIndex = 80;
            this.label1.Text = "Consultar Fornecedor Por Nome";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(127, 135);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(225, 29);
            this.txtFornecedor.TabIndex = 1;
            this.txtFornecedor.TextChanged += new System.EventHandler(this.txtFornecedor_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(29, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 84;
            this.label4.Text = "Fornecedor:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(231)))), ((int)(((byte)(167)))));
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.ImgBack);
            this.panel3.Controls.Add(this.Button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 36);
            this.panel3.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label14.Location = new System.Drawing.Point(-1, -1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 30);
            this.label14.TabIndex = 81;
            this.label14.Text = "Fornecedor";
            // 
            // ImgBack
            // 
            this.ImgBack.BackColor = System.Drawing.Color.Transparent;
            this.ImgBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImgBack.Image = ((System.Drawing.Image)(resources.GetObject("ImgBack.Image")));
            this.ImgBack.Location = new System.Drawing.Point(739, -1);
            this.ImgBack.Name = "ImgBack";
            this.ImgBack.Size = new System.Drawing.Size(28, 28);
            this.ImgBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgBack.TabIndex = 79;
            this.ImgBack.TabStop = false;
            this.ImgBack.Click += new System.EventHandler(this.ImgBack_Click);
            this.ImgBack.MouseEnter += new System.EventHandler(this.ImgBack_MouseEnter);
            this.ImgBack.MouseLeave += new System.EventHandler(this.ImgBack_MouseLeave);
            // 
            // Button1
            // 
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Verdana", 12.5F);
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(765, -2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(29, 29);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "X";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            this.Button1.MouseEnter += new System.EventHandler(this.Button1_MouseEnter);
            this.Button1.MouseLeave += new System.EventHandler(this.Button1_MouseLeave);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.dgvFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFornecedor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvFornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fornecedor,
            this.nm_forn,
            this.ds_cnpj,
            this.ds_tel,
            this.ds_cel,
            this.ds_email,
            this.ds_cep,
            this.end_forn,
            this.nu_forn,
            this.uf_estado,
            this.insc_estadual});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFornecedor.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFornecedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvFornecedor.EnableHeadersVisualStyles = false;
            this.dgvFornecedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.dgvFornecedor.Location = new System.Drawing.Point(12, 239);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFornecedor.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.dgvFornecedor.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFornecedor.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.dgvFornecedor.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Turquoise;
            this.dgvFornecedor.Size = new System.Drawing.Size(768, 154);
            this.dgvFornecedor.TabIndex = 108;
            // 
            // id_fornecedor
            // 
            this.id_fornecedor.DataPropertyName = "id_fornecedor";
            this.id_fornecedor.HeaderText = "ID";
            this.id_fornecedor.Name = "id_fornecedor";
            this.id_fornecedor.ReadOnly = true;
            this.id_fornecedor.Width = 50;
            // 
            // nm_forn
            // 
            this.nm_forn.DataPropertyName = "nm_forn";
            this.nm_forn.HeaderText = "Nome:";
            this.nm_forn.Name = "nm_forn";
            this.nm_forn.ReadOnly = true;
            this.nm_forn.Width = 200;
            // 
            // ds_cnpj
            // 
            this.ds_cnpj.DataPropertyName = "ds_cnpj";
            this.ds_cnpj.HeaderText = "CNPJ";
            this.ds_cnpj.Name = "ds_cnpj";
            this.ds_cnpj.ReadOnly = true;
            this.ds_cnpj.Width = 140;
            // 
            // ds_tel
            // 
            this.ds_tel.DataPropertyName = "ds_tel";
            this.ds_tel.HeaderText = "Telefone";
            this.ds_tel.Name = "ds_tel";
            this.ds_tel.ReadOnly = true;
            this.ds_tel.Width = 140;
            // 
            // ds_cel
            // 
            this.ds_cel.DataPropertyName = "ds_cel";
            this.ds_cel.HeaderText = "Celular";
            this.ds_cel.Name = "ds_cel";
            this.ds_cel.ReadOnly = true;
            this.ds_cel.Width = 140;
            // 
            // ds_email
            // 
            this.ds_email.DataPropertyName = "ds_email";
            this.ds_email.HeaderText = "Email";
            this.ds_email.Name = "ds_email";
            this.ds_email.ReadOnly = true;
            // 
            // ds_cep
            // 
            this.ds_cep.DataPropertyName = "ds_cep";
            this.ds_cep.HeaderText = "CEP";
            this.ds_cep.Name = "ds_cep";
            this.ds_cep.ReadOnly = true;
            this.ds_cep.Width = 120;
            // 
            // end_forn
            // 
            this.end_forn.DataPropertyName = "end_forn";
            this.end_forn.HeaderText = "Endereço";
            this.end_forn.Name = "end_forn";
            this.end_forn.ReadOnly = true;
            this.end_forn.Width = 220;
            // 
            // nu_forn
            // 
            this.nu_forn.DataPropertyName = "nu_forn";
            this.nu_forn.HeaderText = "N° estabelecimento:";
            this.nu_forn.Name = "nu_forn";
            this.nu_forn.ReadOnly = true;
            this.nu_forn.Width = 200;
            // 
            // uf_estado
            // 
            this.uf_estado.DataPropertyName = "uf_estado";
            this.uf_estado.HeaderText = "UF";
            this.uf_estado.Name = "uf_estado";
            this.uf_estado.ReadOnly = true;
            this.uf_estado.Width = 50;
            // 
            // insc_estadual
            // 
            this.insc_estadual.DataPropertyName = "insc_estadual";
            this.insc_estadual.HeaderText = "Inscrição Estadual";
            this.insc_estadual.Name = "insc_estadual";
            this.insc_estadual.ReadOnly = true;
            this.insc_estadual.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(468, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultarPorNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(792, 405);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultarPorNome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarPorNome";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ImgBack;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn insc_estadual;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}