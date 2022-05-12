/*
List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered
from. (tip: join  sub-query)
*/

USE Northwind
GO

WITH ge
AS(
SELECT e.City
FROM Employees e JOIN (SELECT TOP 1 o.EmployeeID, COUNT(o.OrderID) [no orders]
FROM Orders o 
GROUP BY o.EmployeeID
ORDER BY COUNT(o.OrderID) DESC) e2 ON e.EmployeeID = e2.EmployeeID
),
gc AS(
SELECT TOP 1 o.shipCity, SUM(od.Quantity) [a lot of orders]
FROM [Order Details] od JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY o.ShipCity
ORDER BY SUM(od.Quantity) DESC
)
SELECT  ge.City[Employee City], gc.ShipCity[Buyer City]
FROM ge CROSS JOIN gc
