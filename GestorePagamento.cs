namespace GestPag
{
    public static class GestorePagamento
    {
        public static void EseguiPagamento(IPagamento metodoPagamento, double importo)
        {
            metodoPagamento.EseguiPagamento(importo);
        }
    }
}