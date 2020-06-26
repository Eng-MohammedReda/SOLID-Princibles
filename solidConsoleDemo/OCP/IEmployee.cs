namespace solidConsoleDemo.OCP
{
    public interface IEmployee
    {
        decimal BasicSalary{get;set;}
       decimal CalcHoursBonus(decimal hours);
    }  
}