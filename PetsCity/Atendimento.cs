namespace PetsCity
{
    internal class Atendimento
    {
        public string? NomePet { get; set; }
        public double PrecoBase { get; set; }
        public int QtdBanhos {  get; set; }
        public int Idade {  get; set; }


        public double DescontoFidelidade()
        {
            double valorFinal = PrecoBase * QtdBanhos;
            if (QtdBanhos >= 6)
            {
                return valorFinal * 0.20;
            }
            return 0.0;
        }

        public double CalcularValorFinal()
        {
            double ValorBruto = PrecoBase * QtdBanhos;
            double Desconto = DescontoFidelidade();
            return ValorBruto - Desconto;
        }

        public double CalcularParcela()
        {
            return CalcularValorFinal() / 2.0;
        }

        public bool Brinde()
        {
            return (Idade >= 8 && QtdBanhos >= 10) || (CalcularValorFinal() > 100);
        }
    }

    
}
