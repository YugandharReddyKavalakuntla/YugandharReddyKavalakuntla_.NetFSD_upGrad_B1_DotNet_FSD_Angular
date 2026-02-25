// Assignment 6: Shape Area Calculator
// Base Class:
// Shape
// - calculateArea()
// Child Classes:
// • Circle
// • Rectangle
// • Triangle
// Each class must override calculateArea().
// Test polymorphism using:
// let shapes = [new Circle(...), new Rectangle(...)]
// Loop through and call calculateArea().


class Shape {
    calculateArea() {
        console.log("Area calculation not defined.");
    }
}

class Circle extends Shape {
    constructor(radius) {
        super();
        this.radius = radius;
    }

    calculateArea() {
        const area = Math.PI * this.radius * this.radius;
        console.log(`Circle Area: ${area.toFixed(2)}`);
    }
}

class Rectangle extends Shape {
    constructor(length, width) {
        super();
        this.length = length;
        this.width = width;
    }

    calculateArea() {
        const area = this.length * this.width;
        console.log(`Rectangle Area: ${area}`);
    }
}

class Triangle extends Shape {
    constructor(base, height) {
        super();
        this.base = base;
        this.height = height;
    }

    calculateArea() {
        const area = 0.5 * this.base * this.height;
        console.log(`Triangle Area: ${area}`);
    }
}


let shapes = [
    new Circle(7),
    new Rectangle(10, 5),
    new Triangle(8, 6)
];

for (let shape of shapes) {
    shape.calculateArea();   
}