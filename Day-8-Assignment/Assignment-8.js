// Assignment 8: Runtime Polymorphism Project
// Create a Payment system.
// Base Class:
// Payment
// - pay(amount)
// Child Classes:
// • CreditCardPayment
// • UPIPayment
// • CashPayment
// Each should implement pay() differently.

class Payment {
    pay(amount) {
        console.log(`Processing payment of ${amount}`);
    }
}

class CreditCardPayment extends Payment {
    pay(amount) {
        console.log(`Paid ${amount} using Credit Card 💳`);
    }
}

class UPIPayment extends Payment {
    pay(amount) {
        console.log(`Paid ${amount} using UPI 📱`);
    }
}

class CashPayment extends Payment {
    pay(amount) {
        console.log(`Paid ${amount} using Cash 💵`);
    }
}



let payments = [
    new CreditCardPayment(),
    new UPIPayment(),
    new CashPayment()
];

payments.forEach(p => p.pay(5000));