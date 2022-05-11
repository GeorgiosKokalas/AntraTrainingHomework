/*
2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
Join them and produce a result set similar to the following.
    Country                        Province
*/

USE AdventureWorks2019
GO

WITH FilteredCountry
AS (SELECT [Name], CountryRegionCode
    FROM Person.CountryRegion
    WHERE [Name] IN ('Germany', 'Canada'))
SELECT cr.Name [Country], sp.Name [Province]
FROM FilteredCountry cr JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
