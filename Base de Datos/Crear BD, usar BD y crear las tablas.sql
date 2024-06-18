CREATE DATABASE GestorStock ON
(
	name=GestorStock,
	FILENAME='G:\C#\WPF\Diseño UI + Login + SQL Server\Diseño 2\Base de Datos\GestorStock.mdf'
);

USE GestorStock;

CREATE TABLE Usuario (
    UsuarioId INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Hash VARBINARY(256) NOT NULL,
    Salt VARBINARY(256) NOT NULL
);

CREATE TABLE Categoria (
    CategoriaId INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Producto (
    ProductoId INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    CategoriaId INT FOREIGN KEY REFERENCES Categoria(CategoriaId),
    Habilitado BIT NOT NULL
);

CREATE TABLE Compra (
    CompraId INT PRIMARY KEY IDENTITY(1,1),
    Fecha DATETIME NOT NULL,
    ProductoId INT FOREIGN KEY REFERENCES Producto(ProductoId),
    Cantidad INT NOT NULL,
    UsuarioId INT FOREIGN KEY REFERENCES Usuario(UsuarioId)
);

CREATE TABLE Venta (
    VentaId INT PRIMARY KEY IDENTITY(1,1),
    Fecha DATETIME NOT NULL,
    ProductoId INT FOREIGN KEY REFERENCES Producto(ProductoId),
    Cantidad INT NOT NULL,
    UsuarioId INT FOREIGN KEY REFERENCES Usuario(UsuarioId)
);