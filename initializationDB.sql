---------------------------------------------------CREATE DATABASE----------------------------------------------------
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
contrasenia VARCHAR(16) NOT NULL,
activo TINYINT NOT NULL
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
urlImagen VARCHAR(30)
);

CREATE TABLE pedidosProductos(
idPedido INTEGER FOREIGN KEY REFERENCES pedidos(idPedido),
idProducto INTEGER FOREIGN KEY REFERENCES productos(idProducto),
cantidad INTEGER --cantidad de ese producto
);

---------------------------------------------------INITIALIZE VALUES----------------------------------------------------

--EMPLEADOS--
INSERT INTO empleados(idEmpleado, nombre, apellidoP, apellidoM, fechaNac, sexo, direccion, puesto, contrasenia,activo) 
VALUES(1, 'Angel', 'Zatarain', 'López', '1999-03-11', 'H', 'Cancún', 'Gerente', '1', 1);

INSERT INTO empleados(idEmpleado, nombre, apellidoP, apellidoM, fechaNac, sexo, direccion, puesto, contrasenia,activo) 
VALUES(2, 'José', 'Cortés', 'Gasca', '2019-12-10', 'H', 'CDMX', 'Gerente', '2', 1);

INSERT INTO empleados(idEmpleado, nombre, apellidoP, apellidoM, fechaNac, sexo, direccion, puesto, contrasenia, activo) 
VALUES(3, 'Diego', 'Hernández', 'Delgado', '2019-11-10', 'H', 'EUA', 'Dueño', '3',1);

INSERT INTO telefonos(idEmpleado, telefono) VALUES(1, 55543267);
INSERT INTO telefonos(idEmpleado, telefono) VALUES(2, 55549999);
INSERT INTO telefonos(idEmpleado, telefono) VALUES(3, 55567888);

--CLIENTES--
INSERT INTO clientes(idCliente, numTarjeta, correo, nombre, apellidoP, apellidoM) VALUES(1, '55658932', 'cliente1@gmail.com', 'Juan', 'Gómez', 'Peralta');
INSERT INTO clientes(idCliente, numTarjeta, correo, nombre, apellidoP, apellidoM) VALUES(2, '55677733', 'cliente2@gmail.com', 'Paco', 'Pérez', 'Lenovos');
INSERT INTO clientes(idCliente, numTarjeta, correo, nombre, apellidoP, apellidoM) VALUES(3, '55999988', 'cliente3@gmail.com', 'Luis', 'Casas', 'Bonitas');

--PRODUCTOS--
INSERT INTO productos(idProducto, costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(1, 15, 20, 'verde', 'Delicioso tamal verde', 'tamal', 30, './images/productos/verde.jpg');

INSERT INTO productos(idProducto, costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(2, 15, 20, 'rojo', 'Delicioso tamal rojo', 'tamal', 30, './images/productos/rojo.jpg');

INSERT INTO productos(idProducto, costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(3, 15, 20, 'mole', 'Delicioso tamal mole', 'tamal', 30, './images/productos/mole.jpg');

INSERT INTO productos(idProducto, costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(4, 15, 20, 'dulce', 'Delicioso tamal dulce', 'tamal', 30, './images/productos/dulce.jpg');

--PEDIDOS--
INSERT INTO pedidos(idPedido, fecha, hora, idCliente, idEmpleado) VALUES(1, '2019-11-03', '00:00', 1,1);
INSERT INTO pedidos(idPedido, fecha, hora, idCliente, idEmpleado) VALUES(2, '2019-11-03', '00:00', 2,2);
INSERT INTO pedidos(idPedido, fecha, hora, idCliente, idEmpleado) VALUES(3, '2019-11-03', '00:00', 3,3);

INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(1,1,2);
INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(1,3,2);
INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(1,4,5);

INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(2,1,1);
INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(2,2,1);

INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(3,2,3);
INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(3,3,3);
INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(3,4,3);
