CREATE DATABASE UsuariosDb
GO
USE UsuariosDb
GO
CREATE TABLE Usuarios
(
	UsuarioId int primary key identity,
	Nombre varchar(30),
	Email varchar(30),
	NivelUsuario int,
	Usuario varchar(30),
	Clave varchar(30),
	FechaIngreso datetime,



);
CREATE TABLE Cargos 
(
	CargoId int primary key identity,
	Descripcion varchar(60),


);

USE UsuariosDb
EXEC sp_rename'Usuarios.Nombre','Nombres';


