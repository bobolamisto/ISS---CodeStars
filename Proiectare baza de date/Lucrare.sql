CREATE TABLE Lucrare(
	id_lucrare int PRIMARY KEY,
	id_cont int FOREIGN KEY REFERENCES Cont,
	id_conferinta int FOREIGN KEY REFERENCES Conferinta,
	nume_lucrare varchar(30),
	tema varchar(30),
	autori varchar(100)
)