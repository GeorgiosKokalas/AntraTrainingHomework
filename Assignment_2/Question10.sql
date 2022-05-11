/*
10. Display the products order each day. Show Order date and Product Name.
*/

USE Northwind
GO

SELECT DISTINCT o.OrderDate, pr.ProductName
FROM Suppliers sp INNER JOIN Products pr ON pr.SupplierID = sp.SupplierID 
                  INNER JOIN [Order Details] od ON od.ProductID = pr.ProductID
                  INNER JOIN [Orders] o ON o.OrderID = od.OrderID
ORDER BY o.OrderDate DESC
