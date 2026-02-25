// Assignment 11: Getters & Setters
// Create class User
// • Private property _password
// • Setter should validate:
// o Minimum 6 characters
// • Getter should return full password


class User {
    constructor(password) {
        this._password = password;
    }

    get password() {
        return this._password;
    }

    set password(newPassword) {
        if (newPassword.length >= 6) {
            this._password = newPassword;
            console.log("Password updated successfully");
        } else {
            console.log("Password must be at least 6 characters");
        }
    }
}

const user1 = new User("secret123");
console.log(user1.password);

user1.password = "abc";      
user1.password = "mypassword"; 
console.log(user1.password);