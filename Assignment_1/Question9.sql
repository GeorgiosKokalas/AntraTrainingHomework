/*
9. Write a query to get a result set on products that begins
with the letter S. 
*/

USE AdventureWorks2019
GO

SELECT *
FROM Production.Product
WHERE "Name" LIKE 'S%'
