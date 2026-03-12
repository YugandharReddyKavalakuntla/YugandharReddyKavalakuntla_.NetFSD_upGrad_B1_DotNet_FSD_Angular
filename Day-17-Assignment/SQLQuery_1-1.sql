-- 2. Exception Handling Assignments
-- Assignment 1


CREATE PROCEDURE sp_AddStudent
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Gender CHAR(1),
    @DepartmentID INT,
    @AdmissionDate DATE
AS
BEGIN
    BEGIN TRY
        INSERT INTO Students (FirstName, Surname, Gender, DepartmentID, AdmissionDate)
        VALUES (@FirstName, @LastName, @Gender, @DepartmentID, @AdmissionDate);
    END TRY
    BEGIN CATCH
        PRINT 'Error Occurred: ' + ERROR_MESSAGE();
    END CATCH
END;

EXEC sp_AddStudent 'John','Doe','M',1,'2025-01-01';


EXEC sp_AddStudent 'Jane','Doe','F',999,'2025-01-01';

-- Assignment 2

CREATE PROCEDURE sp_InsertMarks
    @StudentID INT,
    @ExamID INT,
    @MarksObtained INT
AS
BEGIN
    IF @MarksObtained < 0 OR @MarksObtained > 100
    BEGIN
        RAISERROR('Invalid Marks: Must be between 0 and 100',16,1);
        RETURN;
    END
    INSERT INTO Marks (StudentID, ExamID, MarksObtained)
    VALUES (@StudentID, @ExamID, @MarksObtained);
END;


EXEC sp_InsertMarks 2,1,85;


EXEC sp_InsertMarks 2,1,120;



-- Assignment 3

CREATE PROCEDURE sp_DeleteStudent
    @StudentID INT
AS
BEGIN
    BEGIN TRY
        DELETE FROM Students WHERE StudentID = @StudentID;
        PRINT 'Student deleted successfully.';
    END TRY
    BEGIN CATCH
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END;


EXEC sp_DeleteStudent 1;


EXEC sp_DeleteStudent 100;


