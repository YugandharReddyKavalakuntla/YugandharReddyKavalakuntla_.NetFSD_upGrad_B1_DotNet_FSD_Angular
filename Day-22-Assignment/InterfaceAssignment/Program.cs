

class Program
{
    static void Main()
    {
   
        TCS tcsEmp = new TCS(101, "Ravi", "IT", "Developer", 50000);

        Console.WriteLine("TCS Employee Details:");
        Console.WriteLine($"ID: {tcsEmp.EmpId}, Name: {tcsEmp.Name}, Dept: {tcsEmp.Dept}, Designation: {tcsEmp.Desg}, Salary: {tcsEmp.BasicSalary}");

        tcsEmp.EmployeePF(tcsEmp.BasicSalary);
        Console.WriteLine(tcsEmp.LeaveDetails());
        Console.WriteLine("Gratuity: " + tcsEmp.GratuityAmount(12, tcsEmp.BasicSalary));

        Console.WriteLine("\n----------------------------------\n");

        // Accenture Employee
        Cognizant accEmp = new Cognizant(102, "Priya", "HR", "Manager", 60000);

        Console.WriteLine("Accenture Employee Details:");
        Console.WriteLine($"ID: {accEmp.EmpId}, Name: {accEmp.Name}, Dept: {accEmp.Dept}, Designation: {accEmp.Desg}, Salary: {accEmp.BasicSalary}");

        accEmp.EmployeePF(accEmp.BasicSalary);
        Console.WriteLine(accEmp.LeaveDetails());
        Console.WriteLine("Gratuity: " + accEmp.GratuityAmount(12, accEmp.BasicSalary));
    }
}