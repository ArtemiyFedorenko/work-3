using System;

class Employee
{
    private string lastName;
    private string firstName;
    private string position;
    private int experience;
    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void SetPositionAndExperience(string position, int experience)
    {
        this.position = position;
        this.experience = experience;
    }
    public double CalculateSalary()
    {
        double baseSalary = 2000;
        switch (position.ToLower())
        {
            case "Монтажник":
                baseSalary += 1000;
                break;
            case "Замiшувачь":
                baseSalary += 1500;
                break;
            case "Кресяр":
                baseSalary += 1200;
                break;
            default:
                Console.WriteLine("Невiдома посада");
                break;
        }

        if (experience >= 5)
        {
            baseSalary += 500;
        }

        return baseSalary;
    }

    public double CalculateTax()
    {
        double salary = CalculateSalary();
        double taxRate = 0.18; 
        double tax = salary * taxRate;
        return tax;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Прiзвище: {lastName}");
        Console.WriteLine($"Iм'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {CalculateSalary()} грн");
        Console.WriteLine($"Податковий збiр: {CalculateTax()} грн");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("Василенко", "Денис");

        employee.SetPositionAndExperience("Замiшувачь", 7);

        employee.DisplayInfo();
    }
}