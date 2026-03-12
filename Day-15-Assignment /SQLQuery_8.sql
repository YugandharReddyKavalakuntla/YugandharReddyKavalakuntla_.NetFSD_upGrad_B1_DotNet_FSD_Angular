--Assignment4 

-- Departments
INSERT INTO Departments (DepartmentName, Location) VALUES
('Computer Science','Building A'),
('Mechanical','Building B'),
('Electrical','Building C'),
('Civil','Building D'),
('Mathematics','Building E');

-- Teachers
INSERT INTO Teachers (TeacherName, Email, DepartmentID, HireDate, Salary) VALUES
('John Smith','john.smith@email.com',1,'2023-01-10',50000),
('Alice Brown','alice.brown@email.com',1,'2022-05-20',55000),
('Robert Green','robert.green@email.com',2,'2021-07-15',60000),
('Emma White','emma.white@email.com',2,'2023-03-12',45000),
('Michael Black','michael.black@email.com',3,'2022-09-01',70000),
('Laura Grey','laura.grey@email.com',4,'2021-11-18',48000),
('David Blue','david.blue@email.com',5,'2020-12-22',52000),
('Sophia Yellow','sophia.yellow@email.com',3,'2023-02-28',53000),
('Daniel Red','daniel.red@email.com',4,'2022-08-08',47000),
('Olivia Pink','olivia.pink@email.com',5,'2021-06-14',55000);

-- Students (20 sample)
INSERT INTO Students (FirstName,Surname,DateOfBirth,Gender,DepartmentID,AdmissionDate) VALUES
('Amit','Sharma','2006-02-15','M',1,'2022-08-01'),
('Anjali','Verma','2005-11-22','F',1,'2021-08-01'),
('Rahul','Kumar','2007-05-12','M',2,'2023-01-10'),
('Sneha','Patel','2006-09-30','F',2,'2022-09-01'),
('Vikram','Singh','2005-12-10','M',3,'2021-07-15'),
('Priya','Gupta','2006-03-25','F',3,'2022-08-01'),
('Rohit','Mehta','2007-01-14','M',4,'2023-02-01'),
('Neha','Rao','2005-10-20','F',4,'2021-06-15'),
('Karan','Joshi','2006-08-08','M',5,'2022-09-10'),
('Isha','Shah','2007-04-18','F',5,'2023-01-20'),
('Aditya','Singh','2005-05-25','M',1,'2021-08-15'),
('Aanya','Kaur','2006-06-30','F',1,'2022-09-12'),
('Rajat','Verma','2007-07-07','M',2,'2023-02-05'),
('Simran','Malhotra','2005-09-18','F',2,'2021-07-20'),
('Kabir','Chopra','2006-11-01','M',3,'2022-08-22'),
('Tanya','Bhatia','2007-03-14','F',3,'2023-01-12'),
('Arjun','Reddy','2005-02-09','M',4,'2021-06-28'),
('Maya','Desai','2006-12-21','F',4,'2022-08-11'),
('Dev','Kapoor','2007-10-05','M',5,'2023-02-14'),
('Rhea','Nair','2005-01-30','F',5,'2021-07-18');

-- Courses (10 sample)
INSERT INTO Courses (CourseName, Credits, DepartmentID, TeacherID) VALUES
('Database Systems',3,1,1),
('Algorithms',4,1,2),
('Thermodynamics',3,2,3),
('Mechanics',4,2,4),
('Circuits',3,3,5),
('Electromagnetics',4,3,8),
('Structural Analysis',3,4,6),
('Concrete Technology',4,4,9),
('Calculus',3,5,7),
('Linear Algebra',4,5,10);

-- Enrollments (30 sample)
INSERT INTO Enrollments (StudentID, CourseID) VALUES
(1,1),(1,2),(2,1),(2,2),(3,3),(3,4),(4,3),(4,4),(5,5),(5,6),
(6,5),(6,6),(7,7),(7,8),(8,7),(8,8),(9,9),(9,10),(10,9),(10,10),
(11,1),(11,2),(12,1),(12,2),(13,3),(13,4),(14,3),(14,4),(15,5),(15,6);

-- Exams (5 sample)
INSERT INTO Exams (CourseID, ExamDate, ExamType) VALUES
(1,'2023-12-01','Midterm'),
(2,'2023-12-05','Final'),
(3,'2023-11-25','Midterm'),
(4,'2023-11-28','Final'),
(5,'2023-12-02','Midterm');

-- Marks (30 sample)
INSERT INTO Marks (StudentID, ExamID, MarksObtained) VALUES
(1,1,85),(2,1,90),(3,3,75),(4,3,80),(5,5,95),
(6,5,88),(7,4,70),(8,4,78),(9,2,82),(10,2,85),
(11,1,88),(12,2,92),(13,3,77),(14,4,79),(15,5,91),
(1,2,87),(2,3,89),(3,4,76),(4,5,83),(5,1,80),
(6,2,84),(7,3,72),(8,4,81),(9,5,90),(10,1,86),
(11,3,75),(12,4,88),(13,5,92),(14,1,79),(15,2,85);