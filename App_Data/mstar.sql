/* Script de criação do banco de dados - MStarSupply SCM */

CREATE TABLE Mercadoria (
	Id INTEGER NOT NULL PRIMARY KEY,
	Numero_registro INTEGER NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Fabricante VARCHAR(50) NOT NULL,
	Tipo VARCHAR(20) NOT NULL,
	Descricao VARCHAR(200)
);

INSERT INTO Mercadoria VALUES (
	1, 0012019, "Mercadoria 1", "Fabricante AA", "Tipo AAB", "Desc mercadoria 1"
);
INSERT INTO Mercadoria VALUES (
	2, 0022019, "Mercadoria 2", "Fabricante BB", "Tipo CCC", "Desc mercadoria 2"
);

CREATE TABLE Entrada (
	Id INTEGER NOT NULL PRIMARY KEY,
	Mercadoria_Id INTEGER NOT NULL,
	Quantidade Integer NOT NULL,
	Data TEXT NOT NULL,
	Hora TEXT(20) NOT NULL,
	Local VARCHAR(20) NOT NULL,
	FOREIGN KEY(Mercadoria_Id) REFERENCES Mercadoria(Id)
);

CREATE TABLE Saida (
	Id INTEGER NOT NULL PRIMARY KEY,
	Mercadoria_id INTEGER NOT NULL,
	Quantidade Integer NOT NULL,
	Data DATETIME NOT NULL,
	Hora DATETIME NOT NULL,
	Local VARCHAR(20) NOT NULL,
	FOREIGN KEY(Mercadoria_Id) REFERENCES Mercadoria(Id)
);