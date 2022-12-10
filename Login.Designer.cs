namespace Compra_e_venda_de_automóveis_wbmts
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.webm = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lbsenha = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lbuser = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(192, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Login";
            // 
            // webm
            // 
            this.webm.AutoSize = true;
            this.webm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.webm.Location = new System.Drawing.Point(114, 55);
            this.webm.Name = "webm";
            this.webm.Size = new System.Drawing.Size(225, 46);
            this.webm.TabIndex = 12;
            this.webm.Text = "WebMotors";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(161, 291);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(144, 26);
            this.txtsenha.TabIndex = 11;
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.lbsenha.Location = new System.Drawing.Point(68, 294);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(56, 20);
            this.lbsenha.TabIndex = 10;
            this.lbsenha.Text = "Senha";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(161, 210);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(144, 26);
            this.txtusuario.TabIndex = 9;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged_1);
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(68, 213);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(64, 20);
            this.lbuser.TabIndex = 8;
            this.lbuser.Text = "Usuário";
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfirmar.Location = new System.Drawing.Point(181, 379);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(95, 29);
            this.btnconfirmar.TabIndex = 7;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webm);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.btnconfirmar);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label webm;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lbsenha;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Button btnconfirmar;
    }
}

