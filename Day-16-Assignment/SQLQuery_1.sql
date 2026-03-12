-- Assignment 1

-- 1. Create the view
CREATE VIEW vw_StudentDepartment AS
SELECT 
    S.StudentID,
    S.FirstName + ' ' + S.Surname AS StudentName,
    D.DepartmentName,
    S.AdmissionDate
FROM Students S
JOIN Departments D ON S.DepartmentID = D.DepartmentID;

-- 2. Retrieve all records
SELECT * FROM vw_StudentDepartment;

-- 3. Filter students from Computer Science
SELECT * FROM vw_StudentDepartment
WHERE DepartmentName = 'Computer Science';

-- 4. Drop the view
DROP VIEW vw_StudentDepartment;



-- Assignment 2

-- 1. Create view
CREATE VIEW vw_StudentCourses AS
SELECT 
    S.FirstName + ' ' + S.Surname AS StudentName,
    C.CourseName,
    E.EnrollmentDate
FROM Enrollments E
JOIN Students S ON E.StudentID = S.StudentID
JOIN Courses C ON E.CourseID = C.CourseID;

-- 2. Show courses taken by StudentID = 5
SELECT * FROM vw_StudentCourses
WHERE StudentName = (SELECT FirstName + ' ' + Surname FROM Students WHERE StudentID = 5);

-- 3. Count courses taken by each student
SELECT StudentName, COUNT(*) AS CourseCount
FROM vw_StudentCourses
GROUP BY StudentName;

-- 4. Students enrolled after 2024
SELECT * FROM vw_StudentCourses
WHERE EnrollmentDate > '2024-01-01';



--Assignment 3

-- 1. Create view
CREATE VIEW vw_ExamResults AS
SELECT 
    S.FirstName + ' ' + S.Surname AS StudentName,
    C.CourseName,
    Ex.ExamType,
    M.MarksObtained
FROM Marks M
JOIN Students S ON M.StudentID = S.StudentID
JOIN Exams Ex ON M.ExamID = Ex.ExamID
JOIN Courses C ON Ex.CourseID = C.CourseID;

-- 2. Retrieve students scoring more than 80
SELECT * FROM vw_ExamResults
WHERE MarksObtained > 80;

-- 3. Retrieve top scorers in each exam
SELECT *
FROM vw_ExamResults VR
WHERE MarksObtained = (
    SELECT MAX(MarksObtained) 
    FROM vw_ExamResults 
    WHERE CourseName = VR.CourseName AND ExamType = VR.ExamType
);

-- 4. Students who failed (Marks < 60)
SELECT * FROM vw_ExamResults
WHERE MarksObtained < 60;



-- Assignment 4

-- 1. Create view
CREATE VIEW vw_DepartmentStudentCount AS
SELECT 
    D.DepartmentName,
    COUNT(S.StudentID) AS TotalStudents
FROM Departments D
LEFT JOIN Students S ON D.DepartmentID = S.DepartmentID
GROUP BY D.DepartmentName;

-- 2. Retrieve departments with more than 10 students
SELECT * FROM vw_DepartmentStudentCount
WHERE TotalStudents > 10;

-- 3. Sort departments by highest student count
SELECT * FROM vw_DepartmentStudentCount
ORDER BY TotalStudents DESC;

-- 2. Stored Procedures Assignments
-- Assignment 1

CREATE PROCEDURE sp_InsertStudent
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Gender CHAR(1),
    @DepartmentID INT,
    @AdmissionDate DATE
AS
BEGIN
    INSERT INTO Students (FirstName, Surname, Gender, DepartmentID, AdmissionDate)
    VALUES (@FirstName, @LastName, @Gender, @DepartmentID, @AdmissionDate);
END;

-- Execute procedure
EXEC sp_InsertStudent 'Rohan','Khan','M',1,'2025-01-15';

-- Verify insertion
SELECT * FROM Students WHERE FirstName = 'Rohan' AND Surname = 'Khan';


-- Assignment 2

CREATE PROCEDURE sp_GetStudentsByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT StudentID, FirstName + ' ' + Surname AS StudentName, AdmissionDate
    FROM Students
    WHERE DepartmentID = @DepartmentID;
END;

-- Execute for DepartmentID = 2
EXEC sp_GetStudentsByDepartment 2;

-- Execute for DepartmentID = 3
EXEC sp_GetStudentsByDepartment 3;

-- Assignment 3

CREATE PROCEDURE sp_EnrollStudent
    @StudentID INT,
    @CourseID INT
AS
BEGIN
    INSERT INTO Enrollments (StudentID, CourseID, EnrollmentDate)
    VALUES (@StudentID, @CourseID, GETDATE());
END;

-- Example execution
EXEC sp_EnrollStudent 5, 2;


-- Assignment 4
CREATE PROCEDURE sp_GetStudentMarks
    @StudentID INT
AS
BEGIN
    SELECT 
        S.FirstName + ' ' + S.Surname AS StudentName,
        C.CourseName,
        Ex.ExamType,
        M.MarksObtained
    FROM Marks M
    JOIN Students S ON M.StudentID = S.StudentID
    JOIN Exams Ex ON M.ExamID = Ex.ExamID
    JOIN Courses C ON Ex.CourseID = C.CourseID
    WHERE S.StudentID = @StudentID;
END;

-- Execute example
EXEC sp_GetStudentMarks 5;


-- Assignment 5

CREATE PROCEDURE sp_UpdateMarks
    @MarkID INT,
    @NewMarks INT
AS
BEGIN
    UPDATE Marks
    SET MarksObtained = @NewMarks
    WHERE MarkID = @MarkID;

    -- Display updated result
    SELECT * FROM Marks WHERE MarkID = @MarkID;
END;

-- Example execution
EXEC sp_UpdateMarks 3, 88;


-- Assignment 6

CREATE PROCEDURE sp_DeleteEnrollment
    @EnrollmentID INT
AS
BEGIN
    DELETE FROM Enrollments
    WHERE EnrollmentID = @EnrollmentID;

    -- Verify deletion
    SELECT * FROM Enrollments WHERE EnrollmentID = @EnrollmentID;
END;

-- Example execution
EXEC sp_DeleteEnrollment 10;


-- 3. User Defined Functions Assignments
-- Assignment 1

CREATE FUNCTION fn_GetGrade(@MarksObtained INT)
RETURNS CHAR(1)
AS
BEGIN
    DECLARE @Grade CHAR(1);

    IF @MarksObtained >= 90
        SET @Grade = 'A';
    ELSE IF @MarksObtained >= 75
        SET @Grade = 'B';
    ELSE IF @MarksObtained >= 60
        SET @Grade = 'C';
    ELSE
        SET @Grade = 'F';

    RETURN @Grade;
END;

-- Usage example
SELECT StudentID, MarksObtained, dbo.fn_GetGrade(MarksObtained) AS Grade
FROM Marks;


-- Assignment 2

CREATE FUNCTION fn_GetStudentAge(@DateOfBirth DATE)
RETURNS INT
AS
BEGIN
    RETURN DATEDIFF(YEAR, @DateOfBirth, GETDATE());
END;

-- Usage example
SELECT FirstName + ' ' + Surname AS StudentName, dbo.fn_GetStudentAge(DateOfBirth) AS Age
FROM Students;


-- Assignment 3

CREATE FUNCTION fn_GetTotalMarks(@StudentID INT)
RETURNS INT
AS
BEGIN
    DECLARE @TotalMarks INT;
    SELECT @TotalMarks = SUM(MarksObtained) 
    FROM Marks
    WHERE StudentID = @StudentID;
    RETURN ISNULL(@TotalMarks, 0);
END;

-- Usage
SELECT dbo.fn_GetTotalMarks(5) AS TotalMarks;


-- Asignment 4

CREATE FUNCTION fn_GetStudentCourses(@StudentID INT)
RETURNS TABLE
AS
RETURN
(
    SELECT C.CourseName, E.EnrollmentDate
    FROM Enrollments E
    JOIN Courses C ON E.CourseID = C.CourseID
    WHERE E.StudentID = @StudentID
);

-- Usage
SELECT * FROM dbo.fn_GetStudentCourses(5);


-- Assignment 5

CREATE FUNCTION fn_GetDepartmentStudents(@DepartmentID INT)
RETURNS TABLE
AS
RETURN
(
    SELECT StudentID, FirstName + ' ' + Surname AS StudentName, AdmissionDate
    FROM Students
    WHERE DepartmentID = @DepartmentID
);

-- Usage
SELECT * FROM dbo.fn_GetDepartmentStudents(2);