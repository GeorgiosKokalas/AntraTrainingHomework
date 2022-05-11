/*
3. List all Products that has been sold at least once in last 25 years.
*/

USE Northwind
GO

SELECT DISTINCT p.ProductName 
FROM Orders o INNER JOIN [Order Details] od ON od.OrderID = o.OrderID INNER JOIN Products p ON p.ProductID = od.ProductID
WHERE DATEDIFF(year, GETDATE(), o.OrderDate) >= -25
