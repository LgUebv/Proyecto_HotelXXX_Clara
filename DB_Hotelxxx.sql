create database Hotel;
use Hotel;

create table Usuarios(
    idUsuario int primary key auto_increment,
    Username varchar(255) unique,
    Password varchar(255),
    Rol enum('Administrador', 'Empleado')
);

create table Clientes(
    idCliente int primary key auto_increment,
    Nombre varchar(255),
    ApellidoP varchar(255),
    ApellidoM varchar(255)
);

create table Habitaciones(
    idHabitacion int primary key auto_increment,
    Tipo enum('Individual', 'Matrimonial', 'Cogelona'),
    Capacidad int,
    PrecioNoche decimal(10,2),
    Estado enum('Disponible', 'Ocupada'),
    Descripcion varchar(255)
);

create table reservaciones(
    idReservacion int primary key auto_increment,
    FK_IdCliente int,
    FK_IdHabitacion int,
    Dias int,
    FechaReservacion timestamp default current_timestamp,
    FechaTermino date
);


------------------- PROCEDIMIENTOS ALMACENADOS -------------------------

-- CRUD Usuarios --
drop procedure if exists p_AgregarUsuario;
create procedure p_AgregarUsuario(
    in p_Username varchar(255),
    in p_Password varchar(255),
    in p_Rol varchar(255)
)
begin
    if p_Rol in ('Administrador', 'Empleado') then
        insert into Usuarios (Username, Password, Rol)
        values (p_Username, p_Password, p_Rol);
    else
        signal sqlstate '45000'
        set message_text = 'El rol ingresado no es válido. Debe ser Administrador o Empleado.';
    end if;
end;

drop procedure if exists p_EditarUsuario;
create procedure p_EditarUsuario(
    in p_idUsuario int,
    in p_Username varchar(255),
    in p_Password varchar(255),
    in p_Rol varchar(255)
)
begin
    if p_Rol in ('Administrador', 'Empleado') then
        update Usuarios 
            set Username = p_Username,
                Password = p_Password,
                Rol = p_Rol
            where idUsuario = p_idUsuario;
    else 
        signal sqlstate '45000'
        set message_text = 'El rol ingresado no es valido. Debe de ser Administrador o Empleado.';
    end if;
end;

drop procedure if exists p_EliminarUsuario;
create procedure p_EliminarUsuario(
    in p_idUsuario int
)
begin
    delete from Usuarios where idUsuario = p_idUsuario;
end;

-- CRUD Clientes --
drop procedure if exists p_AgregarCliente;
create procedure p_AgregarCliente(
    in p_Nombre varchar(255),
    in p_ApellidoP varchar(255),
    in p_ApellidoM varchar(255)
)
begin
    insert into Clientes (Nombre, ApellidoP, ApellidoM)
    values (p_Nombre, p_ApellidoP, p_ApellidoM);
end;

drop procedure if exists p_EditarCliente;
create procedure p_EditarCliente(
    in p_idCliente int,
    in p_Nombre varchar(255),
    in p_ApellidoP varchar(255),
    in p_ApellidoM varchar(255)
)
begin
    update Clientes
    set Nombre = p_Nombre,
        ApellidoP = p_ApellidoP,
        ApellidoM = p_ApellidoM
    where idCliente = p_idCliente;
end;

drop procedure if exists p_EliminarCliente;
create procedure p_EliminarCliente(
    in p_idCliente int
)
begin
    delete from Clientes where idCliente = p_idCliente;
end;


-- CRUD Habitaciones --
drop procedure if exists p_AgregarHabitacion;
create procedure p_AgregarHabitacion(
    in p_Tipo varchar(50),
    in p_Capacidad int,
    in p_PrecioNoche decimal(10,2),
    in p_Estado varchar(50),
    in p_Descripcion varchar(255)
)
begin
    if p_Tipo in ('Individual', 'Matrimonial', 'Cogelona') 
    and p_Estado in ('Disponible', 'Ocupada') then
        insert into Habitaciones (Tipo, Capacidad, PrecioNoche, Estado, Descripcion)
        values (p_Tipo, p_Capacidad, p_PrecioNoche, p_Estado, p_Descripcion);
    else
        signal sqlstate '45000'
        set message_text = 'El tipo o el estado ingresado no es válido.';
    end if;
end;

drop procedure if exists p_EditarHabitacion;
create procedure p_EditarHabitacion(
    in p_idHabitacion int,
    in p_Tipo varchar(50),
    in p_Capacidad int,
    in p_PrecioNoche decimal(10,2),
    in p_Estado varchar(50),
    in p_Descripcion varchar(255)
)
begin
    if p_Tipo in ('Individual', 'Matrimonial', 'Cogelona') 
    and p_Estado in ('Disponible', 'Ocupada') then
        update Habitaciones
        set Tipo = p_Tipo,
            Capacidad = p_Capacidad,
            PrecioNoche = p_PrecioNoche,
            Estado = p_Estado,
            Descripcion = p_Descripcion
        where idHabitacion = p_idHabitacion;
    else
        signal sqlstate '45000'
        set message_text = 'El tipo o el estado ingresado no es válido.';
    end if;
end;

drop procedure if exists p_EliminarHabitacion;
create procedure p_EliminarHabitacion(
    in p_idHabitacion int
)
begin
    delete from Habitaciones where idHabitacion = p_idHabitacion;
end;


-- CRUD Reservaciones --
drop procedure if exists p_AgregarReservacion;
create procedure p_AgregarReservacion(
    in p_FK_IdCliente int,
    in p_FK_IdHabitacion int,
    in p_Dias int,
    in p_FechaTermino date
)
begin
    if exists (select 1 from Clientes where idCliente = p_FK_IdCliente)
    and exists (select 1 from Habitaciones where idHabitacion = p_FK_IdHabitacion) then
        insert into Reservaciones (FK_IdCliente, FK_IdHabitacion, Dias, FechaTermino)
        values (p_FK_IdCliente, p_FK_IdHabitacion, p_Dias, p_FechaTermino);
    else
        signal sqlstate '45000'
        set message_text = 'El cliente o la habitación no existen.';
    end if;
end;

drop procedure if exists p_EditarReservacion;
create procedure p_EditarReservacion(
    in p_idReservacion int,
    in p_FK_IdCliente int,
    in p_FK_IdHabitacion int,
    in p_Dias int,
    in p_FechaTermino date
)
begin
    if exists (select 1 from Clientes where idCliente = p_FK_IdCliente)
    and exists (select 1 from Habitaciones where idHabitacion = p_FK_IdHabitacion) then
        update Reservaciones
        set FK_IdCliente = p_FK_IdCliente,
            FK_IdHabitacion = p_FK_IdHabitacion,
            Dias = p_Dias,
            FechaTermino = p_FechaTermino
        where idReservacion = p_idReservacion;
    else
        signal sqlstate '45000'
        set message_text = 'El cliente o la habitación no existen.';
    end if;
end;

drop procedure if exists p_EliminarReservacion;
create procedure p_EliminarReservacion(
    in p_idReservacion int
)
begin
    delete from Reservaciones where idReservacion = p_idReservacion;
end;


------------------------------- REGISTROS ---------------------------------------
CALL p_AgregarUsuario('pepin', SHA1('1234'), 'Administrador');
CALL p_AgregarUsuario('pepinilla', SHA1('1234'), 'Empleado');

CALL p_AgregarCliente('Juan', 'Pérez', 'Martínez');
CALL p_AgregarCliente('Ana', 'López', 'Hernández');

CALL p_AgregarHabitacion('Individual', 1, 500.00, 'Disponible', 'Habitación pequeña para una persona');
CALL p_AgregarHabitacion('Matrimonial', 2, 800.00, 'Disponible', 'Habitación para parejas con cama matrimonial');

CALL p_AgregarReservacion(1, 1, 3, '2024-11-30'); -- Juan Pérez reservando habitación individual por 3 días
CALL p_AgregarReservacion(2, 2, 5, '2024-12-05'); -- Ana López reservando habitación matrimonial por 5 días


----------------------------- VISTAS -------------------------------------------
select * from Usuarios;
select * from Clientes;
select * from Habitaciones;
select * from Reservaciones;

create view Historial_Cliente as
select c.Nombre as Nombre_Cliente, 
        c.ApellidoP as Apellido_Pat, 
        c.ApellidoM as Apellido_Mat, 
        h.idHabitacion as Habitacion, 
        h.Tipo as Tipo, 
        r.dias as dias,
        r.FechaReservacion as Fecha_De_Reservacion,
        r.FechaTermino as Fecha_De_Termino
    from Clientes as c 
    Left join Reservaciones as r on c.idCliente = r.FK_IdCliente
    Left join Habitaciones as h on r.FK_IdHabitacion = h.idHabitacion;

select * from Historial_Cliente where Nombre_Cliente = "Juan";