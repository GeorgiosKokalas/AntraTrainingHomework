/*
11. Displays pairs of employees who have the same job title.
*/

USE Northwind
GO

SELECT e1.FirstName + ' ' + e1.LastName [Employee1],  e2.FirstName + ' ' + e2.LastName [Employee2]
From Employees e1 CROSS JOIN Employees e2 
WHERE e1.Title = e2.Title
    AND e1.LastName != e2.LastName
