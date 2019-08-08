create database controlequipos;
use controlequipos;

CREATE TABLE dominios(
tipo_domino varchar(30),
id_domino   varchar(5),
vlr_domino  varchar(50),
primary key(tipo_domino,id_domino));

CREATE TABLE  marcas(
id_marca  int             primary key identity(1,1),
nom_marca varchar(50)     not null );

CREATE TABLE perifericos(
serial_perif   varchar(30) primary key,
tipo_perif     varchar(5)  not null);

CREATE TABLE  personas(
id_persona    numeric(15) primary key,
ape_persona   varchar(50) not null,
nom_persona  varchar(50) not null,
tel_persona   numeric(10) not null,
email_persona varchar(100)not null ,
tipo_persona  varchar(5)  not null,
contrasena    varchar(15) not null);

CREATE TABLE salas(
id_sala   int         primary key identity(1,1),
nomb_sala  varchar(30) not null   unique,
piso       int         not null,
capacidad  int         not null);

CREATE TABLE equipos(
serial_equipo varchar(30) primary key,
nro_equippo   int         not null,
tipo_equipo   varchar(5)  not null,
id_marca      int         not null,
id_sala       int         not null,
foreign key (id_marca) references marcas (id_marca),
foreign key (id_sala) references salas (id_sala));

CREATE TABLE caracteristicas(
id_caract  int         primary key identity (1,1),
nom_caract varchar(50) not null,
und_medida varchar(5)  not null);

CREATE TABLE  software(
id_softaware int           primary key identity(1,1),
nom_software  varchar(100) not null,
cod_licencia  varchar(100),
tipo_licencia varchar(5)   not null);

CREATE TABLE solicitudes(
nro_solicitud   int        primary key identity(1,1),
fecha_solicitud date       not null,
fecha_atencion  date,
fecha_cierre    date,
obs_solicitud   varchar(600),
tipo_solicitud  varchar(5)  not null,
id_persona_sol  numeric(15) not null,
id_persona_ati  numeric(15),
foreign key (id_persona_sol) references personas (id_persona),
foreign key (id_persona_ati) references personas (id_persona));

CREATE TABLE  equipos_caract(
serial_equipo      varchar(30)    not null,
id_caract          int            not null,
valor_desc         varchar(30)    not null,
foreign key (serial_equipo) references equipos (serial_equipo),
foreign key (id_caract) references caracteristicas (id_caract));

CREATE TABLE equipos_software(
serial_equipo     varchar(30) not null,
id_software        int        not null,
version_software   varchar(20),
vigencia           date,
foreign key (serial_equipo) references equipos (serial_equipo),
foreign key (id_software) references software (id_softaware));

CREATE TABLE solicitud_equipo(
serial_equipo      varchar(30)  not null,
nro_solicitud      int          not null,
det_solicitud      varchar(400) not null,
foreign key (serial_equipo) references equipos(serial_equipo),
foreign key (nro_solicitud) references solicitudes (nro_solicitud));


select * from marcas;

insert into salas values (

);