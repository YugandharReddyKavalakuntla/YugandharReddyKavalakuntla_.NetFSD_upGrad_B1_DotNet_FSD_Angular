using System;


public class TCS : GovtRules
{
    private int empId;
    private string name;
    private string dept;
    private string desg;
    private double basicSalary;

    public TCS(int empId, string name, string dept, string desg, double basicSalary)
    {
        this.empId = empId;
        this.name = name;
        this.dept = dept;
        this.desg = desg;
        this.basicSalary = basicSalary;
    }

    public int EmpId { get { return empId; } }
    public string Name { get { return name; } }
    public string Dept { get { return dept; } }
    public string Desg { get { return desg; } }
    public double BasicSalary { get { return basicSalary; } }

    public double EmployeePF(double basicSalary)
    {
        double employeePF = basicSalary * 0.12;
        double employerPF = basicSalary * 0.0833;
        double pensionFund = basicSalary * 0.0367;

        Console.WriteLine("TCS PF Details:");
        Console.WriteLine("Employee PF: " + employeePF);
        Console.WriteLine("Employer PF: " + employerPF);
        Console.WriteLine("Pension Fund: " + pensionFund);

        return employeePF + employerPF + pensionFund;
    }

    public string LeaveDetails()
    {
        return "TCS Leave Policy:\n" +
               "1 Casual Leave per month\n" +
               "12 Sick Leaves per year\n" +
               "10 Privilege Leaves per year";
    }

    public double GratuityAmount(float serviceCompleted, double basicSalary)
    {
        if (serviceCompleted > 20)
            return 3 * basicSalary;
        else if (serviceCompleted > 10)
            return 2 * basicSalary;
        else if (serviceCompleted > 5)
            return 1 * basicSalary;
        else
            return 0;
    }
}
