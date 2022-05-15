Create Database Aviatur
Go

Use Aviatur 

Go

Create table  Ciudades (
CIUCodigo  int not null, 
CIUDescripcion varchar(200) not null
CONSTRAINT PK_Ciudades PRIMARY KEY (CIUCodigo)
);
GO
 INSERT Into Ciudades Values (63401,'La Tebaida'),(08758,'Soledad'),
 (11001,'Bogotá'),(68001,'BUCARAMANGA'),(76520,'Palmira'),(54001,'Cúcuta'),(13001,'Cartagena'),(91001,'Leticia'),
(05615,'Rionegro'),(66001,'Pereira'),(68669,'San Andrés'),(47001,'Santa Marta'),(23001,'Montería'),(44001,'Riohacha'),(05147,'Carepa'),
(81001,'Arauca'),(27075,'Bahía Solano'),(68081,'Barrancabermeja'),(05154,'Caucasia'),(18001,'Florencia'),(19318,'Guapi'),(73001, 'Ibagué'),
(52022, 'Aldana'),(50350,'La Macarena'),(17001,'Manizales'),(05001,'Medellín'),(86001,'MOCOA'),(44430,'Maicao'),(97001,'Mitú'),(41001,'Neiva'),
(27495,'Nuquí'),(52240,'Chachagüí'),(41551,'Pitalito'),(19001,'Popayán'),(52565, 'Providencia'),(86568,'Puerto Asís'),(50568,'Puerto Gaitán'),
(86573,'Puerto Leguízamo'),(99001,'Puerto Carreño')
GO



Create table Aeropuertos (
IATA varchar(3) not null , 
CIUCodigo  int not null, 
AERONombre varchar(200) not null,
CONSTRAINT PK_Aeropuertos PRIMARY KEY (IATA),
CONSTRAINT FK_AeropuertosCiudad FOREIGN KEY (CIUCodigo) REFERENCES Ciudades(CIUCodigo)
);
GO

INSERT Into Aeropuertos Values ('AXM' , 63401,'Aeropuerto Internacional El Edén'),('BAQ',08758,'Aeropuerto Internacional Ernesto Cortissoz'),
 ('BOG',11001,'Aeropuerto Internacional El Dorado '),('BGA',68001,'Aeropuerto Internacional Palonegro'),
 ('CLO',76520,'Aeropuerto Internacional Alfonso Bonilla Aragón'),('CUC',54001,'Aeropuerto Internacional Camilo Daza'),
 ('CTG',13001,'Aeropuerto Internacional Rafael Núñez'),('LET',91001,'Aeropuerto Internacional Alfredo Vásquez Cobo '),
('MDE' , 05615,'Aeropuerto Internacional José María Córdova'),('PEI',66001,'Aeropuerto Internacional Matecaña '),
('ADZ',68669,'Aeropuerto Internacional Gustavo Rojas Pinilla'),('SMR',47001,'Aeropuerto Internacional Simón Bolívar'),
('MTR',23001,'Aeropuerto Internacional Los Garzones '),('RCH',44001,'Aeropuerto Internacional Almirante Padilla '),
( 'APO' , 05147,'Aeropuerto Antonio Roldán Betancourt'),
('AUC',81001,'Aeropuerto Santiago Pérez Quiroz'),('BSC',27075,'Aeropuerto José Celestino Mutis'),
('EJA', 68081,'Aeropuerto Yariguíes'),('CAQ', 05154,'Aeropuerto Juan H. White'),
('FLA',18001,'Aeropuerto Gustavo Artunduaga'),('GPI',19318,'Aeropuerto Juan Casiano'),('IBE',73001, 'Aeropuerto Perales'),
('IPI',52022, 'Aeropuerto San Luis'),('LMC',50350,'Aeropuerto Javier Noreña Valencia'),('MZL',17001,'Aeropuerto La Nubia'),
('EOH',05001,'Aeropuerto Enrique Olaya Herrera'),('VGZ',86001,'Aeropuerto de Villagarzón'),
('LMN',44430,'Aeropuerto Jorge Isaacs'),('MVP',97001,'Aeropuerto Fabio Alberto León Bentley'),
('NVA',41001,'Aeropuerto Benito Salas'),
('NQU',27495,'Aeropuerto Reyes Murillo'),('PSO',52240,'Aeropuerto Antonio Nariño'),
('PTX',41551,'Aeropuerto Contador'),('PPN',19001,'Aeropuerto Guillermo León Valencia'),
('PVA',52565, 'Aeropuerto El Embrujo'),('PUU',86568,'Aeropuerto Tres de Mayo'),
('PTG',50568,'Aeropuerto Morelia'),
('LQM',86573,'Aeropuerto Caucaya'),('PCR',99001,'Aeropuerto Germán Olano')
GO



Create table  Estados (
ESOCodigo int not null identity (1,1), 
ESODescripcion varchar(200) not null
CONSTRAINT PK_Estados PRIMARY KEY (ESOCodigo)
);
GO
Insert into estados values ('Activo'),('Inactivo'),('Abordando'),('Cancelado'),('Programado')
GO


Create table Vuelos (
IDVuelo  numeric(18,0) not null identity (1,1),
IATAOrigen  varchar(3) not null, 
IATADestino varchar(3) not null ,
fecha date not null,
HoraSalida time not null,
HoraLlegada time not null,
ESOCodigo int not null ,  
CONSTRAINT PK_Vuelos PRIMARY KEY (IDVuelo),
CONSTRAINT FK_AeropuertosVuelosO FOREIGN KEY (IATAOrigen) REFERENCES Aeropuertos(IATA),
CONSTRAINT FK_AeropuertosVuelosD FOREIGN KEY (IATADestino) REFERENCES Aeropuertos(IATA),
CONSTRAINT FK_VuelosEstados FOREIGN KEY (ESOCodigo) REFERENCES Estados(ESOCodigo)
);
GO 
insert into Vuelos values
('SMR','BOG',CAST(GETDATE() As Date) , CONVERT(nvarchar(5), GETDATE(), 108),CONVERT(nvarchar(5), DATEADD (MINUTE,90 , getdate()), 108),3)
,('BOG','MDE',CAST(GETDATE() As Date) , CONVERT(nvarchar(5), GETDATE(), 108),CAST(DATEADD (MINUTE,60 , CONVERT(nvarchar(5), GETDATE(), 108)) As Time),4)
,('BOG','MDE',CAST(GETDATE() As Date) , CONVERT(nvarchar(5), GETDATE(), 108),CAST(DATEADD (MINUTE,260 , CONVERT(nvarchar(5), GETDATE(), 108)) As Time),3)
,('BOG','MDE',CAST(GETDATE() As Date) , CONVERT(nvarchar(5), GETDATE(), 108),CAST(DATEADD (MINUTE,460 , CONVERT(nvarchar(5), GETDATE(), 108)) As Time),4)
,('BOG','MDE',CAST(GETDATE() As Date) , CONVERT(nvarchar(5), GETDATE(), 108),CAST(DATEADD (MINUTE,560 , CONVERT(nvarchar(5), GETDATE(), 108)) As Time),5)
,('BOG','MDE',CAST(GETDATE() As Date) , CONVERT(nvarchar(5), GETDATE(), 108),CAST(DATEADD (MINUTE,660 , CONVERT(nvarchar(5), GETDATE(), 108)) As Time),4)
GO


Create table  Perfiles (
PERCodigo  int not null identity (1,1),
PERDescripcion  varchar(100) not null,
CONSTRAINT PK_Perfiles PRIMARY KEY (PERCodigo)
);
GO

insert into perfiles values ('Administrador'),('Estandar')

GO

Create table  Usuarios (
USUCodigo  int not null identity (1,1),
USUNombre  varchar(100) not null, 
ESOCodigo int not null , 
PERCodigo int not null ,
USULogin varchar(40) not null,
USUPassword varchar(50) not null,
CONSTRAINT PK_Usuarios PRIMARY KEY (USUCodigo),
CONSTRAINT FK_UsuariosEstados FOREIGN KEY (ESOCodigo) REFERENCES Estados(ESOCodigo),
CONSTRAINT FK_UsuariosPerfiles FOREIGN KEY (PERCodigo) REFERENCES Perfiles(PERCodigo),
);

GO
insert into Usuarios values ('Eduardo Lozada' , 1,1,'Elozada','A123456a')
insert into Usuarios values ('Pedro lopez' , 1,2,'Plopez','A123456a')
insert into Usuarios values ('Juan Camargo' , 2,1,'JCamargo','A123456a')
insert into Usuarios values ('Matias Fernandez' , 1,1,'MFernandez','A123456a')

GO
--Metodo encargado de Validar la autenticacion 
IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPValidaLogin]') AND type in (N'P', N'PC'))
	EXEC ('CREATE PROCEDURE [dbo].[SPValidaLogin] AS BEGIN SET NOCOUNT ON; END')
GO
ALTER PROCEDURE SPValidaLogin
@piUser VARCHAR(40),@piPassword varchar(50)
AS
BEGIN
	
	select usu.USUNombre,per.PERDescripcion from usuarios usu 
	inner join Perfiles per on usu.PERCodigo=per.PERCodigo Where USULogin=@piUser and USUPassword = @piPassword and ESOCodigo=1 
END
GO

--Metodo encargado de traer  todos los vuelos

IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPTraerVuelos]') AND type in (N'P', N'PC'))
	EXEC ('CREATE PROCEDURE [dbo].[SPTraerVuelos] AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE SPTraerVuelos @piTextoBuscar varchar(50)
AS
BEGIN
	if (@piTextoBuscar != '')
		begin
			select vue.IDVuelo 'Id Vuelo'  ,   ciu.CIUDescripcion 'Ciudad Origen', aer.IATA 'Origen',ciu2.CIUDescripcion 'Ciudad Destino' ,aer2.IATA 'Destino', fecha 'Fecha', HoraSalida 'Hora Salida', HoraLlegada 'Hora Llegada', eso.ESODescripcion 'Estado'   from vuelos vue 
			inner join Aeropuertos aer on aer.IATA=IATAOrigen
			inner join Ciudades ciu on aer.CIUCodigo=ciu.CIUCodigo
			inner join Aeropuertos aer2 on aer2.IATA=IATADestino
			inner join Ciudades ciu2 on aer2.CIUCodigo=ciu2.CIUCodigo
			inner join Estados eso on eso.ESOCodigo = vue.ESOCodigo
			where IDVuelo like'%' +@piTextoBuscar + '%' or ciu.CIUDescripcion like'%' +@piTextoBuscar + '%' or  fecha like'%' +@piTextoBuscar + '%'
			or ciu2.CIUDescripcion like'%' +@piTextoBuscar + '%' or  eso.ESODescripcion like'%' +@piTextoBuscar + '%'
		end 
    else
		begin
		select vue.IDVuelo 'Id Vuelo'  ,   ciu.CIUDescripcion 'Ciudad Origen', aer.IATA 'Origen',ciu2.CIUDescripcion 'Ciudad Destino' ,aer2.IATA 'Destino', fecha 'Fecha', HoraSalida 'Hora Salida', HoraLlegada 'Hora Llegada', eso.ESODescripcion 'Estado'   from vuelos vue 
		inner join Aeropuertos aer on aer.IATA=IATAOrigen
		inner join Ciudades ciu on aer.CIUCodigo=ciu.CIUCodigo
		inner join Aeropuertos aer2 on aer2.IATA=IATADestino
		inner join Ciudades ciu2 on aer2.CIUCodigo=ciu2.CIUCodigo
		inner join Estados eso on eso.ESOCodigo = vue.ESOCodigo
	end	
END
GO

--Metodo encargado de traer  las ciudades con Aeropuertos
IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPTraerCiudades]') AND type in (N'P', N'PC'))
	EXEC ('CREATE PROCEDURE [dbo].[SPTraerCiudades] AS BEGIN SET NOCOUNT ON; END')
GO
ALTER PROCEDURE SPTraerCiudades
AS
BEGIN
	
	select aer.IATA,CIUDescripcion  from Ciudades ciu inner join Aeropuertos aer on ciu.CIUCodigo=aer.CIUCodigo
END
GO

--Metodo encargado de traer Traer Estados de un vuelo
IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPTraerEstados]') AND type in (N'P', N'PC'))
	EXEC ('CREATE PROCEDURE [dbo].[SPTraerEstados] AS BEGIN SET NOCOUNT ON; END')
GO
ALTER PROCEDURE SPTraerEstados
AS
BEGIN
	
	select * from Estados where ESOCodigo > 2 
END
GO

--Metodo encargado de traer el detalle de un vuelo 

IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPTraerDetalle]') AND type in (N'P', N'PC'))
	EXEC ('CREATE PROCEDURE [dbo].[SPTraerDetalle] AS BEGIN SET NOCOUNT ON; END')
GO
ALTER PROCEDURE SPTraerDetalle @piIdVuelo numeric(18,0)
AS
BEGIN
	
	select cast(vue.IDVuelo as varchar) 'Id Vuelo'  ,   ciu.CIUDescripcion 'Ciudad Origen', aer.IATA 'Origen' ,aer.AERONombre AeropuertoO,ciu2.CIUDescripcion 'Ciudad Destino' ,aer2.IATA 'Destino',aer2.AERONombre AeropuertoD, cast(fecha as varchar) 'Fecha', cast(HoraSalida  as varchar(5))'Hora Salida',CAST(HoraLlegada as varchar(5) )'Hora Llegada', eso.ESODescripcion 'Estado'   from vuelos vue 
	inner join Aeropuertos aer on aer.IATA=IATAOrigen
	inner join Ciudades ciu on aer.CIUCodigo=ciu.CIUCodigo
	inner join Aeropuertos aer2 on aer2.IATA=IATADestino
	inner join Ciudades ciu2 on aer2.CIUCodigo=ciu2.CIUCodigo
	inner join Estados eso on eso.ESOCodigo = vue.ESOCodigo where vue.IDVuelo= @piIdVuelo
END
GO

--Metodo encargado de insertar datos de los vuelos

IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPinsertarVuelos]') AND type in (N'P', N'PC'))
	EXEC ('CREATE PROCEDURE [dbo].[SPinsertarVuelos] AS BEGIN SET NOCOUNT ON; END')
GO
ALTER PROCEDURE SPinsertarVuelos 
@piIATAOrigen VARCHAR(3),
@piIATADestino varchar(3),
@piFecha varchar(50),
@piHoraSalida varchar(50),
@piHoraLlegada varchar(50),
@piESOCodigo int 
AS
BEGIN
	set @piFecha = cast(@piFecha as datetime)
	set @piHoraSalida = cast(@piHoraSalida as time)
	set @piHoraLlegada = cast(@piHoraLlegada as time)
	insert into vuelos  values (@piIATAOrigen,@piIATADestino,@piFecha,@piHoraSalida,@piHoraLlegada,@piESOCodigo)
END
GO


--Metodo encargado de actualizar datos de los vuelos

IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPActualizarVuelos]') AND type in (N'P', N'PC'))
	EXEC ('CREATE PROCEDURE [dbo].[SPActualizarVuelos] AS BEGIN SET NOCOUNT ON; END')
GO
ALTER PROCEDURE SPActualizarVuelos 
@piFecha varchar(50),
@piHoraSalida varchar(50),
@piHoraLlegada varchar(50),
@piESOCodigo int ,
@IdVuelo numeric(18,0) 
AS
BEGIN
	set @piFecha = cast(@piFecha as datetime)
	set @piHoraSalida = cast(@piHoraSalida as time)
	set @piHoraLlegada = cast(@piHoraLlegada as time)
	update vuelos set fecha = @piFecha,HoraSalida=@piHoraSalida ,
	HoraLlegada= @piHoraLlegada,ESOCodigo =@piESOCodigo where IDVuelo = @IdVuelo
END
GO


