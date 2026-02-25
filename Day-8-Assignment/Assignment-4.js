// Assignment 4: Vehicle Inheritance
//  Objective:
// Understand extends and super.
//  Task:
// Create:
// Base Class:
// Vehicle
// - brand
// - speed
// - start()
// Derived Class:
// Car
// - fuelType
// - showDetails()
// Requirements:
// • Use super() properly.
// • Call parent method from child object.


class Vehicle{

    constructor(brand, speed){
        this.brand = brand;
        this.speed = speed;
    }
 
    start(){
         console.log(`${this.brand} vehicle is starting at speed ${this.speed} km/h`);
    }

}


class Car extends Vehicle{

    constructor(brand, speed,fuelType){
        super(brand, speed);
        this.fuelType = fuelType;
    } 

    showDetails(){
        console.log(`Brand: ${this.brand}`);
        console.log(`Speed: ${this.speed} km/h`);
        console.log(`Fuel Type: ${this.fuelType}`);

    }

}


const car1 = new Car("TATA", "140", "Pertol");

car1.start();

car1.showDetails();

