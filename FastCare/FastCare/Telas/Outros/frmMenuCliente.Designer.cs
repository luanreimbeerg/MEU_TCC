namespace FastCare.Telas.Outros
{
    partial class frmMenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCliente));
            this.panel3 = new System.Windows.Forms.Panel();
            this.imgVoltar = new System.Windows.Forms.PictureBox();
            this.imgFechar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHorarioEmSessao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.imgPet = new System.Windows.Forms.PictureBox();
            this.imgClean = new System.Windows.Forms.PictureBox();
            this.imgBaby = new System.Windows.Forms.PictureBox();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBaby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(231)))), ((int)(((byte)(167)))));
            this.panel3.Controls.Add(this.imgVoltar);
            this.panel3.Controls.Add(this.imgFechar);
            this.panel3.Controls.Add(this.label9);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Name = "panel3";
            // 
            // imgVoltar
            // 
            this.imgVoltar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.imgVoltar, "imgVoltar");
            this.imgVoltar.Name = "imgVoltar";
            this.imgVoltar.TabStop = false;
            this.imgVoltar.Click += new System.EventHandler(this.imgVoltar_Click);
            this.imgVoltar.MouseEnter += new System.EventHandler(this.imgVoltar_MouseEnter);
            this.imgVoltar.MouseLeave += new System.EventHandler(this.imgVoltar_MouseLeave);
            // 
            // imgFechar
            // 
            this.imgFechar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.imgFechar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.imgFechar, "imgFechar");
            this.imgFechar.ForeColor = System.Drawing.Color.Black;
            this.imgFechar.Name = "imgFechar";
            this.imgFechar.UseVisualStyleBackColor = true;
            this.imgFechar.Click += new System.EventHandler(this.imgFechar_Click);
            this.imgFechar.MouseEnter += new System.EventHandler(this.imgFechar_MouseEnter);
            this.imgFechar.MouseLeave += new System.EventHandler(this.imgFechar_MouseLeave);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label9.Name = "label9";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label1.Name = "label1";
            // 
            // lblHorarioEmSessao
            // 
            resources.ApplyResources(this.lblHorarioEmSessao, "lblHorarioEmSessao");
            this.lblHorarioEmSessao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.lblHorarioEmSessao.Name = "lblHorarioEmSessao";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label4.Name = "label4";
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.lblNome.Name = "lblNome";
            // 
            // imgPet
            // 
            resources.ApplyResources(this.imgPet, "imgPet");
            this.imgPet.Name = "imgPet";
            this.imgPet.TabStop = false;
            // 
            // imgClean
            // 
            resources.ApplyResources(this.imgClean, "imgClean");
            this.imgClean.Name = "imgClean";
            this.imgClean.TabStop = false;
            this.imgClean.Click += new System.EventHandler(this.imgClean_Click);
            // 
            // imgBaby
            // 
            resources.ApplyResources(this.imgBaby, "imgBaby");
            this.imgBaby.Name = "imgBaby";
            this.imgBaby.TabStop = false;
            this.imgBaby.Click += new System.EventHandler(this.imgBaby_Click);
            // 
            // imgPerfil
            // 
            this.imgPerfil.Image = global::FastCare.Properties.Resources.user_silhouette;
            resources.ApplyResources(this.imgPerfil, "imgPerfil");
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.label6.Name = "label6";
            // 
            // frmMenuCliente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblHorarioEmSessao);
            this.Controls.Add(this.imgPet);
            this.Controls.Add(this.imgClean);
            this.Controls.Add(this.imgBaby);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgPerfil);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuCliente";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBaby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox imgVoltar;
        private System.Windows.Forms.Button imgFechar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgBaby;
        private System.Windows.Forms.PictureBox imgClean;
        private System.Windows.Forms.PictureBox imgPet;
        private System.Windows.Forms.Label lblHorarioEmSessao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}