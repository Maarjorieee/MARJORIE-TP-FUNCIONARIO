namespace MARJORIE_TP_FUNCIONARIO
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
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDiasTrabalhados = new System.Windows.Forms.Label();
            this.lblValorDiaria = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblValorDoIR = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorDoIR = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.txtDiasTrabalhados = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.mstCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(93, 87);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(59, 32);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(93, 197);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 32);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblDiasTrabalhados
            // 
            this.lblDiasTrabalhados.AutoSize = true;
            this.lblDiasTrabalhados.Location = new System.Drawing.Point(529, 87);
            this.lblDiasTrabalhados.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiasTrabalhados.Name = "lblDiasTrabalhados";
            this.lblDiasTrabalhados.Size = new System.Drawing.Size(198, 32);
            this.lblDiasTrabalhados.TabIndex = 2;
            this.lblDiasTrabalhados.Text = "Dias Trabalhados:";
            // 
            // lblValorDiaria
            // 
            this.lblValorDiaria.AutoSize = true;
            this.lblValorDiaria.Location = new System.Drawing.Point(529, 197);
            this.lblValorDiaria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValorDiaria.Name = "lblValorDiaria";
            this.lblValorDiaria.Size = new System.Drawing.Size(173, 32);
            this.lblValorDiaria.TabIndex = 3;
            this.lblValorDiaria.Text = "Valor da Diária:";
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Location = new System.Drawing.Point(93, 369);
            this.lblSalarioBase.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(146, 32);
            this.lblSalarioBase.TabIndex = 4;
            this.lblSalarioBase.Text = "Salário Base:";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(784, 369);
            this.lblSalarioLiquido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(176, 32);
            this.lblSalarioLiquido.TabIndex = 5;
            this.lblSalarioLiquido.Text = "Salário Líquido:";
            // 
            // lblValorDoIR
            // 
            this.lblValorDoIR.AutoSize = true;
            this.lblValorDoIR.Location = new System.Drawing.Point(437, 369);
            this.lblValorDoIR.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValorDoIR.Name = "lblValorDoIR";
            this.lblValorDoIR.Size = new System.Drawing.Size(134, 32);
            this.lblValorDoIR.TabIndex = 6;
            this.lblValorDoIR.Text = "Valor do IR:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(904, 113);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(135, 63);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular:";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(187, 190);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 39);
            this.txtNome.TabIndex = 2;
            // 
            // txtValorDoIR
            // 
            this.txtValorDoIR.Location = new System.Drawing.Point(580, 362);
            this.txtValorDoIR.Name = "txtValorDoIR";
            this.txtValorDoIR.Size = new System.Drawing.Size(122, 39);
            this.txtValorDoIR.TabIndex = 6;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(248, 362);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(135, 39);
            this.txtSalarioBase.TabIndex = 5;
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(736, 190);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(89, 39);
            this.txtValorDiaria.TabIndex = 4;
            // 
            // txtDiasTrabalhados
            // 
            this.txtDiasTrabalhados.Location = new System.Drawing.Point(736, 80);
            this.txtDiasTrabalhados.Name = "txtDiasTrabalhados";
            this.txtDiasTrabalhados.Size = new System.Drawing.Size(89, 39);
            this.txtDiasTrabalhados.TabIndex = 3;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(969, 366);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(122, 39);
            this.txtSalarioLiquido.TabIndex = 7;
            // 
            // mstCPF
            // 
            this.mstCPF.Location = new System.Drawing.Point(161, 80);
            this.mstCPF.Mask = "000.000.000-00";
            this.mstCPF.Name = "mstCPF";
            this.mstCPF.Size = new System.Drawing.Size(222, 39);
            this.mstCPF.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.mstCPF);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtDiasTrabalhados);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.txtValorDoIR);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValorDoIR);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioBase);
            this.Controls.Add(this.lblValorDiaria);
            this.Controls.Add(this.lblDiasTrabalhados);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCPF);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCPF;
        private Label lblNome;
        private Label lblDiasTrabalhados;
        private Label lblValorDiaria;
        private Label lblSalarioBase;
        private Label lblSalarioLiquido;
        private Label lblValorDoIR;
        private Button btnCalcular;
        private TextBox txtNome;
        private TextBox txtValorDoIR;
        private TextBox txtSalarioBase;
        private TextBox txtValorDiaria;
        private TextBox txtDiasTrabalhados;
        private TextBox txtSalarioLiquido;
        private MaskedTextBox mstCPF;
    }
}