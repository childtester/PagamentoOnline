namespace Pag2
{
    class CartaDiCredito : PagamentoOnline
    {

        private double commissione = 4;

        public override double CalcolaCommissione(double importo)
        {
            return commissione;
        }

        public override void EseguiPagamento(double importo)
        {
            Console.WriteLine("hai speso" + CalcolaCommissione(importo));
        }
    }
}