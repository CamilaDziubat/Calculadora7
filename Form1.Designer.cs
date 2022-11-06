
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.lbOperacao = new System.Windows.Forms.Label();
            this.btnPositivoNegativo = new System.Windows.Forms.Button();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnRaizQuadrada = new System.Windows.Forms.Button();
            this.btnApagarUmPorUm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIgual
            // 
            this.btnIgual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgual.Location = new System.Drawing.Point(211, 338);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(62, 44);
            this.btnIgual.TabIndex = 0;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(78, 338);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(62, 44);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(10, 288);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(62, 44);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(78, 288);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(62, 44);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(10, 238);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(62, 44);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(78, 238);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(62, 44);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn6
            // 
            this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn6.Location = new System.Drawing.Point(146, 238);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(62, 44);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(10, 188);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(62, 44);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(78, 188);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(62, 44);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn9
            // 
            this.btn9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn9.Location = new System.Drawing.Point(146, 188);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(62, 44);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.Location = new System.Drawing.Point(146, 288);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(62, 44);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVirgula.Location = new System.Drawing.Point(146, 338);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(62, 44);
            this.btnVirgula.TabIndex = 12;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoma.Location = new System.Drawing.Point(211, 288);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(62, 44);
            this.btnSoma.TabIndex = 13;
            this.btnSoma.Tag = "+";
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubtracao.Location = new System.Drawing.Point(211, 238);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(62, 44);
            this.btnSubtracao.TabIndex = 14;
            this.btnSubtracao.Tag = "-";
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiplicacao.Location = new System.Drawing.Point(211, 187);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(62, 44);
            this.btnMultiplicacao.TabIndex = 15;
            this.btnMultiplicacao.Tag = "x";
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDivisao.Location = new System.Drawing.Point(214, 137);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(62, 44);
            this.btnDivisao.TabIndex = 16;
            this.btnDivisao.Tag = "÷";
            this.btnDivisao.Text = "÷";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(78, 88);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(62, 44);
            this.btnCE.TabIndex = 18;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(146, 88);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(62, 44);
            this.btnC.TabIndex = 19;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(7, 35);
            this.txtResultado.MaxLength = 12;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(266, 46);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.BackColor = System.Drawing.Color.Transparent;
            this.labelOperacao.Location = new System.Drawing.Point(12, 45);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(0, 15);
            this.labelOperacao.TabIndex = 21;
            // 
            // lbOperacao
            // 
            this.lbOperacao.AutoSize = true;
            this.lbOperacao.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOperacao.Location = new System.Drawing.Point(10, 41);
            this.lbOperacao.Name = "lbOperacao";
            this.lbOperacao.Size = new System.Drawing.Size(0, 31);
            this.lbOperacao.TabIndex = 22;
            // 
            // btnPositivoNegativo
            // 
            this.btnPositivoNegativo.Location = new System.Drawing.Point(10, 338);
            this.btnPositivoNegativo.Name = "btnPositivoNegativo";
            this.btnPositivoNegativo.Size = new System.Drawing.Size(62, 44);
            this.btnPositivoNegativo.TabIndex = 23;
            this.btnPositivoNegativo.Text = "±";
            this.btnPositivoNegativo.UseVisualStyleBackColor = true;
            this.btnPositivoNegativo.Click += new System.EventHandler(this.btnPositivoNegativo_Click);
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.Location = new System.Drawing.Point(78, 138);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(62, 44);
            this.btnQuadrado.TabIndex = 26;
            this.btnQuadrado.Tag = "²";
            this.btnQuadrado.Text = "x²";
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRaizQuadrada
            // 
            this.btnRaizQuadrada.Location = new System.Drawing.Point(146, 138);
            this.btnRaizQuadrada.Name = "btnRaizQuadrada";
            this.btnRaizQuadrada.Size = new System.Drawing.Size(62, 44);
            this.btnRaizQuadrada.TabIndex = 27;
            this.btnRaizQuadrada.Tag = "√";
            this.btnRaizQuadrada.Text = "√";
            this.btnRaizQuadrada.UseVisualStyleBackColor = true;
            this.btnRaizQuadrada.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnApagarUmPorUm
            // 
            this.btnApagarUmPorUm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagarUmPorUm.Location = new System.Drawing.Point(214, 87);
            this.btnApagarUmPorUm.Name = "btnApagarUmPorUm";
            this.btnApagarUmPorUm.Size = new System.Drawing.Size(62, 44);
            this.btnApagarUmPorUm.TabIndex = 28;
            this.btnApagarUmPorUm.Text = "⌫";
            this.btnApagarUmPorUm.UseVisualStyleBackColor = true;
            this.btnApagarUmPorUm.Click += new System.EventHandler(this.btnApagarUmPorUm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 395);
            this.Controls.Add(this.btnApagarUmPorUm);
            this.Controls.Add(this.btnRaizQuadrada);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.btnPositivoNegativo);
            this.Controls.Add(this.lbOperacao);
            this.Controls.Add(this.labelOperacao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnIgual);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(302, 434);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(302, 434);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label labelOperacao;
        private System.Windows.Forms.Label lbOperacao;
        private System.Windows.Forms.Button btnPositivoNegativo;
        private System.Windows.Forms.Button btnUmSobreValor;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnRaizQuadrada;
        private System.Windows.Forms.Button btnApagarUmPorUm;
    }
}

