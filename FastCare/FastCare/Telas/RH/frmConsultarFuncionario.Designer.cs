﻿namespace FastCare.Telas.RH
{
    partial class frmConsultarFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarFuncionario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboOrdem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_contratacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bl_vt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_vt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bl_va = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_va = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(262, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Consultar Funcionário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvFuncionario);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 319);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // dgvFuncionario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.dgvFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.dgvFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_funcionario,
            this.nm_funcionario,
            this.dt_nasc,
            this.ds_rg,
            this.ds_cpf,
            this.end_funcionario,
            this.nu_funcionario,
            this.ds_cep,
            this.ds_tel,
            this.ds_cel,
            this.ds_email,
            this.nm_cargo,
            this.qt_salario,
            this.ds_setor,
            this.dt_contratacao,
            this.ds_genero,
            this.uf_estado,
            this.est_civil,
            this.bl_vt,
            this.vl_vt,
            this.bl_va,
            this.vl_va});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionario.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFuncionario.EnableHeadersVisualStyles = false;
            this.dgvFuncionario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.dgvFuncionario.Location = new System.Drawing.Point(6, 28);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFuncionario.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.dgvFuncionario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFuncionario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.dgvFuncionario.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.dgvFuncionario.Size = new System.Drawing.Size(674, 285);
            this.dgvFuncionario.TabIndex = 0;
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboOrdem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.groupBox1.Location = new System.Drawing.Point(8, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 82);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem";
            // 
            // cboOrdem
            // 
            this.cboOrdem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrdem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrdem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboOrdem.FormattingEnabled = true;
            this.cboOrdem.Items.AddRange(new object[] {
            "ID Funcionario",
            "Funcionario",
            "Salario",
            "Dt. Contratação",
            "Convenio",
            "Vale Refeição",
            "Vale Transporte",
            "Vale Alimentação",
            "UF",
            "Cargo",
            "Setor",
            "Estado Civil",
            "Nascimento",
            "Genero"});
            this.cboOrdem.Location = new System.Drawing.Point(264, 34);
            this.cboOrdem.Name = "cboOrdem";
            this.cboOrdem.Size = new System.Drawing.Size(216, 29);
            this.cboOrdem.TabIndex = 64;
            this.cboOrdem.SelectedIndexChanged += new System.EventHandler(this.cboOrdem_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ordenar por:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(231)))), ((int)(((byte)(167)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.Button1);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 36);
            this.panel3.TabIndex = 98;
            // 
            // Button1
            // 
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Verdana", 12.5F);
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(676, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(29, 29);
            this.Button1.TabIndex = 82;
            this.Button1.Text = "X";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            this.Button1.MouseEnter += new System.EventHandler(this.Button1_MouseEnter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label20.Location = new System.Drawing.Point(7, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 30);
            this.label20.TabIndex = 78;
            this.label20.Text = "RH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(649, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // id_funcionario
            // 
            this.id_funcionario.DataPropertyName = "id_funcionario";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.id_funcionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.id_funcionario.HeaderText = "ID";
            this.id_funcionario.Name = "id_funcionario";
            this.id_funcionario.ReadOnly = true;
            // 
            // nm_funcionario
            // 
            this.nm_funcionario.DataPropertyName = "nm_funcionario";
            this.nm_funcionario.HeaderText = "Nome";
            this.nm_funcionario.Name = "nm_funcionario";
            this.nm_funcionario.ReadOnly = true;
            // 
            // dt_nasc
            // 
            this.dt_nasc.DataPropertyName = "dt_nasc";
            this.dt_nasc.HeaderText = "Data_de_Nascimento";
            this.dt_nasc.Name = "dt_nasc";
            this.dt_nasc.ReadOnly = true;
            // 
            // ds_rg
            // 
            this.ds_rg.DataPropertyName = "ds_rg";
            this.ds_rg.HeaderText = "RG";
            this.ds_rg.Name = "ds_rg";
            this.ds_rg.ReadOnly = true;
            // 
            // ds_cpf
            // 
            this.ds_cpf.DataPropertyName = "ds_cpf";
            this.ds_cpf.HeaderText = "CPF";
            this.ds_cpf.Name = "ds_cpf";
            this.ds_cpf.ReadOnly = true;
            // 
            // end_funcionario
            // 
            this.end_funcionario.DataPropertyName = "end_funcionario";
            this.end_funcionario.HeaderText = "Endereço";
            this.end_funcionario.Name = "end_funcionario";
            this.end_funcionario.ReadOnly = true;
            // 
            // nu_funcionario
            // 
            this.nu_funcionario.DataPropertyName = "nu_funcionario";
            this.nu_funcionario.HeaderText = "Número_Residência";
            this.nu_funcionario.Name = "nu_funcionario";
            this.nu_funcionario.ReadOnly = true;
            // 
            // ds_cep
            // 
            this.ds_cep.DataPropertyName = "ds_cep";
            this.ds_cep.HeaderText = "CEP";
            this.ds_cep.Name = "ds_cep";
            this.ds_cep.ReadOnly = true;
            // 
            // ds_tel
            // 
            this.ds_tel.DataPropertyName = "ds_tel";
            this.ds_tel.HeaderText = "Telefone";
            this.ds_tel.Name = "ds_tel";
            this.ds_tel.ReadOnly = true;
            // 
            // ds_cel
            // 
            this.ds_cel.DataPropertyName = "ds_cel";
            this.ds_cel.HeaderText = "Celular";
            this.ds_cel.Name = "ds_cel";
            this.ds_cel.ReadOnly = true;
            // 
            // ds_email
            // 
            this.ds_email.DataPropertyName = "ds_email";
            this.ds_email.HeaderText = "Email";
            this.ds_email.Name = "ds_email";
            this.ds_email.ReadOnly = true;
            // 
            // nm_cargo
            // 
            this.nm_cargo.DataPropertyName = "nm_cargo";
            this.nm_cargo.HeaderText = "Cargo";
            this.nm_cargo.Name = "nm_cargo";
            this.nm_cargo.ReadOnly = true;
            // 
            // qt_salario
            // 
            this.qt_salario.DataPropertyName = "qt_salario";
            this.qt_salario.HeaderText = "Salário";
            this.qt_salario.Name = "qt_salario";
            this.qt_salario.ReadOnly = true;
            // 
            // ds_setor
            // 
            this.ds_setor.DataPropertyName = "ds_setor";
            this.ds_setor.HeaderText = "Setor";
            this.ds_setor.Name = "ds_setor";
            this.ds_setor.ReadOnly = true;
            // 
            // dt_contratacao
            // 
            this.dt_contratacao.DataPropertyName = "dt_contratacao";
            this.dt_contratacao.HeaderText = "Data_de_Contratação";
            this.dt_contratacao.Name = "dt_contratacao";
            this.dt_contratacao.ReadOnly = true;
            // 
            // ds_genero
            // 
            this.ds_genero.DataPropertyName = "ds_genero";
            this.ds_genero.HeaderText = "Gênero";
            this.ds_genero.Name = "ds_genero";
            this.ds_genero.ReadOnly = true;
            // 
            // uf_estado
            // 
            this.uf_estado.DataPropertyName = "uf_estado";
            this.uf_estado.HeaderText = "UF";
            this.uf_estado.Name = "uf_estado";
            this.uf_estado.ReadOnly = true;
            // 
            // est_civil
            // 
            this.est_civil.DataPropertyName = "est_civil";
            this.est_civil.HeaderText = "Estado_Civil";
            this.est_civil.Name = "est_civil";
            this.est_civil.ReadOnly = true;
            // 
            // bl_vt
            // 
            this.bl_vt.DataPropertyName = "bl_vt";
            this.bl_vt.HeaderText = "VT";
            this.bl_vt.Name = "bl_vt";
            this.bl_vt.ReadOnly = true;
            // 
            // vl_vt
            // 
            this.vl_vt.DataPropertyName = "vl_vt";
            this.vl_vt.HeaderText = "Valor_VT";
            this.vl_vt.Name = "vl_vt";
            this.vl_vt.ReadOnly = true;
            // 
            // bl_va
            // 
            this.bl_va.DataPropertyName = "bl_va";
            this.bl_va.HeaderText = "VA";
            this.bl_va.Name = "bl_va";
            this.bl_va.ReadOnly = true;
            // 
            // vl_va
            // 
            this.vl_va.DataPropertyName = "vl_va";
            this.vl_va.HeaderText = "Valor_VA";
            this.vl_va.Name = "vl_va";
            this.vl_va.ReadOnly = true;
            // 
            // frmConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(705, 482);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarFuncionario";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboOrdem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_contratacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn est_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn bl_vt;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_vt;
        private System.Windows.Forms.DataGridViewTextBoxColumn bl_va;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_va;
    }
}