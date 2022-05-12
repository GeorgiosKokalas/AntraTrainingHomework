/*
19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it
*/

--I'll get to it later
USE Northwind
GO

WITH PopIDs
AS  (
    SELECT TOP 5 od1.ProductID, COUNT(od1.OrderID) [Number of Orders], AVG(od1.UnitPrice) [Average Price]
    FROM [Order Details] od1 JOIN Orders o1 ON od1.OrderID = o1.OrderID
    GROUP BY od1.ProductID
    ORDER BY [Number of Orders] DESC
    )
SELECT pr.ProductName, pi.[Average Price]
FROM Products pr JOIN PopIds pi ON pi.ProductID=pr.ProductID


