namespace FastCare.Telas.Cartao_Ponto
{
    partial class frmBaterPonto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaterPonto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvPonto = new System.Windows.Forms.DataGridView();
            this.id_car_ponto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hr_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hr_almoco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hr_volta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hr_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hr_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hr_saidaextra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ImgBack = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonto)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBack)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(147, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Funcionário";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(272, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(238, 29);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.dgvPonto);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pontos";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(390, 42);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(111, 21);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data de Ponto:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // dgvPonto
            // 
            this.dgvPonto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.dgvPonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPonto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPonto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_car_ponto,
            this.id_funcionario,
            this.dt_dia,
            this.hr_entrada,
            this.hr_almoco,
            this.hr_volta,
            this.hr_saida,
            this.hr_extra,
            this.hr_saidaextra,
            this.qt_extra});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPonto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPonto.EnableHeadersVisualStyles = false;
            this.dgvPonto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.dgvPonto.Location = new System.Drawing.Point(2, 108);
            this.dgvPonto.Name = "dgvPonto";
            this.dgvPonto.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPonto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPonto.RowHeadersVisible = false;
            this.dgvPonto.Size = new System.Drawing.Size(634, 290);
            this.dgvPonto.TabIndex = 2;
            // 
            // id_car_ponto
            // 
            this.id_car_ponto.DataPropertyName = "id_car_ponto";
            this.id_car_ponto.HeaderText = "ID";
            this.id_car_ponto.Name = "id_car_ponto";
            this.id_car_ponto.ReadOnly = true;
            // 
            // id_funcionario
            // 
            this.id_funcionario.DataPropertyName = "id_funcionario";
            this.id_funcionario.HeaderText = "Funcionario";
            this.id_funcionario.Name = "id_funcionario";
            this.id_funcionario.ReadOnly = true;
            // 
            // dt_dia
            // 
            this.dt_dia.DataPropertyName = "dt_dia";
            this.dt_dia.HeaderText = "Data";
            this.dt_dia.Name = "dt_dia";
            this.dt_dia.ReadOnly = true;
            // 
            // hr_entrada
            // 
            this.hr_entrada.DataPropertyName = "hr_entrada";
            this.hr_entrada.HeaderText = "Hora Entrada";
            this.hr_entrada.Name = "hr_entrada";
            this.hr_entrada.ReadOnly = true;
            // 
            // hr_almoco
            // 
            this.hr_almoco.DataPropertyName = "hr_almoco";
            this.hr_almoco.HeaderText = "Hora Almoço";
            this.hr_almoco.Name = "hr_almoco";
            this.hr_almoco.ReadOnly = true;
            // 
            // hr_volta
            // 
            this.hr_volta.DataPropertyName = "hr_volta";
            this.hr_volta.HeaderText = "Término Almoço";
            this.hr_volta.Name = "hr_volta";
            this.hr_volta.ReadOnly = true;
            // 
            // hr_saida
            // 
            this.hr_saida.DataPropertyName = "hr_saida";
            this.hr_saida.HeaderText = "Hora Saída";
            this.hr_saida.Name = "hr_saida";
            this.hr_saida.ReadOnly = true;
            // 
            // hr_extra
            // 
            this.hr_extra.DataPropertyName = "hr_extra";
            this.hr_extra.HeaderText = "Hora Extra";
            this.hr_extra.Name = "hr_extra";
            this.hr_extra.ReadOnly = true;
            // 
            // hr_saidaextra
            // 
            this.hr_saidaextra.DataPropertyName = "hr_saidaextra";
            this.hr_saidaextra.HeaderText = "Saída Extra";
            this.hr_saidaextra.Name = "hr_saidaextra";
            this.hr_saidaextra.ReadOnly = true;
            // 
            // qt_extra
            // 
            this.qt_extra.DataPropertyName = "qt_extra";
            this.qt_extra.HeaderText = "Quantidade Extra";
            this.qt_extra.Name = "qt_extra";
            this.qt_extra.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(231)))), ((int)(((byte)(167)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ImgBack);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 36);
            this.panel3.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Cartão de Ponto";
            // 
            // ImgBack
            // 
            this.ImgBack.BackColor = System.Drawing.Color.Transparent;
            this.ImgBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImgBack.Image = ((System.Drawing.Image)(resources.GetObject("ImgBack.Image")));
            this.ImgBack.Location = new System.Drawing.Point(624, 3);
            this.ImgBack.Name = "ImgBack";
            this.ImgBack.Size = new System.Drawing.Size(28, 29);
            this.ImgBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgBack.TabIndex = 79;
            this.ImgBack.TabStop = false;
            this.ImgBack.Click += new System.EventHandler(this.ImgBack_Click);
            this.ImgBack.MouseEnter += new System.EventHandler(this.ImgBack_MouseEnter);
            this.ImgBack.MouseLeave += new System.EventHandler(this.ImgBack_MouseLeave);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12.5F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(651, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.groupBox2.Location = new System.Drawing.Point(21, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 64);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionário";
            // 
            // frmBaterPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(683, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBaterPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaterPonto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBack)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvPonto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ImgBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_car_ponto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hr_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn hr_almoco;
        private System.Windows.Forms.DataGridViewTextBoxColumn hr_volta;
        private System.Windows.Forms.DataGridViewTextBoxColumn hr_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hr_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn hr_saidaextra;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_extra;
    }
}