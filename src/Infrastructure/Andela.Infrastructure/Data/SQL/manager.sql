-- Active: 1721868519822@@127.0.0.1@3306@bc4mqniikcg2ruxesufj
DROP Table `Students`;
SET FOREIGN_KEY_CHECKS=1;

-----## Students Table ##-----
CREATE TABLE Students (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(125)
);

-----## Students Data ##-----
INSERT INTO Students (`Name`) VALUES
('Carlos Marulanda'),
('Runtrafan Sail'),
('Minitu Mulan');