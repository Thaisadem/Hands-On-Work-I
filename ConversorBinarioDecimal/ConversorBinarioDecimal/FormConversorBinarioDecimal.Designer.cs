namespace ConversorBinarioDecimal
{
    partial class FormConversorBinarioDecimal
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grBoxValores = new System.Windows.Forms.GroupBox();
            this.txtBoxConvertido = new System.Windows.Forms.TextBox();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.lbConvertido = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.grBoxTipoConversao = new System.Windows.Forms.GroupBox();
            this.rdBtnBinarioDecimal = new System.Windows.Forms.RadioButton();
            this.rdBtnDecimalBinario = new System.Windows.Forms.RadioButton();
            this.grBoxValores.SuspendLayout();
            this.grBoxTipoConversao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(107, 206);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(27, 206);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grBoxValores
            // 
            this.grBoxValores.Controls.Add(this.txtBoxConvertido);
            this.grBoxValores.Controls.Add(this.txtBoxValor);
            this.grBoxValores.Controls.Add(this.lbConvertido);
            this.grBoxValores.Controls.Add(this.lbValor);
            this.grBoxValores.Location = new System.Drawing.Point(12, 100);
            this.grBoxValores.Name = "grBoxValores";
            this.grBoxValores.Size = new System.Drawing.Size(182, 100);
            this.grBoxValores.TabIndex = 8;
            this.grBoxValores.TabStop = false;
            this.grBoxValores.Text = "Valores";
            // 
            // txtBoxConvertido
            // 
            this.txtBoxConvertido.Location = new System.Drawing.Point(70, 63);
            this.txtBoxConvertido.Name = "txtBoxConvertido";
            this.txtBoxConvertido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxConvertido.TabIndex = 5;
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.Location = new System.Drawing.Point(43, 19);
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValor.TabIndex = 4;
            // 
            // lbConvertido
            // 
            this.lbConvertido.AutoSize = true;
            this.lbConvertido.Location = new System.Drawing.Point(6, 66);
            this.lbConvertido.Name = "lbConvertido";
            this.lbConvertido.Size = new System.Drawing.Size(58, 13);
            this.lbConvertido.TabIndex = 2;
            this.lbConvertido.Text = "Conversão";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(6, 23);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 0;
            this.lbValor.Text = "Valor";
            // 
            // grBoxTipoConversao
            // 
            this.grBoxTipoConversao.Controls.Add(this.rdBtnBinarioDecimal);
            this.grBoxTipoConversao.Controls.Add(this.rdBtnDecimalBinario);
            this.grBoxTipoConversao.Location = new System.Drawing.Point(12, 12);
            this.grBoxTipoConversao.Name = "grBoxTipoConversao";
            this.grBoxTipoConversao.Size = new System.Drawing.Size(182, 82);
            this.grBoxTipoConversao.TabIndex = 7;
            this.grBoxTipoConversao.TabStop = false;
            this.grBoxTipoConversao.Text = "Tipo Conversão";
            // 
            // rdBtnBinarioDecimal
            // 
            this.rdBtnBinarioDecimal.AutoSize = true;
            this.rdBtnBinarioDecimal.Location = new System.Drawing.Point(5, 19);
            this.rdBtnBinarioDecimal.Name = "rdBtnBinarioDecimal";
            this.rdBtnBinarioDecimal.Size = new System.Drawing.Size(122, 17);
            this.rdBtnBinarioDecimal.TabIndex = 0;
            this.rdBtnBinarioDecimal.TabStop = true;
            this.rdBtnBinarioDecimal.Text = "Binário para Decimal";
            this.rdBtnBinarioDecimal.UseVisualStyleBackColor = true;
            // 
            // rdBtnDecimalBinario
            // 
            this.rdBtnDecimalBinario.AutoSize = true;
            this.rdBtnDecimalBinario.Location = new System.Drawing.Point(5, 52);
            this.rdBtnDecimalBinario.Name = "rdBtnDecimalBinario";
            this.rdBtnDecimalBinario.Size = new System.Drawing.Size(122, 17);
            this.rdBtnDecimalBinario.TabIndex = 1;
            this.rdBtnDecimalBinario.TabStop = true;
            this.rdBtnDecimalBinario.Text = "Decimal para Binário";
            this.rdBtnDecimalBinario.UseVisualStyleBackColor = true;
            // 
            // FormConversorBinarioDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 246);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grBoxValores);
            this.Controls.Add(this.grBoxTipoConversao);
            this.Name = "FormConversorBinarioDecimal";
            this.Text = "Conversor Binário Decimal";
            this.grBoxValores.ResumeLayout(false);
            this.grBoxValores.PerformLayout();
            this.grBoxTipoConversao.ResumeLayout(false);
            this.grBoxTipoConversao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grBoxValores;
        private System.Windows.Forms.Label lbConvertido;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.GroupBox grBoxTipoConversao;
        private System.Windows.Forms.RadioButton rdBtnBinarioDecimal;
        private System.Windows.Forms.RadioButton rdBtnDecimalBinario;
        private System.Windows.Forms.TextBox txtBoxConvertido;
        private System.Windows.Forms.TextBox txtBoxValor;
    }
}

