CREATE TABLE [dbo].[Cars] (
    [CarID]         SMALLINT     IDENTITY (1, 1) NOT NULL,
    [Model]         VARCHAR (50) NOT NULL,
    [Manafacturer]  VARCHAR (50) NOT NULL,
    [Color]         VARCHAR (50) NOT NULL,
    [Mileage]       INT          CONSTRAINT [DF_Cars_Mileage] DEFAULT ((0)) NOT NULL,
    [Cost]          INT          NOT NULL,
    [WarrantyYears] INT          CONSTRAINT [DF_Cars_WarrantyYears] DEFAULT ((3)) NOT NULL,
    [StatusID]      SMALLINT     NOT NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([CarID] ASC),
    FOREIGN KEY ([StatusID]) REFERENCES [dbo].[CarStatuses] ([StatusID])
);

