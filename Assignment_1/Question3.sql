/*
3. Write a query that retrieves the columns ProductID, Name,
Color and ListPrice from the Production.Product table, the rows that are not NULL for the Color column.
*/

USE AdventureWorks2019
GO

SELECT "ProductID", "Name","Color", "ListPrice" 
FROM Production.Product
WHERE "Color" IS NOT NULL
