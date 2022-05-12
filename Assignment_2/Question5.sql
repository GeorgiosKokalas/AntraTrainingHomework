/*
5. List all city names and number of customers in that city.
*/

USE Northwind
GO

SELECT City, COUNT(CustomerID) [Number of Customers]
FROM Customers
GROUP BY City
ORDER BY [Number of Customers] DESC
