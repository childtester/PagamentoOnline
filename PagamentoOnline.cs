public abstract class PagamentoOnline : IPagamento
{

    public abstract double CalcolaCommissione(double importo);
    public abstract void EseguiPagamento(double importo);
}
        
    

