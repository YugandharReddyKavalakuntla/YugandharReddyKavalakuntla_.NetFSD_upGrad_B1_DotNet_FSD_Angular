// Task:
// Create a class called Person.
// Requirements:
// • Properties: name, age
// • Method: greet() → prints
// "Hello, my name is <name> and I am <age> years old."
//  Expected Usage:
// let p1 = new Person("Rahul", 25);
// p1.greet();


class Person{
    constructor(name, age){
        this.name = name;
        this.age = age;
    }

    greet(){
        console.log(`Hello, my name is ${this.name} and I am ${this.age} years old.`);

    }


}


let p1 = new Person("Yugandhara Reddy Kavalakuntla", 23);

p1.greet();