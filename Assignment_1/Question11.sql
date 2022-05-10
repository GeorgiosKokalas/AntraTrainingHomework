/*
11. Write a query so you retrieve rows
that have a Name that begins with the letters SPO, but is then not followed by the letter K. After this zero or more letters can exists. Order the result set by the Name column.
*/

USE AdventureWorks2019
GO

SELECT "Name"
FROM Production.Product
WHERE "Name" LIKE 'spo[^k]%'
ORDER BY "Name" ASC
