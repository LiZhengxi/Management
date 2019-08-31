CREATE PROCEDURE PS_GetSalary (@Year AS INT,@Month AS INT)
AS
BEGIN
DECLARE @Revenue FLOAT 

SET @Revenue = (SELECT number  FROM Revenue R WHERE R.[month] = @Month and R.[year] = @Year)

SELECT @Revenue

SELECT * FROM Employee E
INNER JOIN Salary S ON S.employee_id = E.id  AND S.[year] =@Year AND S.[month] = @Month
INNER JOIN Altelier A ON A.id = E.altelier_id

END