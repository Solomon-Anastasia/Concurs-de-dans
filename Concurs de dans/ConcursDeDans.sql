--Utilizarea bazei de date 'MASTER'
USE MASTER
GO

--Stergerea BD 'ConcursDeDans' in caz ca exista
IF EXISTS (SELECT * FROM sys.databases WHERE NAME = 'ConcursDeDans')
BEGIN
	ALTER DATABASE ConcursDeDans SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE ConcursDeDans
END
GO

--Crearea bazei de date 'ConcursDeDans'
CREATE DATABASE ConcursDeDans
GO

--Utilizarea bazei de date 'ConcursDeDans'
USE ConcursDeDans
GO

--Crearea tabelului INSTITUTII
CREATE TABLE Institutii (
	IdInstitutie INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	NumeInstitutie VARCHAR(100) NOT NULL,
	Adresa VARCHAR(50) NOT NULL,
)
GO

--Crearea tabelului CATEGORIE_DANSURI
CREATE TABLE CategorieDansuri (
	IdCategorie INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	DenumireCategorie VARCHAR(50) NOT NULL,
)
GO

--Crearea tabelului TIP_DANSURI
CREATE TABLE TipuriDans (
	IdTipDans INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	DenumireTipDans VARCHAR(50) NOT NULL,
	IdCategorie INT NOT NULL,
)
GO

--Crearea cheii straine intre tabelul CategorieDansuri si TipuriDans
ALTER TABLE TipuriDans WITH CHECK ADD CONSTRAINT FK_TipuriDans_CategorieDansuri
FOREIGN KEY(IdCategorie)
REFERENCES CategorieDansuri(IdCategorie)
ON DELETE CASCADE
GO

--Crearea tabelului DANSATORI
CREATE TABLE Dansatori (
	IdDansator INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	CodDansator VARCHAR(6) NOT NULL,
	Nume VARCHAR(20) NOT NULL,
	Prenume VARCHAR(20) NOT NULL,
	Sex VARCHAR(1) NOT NULL,
	DataNasterii DATE NOT NULL,
	Experienta INT NOT NULL,
	IdTipDans INT NOT NULL,
)
GO

--Crearea cheii straine intre tabelul Dansuri si TipuriDans 
ALTER TABLE Dansatori WITH CHECK ADD CONSTRAINT FK_Dansatori_TipuriDans
FOREIGN KEY(IdTipDans)
REFERENCES TipuriDans(IdTipDans)
ON DELETE CASCADE
GO

--Crearea tabelului DATE_DE_CONTACT
CREATE TABLE DateDeContact (
	IdDateDeContact INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Email VARCHAR(50) NOT NULL,
	Telefon VARCHAR(15) NOT NULL,
	Adresa VARCHAR(50) NOT NULL,
	IdInstitutie INT NOT NULL,
	IdDansator INT NOT NULL,
)
GO

--Crearea cheii straine intre tabelul Institutii si DateDeContact
ALTER TABLE DateDeContact WITH CHECK ADD CONSTRAINT FK_DateDeContact_Institutii 
FOREIGN KEY(IdInstitutie)
REFERENCES Institutii(IdInstitutie)
ON DELETE CASCADE
GO

--Crearea cheii straine intre tabelul Dansatori si DateDeContact
ALTER TABLE DateDeContact WITH CHECK ADD CONSTRAINT FK_DateDeContact_Dansatori
FOREIGN KEY(IdDansator)
REFERENCES Dansatori(IdDansator)
ON DELETE CASCADE
GO

--Crearea tabelului CONCURSURI
CREATE TABLE Concursuri (
	IdConcurs INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Denumire VARCHAR(100) NOT NULL,
	AdresaDesfasurarii VARCHAR(50) NOT NULL,
	Durata TIME NOT NULL,
	DataDesfasuratii DATE NOT NULL,
)
GO

--Crearea tabelului ACTE
CREATE TABLE Acte (
	IdAct INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	IdDansator INT NOT NULL,
	IdConcurs INT NOT NULL,
)
GO

--Crearea cheii straine intre tabelul Dansatori si Acte
ALTER TABLE Acte WITH CHECK ADD CONSTRAINT FK_Acte_Dansatori
FOREIGN KEY(IdDansator)
REFERENCES Dansatori(IdDansator)
ON DELETE CASCADE
GO

--Crearea cheii straine intre tabelul Concursuri si Acte
ALTER TABLE Acte WITH CHECK ADD CONSTRAINT FK_Acte_Concursuri
FOREIGN KEY(IdConcurs)
REFERENCES Concursuri(IdConcurs)
ON DELETE CASCADE
GO

--Crearea tabelului PREMII
CREATE TABLE Premii (
	IdPremiu INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Locul VARCHAR(20) NOT NULL,
	PremiuBanesc MONEY NOT NULL,
	IdDansator INT NOT NULL,
	IdConcurs INT NOT NULL,
)
GO

--Crearea tabelului Utilizatori
CREATE TABLE Utilizatori (
	IdUtilizator INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Username VARCHAR(50) NOT NULL,
	Parola VARCHAR(25),
	Email VARCHAR(50),
	EsteAdministrator BIT NOT NULL,
)
GO

--Crearea cheii straine intre tabelul Dansatori si Premii
ALTER TABLE Premii WITH CHECK ADD CONSTRAINT FK_Premii_Dansatori
FOREIGN KEY(IdDansator)
REFERENCES Dansatori(IdDansator)
ON DELETE CASCADE
GO

--Crearea cheii straine intre tabelul Concursuri si Premii
ALTER TABLE Premii WITH CHECK ADD CONSTRAINT FK_Premii_Concursuri
FOREIGN KEY(IdConcurs)
REFERENCES Concursuri(IdConcurs)
ON DELETE CASCADE
GO

--Inserarea datelor in tabelul INSTITUTII
INSERT INTO Institutii (NumeInstitutie, Adresa) VALUES
	('Liceul Teoretic "Pro Succes"', 'Chisinau'),
	('Liceul Teoretic cu Profil Sportiv "Gloria"', 'Balti'),
	('Liceul Teoretic "Rambam"', 'Tiraspol'),
	('Gimnaziul "Galata"', 'Cahul'),
	('Gimnaziul "Decebal"', 'Chisinau'),
	('Liceul Teoretic cu Profil de Arte "Elena Alistar"', 'Edinet'),
	('Liceul Teoretic "Iulia Hasdeu"', 'Cahul'),
	('Institutia Publica Liceul Teoretic "Liviu Rebreanu"', 'Cimislia'),
	('Gimnaziul "Nicolae H. Costin"', 'Cimislia'),
	('Gimnaziul nr.49', 'Chisinau'),
	('Institutia Publica Liceul Teoretic "Tudor Vladimirescu"', 'Cahul'),
	('Liceul Teoretic "Mircea cel Batran"', 'Edinet'),
	('Liceul Teoretic "Bogdan Petriceicu Hasdeu"', 'Cahul'),
	('Institutia Publica Liceul Teoretic "Traian"', 'Tiraspol'),
	('Liceul Teoretic "Mihai Grecu" ', 'Chisinau'),
	('Institutia Publica Liceul Teoretic "Petru Movila"', 'Balti'),
	('Liceul Teoretic "Nicolae Iorga"', 'Chisinau'),
	('Liceul Teoretic "Mihai Eminescu"', 'Cahul'),
	('Colegiul de Informatica', 'Cimislia'),
	('Colegiul Financiar – Bancar', 'Balti'),
	('Colegiul de Microelectronica si Tehnica de Calcul', 'Cimislia'),
	('Colegiul de Ecologie', 'Edinet'),
	('Colegiul de Industrie Usoara', 'Chisinau'),
	('Colegiul Politehnic', 'Chisinau'),
	('Colegiul de Transporturi', 'Balti'),
	('Colegiul Tehnologic', 'Cimislia'),
	('Colegiul de Constructii', 'Chisinau'),
	('Colegiul Tehnic Feroviar', 'Balti'),
	('Academia de Muzica, Teatru si Arte Plastice', 'Tiraspol'),
	('Academia de Studii Economice', 'Edinet'),
	('Universitatea Agrara de Stat', 'Cimislia'),
	('Universitatea Pedagogica de Stat "Ion Creanga"', 'Tiraspol'),
	('Universitatea de Stat de Medicina si Farmacie "Nicolae Testemiþanu"', 'Cahul'),
	('Universitatea Cooperatist – Comerciala', 'Cahul'),
	('Universitatea de Stat', 'Edinet'),
	('Universitatea Tehnica', 'Cahul'),
	('Academia de Studii Economice', 'Cimislia'),
	('Universitatea de Stat "Alecu Russo"', 'Cahul'),
	('Universitatea de Stat "Bogdan Petriceicu Hasdeu"', 'Tiraspol'),
	('Universitatea de Stat de Educatie Fizica si Sport', 'Cahul'),
	('Academia de Politie "Stefan cel Mare"', 'Edinet'),
	('Academia Militara a Fortelor Armate "Alexandru cel Bun"', 'Tiraspol'),
	('Academia de Administrare Publica', 'Balti'),
	('Universitatea de Stat "Grigore Tamblac"', 'Balti'),
	('Universitatea Libera Internationala', 'Chisinau'),
	('Institutul de Stiinte Penale si Criminologie Aplicata', 'Cahul'),
	('Institutul Interntional de Management "IMI-NOVA"', 'Tiraspol'),
	('Universitatea de Studii Politice si Economice Europene', 'Tiraspol'),
	('Academia de Teologie Ortodoxa', 'Balti'),
	('Scoala Profesionala nr.1', 'Chisinau');
GO

--Inserarea datelor in tabelul CATEGORIE_DANSURI
INSERT INTO CategorieDansuri (DenumireCategorie) VALUES
	('Africane si afro-americane'),
	('Dans ceremonial'),
	('Discoteca / Dans electronic'),
	('Hanpurian'),
	('Dans gratuit si improvizat'),
	('Dans istoric'),
	('Latina / Ritm'),
	('Dansuri de noutate si moft'),
	('Dans social'),
	('Dans de strada'),
	('Dans de leagan'),
	('Alte');
GO

--Inserarea datelor in tabelul TIP_DANSURI
INSERT INTO TipuriDans (DenumireTipDans, IdCategorie) VALUES
	('Bolojo', 1),
	('Boge', 1),
	('Pas cu pas', 1),
	('Kompa', 1),
	('Dans de jazz', 1),
	('Haka', 2),
	('Kagura', 2),
	('Dansuri rituale din China', 2),
	('Dans Cham', 2),
	('Drametse Ngacham', 2),
	('Dans Kumha Pyakhan', 2),
	('Dans profetic', 2),
	('Boogaloo', 3),
	('Cucui', 3),
	('Taierea formelor', 3),
	('Waacking', 3),
	('Pas liber', 3),
	('Hustle', 3),
	('Dans Adhunik Hanpurian', 4),
	('Contact improvizatie', 5),
	('Improvizatie de dans', 5),
	('Dans extatic', 5),
	('Dans gratuit', 5),
	('Balet / Franta', 6),
	('Dans baroc', 6),
	('Dans medieval', 6),
	('Dans Polka', 6),
	('Rumba', 7),
	('Cha Cha', 7),
	('Salsa', 7),
	('Lambada', 8),
	('Madison', 8),
	('Dans solo', 9),
	('Dans hip-hop', 10),
	('Dansuri de club', 10),
	('Breakdancing', 10),
	('Uprock', 10),
	('Dansul electro', 10),
	('Balboa', 11),
	('Dansul blues', 11),
	('Bugg', 11),
	('Jive', 11),
	('Colegial Shag', 11),
	('Single Swing', 11),
	('Dansul acro', 12),
	('Dansul focului', 12),
	('K-Pop', 12),
	('Dans liric', 12),
	('Flamenco', 12),
	('Dans vintage', 12);
GO

--Inserarea datelor in tabelul DANSATORI
INSERT INTO Dansatori (CodDansator, Nume, Prenume, Sex, DataNasterii, Experienta, IdTipDans) VALUES
	('MR3716', 'Mccallum', 'Ryley', 'F', '2014-12-24', 2, 1),
	('DD1783', 'Davidson', 'Darcie-Mae', 'F', '2014-06-20', 1, 17),
	('RM3483', 'Rush', 'Manal', 'M', '2008-09-15', 6, 16),
	('HC6318', 'Holland', 'Cain', 'M', '2008-06-24', 7, 28),
	('IE1634', 'Ibarra', 'Emyr', 'F', '2013-10-10', 3, 30),
	('CB7590', 'Corona', 'Bryce', 'M', '2002-06-10', 10, 18),
	('HW3802', 'Huffman', 'Wade', 'M', '1991-04-01', 22, 38),
	('IK4894', 'Irvine', 'Kyran', 'M', '2007-09-16', 4, 29),
	('OK4361', 'ONeill', 'Kian', 'M', '2006-09-30', 7, 2),
	('MP7371', 'Mccormick', 'Phillipa', 'F', '2004-09-26', 11, 19),
	('ES0047', 'Espinosa', 'Sonny', 'M', '2000-01-09', 2, 15),
	('PD8341', 'Perkins', 'Derry', 'M', '2008-08-11', 5, 35),
	('KA2531', 'Kirkland', 'Abigale', 'F', '2013-06-01', 1, 3),
	('BB2610', 'Bains', 'Brenna', 'F', '2013-09-24', 2, 39),
	('EC5281', 'Elliott', 'Cairon', 'M', '2001-09-25', 6, 50),
	('HG4438', 'Holman', 'Greg', 'M', '1994-07-08', 18, 36),
	('FF1732', 'Flower', 'Franciszek', 'M', '1993-03-19', 15, 49),
	('BL7829', 'Bob', 'Loki', 'M', '2004-03-10', 2, 37),
	('LJ8261', 'Le', 'Joan', 'M', '2004-01-09', 10, 48),
	('JC5174', 'Jacobs', 'Charis', 'M', '1999-01-23', 3, 27),
	('KZ8756', 'Kaiser', 'Zahra', 'F', '2010-05-21', 4, 4),
	('WH0760', 'Wilkerson', 'Harvir', 'M', '1997-11-13', 5, 40),
	('DM6019', 'Delgado', 'Mariah', 'F', '1983-05-17', 29, 31),
	('GP3356', 'Guest', 'Padraig', 'F', '1993-03-21', 10, 43),
	('DA0875', 'Derrick', 'Ariella', 'F', '1992-11-24', 11, 5),
	('DN0348', 'Dickinson', 'Nia', 'F', '2009-09-25', 7, 12),
	('MM5613', 'Mcghee', 'Mai', 'F', '1994-05-10', 12, 6),
	('KR3891', 'Knowles', 'Reiss', 'M', '1990-06-07', 15, 20),
	('QC6450', 'Quintero', 'Cristiano', 'M', '1992-10-25', 21, 13),
	('NK4000', 'Nicholls', 'Kristen', 'F', '2011-01-15', 6, 44),
	('GJ1936', 'Grey', 'Jett', 'M', '1998-10-16', 14, 14),
	('MK0419', 'Mccaffrey', 'Keelan', 'M', '1989-11-19', 23, 41),
	('AK2274', 'Arias', 'Krista', 'F', '2013-05-01', 2, 21),
	('NE8215', 'Neale', 'Eduard', 'M', '2011-11-08', 6, 46),
	('BF2981', 'Beech', 'Flora', 'F', '1988-06-21', 24, 42),
	('WC3210', 'Wilde', 'Colton', 'M', '1988-08-16', 20, 26),
	('CL0815', 'Campos', 'Leila', 'F', '2011-05-13', 4, 22),
	('HK7613', 'Harper', 'Karim', 'F', '2011-06-21', 5, 32),
	('MM8033', 'Mendez', 'Miriam', 'F', '1997-09-09', 16, 9),
	('RK2137', 'Redman', 'Karson', 'M', '2010-07-08', 7, 10),
	('MM4671', 'Meza', 'Malika', 'F', '2011-06-21', 2, 24),
	('GH9753', 'Goulding', 'Hira', 'F', '2014-10-22', 1, 34),
	('PM4781', 'Preston', 'Maci', 'M', '2014-10-05', 1, 23),
	('ME2375', 'Mcpherson', 'Emilis', 'F', '1998-10-24', 15, 45),
	('BZ8349', 'Butt', 'Zeshan', 'M', '1987-11-20', 27, 47),
	('JN9339', 'Joyce', 'Naseem', 'M', '1996-08-08', 18, 11),
	('EA9201', 'Erickson', 'Alissa', 'F', '2015-08-21', 2, 33),
	('PA9176', 'Piper', 'Antony', 'M', '1983-06-26', 32, 7),
	('HB4085', 'Hanna', 'Brooklyn', 'M', '1986-01-17', 28, 25),
	('SC4892', 'Shah', 'Chenai', 'M', '1987-11-04', 26, 8);
GO

--Inserarea datelor in tabelul DATE_DE_CONTACT
INSERT INTO DateDeContact (Email, Telefon, Adresa, IdInstitutie, IdDansator) VALUES
	('kohlis@gmail.com', '+373 562 31 237', 'Chisinau', 1, 1),
	('fukuchi@gmail.com', '+373 562 52 426', 'Truseni', 2, 14),
	('mgreen@mail.com', '+373 680 74 925', 'Cricova', 3, 13),
	('sacraver@yahoo.com', '+373 640 72 956', 'Chisinau', 28, 27),
	('fatelk@mail.com', '+373 562 27 132', 'Bacioi', 35, 36),
	('fallorn@gmail.com', '+373 562 22 983', 'Floresti', 34, 45),
	('kingma@mail.com', '+373 776 29 903', 'Floresti', 4, 26),
	('oster@yahoo.com', '+373 562 72 844', 'Bacioi', 40, 16),
	('afeldspar@gmail.com', '+373 562 23 908', 'Cricova', 15, 37),
	('novanet@yahoo.com', '+373 562 46 693', 'Chisinau', 38, 46),
	('johnbob@yahoo.com', '+373 562 95 329', 'Ialoveni', 41, 35),
	('qrcza@gmail.com', '+373 637 19 047', 'Balti', 13, 43),
	('fwitness@gmail.com', '+373 608 69 892', 'Balti', 5, 47),
	('frode@mail.com', '+373 776 31 333', 'Balti', 31, 24),
	('mjewell@gmail.com', '+373 624 40 782', 'Cricova', 6, 34),
	('jtorkbob@yahoo.com', '+373 645 32 252', 'Balti', 23, 15),
	('kudra@gmail.com', '+373 562 89 723', 'Truseni', 29, 44),
	('torgox@mail.com', '+373 562 86 817', 'Chisinau', 7, 2),
	('keijser@gmail.com', '+373 782 05 383', 'Floresti', 11, 12),
	('geekoid@gmail.com', '+373 635 44 508', 'Cricova', 33, 25),
	('avalon@gmail.com', '+373 562 84 938', 'Ialoveni', 39, 28),
	('aibrahim@gmail.com', '+373 562 28 191', 'Balti', 32, 48),
	('osrin@yahoo.com', '+373 646 94 463', 'Truseni', 17, 4),
	('jsbach@gmail.com', '+373 562 37 575', 'Bacioi', 22, 6),
	('kalpol@gmail.com', '+373 711 81 138', 'Chisinau', 49, 7),
	('ahuillet@gmail.com', '+373 562 64 760', 'Ialoveni', 45, 23),
	('jdhedden@gmail.com', '+373 562 79 334', 'Cricova', 8, 3),
	('paley@gmail.com', '+373 621 21 017', 'Balti', 36, 17),
	('stomv@yahoo.com', '+373 638 37 382', 'Chisinau', 25, 19),
	('privcan@gmail.com', '+373 654 99 419', 'Floresti', 37, 31),
	('rgarton@gmail.com', '+373 647 36 276', 'Balti', 9, 38),
	('seanq@mail.com', '+373 562 80 216', 'Truseni', 10, 5),
	('maratb@gmail.com', '+373 788 20 440', 'Balti', 44, 49),
	('jelmer@mail.com', '+373 636 38 978', 'Ialoveni', 24, 18),
	('attwood@gmail.com', '+373 562 13 980', 'Cricova', 48, 39),
	('tubesteak@gmail.com', '+373 562 05 948', 'Chisinau', 47, 50),
	('mosses@gmail.com', '+373 562 05 948', 'Chisinau', 10, 8),
	('sopwith@gmail.com', '+373 777 52 946', 'Bacioi', 12, 41),
	('vganesh@gmail.com', '+373 562 61 664', 'Cricova', 42, 29),
	('valdez@mail.com', '+373 790 90 897', 'Truseni', 14, 42),
	('timtroyr@gmail.com', '+373 562 32 022', 'Chisinau', 16, 33),
	('scarlet@yahoo.com', '+373 792 20 421', 'Balti', 18, 40),
	('kostas@mail.com', '+373 628 65 343', 'Ialoveni', 26, 9),
	('delpino@yahoo.ca', '+373 562 08 707', 'Truseni', 43, 22),
	('pjacklam@yahoo.com', '+373 760 64 704', 'Balti', 46, 32),
	('frostman@gmail.com', '+373 717 48 740', 'Cricova', 19, 30),
	('pereinar@gmail.com', '+373 786 24 451', 'Chisinau', 30, 20),
	('alastair@mail.com', '+373 562 22 373', 'Bacioi', 20, 10),
	('dwheeler@gmail.com', '+373 562 85 287', 'Truseni', 21, 21),
	('bjornk@gmail.com', '+373 562 42 600', 'Chisinau', 50, 11);

GO

--Inserarea datelor in tabelul CONCURSURI
INSERT INTO Concursuri (Denumire, AdresaDesfasurarii, Durata, DataDesfasuratii) VALUES
	('Marea Neagra', 'Chisinau', '01:30', '2021-10-30'),
	('Fantezie si Talent', 'Causeni', '02:30', '2021-10-13'),
	('AllStyles Dance Competition', 'Drochia', '02:00', '2021-06-24'),
	('Tinere Talente', 'Straseni', '01:30', '2021-05-29'),
	('Ghiocelul de Argint', 'Orhei', '02:00', '2021-06-09'),
	('Jocuri Dinamice si Dans', 'Vulcanesti', '02:30', '2021-05-27'),
	('Dincolo de Stele', 'Ceadir-Lunga', '01:30', '2021-10-10'),
	('Aplauze Talent', 'Chisinau', '01:30', '2021-10-09'),
	('Sisteme de Fulgi', 'Chisinau', '02:30', '2021-12-30'),
	('Puterea Stelelor', 'Chisinau', '02:00', '2021-08-20');
GO

--Inserarea datelor in tabelul ACTE
INSERT INTO Acte (IdDansator, IdConcurs) VALUES
	(4, 1),
	(22, 2),
	(39, 4),
	(3, 3),
	(49, 6),
	(40, 8),
	(21, 10),
	(37, 9),
	(50, 7),
	(38, 3),
	(2, 3),
	(1, 6),
	(36, 5),
	(48, 3),
	(23, 9),
	(10, 10),
	(20, 1),
	(41, 5),
	(46, 1),
	(11, 7),
	(19, 9),
	(28, 8),
	(6, 5),
	(18, 6),
	(34, 7),
	(5, 10),
	(27, 10),
	(35, 8),
	(29, 1),
	(24, 9),
	(45, 10),
	(47, 1),
	(15, 4),
	(12, 8),
	(44, 2),
	(9, 5),
	(26, 7),
	(30, 3),
	(14, 6),
	(17, 2),
	(33, 4),
	(32, 7),
	(13, 9),
	(25, 4),
	(43, 8),
	(7, 4),
	(16, 2),
	(42, 6),
	(8, 5),
	(31, 2);
GO

--Inserarea datelor in tabelul PREMII
INSERT INTO Premii (Locul, PremiuBanesc, IdDansator, IdConcurs) VALUES
	('I', 1000, 4, 1),
	('I', 1500, 8, 5),
	('I', 3000, 2, 3),
	('I', 2500, 42, 6),
	('I', 2000, 23, 9),
	('I', 1000, 39, 4),
	('I', 1500, 44, 2),
	('I', 3000, 28, 8),
	('I', 2500, 47, 10),
	('I', 2000, 11, 7),

	('II', 2000, 9, 5),
	('II', 500, 22, 2),
	('II', 1000, 35, 8),
	('II', 1750, 20, 1),
	('II', 2000, 49, 6),
	('II', 2000, 37, 9),
	('II', 500, 30, 3),
	('II', 1000, 5, 10),
	('II', 1750, 50, 7),
	('II', 2000, 33, 4),

	('III', 750, 7, 4),
	('III', 1500, 40, 8),
	('III', 1500, 36, 5),
	('III', 750, 32, 7),
	('III', 1500, 17, 2),

	('Mentiune', 1000, 41, 5),
	('Mentiune', 1000, 12, 8),
	('Mentiune', 500, 15, 4),
	('Mentiune', 100, 16, 2),
	('Mentiune', 1000, 34, 7);
GO

--Inserarea datelor in tabelul ADMINISTRATORI
INSERT INTO Utilizatori(Username, Parola, Email, EsteAdministrator) VALUES
	('Guest', NULL, NULL, 0),
	('Anastasia', '1234', 'exemplu@gmail.com', 1),
	('Lucas', '4321', 'lucas@gmail.com', 1);
GO

--PROCEDURI
--Procedura ce selecteaza denumirea concursurilor
CREATE OR ALTER PROCEDURE selectCompetition
AS
	SELECT Denumire FROM Concursuri
GO

--Procedura ce selecteaza dansatori
CREATE OR ALTER PROCEDURE selectDancers
AS
	SELECT * FROM Dansatori
GO

--Procedura ce selecteaza denumirea categoriilor de dans
CREATE OR ALTER PROCEDURE selectCategory
AS
	SELECT DenumireCategorie FROM CategorieDansuri
GO

--Procedura ce selecteaza denumirea tipurilor de dans
CREATE OR ALTER PROCEDURE selectDanceType
AS
	SELECT DenumireTipDans FROM TipuriDans
GO

--Procedura ce selecteaza participantii in functie de codul personal
CREATE OR ALTER PROCEDURE selectDancersByCode
@Code VARCHAR(6)
AS
	SELECT * FROM Dansatori
	WHERE CodDansator = @Code
GO

--Procedura ce afiseaza username-ul din vedere
CREATE OR ALTER PROCEDURE selectFromView
AS
	SELECT EsteAdministrator FROM currentUser
GO

--Procedura ce verifica daca username si parola introdusa, 
--corespunde cu datele din tabelul utilizatori
CREATE OR ALTER PROCEDURE checkUser
@Username VARCHAR(50), 
@Parola VARCHAR(25)
AS
	SELECT Username FROM Utilizatori
	WHERE Username = @Username AND
		  Parola = @Parola
GO

--ITEMUL 1
--Procedura ce inregistreaza un dansator nou
CREATE OR ALTER PROCEDURE insertDancer
@NumeInstitutie VARCHAR(100),
@AdresaInstitutie VARCHAR(50),

@DenumireTipDans VARCHAR(50),

@CodDansator VARCHAR(6),
@NumeDansator VARCHAR(20),
@PrenumeDansator VARCHAR(20),
@SexDansator VARCHAR(1),
@DataNasterii DATE,
@Experienta INT,

@DenumireConcurs VARCHAR(100),

@Email VARCHAR(50),
@Telefon VARCHAR(15),
@AdresaDansator VARCHAR(50)
AS
	DECLARE @IdInstitutie INT,
			@IdDansator INT
	
	IF NOT EXISTS((SELECT NumeInstitutie, Adresa FROM Institutii
				   WHERE NumeInstitutie = @NumeInstitutie AND 
						 Adresa = @AdresaInstitutie))
	BEGIN
		INSERT INTO Institutii (NumeInstitutie, Adresa) VALUES
			(@NumeInstitutie, @AdresaInstitutie);

		SET @IdInstitutie = (SELECT MAX(IdInstitutie) FROM Institutii);
	END
	ELSE
	BEGIN
		SET @IdInstitutie = (SELECT IdInstitutie FROM Institutii
							 WHERE NumeInstitutie = @NumeInstitutie AND 
								   Adresa = @AdresaInstitutie);
	END
	
	INSERT INTO Dansatori (CodDansator, Nume, Prenume, Sex, DataNasterii, Experienta, IdTipDans) VALUES
		(@CodDansator, @NumeDansator, @PrenumeDansator, @SexDansator, @DataNasterii, @Experienta, (SELECT IdTipDans FROM TipuriDans
																								   WHERE DenumireTipDans = @DenumireTipDans));
	SET @IdDansator = (SELECT MAX(IdDansator) FROM Dansatori);

	INSERT INTO DateDeContact (Email, Telefon, Adresa, IdInstitutie, IdDansator) VALUES
		(@Email, @Telefon, @AdresaDansator, @IdInstitutie, @IdDansator);

	INSERT INTO Acte (IdDansator, IdConcurs) VALUES
		(@IdDansator, (SELECT IdConcurs FROM Concursuri
					   WHERE Denumire = @DenumireConcurs));

GO

--Procedura ce insereaza premiul unui dansator
CREATE OR ALTER PROCEDURE insertPrize
@Locul VARCHAR(20),
@PremiuBanesc MONEY,
@DenumireConcurs VARCHAR(100)
AS
	DECLARE @IdDansator INT,
			@IdConcurs INT

	INSERT INTO Premii (Locul, PremiuBanesc, IdDansator, IdConcurs) VALUES
		(@Locul, @PremiuBanesc, (SELECT MAX(IdDansator) FROM Dansatori), (SELECT IdConcurs FROM Concursuri 
																		  WHERE Denumire = @DenumireConcurs));
GO

--ITEMUL 2
--Procedura ce exclude un dasator, in functie de codul introdus
CREATE OR ALTER PROCEDURE deleteDancer
@CodDansator VARCHAR(60)
AS
	DELETE FROM Dansatori 
	WHERE CodDansator = @CodDansator
GO

--ITEMUL 3
--Procedura ce selecteaza participantul cel mai tanar si ce tip de dans practica
CREATE OR ALTER PROCEDURE youngestDancer
AS
	SELECT CodDansator, Nume, Prenume, DataNasterii, DenumireTipDans FROM Dansatori
		INNER JOIN TipuriDans
		ON Dansatori.IdTipDans = TipuriDans.IdTipDans
	WHERE DataNasterii = (SELECT MAX(DataNasterii) FROM Dansatori)
GO

--Procedura ce selecteaza participantul cel mai in varsta si ce tip de dans practica
CREATE OR ALTER PROCEDURE oldestDancer
AS
	SELECT CodDansator, Nume, Prenume, DataNasterii, DenumireTipDans FROM Dansatori
		INNER JOIN TipuriDans
		ON Dansatori.IdTipDans = TipuriDans.IdTipDans
	WHERE DataNasterii = (SELECT MIN(DataNasterii) FROM Dansatori)
GO

--ITEMUL 4
--Procedura ce ordoneaza ascendent toti dansatorii, dupa varsta
CREATE OR ALTER PROCEDURE sortAscAllDancersByDate
AS
	SELECT Nume, Prenume, DataNasterii FROM Dansatori
	ORDER BY DataNasterii DESC
GO

--Procedura ce ordoneaza ascendent dansatorii dintr-un concurs, dupa varsta
CREATE OR ALTER PROCEDURE sortDancersASCFromOneCompetitionByDate
@DenumireConcurs VARCHAR(100)
AS
	SELECT Nume, Prenume, DataNasterii FROM Dansatori
		INNER JOIN Acte
		ON Acte.IdDansator = Dansatori.IdDansator
			INNER JOIN Concursuri
			ON Concursuri.IdConcurs = Acte.IdConcurs
	WHERE Denumire = @DenumireConcurs
	ORDER BY DataNasterii DESC
GO

--ITEMUL 5
--Procedura ce selecteaza codul, numele, prenumele, data nasterii si genul
--celei mai tinere persoane de sex feminin
CREATE OR ALTER PROCEDURE youngestFemaleDancer
AS
	SELECT CodDansator, Nume, Prenume, DataNasterii, Sex FROM Dansatori
	WHERE DataNasterii = (SELECT MAX(DataNasterii) FROM Dansatori) AND 
		  Sex = 'F'
GO

--ITEMUL 6
--Procedura ce selecteaza lista participantilor la categoria de dans indicata
CREATE OR ALTER PROCEDURE selectDancersByCategory
@DenumireCategorie VARCHAR(50)
AS
	SELECT Dansatori.*, CategorieDansuri.DenumireCategorie FROM Dansatori
		INNER JOIN TipuriDans
		ON Dansatori.IdTipDans = TipuriDans.IdTipDans
			INNER JOIN CategorieDansuri
			ON CategorieDansuri.IdCategorie = TipuriDans.IdCategorie
	WHERE CategorieDansuri.DenumireCategorie = @DenumireCategorie
GO

--ITEMUL 7
--Procedura ce afiseaza danstatorii barbati pentru fiecare categorie de dans
CREATE OR ALTER PROCEDURE selectMaleDancersByCategory
@DenumireCategorie VARCHAR(50)
AS
	SELECT DataNasterii FROM Dansatori
		INNER JOIN TipuriDans
		ON Dansatori.IdTipDans = TipuriDans.IdTipDans
			INNER JOIN CategorieDansuri
			ON CategorieDansuri.IdCategorie = TipuriDans.IdCategorie
	WHERE CategorieDansuri.DenumireCategorie = @DenumireCategorie AND
		  Sex = 'M'
GO

--ITEMUL 8
--Procedura ce ajuta la exportarea intr-un fisier MS Excel lista tuturor
--participantelor cu varsta sub o varsta introdusa
CREATE OR ALTER PROCEDURE selectFemaleDancersUnderIntroducedYears
@DataIntrodusa DATE
AS
	SELECT CodDansator, Nume, Prenume, Experienta, DataNasterii FROM Dansatori
	WHERE DataNasterii > @DataIntrodusa AND
		  Sex = 'F'
GO

--ITEMUL 9
--Vederea ce creeaza o vedere ce contine date de contact al fiecarui dansator
CREATE OR ALTER PROCEDURE createView
AS
	GO
	CREATE OR ALTER VIEW selectDateDeContact (CodDansator, Nume, Prenume, Email, Telefon, Adresa)
	AS SELECT CodDansator, Nume, Prenume, Email, Telefon, Adresa FROM DateDeContact
		INNER JOIN Dansatori
		ON Dansatori.IdDansator = DateDeContact.IdDansator
GO

--Procedura ce preia datele din vedere
CREATE OR ALTER PROCEDURE selectContactData
AS
	SELECT * FROM selectDateDeContact
GO

--ITEMUL 10
--Procedura ce afiseaza lista participantilor si institutia unde isi fac studiile
CREATE OR ALTER PROCEDURE selectDancersAndInstitution
AS
	SELECT CodDansator, Nume, Prenume, NumeInstitutie FROM Dansatori
		INNER JOIN DateDeContact
		ON Dansatori.IdDansator = DateDeContact.IdDansator
			INNER JOIN Institutii
			ON DateDeContact.IdInstitutie = Institutii.IdInstitutie
GO

--ITEMUL 11
--Procedura ce afiseaza codul, numele, prenumele, locul dansatorului, 
--in functie de concursul selectat
CREATE OR ALTER PROCEDURE selectDancerPrizeByCompetition
@DenumireConcurs VARCHAR(100)
AS
	SELECT CodDansator, Nume, Prenume, Locul FROM Dansatori
		INNER JOIN Premii
		ON Dansatori.IdDansator = Premii.IdDansator
			INNER JOIN Concursuri
			ON Concursuri.IdConcurs = Premii.IdConcurs
	WHERE Denumire = @DenumireConcurs
	ORDER BY Locul
GO

--ITEMUL 12
--Procedura ce selecteaza participantii in functie de denumirea concursului
CREATE OR ALTER PROCEDURE selectDancersByCompetitionName
@CompetitionName VARCHAR(100)
AS
	SELECT Nume, Prenume FROM Dansatori
		INNER JOIN Acte
		ON Acte.IdDansator = Dansatori.IdDansator
			INNER JOIN Concursuri
			ON Concursuri.IdConcurs = Acte.IdConcurs
	WHERE Concursuri.Denumire = @CompetitionName
GO

/*
SELECT * FROM CategorieDansuri
SELECT * FROM TipuriDans
SELECT * FROM Dansatori
SELECT * FROM Acte
SELECT * FROM DateDeContact
SELECT * FROM Institutii
SELECT * FROM Concursuri
SELECT * FROM Premii
SELECT * FROM Utilizatori
*/