/*
7. Write a query to retrieve the to the columns ProductID and Name from the Production.Product table filtered by ProductID from 400 to 500 using between
*/

USE AdventureWorks2019
GO

SELECT "ProductID", "Name"
FROM Production.Product
WHERE "ProductID" BETWEEN 400 AND 500
