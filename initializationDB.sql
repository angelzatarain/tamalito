CREATE DATABASE tamalito;

USE tamalito;

CREATE TABLE empleados(
idEmpleado INTEGER PRIMARY KEY,
nombre VARCHAR(30) NOT NULL,
apellidoP VARCHAR(30) NOT NULL,
apellidoM VARCHAR(30) NOT NULL,
fechaNac DATE,
sexo CHAR(1) NOT NULL,
direccion VARCHAR(40),
puesto VARCHAR(20) NOT NULL,
contrasenia VARCHAR(16) NOT NULL
);

CREATE TABLE telefonos(
idEmpleado INTEGER PRIMARY KEY,
telefono INTEGER,
);

CREATE TABLE clientes(
idCliente INTEGER PRIMARY KEY,
numTarjeta VARCHAR(30),
correo VARCHAR(30),
nombre VARCHAR(30),
apellidoP VARCHAR(30),
apellidoM VARCHAR(30),
);

CREATE TABLE pedidos(
idPedido INTEGER PRIMARY KEY,
fecha DATE,
hora TIME,
idCliente INTEGER REFERENCES clientes(idCliente),
idEmpleado INTEGER REFERENCES empleados(idEmpleado)
);

CREATE TABLE productos(
idProducto INTEGER PRIMARY KEY,
costo INTEGER,
inventario INTEGER, --cantidad de ese producto
nombre VARCHAR(30),
descripcion VARCHAR(270),
categoria VARCHAR(30),
tiempoPreparacion INTEGER,
urlImage VARCHAR(30)
);

CREATE TABLE pedidosProductos(
idPedido INTEGER FOREIGN KEY REFERENCES pedidos(idPedido),
idProducto INTEGER FOREIGN KEY REFERENCES productos(idProducto),
cantidad INTEGER --cantidad de ese producto
);
