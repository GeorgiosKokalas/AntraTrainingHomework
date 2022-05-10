/*
5. Write a query that concatenates the columns Name and Color
from the Production.Product table by excluding the rows that are null for color.
*/

USE AdventureWorks2019
GO

SELECT "Name" + "Color" AS "Name and Color" 
FROM Production.Product
WHERE "Color" IS NOT NULL
