CREATE PROCEDURE [dbo].[f_car] 
@Color VARCHAR (50)
AS  
SELECT [dbo].FIND_CAR(@Color)  
