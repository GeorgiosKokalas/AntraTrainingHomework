/*
15. List all cities that have Customers but no Employee.
a.
 Use
sub-query

b.
 Do
not use sub-query
*/

--a
USE Northwind
GO
  
SELECT DISTINCT c.City 
FROM Customers c
WHERE c.City NOT IN (
    SELECT e.City
    FROM Employees e)


-- bee
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL
