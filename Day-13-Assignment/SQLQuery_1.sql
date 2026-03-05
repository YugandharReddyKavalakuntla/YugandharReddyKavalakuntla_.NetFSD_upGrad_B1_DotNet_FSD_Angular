SELECT * from Bonus;

SELECT * from Customers;

SELECT * from Orders;

SELECT * from Title;

SELECT * from Worker;

-- 1. Write an SQL query to fetch “FIRST_NAME” from Worker table using the alias name as <WORKER_NAME>.
SELECT first_name as worker_name from Worker;

-- 2. Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.
SELECT UPPER(FIRST_NAME) from Worker;

-- 3. Write an SQL query to fetch unique values of DEPARTMENT from Worker table.
SELECT distinct DEPARTMENT from Worker;

-- 4. Write an SQL query to print the first three characters of  FIRST_NAME from Worker table.
SELECT left(FIRST_NAME, 3) from worker;

-- 5. Write an SQL query to find the position of the alphabet (‘a’) in the first name column ‘Amitabh’ from Worker table.
SELECT CHARINDEX('a', FIRST_NAME) as POSITION from Worker
where FIRST_NAME = 'Amitabh'

-- 6. Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.
SELECT RTRIM(first_name) from Worker;

-- 7. Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.
SELECT RTRIM(first_name) from Worker; 

-- 8. Write an SQL query that fetches the unique values of DEPARTMENT from Worker table and prints its length.
SELECT distinct FIRST_NAME, len(first_name) as lengths from Worker;

-- 9. Write an SQL query to print the FIRST_NAME from Worker table after replacing ‘a’ with ‘A’.
SELECT REPLACE(FIRST_NAME , 'a' , 'A') from Worker;

-- 10. Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char should separate them.
SELECT (FIRST_NAME  + ' ' + LAST_NAME) as Complete_name from Worker;

-- 11. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending.
SELECT * from Worker 
order by FIRST_NAME ;

-- 12. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending.
SELECT * from Worker 
order by FIRST_NAME , DEPARTMENT desc;


-- 13. Write an SQL query to print details for Workers with the first name as “Vipul” and “Satish” from Worker table.
SELECT * from Worker
where FIRST_NAME in ('Vipul' , 'satish');

-- 14. Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.
SELECT * from Worker
where FIRST_NAME not in ('Vipul' , 'satish');

-- 15. Write an SQL query to print details of Workers with DEPARTMENT name as “Admin”.
SELECT * from Worker
where DEPARTMENT = 'Admin';

-- 16. Write an SQL query to print details of the Workers whose FIRST_NAME contains ‘a’.
SELECT * from Worker
where FIRST_NAME like 'a%';

-- 17. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘a’.
SELECT * from Worker
where FIRST_NAME like '%a';

-- 18. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six alphabets.
SELECT * from Worker
where FIRST_NAME like '%h'
AND LEN(FIRST_NAME) =6  ;

-- 19. Write an SQL query to print details of the Workers whose SALARY lies between 100000 and 500000.
SELECT * FROM Worker
where SALARY BETWEEN 10000 and 500000;

-- 20. Write an SQL query to print details of the Workers who have joined in Feb’2014.
SELECT * FROM Worker
where JOINING_DATE BETWEEN '2014-02-01' and '2014-02-28';

-- 21. Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000.
SELECT FIRST_NAME, SALARY
FROM Worker
WHERE SALARY BETWEEN 50000 AND 100000;

-- 22. Write an SQL query to fetch the no. of workers for each department in the descending order.
SELECT DEPARTMENT, count(WORKER_ID) as NO_OF_Workers 
from Worker
 GROUP BY DEPARTMENT
 ORDER by count(WORKER_ID) desc;

-- 23. Write an SQL query to print details of the Workers who are also Managers
SELECT w.* from Worker w
join Title t 
on w.WORKER_ID = t.WORKER_REF_ID
where t.WORKER_TITLE = 'manager';

-- 24.Write an SQL query to show the current date and time.
SELECT GETDATE() as CURRENT_DATE_Time;

-- 25.Write an SQL query to show the top n (say 10) records of a table.
SELECT top 3 * from Worker;



