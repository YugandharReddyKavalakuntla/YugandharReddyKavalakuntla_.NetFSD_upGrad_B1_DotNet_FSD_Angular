// Multi-level inheritance
// Structure:
// Employee
//  |
// Manager
//  |
// Director
// Base Class:
// • name
// • salary
// • getDetails()
// Manager:
// • bonus
// • getTotalSalary()
// Director:
// • stockOptions
// • getFullCompensation()

class Employee {
    constructor(name, salary) {
        this.name = name;
        this.salary = salary;
    }

    getDetails() {
        console.log(`Employee Name: ${this.name}, Salary: ${this.salary}`);
    }
}

class Manager extends Employee {
    constructor(name, salary, bonus) {
        super(name, salary);  
        this.bonus = bonus;
    }

    getTotalSalary() {
        return this.salary + this.bonus;
    }
}

class Director extends Manager {
    constructor(name, salary, bonus, stockOptions) {
        super(name, salary, bonus);  
        this.stockOptions = stockOptions;
    }

    getFullCompensation() {
        return this.salary + this.bonus + this.stockOptions;
    }
}


const dir1 = new Director("Yugandhar", 100000, 20000, 50000);

dir1.getDetails();

console.log("Total Salary (Manager level):", dir1.getTotalSalary());

console.log("Full Compensation (Director level):", dir1.getFullCompensation());