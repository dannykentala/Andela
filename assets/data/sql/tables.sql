-- Active: 1722269449582@@127.0.0.1@3306@b8b4nboyx5zcptwzyo9f

-- Students Table
CREATE TABLE Students (
  Id INT PRIMARY KEY,
  FirstName VARCHAR(255),
  LastName VARCHAR(255),
  Email VARCHAR(125),
  Phone VARCHAR(60)
);

-- Enrollments Table
CREATE TABLE Enrollments (
  Id INT PRIMARY KEY,
  Status ENUM('PAID', 'PENDING'),
  StudentId INT,
  ClassId INT,
  FOREIGN KEY (StudentId) REFERENCES Students(Id),
  FOREIGN KEY (ClassId) REFERENCES Classes(Id)
);

-- Semesters Table
CREATE TABLE Semesters (
  Id INT PRIMARY KEY,
  Name VARCHAR(30)
);

-- Teachers Table
CREATE TABLE Teachers (
  Id INT PRIMARY KEY,
  FirstName VARCHAR(255),
  LastName VARCHAR(255),
  Email VARCHAR(125),
  Phone VARCHAR(60)
);

-- Classes Table
CREATE TABLE Classes (
  Id INT PRIMARY KEY,
  Year DATE,
  SemesterId INT,
  TeacherId INT,
  CourseId INT,
  FOREIGN KEY (SemesterId) REFERENCES Semesters(Id),
  FOREIGN KEY (TeacherId) REFERENCES Teachers(Id),
  FOREIGN KEY (CourseId) REFERENCES Courses(Id)
);

-- Courses Table
CREATE TABLE Courses (
  Id INT PRIMARY KEY,
  Name VARCHAR(255)
);

-- Degrees Table
CREATE TABLE Degrees (
  Id INT PRIMARY KEY,
  Name VARCHAR(255),
  UniversityId INT,
  FOREIGN KEY (UniversityId) REFERENCES Universities(Id)
);

-- Universities Table
CREATE TABLE Universities (
  Id INT PRIMARY KEY,
  Name VARCHAR(255),
  ProvostName VARCHAR(255)
);

-- CourseDegreePivot Table
CREATE TABLE CourseDegreePivot (
  IdCourse INT,
  IdDegree INT,
  FOREIGN KEY (IdCourse) REFERENCES Courses(Id),
  FOREIGN KEY (IdDegree) REFERENCES Degrees(Id)
);