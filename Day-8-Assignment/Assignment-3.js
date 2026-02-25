// Assignment 3: Student Grade Calculator
//  Objective:
// Work with arrays inside classes.
//  Task:
// Create class Student
// Properties:
// • name
// • marks (array)
// Methods:
// • addMark(mark)
// • getAverage()
// • getGrade()
// Grade Rules:
// • 90+ → A
// • 75+ → B
// • 50+ → C
// • else → Fail


class Student{
    constructor(name, marks=[]){
        this.name = name;
        this.marks = marks;
    }

    addMark(mark){
        this.marks.push(mark);
        console.log(`${mark} Marks was added for ${this.name}`);
    }

    getAverage(){

        if(this.marks.length === 0){
            return 0;
        }

        let total = 0;

        for(let i=0 ; i < this.marks.length; i++){
            total += this.marks[i];
        }

        return total/this.marks.length;

    }

    getGrade(){
        const avg = this.getAverage();
        if (avg >= 90) {
            return "A";
        } else if (avg >= 75) {
            return "B";
        } else if (avg >= 50) {
            return "C";
        } else {
            return "Fail";
        }

    }


}

const student1 = new Student("Yugandhar");

student1.addMark(85);
student1.addMark(92);
student1.addMark(78);

console.log("Average:", student1.getAverage());
console.log("Grade:", student1.getGrade());