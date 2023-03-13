CREATE DATABASE SistemaComiclandia
GO
USE SistemaComiclandia
GO
CREATE TABLE cliente(
cod_cliente char(10) primary key,
nombres varchar(50),
apellidos varchar(50),
dni varchar(10),
sexo varchar(15),
direccion varchar(50),
telefono varchar(10),
estado char(1))
GO
CREATE TABLE venta(
num_documento char(10) primary key ,
serie	char(4), ---Defecto 
fecha		date ,
cod_cliente	char(10),
dni varchar(10),
total decimal(18,2),
estado		char(1)
)
GO
CREATE TABLE producto(
cod_producto char(10) primary key,
nombre		varchar(50),
precio		decimal(9,2) ,
stock		int ,
estado		char(1),
)
GO
CREATE TABLE detalleventa(
num_documento	char(10) ,
serie	char(4) ,
cod_producto char(10) ,
cantidad	int ,
precio		decimal(9,2) ,
)
GO
----alterando tablas,agregando su llave foranea
ALTER TABLE detalleventa add foreign key(num_documento)
references venta(num_documento)
GO
ALTER TABLE venta add foreign key(cod_cliente)
references cliente(cod_cliente)
GO
ALTER TABLE detalleventa add foreign key(cod_producto)
references producto(cod_producto)
GO
------------------------PROCEDIMIENTOS ALMACENADOS
CREATE PROC mostrar_producto
AS
select * from producto where estado = 1
GO
CREATE PROC buscar_producto(
@texto varchar(50) = '%')
AS
select * from producto where nombre like '%'+@texto+'%' and estado = '1'
go
CREATE PROC insertar_cliente(
@cod_cliente char(10) output,
@nombres varchar(50),
@apellidos varchar(50),
@dni varchar(10),
@sexo varchar(15),
@direccion varchar(50),
@telefeono varchar(10)
)
AS
declare @num int
	begin
		if(select max(CONVERT(int,substring(cod_cliente,4,10))) from cliente) is not null
			begin
				select @num=max(CONVERT(int,substring(cod_cliente,4,10))) from cliente
				select @cod_cliente='CLI' + REPLICATE('0',7-
				DATALENGTH(convert(varchar,@num+1)))+
					CONVERT(varchar,@num+1)
		end
		else
			select @cod_cliente = 'CLI0000001'
			insert into cliente(cod_cliente,nombres,apellidos,dni,sexo,direccion,telefono,estado)
			values(@cod_cliente,@nombres,@apellidos,@dni,@sexo,@direccion,@telefeono,'1')
	end
GO
CREATE PROC editar_cliente(
@cod_cliente char(10) ,
@nombres varchar(50),
@apellidos varchar(50),
@dni varchar(10),
@sexo varchar(15),
@direccion varchar(50),
@telefeono varchar(10)
)
AS
update cliente set nombres=@nombres,apellidos=@apellidos,dni=@dni,sexo=@sexo,direccion=@direccion,telefono=@telefeono
where cod_cliente=@cod_cliente
GO
create proc eliminar_cliente(
@cod_cliente char(10))
AS
update cliente set estado='0' where cod_cliente=@cod_cliente
GO
create proc mostrar_cliente
AS
select cod_cliente AS CODIGO, nombres AS NOMBRES, apellidos AS APELLIDOS, direccion AS DIRECCION, telefono AS TELEFONO, dni AS CEDULA, sexo AS SEXO from cliente where estado='1'
GO
create proc buscar_cliente(
@texto varchar(50) = '%')
AS
select cod_cliente AS CODIGO, nombres AS NOMBRES, apellidos AS APELLIDOS, direccion AS DIRECCION, telefono AS TELEFONO, dni AS CEDULA, sexo AS SEXO from cliente where (nombres like '%'+@texto+'%' or apellidos like '%'+@texto+'%' ) and estado = '1'
GO

create proc insertar_venta(
@num_documento char(10) output,
@cod_cliente char(10),
@dni_cliente varchar(10),
@total decimal(18,2))
AS
insert into venta(num_documento,serie,fecha,cod_cliente,dni,total,estado)
			values(@num_documento,'001',GETDATE(),@cod_cliente,@dni_cliente,@total,'1')
GO
CREATE PROC ingresa_detalle(
@num_documento char(10) out,
@cod_producto char(10),
@cantidad int,
@precio decimal(9,2)
)
AS
insert into detalleventa(num_documento,serie,cod_producto,cantidad,precio)
values(@num_documento,'001',@cod_producto,@cantidad,@precio)
GO
CREATE PROC mostrar_ventas
AS
select v.num_documento as 'Numero de Documento',v.serie as 'Numero de Serie',v.fecha,c.nombres +' ' + c.apellidos as 'Cliente',
v.total as 'Ganancia',v.estado from cliente c inner join venta v on c.cod_cliente=v.cod_cliente
GO
CREATE VIEW ventasview
AS
select v.num_documento as 'NumeroDocumento',v.serie as 'Numero de Serie',v.fecha,c.nombres +' ' + c.apellidos as 'Cliente',
v.total as 'Ganancia',v.estado from cliente c inner join venta v on c.cod_cliente=v.cod_cliente
GO
CREATE PROC buscar_venta
(@texto varchar(50) = '%')
AS
select * from ventasview where (NumeroDocumento like '%'+@texto+'%' or Cliente like '%'+@texto+'%') and estado = '1'
GO

CREATE PROC vertotal
AS
select sum(total) as 'total' from venta where estado = '1'
GO

INSERT INTO cliente(cod_cliente,nombres,apellidos,dni,sexo,direccion,telefono,estado)
VALUES('CLI0000001','JAIME','CARRASQUERO','1232592453','Masculino','MEDELLIN','3212639965','1')
GO
INSERT INTO cliente(cod_cliente,nombres,apellidos,dni,sexo,direccion,telefono,estado)
VALUES('CLI0000002','ASHLEY','CARRASQUERO','1232592478','Femenino','MEDELLIN','3195245555','1')
GO
INSERT INTO cliente(cod_cliente,nombres,apellidos,dni,sexo,direccion,telefono,estado)
VALUES('CLI0000003','ILIANI','JIMENEZ','852412','Femenino','MEDELLIN','319852455','1')
GO
INSERT INTO cliente(cod_cliente,nombres,apellidos,dni,sexo,direccion,telefono,estado)
VALUES('CLI0000004','ELVIRA','VALDERRAMA','215254525','Femenino','MEDELLIN','3205418755','1')
GO
INSERT INTO producto(cod_producto,nombre,precio,stock,estado)
VALUES('PRO0000001','ACEITE CALIENTE','22800','10','1')
GO
INSERT INTO producto(cod_producto,nombre,precio,stock,estado)
VALUES('PRO0000002','LUBRICANTE','15600','20','1')
GO
INSERT INTO producto(cod_producto,nombre,precio,stock,estado)
VALUES('PRO0000003','LENCERIA','98900','30','1')
GO
INSERT INTO producto(cod_producto,nombre,precio,stock,estado)
VALUES('PRO0000004','HIGIENE','48500','50','1')
GO