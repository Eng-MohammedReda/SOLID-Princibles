namespace solidConsoleDemo.DIP
{
    public class Gmail : IMessage
    {
       public string Addrees = "address";
       public string from = "from mail";
       public string ToAddress = "ToAddress";

       public void Send(){ /* code */} 
    }

    public class Hotmail : IMessage
    {
       public string Addrees = "address";
       public string from = "from mail";
       public string ToAddress = "ToAddress";
       public void Send(){ /* code */} 
    }

    public class WebMail : IMessage
    {
       public string Addrees = "address";
       public string from = "from mail";
       public string ToAddress = "ToAddress";
       public void Send(){ /* code */} 
    }
}