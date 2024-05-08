namespace Pag1
{
    class PayPal : PagamentoOnline

    {
        private double commissione = 3;

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

