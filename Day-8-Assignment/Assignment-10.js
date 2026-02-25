// Assignment 10: Static Methods
// Create a class MathUtils
// Add:
// • static add()
// • static subtract()
// • static multiply()
// Test:
// MathUtils.add(10, 20);


class MathUtils {
    static add(a, b) {
        return a + b;
    }

    static subtract(a, b) {
        return a - b;
    }

    static multiply(a, b) {
        return a * b;
    }
}

console.log(MathUtils.add(10, 20));
console.log(MathUtils.subtract(50, 15));
console.log(MathUtils.multiply(5, 6));