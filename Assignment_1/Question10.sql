/*
10. Write a query that retrieves the columns Name and ListPrice
from the Production.Product table. Your result set should look something like the following. Order the result set
by the Name column. The products name should start with either 'A' or 'S'

Name                                            ListPrice
Adjustable Race                                   0,00
All-Purpose Bike Stand                       159,00
AWC Logo Cap                                      8,99
Seat Lug                                          0,00
Seat Post                                         0,00
*/

USE AdventureWorks2019
GO

SELECT TOP(5) "Name", "ListPrice"
FROM Production.Product
WHERE ("Name" LIKE 'A%'
        OR "Name" LIKE 'S%')
ORDER BY "Name" ASC
