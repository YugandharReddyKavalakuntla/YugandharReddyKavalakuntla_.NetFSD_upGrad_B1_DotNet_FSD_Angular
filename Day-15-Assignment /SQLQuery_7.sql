--  Day15 Assignment 1

-- 1. Departments Table
CREATE TABLE Departments (
    DepartmentID INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName NVARCHAR(100) UNIQUE,
    Location NVARCHAR(100)
);

-- 2. Teachers Table
CREATE TABLE Teachers (
    TeacherID INT IDENTITY(1,1) PRIMARY KEY,
    TeacherName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    DepartmentID INT,
    HireDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- 3. Students Table
CREATE TABLE Students (
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    DateOfBirth DATE,
    Gender CHAR(1) CHECK (Gender IN ('M','F')),
    DepartmentID INT,
    AdmissionDate DATE DEFAULT GETDATE(),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- 4. Courses Table
CREATE TABLE Courses (
    CourseID INT IDENTITY(1,1) PRIMARY KEY,
    CourseName NVARCHAR(100),
    Credits INT CHECK (Credits BETWEEN 1 AND 5),
    DepartmentID INT,
    TeacherID INT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
    FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID)
);

-- 5. Enrollments Table
CREATE TABLE Enrollments (
    EnrollmentID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    EnrollmentDate DATE DEFAULT GETDATE(),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

-- 6. Exams Table
CREATE TABLE Exams (
    ExamID INT IDENTITY(1,1) PRIMARY KEY,
    CourseID INT,
    ExamDate DATE,
    ExamType NVARCHAR(50),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

-- 7. Marks Table
CREATE TABLE Marks (
    MarkID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ExamID INT,
    MarksObtained INT CHECK (MarksObtained BETWEEN 0 AND 100),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
);