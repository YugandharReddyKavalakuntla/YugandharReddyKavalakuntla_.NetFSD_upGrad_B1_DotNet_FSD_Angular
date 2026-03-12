-- Assignment 3


-- 1. Add PhoneNumber to Students
ALTER TABLE Students ADD PhoneNumber NVARCHAR(15);

-- 2. Add Salary to Teachers
ALTER TABLE Teachers ADD Salary DECIMAL(10,2);

-- 3. Modify Salary datatype
ALTER TABLE Teachers ALTER COLUMN Salary DECIMAL(12,2);

-- 4. Add CHECK constraint to Salary
ALTER TABLE Teachers
ADD CONSTRAINT CHK_Salary CHECK (Salary > 20000);

-- 5. Drop PhoneNumber column
ALTER TABLE Students DROP COLUMN PhoneNumber;

-- 6. Rename column (example: LastName to Surname)
EXEC sp_rename 'Students.LastName', 'Surname', 'COLUMN';