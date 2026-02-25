// Assignment 2: Bank Account System
//  Objective:
// Use methods and modify object state.
//  Task:
// Create a class BankAccount.
// Properties:
// • accountHolder
// • balance
// Methods:
// • deposit(amount)
// • withdraw(amount)
// • checkBalance()
// Conditions:
// • Cannot withdraw more than balance
// • Show appropriate message


class BankAccount{
    constructor(accountHolder, balance){
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    deposit(amount){
        console.log(`Welcome to SBI NET BANKING ${this.accountHolder}`);
        this.balance += amount;
        console.log(`You Deposited Amount was ${amount} and currently Avalable balance in your account was ${this.balance}`);
        console.log("Thank You...")
    }

    withdraw(cash){
        console.log(`Welcome to SBI NET BANKING ${this.accountHolder}`);
        if(this.balance >= cash){
            this.balance -= cash;
            console.log(`You withdrawn Amount was ${cash} and currently Avalable balance in your account was ${this.balance}`);
            console.log("Thank You...")
        }else{
            console.log("Insufficent funds..");
        }


    }

    checkBalance(){
        console.log(`currently Avaliable balance was ${this.balance}`);

    }
}


const cust1 = new BankAccount("Yugandhar Reddy K", 35000);

cust1.deposit(4250);


console.log("---------------");

cust1.withdraw(39000);

console.log("---------------");


cust1.checkBalance();