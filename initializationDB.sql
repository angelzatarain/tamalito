---------------------------------------------------CREATE DATABASE----------------------------------------------------
CREATE DATABASE tamalito;

USE tamalito;

CREATE TABLE empleados(
idEmpleado INTEGER IDENTITY(1,1) PRIMARY KEY ,
nombre VARCHAR(30) NOT NULL,
apellidoP VARCHAR(30) NOT NULL,
apellidoM VARCHAR(30) NOT NULL,
fechaNac DATE,
sexo CHAR(1) NOT NULL,
direccion VARCHAR(40),
puesto VARCHAR(20) NOT NULL,
contrasenia VARCHAR(16) NOT NULL,
activo TINYINT DEFAULT 1
);

CREATE TABLE telefonos(
idEmpleado INTEGER PRIMARY KEY,
telefono INTEGER,
);

CREATE TABLE clientes(
idCliente INTEGER IDENTITY(1,1) PRIMARY KEY,
numTarjeta VARCHAR(30),
correo VARCHAR(30),
nombre VARCHAR(30),
apellidoP VARCHAR(30),
apellidoM VARCHAR(30),
);

CREATE TABLE pedidos(
idPedido INTEGER IDENTITY(1,1) PRIMARY KEY,
fechaHora DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
idCliente INTEGER REFERENCES clientes(idCliente),
idEmpleado INTEGER REFERENCES empleados(idEmpleado)
);

CREATE TABLE productos(
idProducto INTEGER IDENTITY(1,1) PRIMARY KEY,
costo INTEGER,
inventario INTEGER, --cantidad de ese producto
nombre VARCHAR(30),
descripcion VARCHAR(270),
categoria VARCHAR(30),
tiempoPreparacion INTEGER,
urlImagen VARCHAR(50)
);

CREATE TABLE pedidosProductos(
idPedido INTEGER FOREIGN KEY REFERENCES pedidos(idPedido),
idProducto INTEGER FOREIGN KEY REFERENCES productos(idProducto),
cantidad INTEGER --cantidad de ese producto
);

---------------------------------------------------INITIALIZE VALUES----------------------------------------------------

--EMPLEADOS--
INSERT INTO empleados(nombre, apellidoP, apellidoM, fechaNac, sexo, direccion, puesto, contrasenia,activo) 
VALUES('Angel', 'Zatarain', 'López', '1999-03-11', 'H', 'Cancún', 'Empleado', '1', 1);

INSERT INTO empleados( nombre, apellidoP, apellidoM, fechaNac, sexo, direccion, puesto, contrasenia,activo) 
VALUES('José', 'Cortés', 'Gasca', '2019-12-10', 'H', 'CDMX', 'Gerente', '2', 1);

INSERT INTO empleados(nombre, apellidoP, apellidoM, fechaNac, sexo, direccion, puesto, contrasenia, activo) 
VALUES('Diego', 'Hernández', 'Delgado', '2019-11-10', 'H', 'EUA', 'Dueño', '3',1);

INSERT INTO telefonos(idEmpleado, telefono) VALUES(1, 55543267);
INSERT INTO telefonos(idEmpleado, telefono) VALUES(2, 55549999);
INSERT INTO telefonos(idEmpleado, telefono) VALUES(3, 55567888);

--CLIENTES--
INSERT INTO clientes(numTarjeta, correo, nombre, apellidoP, apellidoM) VALUES( '55658932', 'cliente1@gmail.com', 'Juan', 'Gómez', 'Peralta');
INSERT INTO clientes(numTarjeta, correo, nombre, apellidoP, apellidoM) VALUES( '55677733', 'cliente2@gmail.com', 'Paco', 'Pérez', 'Lenovos');
INSERT INTO clientes(numTarjeta, correo, nombre, apellidoP, apellidoM) VALUES( '55999988', 'cliente3@gmail.com', 'Luis', 'Casas', 'Bonitas');

--PRODUCTOS--
--TAMALES--
INSERT INTO productos(costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(15, 20, 'verde', 'Delicioso tamal verde', 'tamal', 30, './images/productos/tamales/verde.jpg');

INSERT INTO productos(costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(15, 20, 'rojo', 'Delicioso tamal rojo', 'tamal', 30, './images/productos/tamales/rojo.jpg');

INSERT INTO productos(costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(15, 20, 'mole', 'Delicioso tamal mole', 'tamal', 30, './images/productos/tamales/mole.jpg');

INSERT INTO productos(costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(15, 20, 'dulce', 'Delicioso tamal dulce', 'tamal', 30, './images/productos/tamales/dulce.jpg');

--ATOLES--
INSERT INTO productos(costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(12, 30, 'arroz', 'Delicioso atole de arroz', 'atole', 20, './images/productos/atoles/verde.jpg');

INSERT INTO productos(costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(12, 30, 'vainilla', 'Delicioso atole de vainilla', 'atole', 20, './images/productos/atoles/rojo.jpg');

INSERT INTO productos(costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(12, 30, 'fresa', 'Delicioso atole de fresa', 'atole', 20, './images/productos/atoles/mole.jpg');

INSERT INTO productos(costo, inventario, nombre, descripcion, categoria, tiempoPreparacion, urlImagen) 
VALUES(12, 30, 'chocolate', 'Delicioso atole de chocolate', 'atole', 20, './images/productos/atoles/dulce.jpg');


--PEDIDOS--
INSERT INTO pedidos(idCliente, idEmpleado) VALUES(1,1);
INSERT INTO pedidos(idCliente, idEmpleado) VALUES(2,2);
INSERT INTO pedidos(idCliente, idEmpleado) VALUES(3,3);

INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(1,1,2);
INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(1,3,2);
INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(1,4,5);

INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(2,1,1);
INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(2,2,1);

INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(3,2,3);
INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(3,3,3);
INSERT INTO pedidosProductos(idPedido, idProducto, cantidad) VALUES(3,4,3);
