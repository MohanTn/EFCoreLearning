CREATE TABLE Child(
ID INT PRIMARY KEY,
Name VARCHAR(MAX),
)
GO
INSERT INTO Child Values(1,'Child1')
INSERT INTO Child Values(2,'Child2')
INSERT INTO Child Values(3,'Child3')
GO

CREATE TABLE Parents(
ID INT PRIMARY KEY,
Name VARCHAR(MAX),
Children INT REFERENCES Child(ID)
)
GO
Insert into Parents Values(1,'Parent1',1)
Insert into Parents Values(2,'Parent2',2)
Insert into Parents Values(3,'Parent3',2)
Insert into Parents Values(4,'Parent4',3)
Insert into Parents Values(5,'Parent5',3)
Insert into Parents Values(6,'Parent6',3)
GO

CREATE TABLE GrandParents(
ID INT PRIMARY KEY,
Name VARCHAR(MAX),
Parent INT REFERENCES Parents(ID)
)
GO
Insert into GrandParents Values (1,'GrandParent1',1)
Insert into GrandParents Values (2,'GrandParent2',2)
Insert into GrandParents Values (3,'GrandParent3',2)
Insert into GrandParents Values (4,'GrandParent4',3)
Insert into GrandParents Values (5,'GrandParent5',3)
Insert into GrandParents Values (6,'GrandParent6',3)
GO

CREATE TABLE GrandGrandParents(
ID INT PRIMARY KEY,
Name VARCHAR(MAX),
GrandParent INT REFERENCES GrandParents(ID)
)
GO
Insert into GrandGrandParents Values (1,'GrandGrandParents1',1)
Insert into GrandGrandParents Values (2,'GrandGrandParents2',2)
Insert into GrandGrandParents Values (3,'GrandGrandParents3',2)
Insert into GrandGrandParents Values (4,'GrandGrandParents4',3)
Insert into GrandGrandParents Values (5,'GrandGrandParents5',3)
Insert into GrandGrandParents Values (6,'GrandGrandParents6',3)
GO




