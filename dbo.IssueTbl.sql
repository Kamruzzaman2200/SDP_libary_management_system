CREATE TABLE [dbo].[IssueTbl] (
    [IssueName]  INT           NOT NULL,
    [StdId]      INT           NOT NULL,
    [StdName]    VARCHAR (50)  NOT NULL,
    [StdDept]    VARCHAR (50)  NOT NULL,
    [StdPhone]   VARCHAR (50)  NOT NULL,
    [BookIssued] VARCHAR (100) NOT NULL,
    [IssueDate]  DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([IssueName] ASC)
);
