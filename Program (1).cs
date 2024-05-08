
using Pag1;
using Pag2;
using Pag3;
using GestPag;
class Program
{
    Bonifico bonifico= new Bonifico();
    PayPal payPal=new PayPal();
    CartaDiCredito cartaDiCredito=new CartaDiCredito();
    GestorePagamento.EseguiPagamento(new Bonifico(), 100);
    GestorePagamento.EseguiPagamento(new PayPal(), 100); 
    GestorePagamento.EseguiPagamento(new CartaDiCredito(), 100);  
    
}


   
