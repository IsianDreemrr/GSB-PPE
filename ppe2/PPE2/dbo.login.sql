CREATE TABLE [dbo].[login] (
    [idLogin]  INT          NOT NULL,
    [username] VARCHAR (50) NOT NULL,
    [password] VARCHAR (50) NOT NULL,
	nom        VARCHAR (50) NOT NULL ,
	prenom     VARCHAR (50) NOT NULL  ,
    PRIMARY KEY CLUSTERED ([idLogin] ASC)
);

