---Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, with no filter. 
USE AdventureWorks2019
GO

SELECT ProductID, "Name",Color, ListPrice 
FROM Production.Product
