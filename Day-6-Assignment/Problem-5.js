// Assignment 5 – Data Cleaning & Analytics (Interview Level)
// 🎯 Scenario
// You receive messy data from API.

// 🧩 Data
// let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];

// 📌 Tasks
// 	•	Remove duplicates.
// 	•	Find second largest number.
// 	•	Find frequency of each element.
// 	•	Find first non-repeating number.
// 	•	Rotate array by 2 positions.
// 	•	Flatten nested array: [1,2,[3,4,[5]]]
// 	•	Find missing number in [1,2,3,5,6]

// 🛠 Methods
// Set, reduce(), sort(), map(), filter(), slice()



let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];




let uniqueNumbers = [...new Set(numbers)];
console.log("1. Unique Numbers:", uniqueNumbers);




let sortedDesc = [...uniqueNumbers].sort((a, b) => b - a);
let secondLargest = sortedDesc[1];
console.log("2. Second Largest Number:", secondLargest);



let frequencyMap = numbers.reduce((freq, num) => {
  freq[num] = (freq[num] || 0) + 1;
  return freq;
}, {});

console.log("3. Frequency of Elements:", frequencyMap);



let firstNonRepeating = numbers.find(num => frequencyMap[num] === 1);
console.log("4. First Non-Repeating Number:", firstNonRepeating);



let rotateBy = 2;
let rotatedArray = [
  ...numbers.slice(-rotateBy),
  ...numbers.slice(0, numbers.length - rotateBy)
];

console.log("5. Array after rotating by 2 positions:", rotatedArray);



let nestedArray = [1, 2, [3, 4, [5]]];

let flattenedArray = nestedArray.flat(Infinity);
console.log("6. Flattened Array:", flattenedArray);




let arr = [1, 2, 3, 5, 6];

let missingNumber = null;
for (let i = 0; i < arr.length - 1; i++) {
  if (arr[i + 1] !== arr[i] + 1) {
    missingNumber = arr[i] + 1;
    break;
  }
}

console.log("7. Missing Number:", missingNumber);