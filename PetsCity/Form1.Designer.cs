namespace PetsCity
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
            lblNomePet = new Label();
            lblPreco = new Label();
            lblBanhosMensais = new Label();
            lblIdade = new Label();
            btnCalcular = new Button();
            txtNomePet = new TextBox();
            txtIdadePet = new TextBox();
            txtBanhosMensais = new TextBox();
            txtPrecoBase = new TextBox();
            lblDesconto = new Label();
            lblValorFinal = new Label();
            lblParcelamento = new Label();
            lblBrinde = new Label();
            SuspendLayout();
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Location = new Point(164, 62);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(77, 15);
            lblNomePet.TabIndex = 0;
            lblNomePet.Text = "Nome do Pet";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(146, 92);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(95, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço do Serviço";
            // 
            // lblBanhosMensais
            // 
            lblBanhosMensais.AutoSize = true;
            lblBanhosMensais.Location = new Point(149, 126);
            lblBanhosMensais.Name = "lblBanhosMensais";
            lblBanhosMensais.Size = new Size(92, 15);
            lblBanhosMensais.TabIndex = 2;
            lblBanhosMensais.Text = "Banhos Mensais";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(168, 153);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(73, 15);
            lblIdade.TabIndex = 3;
            lblIdade.Text = "Idade do Pet";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(361, 330);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNomePet
            // 
            txtNomePet.Location = new Point(247, 59);
            txtNomePet.Name = "txtNomePet";
            txtNomePet.Size = new Size(306, 23);
            txtNomePet.TabIndex = 5;
            // 
            // txtIdadePet
            // 
            txtIdadePet.Location = new Point(247, 150);
            txtIdadePet.Name = "txtIdadePet";
            txtIdadePet.Size = new Size(306, 23);
            txtIdadePet.TabIndex = 6;
            // 
            // txtBanhosMensais
            // 
            txtBanhosMensais.Location = new Point(247, 118);
            txtBanhosMensais.Name = "txtBanhosMensais";
            txtBanhosMensais.Size = new Size(306, 23);
            txtBanhosMensais.TabIndex = 7;
            // 
            // txtPrecoBase
            // 
            txtPrecoBase.Location = new Point(247, 89);
            txtPrecoBase.Name = "txtPrecoBase";
            txtPrecoBase.Size = new Size(306, 23);
            txtPrecoBase.TabIndex = 8;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(203, 207);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(133, 15);
            lblDesconto.TabIndex = 9;
            lblDesconto.Text = "Desconto por fidelidade";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(203, 235);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(61, 15);
            lblValorFinal.TabIndex = 10;
            lblValorFinal.Text = "Valor Final";
            // 
            // lblParcelamento
            // 
            lblParcelamento.AutoSize = true;
            lblParcelamento.Location = new Point(203, 263);
            lblParcelamento.Name = "lblParcelamento";
            lblParcelamento.Size = new Size(80, 15);
            lblParcelamento.TabIndex = 11;
            lblParcelamento.Text = "Parcelamento";
            // 
            // lblBrinde
            // 
            lblBrinde.AutoSize = true;
            lblBrinde.Location = new Point(203, 290);
            lblBrinde.Name = "lblBrinde";
            lblBrinde.Size = new Size(41, 15);
            lblBrinde.TabIndex = 12;
            lblBrinde.Text = "Brinde";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBrinde);
            Controls.Add(lblParcelamento);
            Controls.Add(lblValorFinal);
            Controls.Add(lblDesconto);
            Controls.Add(txtPrecoBase);
            Controls.Add(txtBanhosMensais);
            Controls.Add(txtIdadePet);
            Controls.Add(txtNomePet);
            Controls.Add(btnCalcular);
            Controls.Add(lblIdade);
            Controls.Add(lblBanhosMensais);
            Controls.Add(lblPreco);
            Controls.Add(lblNomePet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomePet;
        private Label lblPreco;
        private Label lblBanhosMensais;
        private Label lblIdade;
        private Button btnCalcular;
        private TextBox txtNomePet;
        private TextBox txtIdadePet;
        private TextBox txtBanhosMensais;
        private TextBox txtPrecoBase;
        private Label lblDesconto;
        private Label lblValorFinal;
        private Label lblParcelamento;
        private Label lblBrinde;
    }
}
