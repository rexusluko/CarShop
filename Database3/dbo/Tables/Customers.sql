CREATE TABLE [dbo].[Customers] (
    [CustomerID] SMALLINT     IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    [Phone]      VARCHAR (11) NOT NULL,
    [Address]    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

