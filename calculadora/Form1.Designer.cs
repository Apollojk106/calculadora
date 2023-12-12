namespace calculadora
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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btMultiplicacao = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btSubtracao = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btvirgula = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.btoperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(50, 136);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(64, 60);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(141, 136);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(64, 60);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.Location = new System.Drawing.Point(333, 136);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(64, 60);
            this.btDivisao.TabIndex = 4;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = true;
            this.btDivisao.Click += new System.EventHandler(this.btDivisao_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(236, 136);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(64, 60);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btMultiplicacao
            // 
            this.btMultiplicacao.Location = new System.Drawing.Point(333, 231);
            this.btMultiplicacao.Name = "btMultiplicacao";
            this.btMultiplicacao.Size = new System.Drawing.Size(64, 60);
            this.btMultiplicacao.TabIndex = 8;
            this.btMultiplicacao.Text = "X";
            this.btMultiplicacao.UseVisualStyleBackColor = true;
            this.btMultiplicacao.Click += new System.EventHandler(this.btMultiplicacao_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(236, 231);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(64, 60);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(141, 231);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(64, 60);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(50, 231);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(64, 60);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(50, 42);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(347, 20);
            this.textResultado.TabIndex = 9;
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btSubtracao
            // 
            this.btSubtracao.Location = new System.Drawing.Point(333, 423);
            this.btSubtracao.Name = "btSubtracao";
            this.btSubtracao.Size = new System.Drawing.Size(64, 60);
            this.btSubtracao.TabIndex = 17;
            this.btSubtracao.Text = "-";
            this.btSubtracao.UseVisualStyleBackColor = true;
            this.btSubtracao.Click += new System.EventHandler(this.btSubtracao_Click);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(236, 423);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(64, 60);
            this.btIgual.TabIndex = 16;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(141, 423);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(64, 60);
            this.bt0.TabIndex = 15;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btvirgula
            // 
            this.btvirgula.Location = new System.Drawing.Point(50, 423);
            this.btvirgula.Name = "btvirgula";
            this.btvirgula.Size = new System.Drawing.Size(64, 60);
            this.btvirgula.TabIndex = 14;
            this.btvirgula.Text = ",";
            this.btvirgula.UseVisualStyleBackColor = true;
            this.btvirgula.Click += new System.EventHandler(this.btvirgula_Click);
            // 
            // btSoma
            // 
            this.btSoma.Location = new System.Drawing.Point(333, 328);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(64, 60);
            this.btSoma.TabIndex = 13;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(236, 328);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(64, 60);
            this.bt9.TabIndex = 12;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(141, 328);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(64, 60);
            this.bt8.TabIndex = 11;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(50, 328);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(64, 60);
            this.bt7.TabIndex = 10;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // Apagar
            // 
            this.Apagar.Location = new System.Drawing.Point(236, 90);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(161, 27);
            this.Apagar.TabIndex = 18;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = true;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // btoperacao
            // 
            this.btoperacao.AutoSize = true;
            this.btoperacao.Location = new System.Drawing.Point(56, 45);
            this.btoperacao.Name = "btoperacao";
            this.btoperacao.Size = new System.Drawing.Size(0, 13);
            this.btoperacao.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 513);
            this.Controls.Add(this.btoperacao);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.btSubtracao);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btvirgula);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.btMultiplicacao);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btMultiplicacao;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button btSubtracao;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btvirgula;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Label btoperacao;
    }
}

