/*
12. Write a query that retrieves the unique combination of
columns ProductSubcategoryID and Color from the Production.Product table. We do not want any rows that are NULL.in any of the two columns in the result. (Hint: Use IsNull)
*/

USE AdventureWorks2019
GO

SELECT ISNULL("ProductSubcategoryID", 0), ISNULL("Color", 'Transparent')
FROM Production.Product
