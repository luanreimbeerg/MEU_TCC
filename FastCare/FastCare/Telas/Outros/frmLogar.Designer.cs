namespace FastCare.Telas.Outros
{
    partial class frmLogar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblGerente = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.imgGerente = new System.Windows.Forms.PictureBox();
            this.imgFuncionario = new System.Windows.Forms.PictureBox();
            this.imgCliente = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgGerente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(99, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fast Care - Login";
            // 
            // lblGerente
            // 
            this.lblGerente.AutoSize = true;
            this.lblGerente.BackColor = System.Drawing.Color.Transparent;
            this.lblGerente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.lblGerente.Location = new System.Drawing.Point(183, 113);
            this.lblGerente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGerente.Name = "lblGerente";
            this.lblGerente.Size = new System.Drawing.Size(79, 25);
            this.lblGerente.TabIndex = 1;
            this.lblGerente.Text = "Gerente";
            this.lblGerente.Click += new System.EventHandler(this.lblGerente_Click);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.lblFuncionario.Location = new System.Drawing.Point(183, 242);
            this.lblFuncionario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(93, 25);
            this.lblFuncionario.TabIndex = 2;
            this.lblFuncionario.Text = "Prestador";
            this.lblFuncionario.Click += new System.EventHandler(this.lblFuncionario_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.lblCliente.Location = new System.Drawing.Point(183, 368);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(71, 25);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // imgGerente
            // 
            this.imgGerente.Image = global::FastCare.Properties.Resources.manager;
            this.imgGerente.Location = new System.Drawing.Point(91, 86);
            this.imgGerente.Margin = new System.Windows.Forms.Padding(6);
            this.imgGerente.Name = "imgGerente";
            this.imgGerente.Size = new System.Drawing.Size(80, 80);
            this.imgGerente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGerente.TabIndex = 4;
            this.imgGerente.TabStop = false;
            this.imgGerente.Click += new System.EventHandler(this.imgGerente_Click);
            // 
            // imgFuncionario
            // 
            this.imgFuncionario.Image = global::FastCare.Properties.Resources.user_silhouette;
            this.imgFuncionario.Location = new System.Drawing.Point(91, 213);
            this.imgFuncionario.Margin = new System.Windows.Forms.Padding(6);
            this.imgFuncionario.Name = "imgFuncionario";
            this.imgFuncionario.Size = new System.Drawing.Size(80, 80);
            this.imgFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFuncionario.TabIndex = 5;
            this.imgFuncionario.TabStop = false;
            this.imgFuncionario.Click += new System.EventHandler(this.imgFuncionario_Click);
            // 
            // imgCliente
            // 
            this.imgCliente.Image = global::FastCare.Properties.Resources.user_silhouette;
            this.imgCliente.Location = new System.Drawing.Point(91, 341);
            this.imgCliente.Margin = new System.Windows.Forms.Padding(6);
            this.imgCliente.Name = "imgCliente";
            this.imgCliente.Size = new System.Drawing.Size(80, 80);
            this.imgCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCliente.TabIndex = 6;
            this.imgCliente.TabStop = false;
            this.imgCliente.Click += new System.EventHandler(this.imgCliente_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(231)))), ((int)(((byte)(167)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 36);
            this.panel3.TabIndex = 102;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12.5F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(349, 2);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label14.Location = new System.Drawing.Point(1, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 30);
            this.label14.TabIndex = 78;
            this.label14.Text = "Login";
            // 
            // frmLogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.imgCliente);
            this.Controls.Add(this.imgFuncionario);
            this.Controls.Add(this.imgGerente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblGerente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLogar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            ((System.ComponentModel.ISupportInitialize)(this.imgGerente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGerente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.PictureBox imgGerente;
        private System.Windows.Forms.PictureBox imgFuncionario;
        private System.Windows.Forms.PictureBox imgCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
    }
}