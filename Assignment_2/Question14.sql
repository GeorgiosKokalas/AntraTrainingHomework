/*
14. List all cities that have both Employees and Customers.
*/

USE Northwind
GO
  
SELECT DISTINCT c.City 
FROM Customers c INNER JOIN Employees e ON e.City = c.City
