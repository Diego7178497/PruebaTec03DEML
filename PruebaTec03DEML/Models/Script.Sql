-- Creaci�n de la base de datos
CREATE DATABASE Rutas;
GO

-- Uso de la base de datos reci�n creada
USE Rutas;
GO

-- Creaci�n de la tabla Autores
CREATE TABLE Rutas (
    RutaId INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    
);


-- Creaci�n de la tabla Libros
CREATE TABLE Buses (
    AutobusId INT PRIMARY KEY IDENTITY,
    Modelo NVARCHAR(100) NOT NULL,
    Placa NVARCHAR(20) NOT NULL,
    CapacidadPasajeros INT,
	Imagen IMAGE,
    RutaId INT FOREIGN KEY REFERENCES Rutas(RutaId)
);