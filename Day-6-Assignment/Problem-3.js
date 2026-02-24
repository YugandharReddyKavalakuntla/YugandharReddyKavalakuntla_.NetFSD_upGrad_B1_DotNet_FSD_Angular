{/* <Assignment 3 – Shopping Cart Management (Intermediate–Advanced)
🎯 Scenario
Build shopping cart functionality using arrays.

🧩 Data
let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];

📌 Tasks
	•	Calculate total cart value.
	•	Increase quantity of a product.
	•	Remove product from cart.
	•	Apply 10% discount on items above ₹10,000.
	•	Sort cart by total item price.
	•	Check if any product costs more than ₹50,000.
	•	Check if all items are in stock (qty > 0).

🛠 Methods
reduce(), map(), filter(), some(), every(), sort()

🏆 Bonus
	•	Convert cart into invoice format.
	•	Find most expensive product.
	•	Calculate GST (18%) on total.
  */}





let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];




let totalCartValue = cart.reduce((total, item) => {
  return total + (item.price * item.qty);
}, 0);

console.log("1. Total Cart Value: ₹", totalCartValue);





let updatedCartQty = cart.map(item => {
  if (item.id === 1) {
    return {
      ...item,
      qty: item.qty + 1
    };
  }
  return item;
});

console.log("2. Cart after increasing quantity:", updatedCartQty);





let removeProductId = 3;

let cartAfterRemoval = cart.filter(item => item.id !== removeProductId);

console.log("3. Cart after removing product:", cartAfterRemoval);



let discountedCart = cart.map(item => {
  if (item.price > 10000) {
    return {
      ...item,
      price: item.price - (item.price * 0.10)
    };
  }
  return item;
});

console.log("4. Cart after discount:", discountedCart);




let sortedByItemTotal = [...cart].sort((a, b) => {
  return (a.price * a.qty) - (b.price * b.qty);
});

console.log("5. Cart sorted by total item price:", sortedByItemTotal);




let isAnyCostlyProduct = cart.some(item => item.price > 50000);

console.log("6. Any product above ₹50,000?", isAnyCostlyProduct);



let allItemsInStock = cart.every(item => item.qty > 0);

console.log("7. All items in stock?", allItemsInStock);





let invoice = cart
  .map(item => {
    return `${item.product} | ₹${item.price} x ${item.qty} = ₹${item.price * item.qty}`;
  })
  .join("\n");

console.log("8. Invoice:\n" + invoice);




let mostExpensiveProduct = cart.reduce((max, item) => {
  return item.price > max.price ? item : max;
});

console.log("9. Most Expensive Product:", mostExpensiveProduct);




let gstAmount = totalCartValue * 0.18;
let finalAmountWithGST = totalCartValue + gstAmount;

console.log("10. GST (18%): ₹", gstAmount);
console.log("Final Amount with GST: ₹", finalAmountWithGST);