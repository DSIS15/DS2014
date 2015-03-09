-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 12, 2014 at 01:38 AM
-- Server version: 5.5.24-log
-- PHP Version: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hsancarlosdb`
--
CREATE DATABASE `hsancarlosdb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `hsancarlosdb`;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_bccuentabanco`
--

CREATE TABLE IF NOT EXISTS `tabm_bccuentabanco` (
  `cod_ctabco` decimal(4,0) NOT NULL,
  `banco_ctabco` varchar(25) NOT NULL,
  `cuenta_ctabco` varchar(25) NOT NULL,
  `saldo_ctabco` float NOT NULL,
  `tipo_ctabanc` decimal(10,0) NOT NULL,
  `fechmodf_ctabco` date NOT NULL,
  `fechcreado_ctabco` date NOT NULL,
  `saldoant_sal` float NOT NULL,
  `saldoact_sal` float NOT NULL,
  `interesactual_sal` float NOT NULL,
  `interesacum_sal` float NOT NULL,
  `estado_ctabco` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_ctabco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_bcprestamo`
--

CREATE TABLE IF NOT EXISTS `tabm_bcprestamo` (
  `codprem_prem` decimal(4,0) NOT NULL,
  `fechcreac_prem` date NOT NULL,
  `intr_prem` float NOT NULL,
  `cant_prem` float NOT NULL,
  `estado_prem` tinyint(1) NOT NULL,
  PRIMARY KEY (`codprem_prem`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_cccpcaja`
--

CREATE TABLE IF NOT EXISTS `tabm_cccpcaja` (
  `cod_caja` decimal(4,0) NOT NULL,
  `cod_tpago` decimal(4,0) NOT NULL,
  `cant_caja` float NOT NULL,
  `docpago_caja` varchar(25) NOT NULL,
  `estado_caja` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_caja`),
  KEY `tabm_tipocaja_tabm_caja_fk` (`cod_tpago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_cccpttrans`
--

CREATE TABLE IF NOT EXISTS `tabm_cccpttrans` (
  `cod_ttrans` decimal(4,0) NOT NULL,
  `descrip_ttrans` varchar(25) NOT NULL,
  `CA_ttrans` decimal(1,0) NOT NULL,
  `estado_ttrans` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_ttrans`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_cccpttrans`
--

INSERT INTO `tabm_cccpttrans` VALUES('1', 'Cargo', '1', 1);
INSERT INTO `tabm_cccpttrans` VALUES('2', 'Abono', '0', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_cctranscc`
--

CREATE TABLE IF NOT EXISTS `tabm_cctranscc` (
  `cod_transcc` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `cod_fra` decimal(4,0) NOT NULL,
  `cod_cte` decimal(4,0) NOT NULL,
  `cod_ttrans` decimal(4,0) NOT NULL,
  `cod_caja` decimal(4,0) NOT NULL,
  `fechini_transcc` date NOT NULL,
  `valor_transcc` float NOT NULL,
  `saldoact_transcc` float NOT NULL,
  `estado_transcc` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_transcc`,`cod_srie`,`cod_fra`,`cod_cte`),
  KEY `tabm_caja_tabm_transcc_fk` (`cod_caja`),
  KEY `tabm_serie_tabm_transcc_fk` (`cod_srie`),
  KEY `tabm_ttrans_tabm_transcc_fk` (`cod_ttrans`),
  KEY `tabm_cliente_tabm_transcc_fk` (`cod_cte`),
  KEY `tabm_factura_tabm_transcc_fk` (`cod_fra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_cpcompras`
--

CREATE TABLE IF NOT EXISTS `tabm_cpcompras` (
  `cod_compra` decimal(4,0) NOT NULL,
  `cod_prov` decimal(4,0) NOT NULL,
  `cod_fra` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `cod_suc` decimal(4,0) NOT NULL,
  `cod_empsa` decimal(4,0) NOT NULL,
  `fech_compra` date NOT NULL,
  `total_compra` float NOT NULL,
  `estado_compra` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_compra`,`cod_prov`,`cod_fra`,`cod_srie`,`cod_suc`,`cod_empsa`),
  KEY `tabm_proveedor_tabm_compras_fk` (`cod_prov`),
  KEY `tabm_FEfactura_tabm_CPcompras_fk` (`cod_fra`,`cod_srie`,`cod_suc`,`cod_empsa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_cpproveedor`
--

CREATE TABLE IF NOT EXISTS `tabm_cpproveedor` (
  `cod_prov` decimal(4,0) NOT NULL,
  `nom_prov` varchar(25) NOT NULL,
  `tel_prov` varchar(25) NOT NULL,
  `dire_prov` varchar(50) NOT NULL,
  `saldoant_prov` float NOT NULL,
  `saldoact_prov` float NOT NULL,
  `cargo_prov` float NOT NULL,
  `abono_prov` float NOT NULL,
  `cargoacum_prov` float NOT NULL,
  `estado_prov` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_cptpago`
--

CREATE TABLE IF NOT EXISTS `tabm_cptpago` (
  `cod_tpago` decimal(4,0) NOT NULL,
  `tipo_tpago` varchar(25) NOT NULL,
  `estado_tpago` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_tpago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_cptpago`
--

INSERT INTO `tabm_cptpago` VALUES('1', 'Efectivo', 1);
INSERT INTO `tabm_cptpago` VALUES('2', 'Debito', 1);
INSERT INTO `tabm_cptpago` VALUES('3', 'Credito', 1);
INSERT INTO `tabm_cptpago` VALUES('4', 'Cheque', 1);
INSERT INTO `tabm_cptpago` VALUES('5', 'Compensacion', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_cptranscp`
--

CREATE TABLE IF NOT EXISTS `tabm_cptranscp` (
  `cod_transcp` decimal(4,0) NOT NULL,
  `cod_empsa` decimal(4,0) NOT NULL,
  `cod_prov` decimal(4,0) NOT NULL,
  `cod_compra` decimal(4,0) NOT NULL,
  `cod_fra` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `cod_suc` decimal(4,0) NOT NULL,
  `cod_ttrans` decimal(4,0) NOT NULL,
  `cod_compconta` decimal(4,0) NOT NULL,
  `cod_ctas` decimal(4,0) NOT NULL,
  `cod_caja` decimal(4,0) NOT NULL,
  `fechini_transcp` date NOT NULL,
  `valor_trascp` float NOT NULL,
  `saldoact_transcp` float NOT NULL,
  `estado_transcp` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_transcp`,`cod_empsa`,`cod_prov`,`cod_compra`,`cod_fra`,`cod_srie`,`cod_suc`),
  KEY `tabt_ctacontab_tabm_CPtranscp_fk` (`cod_compconta`,`cod_ctas`),
  KEY `tabm_proveedor_tabm_transcp_fk` (`cod_prov`),
  KEY `tabm_caja_tabm_transcp_fk` (`cod_caja`),
  KEY `tabm_empresa_tabm_transcp_fk` (`cod_empsa`),
  KEY `tabm_ttrans_tabm_transcp_fk` (`cod_ttrans`),
  KEY `tabm_CPcompras_tabm_CPtranscp_fk` (`cod_compra`,`cod_prov`,`cod_fra`,`cod_srie`,`cod_suc`,`cod_empsa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_ctcompconta`
--

CREATE TABLE IF NOT EXISTS `tabm_ctcompconta` (
  `cod_compconta` decimal(4,0) NOT NULL,
  `codtipodoc_compcont` decimal(2,0) NOT NULL,
  `serie_compcont` varchar(2) NOT NULL,
  `fech_compconta` date NOT NULL,
  `estado_compconta` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_compconta`),
  KEY `tabm_doccomp_tabm_compconta_fk` (`codtipodoc_compcont`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_ctctacont`
--

CREATE TABLE IF NOT EXISTS `tabm_ctctacont` (
  `cod_ctacont` decimal(10,0) NOT NULL,
  `nom_ctacont` varchar(50) NOT NULL,
  `fechcreado_ctacont` date NOT NULL,
  `fechmod_ctacont` date NOT NULL,
  `pertenece_ctacont` decimal(4,0) NOT NULL,
  `estado_ctacont` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_ctacont`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_ctdescuentoempl`
--

CREATE TABLE IF NOT EXISTS `tabm_ctdescuentoempl` (
  `cod_descempl` decimal(4,0) NOT NULL,
  `tipo_desc` varchar(25) NOT NULL,
  `poc_desc` float NOT NULL,
  `estado_desc` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_descempl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_ctdiario`
--

CREATE TABLE IF NOT EXISTS `tabm_ctdiario` (
  `codpartd_dro` decimal(10,0) NOT NULL,
  `fechcreado_dro` date NOT NULL,
  `cod_compconta` decimal(4,0) NOT NULL,
  `concp_dro` varchar(255) NOT NULL,
  `estado_diario` tinyint(1) NOT NULL,
  PRIMARY KEY (`codpartd_dro`,`fechcreado_dro`),
  KEY `tabm_compconta_tabm_diario_fk` (`cod_compconta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_ctdoccomp`
--

CREATE TABLE IF NOT EXISTS `tabm_ctdoccomp` (
  `codtipodoc_compcont` decimal(2,0) NOT NULL,
  `nom_tipocomp` varchar(50) NOT NULL,
  `fechcreado_tipocomp` date NOT NULL,
  `estado_doccomp` tinyint(1) NOT NULL,
  PRIMARY KEY (`codtipodoc_compcont`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_ctinventario`
--

CREATE TABLE IF NOT EXISTS `tabm_ctinventario` (
  `cod_inv` decimal(4,0) NOT NULL,
  `cod_ctacont` decimal(10,0) NOT NULL,
  `nom_inv` varchar(45) NOT NULL,
  `fechagrd_inv` date NOT NULL,
  `fechmodf` date NOT NULL,
  `cant_inv` decimal(10,0) NOT NULL,
  `valorsiniva_inv` float NOT NULL,
  `valorconiva` float NOT NULL,
  `totalsiniva` float NOT NULL,
  `estado_inv` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_inv`,`cod_ctacont`),
  KEY `tabm_ctacont_tabm_inventario_fk` (`cod_ctacont`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_feambiente`
--

CREATE TABLE IF NOT EXISTS `tabm_feambiente` (
  `cod_amb` decimal(4,0) NOT NULL,
  `cod_tamb` decimal(4,0) NOT NULL,
  `precio_amb` decimal(10,0) NOT NULL,
  `disponibilidad_amb` tinyint(1) NOT NULL,
  `estado_amb` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_amb`),
  KEY `Tipo_Habitacion_Habitacion_fk` (`cod_tamb`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_feambiente`
--

INSERT INTO `tabm_feambiente` VALUES('1', '1', '640', 0, 0);
INSERT INTO `tabm_feambiente` VALUES('2', '1', '640', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('3', '1', '640', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('4', '1', '640', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('5', '1', '640', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('6', '1', '640', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('7', '1', '640', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('8', '1', '640', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('9', '2', '720', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('10', '2', '720', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('11', '2', '720', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('12', '2', '720', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('13', '2', '720', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('14', '2', '720', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('15', '2', '720', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('16', '2', '720', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('17', '3', '1000', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('18', '3', '1000', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('19', '3', '1000', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('20', '3', '1000', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('21', '4', '1200', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('22', '4', '1200', 1, 1);
INSERT INTO `tabm_feambiente` VALUES('23', '5', '1400', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_febodega`
--

CREATE TABLE IF NOT EXISTS `tabm_febodega` (
  `cod_bga` decimal(4,0) NOT NULL,
  `cod_suc` decimal(4,0) NOT NULL,
  `descrip_bga` varchar(25) NOT NULL,
  `dire_bga` varchar(25) NOT NULL,
  `estado_bga` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_bga`),
  KEY `tabm_sucursal_tabm_bodega_fk` (`cod_suc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_febodega`
--

INSERT INTO `tabm_febodega` VALUES('1', '1', 'Bodega de Alimentos', 'Av Reforma 7-89 Zona 10', 1);
INSERT INTO `tabm_febodega` VALUES('2', '1', 'Bodega de Productos', 'Av Reforma 7-89 Zona 10', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_fecatprod`
--

CREATE TABLE IF NOT EXISTS `tabm_fecatprod` (
  `cod_catprod` decimal(4,0) NOT NULL,
  `tipo_catprod` varchar(25) NOT NULL,
  `nom_catprod` varchar(25) NOT NULL,
  `precioc_catprod` float NOT NULL,
  `preciov_catprod` float NOT NULL,
  `cmax_catprod` float NOT NULL,
  `cmin_catprod` float NOT NULL,
  `ctotal_catprod` float NOT NULL,
  `estado_catprod` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_catprod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_fecatprod`
--

INSERT INTO `tabm_fecatprod` VALUES('1', 'Mobiliario', 'Cama Matrimonial', 0, 0, 28, 28, 28, 1);
INSERT INTO `tabm_fecatprod` VALUES('2', 'Mobiliario', 'Cama King Size', 0, 0, 4, 4, 4, 1);
INSERT INTO `tabm_fecatprod` VALUES('3', 'Mobiliario', 'Escritorio', 0, 0, 16, 16, 16, 1);
INSERT INTO `tabm_fecatprod` VALUES('4', 'Mobiliario', 'Cafetera', 0, 0, 23, 23, 23, 1);
INSERT INTO `tabm_fecatprod` VALUES('5', 'Mobiliario', 'Secadora de pelo', 0, 0, 16, 16, 16, 1);
INSERT INTO `tabm_fecatprod` VALUES('6', 'Mobiliario', 'Telefono', 0, 0, 23, 23, 23, 1);
INSERT INTO `tabm_fecatprod` VALUES('7', 'Mobiliario', 'Televisor', 0, 0, 23, 23, 23, 1);
INSERT INTO `tabm_fecatprod` VALUES('8', 'Mobiliario', 'Cajillas de seguridad', 0, 0, 23, 23, 23, 1);
INSERT INTO `tabm_fecatprod` VALUES('9', 'Mobiliario', 'Sofa-cama', 0, 0, 7, 7, 7, 1);
INSERT INTO `tabm_fecatprod` VALUES('10', 'Mobiliario', 'Cocineta', 0, 0, 7, 7, 7, 1);
INSERT INTO `tabm_fecatprod` VALUES('11', 'Mobiliario', 'Horno microondas', 0, 0, 7, 7, 7, 1);
INSERT INTO `tabm_fecatprod` VALUES('12', 'Mobiliario', 'Tostador', 0, 0, 7, 7, 7, 1);
INSERT INTO `tabm_fecatprod` VALUES('13', 'Mobiliario', 'Refrigerador', 0, 0, 7, 7, 7, 1);
INSERT INTO `tabm_fecatprod` VALUES('14', 'Mobiliario', 'Utensilios para cocina', 0, 0, 7, 7, 7, 1);
INSERT INTO `tabm_fecatprod` VALUES('15', 'Mobiliario', 'Desayunador', 0, 0, 4, 4, 4, 1);
INSERT INTO `tabm_fecatprod` VALUES('16', 'Mobiliario', 'Comoda', 0, 0, 7, 7, 7, 1);
INSERT INTO `tabm_fecatprod` VALUES('17', 'Mobiliario', 'Sala', 0, 0, 3, 3, 3, 1);
INSERT INTO `tabm_fecatprod` VALUES('18', 'Mobiliario', 'Comedor', 0, 0, 3, 3, 3, 1);
INSERT INTO `tabm_fecatprod` VALUES('19', 'Producto', 'Jabon tocador', 5, 8, 25, 25, 25, 1);
INSERT INTO `tabm_fecatprod` VALUES('20', 'Producto', 'Shampoo', 3, 5, 25, 25, 25, 1);
INSERT INTO `tabm_fecatprod` VALUES('21', 'Producto', 'Toalla', 25, 30, 50, 50, 50, 1);
INSERT INTO `tabm_fecatprod` VALUES('22', 'Producto', 'Salero', 8, 11, 30, 30, 30, 1);
INSERT INTO `tabm_fecatprod` VALUES('23', 'Producto', 'Pimentero', 8, 11, 30, 30, 30, 1);
INSERT INTO `tabm_fecatprod` VALUES('24', 'Producto', 'Crema de manos', 20, 25, 50, 50, 50, 1);
INSERT INTO `tabm_fecatprod` VALUES('25', 'Producto', 'Botella de agua', 5, 8, 100, 100, 100, 1);
INSERT INTO `tabm_fecatprod` VALUES('26', 'Producto', 'Botella de vino Pingus', 570, 800, 10, 10, 10, 1);
INSERT INTO `tabm_fecatprod` VALUES('27', 'Producto', 'Crema de cuerpo', 20, 25, 50, 50, 50, 1);
INSERT INTO `tabm_fecatprod` VALUES('28', 'Producto', 'Soda en lata', 4, 6, 100, 100, 100, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_fecliente`
--

CREATE TABLE IF NOT EXISTS `tabm_fecliente` (
  `cod_cte` decimal(4,0) NOT NULL,
  `dpi_cte` varchar(25) NOT NULL,
  `nit_cte` varchar(25) NOT NULL,
  `nom1_cte` varchar(25) NOT NULL,
  `nom2_cte` varchar(25) NOT NULL,
  `apell1_cte` varchar(25) NOT NULL,
  `apell2_cte` varchar(25) NOT NULL,
  `tel_cte` varchar(25) NOT NULL,
  `credito_cte` float NOT NULL,
  `cargo_cte` float NOT NULL,
  `abono_cte` float NOT NULL,
  `cargoacum_cte` float NOT NULL,
  `estado_cte` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_cte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_fecliente`
--

INSERT INTO `tabm_fecliente` VALUES('1', '1929-15654-0101', '7894543-6', 'Luis', 'Daniel', 'Aguirre', 'Gomez', '5784-7125', 3000, 1800, 1300, 500, 1);
INSERT INTO `tabm_fecliente` VALUES('2', '1547-47152-0103', '6792145-4', 'Luisa', 'Fernanda', 'Robledo', 'Mendez', '5065-8070', 3000, 2500, 1000, 1500, 1);
INSERT INTO `tabm_fecliente` VALUES('3', '3578-56415-0105', '1985278-8', 'Jorge', 'Oswaldo', 'Ramirez', 'Estrada', '5052-8072', 6000, 4800, 4000, 800, 1);
INSERT INTO `tabm_fecliente` VALUES('4', '9745-47915-0104', '3216478-7', 'Pedro', 'Jose', 'Aguilar', 'Morataya', '4890-3511', 9000, 8700, 8500, 200, 1);
INSERT INTO `tabm_fecliente` VALUES('5', '3847-31489-0109', '1656781-3', 'Andrea', 'Paola', 'Herandez', 'Moya', '4987-7089', 3000, 3000, 3000, 0, 1);
INSERT INTO `tabm_fecliente` VALUES('6', '9756-49152-0101', '4896914-2', 'Cristian', 'David', 'Estrada', 'Ratzan', '5078-0647', 1000, 530, 270, 280, 1);
INSERT INTO `tabm_fecliente` VALUES('7', '0297-12615-0101', '3147815-1', 'Manuel', 'Andres', 'Alvarez', 'Diaz', '5907-9754', 9000, 6500, 4000, 2500, 1);
INSERT INTO `tabm_fecliente` VALUES('8', '7155-47895-0108', '4985621-8', 'Francisco', 'Antonio', 'Velasquez', 'Guzman', '4878-0894', 6000, 3200, 1500, 1700, 1);
INSERT INTO `tabm_fecliente` VALUES('9', '2648-46517-0107', '4651781-5', 'Karla', 'Daniela', 'Castillo', 'Orellana', '5648-4078', 9000, 8500, 7800, 1200, 1);
INSERT INTO `tabm_fecliente` VALUES('10', '2123-16484-0103', '4749845-4', 'Nidia', 'Fernanda', 'Mazariegos', 'Benitez', '4978-1568', 1000, 650, 400, 250, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_fedocumentos`
--

CREATE TABLE IF NOT EXISTS `tabm_fedocumentos` (
  `cod_docs` decimal(4,0) NOT NULL,
  `cod_empsa` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `cod_suc` decimal(4,0) NOT NULL,
  `cod_ttrans` decimal(4,0) NOT NULL,
  `fechent_inv` date NOT NULL,
  `total_docs` float NOT NULL,
  `estado_docs` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_docs`,`cod_empsa`,`cod_srie`,`cod_suc`),
  KEY `tabm_sucursal_tabm_documentos_fk` (`cod_suc`),
  KEY `tabm_serie_tabm_documentos_fk` (`cod_srie`),
  KEY `tabm_empresa_tabm_documentos_fk` (`cod_empsa`),
  KEY `tabm_tipo_transaccion_tabt_inven_fk` (`cod_ttrans`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_fedocumentos`
--

INSERT INTO `tabm_fedocumentos` VALUES('1', '1', '1', '1', '1', '2014-11-11', 6760, 1);
INSERT INTO `tabm_fedocumentos` VALUES('2', '1', '1', '1', '1', '2014-11-11', 1140, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_feempresa`
--

CREATE TABLE IF NOT EXISTS `tabm_feempresa` (
  `cod_empsa` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `razsocial_empsa` varchar(50) NOT NULL,
  `nomcomercial_empsa` varchar(50) NOT NULL,
  `dire_empsa` varchar(50) NOT NULL,
  `nit_empsa` decimal(25,0) NOT NULL,
  `estado_empsa` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_empsa`),
  KEY `tabm_series_tabm_empresa_fk` (`cod_srie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_feempresa`
--

INSERT INTO `tabm_feempresa` VALUES('1', '1', 'Hotel San Carlos', 'Hotel San Carlos', 'Av Reforma 7-89 Zona 10', '12345678', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_fefactura`
--

CREATE TABLE IF NOT EXISTS `tabm_fefactura` (
  `cod_fra` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `cod_suc` decimal(4,0) NOT NULL,
  `cod_empsa` decimal(4,0) NOT NULL,
  `cod_flocte` decimal(4,0) NOT NULL,
  `fechemitida_fra` date NOT NULL,
  `valor_fra` float NOT NULL,
  `impuesto_fra` float NOT NULL,
  `total_fra` float NOT NULL,
  `estado_fra` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_fra`,`cod_srie`,`cod_suc`,`cod_empsa`),
  KEY `tabm_sucursal_tabm_factura_fk` (`cod_suc`),
  KEY `tabm_serie_tabm_factura_fk` (`cod_srie`),
  KEY `tabm_FEempresa_tabm_FEfactura_fk` (`cod_empsa`),
  KEY `tabm_foliocliente_tabm_factura_fk` (`cod_flocte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_fefactura`
--

INSERT INTO `tabm_fefactura` VALUES('1', '1', '1', '1', '1', '2014-11-11', 4200, 1638, 5838, 1);
INSERT INTO `tabm_fefactura` VALUES('2', '1', '1', '1', '2', '2014-11-11', 2240, 873.6, 3113.6, 1);
INSERT INTO `tabm_fefactura` VALUES('3', '1', '1', '1', '1', '2014-11-11', 4200, 1638, 5838, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_fefoliocliente`
--

CREATE TABLE IF NOT EXISTS `tabm_fefoliocliente` (
  `cod_flocte` decimal(4,0) NOT NULL,
  `cod_rsva` decimal(4,0) NOT NULL,
  `estado_flocte` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_flocte`),
  KEY `tabm_reservacion_tabm_foliocliente_fk` (`cod_rsva`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_fefoliocliente`
--

INSERT INTO `tabm_fefoliocliente` VALUES('1', '1', 1);
INSERT INTO `tabm_fefoliocliente` VALUES('2', '2', 1);
INSERT INTO `tabm_fefoliocliente` VALUES('3', '3', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_feimpuesto`
--

CREATE TABLE IF NOT EXISTS `tabm_feimpuesto` (
  `cod_imp` decimal(4,0) NOT NULL,
  `nom_imp` varchar(25) NOT NULL,
  `valor_imp` float NOT NULL,
  `estado_imp` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_imp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_feimpuesto`
--

INSERT INTO `tabm_feimpuesto` VALUES('1', 'IVA', 0.12, 1);
INSERT INTO `tabm_feimpuesto` VALUES('2', 'ISR', 0.05, 1);
INSERT INTO `tabm_feimpuesto` VALUES('3', 'Turismo', 0.22, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_fereservacion`
--

CREATE TABLE IF NOT EXISTS `tabm_fereservacion` (
  `cod_rsva` decimal(4,0) NOT NULL,
  `cod_cte` decimal(4,0) NOT NULL,
  `fechres_rsva` date NOT NULL,
  `fechent_rsva` date NOT NULL,
  `fechsal_rsva` date NOT NULL,
  `dias_rsva` decimal(4,0) NOT NULL,
  `adultos_rsva` decimal(4,0) NOT NULL,
  `ninos_rsva` decimal(4,0) NOT NULL,
  `total_rsva` float NOT NULL,
  `confent_rsva` tinyint(1) NOT NULL,
  `confsal_rsva` tinyint(1) NOT NULL,
  `estado_rsva` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_rsva`),
  KEY `Cliente_Reservacion_fk` (`cod_cte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_fereservacion`
--

INSERT INTO `tabm_fereservacion` VALUES('1', '1', '2014-11-11', '2014-11-11', '2014-11-14', '0', '3', '2', 3840, 1, 1, 1);
INSERT INTO `tabm_fereservacion` VALUES('2', '2', '2014-11-11', '2014-11-13', '2014-11-15', '0', '2', '1', 2000, 1, 1, 1);
INSERT INTO `tabm_fereservacion` VALUES('3', '3', '2014-11-11', '2014-11-15', '2014-11-16', '0', '1', '1', 640, 1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_feserie`
--

CREATE TABLE IF NOT EXISTS `tabm_feserie` (
  `cod_srie` decimal(4,0) NOT NULL,
  `serie_srie` varchar(25) NOT NULL,
  `estado_srie` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_srie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_feserie`
--

INSERT INTO `tabm_feserie` VALUES('1', 'A11', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_feservicio`
--

CREATE TABLE IF NOT EXISTS `tabm_feservicio` (
  `cod_serv` decimal(4,0) NOT NULL,
  `servicio_serv` varchar(25) NOT NULL,
  `precio_serv` float NOT NULL,
  `disponibilidad_serv` tinyint(1) NOT NULL,
  `estado_serv` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_serv`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_feservicio`
--

INSERT INTO `tabm_feservicio` VALUES('1', 'Servicio en la habitacion', 40, 1, 1);
INSERT INTO `tabm_feservicio` VALUES('2', 'Desayuno', 0, 1, 1);
INSERT INTO `tabm_feservicio` VALUES('3', 'Piscina', 80, 1, 1);
INSERT INTO `tabm_feservicio` VALUES('4', 'Estacionamiento', 0, 1, 1);
INSERT INTO `tabm_feservicio` VALUES('5', 'Internet inalambrico', 0, 1, 1);
INSERT INTO `tabm_feservicio` VALUES('6', 'Servicio de lavanderia', 80, 1, 1);
INSERT INTO `tabm_feservicio` VALUES('7', 'Traslados A-H-A', 0, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_fesucursal`
--

CREATE TABLE IF NOT EXISTS `tabm_fesucursal` (
  `cod_suc` decimal(4,0) NOT NULL,
  `nom_suc` varchar(25) NOT NULL,
  `ubic_suc` varchar(25) NOT NULL,
  `estado_suc` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_suc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_fesucursal`
--

INSERT INTO `tabm_fesucursal` VALUES('1', 'Central', 'Av Reforma 7-89 Zona 10', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_fetambiente`
--

CREATE TABLE IF NOT EXISTS `tabm_fetambiente` (
  `cod_tamb` decimal(4,0) NOT NULL,
  `ambiente_tamb` varchar(25) NOT NULL,
  `estado_tamb` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_tamb`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_fetambiente`
--

INSERT INTO `tabm_fetambiente` VALUES('1', 'Habitacion Sencilla', 1);
INSERT INTO `tabm_fetambiente` VALUES('2', 'Habitacion Doble', 1);
INSERT INTO `tabm_fetambiente` VALUES('3', 'Suite', 1);
INSERT INTO `tabm_fetambiente` VALUES('4', 'Apto. con 1 Habitacion', 1);
INSERT INTO `tabm_fetambiente` VALUES('5', 'Apto. con 2 Habitaciones', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_nndepartamento`
--

CREATE TABLE IF NOT EXISTS `tabm_nndepartamento` (
  `cod_depto` decimal(4,0) NOT NULL,
  `tip_depto` varchar(25) NOT NULL,
  `estado_depto` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_depto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_nndepartamento`
--

INSERT INTO `tabm_nndepartamento` VALUES('1', 'Recursos Humanos', 1);
INSERT INTO `tabm_nndepartamento` VALUES('2', 'Administracion', 1);
INSERT INTO `tabm_nndepartamento` VALUES('3', 'Marketing', 1);
INSERT INTO `tabm_nndepartamento` VALUES('4', 'Contabilidad', 1);
INSERT INTO `tabm_nndepartamento` VALUES('5', 'Seguridad', 1);
INSERT INTO `tabm_nndepartamento` VALUES('6', 'Mantenimiento', 1);
INSERT INTO `tabm_nndepartamento` VALUES('7', 'Recepcion', 1);
INSERT INTO `tabm_nndepartamento` VALUES('8', 'Reservas', 1);
INSERT INTO `tabm_nndepartamento` VALUES('9', 'Alimentos y Bebidas', 1);
INSERT INTO `tabm_nndepartamento` VALUES('10', 'House Keeping', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_nnempleado`
--

CREATE TABLE IF NOT EXISTS `tabm_nnempleado` (
  `cod_emp` decimal(4,0) NOT NULL,
  `cod_empsa` decimal(4,0) NOT NULL,
  `cod_depto` decimal(4,0) NOT NULL,
  `cod_pto` decimal(4,0) NOT NULL,
  `cod_tpago` decimal(4,0) NOT NULL,
  `dpi_emp` decimal(25,0) NOT NULL,
  `nit_emp` varchar(25) NOT NULL,
  `nom1_emp` varchar(25) NOT NULL,
  `nom2_emp` varchar(25) NOT NULL,
  `apell1_emp` varchar(25) NOT NULL,
  `apell2_emp` varchar(25) NOT NULL,
  `dire_emp` varchar(50) NOT NULL,
  `afiigss_emp` decimal(25,0) NOT NULL,
  `salario_emp` float NOT NULL,
  `estado_emp` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_emp`),
  KEY `tabm_puesto_tabm_empleado_fk` (`cod_pto`),
  KEY `tabm_departamento_tabm_empleado_fk` (`cod_depto`),
  KEY `tabm_tpago_tabm_empleado_fk` (`cod_tpago`),
  KEY `tabm_empresa_tabm_empleado_fk` (`cod_empsa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_nnempleado`
--

INSERT INTO `tabm_nnempleado` VALUES('1', '1', '7', '1', '2', '2203976580101', '2723450', 'Angelica', 'Elizabeth', 'Gomez', 'Sosa', '5 avenida 3-44 zona 1', '20110760058', 4500, 1);
INSERT INTO `tabm_nnempleado` VALUES('2', '1', '7', '2', '2', '2245874850101', '7895451', 'Juan', 'Roman', 'Reyes', 'Godinez', '4 calle 3 ave. 1-15 zona 14', '200078459869', 8000, 1);
INSERT INTO `tabm_nnempleado` VALUES('3', '1', '6', '3', '4', '2458795120101', '584784', 'Carlos', 'Eduardo', 'Hall', 'Lopez', 'Avenida los arboles 3-44 zona 6', '200145879658', 4000, 1);
INSERT INTO `tabm_nnempleado` VALUES('4', '1', '6', '4', '4', '2356874950101', '7154872', 'Shenny', 'Maria', 'Vasquez', 'Perez', '21 calle ave. elena 24-9', '20111458785', 3500, 1);
INSERT INTO `tabm_nnempleado` VALUES('5', '1', '6', '5', '2', '4587412580101', '2123453', 'Alejandro', 'Enrique', 'Hernandez', '', '20 calle zona 21', '201478598654', 3250, 1);
INSERT INTO `tabm_nnempleado` VALUES('6', '1', '9', '6', '4', '2365874150101', '7845937', 'Lesly', 'Eunice', 'Araujo', 'Escobar', 'Los olivos 3-D-11', '201475632458', 8500, 1);
INSERT INTO `tabm_nnempleado` VALUES('7', '1', '6', '7', '1', '1254785620101', '4859873', 'Manuel', 'Eduardo', 'Yani', 'Perez', 'El Manantial 3av. 21', '20132012356', 3000, 1);
INSERT INTO `tabm_nnempleado` VALUES('8', '1', '4', '8', '2', '2365874150101', '7845965', 'Carlos', 'Gabriel', 'Duarte', 'Suarez', 'CA-9 km 8.5 zona 17', '201225459874', 12000, 1);
INSERT INTO `tabm_nnempleado` VALUES('9', '1', '5', '9', '1', '2587469710101', '7378100', 'Victor', 'Hugo', 'Giron', 'Hurtado', '4 av. 3 calle zona 1', '20054587586', 11500, 1);
INSERT INTO `tabm_nnempleado` VALUES('10', '1', '6', '10', '2', '2269854120101', '549739', 'Angela', 'Gabriela', 'Andrade', 'Aguilar', 'avenida los arbustos 21-55', '200945879587', 9800, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_nnnomina`
--

CREATE TABLE IF NOT EXISTS `tabm_nnnomina` (
  `cod_nomi` decimal(4,0) NOT NULL,
  `cod_tnomi` decimal(4,0) NOT NULL,
  `cod_empsa` decimal(4,0) NOT NULL,
  `finicio_nomi` date NOT NULL,
  `ffin_nomi` date NOT NULL,
  `estado_nomi` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_nomi`),
  KEY `tabm_tiponomina_tabm_nomina_fk` (`cod_tnomi`),
  KEY `tabm_empresa_tabm_nomina_fk` (`cod_empsa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_nnpuesto`
--

CREATE TABLE IF NOT EXISTS `tabm_nnpuesto` (
  `cod_pto` decimal(4,0) NOT NULL,
  `tipo_pto` varchar(25) NOT NULL,
  `estado_pto` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_pto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_nnpuesto`
--

INSERT INTO `tabm_nnpuesto` VALUES('1', 'Recepcionista', 1);
INSERT INTO `tabm_nnpuesto` VALUES('2', 'Jefe de Recepcion', 1);
INSERT INTO `tabm_nnpuesto` VALUES('3', 'Mayordomo', 1);
INSERT INTO `tabm_nnpuesto` VALUES('4', 'Conserje', 1);
INSERT INTO `tabm_nnpuesto` VALUES('5', 'Botones', 1);
INSERT INTO `tabm_nnpuesto` VALUES('6', 'Chef Ejecutivo', 1);
INSERT INTO `tabm_nnpuesto` VALUES('7', 'Valet Parking', 1);
INSERT INTO `tabm_nnpuesto` VALUES('8', 'Gerente de Operaciones', 1);
INSERT INTO `tabm_nnpuesto` VALUES('9', 'Gerente de Seguridad', 1);
INSERT INTO `tabm_nnpuesto` VALUES('10', 'Encargado de Mantenimient', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_nntnomina`
--

CREATE TABLE IF NOT EXISTS `tabm_nntnomina` (
  `cod_tnomi` decimal(4,0) NOT NULL,
  `tipo_tnomi` varchar(25) NOT NULL,
  `descrip_tnomi` varchar(30) NOT NULL,
  `estado_tnomi` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_tnomi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_nntransaccion`
--

CREATE TABLE IF NOT EXISTS `tabm_nntransaccion` (
  `cod_trans` decimal(4,0) NOT NULL,
  `cod_ctacont` decimal(10,0) NOT NULL,
  `tipo_trans` varchar(25) NOT NULL,
  `valor_trans` float NOT NULL,
  `descrip_trans` varchar(30) NOT NULL,
  `estado_trans` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_trans`),
  KEY `tabm_CTctacont_tabm_NNtransaccion_fk` (`cod_ctacont`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_sgaplicacion`
--

CREATE TABLE IF NOT EXISTS `tabm_sgaplicacion` (
  `cod_app` decimal(4,0) NOT NULL,
  `nomapp_app` varchar(25) NOT NULL,
  `fechcreado_app` date NOT NULL,
  `fechmodif_app` date NOT NULL,
  `estado_app` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_app`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_sgperfil`
--

CREATE TABLE IF NOT EXISTS `tabm_sgperfil` (
  `cod_pfll` decimal(4,0) NOT NULL,
  `nom_pfl` varchar(25) NOT NULL,
  `fechcreado_pfl` date NOT NULL,
  `fechmodif_pfl` date NOT NULL,
  `estado_pfl` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_pfll`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabm_sgpregunta`
--

CREATE TABLE IF NOT EXISTS `tabm_sgpregunta` (
  `cod_preg` decimal(4,0) NOT NULL,
  `nom_preg` varchar(100) NOT NULL,
  `estado_preg` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_preg`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_sgpregunta`
--

INSERT INTO `tabm_sgpregunta` VALUES('1', 'Nombre de mi mascota?', 1);
INSERT INTO `tabm_sgpregunta` VALUES('2', 'Nombre de mi mejor amigo de la infancia?', 1);
INSERT INTO `tabm_sgpregunta` VALUES('3', 'Ciudad de mi infancia?', 1);
INSERT INTO `tabm_sgpregunta` VALUES('4', 'Nombre de mi programa favorito?', 1);
INSERT INTO `tabm_sgpregunta` VALUES('5', 'Nombre de una comida especial?', 1);
INSERT INTO `tabm_sgpregunta` VALUES('6', 'Festividad Favorita?', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_sgprivilegio`
--

CREATE TABLE IF NOT EXISTS `tabm_sgprivilegio` (
  `cod_priv` decimal(4,0) NOT NULL,
  `nom_priv` varchar(25) NOT NULL,
  `fechcreado_privi` date NOT NULL,
  `fechmodif_privi` date NOT NULL,
  `estado_priv` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_priv`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_sgprivilegio`
--

INSERT INTO `tabm_sgprivilegio` VALUES('1', 'Administrador Global', '2014-11-09', '2014-11-09', 1);
INSERT INTO `tabm_sgprivilegio` VALUES('2', 'Administrador de Area', '2014-11-09', '2014-11-09', 1);
INSERT INTO `tabm_sgprivilegio` VALUES('3', 'Estandar', '2014-11-09', '2014-11-09', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabm_sgusuario`
--

CREATE TABLE IF NOT EXISTS `tabm_sgusuario` (
  `cod_usr` decimal(4,0) NOT NULL,
  `cod_emp` decimal(4,0) NOT NULL,
  `cod_priv` decimal(4,0) NOT NULL,
  `cod_preg` decimal(4,0) NOT NULL,
  `cuenta_usr` varchar(25) NOT NULL,
  `correo_usr` varchar(50) NOT NULL,
  `resp_usr` varchar(50) NOT NULL,
  `pass_usr` varchar(25) NOT NULL,
  `fechcreado_usr` date NOT NULL,
  `fechmodif_usr` date NOT NULL,
  `host_usr` varchar(50) NOT NULL,
  `ipdir_usr` varchar(16) NOT NULL,
  `estado_usr` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_usr`),
  KEY `tabm_pregunta_tabm_usuario_fk` (`cod_preg`),
  KEY `tabm_privilegio_tabm_usuario_fk` (`cod_priv`),
  KEY `tabm_empleado_tabm_usuario_fk` (`cod_emp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabm_sgusuario`
--

INSERT INTO `tabm_sgusuario` VALUES('1', '8', '1', '1', 'CGabriel01', 'CarlosGab01@gmail.com', 'Rex', 'C01112014', '2014-11-09', '2014-11-09', 'Maquina 1', '%.%.%.%', 1);
INSERT INTO `tabm_sgusuario` VALUES('2', '9', '2', '2', 'HGiron02', 'HugoGir02@gmail.com', 'Amilcar Chew', 'H02112014', '2014-11-09', '2014-11-09', 'Maquina 2', '%.%.%.%', 1);
INSERT INTO `tabm_sgusuario` VALUES('3', '10', '3', '3', 'AGabriela03', 'AnaG03@gmail.com', 'Cartagena', 'A03112014', '2014-11-09', '2014-11-09', 'Maquina 3', '%.%.%.%', 1);
INSERT INTO `tabm_sgusuario` VALUES('4', '1', '3', '4', 'AGomez04', 'AngelicaG04@gmail.com', 'The Big Bang Theory', 'AG04112014', '2014-11-09', '2014-11-09', 'Maquina 4', '%.%.%.%', 1);
INSERT INTO `tabm_sgusuario` VALUES('5', '2', '1', '5', 'RReyez05', 'RamonR05@gmail.com', 'Onigiri', 'RR05112014', '2014-11-09', '2014-11-09', 'Maquina 5', '%.%.%.%', 1);
INSERT INTO `tabm_sgusuario` VALUES('6', '4', '2', '6', 'MVasquez06', 'MariaV06@gmail.com', 'Hanuka', 'MV06112014', '2014-11-09', '2014-11-09', 'Maquina 6', '%.%.%.%', 1);
INSERT INTO `tabm_sgusuario` VALUES('7', '5', '3', '1', 'AEnriquez07', 'EneriquezH07@gmail.com', 'Fido', 'AE07112014', '2014-11-02', '2014-11-09', 'Maquina 7', '%.%.%.%', 1);
INSERT INTO `tabm_sgusuario` VALUES('8', '6', '3', '2', 'LEunice06', 'LeslyE06@gmail.com', 'Ana Maria Guerra', 'LE06112014', '2014-11-09', '2014-11-09', 'Maquina 8', '%.%.%.%', 1);
INSERT INTO `tabm_sgusuario` VALUES('9', '3', '3', '3', 'HLopez09', 'HallL09@gmail.com', 'Cristina', 'HL09112014', '2014-11-09', '2014-11-09', 'Maquina 9', '%.%.%.%', 1);
INSERT INTO `tabm_sgusuario` VALUES('10', '7', '3', '3', 'EYani07', 'EduardoY07@gmail.com', 'Esquipulas', 'EY07112014', '2014-11-09', '2014-11-09', 'Maquina 10', '%.%.%.%', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabt_bcctacontab`
--

CREATE TABLE IF NOT EXISTS `tabt_bcctacontab` (
  `cod_compconta` decimal(4,0) NOT NULL,
  `cod_ctas` decimal(4,0) NOT NULL,
  `cod_cte` decimal(4,0) NOT NULL,
  `estado_ctacontab` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_compconta`,`cod_ctas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_bchistoriabanc`
--

CREATE TABLE IF NOT EXISTS `tabt_bchistoriabanc` (
  `codhstbco_hstbco` decimal(4,0) NOT NULL,
  `cod_ctabco` decimal(4,0) NOT NULL,
  `anio_hstbco` decimal(4,0) NOT NULL,
  `trim_hstbco` decimal(1,0) NOT NULL,
  `mes_hstbco` varchar(25) NOT NULL,
  `saldo_hstbco` float NOT NULL,
  `estado_hstbco` tinyint(1) NOT NULL,
  PRIMARY KEY (`codhstbco_hstbco`,`cod_ctabco`),
  KEY `tabm_BCcuentabanco_tabt_BChistoriabanc_fk` (`cod_ctabco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_bcmovbanc`
--

CREATE TABLE IF NOT EXISTS `tabt_bcmovbanc` (
  `cod_mov` decimal(4,0) NOT NULL,
  `cod_ctabco` decimal(4,0) NOT NULL,
  `cod_ttrans` decimal(4,0) NOT NULL,
  `cod_tpago` decimal(4,0) NOT NULL,
  `cod_ctas` decimal(4,0) NOT NULL,
  `cod_compconta` decimal(4,0) NOT NULL,
  `cant_movbco` float NOT NULL,
  `estado_movbco` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_mov`,`cod_ctabco`),
  KEY `tabm_cuentabanco_tabt_movbanc_fk` (`cod_ctabco`),
  KEY `tabt_ctacontab_tabt_movbanc_fk` (`cod_compconta`,`cod_ctas`),
  KEY `tabm_CPtpago_tabt_movbanc_fk` (`cod_tpago`),
  KEY `tabm_CCCPttrans_tabt_movbanc_fk` (`cod_ttrans`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_bcpagoprem`
--

CREATE TABLE IF NOT EXISTS `tabt_bcpagoprem` (
  `cod_ctabco` decimal(4,0) NOT NULL,
  `codprem_prem` decimal(4,0) NOT NULL,
  `fechcreado_pagoprem` date NOT NULL,
  `cantpag_pagoprem` float NOT NULL,
  `estado_pagoprem` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_ctabco`,`codprem_prem`),
  KEY `tabm_prestamo_tabt_pagoprem_fk` (`codprem_prem`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_bibitacora`
--

CREATE TABLE IF NOT EXISTS `tabt_bibitacora` (
  `cod_bita` decimal(4,0) NOT NULL,
  `cod_usr` decimal(4,0) NOT NULL,
  `fecha_bita` date NOT NULL,
  `codRegistro_bita` decimal(4,0) NOT NULL,
  `accion_bita` varchar(25) NOT NULL,
  `tabla_bita` varchar(25) NOT NULL,
  `campo_bita` varchar(25) NOT NULL,
  `datoviejo_bita` varchar(25) NOT NULL,
  `datonuevo_bita` varchar(25) NOT NULL,
  `usuario_bita` varchar(25) NOT NULL,
  `ip_bita` varchar(25) NOT NULL,
  `host_bita` varchar(50) NOT NULL,
  `estado_bita` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_bita`),
  KEY `tabm_usuario_tabt_BIbitacora_fk` (`cod_usr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_cpdcompra`
--

CREATE TABLE IF NOT EXISTS `tabt_cpdcompra` (
  `cod_compra` decimal(4,0) NOT NULL,
  `cod_prov` decimal(4,0) NOT NULL,
  `cod_catprod` decimal(4,0) NOT NULL,
  `cantidad_dcompra` decimal(4,0) NOT NULL,
  `valor_dcompra` float NOT NULL,
  `estado_dcompra` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_compra`,`cod_prov`,`cod_catprod`),
  KEY `tabm_catprod_tabt_dcompras_fk` (`cod_catprod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_ctmovdiario`
--

CREATE TABLE IF NOT EXISTS `tabt_ctmovdiario` (
  `fechcreado_dro` date NOT NULL,
  `codpartd_dro` decimal(10,0) NOT NULL,
  `cod_ctacont` decimal(10,0) NOT NULL,
  `debhab_dro` tinyint(1) NOT NULL,
  `cant_dro` float NOT NULL,
  `estado_movdiario` tinyint(1) NOT NULL,
  PRIMARY KEY (`fechcreado_dro`,`codpartd_dro`,`cod_ctacont`),
  KEY `tabm_ctacont_tabt_movdiario_fk` (`cod_ctacont`),
  KEY `tabm_diario_tabt_movdiario_fk` (`codpartd_dro`,`fechcreado_dro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_ctremune`
--

CREATE TABLE IF NOT EXISTS `tabt_ctremune` (
  `cod_remu` decimal(4,0) NOT NULL,
  `cod_compconta` decimal(4,0) NOT NULL,
  `cod_emp` decimal(4,0) NOT NULL,
  `cod_compconta_1` decimal(10,0) NOT NULL,
  `mes_remu` decimal(2,0) NOT NULL,
  `anio_remu` decimal(4,0) NOT NULL,
  `salario_rem` float NOT NULL,
  `diastrabajados_remu` decimal(4,0) NOT NULL,
  `estado_remune` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_remu`),
  KEY `tabm_compconta_tabt_remune_fk` (`cod_compconta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_ctsalarioneto`
--

CREATE TABLE IF NOT EXISTS `tabt_ctsalarioneto` (
  `cod_slnet` decimal(4,0) NOT NULL,
  `cod_remu` decimal(4,0) NOT NULL,
  `cod_descempl` decimal(4,0) NOT NULL,
  `salariototal_tlp` float NOT NULL,
  `estado_slnet` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_slnet`,`cod_remu`),
  KEY `tabm_descuentoempl_tabt_salarioneto_fk` (`cod_descempl`),
  KEY `tabt_remune_tabt_salarioneto_fk` (`cod_remu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_feambcatprod`
--

CREATE TABLE IF NOT EXISTS `tabt_feambcatprod` (
  `cod_amb` decimal(4,0) NOT NULL,
  `cod_catprod` decimal(4,0) NOT NULL,
  `cant_ambcatprod` float NOT NULL,
  `estado_ambcatprod` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_amb`,`cod_catprod`),
  KEY `tabm_FEcatprod_tabt_FEambcatprod_fk` (`cod_catprod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabt_feambcatprod`
--

INSERT INTO `tabt_feambcatprod` VALUES('1', '1', 1, 0);
INSERT INTO `tabt_feambcatprod` VALUES('1', '3', 1, 0);
INSERT INTO `tabt_feambcatprod` VALUES('1', '4', 1, 0);
INSERT INTO `tabt_feambcatprod` VALUES('1', '5', 1, 0);
INSERT INTO `tabt_feambcatprod` VALUES('1', '6', 1, 0);
INSERT INTO `tabt_feambcatprod` VALUES('1', '7', 1, 0);
INSERT INTO `tabt_feambcatprod` VALUES('1', '8', 1, 0);
INSERT INTO `tabt_feambcatprod` VALUES('2', '1', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('2', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('2', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('2', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('2', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('2', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('2', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('3', '1', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('3', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('3', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('3', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('3', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('3', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('3', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('4', '1', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('4', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('4', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('4', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('4', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('4', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('4', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('5', '1', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('5', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('5', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('5', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('5', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('5', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('5', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('6', '1', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('6', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('6', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('6', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('6', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('6', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('6', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('7', '1', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('7', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('7', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('7', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('7', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('7', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('7', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('8', '1', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('8', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('8', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('8', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('8', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('8', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('8', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('9', '1', 2, 1);
INSERT INTO `tabt_feambcatprod` VALUES('9', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('9', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('9', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('9', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('9', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('9', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('10', '1', 2, 1);
INSERT INTO `tabt_feambcatprod` VALUES('10', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('10', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('10', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('10', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('10', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('10', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('11', '1', 2, 1);
INSERT INTO `tabt_feambcatprod` VALUES('11', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('11', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('11', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('11', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('11', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('11', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('12', '1', 2, 1);
INSERT INTO `tabt_feambcatprod` VALUES('12', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('12', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('12', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('12', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('12', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('12', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('13', '1', 2, 1);
INSERT INTO `tabt_feambcatprod` VALUES('13', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('13', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('13', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('13', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('13', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('13', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('14', '1', 2, 1);
INSERT INTO `tabt_feambcatprod` VALUES('14', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('14', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('14', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('14', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('14', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('14', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('15', '1', 2, 1);
INSERT INTO `tabt_feambcatprod` VALUES('15', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('15', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('15', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('15', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('15', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('15', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('16', '1', 2, 1);
INSERT INTO `tabt_feambcatprod` VALUES('16', '3', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('16', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('16', '5', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('16', '6', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('16', '7', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('16', '8', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('17', '2', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('17', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('17', '9', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('17', '10', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('17', '11', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('17', '12', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('17', '13', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('17', '14', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('17', '15', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('17', '16', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('18', '2', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('18', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('18', '9', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('18', '10', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('18', '11', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('18', '12', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('18', '13', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('18', '14', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('18', '15', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('18', '16', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('19', '2', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('19', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('19', '9', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('19', '10', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('19', '11', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('19', '12', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('19', '13', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('19', '14', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('19', '15', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('19', '16', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('20', '2', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('20', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('20', '9', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('20', '10', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('20', '11', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('20', '12', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('20', '13', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('20', '14', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('20', '15', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('20', '16', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '2', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '9', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '10', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '11', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '12', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '13', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '14', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '16', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '17', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('21', '18', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '2', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '9', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '10', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '11', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '12', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '13', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '14', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '16', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '17', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('22', '18', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '2', 2, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '4', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '9', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '10', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '11', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '12', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '13', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '14', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '16', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '17', 1, 1);
INSERT INTO `tabt_feambcatprod` VALUES('23', '18', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabt_feddocumentos`
--

CREATE TABLE IF NOT EXISTS `tabt_feddocumentos` (
  `cod_docs` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `cod_catprod` decimal(4,0) NOT NULL,
  `cod_bga` decimal(4,0) NOT NULL,
  `precioc_ddocs` float NOT NULL,
  `preciov_ddocs` float NOT NULL,
  `cant_ddocs` decimal(4,0) NOT NULL,
  `valor_ddocs` float NOT NULL,
  `estado_ddocs` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_docs`,`cod_srie`,`cod_catprod`),
  KEY `tabm_serie_tabt_ddocumentos_fk` (`cod_srie`),
  KEY `tabm_bodega_tabt_ddocumentos_fk` (`cod_bga`),
  KEY `cata_producto_tabt_kardex_fk` (`cod_catprod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabt_feddocumentos`
--

INSERT INTO `tabt_feddocumentos` VALUES('1', '1', '22', '1', 8, 11, '10', 80, 1);
INSERT INTO `tabt_feddocumentos` VALUES('1', '1', '23', '1', 8, 11, '10', 80, 1);
INSERT INTO `tabt_feddocumentos` VALUES('1', '1', '25', '1', 5, 8, '100', 500, 1);
INSERT INTO `tabt_feddocumentos` VALUES('1', '1', '26', '1', 570, 800, '10', 5700, 1);
INSERT INTO `tabt_feddocumentos` VALUES('1', '1', '28', '1', 4, 6, '100', 400, 1);
INSERT INTO `tabt_feddocumentos` VALUES('2', '1', '19', '2', 5, 8, '30', 150, 1);
INSERT INTO `tabt_feddocumentos` VALUES('2', '1', '20', '2', 3, 5, '30', 90, 1);
INSERT INTO `tabt_feddocumentos` VALUES('2', '1', '21', '2', 25, 30, '20', 500, 1);
INSERT INTO `tabt_feddocumentos` VALUES('2', '1', '24', '2', 20, 25, '10', 200, 1);
INSERT INTO `tabt_feddocumentos` VALUES('2', '1', '27', '2', 20, 25, '10', 200, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabt_fedrsva`
--

CREATE TABLE IF NOT EXISTS `tabt_fedrsva` (
  `cod_rsva` decimal(4,0) NOT NULL,
  `cod_amb` decimal(4,0) NOT NULL,
  `dias_drsva` float NOT NULL,
  `total_drsva` float NOT NULL,
  `estado_drsva` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_rsva`,`cod_amb`),
  KEY `Habitacion_Dett_Reservacion_fk` (`cod_amb`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabt_fedrsva`
--

INSERT INTO `tabt_fedrsva` VALUES('1', '1', 3, 1920, 1);
INSERT INTO `tabt_fedrsva` VALUES('1', '2', 3, 1920, 1);
INSERT INTO `tabt_fedrsva` VALUES('2', '17', 2, 2000, 1);
INSERT INTO `tabt_fedrsva` VALUES('3', '1', 1, 640, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabt_feexistencias`
--

CREATE TABLE IF NOT EXISTS `tabt_feexistencias` (
  `cod_bga` decimal(4,0) NOT NULL,
  `cod_catprod` decimal(4,0) NOT NULL,
  `cant_exis` float NOT NULL,
  `cantcongelada_exis` float NOT NULL,
  `estado_exis` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_bga`,`cod_catprod`),
  KEY `tabm_catprod_tabt_existencias_fk` (`cod_catprod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabt_feexistencias`
--

INSERT INTO `tabt_feexistencias` VALUES('1', '22', 10, 10, 1);
INSERT INTO `tabt_feexistencias` VALUES('1', '23', 10, 10, 1);
INSERT INTO `tabt_feexistencias` VALUES('1', '25', 100, 100, 1);
INSERT INTO `tabt_feexistencias` VALUES('1', '26', 10, 10, 1);
INSERT INTO `tabt_feexistencias` VALUES('1', '28', 100, 100, 1);
INSERT INTO `tabt_feexistencias` VALUES('2', '19', 30, 30, 1);
INSERT INTO `tabt_feexistencias` VALUES('2', '20', 30, 30, 1);
INSERT INTO `tabt_feexistencias` VALUES('2', '21', 20, 20, 1);
INSERT INTO `tabt_feexistencias` VALUES('2', '24', 10, 10, 1);
INSERT INTO `tabt_feexistencias` VALUES('2', '27', 10, 10, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabt_fefraim`
--

CREATE TABLE IF NOT EXISTS `tabt_fefraim` (
  `cod_fra` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `cod_suc` decimal(4,0) NOT NULL,
  `cod_imp` decimal(4,0) NOT NULL,
  `total_fraimp` float NOT NULL,
  `estado_fraimp` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_fra`,`cod_srie`,`cod_suc`,`cod_imp`),
  KEY `tabm_FEimpuesto_tabt_FEfraim_fk` (`cod_imp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabt_fefraim`
--

INSERT INTO `tabt_fefraim` VALUES('1', '1', '1', '1', 504, 1);
INSERT INTO `tabt_fefraim` VALUES('1', '1', '1', '2', 210, 1);
INSERT INTO `tabt_fefraim` VALUES('1', '1', '1', '3', 924, 1);
INSERT INTO `tabt_fefraim` VALUES('2', '1', '1', '1', 268.8, 1);
INSERT INTO `tabt_fefraim` VALUES('2', '1', '1', '2', 112, 1);
INSERT INTO `tabt_fefraim` VALUES('2', '1', '1', '3', 492.8, 1);
INSERT INTO `tabt_fefraim` VALUES('3', '1', '1', '1', 504, 1);
INSERT INTO `tabt_fefraim` VALUES('3', '1', '1', '2', 210, 1);
INSERT INTO `tabt_fefraim` VALUES('3', '1', '1', '3', 924, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabt_feservflocte`
--

CREATE TABLE IF NOT EXISTS `tabt_feservflocte` (
  `cod_flocte` decimal(4,0) NOT NULL,
  `cod_serv` decimal(4,0) NOT NULL,
  `cant_servflocte` float NOT NULL,
  `total_servflocte` float NOT NULL,
  `estado_servflocte` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_flocte`,`cod_serv`),
  KEY `tabm_servicio_tabt_servflocte_fk` (`cod_serv`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tabt_feservflocte`
--

INSERT INTO `tabt_feservflocte` VALUES('1', '1', 3, 120, 1);
INSERT INTO `tabt_feservflocte` VALUES('1', '2', 3, 0, 1);
INSERT INTO `tabt_feservflocte` VALUES('1', '6', 3, 240, 1);
INSERT INTO `tabt_feservflocte` VALUES('2', '1', 2, 80, 1);
INSERT INTO `tabt_feservflocte` VALUES('2', '2', 4, 0, 1);
INSERT INTO `tabt_feservflocte` VALUES('2', '4', 2, 0, 1);
INSERT INTO `tabt_feservflocte` VALUES('2', '6', 2, 160, 1);
INSERT INTO `tabt_feservflocte` VALUES('3', '1', 1, 40, 1);
INSERT INTO `tabt_feservflocte` VALUES('3', '2', 1, 0, 1);
INSERT INTO `tabt_feservflocte` VALUES('3', '6', 1, 80, 1);
INSERT INTO `tabt_feservflocte` VALUES('3', '7', 1, 0, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabt_nndnomina`
--

CREATE TABLE IF NOT EXISTS `tabt_nndnomina` (
  `cod_nomi` decimal(4,0) NOT NULL,
  `cod_trans` decimal(4,0) NOT NULL,
  `cod_emp` decimal(4,0) NOT NULL,
  `diastrab_dnomi` float NOT NULL,
  `diasnolab_dnomi` float NOT NULL,
  `totasigna_dnomi` float NOT NULL,
  `totdeduc_dnomi` float NOT NULL,
  `suneto_dnomi` float NOT NULL,
  `estado_dnomi` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_nomi`,`cod_trans`,`cod_emp`),
  KEY `tabm_NNtransaccion_tabm_NNdnomina_fk` (`cod_trans`),
  KEY `tabm_NNempleado_tabm_NNdnomina_fk` (`cod_emp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_sgasignapppersonal`
--

CREATE TABLE IF NOT EXISTS `tabt_sgasignapppersonal` (
  `cod_aappp` decimal(4,0) NOT NULL,
  `cod_usr` decimal(4,0) NOT NULL,
  `cod_app` decimal(4,0) NOT NULL,
  `fechcreado_aappp` date NOT NULL,
  `fechmodif_aappp` date NOT NULL,
  `estado_asignapppersonal` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_aappp`),
  KEY `tabm_aplicacion_tabt_asignapppersonal_fk` (`cod_app`),
  KEY `tabm_SGusuario_tabt_SGasignapppersonal_fk` (`cod_usr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_sgperfilapp`
--

CREATE TABLE IF NOT EXISTS `tabt_sgperfilapp` (
  `cod_papp` decimal(4,0) NOT NULL,
  `Id_perfil` decimal(4,0) NOT NULL,
  `cod_app` decimal(4,0) NOT NULL,
  `fechcreado_papp` date NOT NULL,
  `select_papp` tinyint(1) NOT NULL,
  `insert_paap` tinyint(1) NOT NULL,
  `update_papp` tinyint(1) NOT NULL,
  `delete_papp` tinyint(1) NOT NULL,
  `imprimir_papp` tinyint(1) NOT NULL,
  `estado_papp` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_papp`,`Id_perfil`),
  KEY `tabm_perfil_tabt_perfilapp_fk` (`Id_perfil`),
  KEY `tabm_aplicacion_tabt_perfilapp_fk` (`cod_app`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_sgperfiusuario`
--

CREATE TABLE IF NOT EXISTS `tabt_sgperfiusuario` (
  `cod_pusr` decimal(4,0) NOT NULL,
  `cod_usr` decimal(4,0) NOT NULL,
  `cod_pfll` decimal(4,0) NOT NULL,
  `fechcreado_plfusr` date NOT NULL,
  `fechmodf_pflusr` date NOT NULL,
  `estado_plfusr` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_pusr`),
  KEY `tabm_perfil_tabt_perfiusuario_fk` (`cod_pfll`),
  KEY `tabm_usuario_tabt_perfiusuario_fk` (`cod_usr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tabt_sgsesion`
--

CREATE TABLE IF NOT EXISTS `tabt_sgsesion` (
  `cod_ses` decimal(4,0) NOT NULL,
  `cod_usr` decimal(4,0) NOT NULL,
  `sesact_ses` tinyint(1) NOT NULL,
  `fechinic_ses` date NOT NULL,
  `fechfin_ses` date NOT NULL,
  `estado_sesion` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_ses`,`cod_usr`),
  KEY `tabm_SGusuario_tabt_sesion_fk` (`cod_usr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tabm_cccpcaja`
--
ALTER TABLE `tabm_cccpcaja`
  ADD CONSTRAINT `tabm_tipocaja_tabm_caja_fk` FOREIGN KEY (`cod_tpago`) REFERENCES `tabm_cptpago` (`cod_tpago`);

--
-- Constraints for table `tabm_cctranscc`
--
ALTER TABLE `tabm_cctranscc`
  ADD CONSTRAINT `tabm_factura_tabm_transcc_fk` FOREIGN KEY (`cod_fra`) REFERENCES `tabm_fefactura` (`cod_fra`),
  ADD CONSTRAINT `tabm_caja_tabm_transcc_fk` FOREIGN KEY (`cod_caja`) REFERENCES `tabm_cccpcaja` (`cod_caja`),
  ADD CONSTRAINT `tabm_cliente_tabm_transcc_fk` FOREIGN KEY (`cod_cte`) REFERENCES `tabm_fecliente` (`cod_cte`),
  ADD CONSTRAINT `tabm_serie_tabm_transcc_fk` FOREIGN KEY (`cod_srie`) REFERENCES `tabm_feserie` (`cod_srie`),
  ADD CONSTRAINT `tabm_ttrans_tabm_transcc_fk` FOREIGN KEY (`cod_ttrans`) REFERENCES `tabm_cccpttrans` (`cod_ttrans`);

--
-- Constraints for table `tabm_cpcompras`
--
ALTER TABLE `tabm_cpcompras`
  ADD CONSTRAINT `tabm_FEfactura_tabm_CPcompras_fk` FOREIGN KEY (`cod_fra`, `cod_srie`, `cod_suc`, `cod_empsa`) REFERENCES `tabm_fefactura` (`cod_fra`, `cod_srie`, `cod_suc`, `cod_empsa`),
  ADD CONSTRAINT `tabm_proveedor_tabm_compras_fk` FOREIGN KEY (`cod_prov`) REFERENCES `tabm_cpproveedor` (`cod_prov`);

--
-- Constraints for table `tabm_cptranscp`
--
ALTER TABLE `tabm_cptranscp`
  ADD CONSTRAINT `tabm_CPcompras_tabm_CPtranscp_fk` FOREIGN KEY (`cod_compra`, `cod_prov`, `cod_fra`, `cod_srie`, `cod_suc`, `cod_empsa`) REFERENCES `tabm_cpcompras` (`cod_compra`, `cod_prov`, `cod_fra`, `cod_srie`, `cod_suc`, `cod_empsa`),
  ADD CONSTRAINT `tabm_caja_tabm_transcp_fk` FOREIGN KEY (`cod_caja`) REFERENCES `tabm_cccpcaja` (`cod_caja`),
  ADD CONSTRAINT `tabm_empresa_tabm_transcp_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_feempresa` (`cod_empsa`),
  ADD CONSTRAINT `tabm_proveedor_tabm_transcp_fk` FOREIGN KEY (`cod_prov`) REFERENCES `tabm_cpproveedor` (`cod_prov`),
  ADD CONSTRAINT `tabm_ttrans_tabm_transcp_fk` FOREIGN KEY (`cod_ttrans`) REFERENCES `tabm_cccpttrans` (`cod_ttrans`),
  ADD CONSTRAINT `tabt_ctacontab_tabm_CPtranscp_fk` FOREIGN KEY (`cod_compconta`, `cod_ctas`) REFERENCES `tabt_bcctacontab` (`cod_compconta`, `cod_ctas`);

--
-- Constraints for table `tabm_ctcompconta`
--
ALTER TABLE `tabm_ctcompconta`
  ADD CONSTRAINT `tabm_doccomp_tabm_compconta_fk` FOREIGN KEY (`codtipodoc_compcont`) REFERENCES `tabm_ctdoccomp` (`codtipodoc_compcont`);

--
-- Constraints for table `tabm_ctdiario`
--
ALTER TABLE `tabm_ctdiario`
  ADD CONSTRAINT `tabm_compconta_tabm_diario_fk` FOREIGN KEY (`cod_compconta`) REFERENCES `tabm_ctcompconta` (`cod_compconta`);

--
-- Constraints for table `tabm_ctinventario`
--
ALTER TABLE `tabm_ctinventario`
  ADD CONSTRAINT `tabm_ctacont_tabm_inventario_fk` FOREIGN KEY (`cod_ctacont`) REFERENCES `tabm_ctctacont` (`cod_ctacont`);

--
-- Constraints for table `tabm_feambiente`
--
ALTER TABLE `tabm_feambiente`
  ADD CONSTRAINT `Tipo_Habitacion_Habitacion_fk` FOREIGN KEY (`cod_tamb`) REFERENCES `tabm_fetambiente` (`cod_tamb`);

--
-- Constraints for table `tabm_febodega`
--
ALTER TABLE `tabm_febodega`
  ADD CONSTRAINT `tabm_sucursal_tabm_bodega_fk` FOREIGN KEY (`cod_suc`) REFERENCES `tabm_fesucursal` (`cod_suc`);

--
-- Constraints for table `tabm_fedocumentos`
--
ALTER TABLE `tabm_fedocumentos`
  ADD CONSTRAINT `tabm_tipo_transaccion_tabt_inven_fk` FOREIGN KEY (`cod_ttrans`) REFERENCES `tabm_cccpttrans` (`cod_ttrans`),
  ADD CONSTRAINT `tabm_empresa_tabm_documentos_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_feempresa` (`cod_empsa`),
  ADD CONSTRAINT `tabm_serie_tabm_documentos_fk` FOREIGN KEY (`cod_srie`) REFERENCES `tabm_feserie` (`cod_srie`),
  ADD CONSTRAINT `tabm_sucursal_tabm_documentos_fk` FOREIGN KEY (`cod_suc`) REFERENCES `tabm_fesucursal` (`cod_suc`);

--
-- Constraints for table `tabm_feempresa`
--
ALTER TABLE `tabm_feempresa`
  ADD CONSTRAINT `tabm_series_tabm_empresa_fk` FOREIGN KEY (`cod_srie`) REFERENCES `tabm_feserie` (`cod_srie`);

--
-- Constraints for table `tabm_fefactura`
--
ALTER TABLE `tabm_fefactura`
  ADD CONSTRAINT `tabm_foliocliente_tabm_factura_fk` FOREIGN KEY (`cod_flocte`) REFERENCES `tabm_fefoliocliente` (`cod_flocte`),
  ADD CONSTRAINT `tabm_FEempresa_tabm_FEfactura_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_feempresa` (`cod_empsa`),
  ADD CONSTRAINT `tabm_serie_tabm_factura_fk` FOREIGN KEY (`cod_srie`) REFERENCES `tabm_feserie` (`cod_srie`),
  ADD CONSTRAINT `tabm_sucursal_tabm_factura_fk` FOREIGN KEY (`cod_suc`) REFERENCES `tabm_fesucursal` (`cod_suc`);

--
-- Constraints for table `tabm_fefoliocliente`
--
ALTER TABLE `tabm_fefoliocliente`
  ADD CONSTRAINT `tabm_reservacion_tabm_foliocliente_fk` FOREIGN KEY (`cod_rsva`) REFERENCES `tabm_fereservacion` (`cod_rsva`);

--
-- Constraints for table `tabm_fereservacion`
--
ALTER TABLE `tabm_fereservacion`
  ADD CONSTRAINT `Cliente_Reservacion_fk` FOREIGN KEY (`cod_cte`) REFERENCES `tabm_fecliente` (`cod_cte`);

--
-- Constraints for table `tabm_nnempleado`
--
ALTER TABLE `tabm_nnempleado`
  ADD CONSTRAINT `tabm_empresa_tabm_empleado_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_feempresa` (`cod_empsa`),
  ADD CONSTRAINT `tabm_departamento_tabm_empleado_fk` FOREIGN KEY (`cod_depto`) REFERENCES `tabm_nndepartamento` (`cod_depto`),
  ADD CONSTRAINT `tabm_puesto_tabm_empleado_fk` FOREIGN KEY (`cod_pto`) REFERENCES `tabm_nnpuesto` (`cod_pto`),
  ADD CONSTRAINT `tabm_tpago_tabm_empleado_fk` FOREIGN KEY (`cod_tpago`) REFERENCES `tabm_cptpago` (`cod_tpago`);

--
-- Constraints for table `tabm_nnnomina`
--
ALTER TABLE `tabm_nnnomina`
  ADD CONSTRAINT `tabm_empresa_tabm_nomina_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_feempresa` (`cod_empsa`),
  ADD CONSTRAINT `tabm_tiponomina_tabm_nomina_fk` FOREIGN KEY (`cod_tnomi`) REFERENCES `tabm_nntnomina` (`cod_tnomi`);

--
-- Constraints for table `tabm_nntransaccion`
--
ALTER TABLE `tabm_nntransaccion`
  ADD CONSTRAINT `tabm_CTctacont_tabm_NNtransaccion_fk` FOREIGN KEY (`cod_ctacont`) REFERENCES `tabm_ctctacont` (`cod_ctacont`);

--
-- Constraints for table `tabm_sgusuario`
--
ALTER TABLE `tabm_sgusuario`
  ADD CONSTRAINT `tabm_empleado_tabm_usuario_fk` FOREIGN KEY (`cod_emp`) REFERENCES `tabm_nnempleado` (`cod_emp`),
  ADD CONSTRAINT `tabm_pregunta_tabm_usuario_fk` FOREIGN KEY (`cod_preg`) REFERENCES `tabm_sgpregunta` (`cod_preg`),
  ADD CONSTRAINT `tabm_privilegio_tabm_usuario_fk` FOREIGN KEY (`cod_priv`) REFERENCES `tabm_sgprivilegio` (`cod_priv`);

--
-- Constraints for table `tabt_bcctacontab`
--
ALTER TABLE `tabt_bcctacontab`
  ADD CONSTRAINT `tabm_compconta_tabt_ctacontab_fk` FOREIGN KEY (`cod_compconta`) REFERENCES `tabm_ctcompconta` (`cod_compconta`);

--
-- Constraints for table `tabt_bchistoriabanc`
--
ALTER TABLE `tabt_bchistoriabanc`
  ADD CONSTRAINT `tabm_BCcuentabanco_tabt_BChistoriabanc_fk` FOREIGN KEY (`cod_ctabco`) REFERENCES `tabm_bccuentabanco` (`cod_ctabco`);

--
-- Constraints for table `tabt_bcmovbanc`
--
ALTER TABLE `tabt_bcmovbanc`
  ADD CONSTRAINT `tabm_CCCPttrans_tabt_movbanc_fk` FOREIGN KEY (`cod_ttrans`) REFERENCES `tabm_cccpttrans` (`cod_ttrans`),
  ADD CONSTRAINT `tabm_CPtpago_tabt_movbanc_fk` FOREIGN KEY (`cod_tpago`) REFERENCES `tabm_cptpago` (`cod_tpago`),
  ADD CONSTRAINT `tabm_cuentabanco_tabt_movbanc_fk` FOREIGN KEY (`cod_ctabco`) REFERENCES `tabm_bccuentabanco` (`cod_ctabco`),
  ADD CONSTRAINT `tabt_ctacontab_tabt_movbanc_fk` FOREIGN KEY (`cod_compconta`, `cod_ctas`) REFERENCES `tabt_bcctacontab` (`cod_compconta`, `cod_ctas`);

--
-- Constraints for table `tabt_bcpagoprem`
--
ALTER TABLE `tabt_bcpagoprem`
  ADD CONSTRAINT `tabm_cuentabanco_tabt_pagoprem_fk` FOREIGN KEY (`cod_ctabco`) REFERENCES `tabm_bccuentabanco` (`cod_ctabco`),
  ADD CONSTRAINT `tabm_prestamo_tabt_pagoprem_fk` FOREIGN KEY (`codprem_prem`) REFERENCES `tabm_bcprestamo` (`codprem_prem`);

--
-- Constraints for table `tabt_bibitacora`
--
ALTER TABLE `tabt_bibitacora`
  ADD CONSTRAINT `tabm_usuario_tabt_BIbitacora_fk` FOREIGN KEY (`cod_usr`) REFERENCES `tabm_sgusuario` (`cod_usr`);

--
-- Constraints for table `tabt_cpdcompra`
--
ALTER TABLE `tabt_cpdcompra`
  ADD CONSTRAINT `tabm_compras_tabt_dcompras_fk` FOREIGN KEY (`cod_compra`, `cod_prov`) REFERENCES `tabm_cpcompras` (`cod_compra`, `cod_prov`),
  ADD CONSTRAINT `tabm_catprod_tabt_dcompras_fk` FOREIGN KEY (`cod_catprod`) REFERENCES `tabm_fecatprod` (`cod_catprod`);

--
-- Constraints for table `tabt_ctmovdiario`
--
ALTER TABLE `tabt_ctmovdiario`
  ADD CONSTRAINT `tabm_diario_tabt_movdiario_fk` FOREIGN KEY (`codpartd_dro`, `fechcreado_dro`) REFERENCES `tabm_ctdiario` (`codpartd_dro`, `fechcreado_dro`),
  ADD CONSTRAINT `tabm_ctacont_tabt_movdiario_fk` FOREIGN KEY (`cod_ctacont`) REFERENCES `tabm_ctctacont` (`cod_ctacont`);

--
-- Constraints for table `tabt_ctremune`
--
ALTER TABLE `tabt_ctremune`
  ADD CONSTRAINT `tabm_compconta_tabt_remune_fk` FOREIGN KEY (`cod_compconta`) REFERENCES `tabm_ctcompconta` (`cod_compconta`);

--
-- Constraints for table `tabt_ctsalarioneto`
--
ALTER TABLE `tabt_ctsalarioneto`
  ADD CONSTRAINT `tabt_remune_tabt_salarioneto_fk` FOREIGN KEY (`cod_remu`) REFERENCES `tabt_ctremune` (`cod_remu`),
  ADD CONSTRAINT `tabm_descuentoempl_tabt_salarioneto_fk` FOREIGN KEY (`cod_descempl`) REFERENCES `tabm_ctdescuentoempl` (`cod_descempl`);

--
-- Constraints for table `tabt_feambcatprod`
--
ALTER TABLE `tabt_feambcatprod`
  ADD CONSTRAINT `tabm_FEcatprod_tabt_FEambcatprod_fk` FOREIGN KEY (`cod_catprod`) REFERENCES `tabm_fecatprod` (`cod_catprod`),
  ADD CONSTRAINT `tabm_FEambiente_tabt_FEambcatprod_fk` FOREIGN KEY (`cod_amb`) REFERENCES `tabm_feambiente` (`cod_amb`);

--
-- Constraints for table `tabt_feddocumentos`
--
ALTER TABLE `tabt_feddocumentos`
  ADD CONSTRAINT `cata_producto_tabt_kardex_fk` FOREIGN KEY (`cod_catprod`) REFERENCES `tabm_fecatprod` (`cod_catprod`),
  ADD CONSTRAINT `tabm_bodega_tabt_ddocumentos_fk` FOREIGN KEY (`cod_bga`) REFERENCES `tabm_febodega` (`cod_bga`),
  ADD CONSTRAINT `tabm_serie_tabt_ddocumentos_fk` FOREIGN KEY (`cod_srie`) REFERENCES `tabm_feserie` (`cod_srie`),
  ADD CONSTRAINT `tabt_inven_tabt_kardex_fk` FOREIGN KEY (`cod_docs`) REFERENCES `tabm_fedocumentos` (`cod_docs`);

--
-- Constraints for table `tabt_fedrsva`
--
ALTER TABLE `tabt_fedrsva`
  ADD CONSTRAINT `Reservacion_Dett_Reservacion_fk` FOREIGN KEY (`cod_rsva`) REFERENCES `tabm_fereservacion` (`cod_rsva`),
  ADD CONSTRAINT `Habitacion_Dett_Reservacion_fk` FOREIGN KEY (`cod_amb`) REFERENCES `tabm_feambiente` (`cod_amb`);

--
-- Constraints for table `tabt_feexistencias`
--
ALTER TABLE `tabt_feexistencias`
  ADD CONSTRAINT `tabm_catprod_tabt_existencias_fk` FOREIGN KEY (`cod_catprod`) REFERENCES `tabm_fecatprod` (`cod_catprod`),
  ADD CONSTRAINT `tabm_bodega_tabt_existencias_fk` FOREIGN KEY (`cod_bga`) REFERENCES `tabm_febodega` (`cod_bga`);

--
-- Constraints for table `tabt_fefraim`
--
ALTER TABLE `tabt_fefraim`
  ADD CONSTRAINT `tabm_FEfactura_tabt_FEfraim_fk` FOREIGN KEY (`cod_fra`, `cod_srie`, `cod_suc`) REFERENCES `tabm_fefactura` (`cod_fra`, `cod_srie`, `cod_suc`),
  ADD CONSTRAINT `tabm_FEimpuesto_tabt_FEfraim_fk` FOREIGN KEY (`cod_imp`) REFERENCES `tabm_feimpuesto` (`cod_imp`);

--
-- Constraints for table `tabt_feservflocte`
--
ALTER TABLE `tabt_feservflocte`
  ADD CONSTRAINT `tabm_FEfoliocliente_tabt_servflocte_fk` FOREIGN KEY (`cod_flocte`) REFERENCES `tabm_fefoliocliente` (`cod_flocte`),
  ADD CONSTRAINT `tabm_servicio_tabt_servflocte_fk` FOREIGN KEY (`cod_serv`) REFERENCES `tabm_feservicio` (`cod_serv`);

--
-- Constraints for table `tabt_nndnomina`
--
ALTER TABLE `tabt_nndnomina`
  ADD CONSTRAINT `tabm_NNnomina_tabm_NNdnomina_fk` FOREIGN KEY (`cod_nomi`) REFERENCES `tabm_nnnomina` (`cod_nomi`),
  ADD CONSTRAINT `tabm_NNempleado_tabm_NNdnomina_fk` FOREIGN KEY (`cod_emp`) REFERENCES `tabm_nnempleado` (`cod_emp`),
  ADD CONSTRAINT `tabm_NNtransaccion_tabm_NNdnomina_fk` FOREIGN KEY (`cod_trans`) REFERENCES `tabm_nntransaccion` (`cod_trans`);

--
-- Constraints for table `tabt_sgasignapppersonal`
--
ALTER TABLE `tabt_sgasignapppersonal`
  ADD CONSTRAINT `tabm_SGusuario_tabt_SGasignapppersonal_fk` FOREIGN KEY (`cod_usr`) REFERENCES `tabm_sgusuario` (`cod_usr`),
  ADD CONSTRAINT `tabm_aplicacion_tabt_asignapppersonal_fk` FOREIGN KEY (`cod_app`) REFERENCES `tabm_sgaplicacion` (`cod_app`);

--
-- Constraints for table `tabt_sgperfilapp`
--
ALTER TABLE `tabt_sgperfilapp`
  ADD CONSTRAINT `tabm_aplicacion_tabt_perfilapp_fk` FOREIGN KEY (`cod_app`) REFERENCES `tabm_sgaplicacion` (`cod_app`),
  ADD CONSTRAINT `tabm_perfil_tabt_perfilapp_fk` FOREIGN KEY (`Id_perfil`) REFERENCES `tabm_sgperfil` (`cod_pfll`);

--
-- Constraints for table `tabt_sgperfiusuario`
--
ALTER TABLE `tabt_sgperfiusuario`
  ADD CONSTRAINT `tabm_usuario_tabt_perfiusuario_fk` FOREIGN KEY (`cod_usr`) REFERENCES `tabm_sgusuario` (`cod_usr`),
  ADD CONSTRAINT `tabm_perfil_tabt_perfiusuario_fk` FOREIGN KEY (`cod_pfll`) REFERENCES `tabm_sgperfil` (`cod_pfll`);

--
-- Constraints for table `tabt_sgsesion`
--
ALTER TABLE `tabt_sgsesion`
  ADD CONSTRAINT `tabm_SGusuario_tabt_sesion_fk` FOREIGN KEY (`cod_usr`) REFERENCES `tabm_sgusuario` (`cod_usr`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
