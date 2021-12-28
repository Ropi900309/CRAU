/*
Navicat SQL Server Data Transfer

Source Server         : crau
Source Server Version : 150000
Source Host           : localhost:1433
Source Database       : crau
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 150000
File Encoding         : 65001

Date: 2021-12-27 14:22:29
*/


-- ----------------------------
-- Table structure for almacen_movimientos
-- ----------------------------
DROP TABLE [dbo].[almacen_movimientos]
GO
CREATE TABLE [dbo].[almacen_movimientos] (
[id] int NOT NULL ,
[almacen] int NULL ,
[tipo_movimiento] int NULL ,
[empleado] int NULL ,
[fecha_creacion] date NULL 
)


GO

-- ----------------------------
-- Indexes structure for table almacen_movimientos
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table almacen_movimientos
-- ----------------------------
ALTER TABLE [dbo].[almacen_movimientos] ADD PRIMARY KEY ([id])
GO
