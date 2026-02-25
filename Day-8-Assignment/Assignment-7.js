// Assignment 7: Method Overriding
// Create:
// class Animal {
//  makeSound()
// }
// Child Classes:
// • Dog
// • Cat
// • Cow
// Each should override makeSound() differently.
// Test using:
// let animals = [new Dog(), new Cat(), new Cow()];
// animals.forEach(a => a.makeSound());


class Animal{
    makeSound(){
        console.log("Animal will sound");
    }
}

class Dog extends Animal{

    makeSound(){
        console.log("Dog Barks");
    }

}

class Cat extends Animal{

    makeSound(){
        console.log("cat says meow meow");
    }

}

class Cow extends Animal{

    makeSound(){
        console.log("cow says amba ambaa");
    }

}

let animals = [new Dog(), new Cat(), new Cow()];


animals.forEach(a => a.makeSound());
