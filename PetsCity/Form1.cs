namespace PetsCity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Atendimento pet = new Atendimento();

                pet.NomePet = txtNomePet.Text;
                pet.PrecoBase = Convert.ToDouble(txtPrecoBase.Text);
                pet.QtdBanhos = int.Parse(txtBanhosMensais.Text);
                pet.Idade = int.Parse(txtIdadePet.Text);

                double desconto = pet.DescontoFidelidade();
                double valorFinal = pet.CalcularValorFinal();
                double parcelamento = pet.CalcularParcela();
                bool brinde = pet.Brinde();

                lblDesconto.Text = $"R$:{desconto:N2}";
                lblValorFinal.Text = $"R$:{valorFinal:N2}";
                lblParcelamento.Text = $"2x de {parcelamento}";

                if (brinde)
                {
                    lblBrinde.Text = $"Parabens!!! Voce ganhou o brinde";
                    lblBrinde.ForeColor = Color.Green;
                }
                else
                {
                    lblBrinde.Text = $"Compra padrão do banho realizada!!";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha os campos numéricos corretamente!",
                    "Erro de Digitação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
