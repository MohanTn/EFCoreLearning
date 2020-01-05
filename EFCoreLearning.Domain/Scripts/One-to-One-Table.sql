create table Authors(
AuthorId INT NOT NULL,
FirstName VARCHAR(MAX),
LastName VARCHAR(MAX),
PRIMARY KEY (AuthorId)
)
GO
INSERT INTO Authors VALUES (1,'Autho1','Ross')
INSERT INTO Authors VALUES (2,'Autho2','Ross')
INSERT INTO Authors VALUES (3,'Autho3','Ross')
INSERT INTO Authors VALUES (4,'Autho4','Ross')
INSERT INTO Authors VALUES (5,'Autho5','Ross')
INSERT INTO Authors VALUES (6,'Autho6','Ross')
GO

CREATE TABLE AuthorBiographys (
AuthorBiographyId INT NOT NULL,
Biography VARCHAR(MAX),
DateOfBirth Date,
PlaceOfBirth VARCHAR(MAX),
Nationality VARCHAR(MAX),
AuthorRef INT,
PRIMARY KEY (AuthorBiographyId),
FOREIGN KEY (AuthorRef) REFERENCES Authors(AuthorId),
CONSTRAINT Author_Bio UNIQUE (AuthorRef)
)
GO
INSERT INTO AuthorBiographys VALUES (1,'Test Author Bio1','01-01-2020','BLR1','Indian',1)
INSERT INTO AuthorBiographys VALUES (2,'Test Author Bio2','01-01-2020','BLR2','Indian',1)
INSERT INTO AuthorBiographys VALUES (3,'Test Author Bio3','01-01-2020','BLR3','Indian',1)
INSERT INTO AuthorBiographys VALUES (4,'Test Author Bio4','01-01-2020','BLR4','Indian',1)
INSERT INTO AuthorBiographys VALUES (5,'Test Author Bio5','01-01-2020','BLR5','Indian',1)
INSERT INTO AuthorBiographys VALUES (6,'Test Author Bio6','01-01-2020','BLR6','Indian',1)
GO