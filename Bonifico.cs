namespace Pag3
{
    public class Bonifico : PagamentoOnline
    {
        private double commissione = 2;

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