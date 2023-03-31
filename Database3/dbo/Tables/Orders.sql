CREATE TABLE [dbo].[Orders] (
    [OrderID]    SMALLINT IDENTITY (1, 1) NOT NULL,
    [CustomerID] SMALLINT NOT NULL,
    [CarID]      SMALLINT NOT NULL,
    [OrderDate]  DATE     NOT NULL,
    [PaymentID]  SMALLINT NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderID] ASC),
    FOREIGN KEY ([CarID]) REFERENCES [dbo].[Cars] ([CarID]),
    FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([CustomerID]),
    FOREIGN KEY ([PaymentID]) REFERENCES [dbo].[PaymentStatuses] ([PaymentID])
);

