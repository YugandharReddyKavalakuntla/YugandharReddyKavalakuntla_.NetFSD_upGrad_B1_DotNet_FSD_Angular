// Assignment 9: Use ES6 Features Inside Class
// Create a Product class using:
// • Default parameters
// • Template literals
// • Arrow functions
// • Destructuring
// • Spread operator
// Example:
// constructor({name, price, category = "General"})



class Product {
    constructor({ name, price, category = "General" }) {
        this.name = name;
        this.price = price;
        this.category = category;
        this.tags = []; 
    }

    addTags = (...newTags) => {   
        this.tags.push(...newTags);
        console.log(`Tags [${newTags.join(", ")}] added to ${this.name}`);
    }

    showInfo = () => {
        console.log(`Product: ${this.name} | Price: $${this.price} | Category: ${this.category}`);
        if (this.tags.length > 0) {
            console.log(`Tags: ${this.tags.join(", ")}`);
        }
    }
}

const prod1 = new Product({ name: "Laptop", price: 1200 });
prod1.showInfo();  

prod1.addTags("Electronics", "Gadgets", "New");  
prod1.showInfo();

const prod2 = new Product({ name: "Book", price: 25, category: "Education" });
prod2.showInfo();