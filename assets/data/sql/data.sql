-- Inserting data into Students Table
INSERT INTO Students (Id, FirstName, LastName, Email, Phone) VALUES
(1, 'Alice', 'Smith', 'alice.smith@example.com', '123-456-7890'),
(2, 'Bob', 'Johnson', 'bob.johnson@example.com', '234-567-8901'),
(3, 'Charlie', 'Williams', 'charlie.williams@example.com', '345-678-9012'),
(4, 'David', 'Jones', 'david.jones@example.com', '456-789-0123'),
(5, 'Eve', 'Brown', 'eve.brown@example.com', '567-890-1234');

-- Inserting data into Semesters Table
INSERT INTO Semesters (Id, Name) VALUES
(1, 'Fall 2024'),
(2, 'Spring 2024'),
(3, 'Summer 2024'),
(4, 'Fall 2023'),
(5, 'Spring 2023');

-- Inserting data into Teachers Table
INSERT INTO Teachers (Id, FirstName, LastName, Email, Phone) VALUES
(1, 'John', 'Doe', 'john.doe@example.com', '678-901-2345'),
(2, 'Jane', 'Smith', 'jane.smith@example.com', '789-012-3456'),
(3, 'Michael', 'Johnson', 'michael.johnson@example.com', '890-123-4567'),
(4, 'Emily', 'Davis', 'emily.davis@example.com', '901-234-5678'),
(5, 'Daniel', 'Wilson', 'daniel.wilson@example.com', '012-345-6789');

-- Inserting data into Courses Table
INSERT INTO Courses (Id, Name) VALUES
(1, 'Mathematics 101'),
(2, 'Physics 101'),
(3, 'Chemistry 101'),
(4, 'Biology 101'),
(5, 'Computer Science 101');

-- Inserting data into Classes Table
INSERT INTO Classes (Id, Year, SemesterId, TeacherId, CourseId) VALUES
(1, '2024-09-01', 1, 1, 1),
(2, '2024-09-01', 1, 2, 2),
(3, '2024-01-15', 2, 3, 3),
(4, '2023-09-01', 4, 4, 4),
(5, '2024-01-15', 2, 5, 5);

-- Inserting data into Enrollments Table
INSERT INTO Enrollments (Id, Status, StudentId, ClassId) VALUES
(1, 'PAID', 1, 1),
(2, 'PENDING', 2, 2),
(3, 'PAID', 3, 3),
(4, 'PENDING', 4, 4),
(5, 'PAID', 5, 5);

-- Inserting data into Degrees Table
INSERT INTO Degrees (Id, Name, UniversityId) VALUES
(1, 'Bachelor of Science', 1),
(2, 'Bachelor of Arts', 1),
(3, 'Master of Science', 2),
(4, 'Master of Arts', 2),
(5, 'Doctor of Philosophy', 3);

-- Inserting data into Universities Table
INSERT INTO Universities (Id, Name, ProvostName) VALUES
(1, 'University of Example', 'Dr. Example'),
(2, 'Example State University', 'Dr. State'),
(3, 'Example Institute of Technology', 'Dr. Tech'),
(4, 'Example Community College', 'Dr. Community'),
(5, 'Example Online University', 'Dr. Online');

-- Inserting data into CourseDegreePivot Table
INSERT INTO CourseDegreePivot (IdCourse, IdDegree) VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 3),
(5, 4);