
public class Cognizant : GovtRules
{
    private int empId;
    private string name;
    private string dept;
    private string desg;
    private double basicSalary;

    public Cognizant(int empId, string name, string dept, string desg, double basicSalary)
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
        double employerPF = basicSalary * 0.12;

        Console.WriteLine("Accenture PF Details:");
        Console.WriteLine("Employee PF: " + employeePF);
        Console.WriteLine("Employer PF: " + employerPF);

        return employeePF + employerPF;
    }

    public string LeaveDetails()
    {
        return "Cognizant Leave Policy:\n" +
               "2 Casual Leaves per month\n" +
               "5 Sick Leaves per year\n" +
               "5 Privilege Leaves per year";
    }

    public double GratuityAmount(float serviceCompleted, double basicSalary)
    {
        return 0; 
    }
}
