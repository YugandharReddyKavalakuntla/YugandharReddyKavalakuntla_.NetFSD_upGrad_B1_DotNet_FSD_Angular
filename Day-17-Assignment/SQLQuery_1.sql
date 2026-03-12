-- 1. Triggers Assignments
-- Assignment 1


CREATE TABLE StudentAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ActionType NVARCHAR(20),
    ActionDate DATETIME DEFAULT GETDATE()
);


CREATE TRIGGER trg_StudentInsertAudit
ON Students
AFTER INSERT
AS
BEGIN
    INSERT INTO StudentAudit (StudentID, ActionType)
    SELECT StudentID, 'INSERT'
    FROM inserted;
END;


INSERT INTO Students (FirstName, Surname, Gender, DepartmentID, AdmissionDate)
VALUES ('Test', 'Student', 'M', 1, GETDATE());


SELECT * FROM StudentAudit;


INSERT INTO Students (FirstName, Surname, Gender, DepartmentID, AdmissionDate)
VALUES 
('Alice','Test','F',1,GETDATE()),
('Bob','Test','M',2,GETDATE());

SELECT * FROM StudentAudit;


-- Assignment 2

CREATE TRIGGER trg_PreventStudentDelete
ON Students
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Enrollments E JOIN deleted D ON E.StudentID = D.StudentID)
    BEGIN
        RAISERROR('Student has course enrollments and cannot be deleted', 16, 1);
        ROLLBACK;
    END
    ELSE
    BEGIN
        DELETE FROM Students
        WHERE StudentID IN (SELECT StudentID FROM deleted);
    END
END;


DELETE FROM Students WHERE StudentID = 1;


DELETE FROM Students WHERE StudentID = 100; 


-- Assignment 3


CREATE TABLE MarksAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ExamID INT,
    OldMarks INT,
    NewMarks INT,
    UpdatedDate DATETIME DEFAULT GETDATE()
);


CREATE TRIGGER trg_UpdateMarksAudit
ON Marks
AFTER UPDATE
AS
BEGIN
    INSERT INTO MarksAudit (StudentID, ExamID, OldMarks, NewMarks)
    SELECT i.StudentID, i.ExamID, d.MarksObtained, i.MarksObtained
    FROM inserted i
    JOIN deleted d ON i.MarkID = d.MarkID;
END;


UPDATE Marks SET MarksObtained = 95 WHERE MarkID = 1;


SELECT * FROM MarksAudit;