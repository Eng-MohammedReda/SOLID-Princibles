namespace solidConsoleDemo.ISP
{
    public interface IOrder :ICashOrder , IOnlineOrder , ICreditOrder
    {
       void newMethod();
    }   

    public interface ICashOrder { void ProcessCashInvoice(); void Complete();}
    public interface IOnlineOrder{ void ProcessOnlinePaymentInvoice();}

    public interface ICreditOrder{ void ProcessCreditInvoice();}
}