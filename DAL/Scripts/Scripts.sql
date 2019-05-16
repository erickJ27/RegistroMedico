CREATE DATABASE UsuariosDb
GO
USE UsuariosDb
GO
CREATE TABLE Usuarios
(
	Id int primary key identity,
	Nombre varchar(30),
	Email varchar(30),
	NivelUsuario int,
	Usuario varchar(30),
	Clave varchar(30),
	FechaIngreso datetime,



);