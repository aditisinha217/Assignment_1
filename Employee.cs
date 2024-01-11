using System.Security.Cryptography.X509Certificates;

namespace assignment;

class Employee{
    public int EmpId{
        get;
        set;
    }

    public string? EmpName{
        get;
        set;
    }

    public DateTime Doj{
        get;
        set;
    }
    
    public int Salary{
        get;
        set;
    }

    public void AcceptDetails(){
        System.Console.WriteLine("Enter your name: ");
        EmpName=Console.ReadLine();
        System.Console.WriteLine("Enter your EmpId: ");
        EmpId=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your doj");
        Doj=Convert.ToDateTime(Console.ReadLine());
    }

    public void DisplayDetails(){
        System.Console.WriteLine("Employee name: "+ EmpName);
        System.Console.WriteLine("Employee ID: "+ EmpId);
        System.Console.WriteLine("Employee doj: "+ Doj);
        System.Console.WriteLine("Employee Salary: "+ Salary);
    }

    public virtual int CalculateSalary(){
        System.Console.WriteLine("Enter your salary");
        Salary=Convert.ToInt32(Console.ReadLine());
        return Salary;
    }
}

class Permanent: Employee, IEmployee{
    public int BasicPay{
        get;
        set;
    }

    public int HRA{
        get;
        set;
    }

    public int DA{
        get;
        set;
    }
    
    public int PF{
        get;
        set;
    }

    public void GetDetails(){
        System.Console.WriteLine("Enter your BasicPay: ");
        BasicPay=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your HRA: ");
        HRA=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your DA");
        DA=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your PF");
        PF=Convert.ToInt32(Console.ReadLine());
    }

    public void ShowDetails(){
        System.Console.WriteLine("Employee basicpay: "+ BasicPay);
        System.Console.WriteLine("Employee HRA: "+ HRA);
        System.Console.WriteLine("Employee DA: "+ DA);
        System.Console.WriteLine("Employee PF: "+ PF);
    }

    public override int CalculateSalary()
    {
        Salary=base.CalculateSalary()+BasicPay+HRA+DA-PF;
        return Salary;
    }
}

class Trainee: Employee,IEmployee{
    public int Bonus{
        get;
        set;
    }

    public string? ProjectName{
        get;
        set;
    }

    public void GetTraineeDetails(){
        System.Console.WriteLine("Enter your bonus: ");
        Bonus=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your ProjectName: ");
        ProjectName=Console.ReadLine();
    }

    public void ShowTraineeDetails(){
        System.Console.WriteLine("Trainee bonus: "+ Bonus);
        System.Console.WriteLine("Trainee Project Name: "+ ProjectName);
    }

    public override int CalculateSalary()
    {
        if(ProjectName=="Banking"){
            int bonus=(5/100)*base.CalculateSalary();
            Salary=base.CalculateSalary()+bonus;
        }
        else if(ProjectName=="Insurance"){
            int bonus=(10/100)*base.CalculateSalary();
            Salary=base.CalculateSalary()+bonus;
        }
        return Salary;
    }
}