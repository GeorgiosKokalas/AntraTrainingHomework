/*
8. Write a query to retrieve the to the columns  ProductID,
Name and color from the Production.Product table restricted to the colors black and blue
*/

USE AdventureWorks2019
GO

SELECT "ProductID", "Name", "Color"
FROM Production.Product
WHERE "Color" IN ('Black', 'Blue')
