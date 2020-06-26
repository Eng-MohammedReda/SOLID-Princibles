using solidConsoleDemo.OCP;

namespace solidConsoleDemo
{
    public abstract class Employee
    {
        public string ID {get;set;}
        public string Name {get;set;}
        public decimal BasicSalary {get;set;}
        public string EmpType{get;set;}

        public abstract decimal CalcHoursBouns(decimal hours);

        public override string ToString(){
           return $"Employee Id: {ID}, Name: {Name}";
       }
    }

    public class Manager : IEmployee
    {
        public string ID {get;set;}
        public string Name {get;set;}
        public decimal BasicSalary { get;set; }

        public decimal CalcHoursBonus(decimal hours)
        {
             return (((BasicSalary/30)/8) * hours )*2;
        }
         public override string ToString(){
           return $"Employee Id: {ID}, Name: {Name}";
       }
    }

    public class RegularEmp : IEmployee
    {
         public string ID {get;set;}
        public string Name {get;set;}
        public decimal BasicSalary { get;set; }
        public decimal CalcHoursBonus(decimal hours)
        {
            return (((BasicSalary/30)/8) * hours );
        }
         public override string ToString(){
           return $"Employee Id: {ID}, Name: {Name}";
       }
    }



}