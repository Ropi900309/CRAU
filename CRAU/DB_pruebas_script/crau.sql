/*
Navicat SQL Server Data Transfer

Source Server         : SQL_SERV
Source Server Version : 140000
Source Host           : localhost:1433
Source Database       : CRAU
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 140000
File Encoding         : 65001

Date: 2021-11-23 09:52:47
*/


-- ----------------------------
-- Table structure for alm_mov_det
-- ----------------------------
DROP TABLE [dbo].[alm_mov_det]
GO
CREATE TABLE [dbo].[alm_mov_det] (
[movimiento_almacen] int NOT NULL ,
[producto] int NOT NULL ,
[cantidad] numeric(18) NULL 
)


GO

-- ----------------------------
-- Records of alm_mov_det
-- ----------------------------

-- ----------------------------
-- Table structure for alm_ord_comp_rel
-- ----------------------------
DROP TABLE [dbo].[alm_ord_comp_rel]
GO
CREATE TABLE [dbo].[alm_ord_comp_rel] (
[orden_compra] int NOT NULL ,
[movimiento_almacen] int NOT NULL ,
[factura] varchar(50) NULL 
)


GO

-- ----------------------------
-- Records of alm_ord_comp_rel
-- ----------------------------

-- ----------------------------
-- Table structure for alm_ord_serv_rel
-- ----------------------------
DROP TABLE [dbo].[alm_ord_serv_rel]
GO
CREATE TABLE [dbo].[alm_ord_serv_rel] (
[orden_servicio] int NOT NULL ,
[movimiento_almacen] int NOT NULL ,
[factura] varchar(50) NULL 
)


GO

-- ----------------------------
-- Records of alm_ord_serv_rel
-- ----------------------------

-- ----------------------------
-- Table structure for almacen_movimientos
-- ----------------------------
DROP TABLE [dbo].[almacen_movimientos]
GO
CREATE TABLE [dbo].[almacen_movimientos] (
[id] int NOT NULL IDENTITY(1,1) ,
[almacen] int NULL ,
[tipo_movimiento] int NULL ,
[empleado] int NULL ,
[fecha_creacion] date NULL 
)


GO

-- ----------------------------
-- Records of almacen_movimientos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[almacen_movimientos] ON
GO
SET IDENTITY_INSERT [dbo].[almacen_movimientos] OFF
GO

-- ----------------------------
-- Table structure for almacen_tip_mov
-- ----------------------------
DROP TABLE [dbo].[almacen_tip_mov]
GO
CREATE TABLE [dbo].[almacen_tip_mov] (
[id] int NOT NULL IDENTITY(1,1) ,
[movimiento] varchar(50) NULL ,
[eliminado] varchar(255) NULL 
)


GO

-- ----------------------------
-- Records of almacen_tip_mov
-- ----------------------------
SET IDENTITY_INSERT [dbo].[almacen_tip_mov] ON
GO
SET IDENTITY_INSERT [dbo].[almacen_tip_mov] OFF
GO

-- ----------------------------
-- Table structure for almacenes
-- ----------------------------
DROP TABLE [dbo].[almacenes]
GO
CREATE TABLE [dbo].[almacenes] (
[id] int NOT NULL IDENTITY(1,1) ,
[almacen] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO

-- ----------------------------
-- Records of almacenes
-- ----------------------------
SET IDENTITY_INSERT [dbo].[almacenes] ON
GO
INSERT INTO [dbo].[almacenes] ([id], [almacen], [eliminado]) VALUES (N'1', N'Almacen General', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[almacenes] OFF
GO

-- ----------------------------
-- Table structure for asociados
-- ----------------------------
DROP TABLE [dbo].[asociados]
GO
CREATE TABLE [dbo].[asociados] (
[id] int NOT NULL IDENTITY(1,1) ,
[razon_social] varchar(250) NULL ,
[rfc] varchar(50) NULL ,
[direccion] text NULL ,
[tipo_asociado] int NULL ,
[clave] varchar(25) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[asociados]', RESEED, 145)
GO

-- ----------------------------
-- Records of asociados
-- ----------------------------
SET IDENTITY_INSERT [dbo].[asociados] ON
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'1', N'GRUPO PECUARIO SAN ANTONIO SA DE CV', N'GPS680713D5A', N'KM.335 CARRETERA FEDERAL FORTIN-CORDOBA  N° EXT S/N N° INT    COL. SAN NICOLAS  CIUDAD Córdoba  C.P 94540  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL1')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'2', N'ZETA TRANSPORTES , S.A. DE C.V.', N'ZTR000329TY2', N'KM. 291 AUTOPISTA MEX-VER JUNTO A CAFETALERA ZETA  N° EXT S/N N° INT    COL. La Luz Francisco I Madero  CIUDAD Córdoba  C.P 94542  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL2')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'3', N'ERIK MIGUEL MARIN GARZA', N'MAGE860614AJ1', N'AVENIDA JUAREZ  N° EXT 358 N° INT    COL. AQUILES SERDAN  CIUDAD Nogales  C.P 94720  ESTADO Veracruz MUNICIPIO Nogales', N'1', N'CL3')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'4', N'AUTOQUIMICOS S.A. DE C.V.', N'AUT9407288V2', N'AV. 51 CALLE 2  N° EXT 220 N° INT    COL. Tranca de Tubos  CIUDAD Córdoba  C.P 94656  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL4')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'5', N'FLETERA CONTINENTAL DE LIQUIDOS, S.A. DE C.V.', N'FCL820609NI8', N'CONOCIDO RANCHO SANTA TECLA  N° EXT S/N N° INT    COL. CONGREGACION TLACOTENGO  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL5')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'6', N'GERARDO PATEYRO CINTA', N'PACG720713143', N'CALLE MADRID  N° EXT 1 N° INT    COL. LOS OLIVOS  CIUDAD Ixhuatlancillo  C.P 94430  ESTADO Veracruz MUNICIPIO Ixhuatlancillo', N'1', N'CL6')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'7', N'TRANSPORTES JVC, S.A. DE C.V.', N'TJV930211BZ5', N'CALZADA TLACOTENGO ESQ. CALLE DE LA ROSA  N° EXT S/N N° INT    COL. ADALBERTO DIAZ JACOME  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL7')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'8', N'CONSORCIO RIVADENEYRA, S.A. DE C.V.', N'CRI0502175H7', N'AV. 9 BIS ENTRE CALLES 10 Y 12  N° EXT 1012 INT N° INT  2  COL. San José  CIUDAD Córdoba  C.P 94560  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL8')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'9', N'TRABAL S. DE R.L. DE C.V.', N'TRA051006TU2', N'CAMINO VECINAL  N° EXT 8528 N° INT  A  COL. San Miguelito  CIUDAD Córdoba  C.P 94680  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL9')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'10', N'BENEFICIADORES DE CAFES ARESCA S.A. DE C.V.', N'BCA850325EV0', N'FRANCISCO JAVIER MINA  N° EXT 20 N° INT  B  COL. CENTRO  CIUDAD Xico  C.P 91240  ESTADO Veracruz MUNICIPIO Xico', N'1', N'CL10')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'11', N'TRAMO DEL CENTRO S.A. DE C.V.', N'TCE0202264V3', N'CARRETERA A MATEHUALA KM 7  N° EXT 17200 N° INT    COL. CENTRO  CIUDAD Soledad de Graciano Sánchez  C.P 78430  ESTADO San Luis Potosí MUNICIPIO Soledad de Graciano Sánchez', N'1', N'CL11')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'12', N'KENWORTH DEL ESTE S.A. DE C.V.', N'KES940817F20', N'KM 9 +700 CARRETERA FEDERAL CORDOBA-VERACRUZ  N° EXT S/N N° INT    COL. VENTA PARADA  CIUDAD Amatlán de los Reyes  C.P 94946  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL12')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'13', N'JOSE GUILLERMO SANDOVAL DIAZ', N'SADG480916FP9', N'PROLONGACION DE CALLE ORIENTE  N° EXT 4 N° INT    COL. BARRIO DE LA LUZ  CIUDAD Ixtaczoquitlán  C.P 94450  ESTADO Veracruz MUNICIPIO Ixtaczoquitlán', N'1', N'CL13')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'14', N'TRANSP ESPEC OLEAGINOSA GRANOS Y ALMTO BALANCEADO, SA DE CV', N'TEO880315U36', N'CARRETERA FEDERAL MEXICO PACHUCA  N° EXT km 39 N° INT    COL. CENTRO  CIUDAD Tecamac de Felipe Villanueva  C.P 55740  ESTADO México MUNICIPIO Tecámac', N'1', N'CL14')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'15', N'TRANSPORTES ORGANIZADOS DE CORDOBA, S.A. DE C.V.', N'TOC070326BF1', N'AVENIDA 2 PONIENTE  N° EXT 101 N° INT  LOC 2  COL. CENTRO  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL15')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'16', N'AGROPECUARIA LA FORTUNA, S.A. DE C.V.', N'AFO840718MC9', N'ARISTOTELES ENTRE CALLE AV. HORACIO Y AV. PRESIDENTE MASARYK  N° EXT 157 N° INT    COL. POLANCO REFORMA  CIUDAD Ciudad de México  C.P 11550  ESTADO Ciudad de México MUNICIPIO Miguel Hidalgo', N'1', N'CL16')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'17', N'TRANS JORGE S.A. DE C.V.', N'TJO990913E4A', N'CALLE 34  N° EXT 1304 N° INT    COL. DOS CAMINOS  CIUDAD Córdoba  C.P 94550  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL17')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'18', N'AUTOTRANSPORTES DE CARGA TRESGUERRAS, S.A. DE C.V.', N'ACT6808066SA', N'CARR. CELAYA-VILLAGRAM KM. 3.57  N° EXT S/N N° INT    COL. LOC. ESTRADA  CIUDAD Celaya  C.P 38110  ESTADO Guanajuato MUNICIPIO Celaya', N'1', N'CL18')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'19', N'TRANSPORTES ESPECIALIZADOS DE CORDOBA S.A. DE C.V', N'TEC801007441', N'AV. CENTRAL ENTRE CALLE 10 Y TREBOL DE LA LUZ  N° EXT S/N N° INT    COL. LA LUZ FRANCISCO I. MADERO  CIUDAD Córdoba  C.P 94542  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL19')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'20', N'AUTOTANQUES JAGUARES, S.A DE C.V', N'AJA0403051H6', N'AV. 1 CALLES 24 Y 26  N° EXT 2414 N° INT    COL. DEL MAESTRO  CIUDAD Córdoba  C.P 94550  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL20')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'21', N'ALTRAN, S.A. DE C.V.', N'ALT980318EV3', N'AV. 3 PTE ENTRE CALLES 1 Y 2 SUR  N° EXT 99 N° INT  INT 1  COL. Centro  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL21')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'22', N'TT SERVICIOS ESPECIALIZADOS, S.A. DE C.V.', N'TTS901004MN6', N'CARRETERA CENTRAL 57 KM 615  N° EXT S/N N° INT    COL. República  CIUDAD Matehuala  C.P 78740  ESTADO San Luis Potosí MUNICIPIO Matehuala', N'1', N'CL22')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'23', N'REYES GOMEZ PEÑA', N'GOPR840907455', N'A. JUAREZ  N° EXT S/N N° INT    COL. CENTRO  CIUDAD SAN JUAN TIZAHUAPAN  C.P 43585  ESTADO Hidalgo MUNICIPIO Epazoyucan', N'1', N'CL23')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'24', N'COMERCIALIZADORA SALMA S.A. DE C.V.', N'CSA071128JF1', N'NICOLAS BRAVO PTE.  N° EXT 37 N° INT    COL. San Felipe Hueyotlipan  CIUDAD Puebla (Heroica Puebla)  C.P 72030  ESTADO Puebla MUNICIPIO Puebla', N'1', N'CL24')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'25', N'GOMSA CAMIONES, S.A. DE C.V.', N'GCA950503PT4', N'AV. XALAPA  N° EXT 703 N° INT    COL. Unidad del Bosque Pensiones  CIUDAD Xalapa-Enríquez  C.P 91017  ESTADO Veracruz MUNICIPIO Xalapa', N'1', N'CL25')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'26', N'HIGHWAY TRUCKS, SAPI DE C.V.', N'HTR150608RM0', N'AVENIDA DE LA PALMA  N° EXT 8 PISO 3 DESPACHO 305 N° INT    COL. MAGNOCENTRO SECC. PALMAS  CIUDAD Huixquilucan de Degollado  C.P 52786  ESTADO México MUNICIPIO Huixquilucan', N'1', N'CL26')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'27', N'MECANICA TEK S.A. DE C.V.', N'MTE010529QV8', N'CARRETERA AL OJO DE AGUA  N° EXT 201-B N° INT    COL. CENTRO  CIUDAD Ciudad Apodaca  C.P 66600  ESTADO Nuevo León MUNICIPIO Apodaca', N'1', N'CL27')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'28', N'COMERCIALIZADORA DE REFACCIONES ABRAZ S.A. DE C.V.', N'CRA150304588', N'JUAN DIEGO  N° EXT 20 N° INT    COL. Ampliación Santa María Tulpetlac  CIUDAD Ecatepec de Morelos  C.P 55418  ESTADO México MUNICIPIO Ecatepec de Morelos', N'1', N'CL28')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'29', N'TRANSPORTADORA DEL PAPALOAPAN, S.A. DE C.V.', N'TPA010227C34', N'PINO SUAREZ  N° EXT 93 N° INT    COL. CENTRO  CIUDAD Cosamaloapan  C.P 95400  ESTADO Veracruz MUNICIPIO Cosamaloapan de Carpio', N'1', N'CL29')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'30', N'AGROINDUSTRIAS DE CORDOBA, S.A. DE C.V.', N'ACO031110RIA', N'VICENTE GUERRERO  N° EXT 23 N° INT    COL. NUEVA FLORIDA LA PEÑUELA  CIUDAD AMATLAN DE LOS REYES  C.P 94945  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL30')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'31', N'TRANSPORTES BUENO, S.A. DE C.V.', N'TBU940607U84', N'CAMINO A LA LUZ FCO. I MADERO  N° EXT S/N N° INT    COL. LA LUZ FCO. I MADERO  CIUDAD Córdoba  C.P 94570  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL31')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'32', N'IMPORTADORA DE FILTROS S.A. DE C.V.', N'IFI9203263K3', N'ZARAGOZA  N° EXT 301 N° INT    COL. CENTRO  CIUDAD Allende  C.P 67350  ESTADO Nuevo León MUNICIPIO Allende', N'1', N'CL32')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'33', N'TRANSPORTES ESPECIALIZADOS MONTELLANO, S.A. DE C.V.', N'TEM820612AF7', N'CARRETERA FEDERAL CORDOBA - FORTIN  N° EXT KM. 334 N° INT    COL. Fortín de las Flores Centro  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL33')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'34', N'PUBLICO EN GENERAL', N'XAXX010101000', N'CAMINO TLACOTENGO  N° EXT 58 N° INT    COL. Fortín de las Flores Centro  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL34')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'35', N'MARTIN DIAZ CRUZ', N'DICM920203B86', N'PRIVADA 27 C SUR  N° EXT 13707 N° INT    COL. HACIENDA SANTA CLARA  CIUDAD Puebla (Heroica Puebla)  C.P 72493  ESTADO Puebla MUNICIPIO Puebla', N'1', N'CL35')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'36', N'EMBOTELLADORA EL JAROCHO, S.A. DE C.V.', N'EJA650902LJ6', N'CARRETERA FEDERAL CORDOBA-VERACRUZ  N° EXT KM. 339 N° INT    COL. ZONA INDUSTRIAL  CIUDAD Córdoba  C.P 94690  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL36')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'37', N'CASA GARCIA, S.A DE C.V.', N'CGA 660512867', N'BOULEVARD CORDOBA -PEÑUELA KM. 339  N° EXT S/N N° INT    COL. San Cayetano  CIUDAD Córdoba  C.P 94640  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL37')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'38', N'TODO MEXICO POR TIERRA SAPI, S.A. DE C.V.', N'TMT15030668A', N'KM 9 MAS 700 CARRETERA FEDERAL CORDOBA - VERACRUZ  N° EXT S/N N° INT    COL. VENTA PARADA  CIUDAD Amatlán de los Reyes  C.P 94946  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL38')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'39', N'LOGISTICA SAN JOSE S.A. DE C.V.', N'LSJ031121110', N'CALLE 41 ENTRE AVENIDAS 5 Y 5 BIS  N° EXT 503 N° INT  INT. 1  COL. Moderna  CIUDAD Córdoba  C.P 94640  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL39')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'40', N'VORTEC TRANSPORTES S.A DE C.V', N'VTR150306TI2', N'CAMINO AL PUEBLO DE LAS FLORES  N° EXT LOTE 103 N° INT  MZ 1  COL. Fortín de las Flores Centro  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL40')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'41', N'MARIA LUZ DEL CARMEN VERA CAMACHO', N'VECL530328FT6', N'PROLONGACION OTE 34 PUENTE NO. 74 AUTOPISTA  N° EXT S/N N° INT    COL. RINCON CHICO  CIUDAD Orizaba  C.P 94390  ESTADO Veracruz MUNICIPIO Orizaba', N'1', N'CL41')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'42', N'GOMSA CAMIONES SA DE CV', N'GCA950503PT4', N'KM.342 CARRET.CBA-VER.  N° EXT S/N N° INT    COL. BLVD A PEÑUELA  CIUDAD Córdoba  C.P 94690  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL42')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'43', N'HIDROSISTEMA DE CORDOBA', N'HCO901215RT1', N'CALLE 18  N° EXT 1907 N° INT    COL. Fraccionamiento Lomas  CIUDAD Córdoba  C.P 94570  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL43')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'44', N'COMERCIALIZADORA Y CONSTRUCTORA PE-CE,S.A. DE C.V.', N'CCP130920SX7', N'AV. COSTA VERDE ENTRE CALLE ISABEL LA CATOLICA Y CALLE AMERI  N° EXT 217 N° INT  3  COL. Reforma  CIUDAD Veracruz  C.P 91919  ESTADO Veracruz MUNICIPIO Veracruz', N'1', N'CL44')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'45', N'LUZ SELENE CARDENAS ALARCON', N'CAAL890324K11', N'AV. 41-B ENTRE CALLE 42 Y 46  N° EXT 133-A N° INT    COL. Huilango 3000  CIUDAD Córdoba  C.P 94557  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL45')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'46', N'OBRAS Y SERVICIOS SYCA, S DE RL DE CV', N'OSS110823PV9', N'AV. OAXACA  N° EXT 144-B N° INT    COL. México  CIUDAD Córdoba  C.P 94520  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL46')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'47', N'SERGIO MARTINEZ ZAMORANO', N'MAZS721022178', N'CALZADA TLACOTENGO  N° EXT 58 N° INT    COL. TLACOTENGO  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL47')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'48', N'LOGISTICA SCAT, S.A DE C.V.', N'LSC151019SVA', N'CIRCUITO 38 CASA 1  N° EXT MZ 124 LT 28 N° INT    COL. LOS HEROES TECAMAC  CIUDAD Tecamac de Felipe Villanueva  C.P 55765  ESTADO México MUNICIPIO Tecámac', N'1', N'CL48')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'49', N'ANTONIO ALFONSO GONZALEZ GUTIERREZ', N'GOGA7403076C1', N'JALAPAS  N° EXT 528 N° INT    COL. Villa de las Flores  CIUDAD Coacalco  C.P 55710  ESTADO México MUNICIPIO Coacalco', N'1', N'CL49')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'50', N'MA LUISA DEL PILAR SAINZ DE ROZAS APARICIO', N'SAAL631012HK6', N'CAMINO A LA LUZ FCO I MADERO  N° EXT S/N N° INT    COL.  FCO. I MADERO  CIUDAD Córdoba  C.P 94556  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL50')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'51', N'TRANSPORTES LOTUN, S.A. DE C.V.', N'TLT9702145S2', N'PERIFERICO, PONIENTE UMAN TABLAJE CATASTRAL  N° EXT 11788 N° INT    COL. Xoclan  CIUDAD Mérida  C.P 97246  ESTADO Yucatán MUNICIPIO Mérida', N'1', N'CL51')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'52', N'MARPA DE PACHUCA SA DE CV', N'MPA840215KJ5', N'BOULEVARD TULANCINGO  N° EXT 201 N° INT    COL. CIUDAD DE LOS NIÑOS  CIUDAD Pachuca de Soto  C.P 42070  ESTADO Hidalgo MUNICIPIO Pachuca de Soto', N'1', N'CL52')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'53', N'TALLERES Y GRUAS MENDEZ S.A DE C.V.', N'TGM080418Q76', N'CALLE 28-A  N° EXT 1923 N° INT    COL. Fracc. Nuevo Córdoba  CIUDAD Córdoba  C.P 94550  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL53')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'54', N'TRANSPORTES BONAMPAK, S.A. DE C.V.', N'TBO7911166Z6', N'DURAZNAL SAN CRISTOBAL  N° EXT 28 N° INT    COL. SAN CRISTOBAL  CIUDAD Huiloapan de Cuauhtémoc  C.P 94780  ESTADO Veracruz MUNICIPIO Huiloapan de Cuauhtémoc', N'1', N'CL54')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'55', N'TRANSPORTADORA MERZI, S.A. DE C.V', N'TME160131G35', N'CALLE SIN NOMBRE  N° EXT 213 N° INT    COL. PUENTE BLANCO  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL55')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'56', N'TRANSPORTES JBE S.A. DE C.V.', N'TJB160819L9A', N'CAMINO A LOMBARDO TOLEDANO  N° EXT S/N N° INT    COL. VICENTE LOMBARDO TOLEDANO  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL56')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'57', N'TRACTOACCESORIOS Y REFACCIONES DEL GOLFO, SAPI DE C.V.', N'TRG170310HA6', N'CALLE 8 ENTRE AV. 11 Y AV. 9 BIS  N° EXT 918 N° INT    COL. Córdoba Centro  CIUDAD Córdoba  C.P 94500  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL57')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'58', N'COMERCIALIZADORA ISABEL S.A. DE C.V.', N'CIS910103KE1', N'CARRETERA FEDERAL FORTIN-HUATUSCO  N° EXT 1617 N° INT    COL. EX-HACIENDA LAS ANIMAS  CIUDAD Fortín de las Flores  C.P 94472  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL58')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'59', N'CARLOS GARCÍA TOBÓN', N'GATC720601RS6', N'AV. 18 ENTRE CALLE 8 NORTE  N° EXT NO. 22 N° INT    COL. MELESIO PORTILLO  CIUDAD Fortín de las Flores  C.P 94475  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL59')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'60', N'SUSANA RIVERA SANCHEZ', N'RISS730621EX5', N'CALLE 8  N° EXT NUM.31 N° INT    COL. LA LUZ FRANCISCO I MADERO  CIUDAD CORDOBA  C.P 94485  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL60')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'61', N'ABARROTES CORDOBESES, S.A. DE C.V.', N'ACO6405017L0', N'CALLE 7  N° EXT 609 N° INT    COL. Córdoba Centro  CIUDAD Córdoba  C.P 94500  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL61')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'62', N'PRODUCTOS AVICOLAS PROCESADOS S.A. DE C.V.', N'PAP0803295W3', N'CARRET.CORDOBA-AMATLAN  N° EXT ANDEN D-24 N° INT    COL. Amatlán de los Reyes  CIUDAD Amatlán de los Reyes  C.P 94950  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL62')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'63', N'SERVICIO EN SU COMPAÑIA SA DE CV', N'SSU960311682', N'DIAGONAL DE LA 19 PONIENTE  N° EXT 3102-104 A N° INT    COL. EL VERGEL  CIUDAD Puebla (Heroica Puebla)  C.P 72400  ESTADO Puebla MUNICIPIO Puebla', N'1', N'CL63')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'64', N'GAS EXPRESS NIETO, S.A. DE C.V.', N'GEN700527K14', N'DELFINO VICTORIA  N° EXT KM23+170 N° INT    COL. LIBRAMIENTO CARRETERA VERACRUZ-COATZACOALCOS  CIUDAD Veracruz  C.P 91700  ESTADO Veracruz MUNICIPIO Veracruz', N'1', N'CL64')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'65', N'NASARIO PEREZ RAMIREZ', N'PERN751215D61', N'CALLE JUSTO SIERRA  N° EXT 455 N° INT    COL. AGUA BLANCA INDUSTRIAL  CIUDAD Zapopan  C.P 45235  ESTADO Jalisco MUNICIPIO Zapopan', N'1', N'CL65')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'66', N'PRADERAS DEL GRIJALVA, S.A.P.I. DE C.V.', N'PGR931119QJ2', N'AV. UNIVERSIDAD  N° EXT 212 N° INT  ALTOS  COL. Magisterial  CIUDAD Villahermosa  C.P 86040  ESTADO Tabasco MUNICIPIO Centro', N'1', N'CL66')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'67', N'CENTRAL ENERGETICA DE ATOYAC SPR DE RL DE CV', N'CEA1007084EA', N'CARR LIBRE CORDOBA - ATOYAC KM 8  N° EXT S/N N° INT    COL. Obrera  CIUDAD General Miguel Alemán (Potrero Nuevo)  C.P 94965  ESTADO Veracruz MUNICIPIO Atoyac', N'1', N'CL67')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'68', N'CENTRO FLETERO DEL SURESTE, S.A. DE C.V.', N'CFS990603V25', N'CALLE 39 ENTRE AVS. 5 Y 9  N° EXT S/N N° INT    COL. Moderna  CIUDAD Córdoba  C.P 94640  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL68')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'69', N'ARRENADADORA BYB S. A. DE C.V.', N'ABY080624IG3', N'AV 1 ENTRE CALLES 33 Y  35  N° EXT 3501 N° INT    COL. San Cayetano  CIUDAD Córdoba  C.P 94640  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL69')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'70', N'VICTOR MARTINEZ CRUZ', N'MACV870329HI7', N'AV. 17 ENTRE CALLE 41 Y 43  N° EXT 4104 N° INT    COL. Pino Suárez  CIUDAD Córdoba  C.P 94680  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL70')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'71', N'GAS DEL ATLANTICO, S.A. DE C.V.', N'GAT960911GI5', N'LAS PALMAS  N° EXT LOTE 12 13 14 N° INT    COL. Bruno Pagliai  CIUDAD Veracruz  C.P 91697  ESTADO Veracruz MUNICIPIO Veracruz', N'1', N'CL71')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'72', N'AMADEO PULIDO RINCON', N'PURA650216A71', N'Carretera Tuxtepec - Valle Nacional Km. 1  N° EXT S/N N° INT    COL. La Esperanza  CIUDAD San Juan Bautista Tuxtepec  C.P 68320  ESTADO Oaxaca MUNICIPIO San Juan Bautista Tuxtepec', N'1', N'CL72')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'73', N'ALVAREZ AUTOMOTRIZ, S.A. DE C.V.', N'AAU530731462', N'ANTONIO M RIVERA  N° EXT 7 N° INT    COL. FRACCIONAMIENTO INDUSTRIAL  CIUDAD Tlalnepantla de Baz  C.P 54030  ESTADO México MUNICIPIO Tlalnepantla de Baz', N'1', N'CL73')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'74', N'CONVERTO & QUINHER, S.A. DE C.V.', N'CAQ8709222U9', N'Blvd. Juan JOse Torres Landa  N° EXT 4704 N° INT  B  COL. Cerrito de Jerez  CIUDAD León de los Aldama  C.P 37530  ESTADO Guanajuato MUNICIPIO León', N'1', N'CL74')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'75', N'FERNANDO RODRIGUEZ AVILA', N'ROAF670415MF9', N'AV. 11 Y CALLES  45  Y 47  N° EXT 4503 N° INT    COL. Lázaro Cárdenas  CIUDAD Córdoba  C.P 94680  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL75')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'76', N'TRANSPORTES ALENSUR, S.A. DE C.V.', N'TAL140807MX7', N'AV. 11 ENTRE CALLE 24 Y 26  N° EXT 2419 N° INT  1  COL. DEL MAESTRO  CIUDAD Córdoba  C.P 94550  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL76')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'77', N'GRUPO FARMACEUTICO AXDA, S.A. DE C.V.', N'GFA1606061K2', N'AV. SAN RAFAEL  N° EXT 4880 N° INT  1  COL. EDUARDO LOARCA  CIUDAD Querétaro  C.P 76118  ESTADO Querétaro MUNICIPIO Querétaro', N'1', N'CL77')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'78', N'PASTEURIZADORA AGUASCALIENTES,  S. A.  DE  C. V.', N'PAG840101GL9', N'BOULEVARD A ZACATECAS NORTE  N° EXT S/N N° INT    COL. TROJES  DE  ALONSO  CIUDAD Aguascalientes  C.P 20116  ESTADO Aguascalientes MUNICIPIO Aguascalientes', N'1', N'CL78')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'79', N'DISTRIBUCIÓN AGRÍCOLA E INDUSTRIAL, S. A.  DE  C. V.', N'DAI0909021Q4', N'AV. 3 ENTRE CALLES 23 Y 25  N° EXT 2311 N° INT  A  COL. CENTRO  CIUDAD Córdoba  C.P 94500  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL79')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'80', N'NADIA LOPEZ TRUJEQUE', N'LOTN700811TQ0', N'AV. 1  ENTRE CALLES  14 Y 16  N° EXT 1417 N° INT    COL. CENTRO  CIUDAD Córdoba  C.P 94500  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL80')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'81', N'MARCELA LILIANA QUINTANILLA LIMON', N'QULM830629753', N'PICHON  N° EXT 20 N° INT    COL. LAS ARBOLEDAS  CIUDAD Ciudad Adolfo López Mateos  C.P 52950  ESTADO México MUNICIPIO Atizapán de Zaragoza', N'1', N'CL81')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'82', N'ALPESUR, S. A.   DE  C. V.', N'ALP941221RK2', N'KM. 335 CARRETERA FEDERAL FORTIN-CORDOBA  N° EXT S/N N° INT    COL. SAN NICOLAS  CIUDAD Córdoba  C.P 94540  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL82')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'83', N'TRANSPORTES RAFAGAS DEL GOLFO, S.A. DE C.V.', N'TRG730405MA3', N'Camino a la Luz Francisco I. Madero Lote 9  N° EXT s/n N° INT    COL. La Luz Francisco I. Madero  CIUDAD Córdoba  C.P 94485  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL83')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'84', N'AZUL CERAMICA, S. A.  DE  C. V.', N'ACE030819KZ4', N'CALLE NICOLAS SAN JUAN  N° EXT 1025 N° INT    COL. Del Valle Centro Delegación Benito Juárez  CIUDAD Ciudad de México  C.P 03100  ESTADO Ciudad de México MUNICIPIO Benito Juárez', N'1', N'CL84')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'85', N'ORO VERDE AGROINDUSTRIAS, S.A. DE C.V.', N'OVA971021BUA', N'AV. HIDALGO ENTRE CALLES PIO Y LOPES Y FCO. I MADERO  N° EXT 50 N° INT  1  COL. CENTRO  CIUDAD PEÑUELA  C.P 94945  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL85')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'86', N'ALCOHOLERA DE ZAPOPAN, S.A. DE C.V.', N'AZA910820UJ0', N'VICENTE GUERRERO  N° EXT 295 N° INT    COL. Agua Blanca Industrial  CIUDAD Zapopan  C.P 45235  ESTADO Jalisco MUNICIPIO Zapopan', N'1', N'CL86')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'87', N'DMEX LOGISTIC, S.A. DE C.V.', N'DLO180926AP3', N'22  ENTRE AVES. 11 Y 13  N° EXT 1105 N° INT    COL. SAN JOSÉ  CIUDAD Córdoba  C.P 94560  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL87')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'88', N'CENTRAL DE VIVERES DEL SURESTE, S.A. DE C.V.', N'CVS9002019J1', N'CALLE 39 ENTRE AVS. 5 Y 9  N° EXT S/N N° INT    COL. MODERNA  CIUDAD Córdoba  C.P 94640  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL88')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'89', N'ENLACES TERRESTRES EN FIRME, S.A.  DE  C.V.', N'ETF160908KP2', N'Carretera Fed. Córdoba a Veracruz Km. 9 + 700  N° EXT S/N N° INT    COL. Venta Parada  CIUDAD Amatlán de los Reyes  C.P 94946  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL89')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'90', N'IMPULSADORA DE TRANSPORTES  MEXICANOS, S.A. DE C.V.', N'ITM8012013N0', N'Blvd. Rosendo G. Castro  N° EXT 26 PTE N° INT    COL. Centro  CIUDAD Los Mochis  C.P 81200  ESTADO Sinaloa MUNICIPIO Ahome', N'1', N'CL90')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'91', N'COMERCIO EN FIRME, S.A. DE C.V.', N'CFI10121747A', N'Ave. 3 BIS  N° EXT 1704 N° INT    COL. CENTRO  CIUDAD Córdoba  C.P 94500  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL91')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'92', N'PEDRO RAZO ORNELAS', N'RAOP920828GHA', N'54  N° EXT 19 N° INT    COL. Nueva Esperanza  CIUDAD Córdoba  C.P 94540  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL92')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'93', N'DRESEN QUIMICA SAPI DE CV', N'DQU8705066T3', N'AV.HIDALGO  N° EXT 71 N° INT    COL. DEL CARMEN  CIUDAD Ciudad de México  C.P 04100  ESTADO Ciudad de México MUNICIPIO Coyoacán', N'1', N'CL93')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'94', N'SPECIAL RENTAL, S.A. DE C.V.', N'SRE090707V70', N'NARCISO MENDOZA  N° EXT 3607 N° INT    COL. NIÑO ARTILLERO  CIUDAD Monterrey  C.P 64280  ESTADO Nuevo León MUNICIPIO Monterrey', N'1', N'CL94')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'95', N'SAYER LACK MEXICANA, S.A. DE C.V.', N'SLM8504013R0', N'KM. 13.7 CARRT.LIBRE QUERÉTARO-CELAYA  N° EXT S/N N° INT    COL. San Isidro del Llanito  CIUDAD Apaseo el Alto  C.P 38513  ESTADO Guanajuato MUNICIPIO Apaseo el Alto', N'1', N'CL95')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'96', N'CONSTRUCTORA Y COMERCIALIZADORA INDUSTRIAL DEL GOLFO,SA CV', N'CCI960418472', N'Carretera Tuxtepec-Oaxaca km.6.5  N° EXT S/N N° INT    COL. Del Carmen  CIUDAD San Juan Bautista Tuxtepec  C.P 68363  ESTADO Oaxaca MUNICIPIO San Juan Bautista Tuxtepec', N'1', N'CL96')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'97', N'TRANSPORTES EL OLVIDO, S.A. DE C.V.', N'TOL000410IX8', N'CALLE19  N° EXT 320 N° INT    COL. CENTRO  CIUDAD Córdoba  C.P 94500  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL97')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'98', N'COORDINADOS DE CARGA PAQUETEXPRESS S.R.L DE C.V.', N'CTM131217EL9', N'BLVD ROSENDO G. CASTRO Y CALLE IGNACIO ALLENDE  N° EXT 26 PTE N° INT    COL. BIENESTAR  CIUDAD Los Mochis  C.P 81280  ESTADO Sinaloa MUNICIPIO Ahome', N'1', N'CL98')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'99', N'HELM DE MEXICO, S.A.', N'HME660303531', N'CALZ.TLACOTENGO ENTRE CAMINO PUEBLO DE LA FLORES Y BLVD.CORD  N° EXT 22 N° INT    COL. CRUCERO NACIONAL  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL99')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'100', N'JOSÉ ALFREDO RUÍZ HERNÁNDEZ', N'RUHA6201114P5', N'CALZADA MORELOS  N° EXT 6407 N° INT  1  COL. Guadalupe Barreal  CIUDAD CORDOBA  C.P 94552  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL100')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'101', N'GRUPO MALLA ACEROS CÓRDOBA, S.R.L. DE C.V.', N'GMA070907754', N'Camino a la Luz Esquina Calle 5 de Mayo  N° EXT S/N N° INT    COL. Zacatepec  CIUDAD Córdoba  C.P 94650  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL101')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'102', N'AUTO TRANSPORTES AZTECA PLUS, S.A. DE C.V.', N'ATA990917IZ0', N'AVENIDA 13  N° EXT 4204-A N° INT    COL. Nuevo Córdoba  CIUDAD Córdoba  C.P 94550  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL102')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'103', N'FLETERA AUDAZ, S.A. DE C.V.', N'FAU170922U25', N'CALLE VICENTE GUERRERO  N° EXT 23 N° INT    COL. COL. NUEVA FLORIDA  CIUDAD Peñuela  C.P 94945  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL103')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'104', N'MARTÍN ÁNDRES TELLEZ BRAVO', N'TEBM650105BW4', N'CALLE J. RODRÍGUEZ CLARA  N° EXT S/N N° INT    COL. San Jose  CIUDAD Fortín de las Flores  C.P 94475  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL104')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'105', N'WORLD PATH SERVICES, S. DE R.L. DE C.V.', N'WPS150803FC8', N'Lago Alberto entre Lago Mayor y Mariano Escobedo  N° EXT 320 N° INT    COL. Anáhuac I Sección  CIUDAD Ciudad de México  C.P 11320  ESTADO Ciudad de México MUNICIPIO Miguel Hidalgo', N'1', N'CL105')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'106', N'AUTO PARTES Y MAS, S. A.  DE  C. V.', N'APM8805092U9', N'AV. JUAN GIL PRECIADO  N° EXT 4051 N° INT  A  COL. Hogares de Nuevo México  CIUDAD Zapopan  C.P 45138  ESTADO Jalisco MUNICIPIO Zapopan', N'1', N'CL106')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'107', N'EDGAR CRUZ PEÑA', N'CUPE800414HT9', N'TLACOTENGO  N° EXT LT 6 N° INT  NA  COL. Lombardo Toledano  CIUDAD Fortín de las Flores  C.P 94475  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL107')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'108', N'ABRASIVOS Y SOLDADURAS DE CÓRDOBA, S.A. DE C.V.', N'ASC161101QN2', N'CALLE 15 ENTRE AVES. 3 Y 5  N° EXT 318 N° INT    COL. CENTRO  CIUDAD Córdoba  C.P 94500  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL108')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'109', N'EMBALAJES Y PLASTICOS DE CÓRDOBA, S.A.  DE  C.V.', N'EPC031113J27', N'Camino Conjunto Industrial entre calles Emilio Bueno Lázaro  N° EXT Fracción C N° INT    COL. Cuauhtémoc Localidad Rancho San Felipe  CIUDAD Córdoba  C.P 94480  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL109')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'110', N'TRANSPORTADORA DE CORDOBA, S.A. DE C.V.', N'TCO971126U23', N'CALLE 8  ENTRE AVS. 1 Y  3  N° EXT 117 N° INT    COL. Córdoba Centro  CIUDAD Córdoba  C.P 94500  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL110')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'111', N'Servicio Pan Americano de Protección, S. A.   de  C.V.', N'SPA810429PU2', N'Calzada Tlacotengo  N° EXT 4 N° INT    COL. Crucero Nacional  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL111')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'112', N'TRANSPORTES INDUSTRIALES UNIDOS, S.A. DE C.V.', N'TIU980120KK7', N'AV. 1  #LOTE 3-A  N° EXT S/N N° INT    COL. PARQUE INDUSTRIAL VALLE DE ORIZABA  CIUDAD Huiloapan de Cuauhtémoc  C.P 94780  ESTADO Veracruz MUNICIPIO Huiloapan de Cuauhtémoc', N'1', N'CL112')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'113', N'INDUSTRIAS FRANSOL, S..A. DE C.V.', N'IFR890608TVA', N'BOULEVARD CORDOBA-PEÑUELA KM. 343  N° EXT S/N N° INT    COL. INDUSTRIAL  CIUDAD Córdoba  C.P 94690  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL113')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'114', N'TRANSTOOLS STORE, S.A. DE C.V.', N'TST180910TR0', N'CARRIL DE SAN CRISTÓBAL, PARQUE INDUSTRIAL CHACHAPA  N° EXT 126 N° INT    COL. SAN SALVADOR CHACHAPA AMOZOC  CIUDAD Amozoc  C.P 72990  ESTADO Puebla MUNICIPIO Amozoc', N'1', N'CL114')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'115', N'FLETES CHALIN, S.A.  DE  C.V.', N'FCA060310FB3', N'CALLE 35  N° EXT 301 N° INT  1  COL. ZONA INDUSTRIAL  CIUDAD Córdoba  C.P 94690  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL115')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'116', N'LUZ DEL CARMEN PEDRAZA CASTILLO', N'PECL900530KS8', N'FRANCISCO I. MADERO  N° EXT S/N N° INT    COL. Paraje Nuevo Centro  CIUDAD Paraje Nuevo  C.P 94940  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL116')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'117', N'MARIA LUZ DEL CARMEN VERA CAMACHO', N'VECL530328FT6', N'PROLON.OTE.34 PUENTE No. 74 AUTOPISTA  N° EXT S/N N° INT    COL. Rincón Chico  CIUDAD Orizaba  C.P 94390  ESTADO Veracruz MUNICIPIO Orizaba', N'1', N'CL117')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'118', N'REDMEKANIK, S.A. DE C.V.', N'RED170607J27', N'ANTONIO M. RIVERA ENTRE C. ROBERTO FULTON Y TENAYUCA 1 MANZA  N° EXT 4 LOTE 11 N° INT    COL. INDUSTRIAL TLANEPANTLA  CIUDAD Tlalnepantla de Baz  C.P 54030  ESTADO México MUNICIPIO Tlalnepantla de Baz', N'1', N'CL118')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'119', N'RIVAMONTE, S.P.R. DE R.L.', N'RIV1610131HA', N'CARRETERA FEDERAL LA TINAJA A TIERRA BLANCA  N° EXT KM26 N° INT    COL. Tierra Blanca  CIUDAD Tierra Blanca  C.P 95100  ESTADO Veracruz MUNICIPIO Tierra Blanca', N'1', N'CL119')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'120', N'AUTOTRANSPORTE MACUSPANA, S.A. DE C.V.', N'AMA8711113T4', N'CARRET. VILLAHERMOSA-ESCARCEGA  N° EXT KM 45.5 N° INT    COL. RIA MONTE ADENTRO, LOCALIDAD RIA MONTE ADENTRO 1ERA SECCION  CIUDAD Macuspana  C.P 86703  ESTADO Tabasco MUNICIPIO Macuspana', N'1', N'CL120')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'121', N'KARLA GASPERIN ZUCCOLOTTO', N'GAZK960620H13', N'CARRETERA FEDERAL LIBRE FORTIN -HUATUSCO KM1.5  N° EXT S/N N° INT    COL. VICENTE LOMBARDO TOLEDANO  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL121')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'122', N'SUMINISTRO DE REFRACCIONES A DISEL SA DE CV', N'SRD190216PY3', N'AV.LERDO DE TEJEDA MZ  LT 27  N° EXT 1390 N° INT    COL. MARIA ISABEL  CIUDAD Valle de Chalco Solidaridad  C.P 56615  ESTADO México MUNICIPIO Valle de Chalco Solidaridad', N'1', N'CL122')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'123', N'AUTOLINEAS ESPECIALIZADAS EN GRANELES S.A. DE C.V.', N'AEG0112208F6', N'CARRETERA FEDERAL CORDOBA-VERACRUZ KM. 10.5  N° EXT S/N N° INT    COL. Venta Parada  CIUDAD Amatlán de los Reyes  C.P 94946  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL123')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'124', N'ESTAFETA MEXICANA, S.A. DE C.V.', N'EME880309SK5', N'AVENIDA JOSE VASCONCELOS  N° EXT 105 N° INT  PISO 4  COL. Hipódromo Condesa  CIUDAD Ciudad de México  C.P 06170  ESTADO Ciudad de México MUNICIPIO Cuauhtémoc', N'1', N'CL124')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'125', N'TRANSPORTES GARCIAS TRUCKING, S.A. DE C.V.', N'TGT950925R6A', N'CALLE 2 DE ABRIL  N° EXT S/N N° INT    COL. Santa Bárbara  CIUDAD Cuautitlán Izcalli  C.P 54713  ESTADO México MUNICIPIO Cuautitlán Izcalli', N'1', N'CL125')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'126', N'FABRICA DE JABON LA CORONA, S. A. DE C. V.', N'FJC780315E91', N'CARLOS B. ZETINA  N° EXT 80 N° INT    COL. Parque Industrial Xalostoc  CIUDAD Ecatepec de Morelos  C.P 55348  ESTADO México MUNICIPIO Ecatepec de Morelos', N'1', N'CL126')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'127', N'SALVADOR ROMO LOPEZ', N'ROLS630615HA2', N'RODRIGUEZ Y COSS  N° EXT 104 N° INT    COL. Francisco I Madero  CIUDAD Tulancingo  C.P 43650  ESTADO Hidalgo MUNICIPIO Tulancingo de Bravo', N'1', N'CL127')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'128', N'MOISES MARTIN ARELLANO RETIFF', N'AERM7308251G8', N'AVENIDA LIBRAMIENTO SAN LORENZO-TECNOLOGICO  N° EXT 138 N° INT    COL. San Lorenzo Teotipilco  CIUDAD Tehuacan  C.P 75855  ESTADO Puebla MUNICIPIO Tehuacán', N'1', N'CL128')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'129', N'ELIOMAR MOTA RODRÍGUEZ', N'MORE740424GU9', N'AV. 38 Y CALLE 14  N° EXT 4 N° INT    COL. Nuevo Toxpan  CIUDAD Córdoba  C.P 94516  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL129')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'130', N'OPERADORA DE SERVICIOS PAQUETEXPRESS, S.A. DE C.V.', N'PEC1411282LA', N'BLVD. ROSENDO G. CASTRO ENTRE CALLE SANTOS DEGOLLADO  N° EXT 32 PTE. N° INT  LOCAL 1,2,3,4,5  COL. Primer Cuadro (Centro)  CIUDAD Los Mochis  C.P 81200  ESTADO Sinaloa MUNICIPIO Ahome', N'1', N'CL130')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'131', N'HECTOR MANUEL BENITEZ GOMEZ', N'BEGH810413STA', N'AV. 2 PTE.  N° EXT 204-B N° INT    COL. FRACC. FORTIN DE LAS FLORES  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL131')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'132', N'FLETERA  PCA,  S.  A.   DE    C. V.', N'FPC190402HU5', N'AVENIDA MORELOS ESQUINA CALLE JUAREZ  N° EXT S/N N° INT    COL. CENTRO  CIUDAD PEÑEULA  C.P 94945  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL132')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'133', N'LUBRICANTES ESPECIALIZADOS DE VERACRUZ, S.A. DE C.V.', N'LEV990825AE0', N'PASEO EJERCITO MEXICANO  N° EXT 147 N° INT  A  COL. ADALBERTO TEJEDA  CIUDAD BOCA DEL RÍO  C.P 94298  ESTADO VERACRUZ MUNICIPIO Boca del Río', N'1', N'CL133')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'134', N'NICOLAS CARDOSO JUÁREZ', N'CAJN740916EI8', N'CALLE 5 DE MAYO  N° EXT 2 N° INT    COL. XOCHITLAN  CIUDAD YECAPIXTLA  C.P 62826  ESTADO MORELOS MUNICIPIO YECAPIXTLA', N'1', N'CL134')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'135', N'SIGMA ALIMENTOS CENTRO, S.A. DE C.V.', N'SAC920117AFA', N'CARRET.FED. FORTIN-HUATUSCO PROLONGC. CALLE 5  N° EXT 618 N° INT    COL. RICARDO BALLINAS  CIUDAD Fortín de las Flores  C.P 94472  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL135')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'136', N'CHANDRA, S. DE R.L. DE C.V.', N'CAN9803068P4', N'CALLE 17 ORIENTE  N° EXT 216 N° INT  ALTOS  COL. BARRIO DE SAN PABLO TECAMA  CIUDAD San Pedro Cholula  C.P 72760  ESTADO Puebla MUNICIPIO San Pedro Cholula', N'1', N'CL136')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'137', N'SOLUCIONES DE INGENIERIA OL SA  DE  CV', N'SIO180807ID1', N'Avenida 23 Esq. Calle 20  N° EXT 1846 N° INT  5  COL. San Dimas  CIUDAD Córdoba  C.P 94570  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL137')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'138', N'ABASTECEDORA DE BIOENERGETICO DEL GOLFO', N'ABG151002R8A', N'AVENIDA HIDALGO  N° EXT 50 N° INT    COL. .  CIUDAD Amatlán de los Reyes  C.P 94945  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL138')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'139', N'OSCAR EDUARDO BERISTAIN GARNICA', N'XAXX010101000', N'AVE. 10 PONIENTE  N° EXT 501 N° INT    COL. Melesio Portillo  CIUDAD Fortín de las Flores  C.P 94475  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL139')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'140', N'VERONICA ALICIA ZUCCOLOTTO VAZQUEZ', N'ZUVV720911M58', N'CARRETERA FEDERAL LIBRE FORTÍN-HUATUSCO  N° EXT KM.1.5 N° INT    COL. VICENTE LOMBARDO TOLEDANO  CIUDAD Fortín de las Flores  C.P 94470  ESTADO Veracruz MUNICIPIO Fortín', N'1', N'CL140')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'141', N'TRANSATLANTE S. DE R.L. DE C.V.', N'TRA171011NI6', N'17 N° 55 ENTRE AV. MANUEL NIETO Y CALLE DARIO PERALTA  N° EXT 55 N° INT    COL. MANUEL NIETO  CIUDAD Boca del RÍo  C.P 94296  ESTADO Veracruz MUNICIPIO Boca del Río', N'1', N'CL141')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'142', N'INTEGRADORA DE SOLUCIONES LOGISTICAS EN FIRME S.A. DE C.V.', N'ISL180611IBA', N'CARRETERA FEDERAL CORDOBA A VERACRUZ KM 9 + 700  N° EXT S/N N° INT    COL. VENTA PARADA  CIUDAD   C.P 94946  ESTADO Veracruz MUNICIPIO Amatlán de los Reyes', N'1', N'CL142')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'143', N'JUAN ISRAEL RODRIGUEZ CELIS', N'ROCJ761109UF7', N'CALLE 5 AV. 5 Y AV. 7  N° EXT 521 N° INT    COL. CENTRO  CIUDAD Córdoba  C.P 94500  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL143')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'144', N'SINERGIA MEXICANA DE FLETERAS S.A. DE C.V.', N'SMF200701C85', N'AV. ELISA ENTRE CALLES 3 Y AV. 19  N° EXT 1704 N° INT    COL. ALAMEDA  CIUDAD Córdoba  C.P 94580  ESTADO Veracruz MUNICIPIO Córdoba', N'1', N'CL144')
GO
GO
INSERT INTO [dbo].[asociados] ([id], [razon_social], [rfc], [direccion], [tipo_asociado], [clave]) VALUES (N'145', N'BRIMALOG S.A. DE C.V.', N'BRI150312DA3', N'PASEO DE LOS ALAMOS S/N  N° EXT S/N N° INT  1  COL. Santa Ana Pacueco  CIUDAD Pénjamo  C.P 36910  ESTADO Guanajuato MUNICIPIO Pénjamo', N'1', N'CL145')
GO
GO
SET IDENTITY_INSERT [dbo].[asociados] OFF
GO

-- ----------------------------
-- Table structure for asociados_cond_pago
-- ----------------------------
DROP TABLE [dbo].[asociados_cond_pago]
GO
CREATE TABLE [dbo].[asociados_cond_pago] (
[id] int NOT NULL IDENTITY(1,1) ,
[asociado] int NULL ,
[pago] varchar(50) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[asociados_cond_pago]', RESEED, 3)
GO

-- ----------------------------
-- Records of asociados_cond_pago
-- ----------------------------
SET IDENTITY_INSERT [dbo].[asociados_cond_pago] ON
GO
INSERT INTO [dbo].[asociados_cond_pago] ([id], [asociado], [pago]) VALUES (N'1', N'1', N'CREDITO')
GO
GO
INSERT INTO [dbo].[asociados_cond_pago] ([id], [asociado], [pago]) VALUES (N'2', N'3', N'CONTADO')
GO
GO
SET IDENTITY_INSERT [dbo].[asociados_cond_pago] OFF
GO

-- ----------------------------
-- Table structure for asociados_contactos
-- ----------------------------
DROP TABLE [dbo].[asociados_contactos]
GO
CREATE TABLE [dbo].[asociados_contactos] (
[id] int NOT NULL IDENTITY(1,1) ,
[asociado] int NULL ,
[telefono] varchar(10) NULL ,
[correo_electronico] varchar(50) NULL ,
[nombre_contacto] varchar(150) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[asociados_contactos]', RESEED, 3)
GO

-- ----------------------------
-- Records of asociados_contactos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[asociados_contactos] ON
GO
INSERT INTO [dbo].[asociados_contactos] ([id], [asociado], [telefono], [correo_electronico], [nombre_contacto]) VALUES (N'1', N'1', N'2712631143', N'm.pastelin@grupoporres.com.mx', N'Mauricio Pastelin Mendoza')
GO
GO
INSERT INTO [dbo].[asociados_contactos] ([id], [asociado], [telefono], [correo_electronico], [nombre_contacto]) VALUES (N'2', N'1', N'2712631143', N'a.pastelin@grupoporres.com.mx', N'Adrian Pastelin Mendoza')
GO
GO
INSERT INTO [dbo].[asociados_contactos] ([id], [asociado], [telefono], [correo_electronico], [nombre_contacto]) VALUES (N'3', N'2', N'2712631143', N'a.linares@azteka.com.mx', N'Adriana Linares Mendez')
GO
GO
SET IDENTITY_INSERT [dbo].[asociados_contactos] OFF
GO

-- ----------------------------
-- Table structure for asociados_tipo
-- ----------------------------
DROP TABLE [dbo].[asociados_tipo]
GO
CREATE TABLE [dbo].[asociados_tipo] (
[id] int NOT NULL IDENTITY(1,1) ,
[tipo_asociado] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[asociados_tipo]', RESEED, 5)
GO

-- ----------------------------
-- Records of asociados_tipo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[asociados_tipo] ON
GO
INSERT INTO [dbo].[asociados_tipo] ([id], [tipo_asociado], [eliminado]) VALUES (N'1', N'CLIENTE', N'0')
GO
GO
INSERT INTO [dbo].[asociados_tipo] ([id], [tipo_asociado], [eliminado]) VALUES (N'2', N'PROVEEDOR', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[asociados_tipo] OFF
GO

-- ----------------------------
-- Table structure for asos_cond_pag_det
-- ----------------------------
DROP TABLE [dbo].[asos_cond_pag_det]
GO
CREATE TABLE [dbo].[asos_cond_pag_det] (
[id] int NOT NULL IDENTITY(1,1) ,
[asos_con_pago] int NULL ,
[dias] int NULL ,
[limite_credito] numeric(18) NULL ,
[descuento] numeric(18) NULL 
)


GO

-- ----------------------------
-- Records of asos_cond_pag_det
-- ----------------------------
SET IDENTITY_INSERT [dbo].[asos_cond_pag_det] ON
GO
SET IDENTITY_INSERT [dbo].[asos_cond_pag_det] OFF
GO

-- ----------------------------
-- Table structure for departamentos
-- ----------------------------
DROP TABLE [dbo].[departamentos]
GO
CREATE TABLE [dbo].[departamentos] (
[id] int NOT NULL IDENTITY(1,1) ,
[departamento] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[departamentos]', RESEED, 2)
GO

-- ----------------------------
-- Records of departamentos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[departamentos] ON
GO
INSERT INTO [dbo].[departamentos] ([id], [departamento], [eliminado]) VALUES (N'1', N'SISTEMAS', N'0')
GO
GO
INSERT INTO [dbo].[departamentos] ([id], [departamento], [eliminado]) VALUES (N'2', N'ALMACEN', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[departamentos] OFF
GO

-- ----------------------------
-- Table structure for empleados
-- ----------------------------
DROP TABLE [dbo].[empleados]
GO
CREATE TABLE [dbo].[empleados] (
[id] int NOT NULL IDENTITY(1,1) ,
[nombre] varchar(50) NULL ,
[paterno] varchar(50) NULL ,
[materno] varchar(50) NULL ,
[rfc] varchar(20) NULL ,
[nss] varchar(20) NULL ,
[fecha_alta] date NULL ,
[departamento] int NULL ,
[puesto] int NULL ,
[fecha_baja] date NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[empleados]', RESEED, 2)
GO

-- ----------------------------
-- Records of empleados
-- ----------------------------
SET IDENTITY_INSERT [dbo].[empleados] ON
GO
INSERT INTO [dbo].[empleados] ([id], [nombre], [paterno], [materno], [rfc], [nss], [fecha_alta], [departamento], [puesto], [fecha_baja]) VALUES (N'1', N'Isaac', N'Rodriguez', N'Paredes', N'ROPI900309A62', N'330632552', N'2021-10-28', N'1', N'1', null)
GO
GO
INSERT INTO [dbo].[empleados] ([id], [nombre], [paterno], [materno], [rfc], [nss], [fecha_alta], [departamento], [puesto], [fecha_baja]) VALUES (N'2', N'Mauricio', N'Pastellin', N'Mendoza', N'asdadad', N'adadada', N'2021-11-08', N'1', N'1', null)
GO
GO
SET IDENTITY_INSERT [dbo].[empleados] OFF
GO

-- ----------------------------
-- Table structure for empleados_puestos
-- ----------------------------
DROP TABLE [dbo].[empleados_puestos]
GO
CREATE TABLE [dbo].[empleados_puestos] (
[id] int NOT NULL IDENTITY(1,1) ,
[puesto] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[empleados_puestos]', RESEED, 2)
GO

-- ----------------------------
-- Records of empleados_puestos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[empleados_puestos] ON
GO
INSERT INTO [dbo].[empleados_puestos] ([id], [puesto], [eliminado]) VALUES (N'1', N'DESARROLLADOR', N'0')
GO
GO
INSERT INTO [dbo].[empleados_puestos] ([id], [puesto], [eliminado]) VALUES (N'2', N'OPERADOR', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[empleados_puestos] OFF
GO

-- ----------------------------
-- Table structure for garantias
-- ----------------------------
DROP TABLE [dbo].[garantias]
GO
CREATE TABLE [dbo].[garantias] (
[id] int NOT NULL IDENTITY(1,1) ,
[orden] int NULL ,
[costo] numeric(18) NULL ,
[fecha_creacion] date NULL ,
[observaciones] text NULL 
)


GO

-- ----------------------------
-- Records of garantias
-- ----------------------------
SET IDENTITY_INSERT [dbo].[garantias] ON
GO
SET IDENTITY_INSERT [dbo].[garantias] OFF
GO

-- ----------------------------
-- Table structure for garantias_detalle
-- ----------------------------
DROP TABLE [dbo].[garantias_detalle]
GO
CREATE TABLE [dbo].[garantias_detalle] (
[garantia] int NOT NULL ,
[producto] int NOT NULL ,
[costo] numeric(18) NULL 
)


GO

-- ----------------------------
-- Records of garantias_detalle
-- ----------------------------

-- ----------------------------
-- Table structure for menu_opc_sub
-- ----------------------------
DROP TABLE [dbo].[menu_opc_sub]
GO
CREATE TABLE [dbo].[menu_opc_sub] (
[id] int NOT NULL IDENTITY(1,1) ,
[menu_opcion] int NULL ,
[submenu] varchar(150) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[menu_opc_sub]', RESEED, 18)
GO

-- ----------------------------
-- Records of menu_opc_sub
-- ----------------------------
SET IDENTITY_INSERT [dbo].[menu_opc_sub] ON
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'1', N'1', N'Recepción de Material')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'2', N'1', N'Ajuste Inventario Entrada')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'3', N'1', N'Salida De Material')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'4', N'1', N'Ajuste Inventario Salida')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'5', N'1', N'Venta')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'6', N'1', N'Garantia')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'7', N'1', N'Inventario')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'8', N'1', N'Resguardo de herramienta')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'9', N'2', N'Requisiciones')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'10', N'2', N'Orden de Compra')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'11', N'3', N'Clientes')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'12', N'3', N'Proveedores')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'13', N'3', N'Productos')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'14', N'3', N'Servicios')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'15', N'3', N'Vehiculos')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'16', N'4', N'Orden Servicio')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'17', N'5', N'Empleados')
GO
GO
INSERT INTO [dbo].[menu_opc_sub] ([id], [menu_opcion], [submenu]) VALUES (N'18', N'5', N'Usuario')
GO
GO
SET IDENTITY_INSERT [dbo].[menu_opc_sub] OFF
GO

-- ----------------------------
-- Table structure for menu_opciones
-- ----------------------------
DROP TABLE [dbo].[menu_opciones]
GO
CREATE TABLE [dbo].[menu_opciones] (
[id] int NOT NULL IDENTITY(1,1) ,
[opcion_menu] varchar(150) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[menu_opciones]', RESEED, 5)
GO

-- ----------------------------
-- Records of menu_opciones
-- ----------------------------
SET IDENTITY_INSERT [dbo].[menu_opciones] ON
GO
INSERT INTO [dbo].[menu_opciones] ([id], [opcion_menu]) VALUES (N'1', N'Almacen')
GO
GO
INSERT INTO [dbo].[menu_opciones] ([id], [opcion_menu]) VALUES (N'2', N'Compras')
GO
GO
INSERT INTO [dbo].[menu_opciones] ([id], [opcion_menu]) VALUES (N'3', N'Cátalogos')
GO
GO
INSERT INTO [dbo].[menu_opciones] ([id], [opcion_menu]) VALUES (N'4', N'Taller')
GO
GO
INSERT INTO [dbo].[menu_opciones] ([id], [opcion_menu]) VALUES (N'5', N'Administrar')
GO
GO
SET IDENTITY_INSERT [dbo].[menu_opciones] OFF
GO

-- ----------------------------
-- Table structure for monedas
-- ----------------------------
DROP TABLE [dbo].[monedas]
GO
CREATE TABLE [dbo].[monedas] (
[id] int NOT NULL IDENTITY(1,1) ,
[moneda] varchar(50) NULL ,
[nom_moneda] varchar(50) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[monedas]', RESEED, 2)
GO

-- ----------------------------
-- Records of monedas
-- ----------------------------
SET IDENTITY_INSERT [dbo].[monedas] ON
GO
INSERT INTO [dbo].[monedas] ([id], [moneda], [nom_moneda]) VALUES (N'1', N'Peso Mexicano', null)
GO
GO
INSERT INTO [dbo].[monedas] ([id], [moneda], [nom_moneda]) VALUES (N'2', N'Dolar Americano', null)
GO
GO
SET IDENTITY_INSERT [dbo].[monedas] OFF
GO

-- ----------------------------
-- Table structure for orden_compra
-- ----------------------------
DROP TABLE [dbo].[orden_compra]
GO
CREATE TABLE [dbo].[orden_compra] (
[id] int NOT NULL IDENTITY(1,1) ,
[empleado] int NULL ,
[proveedor] int NULL ,
[moneda] int NULL ,
[subtotal] numeric(18) NULL ,
[iva] numeric(18) NULL ,
[total] numeric(18) NULL ,
[observaciones] text NULL ,
[fecha_creacion] date NULL 
)


GO

-- ----------------------------
-- Records of orden_compra
-- ----------------------------
SET IDENTITY_INSERT [dbo].[orden_compra] ON
GO
SET IDENTITY_INSERT [dbo].[orden_compra] OFF
GO

-- ----------------------------
-- Table structure for orden_req_rel
-- ----------------------------
DROP TABLE [dbo].[orden_req_rel]
GO
CREATE TABLE [dbo].[orden_req_rel] (
[requisicion] int NOT NULL ,
[orden] int NOT NULL 
)


GO

-- ----------------------------
-- Records of orden_req_rel
-- ----------------------------

-- ----------------------------
-- Table structure for orden_ser_det
-- ----------------------------
DROP TABLE [dbo].[orden_ser_det]
GO
CREATE TABLE [dbo].[orden_ser_det] (
[ordenServicio] int NOT NULL ,
[producto] int NOT NULL ,
[cantidad] numeric(18) NULL ,
[precio] numeric(18) NULL 
)


GO

-- ----------------------------
-- Records of orden_ser_det
-- ----------------------------

-- ----------------------------
-- Table structure for orden_serv_pro
-- ----------------------------
DROP TABLE [dbo].[orden_serv_pro]
GO
CREATE TABLE [dbo].[orden_serv_pro] (
[orden] int NOT NULL ,
[producto] int NOT NULL ,
[cantidad] numeric(18) NULL ,
[precio] numeric(18) NULL 
)


GO

-- ----------------------------
-- Records of orden_serv_pro
-- ----------------------------

-- ----------------------------
-- Table structure for orden_servicio
-- ----------------------------
DROP TABLE [dbo].[orden_servicio]
GO
CREATE TABLE [dbo].[orden_servicio] (
[id] int NOT NULL IDENTITY(1,1) ,
[empleado] int NULL ,
[asociado] int NULL ,
[subtotal] numeric(18) NULL ,
[descuento] numeric(18) NULL ,
[iva] numeric(18) NULL ,
[total] numeric(18) NULL ,
[moneda] int NULL ,
[vehiculo] int NULL ,
[kilometraje] int NULL ,
[observaciones] text NULL ,
[fecha_creacion] date NULL 
)


GO

-- ----------------------------
-- Records of orden_servicio
-- ----------------------------
SET IDENTITY_INSERT [dbo].[orden_servicio] ON
GO
SET IDENTITY_INSERT [dbo].[orden_servicio] OFF
GO

-- ----------------------------
-- Table structure for producto_impuesto
-- ----------------------------
DROP TABLE [dbo].[producto_impuesto]
GO
CREATE TABLE [dbo].[producto_impuesto] (
[id] int NOT NULL IDENTITY(1,1) ,
[descripcion] varchar(50) NULL ,
[valor] numeric(18) NULL ,
[eliminado] tinyint NULL 
)


GO

-- ----------------------------
-- Records of producto_impuesto
-- ----------------------------
SET IDENTITY_INSERT [dbo].[producto_impuesto] ON
GO
SET IDENTITY_INSERT [dbo].[producto_impuesto] OFF
GO

-- ----------------------------
-- Table structure for productos
-- ----------------------------
DROP TABLE [dbo].[productos]
GO
CREATE TABLE [dbo].[productos] (
[id] int NOT NULL IDENTITY(1,1) ,
[no_parte] varchar(50) NULL ,
[descripcion] text NULL ,
[precio_compra] numeric(18) NULL ,
[precio_venta] numeric(18) NULL ,
[costo_promedio] numeric(18) NULL ,
[medida] int NULL ,
[categoria] int NULL ,
[marca] int NULL ,
[familia] int NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[productos]', RESEED, 1001)
GO

-- ----------------------------
-- Records of productos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[productos] ON
GO
SET IDENTITY_INSERT [dbo].[productos] OFF
GO

-- ----------------------------
-- Table structure for productos_categoria
-- ----------------------------
DROP TABLE [dbo].[productos_categoria]
GO
CREATE TABLE [dbo].[productos_categoria] (
[id] int NOT NULL IDENTITY(1,1) ,
[categoria] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[productos_categoria]', RESEED, 56)
GO

-- ----------------------------
-- Records of productos_categoria
-- ----------------------------
SET IDENTITY_INSERT [dbo].[productos_categoria] ON
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'1', N'ABRAZADERAS SUSPENCION', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'2', N'ACEITES ', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'3', N'ADHESIVOS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'4', N'AMORTIGUADORES', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'5', N'ARGOLLAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'6', N'BANDAS DE SUGECION', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'7', N'BATERIAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'8', N'BROCA', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'9', N'BUJES ', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'10', N'CADENAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'11', N'CAMARA DE AIRE', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'12', N'CHAMBER', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'13', N'CHAVETAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'14', N'CLAVO', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'15', N'CODOS, NIPLES Y COPLES', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'16', N'COMBUSTOLEO', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'17', N'DISCO ', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'18', N'EQUIPO DE SEGURIDAD', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'19', N'ESPARRAGOS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'20', N'ESQUINEROS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'21', N'FILTROS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'22', N'GANCHOS DE ARRASTRE', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'23', N'GRANADAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'24', N'GRASAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'25', N'HERRAMIENTAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'26', N'JUNTAS Y EMPAQUES', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'27', N'LAMINAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'28', N'LUBRICANTES', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'29', N'MANGUERAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'30', N'MATERIAL DE LIMPIEZA', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'31', N'MATERIAL ELECTRICO', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'32', N'MATRACAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'33', N'MUELLES', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'34', N'OTROS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'35', N'PAPELERIA', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'36', N'PATINES', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'37', N'PERCHAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'38', N'PERFIL DE ACERO', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'39', N'PERNOS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'40', N'PINTURAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'41', N'PISOS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'42', N'PLACA', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'43', N'PUERTA CORTINA', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'44', N'REFACCION', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'45', N'REMACHES', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'46', N'RETENES', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'47', N'RONDANAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'48', N'SENSORES', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'49', N'SERVICIO', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'50', N'SOLDADURA', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'51', N'TORNILLOS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'52', N'TUBOS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'53', N'TUERCAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'54', N'VALVULAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'55', N'VIGAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_categoria] ([id], [categoria], [eliminado]) VALUES (N'56', N'ZOCLO', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[productos_categoria] OFF
GO

-- ----------------------------
-- Table structure for productos_familia
-- ----------------------------
DROP TABLE [dbo].[productos_familia]
GO
CREATE TABLE [dbo].[productos_familia] (
[id] int NOT NULL IDENTITY(1,1) ,
[familia] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[productos_familia]', RESEED, 9)
GO

-- ----------------------------
-- Records of productos_familia
-- ----------------------------
SET IDENTITY_INSERT [dbo].[productos_familia] ON
GO
INSERT INTO [dbo].[productos_familia] ([id], [familia], [eliminado]) VALUES (N'1', N'ABRAZADERAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_familia] ([id], [familia], [eliminado]) VALUES (N'2', N'CARROCERÍAS', N'0')
GO
GO
INSERT INTO [dbo].[productos_familia] ([id], [familia], [eliminado]) VALUES (N'3', N'COMBUSTÓLEOS', N'0')
GO
GO
INSERT INTO [dbo].[productos_familia] ([id], [familia], [eliminado]) VALUES (N'4', N'ELÉCTRICO', N'0')
GO
GO
INSERT INTO [dbo].[productos_familia] ([id], [familia], [eliminado]) VALUES (N'5', N'EQUIPO ALEADO TERMO', N'0')
GO
GO
INSERT INTO [dbo].[productos_familia] ([id], [familia], [eliminado]) VALUES (N'6', N'MOTOR', N'0')
GO
GO
INSERT INTO [dbo].[productos_familia] ([id], [familia], [eliminado]) VALUES (N'7', N'PUERTA CORTINA', N'0')
GO
GO
INSERT INTO [dbo].[productos_familia] ([id], [familia], [eliminado]) VALUES (N'8', N'SISTEMA DE FRENADO', N'0')
GO
GO
INSERT INTO [dbo].[productos_familia] ([id], [familia], [eliminado]) VALUES (N'9', N'SUSPENSIÓN', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[productos_familia] OFF
GO

-- ----------------------------
-- Table structure for productos_impuestos_rel
-- ----------------------------
DROP TABLE [dbo].[productos_impuestos_rel]
GO
CREATE TABLE [dbo].[productos_impuestos_rel] (
[producto] int NOT NULL ,
[impuesto] int NOT NULL 
)


GO

-- ----------------------------
-- Records of productos_impuestos_rel
-- ----------------------------

-- ----------------------------
-- Table structure for productos_inventario
-- ----------------------------
DROP TABLE [dbo].[productos_inventario]
GO
CREATE TABLE [dbo].[productos_inventario] (
[id] int NOT NULL IDENTITY(1,1) ,
[stock] numeric(18) NULL ,
[alerta_min_stock] numeric(18) NULL ,
[alerta_max_stock] numeric(18) NULL ,
[producto] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[productos_inventario]', RESEED, 1001)
GO

-- ----------------------------
-- Records of productos_inventario
-- ----------------------------
SET IDENTITY_INSERT [dbo].[productos_inventario] ON
GO
INSERT INTO [dbo].[productos_inventario] ([id], [stock], [alerta_min_stock], [alerta_max_stock], [producto]) VALUES (N'1', N'0', N'0', N'0', N'1')
GO
GO
INSERT INTO [dbo].[productos_inventario] ([id], [stock], [alerta_min_stock], [alerta_max_stock], [producto]) VALUES (N'2', N'0', N'0', N'0', N'2')
GO
GO
INSERT INTO [dbo].[productos_inventario] ([id], [stock], [alerta_min_stock], [alerta_max_stock], [producto]) VALUES (N'3', N'0', N'0', N'0', N'3')
GO
GO
SET IDENTITY_INSERT [dbo].[productos_inventario] OFF
GO

-- ----------------------------
-- Table structure for productos_marca
-- ----------------------------
DROP TABLE [dbo].[productos_marca]
GO
CREATE TABLE [dbo].[productos_marca] (
[id] int NOT NULL IDENTITY(1,1) ,
[marca] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[productos_marca]', RESEED, 65)
GO

-- ----------------------------
-- Records of productos_marca
-- ----------------------------
SET IDENTITY_INSERT [dbo].[productos_marca] ON
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'1', N'3M', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'2', N'ACP', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'3', N'AMPRO', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'4', N'AUSTROMEX', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'5', N'BENDIX', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'6', N'BRALO', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'7', N'COMEX', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'8', N'COMUNELLO', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'9', N'DEWALT', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'10', N'DIPER DIAMOND PARTS', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'11', N'DYNAMIC', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'12', N'ELECTRODOS INFRA', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'13', N'FEDERAL MOGUL', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'14', N'FONTAINE PARTS CONNECTION', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'15', N'GABRIEL ', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'16', N'GAFF', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'17', N'GOODYEAR', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'18', N'GRC', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'19', N'GREAT DANE', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'20', N'GROTE', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'21', N'HENDRICKSON', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'22', N'HOLLAND', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'23', N'INDUX', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'24', N'KATAI', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'25', N'KING HEAVY DUTY', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'26', N'KYNEDINE', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'27', N'MAF', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'28', N'MAKITA', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'29', N'MANSON', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'30', N'MERITOR', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'31', N'MONROE', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'32', N'NEOLITE', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'33', N'PAGID', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'34', N'PARBO', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'35', N'PHILIPS', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'36', N'PHM', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'37', N'PREMIER', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'38', N'PROKTIVE BONDING LUBRICATION TECHNOLOGY', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'39', N'PULIDO', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'40', N'QBH STAR', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'41', N'RALOY', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'42', N'REXNORD', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'43', N'REYMAK', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'44', N'SAYER', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'45', N'SEIF', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'46', N'SIKA', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'47', N'SIRCO', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'48', N'SNR', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'49', N'SOLDADURAS ZELECTA', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'50', N'STAR', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'51', N'STEMCO', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'52', N'SYLVANIA', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'53', N'TENAZIT', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'54', N'TINDU DE MÉXICO', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'55', N'TRAKTOLAMP', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'56', N'TRO-GRIM', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'57', N'TRUCK TEK PARTS', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'58', N'TRUPER', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'59', N'TUK', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'60', N'URREA', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'61', N'UTILITY', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'62', N'VOLTECK', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'63', N'WELD', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'64', N'WHINTING', N'0')
GO
GO
INSERT INTO [dbo].[productos_marca] ([id], [marca], [eliminado]) VALUES (N'65', N'WURTH', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[productos_marca] OFF
GO

-- ----------------------------
-- Table structure for productos_umedida
-- ----------------------------
DROP TABLE [dbo].[productos_umedida]
GO
CREATE TABLE [dbo].[productos_umedida] (
[id] int NOT NULL IDENTITY(1,1) ,
[unidad] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[productos_umedida]', RESEED, 14)
GO

-- ----------------------------
-- Records of productos_umedida
-- ----------------------------
SET IDENTITY_INSERT [dbo].[productos_umedida] ON
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'1', N'BOTE', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'2', N'CAJA', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'3', N'CUBETA', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'4', N'JUEGO', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'5', N'KG', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'6', N'KIT', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'7', N'LITRO', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'8', N'LOTE', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'9', N'METRO', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'10', N'PIE', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'11', N'PIEZA', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'12', N'SERVICIO', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'13', N'TAMBO', N'0')
GO
GO
INSERT INTO [dbo].[productos_umedida] ([id], [unidad], [eliminado]) VALUES (N'14', N'GALON', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[productos_umedida] OFF
GO

-- ----------------------------
-- Table structure for requisiciones
-- ----------------------------
DROP TABLE [dbo].[requisiciones]
GO
CREATE TABLE [dbo].[requisiciones] (
[id] int NOT NULL IDENTITY(1,1) ,
[empleado] int NULL ,
[observaciones] text NULL ,
[fecha_creacion] date NULL ,
[fecha_requerido] date NULL 
)


GO

-- ----------------------------
-- Records of requisiciones
-- ----------------------------
SET IDENTITY_INSERT [dbo].[requisiciones] ON
GO
SET IDENTITY_INSERT [dbo].[requisiciones] OFF
GO

-- ----------------------------
-- Table structure for requisiciones_pro_det
-- ----------------------------
DROP TABLE [dbo].[requisiciones_pro_det]
GO
CREATE TABLE [dbo].[requisiciones_pro_det] (
[requisicion] int NOT NULL ,
[productoId] int NOT NULL ,
[cantidad] numeric(18) NULL ,
[precio_unitario] numeric(18) NULL 
)


GO

-- ----------------------------
-- Records of requisiciones_pro_det
-- ----------------------------

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE [dbo].[usuarios]
GO
CREATE TABLE [dbo].[usuarios] (
[id] int NOT NULL IDENTITY(1,1) ,
[usuario] varchar(50) NULL ,
[contraseña] varchar(50) NULL ,
[empleado] int NULL ,
[usuario_rol] int NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[usuarios]', RESEED, 2)
GO

-- ----------------------------
-- Records of usuarios
-- ----------------------------
SET IDENTITY_INSERT [dbo].[usuarios] ON
GO
INSERT INTO [dbo].[usuarios] ([id], [usuario], [contraseña], [empleado], [usuario_rol], [eliminado]) VALUES (N'1', N'ropi', N'holamundo', N'1', N'1', N'0')
GO
GO
INSERT INTO [dbo].[usuarios] ([id], [usuario], [contraseña], [empleado], [usuario_rol], [eliminado]) VALUES (N'2', N'mapa', N'123', N'2', N'1', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO

-- ----------------------------
-- Table structure for usuarios_rol
-- ----------------------------
DROP TABLE [dbo].[usuarios_rol]
GO
CREATE TABLE [dbo].[usuarios_rol] (
[id] int NOT NULL IDENTITY(1,1) ,
[usuarios_rol] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO

-- ----------------------------
-- Records of usuarios_rol
-- ----------------------------
SET IDENTITY_INSERT [dbo].[usuarios_rol] ON
GO
INSERT INTO [dbo].[usuarios_rol] ([id], [usuarios_rol], [eliminado]) VALUES (N'1', N'ADMINISTRADOR', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[usuarios_rol] OFF
GO

-- ----------------------------
-- Table structure for vehiculo_marca
-- ----------------------------
DROP TABLE [dbo].[vehiculo_marca]
GO
CREATE TABLE [dbo].[vehiculo_marca] (
[id] int NOT NULL IDENTITY(1,1) ,
[marca] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[vehiculo_marca]', RESEED, 6)
GO

-- ----------------------------
-- Records of vehiculo_marca
-- ----------------------------
SET IDENTITY_INSERT [dbo].[vehiculo_marca] ON
GO
INSERT INTO [dbo].[vehiculo_marca] ([id], [marca], [eliminado]) VALUES (N'1', N'FREIGHTLINER', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_marca] ([id], [marca], [eliminado]) VALUES (N'2', N'KENWORTH', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_marca] ([id], [marca], [eliminado]) VALUES (N'3', N'INTERNATIONAL', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_marca] ([id], [marca], [eliminado]) VALUES (N'4', N'VOLVO', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_marca] ([id], [marca], [eliminado]) VALUES (N'5', N'HINO', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_marca] ([id], [marca], [eliminado]) VALUES (N'6', N'ISUZU', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[vehiculo_marca] OFF
GO

-- ----------------------------
-- Table structure for vehiculo_tipo
-- ----------------------------
DROP TABLE [dbo].[vehiculo_tipo]
GO
CREATE TABLE [dbo].[vehiculo_tipo] (
[id] int NOT NULL IDENTITY(1,1) ,
[tipo] varchar(50) NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[vehiculo_tipo]', RESEED, 25)
GO

-- ----------------------------
-- Records of vehiculo_tipo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[vehiculo_tipo] ON
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'1', N'AUTOBUS', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'2', N'AUTOMOVIL', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'3', N'AUTOTANQUE', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'4', N'AUTOTANQUE PARA ASFALTO', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'5', N'CAJA REFRIGERADA', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'6', N'CAJA REFRIGERADA (TERMO)', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'7', N'CAJA SECA', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'8', N'CAMIONETA', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'9', N'CORTINA', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'10', N'DOLLY', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'11', N'FULL / DOBLE SEMIREMOLQUE', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'12', N'GRANEL', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'13', N'GRANELERA', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'14', N'JAULA A GRANEL', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'15', N'JAULA ENLONADA', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'16', N'JAULA GANADERA', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'17', N'MOTO', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'18', N'PIPA', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'19', N'PIPAS REMOLQUE', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'20', N'PLATAFORMA RF', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'21', N'PORTA VEHÍCULOS', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'22', N'RABON ', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'23', N'TOLVA', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'24', N'TOLVA REMOLQUE', N'0')
GO
GO
INSERT INTO [dbo].[vehiculo_tipo] ([id], [tipo], [eliminado]) VALUES (N'25', N'TORTON ', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[vehiculo_tipo] OFF
GO

-- ----------------------------
-- Table structure for vehiculos
-- ----------------------------
DROP TABLE [dbo].[vehiculos]
GO
CREATE TABLE [dbo].[vehiculos] (
[id] int NOT NULL IDENTITY(1,1) ,
[registro_vehicular] varchar(50) NULL ,
[placas] varchar(50) NULL ,
[modelo] varchar(50) NULL ,
[marca] int NULL ,
[tipo] int NULL ,
[serie] varchar(50) NULL ,
[descripcion] varchar(255) NULL ,
[eliminado] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[vehiculos]', RESEED, 21)
GO

-- ----------------------------
-- Records of vehiculos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[vehiculos] ON
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'1', N'5612', N'XX70667', N'T680', N'1', N'22', N'3863997788H', N'', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'2', N'5613', N'XW80069', N'T8080', N'1', N'1', N'99632A6A55', N' ', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'3', N'5614', N'XS96A', N'T8080', N'1', N'1', N'99ASA66A4664', N' ', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'4', N'5615', N'PSFG89A', N'T460', N'1', N'1', N'CASDA996A', N' ', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'5', N'5617', N'XDF988A', N'T460', N'1', N'1', N'99998745A478', N' ', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'6', N'5618', N'XSXS9', N'T460', N'1', N'1', N'1552669P', N' ', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'7', N'5619', N'PDP96', N'T460', N'1', N'1', N'ASDG3454656FHG', N' ', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'8', N'5620', N'GDD70A', N'T680A', N'1', N'1', N'19992ASDG33', N' ', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'9', N'5621', N'XWA965A', N'T680', N'1', N'1', N'ASD996ASAAA', N' ', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'10', N'5622', N'AXC9A', N'TB60', N'1', N'1', N'DD8587742DSA', N' ', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'11', N'5623', N'CCW9D', N'T460', N'1', N'1', N'DD8587742DSAD', N'', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'12', N'5624', N'CDF5GH', N'T460', N'1', N'1', N'FDSFD92175SD', N'', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'14', N'5625', N'CDCD98A', N'T460', N'1', N'1', N'IOJOIOI9889', N'', N'0')
GO
GO
INSERT INTO [dbo].[vehiculos] ([id], [registro_vehicular], [placas], [modelo], [marca], [tipo], [serie], [descripcion], [eliminado]) VALUES (N'15', N'5626', N'OIJOI34', N'T460', N'1', N'1', N'RFRF1899FRF', N'', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[vehiculos] OFF
GO

-- ----------------------------
-- View structure for listado_clientes
-- ----------------------------
DROP VIEW [dbo].[listado_clientes]
GO
CREATE VIEW [dbo].[listado_clientes] AS 
SELECT
	aso.*, asot.tipo_asociado AS des_tipo
FROM
	asociados aso
INNER JOIN asociados_tipo asot ON asot.id = aso.tipo_asociado
WHERE
	aso.tipo_asociado = 1
GO

-- ----------------------------
-- View structure for listado_empleados
-- ----------------------------
DROP VIEW [dbo].[listado_empleados]
GO
CREATE VIEW [dbo].[listado_empleados] AS 
SELECT emp.*,dep.departamento as dec_depto, empu.puesto as desc_puesto from empleados emp 
INNER JOIN departamentos dep on dep.id=emp.departamento
INNER JOIN empleados_puestos empu on empu.id= emp.puesto
GO

-- ----------------------------
-- View structure for listado_productos
-- ----------------------------
DROP VIEW [dbo].[listado_productos]
GO
CREATE VIEW [dbo].[listado_productos] AS 
(

SELECT pro.*,pun.unidad as des_unidad,pca.categoria as des_categoria,pmar.marca as des_marca,pfa.familia as des_familia,pin.stock,pin.alerta_min_stock,pin.alerta_max_stock from productos pro 
INNER JOIN productos_inventario pin on pin.producto=pro.id
INNER JOIN productos_umedida pun on pun.id=pro.medida
INNER JOIN productos_categoria pca on pca.id=pro.categoria
INNER JOIN productos_marca pmar on pmar.id =pro.marca
INNER JOIN productos_familia pfa on pfa.id=pro.familia
where pro.eliminado = 0

)
GO

-- ----------------------------
-- View structure for listado_vehiculos
-- ----------------------------
DROP VIEW [dbo].[listado_vehiculos]
GO
CREATE VIEW [dbo].[listado_vehiculos] AS 
SELECT
		vh.*, vhp.tipo AS des_tipo,
		vhm.marca AS des_marca
	FROM
		vehiculos vh
	INNER JOIN vehiculo_tipo vhp ON vhp.id = vh.tipo
	INNER JOIN vehiculo_marca vhm ON vhm.id = vh.marca
	WHERE
		vh.eliminado = '0'
GO

-- ----------------------------
-- View structure for usuarios_sistema
-- ----------------------------
DROP VIEW [dbo].[usuarios_sistema]
GO
CREATE VIEW [dbo].[usuarios_sistema] AS 
(SELECT us.*,concat(em.nombre,' ',em.paterno,' ', em.materno) as nombre_empleado,usr.usuarios_rol,dep.id as depId,dep.departamento,emp.id as puesId ,emp.puesto FROM usuarios us 
INNER JOIN empleados em on us.empleado=em.id
INNER JOIN usuarios_rol usr on usr.id=us.usuario_rol
INNER JOIN departamentos dep on dep.id=em.departamento
INNER JOIN empleados_puestos emp on emp.id=em.puesto)
GO

-- ----------------------------
-- Indexes structure for table alm_mov_det
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table alm_mov_det
-- ----------------------------
ALTER TABLE [dbo].[alm_mov_det] ADD PRIMARY KEY ([movimiento_almacen], [producto])
GO

-- ----------------------------
-- Indexes structure for table alm_ord_comp_rel
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table alm_ord_comp_rel
-- ----------------------------
ALTER TABLE [dbo].[alm_ord_comp_rel] ADD PRIMARY KEY ([orden_compra], [movimiento_almacen])
GO

-- ----------------------------
-- Indexes structure for table alm_ord_serv_rel
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table alm_ord_serv_rel
-- ----------------------------
ALTER TABLE [dbo].[alm_ord_serv_rel] ADD PRIMARY KEY ([orden_servicio], [movimiento_almacen])
GO

-- ----------------------------
-- Indexes structure for table almacen_movimientos
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table almacen_movimientos
-- ----------------------------
ALTER TABLE [dbo].[almacen_movimientos] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table almacen_tip_mov
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table almacen_tip_mov
-- ----------------------------
ALTER TABLE [dbo].[almacen_tip_mov] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table almacenes
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table almacenes
-- ----------------------------
ALTER TABLE [dbo].[almacenes] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table asociados
-- ----------------------------
CREATE UNIQUE INDEX [asociados_unique] ON [dbo].[asociados]
([clave] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table asociados
-- ----------------------------
ALTER TABLE [dbo].[asociados] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table asociados_cond_pago
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table asociados_cond_pago
-- ----------------------------
ALTER TABLE [dbo].[asociados_cond_pago] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table asociados_contactos
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table asociados_contactos
-- ----------------------------
ALTER TABLE [dbo].[asociados_contactos] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table asociados_tipo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table asociados_tipo
-- ----------------------------
ALTER TABLE [dbo].[asociados_tipo] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table asos_cond_pag_det
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table asos_cond_pag_det
-- ----------------------------
ALTER TABLE [dbo].[asos_cond_pag_det] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table departamentos
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table departamentos
-- ----------------------------
ALTER TABLE [dbo].[departamentos] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table empleados
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table empleados
-- ----------------------------
ALTER TABLE [dbo].[empleados] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table empleados_puestos
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table empleados_puestos
-- ----------------------------
ALTER TABLE [dbo].[empleados_puestos] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table garantias
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table garantias
-- ----------------------------
ALTER TABLE [dbo].[garantias] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table garantias_detalle
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table garantias_detalle
-- ----------------------------
ALTER TABLE [dbo].[garantias_detalle] ADD PRIMARY KEY ([garantia], [producto])
GO

-- ----------------------------
-- Indexes structure for table menu_opc_sub
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table menu_opc_sub
-- ----------------------------
ALTER TABLE [dbo].[menu_opc_sub] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table menu_opciones
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table menu_opciones
-- ----------------------------
ALTER TABLE [dbo].[menu_opciones] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table monedas
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table monedas
-- ----------------------------
ALTER TABLE [dbo].[monedas] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table orden_compra
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table orden_compra
-- ----------------------------
ALTER TABLE [dbo].[orden_compra] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table orden_req_rel
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table orden_req_rel
-- ----------------------------
ALTER TABLE [dbo].[orden_req_rel] ADD PRIMARY KEY ([requisicion], [orden])
GO

-- ----------------------------
-- Indexes structure for table orden_ser_det
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table orden_ser_det
-- ----------------------------
ALTER TABLE [dbo].[orden_ser_det] ADD PRIMARY KEY ([ordenServicio], [producto])
GO

-- ----------------------------
-- Indexes structure for table orden_servicio
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table orden_servicio
-- ----------------------------
ALTER TABLE [dbo].[orden_servicio] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table producto_impuesto
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table producto_impuesto
-- ----------------------------
ALTER TABLE [dbo].[producto_impuesto] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table productos
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table productos
-- ----------------------------
ALTER TABLE [dbo].[productos] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Uniques structure for table productos
-- ----------------------------
ALTER TABLE [dbo].[productos] ADD UNIQUE ([no_parte] ASC)
GO

-- ----------------------------
-- Triggers structure for table productos
-- ----------------------------
DROP TRIGGER [dbo].[producto_inventario_new]
GO
CREATE TRIGGER [dbo].[producto_inventario_new]
ON [dbo].[productos]
AFTER INSERT
AS
BEGIN
    DECLARE @producto INT
		
		SET @producto = (SELECT id from Inserted)

		INSERT INTO productos_inventario VALUES (0,0,0,@producto)
   
END




GO

-- ----------------------------
-- Indexes structure for table productos_categoria
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table productos_categoria
-- ----------------------------
ALTER TABLE [dbo].[productos_categoria] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table productos_familia
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table productos_familia
-- ----------------------------
ALTER TABLE [dbo].[productos_familia] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table productos_impuestos_rel
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table productos_impuestos_rel
-- ----------------------------
ALTER TABLE [dbo].[productos_impuestos_rel] ADD PRIMARY KEY ([producto], [impuesto])
GO

-- ----------------------------
-- Indexes structure for table productos_inventario
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table productos_inventario
-- ----------------------------
ALTER TABLE [dbo].[productos_inventario] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table productos_marca
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table productos_marca
-- ----------------------------
ALTER TABLE [dbo].[productos_marca] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table productos_umedida
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table productos_umedida
-- ----------------------------
ALTER TABLE [dbo].[productos_umedida] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table requisiciones
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table requisiciones
-- ----------------------------
ALTER TABLE [dbo].[requisiciones] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table requisiciones_pro_det
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table requisiciones_pro_det
-- ----------------------------
ALTER TABLE [dbo].[requisiciones_pro_det] ADD PRIMARY KEY ([requisicion], [productoId])
GO

-- ----------------------------
-- Indexes structure for table usuarios
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table usuarios
-- ----------------------------
ALTER TABLE [dbo].[usuarios] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table usuarios_rol
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table usuarios_rol
-- ----------------------------
ALTER TABLE [dbo].[usuarios_rol] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table vehiculo_marca
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table vehiculo_marca
-- ----------------------------
ALTER TABLE [dbo].[vehiculo_marca] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table vehiculo_tipo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table vehiculo_tipo
-- ----------------------------
ALTER TABLE [dbo].[vehiculo_tipo] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table vehiculos
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table vehiculos
-- ----------------------------
ALTER TABLE [dbo].[vehiculos] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Uniques structure for table vehiculos
-- ----------------------------
ALTER TABLE [dbo].[vehiculos] ADD UNIQUE ([registro_vehicular] ASC)
GO
ALTER TABLE [dbo].[vehiculos] ADD UNIQUE ([serie] ASC)
GO
