CREATE TABLE Reservation(
	IDReservation        INT IDENTITY (1,1) NOT NULL ,
	IdLogin              INT  NOT NULL ,
	idEnfant             INT  NOT NULL ,
	idJouet              INT  NOT NULL ,
	CONSTRAINT Reservation_PK PRIMARY KEY (IDReservation)

	,CONSTRAINT Reservation_Parent_FK FOREIGN KEY (IdLogin) REFERENCES login(idLogin)
	,CONSTRAINT Reservation_Enfant0_FK FOREIGN KEY (idEnfant) REFERENCES Enfant(idEnfant)
);