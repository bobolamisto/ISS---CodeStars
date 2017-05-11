--tabel Propunere  

CREATE TABLE Propunere(
	id_propunere INT PRIMARY KEY,
	id_cont INT FOREIGN KEY REFERENCES Cont(id_cont),
	nume_propunere VARCHAR(30),
	keywords_propunere TEXT,
	subiecte_propunere TEXT,
	--deadline_propunere DATE,
	lista_autori TEXT


)