CREATE TABLE ContConferinta(
	id_cont INT FOREIGN KEY REFERENCES Cont(id_cont),
	id_conferinta INT FOREIGN KEY REFERENCES Conferinta(id_conferinta),
	rol Enum, 
)