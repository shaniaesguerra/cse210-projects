using System.Runtime.CompilerServices;

public class Employee
{
    protected string _name;
    protected int _id;

    public Employee (string name, int id)
    {
        _name = name;
        _id = id;
    }

    public void DisplayEmployee()
    {
        Console.WriteLine($"Name {_name} | Employee ID: {_id}");
    }
}

public class Manager : Employee
{
    private int _annualSalary;
    private int _bonus;
    public Manager(string name, int id, int salary, int bonus) : base(name, id)
    {
        _annualSalary = salary;
        _bonus = bonus;
    }
    
    public int CalculatePay()
    {
        return _annualSalary + _bonus;
    }
}

public class HourlyPaidEmployee : Employee
{
    private int _hoursWorked;
    private int _hourlyWage;

    public HourlyPaidEmployee(string name, int id, int hoursWorked, int hourlyWage) : base(name, id)
    {
        _hoursWorked = hoursWorked;
        _hourlyWage  = hourlyWage;
    }

    public int CalculatePay()
    {
        return _hoursWorked * _hourlyWage;
    }
}