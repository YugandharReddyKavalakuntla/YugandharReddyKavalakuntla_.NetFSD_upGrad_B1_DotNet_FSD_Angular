
// 🧪 Assignment 1 – Online Book Store (Beginner–Intermediate)
// 🎯 Scenario
// You are building a small online bookstore inventory system.

// 🧩 Data
// let books = [
//   { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
//   { id: 2, title: "React Guide", price: 650, stock: 5 },
//   { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
//   { id: 4, title: "CSS Complete", price: 300, stock: 12 }
// ];

// 📌 Tasks
// 	•	Display all book titles.
// 	•	Find total inventory value.
// 	•	Find books costing above ₹500.
// 	•	Increase price of all books by 5%.
// 	•	Sort books by price (low → high).
// 	•	Remove a book by ID.
// 	•	Check if any book is out of stock.

// 🛠 Methods to Use
// map(), filter(), reduce(), some(), sort(), find()

// 🏆 Bonus
// 	•	Group books by price range.
// 	•	Add discount only for books above ₹600.
// 	•	Generate invoice string using join().
 



let books = [
  { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
  { id: 2, title: "React Guide", price: 650, stock: 5 },
  { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
  { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];



let titles = books.map(book => book.title);
console.log("1. Book Titles:", titles);



let totalInventoryValue = books.reduce((total, book) => {
  return total + (book.price * book.stock);
}, 0);
console.log("2. Total Inventory Value: ₹", totalInventoryValue);




let booksAbove500 = books.filter(book => book.price > 500);
console.log("3. Books costing above ₹500:", booksAbove500);



let increasedPriceBooks = books.map(book => {
  return {
    ...book,
    price: book.price + (book.price * 0.05)
  };
});
console.log("4. Prices increased by 5%:", increasedPriceBooks);



let sortedBooks = [...books].sort((a, b) => a.price - b.price);
console.log("5. Books sorted by price:", sortedBooks);



let removeBookId = 2;
let booksAfterRemoval = books.filter(book => book.id !== removeBookId);
console.log("6. After removing book with ID 2:", booksAfterRemoval);



let isAnyOutOfStock = books.some(book => book.stock === 0);
console.log("7. Any book out of stock?", isAnyOutOfStock);





let groupedBooks = books.reduce((result, book) => {
  if (book.price < 500) {
    result.budget.push(book);
  } else if (book.price <= 600) {
    result.standard.push(book);
  } else {
    result.premium.push(book);
  }
  return result;
}, { budget: [], standard: [], premium: [] });

console.log("8. Grouped Books by Price Range:", groupedBooks);





let discountedBooks = books.map(book => {
  if (book.price > 600) {
    return {
      ...book,
      price: book.price - (book.price * 0.10)
    };
  }
  return book;
});
console.log("9. Discounted Books (Above ₹600):", discountedBooks);




let invoice = books
  .map(book => `${book.title} - ₹${book.price}`)
  .join("\n");

console.log("10. Invoice:\n" + invoice);