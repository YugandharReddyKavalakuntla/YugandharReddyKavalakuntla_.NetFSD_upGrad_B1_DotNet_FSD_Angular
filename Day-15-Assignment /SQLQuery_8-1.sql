--Assignment5

-- 1. Students from Computer Science
SELECT * FROM Students S
JOIN Departments D ON S.DepartmentID = D.DepartmentID
WHERE D.DepartmentName = 'Computer Science';

-- 2. Teachers hired after 2022
SELECT * FROM Teachers WHERE HireDate > '2022-01-01';

-- 3. Students whose name starts with 'A'
SELECT * FROM Students WHERE FirstName LIKE 'A%';

-- 4. Courses with credits > 3
SELECT * FROM Courses WHERE Credits > 3;

-- 5. Students born between 2005 and 2008
SELECT * FROM Students WHERE DateOfBirth BETWEEN '2005-01-01' AND '2008-12-31';

-- 6. Students not in Mechanical department
SELECT * FROM Students S
JOIN Departments D ON S.DepartmentID = D.DepartmentID
WHERE D.DepartmentName <> 'Mechanical';

-- 7. Teachers with salary between 40000 and 70000
SELECT * FROM Teachers WHERE Salary BETWEEN 40000 AND 70000;

-- 8. Courses not taught by TeacherID = 3
SELECT * FROM Courses WHERE TeacherID <> 3;



-- Assignment6

-- 1. Count students in each department
SELECT DepartmentID, COUNT(*) AS StudentCount
FROM Students
GROUP BY DepartmentID;

-- 2. Average marks per exam
SELECT ExamID, AVG(MarksObtained) AS AvgMarks
FROM Marks
GROUP BY ExamID;

-- 3. Total students enrolled per course
SELECT CourseID, COUNT(*) AS TotalStudents
FROM Enrollments
GROUP BY CourseID;

-- 4. Maximum marks scored in each exam
SELECT ExamID, MAX(MarksObtained) AS MaxMarks
FROM Marks
GROUP BY ExamID;

-- 5. Minimum marks per course
SELECT E.CourseID, MIN(M.MarksObtained) AS MinMarks
FROM Marks M
JOIN Exams E ON M.ExamID = E.ExamID
GROUP BY E.CourseID;

-- 6. Departments with more than 5 students
SELECT DepartmentID, COUNT(*) AS StudentCount
FROM Students
GROUP BY DepartmentID
HAVING COUNT(*) > 5;



-- Assignment-7

-- 1. Students with department names
SELECT S.FirstName, S.Surname, D.DepartmentName
FROM Students S
JOIN Departments D ON S.DepartmentID = D.DepartmentID;

-- 2. Courses with teacher names
SELECT C.CourseName, T.TeacherName
FROM Courses C
JOIN Teachers T ON C.TeacherID = T.TeacherID;

-- 3. Student name and enrolled courses
SELECT S.FirstName, S.Surname, C.CourseName
FROM Enrollments E
JOIN Students S ON E.StudentID = S.StudentID
JOIN Courses C ON E.CourseID = C.CourseID;

-- 4. Students with exam marks
SELECT S.FirstName, S.Surname, E.ExamType, M.MarksObtained
FROM Marks M
JOIN Students S ON M.StudentID = S.StudentID
JOIN Exams E ON M.ExamID = E.ExamID;

-- 5. All courses and teachers (even if no teacher assigned)
SELECT C.CourseName, T.TeacherName
FROM Courses C
LEFT JOIN Teachers T ON C.TeacherID = T.TeacherID;

-- 6. Teachers not assigned to any course
SELECT T.TeacherName
FROM Teachers T
LEFT JOIN Courses C ON T.TeacherID = C.TeacherID
WHERE C.CourseID IS NULL;



-- Assignment 8

-- 1. Students with marks greater than average
SELECT StudentID, MarksObtained
FROM Marks
WHERE MarksObtained > (SELECT AVG(MarksObtained) FROM Marks);

-- 2. Courses with maximum credits
SELECT * FROM Courses
WHERE Credits = (SELECT MAX(Credits) FROM Courses);

-- 3. Students enrolled in more than 2 courses
SELECT StudentID
FROM Enrollments
GROUP BY StudentID
HAVING COUNT(*) > 2;

-- 4. Teachers in same department as 'John Smith'
SELECT * FROM Teachers
WHERE DepartmentID = (SELECT DepartmentID FROM Teachers WHERE TeacherName = 'John Smith');

-- 5. Students who scored highest marks in an exam
SELECT StudentID, ExamID, MarksObtained
FROM Marks
WHERE MarksObtained = (SELECT MAX(MarksObtained) FROM Marks WHERE ExamID = Marks.ExamID);

-- 6. Departments with maximum students
SELECT DepartmentID
FROM Students
GROUP BY DepartmentID
HAVING COUNT(*) = (SELECT MAX(StudentCount)
                   FROM (SELECT DepartmentID, COUNT(*) AS StudentCount
                         FROM Students
                         GROUP BY DepartmentID) AS DeptCounts);



-- Assignment 9
-- 1. Student basic info with department
CREATE VIEW View_StudentDept AS
SELECT S.StudentID, S.FirstName + ' ' + S.Surname AS StudentName, D.DepartmentName
FROM Students S
JOIN Departments D ON S.DepartmentID = D.DepartmentID;

-- 2. Student course enrollment view
CREATE VIEW View_StudentCourses AS
SELECT S.FirstName + ' ' + S.Surname AS StudentName, C.CourseName, E.EnrollmentDate
FROM Enrollments E
JOIN Students S ON E.StudentID = S.StudentID
JOIN Courses C ON E.CourseID = C.CourseID;

-- 3. Exam result view
CREATE VIEW View_ExamResults AS
SELECT S.FirstName + ' ' + S.Surname AS StudentName, C.CourseName, Ex.ExamType, M.MarksObtained
FROM Marks M
JOIN Students S ON M.StudentID = S.StudentID
JOIN Exams Ex ON M.ExamID = Ex.ExamID
JOIN Courses C ON Ex.CourseID = C.CourseID;

-- Query view example
SELECT * FROM View_StudentDept;

-- Drop view
DROP VIEW View_ExamResults;



-- Assignment 10

-- 1. Index on Student LastName
CREATE INDEX idx_Student_LastName ON Students(Surname);

-- 2. Index on Teacher Email
CREATE INDEX idx_Teacher_Email ON Teachers(Email);

-- 3. Composite index on StudentID + CourseID in Enrollments
CREATE INDEX idx_Enrollments_StudentCourse ON Enrollments(StudentID, CourseID);

-- 4. Unique index on DepartmentName
CREATE UNIQUE INDEX idx_Department_Name ON Departments(DepartmentName);

-- 5. Drop an index
DROP INDEX idx_Student_LastName ON Students;
