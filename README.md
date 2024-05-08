# PagamentoOnline
Un Pagamento Online
Traccia: Sistema di Pagamento
Si vuole creare un sistema di gestione dei pagamenti che supporti diverse modalità di
pagamento come carta di credito, bonifico bancario e PayPal. Utilizzare classi
astratte e interfacce per implementare questo sistema.
1.     Definire un'interfaccia chiamata IPagamento con
i seguenti metodi:
                        a.     void EseguiPagamento(double importo): Questo metodo deve essere implementato da ogni classe
che implementa l'interfaccia e deve eseguire il pagamento dell'importo
specificato.
2.     Creare una classe astratta chiamata PagamentoOnline che implementi l'interfaccia IPagamento.
Questa classe astratta dovrebbe avere un campo dati per l'importo totale e un
metodo astratto CalcolaCommissione() che restituisce la commissione applicata per il
pagamento online.
3.     Creare tre classi concrete che estendono la classe PagamentoOnline: CartaDiCredito, BonificoBancario e PayPal. Ogni
classe dovrebbe implementare il metodo CalcolaCommissione() in base
alla politica di commissione specifica per quel tipo di pagamento.
4.     Implementare il metodo EseguiPagamento(double importo) in
ciascuna classe concreta. Questo metodo deve calcolare l'importo totale da
pagare considerando la commissione e stampare un messaggio che confermi il
pagamento avvenuto.
5.     Creare una classe GestorePagamenti che
permetta di eseguire pagamenti utilizzando le diverse modalità di pagamento.
Questa classe dovrebbe avere un metodo EseguiPagamento(IPagamento metodoPagamento, double importo) che riceve un oggetto che implementa l'interfaccia IPagamento e
l'importo da pagare. Il metodo dovrebbe semplicemente chiamare il metodo EseguiPagamento() del metodoPagamento passando l'importo come argomento.
