using System.Reflection;

CREATE DATABASE WebDB;

USE WebDB;

CREATE TABLE Equipos(
    EquipolD INT PRIMARY KEY,
    TipoEquipo TEXT(50),
    Modelo TEXT(50),
    UsuarioID INT,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);

CREATE TABLE Reparaciones(
    ReparacionID INT PRIMARY KEY,
    EquipolD INT,
    FechaSolicitud DATE,
    Estado TEXT(15),
    FechaInicio DATE,
    FechaFin DATE,
    FOREIGN KEY (EquipolD) REFERENCES Equipos(EquipolD)
);

CREATE TABLE Usuarios(
    UsuarioID INT PRIMARY KEY,
    FechaHora TIMESTAMP,
    Char1 TEXT(1),
    Nombre TEXT(50),
    CorreoElectronico TEXT(50),
    Telefono TEXT(50)
);

CREATE TABLE Tecnicos(
    TecnicolD INT PRIMARY KEY,
    Nombre TEXT(50),
    Especialidad TEXT(50)
);

CREATE TABLE Asignaciones(
    AsignacionID INT PRIMARY KEY,
    ReparacionID INT,
    TecnicolD INT,
    FechaAsignacion DATE,
    FOREIGN KEY (ReparacionID) REFERENCES Reparaciones(ReparacionID),
    FOREIGN KEY(TecnicolD) REFERENCES Tecnicos(TecnicolD)
);

CREATE TABLE DetallesReparacion(
    DetalleID INT PRIMARY KEY,
    ReparacionID INT,
    Descripcion TEXT(50),
    FechaHora TIMESTAMP,
    FOREIGN KEY (ReparacionID) REFERENCES Reparaciones(ReparacionID)
);
select* from WebDB