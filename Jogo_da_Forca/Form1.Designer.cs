namespace Jogo_da_Forca
{
    partial class Form1
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
            this.lblPalavra = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblLetrasTentadas = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.lblDigiteaLetra = new System.Windows.Forms.Label();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.btnTentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra.Location = new System.Drawing.Point(62, 105);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(306, 46);
            this.lblPalavra.TabIndex = 0;
            this.lblPalavra.Text = "_ _ _ _ _ _ _ _ _";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(66, 9);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(63, 20);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Tema: ";
            this.lblTema.Click += new System.EventHandler(this.lblTema_Click);
            // 
            // lblLetrasTentadas
            // 
            this.lblLetrasTentadas.AutoSize = true;
            this.lblLetrasTentadas.Location = new System.Drawing.Point(66, 173);
            this.lblLetrasTentadas.Name = "lblLetrasTentadas";
            this.lblLetrasTentadas.Size = new System.Drawing.Size(133, 20);
            this.lblLetrasTentadas.TabIndex = 2;
            this.lblLetrasTentadas.Text = "Letras Tentadas: ";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(180, 57);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(118, 26);
            this.txtLetra.TabIndex = 3;
            // 
            // lblDigiteaLetra
            // 
            this.lblDigiteaLetra.AutoSize = true;
            this.lblDigiteaLetra.Location = new System.Drawing.Point(66, 60);
            this.lblDigiteaLetra.Name = "lblDigiteaLetra";
            this.lblDigiteaLetra.Size = new System.Drawing.Size(108, 20);
            this.lblDigiteaLetra.TabIndex = 4;
            this.lblDigiteaLetra.Text = "Digite a Letra:";
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Location = new System.Drawing.Point(70, 222);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(141, 45);
            this.btnNovoJogo.TabIndex = 5;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // btnTentar
            // 
            this.btnTentar.Location = new System.Drawing.Point(227, 222);
            this.btnTentar.Name = "btnTentar";
            this.btnTentar.Size = new System.Drawing.Size(141, 45);
            this.btnTentar.TabIndex = 6;
            this.btnTentar.Text = "Tentar";
            this.btnTentar.UseVisualStyleBackColor = true;
            this.btnTentar.Click += new System.EventHandler(this.btnTentar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 279);
            this.Controls.Add(this.btnTentar);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.lblDigiteaLetra);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.lblLetrasTentadas);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblPalavra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblLetrasTentadas;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label lblDigiteaLetra;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Button btnTentar;
    }
}

