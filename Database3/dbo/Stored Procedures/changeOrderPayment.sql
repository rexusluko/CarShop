CREATE PROCEDURE [dbo].[changeOrderPayment] 
@ID smallint,
@Payment smallint
AS  
BEGIN  
UPDATE Orders
SET PaymentID=@Payment
WHERE OrderID=@ID
END
