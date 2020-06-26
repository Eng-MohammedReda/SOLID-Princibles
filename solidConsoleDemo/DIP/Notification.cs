namespace solidConsoleDemo.DIP
{
    public class Notification
    {
        private IMessage _mailService ;
        public Notification(IMessage mailService){
            _mailService = mailService ;
        }
         
         public IMessage mailType {get;set;}

        public void SendMail(){  mailType.Send(); }
       
    }
}