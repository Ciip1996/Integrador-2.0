CREATE DATABASE IntegradorBD
GO
Use IntegradorBD
GO
CREATE TABLE Catalogo(
	codigo varchar(10) PRIMARY KEY,
	estilo varchar(100),
	precioMaquila float,
	precioVenta float,
	descripcion varchar(250),
	foto varchar(100),
	marca int
);
GO
CREATE TABLE Inventario(
	NoEntrada int PRIMARY KEY NOT NULL IDENTITY,
	codigo varchar(10) FOREIGN KEY REFERENCES Catalogo(codigo) NOT NULL,
	observaciones varchar(150),
	fechaEntrada date NOT NULL,
	fechaSalida date,
	cantidad int NOT NULL,
	categoria int NOT NULL,
	estatus int NOT NULL,
);
CREATE TABLE Empleado(
	idEmpleado int NOT NULL PRIMARY KEY IDENTITY,
	nombre varchar(50) NOT NULL,
	puesto varchar(150) NOT NULL,
	fechaIngreso date NOT NULL,
	estatus int NOT NULL, 
	fechaEgreso date
);

