/*
16. List all products and their total order quantities throughout all orders.
*/

USE Northwind
GO
  
SELECT DISTINCT p.ProductName, SUM(Quantity) OVER(PARTITION BY p.ProductName) [Number of Sales]
FROM Products p JOIN [Order Details] od ON p.ProductID=od.ProductID
