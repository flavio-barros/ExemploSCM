/* Script de criação do banco de dados - MStarSupply SCM */

CREATE TABLE Mercadoria (
	id INTEGER NOT NULL PRIMARY KEY,
	numero_registro INTEGER NOT NULL,
	nome VARCHAR(100) NOT NULL,
	fabricante VARCHAR(50) NOT NULL,
	tipo VARCHAR(20) NOT NULL,
	descricao VARCHAR(200)
);

INSERT INTO Mercadoria VALUES (
	1, 0012019, "Mercadoria 1", "Fabricante AA", "Tipo AAB", "Desc mercadoria 1"
);
INSERT INTO Mercadoria VALUES (
	2, 0022019, "Mercadoria 2", "Fabricante BB", "Tipo CCC", "Desc mercadoria 2"
);

CREATE TABLE Entrada (
	id INTEGER NOT NULL PRIMARY KEY,
	mercadoria_id INTEGER NOT NULL,
	quantidade Integer NOT NULL,
	data TEXT NOT NULL,
	hora TEXT(20) NOT NULL,
	local VARCHAR(20) NOT NULL,
	FOREIGN KEY(mercadoria_id) REFERENCES Mercadoria(id)
);

CREATE TABLE Saida (
	id INTEGER NOT NULL PRIMARY KEY,
	mercadoria_id INTEGER NOT NULL,
	quantidade Integer NOT NULL,
	data DATETIME NOT NULL,
	hora DATETIME NOT NULL,
	local VARCHAR(20) NOT NULL,
	FOREIGN KEY(mercadoria_id) REFERENCES Mercadoria(id)
);