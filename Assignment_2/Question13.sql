/*
13. Display the customers and suppliers by city. The results should have the following columns
City
Name
Contact Name,
Type (Customer or Supplier)
*/

USE Northwind
GO
  
SELECT c.City, c.ContactName, 'Customer' [Type]
FROM Customers c 
UNION
SELECT e.City, e.FirstName + ' ' + e.LastName, 'Employee'
FROM Employees e
