/*
18. List all Customer Cities that have ordered at least two different kinds of products.
*/

--a
USE Northwind
GO

-- WITH  Cities
-- AS( 

WITH Cities
AS (
    SELECT DISTINCT cu.City, od.ProductID
    FROM Customers cu JOIN Orders o ON cu.CustomerID=o.CustomerID 
                      JOIN [Order Details] od ON od.OrderID =o.OrderID
   ),
Cities2
AS(
    SELECT c.City, COUNT(c.ProductID)[Product Count]
    FROM Cities c
    GROUP BY c.City
    HAVING COUNT(c.ProductID) >= 2
    )
SELECT c2.City
FROM Cities2 c2
