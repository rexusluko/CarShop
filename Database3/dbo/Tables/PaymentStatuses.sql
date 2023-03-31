CREATE TABLE [dbo].[PaymentStatuses] (
    [PaymentID]   SMALLINT     IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_PaymentStatuses] PRIMARY KEY CLUSTERED ([PaymentID] ASC)
);

