/*
6. List city names which have more than 2 customers, and number of customers in that city
*/

USE Northwind
GO

WITH PopularCities
AS (
    SELECT ShipCity, COUNT(o.CustomerID) [No of Customers]
    FROM Orders o
    GROUP BY ShipCity
    HAVING COUNT(o.CustomerID) > 2
    )
SELECT ShipCity
FROM PopularCities
