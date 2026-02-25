// Assignment 12: Private Fields (ES2022)
// Use:
// #balance
// Create class Wallet
// Methods:
// • addMoney()
// • spendMoney()
// • getBalance()
// Ensure balance cannot be accessed directly

class Wallet {
    #balance;

    constructor(initialBalance = 0) {
        this.#balance = initialBalance;
    }

    addMoney(amount) {
        if (amount > 0) {
            this.#balance += amount;
            console.log(`Added ${amount}. Current balance: ${this.#balance}`);
        } else {
            console.log("Amount must be positive");
        }
    }

    spendMoney(amount) {
        if (amount > this.#balance) {
            console.log("Insufficient balance");
        } else if (amount <= 0) {
            console.log("Amount must be positive");
        } else {
            this.#balance -= amount;
            console.log(`Spent ${amount}. Current balance: ${this.#balance}`);
        }
    }

    getBalance() {
        return this.#balance;
    }
}

const myWallet = new Wallet(500);
myWallet.addMoney(200);
myWallet.spendMoney(100);
console.log("Final Balance:", myWallet.getBalance());