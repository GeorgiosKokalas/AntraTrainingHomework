USE Northwind
GO

/*1 Create a view named “view_product_order_[your_last_name]”, list all products and total ordered quantity for that product. */
CREATE VIEW view_product_order_Kokalas AS (
    SELECT p.ProductName, SUM(od.Quantity) [Total Quantity Bought]
    FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
    GROUP BY p.ProductName
)
GO

/*2.Create a stored procedure “sp_product_order_quantity_[your_last_name]” that accept product id as an input and total quantities of order as output parameter.*/
CREATE PROC sp_product_order_quantity_Kokalas 
@id INT
AS BEGIN
    DECLARE @totalQuantity INT
    SELECT @totalQuantity = SUM(Quantity) 
        FROM [Order Details] 
        WHERE ProductID = @id
    RETURN @totalQuantity
END
GO

/*3 Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as an input and
top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.*/
CREATE PROC sp_product_order_city_Kokalas 
@City NVARCHAR(40)
AS BEGIN
    WITH ui AS (
    SELECT TOP 5 p.ProductName, o.ShipCity, SUM(od.Quantity) [Total Quantity Ordered]
    FROM Products p JOIN [Order Details] od ON od.ProductID=p.ProductID
                    JOIN Orders o ON o.OrderID = od.OrderID                  
    WHERE ProductName = @City
    GROUP BY p.ProductName, o.ShipCity
    ORDER BY [Total Quantity Ordered] DESC
    )
    SELECT ShipCity, [Total Quantity Ordered]
    FROM ui
END
GO

/* 4. Create 2 new tables “people_your_last_name” “city_your_last_name”. City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. 
 People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. 
 Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”. Create a view “Packers_your_name” lists all people from Green Bay. 
 If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.*/

 CREATE TABLE city_Kokalas(
     Id INT PRIMARY KEY,
     City NVARCHAR(40)
 )


 CREATE TABLE people_Kokalas(
     Id INT PRIMARY KEY,
     Name NVARCHAR(40),
     City INT
 )


INSERT INTO city_Kokalas VALUES (1, 'Seattle'), (2, 'Green Bay')
INSERT INTO people_Kokalas VALUES (1, 'Aaron Rodgers', 2), (2, 'Russell Wilson', 1), (3, 'Jody Nelson', 2)
DELETE FROM city_Kokalas 
    WHERE City= 'Seattle'
INSERT INTO city_Kokalas VALUES (3, 'Madison')
UPDATE people_Kokalas
    SET City = 3
    WHERE City = 1
    GO

CREATE VIEW Packers_Kokalas AS (
    SELECT [Name]
        FROM people_Kokalas
        WHERE City = 2
)
GO

DROP VIEW Packers_Kokalas
DROP TABLE city_Kokalas
DROP TABLE people_Kokalas
GO


/* 5. Create a stored procedure “sp_birthday_employees_[you_last_name]” that creates a new table “birthday_employees_your_last_name” 
and fill it with all employees that have a birthday on Feb. (Make a screen shot) drop the table. Employee table should not be affected.*/

CREATE PROC sp_birthday_employees_Kokalas AS BEGIN
    CREATE TABLE #birthday_employees_Kokalas (
        EmployeeID INT,
        LastName NVARCHAR(20),
        FirstName NVARCHAR(10),
        BirthDate DATETIME,
    )
    INSERT #birthday_employees_Kokalas SELECT EmployeeID, FirstName, LastName, BirthDate FROM Employees WHERE MONTH(BirthDate) = 2
    DROP TABLE #birthday_employees_Kokalas
END
GO

/* 6.How do you make sure two tables have the same data?*/
DECLARE @i INT;         -- We create Integers to make the comparisons
DECLARE @i2 INT;
DECLARE @i3 INT;

SELECT @i = COUNT(*) FROM Orders;   -- Integer 1 holds the number of  rows for 1 table
SELECT @i2 = COUNT(*) FROM Orders;  -- Integer 2 holds the number of rows for the second table

WITH unity AS (
    SELECT * FROM Orders
    UNION                          -- Integer 3 holds the number of rows by the Union of the 2 tables
    SELECT * FROM Orders           -- If the data in the 2 tables is exactly the same then UNION will delete all duplicate entries
    )                              -- This leaves a result set the size of the original tables
SELECT @i3 = COUNT(*) FROM unity ;  

PRINT @i / @i2;                    -- If the result is 1, then the tables have an equal amount of rows
PRINT @i / @i3;                    -- If the result is 1, then the 2 tables duplicates of each other. 
                                        -- Since we know that the 2 tables have the same amount of rows, then we can exclude
                                        -- the possibility that one table is just a subset of another
