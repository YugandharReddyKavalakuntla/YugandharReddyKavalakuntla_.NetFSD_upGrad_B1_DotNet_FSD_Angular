-- DAY 2 – Hands On
-- Pre-Requisites: Before starting with problem solving, please make sure that you have created a database and restored data (refer Sample Database create objects.txt and load data.txt)


CREATE DATABASE StoreDB;
GO

USE StoreDB;
GO


CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    email VARCHAR(100)
);

CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100)
);

CREATE TABLE brands (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(100)
);

CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(100)
);

CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    brand_id INT,
    category_id INT,
    model_year INT,
    list_price DECIMAL(10,2),

    FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);


CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    customer_id INT,
    order_status INT,
    order_date DATE,
    store_id INT,

    FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
    FOREIGN KEY (store_id) REFERENCES stores(store_id)
);

CREATE TABLE order_items (
    order_item_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT,
    list_price DECIMAL(10,2),
    discount DECIMAL(4,2),

    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);


CREATE TABLE stocks (
    store_id INT,
    product_id INT,
    quantity INT,

    PRIMARY KEY (store_id, product_id),
    FOREIGN KEY (store_id) REFERENCES stores(store_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

SELECT name FROM sys.tables;

INSERT INTO customers VALUES
(1,'John','Doe','john@email.com'),
(2,'Jane','Smith','jane@email.com'),
(3,'Robert','Brown','robert@email.com'),
(4,'Emily','Davis','emily@email.com');

INSERT INTO stores VALUES
(1,'Central Store'),
(2,'City Mall Store');

INSERT INTO brands VALUES
(1,'Trek'),
(2,'Giant'),
(3,'Specialized');

INSERT INTO categories VALUES
(1,'Mountain Bikes'),
(2,'Road Bikes'),
(3,'Accessories');

INSERT INTO products VALUES
(1,'Trek Marlin 7',1,1,2022,850),
(2,'Giant Escape 3',2,2,2021,650),
(3,'Specialized Rockhopper',3,1,2023,950),
(4,'Bike Helmet',3,3,2022,120),
(5,'Cycling Gloves',2,3,2022,60);


INSERT INTO orders VALUES
(1,1,1,'2024-01-10',1),
(2,2,4,'2024-02-15',1),
(3,3,4,'2024-03-20',2),
(4,4,1,'2024-04-05',2);

INSERT INTO order_items VALUES
(1,1,1,1,850,0.05),
(2,2,2,2,650,0.10),
(3,2,4,1,120,0),
(4,3,3,1,950,0.08);

INSERT INTO stocks VALUES
(1,1,10),
(1,2,8),
(1,3,5),
(2,1,6),
(2,4,15),
(2,5,20);

SELECT * FROM customers;
SELECT * FROM orders;
SELECT * FROM products;
SELECT * FROM stocks;
SELECT * FROM stores;
SELECT * FROM brands;
SELECT * FROM categories;
SELECT * FROM order_items;




-- Level-1: Problem 1 - Basic Customer Order Report
-- Scenario:
-- The store manager wants a simple report showing customer orders along with their order dates and status. 
-- This report will help track pending and completed orders.
-- 📌 Requirements
-- 1. Retrieve customer first name, last name, order_id, order_date, and order_status.
-- 2. Display only orders with status Pending (1) or Completed (4).
-- 3. Sort the results by order_date in descending order. 
-- 🛠️ Technical Constraints
-- - Use SELECT statement.
-- - Use WHERE clause with logical operators (AND/OR).
-- - Use ORDER BY clause.
-- - Use INNER JOIN between customers and orders tables. 
-- Expectations:
-- Students should write a correct query using joins and filters, and properly order the result set.
-- 🎯 Learning Outcome 
-- Understand basic SELECT queries, filtering using WHERE conditions, logical operators, and sorting using ORDER BY clause with INNER JOIN.



-- customer orders, dates, status

SELECT c.first_name , c.last_name , o.order_id, o.order_date, o.order_status 
from customers c INNER JOIN orders o on c.customer_id = o.customer_id 
where o.order_status = 1 OR o.order_status= 4;



-- Level-1: Problem 2 - Product Price Listing by Category
-- Scenario:
-- The sales team wants a product listing categorized by product category along with brand details to understand product distribution.
-- 📌 Requirements
-- 1. Display product_name, brand_name, category_name, model_year, and list_price.
-- 2. Filter products with list_price greater than 500.
-- 3. Sort results by list_price in ascending order. 
-- 🛠️ Technical Constraints
-- - Use SELECT statement.
-- - Use WHERE clause.
-- - Use ORDER BY clause.
-- - Use INNER JOIN between products, brands, and categories tables. 
-- Expectations:
-- Students should correctly join multiple tables and apply filtering and sorting logic.
-- 🎯 Learning Outcome 
-- Learn multi-table joins, filtering numeric conditions, and sorting query results. 


-- product , brand, category

SELECT p.product_name , b.brand_name, c.category_name, p.model_year, p.list_price 
from products p INNER JOIN brands b on p.brand_id = b.brand_id
INNER JOIN  categories c on p.category_id = c.category_id
where p.list_price > 500
ORDER by p.list_price asc;









-- Level-2: Problem 1 - Store Wise Sales Summary
-- Scenario:
-- The regional manager wants to analyze total sales generated by each store.
-- 📌 Requirements
-- 1. Display store_name and total sales amount.
-- 2. Calculate total sales using (quantity * list_price * (1 - discount)).
-- 3. Include only completed orders (order_status = 4).
-- 4. Group results by store_name.
-- 5. Sort total sales in descending order.

-- 🛠️ Technical Constraints
-- - Use INNER JOIN between stores, orders, and order_items tables.
-- - Use GROUP BY clause.
-- - Use aggregate functions such as SUM().
-- - Use WHERE clause for filtering.
-- - Use ORDER BY clause. 
-- Expectations:
-- Students must write a grouped query with calculated columns and apply proper filtering.
-- 🎯 Learning Outcome 
-- Understand GROUP BY, aggregate functions, calculated fields, and filtering grouped data.



SELECT 
    s.store_name,
    SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN orders o ON s.store_id = o.store_id
INNER JOIN order_items oi ON o.order_id = oi.order_id
WHERE o.order_status = 4
GROUP BY s.store_name
ORDER BY total_sales DESC;






-- Level-2: Problem 2 - Product Stock and Sales Analysis
-- Scenario:
-- The inventory manager wants to compare stock availability and total quantity sold for each product.
-- 📌 Requirements
-- 1. Display product_name, store_name, available stock quantity, and total quantity sold.
-- 2. Include products even if they have not been sold (use appropriate join).
-- 3. Group results by product_name and store_name.
-- 4. Sort results by product_name.
-- 🛠️ Technical Constraints
-- - Use LEFT JOIN between stocks and order_items.
-- - Use INNER JOIN with products and stores tables.
-- - Use GROUP BY clause.
-- - Use SUM() aggregate function.
-- - Use ORDER BY clause.
-- Expectations:
-- Students should correctly use different join types (INNER and LEFT), grouping, and aggregate functions.
-- 🎯 Learning Outcome 
-- Develop strong understanding of different JOIN types (INNER, LEFT), aggregation, grouping data, and analyzing relational datasets.



SELECT 
    p.product_name,
    st.store_name,
    s.quantity AS stock_quantity,
    ISNULL(SUM(oi.quantity), 0) AS total_quantity_sold
FROM stocks s
INNER JOIN stores st ON s.store_id = st.store_id
INNER JOIN products p ON s.product_id = p.product_id
LEFT JOIN order_items oi ON s.store_id = oi.order_id
LEFT JOIN orders o ON oi.order_id = o.order_id AND o.store_id = s.store_id
GROUP BY p.product_name, st.store_name, s.quantity
ORDER BY p.product_name;