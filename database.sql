create table filiere
(
	id_filiere int primary key identity(1,1),
	nom_filiere varchar(25)
)


create table Etudiant
(
	id_etudiant integer primary key identity(1,1),
	cne varchar(10) unique,
	nom varchar(25),
	prenom varchar(25),
	adresse varchar(100),
	sexe char CHECK (sexe in ('F','M')),
	date_naissance date,
	tele varchar(15),
	id_filiere int references filiere(id_filiere)


)






