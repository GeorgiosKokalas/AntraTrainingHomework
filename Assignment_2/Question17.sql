/*
17. List all Customer Cities that have at least two customers.

a.   
 Use
union

b. 
 Use
sub-query and no union
*/

--a
USE Northwind
GO
  
--a I'll get back to it
SELECT cu.City
FROM Customers cu



--b  
SELECT cu.City
FROM ( 
        SELECT DISTINCT c.City, COUNT(c.ContactName) OVER(PARTITION BY c.City) [Number of Citizens]
        FROM Customers c 
     ) cu
WHERE cu.[Number of Citizens] >= 2
