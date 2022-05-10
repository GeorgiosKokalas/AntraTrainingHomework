/*
2. Write a query that retrieves the
columns ProductID, Name, Color and ListPrice from the Production.Product table,
excluding the rows that ListPrice is 0.
*/

USE AdventureWorks2019
GO

SELECT ProductID, "Name",Color, ListPrice 
FROM Production.Product
WHERE ListPrice != 0
