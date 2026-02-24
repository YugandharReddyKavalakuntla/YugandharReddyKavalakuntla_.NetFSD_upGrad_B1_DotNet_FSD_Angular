// Assignment 4 – Employee Payroll System (Advanced)
// 🎯 Scenario
// HR department salary analytics.

// 🧩 Data
// let employees = [
//  { id:1, name:"Ravi", dept:"IT", salary:70000 },
//  { id:2, name:"Anita", dept:"HR", salary:50000 },
//  { id:3, name:"Karan", dept:"IT", salary:80000 },
//  { id:4, name:"Meena", dept:"Finance", salary:60000 }
// ];

// 📌 Tasks
// 	•	Calculate total salary expense.
// 	•	Find highest and lowest paid employee.
// 	•	Increase IT department salary by 15%.
// 	•	Group employees by department.
// 	•	Calculate department-wise average salary.
// 	•	Sort employees by salary descending.

// 🛠 Methods
// reduce(), map(), filter(), sort()

// 🏆 Bonus
// 	•	Add tax deduction (10%).
// 	•	Find employees earning above average salary.
// 	•	Convert employee data into HTML table.




let employees = [
  { id: 1, name: "Ravi", dept: "IT", salary: 70000 },
  { id: 2, name: "Anita", dept: "HR", salary: 50000 },
  { id: 3, name: "Karan", dept: "IT", salary: 80000 },
  { id: 4, name: "Meena", dept: "Finance", salary: 60000 }
];





let totalSalaryExpense = employees.reduce((total, emp) => {
  return total + emp.salary;
}, 0);

console.log("1. Total Salary Expense: ₹", totalSalaryExpense);




let highestPaid = employees.reduce((max, emp) => {
  return emp.salary > max.salary ? emp : max;
});

let lowestPaid = employees.reduce((min, emp) => {
  return emp.salary < min.salary ? emp : min;
});

console.log("2. Highest Paid Employee:", highestPaid);
console.log("   Lowest Paid Employee:", lowestPaid);




let updatedSalaries = employees.map(emp => {
  if (emp.dept === "IT") {
    return {
      ...emp,
      salary: emp.salary + (emp.salary * 0.15)
    };
  }
  return emp;
});

console.log("3. IT Department Salary Increased:", updatedSalaries);




let employeesByDept = employees.reduce((group, emp) => {
  if (!group[emp.dept]) {
    group[emp.dept] = [];
  }
  group[emp.dept].push(emp);
  return group;
}, {});

console.log("4. Employees Grouped by Department:", employeesByDept);





let deptAverageSalary = employees.reduce((result, emp) => {
  if (!result[emp.dept]) {
    result[emp.dept] = { total: 0, count: 0 };
  }
  result[emp.dept].total += emp.salary;
  result[emp.dept].count += 1;
  return result;
}, {});

for (let dept in deptAverageSalary) {
  deptAverageSalary[dept].average =
    deptAverageSalary[dept].total / deptAverageSalary[dept].count;
}

console.log("5. Department-wise Average Salary:", deptAverageSalary);




let sortedEmployees = [...employees].sort((a, b) => b.salary - a.salary);

console.log("6. Employees Sorted by Salary (High → Low):", sortedEmployees);





let employeesAfterTax = employees.map(emp => {
  return {
    ...emp,
    netSalary: emp.salary - (emp.salary * 0.10)
  };
});

console.log("7. Employees After Tax Deduction:", employeesAfterTax);




let averageSalary = totalSalaryExpense / employees.length;

let aboveAverageEmployees = employees.filter(emp => emp.salary > averageSalary);

console.log("8. Employees Earning Above Average Salary:", aboveAverageEmployees);




let htmlTable =
  `<table border="1">
    <tr>
      <th>ID</th>
      <th>Name</th>
      <th>Department</th>
      <th>Salary</th>
    </tr>` +
  employees
    .map(emp => {
      return `
    <tr>
      <td>${emp.id}</td>
      <td>${emp.name}</td>
      <td>${emp.dept}</td>
      <td>${emp.salary}</td>
    </tr>`;
    })
    .join("") +
  `
  </table>`;

console.log("9. HTML Table:\n", htmlTable);