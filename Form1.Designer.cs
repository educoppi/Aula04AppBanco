namespace Aula04AppBanco
{
    partial class Form1
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
            this.lblBank = new System.Windows.Forms.Label();
            this.lblSeuSaldo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.panelOperacoes = new System.Windows.Forms.Panel();
            this.lblOperacoes = new System.Windows.Forms.Label();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.panelDeposito = new System.Windows.Forms.Panel();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblInformeValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelOperacoes.SuspendLayout();
            this.panelDeposito.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(64, 45);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(139, 31);
            this.lblBank.TabIndex = 0;
            this.lblBank.Text = "Edu Bank";
            // 
            // lblSeuSaldo
            // 
            this.lblSeuSaldo.AutoSize = true;
            this.lblSeuSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeuSaldo.Location = new System.Drawing.Point(67, 95);
            this.lblSeuSaldo.Name = "lblSeuSaldo";
            this.lblSeuSaldo.Size = new System.Drawing.Size(106, 17);
            this.lblSeuSaldo.TabIndex = 1;
            this.lblSeuSaldo.Text = "Seu saldo atual";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(65, 122);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(61, 25);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "R$ 0";
            // 
            // panelOperacoes
            // 
            this.panelOperacoes.Controls.Add(this.panelDeposito);
            this.panelOperacoes.Controls.Add(this.btnSacar);
            this.panelOperacoes.Controls.Add(this.btnDepositar);
            this.panelOperacoes.Controls.Add(this.lblOperacoes);
            this.panelOperacoes.Location = new System.Drawing.Point(70, 164);
            this.panelOperacoes.Name = "panelOperacoes";
            this.panelOperacoes.Size = new System.Drawing.Size(325, 225);
            this.panelOperacoes.TabIndex = 3;
            // 
            // lblOperacoes
            // 
            this.lblOperacoes.AutoSize = true;
            this.lblOperacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacoes.Location = new System.Drawing.Point(15, 0);
            this.lblOperacoes.Name = "lblOperacoes";
            this.lblOperacoes.Size = new System.Drawing.Size(179, 20);
            this.lblOperacoes.TabIndex = 4;
            this.lblOperacoes.Text = "Operações disponíveis";
            // 
            // btnExtrato
            // 
            this.btnExtrato.Location = new System.Drawing.Point(308, 95);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(87, 29);
            this.btnExtrato.TabIndex = 4;
            this.btnExtrato.Text = "Ver extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDepositar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDepositar.Location = new System.Drawing.Point(42, 50);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(87, 29);
            this.btnDepositar.TabIndex = 5;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.White;
            this.btnSacar.Location = new System.Drawing.Point(193, 50);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(87, 29);
            this.btnSacar.TabIndex = 6;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // panelDeposito
            // 
            this.panelDeposito.Controls.Add(this.btnSalvar);
            this.panelDeposito.Controls.Add(this.txtValor);
            this.panelDeposito.Controls.Add(this.lblInformeValor);
            this.panelDeposito.Controls.Add(this.lblDeposito);
            this.panelDeposito.Location = new System.Drawing.Point(42, 99);
            this.panelDeposito.Name = "panelDeposito";
            this.panelDeposito.Size = new System.Drawing.Size(238, 112);
            this.panelDeposito.TabIndex = 7;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(82, 10);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(70, 13);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "DEPÓSITO";
            // 
            // lblInformeValor
            // 
            this.lblInformeValor.AutoSize = true;
            this.lblInformeValor.Location = new System.Drawing.Point(26, 33);
            this.lblInformeValor.Name = "lblInformeValor";
            this.lblInformeValor.Size = new System.Drawing.Size(77, 13);
            this.lblInformeValor.TabIndex = 1;
            this.lblInformeValor.Text = "Informe o valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(29, 49);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(180, 20);
            this.txtValor.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(29, 75);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(177, 31);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 437);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.panelOperacoes);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSeuSaldo);
            this.Controls.Add(this.lblBank);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOperacoes.ResumeLayout(false);
            this.panelOperacoes.PerformLayout();
            this.panelDeposito.ResumeLayout(false);
            this.panelDeposito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblSeuSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Panel panelOperacoes;
        private System.Windows.Forms.Panel panelDeposito;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblInformeValor;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label lblOperacoes;
        private System.Windows.Forms.Button btnExtrato;
    }
}

