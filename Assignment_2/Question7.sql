/*
7. Display the names of all customers  along with the  count of products they bought
*/

USE Northwind
GO

SELECT c.ContactName, COUNT(o.OrderID) [No of Orders]
FROM Orders o JOIN Customers c ON c.CustomerID = o.CustomerID
GROUP BY ContactName

