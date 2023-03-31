CREATE PROCEDURE uspNewCustomer 
@CustomerName VARCHAR (50),
@CustomerLastName VARCHAR (50),
@CustomerPhone VARCHAR (11),
@CustomerAddress VARCHAR(50)
AS  
BEGIN  
INSERT INTO Customers(FirstName,LastName,Phone,Address) VALUES (@CustomerName,@CustomerLastName,@CustomerPhone,@CustomerAddress);  
END