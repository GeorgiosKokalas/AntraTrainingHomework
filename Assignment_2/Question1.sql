/*
1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the
following.

    Country                        Province
*/

USE AdventureWorks2019
GO

SELECT cr.Name [Country], sp.Name [Province]
FROM Person.CountryRegion cr JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
