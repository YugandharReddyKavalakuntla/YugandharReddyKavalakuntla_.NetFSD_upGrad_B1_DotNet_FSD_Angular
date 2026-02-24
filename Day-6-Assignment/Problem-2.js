// Assignment 2 – Student Performance Analyzer (Intermediate)
// 🎯 Scenario
// School wants analytics from student marks.

// 🧩 Data
// let students = [
//   { name: "Akhil", marks: 85 },
//   { name: "Priya", marks: 72 },
//   { name: "Ravi", marks: 90 },
//   { name: "Meena", marks: 45 },
//   { name: "Karan", marks: 30 }
// ];

// 📌 Tasks
// 	•	Get list of passed students (>= 40).
// 	•	Get distinction students (>= 85).
// 	•	Calculate class average.
// 	•	Find topper.
// 	•	Count failed students.
// 	•	Convert marks to grades (A, B, C, Fail).

// 🛠 Methods
// filter(), reduce(), map(), find(), sort()

// 🏆 Bonus
// 	•	Add rank to each student.
// 	•	Remove lowest scorer.
// 	•	Create leaderboard sorted by marks.




let students = [
  { name: "Akhil", marks: 85 },
  { name: "Priya", marks: 72 },
  { name: "Ravi", marks: 90 },
  { name: "Meena", marks: 45 },
  { name: "Karan", marks: 30 }
];

let passedStudents = students.filter(student => student.marks >= 40);
console.log("1. Passed Students:", passedStudents);



let distinctionStudents = students.filter(student => student.marks >= 85);
console.log("2. Distinction Students:", distinctionStudents);



let totalMarks = students.reduce((sum, student) => sum + student.marks, 0);
let averageMarks = totalMarks / students.length;
console.log("3. Class Average:", averageMarks);




let topper = students.reduce((top, student) => {
  return student.marks > top.marks ? student : top;
});
console.log("4. Topper:", topper);




let failedCount = students.filter(student => student.marks < 40).length;
console.log("5. Failed Students Count:", failedCount);



let studentsWithGrades = students.map(student => {
  let grade;

  if (student.marks >= 85) grade = "A";
  else if (student.marks >= 60) grade = "B";
  else if (student.marks >= 40) grade = "C";
  else grade = "Fail";

  return {
    ...student,
    grade: grade
  };
});

console.log("6. Students with Grades:", studentsWithGrades);




let rankedStudents = [...students]
  .sort((a, b) => b.marks - a.marks)
  .map((student, index) => {
    return {
      ...student,
      rank: index + 1
    };
  });

console.log("7. Students with Rank:", rankedStudents);



let lowestScorer = students.reduce((low, student) => {
  return student.marks < low.marks ? student : low;
});

let studentsAfterRemoval = students.filter(
  student => student.name !== lowestScorer.name
);

console.log("8. After Removing Lowest Scorer:", studentsAfterRemoval);




let leaderboard = [...students].sort((a, b) => b.marks - a.marks);
console.log("9. Leaderboard (High to Low):", leaderboard);