CREATE TABLE [dbo].[Enfant]
(
	idEnfant   INT IDENTITY (1,1) NOT NULL ,
	nom        VARCHAR (50) NOT NULL ,
	prenom     VARCHAR (50) NOT NULL ,
	age        INT  NOT NULL  ,
	CONSTRAINT Enfant_PK PRIMARY KEY (idEnfant)
)
