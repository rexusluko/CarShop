CREATE TABLE [dbo].[CarStatuses] (
    [StatusID]    SMALLINT     IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_CarStatuses] PRIMARY KEY CLUSTERED ([StatusID] ASC)
);

