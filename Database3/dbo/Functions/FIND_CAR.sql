﻿CREATE FUNCTION FIND_CAR(@Color VARCHAR(50))
RETURNS INT
AS
BEGIN
DECLARE @result VARCHAR(50)
SET @result=(SELECT TOP(1) Cost
 FROM Cars
 WHERE Color=@Color
 ORDER BY Cost)
RETURN (@result)
END