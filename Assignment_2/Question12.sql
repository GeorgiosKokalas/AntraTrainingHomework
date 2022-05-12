/*
12. Display all the Managers who have more than 2 employees reporting to them.
*/

USE Northwind
GO
  
WITH E1
AS (
    SELECT Employees.[ReportsTo] [Employee ID], COUNT(Employees.ReportsTo) [Reporters]
    FROM Employees
    GROUP BY Employees.[ReportsTo]
    HAVING COUNT(Employees.ReportsTo) > 2
    )
SELECT E2.FirstName + ' ' + E2.LastName [Manager]
FROM E1 INNER JOIN Employees E2 ON E1.[Employee ID] = E2.EmployeeID
