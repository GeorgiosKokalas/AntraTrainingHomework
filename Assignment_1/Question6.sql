/*
6. Write a query that generates the following result set from
Production.Product:

NAME: LL Crankarm  --  COLOR: Black

NAME: ML Crankarm  --  COLOR: Black

NAME: HL Crankarm  --  COLOR: Black

NAME: Chainring Bolts  --  COLOR: Silver

NAME: Chainring Nut  --  COLOR: Silver

NAME: Chainring  --  COLOR: Black
*/

USE AdventureWorks2019
GO

SELECT "Name", "Color" 
FROM Production.Product
WHERE "Color" IN ('Black', 'Silver')
    AND ("Name" LIKE('%Crankarm')
      OR "Name" LIKE('Chainring%'))
ORDER BY "Name" DESC
