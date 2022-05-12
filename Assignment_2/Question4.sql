/*
4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
*/

USE Northwind
GO

WITH ship as (
    SELECT TOP 5 ISNULL(o.ShipPostalCode, 'n/a') [ShipPostalCode], SUM(od.Quantity) [a lot of orders]
    FROM [Order Details] od JOIN Orders o ON od.OrderID = o.OrderID
    WHERE DATEDIFF(year, GETDATE(), o.OrderDate) >= -25
    GROUP BY o.ShipPostalCode
    ORDER BY SUM(od.Quantity) DESC
)
SELECT ship.ShipPostalCode
FROM ship
