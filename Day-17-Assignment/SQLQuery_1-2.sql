-- 3. Cursors Assignments
-- Assignment 1

CREATE PROCEDURE sp_DisplayStudentsCursor
AS
BEGIN
    DECLARE @StudentID INT, @StudentName NVARCHAR(100);

    DECLARE student_cursor CURSOR FOR
    SELECT StudentID, FirstName + ' ' + Surname FROM Students;

    OPEN student_cursor;
    FETCH NEXT FROM student_cursor INTO @StudentID, @StudentName;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT 'StudentID: ' + CAST(@StudentID AS NVARCHAR) + ', Name: ' + @StudentName;
        FETCH NEXT FROM student_cursor INTO @StudentID, @StudentName;
    END

    CLOSE student_cursor;
    DEALLOCATE student_cursor;
END;


EXEC sp_DisplayStudentsCursor;


-- Assignment 2
CREATE PROCEDURE sp_CalculateStudentTotalMarks
AS
BEGIN
    DECLARE @StudentID INT, @StudentName NVARCHAR(100), @TotalMarks INT;

    DECLARE student_cursor CURSOR FOR
    SELECT StudentID, FirstName + ' ' + Surname FROM Students;

    OPEN student_cursor;
    FETCH NEXT FROM student_cursor INTO @StudentID, @StudentName;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SELECT @TotalMarks = SUM(MarksObtained) 
        FROM Marks 
        WHERE StudentID = @StudentID;

        PRINT 'Student: ' + @StudentName + ', Total Marks: ' + CAST(ISNULL(@TotalMarks,0) AS NVARCHAR);

        FETCH NEXT FROM student_cursor INTO @StudentID, @StudentName;
    END

    CLOSE student_cursor;
    DEALLOCATE student_cursor;
END;


EXEC sp_CalculateStudentTotalMarks;


-- Assignment 3

CREATE PROCEDURE sp_UpdateCourseCredits
AS
BEGIN
    DECLARE @CourseID INT, @CourseName NVARCHAR(100), @Credits INT;

    DECLARE course_cursor CURSOR FOR
    SELECT CourseID, CourseName, Credits FROM Courses WHERE Credits < 3;

    OPEN course_cursor;
    FETCH NEXT FROM course_cursor INTO @CourseID, @CourseName, @Credits;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        UPDATE Courses
        SET Credits = Credits + 1
        WHERE CourseID = @CourseID;

        PRINT 'Updated ' + @CourseName + ' credits to ' + CAST(@Credits + 1 AS NVARCHAR);

        FETCH NEXT FROM course_cursor INTO @CourseID, @CourseName, @Credits;
    END

    CLOSE course_cursor;
    DEALLOCATE course_cursor;
END;


EXEC sp_UpdateCourseCredits;


-- Transcations

-- Assignment 1

CREATE PROCEDURE sp_EnrollStudentTransaction
    @StudentID INT,
    @CourseID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO Enrollments (StudentID, CourseID, EnrollmentDate)
        VALUES (@StudentID, @CourseID, GETDATE());

        COMMIT TRANSACTION;
        PRINT 'Enrollment successful.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END;


EXEC sp_EnrollStudentTransaction 5, 2;



-- Assignment 2

CREATE PROCEDURE sp_RecordExamMarks
    @StudentID INT,
    @ExamID INT,
    @MarksObtained INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO Marks (StudentID, ExamID, MarksObtained)
        VALUES (@StudentID, @ExamID, @MarksObtained);

        UPDATE Exams
        SET ExamDate = GETDATE()
        WHERE ExamID = @ExamID;

        COMMIT TRANSACTION;
        PRINT 'Marks recorded successfully.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END;


EXEC sp_RecordExamMarks 5, 1, 90;

-- Assignment 3
CREATE PROCEDURE sp_TransferStudentDepartment
    @StudentID INT,
    @NewDepartmentID INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verify department exists
        IF NOT EXISTS (SELECT 1 FROM Departments WHERE DepartmentID = @NewDepartmentID)
            THROW 50000, 'Department does not exist.', 1;

        -- Update student department
        UPDATE Students
        SET DepartmentID = @NewDepartmentID
        WHERE StudentID = @StudentID;

        COMMIT TRANSACTION;
        PRINT 'Student department updated successfully.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END;


EXEC sp_TransferStudentDepartment 5, 3;