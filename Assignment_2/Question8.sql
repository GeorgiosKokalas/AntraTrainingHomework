/*
8. Display the customer ids who bought more than 100 Products with count of products.
*/

USE Northwind
GO

-- I am not sure if its total number of products purchased or number of products per purchase, so I am going with the former
WITH GoodCustomers
AS (
    SELECT DISTINCT o.CustomerID, SUM(od.Quantity) OVER(PARTITION BY o.CustomerID) [No of Items]
    FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID
    )
SELECT DISTINCT gc.CustomerID
FROM GoodCustomers gc
WHERE gc.[No of Items] > 100
