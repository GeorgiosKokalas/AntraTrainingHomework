/*
9. List all of the possible ways that suppliers can ship their products. Display the results as below
    Supplier Company Name                Shipping Company Name
    ---------------------------------            ----------------------------------
*/

USE Northwind
GO

-- I wasn't sure how else to Connect Shippers to Suppliers
SELECT DISTINCT sp.CompanyName [Supplier Company Name], sh.CompanyName [Shipping Company Name]
FROM Suppliers sp INNER JOIN Products pr ON pr.SupplierID = sp.SupplierID 
                  INNER JOIN [Order Details] od ON od.ProductID = pr.ProductID
                  INNER JOIN [Orders] o ON o.OrderID = od.OrderID
                  INNER JOIN [Shippers] sh ON sh.ShipperID = o.ShipVia  
ORDER BY sp.CompanyName ASC
