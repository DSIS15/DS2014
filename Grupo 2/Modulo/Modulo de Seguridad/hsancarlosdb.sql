-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-11-2014 a las 23:31:56
-- Versión del servidor: 5.6.20
-- Versión de PHP: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `hsancarlosdb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_bccuentabanco`
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
  `estado_ctabco` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_bcprestamo`
--

CREATE TABLE IF NOT EXISTS `tabm_bcprestamo` (
  `codprem_prem` decimal(4,0) NOT NULL,
  `fechcreac_prem` date NOT NULL,
  `intr_prem` float NOT NULL,
  `cant_prem` float NOT NULL,
  `estado_prem` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_cccpcaja`
--

CREATE TABLE IF NOT EXISTS `tabm_cccpcaja` (
  `cod_caja` decimal(4,0) NOT NULL,
  `cod_tpago` decimal(4,0) NOT NULL,
  `cant_caja` float NOT NULL,
  `docpago_caja` varchar(25) NOT NULL,
  `estado_caja` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_cccpttrans`
--

CREATE TABLE IF NOT EXISTS `tabm_cccpttrans` (
  `cod_ttrans` decimal(4,0) NOT NULL,
  `descrip_ttrans` varchar(25) NOT NULL,
  `CA_ttrans` decimal(1,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_cctranscc`
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
  `saldoact_transcc` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_cpcompras`
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
  `estado_compra` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_cpproveedor`
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
  `estado_prov` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_cptpago`
--

CREATE TABLE IF NOT EXISTS `tabm_cptpago` (
  `cod_tpago` decimal(4,0) NOT NULL,
  `tipo_tpago` varchar(25) NOT NULL,
  `estado_tpago` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_cptpago`
--

INSERT INTO `tabm_cptpago` (`cod_tpago`, `tipo_tpago`, `estado_tpago`) VALUES
('1', 'Cheque', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_cptranscp`
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
  `saldoact_transcp` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_ctcompconta`
--

CREATE TABLE IF NOT EXISTS `tabm_ctcompconta` (
  `cod_compconta` decimal(4,0) NOT NULL,
  `codtipodoc_compcont` decimal(2,0) NOT NULL,
  `serie_compcont` varchar(2) NOT NULL,
  `fech_compconta` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_ctctacont`
--

CREATE TABLE IF NOT EXISTS `tabm_ctctacont` (
  `cod_ctacont` decimal(10,0) NOT NULL,
  `nom_ctacont` varchar(50) NOT NULL,
  `fechcreado_ctacont` date NOT NULL,
  `fechmod_ctacont` date NOT NULL,
  `pertenece_ctacont` decimal(10,0) NOT NULL,
  `pertn_ctacont` decimal(10,0) NOT NULL,
  `estado_ctacont` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_ctdescuentoempl`
--

CREATE TABLE IF NOT EXISTS `tabm_ctdescuentoempl` (
  `cod_descempl` decimal(4,0) NOT NULL,
  `tipo_desc` varchar(25) NOT NULL,
  `poc_desc` float NOT NULL,
  `estado_desc` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_ctdiario`
--

CREATE TABLE IF NOT EXISTS `tabm_ctdiario` (
  `codpartd_dro` decimal(10,0) NOT NULL,
  `fechcreado_dro` date NOT NULL,
  `cod_compconta` decimal(4,0) NOT NULL,
  `concp_dro` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_ctdoccomp`
--

CREATE TABLE IF NOT EXISTS `tabm_ctdoccomp` (
  `codtipodoc_compcont` decimal(2,0) NOT NULL,
  `nom_tipocomp` varchar(50) NOT NULL,
  `fechcreado_tipocomp` date NOT NULL,
  `estado_doccomp` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_ctinventario`
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
  `estado_inv` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_feambiente`
--

CREATE TABLE IF NOT EXISTS `tabm_feambiente` (
  `cod_amb` decimal(4,0) NOT NULL,
  `cod_tamb` decimal(4,0) NOT NULL,
  `precio_amb` decimal(10,0) NOT NULL,
  `disponibilidad_amb` tinyint(1) NOT NULL,
  `estado_amb` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_febodega`
--

CREATE TABLE IF NOT EXISTS `tabm_febodega` (
  `cod_bga` decimal(4,0) NOT NULL,
  `cod_suc` decimal(4,0) NOT NULL,
  `descrip_bga` varchar(25) NOT NULL,
  `dire_bga` varchar(25) NOT NULL,
  `estado_bga` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_fecatprod`
--

CREATE TABLE IF NOT EXISTS `tabm_fecatprod` (
  `cod_catprod` decimal(4,0) NOT NULL,
  `nom_catprod` varchar(25) NOT NULL,
  `precioc_catprod` float NOT NULL,
  `preciov_catprod` float NOT NULL,
  `cmax_catprod` float NOT NULL,
  `cmin_catprod` float NOT NULL,
  `ctotal_catprod` float NOT NULL,
  `estado_catprod` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_fecliente`
--

CREATE TABLE IF NOT EXISTS `tabm_fecliente` (
  `cod_cte` decimal(4,0) NOT NULL,
  `doc_cte` varchar(25) NOT NULL,
  `numdoc_cte` varchar(25) NOT NULL,
  `nom1_cte` varchar(25) NOT NULL,
  `nom2_cte` varchar(25) NOT NULL,
  `apell1_cte` varchar(25) NOT NULL,
  `apell2_cte` varchar(25) NOT NULL,
  `tel_cte` varchar(25) NOT NULL,
  `credito_cte` float NOT NULL,
  `cargo_cte` float NOT NULL,
  `abono_cte` float NOT NULL,
  `cargoacum_cte` float NOT NULL,
  `estado_cte` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_fedocumentos`
--

CREATE TABLE IF NOT EXISTS `tabm_fedocumentos` (
  `cod_docs` decimal(4,0) NOT NULL,
  `cod_empsa` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `cod_suc` decimal(4,0) NOT NULL,
  `cod_ttrans` decimal(4,0) NOT NULL,
  `fechent_inv` date NOT NULL,
  `total_docs` float NOT NULL,
  `estado_docs` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_feempresa`
--

CREATE TABLE IF NOT EXISTS `tabm_feempresa` (
  `cod_empsa` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `razsocial_empsa` varchar(50) NOT NULL,
  `nomcomercial_empsa` varchar(50) NOT NULL,
  `dire_empsa` varchar(50) NOT NULL,
  `nit_empsa` decimal(25,0) NOT NULL,
  `estado_empsa` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_feempresa`
--

INSERT INTO `tabm_feempresa` (`cod_empsa`, `cod_srie`, `razsocial_empsa`, `nomcomercial_empsa`, `dire_empsa`, `nit_empsa`, `estado_empsa`) VALUES
('1', '1', 'lucro', 'El Chancro Voraz', 'adasda121e3eddv123', '1324234231', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_fefactura`
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
  `total_fra` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_fefoliocliente`
--

CREATE TABLE IF NOT EXISTS `tabm_fefoliocliente` (
  `cod_flocte` decimal(4,0) NOT NULL,
  `cod_rsva` decimal(4,0) NOT NULL,
  `cod_cte` decimal(4,0) NOT NULL,
  `cod_catprod` decimal(4,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_feimpuesto`
--

CREATE TABLE IF NOT EXISTS `tabm_feimpuesto` (
  `cod_imp` decimal(4,0) NOT NULL,
  `nom_imp` varchar(25) NOT NULL,
  `valor_imp` float NOT NULL,
  `estado_imp` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_fereservacion`
--

CREATE TABLE IF NOT EXISTS `tabm_fereservacion` (
  `cod_rsva` decimal(4,0) NOT NULL,
  `cod_cte` decimal(4,0) NOT NULL,
  `fechres_rsva` date NOT NULL,
  `fechent_rsva` date NOT NULL,
  `fechsal_rsva` date NOT NULL,
  `adultos_rsva` decimal(4,0) NOT NULL,
  `ninos_rsva` decimal(4,0) NOT NULL,
  `dias_rsva` decimal(4,0) NOT NULL,
  `total_rsva` float NOT NULL,
  `confent_rsva` tinyint(1) NOT NULL,
  `confsal_rsva` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_feserie`
--

CREATE TABLE IF NOT EXISTS `tabm_feserie` (
  `cod_srie` decimal(4,0) NOT NULL,
  `serie_srie` varchar(25) NOT NULL,
  `estado_srie` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_feserie`
--

INSERT INTO `tabm_feserie` (`cod_srie`, `serie_srie`, `estado_srie`) VALUES
('1', 'A1231DSAFA123', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_fesucursal`
--

CREATE TABLE IF NOT EXISTS `tabm_fesucursal` (
  `cod_suc` decimal(4,0) NOT NULL,
  `nom_suc` varchar(25) NOT NULL,
  `ubic_suc` varchar(25) NOT NULL,
  `estado_suc` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_fetambiente`
--

CREATE TABLE IF NOT EXISTS `tabm_fetambiente` (
  `cod_tamb` decimal(4,0) NOT NULL,
  `ambiente_tamb` varchar(25) NOT NULL,
  `estado_tamb` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_nndepartamento`
--

CREATE TABLE IF NOT EXISTS `tabm_nndepartamento` (
  `cod_depto` decimal(4,0) NOT NULL,
  `tip_depto` varchar(25) NOT NULL,
  `estado_depto` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_nndepartamento`
--

INSERT INTO `tabm_nndepartamento` (`cod_depto`, `tip_depto`, `estado_depto`) VALUES
('1', 'Contabilidad', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_nnempleado`
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
  `estado_emp` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_nnempleado`
--

INSERT INTO `tabm_nnempleado` (`cod_emp`, `cod_empsa`, `cod_depto`, `cod_pto`, `cod_tpago`, `dpi_emp`, `nit_emp`, `nom1_emp`, `nom2_emp`, `apell1_emp`, `apell2_emp`, `dire_emp`, `afiigss_emp`, `salario_emp`, `estado_emp`) VALUES
('1', '1', '1', '1', '1', '1234242312', '234234QDAS', 'Juan', 'Carlos', 'Perez', 'Sosa', '143242 WQeD SDASD', '1423423412', 90012.4, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_nnnomina`
--

CREATE TABLE IF NOT EXISTS `tabm_nnnomina` (
  `cod_nomi` decimal(4,0) NOT NULL,
  `cod_tnomi` decimal(4,0) NOT NULL,
  `cod_empsa` decimal(4,0) NOT NULL,
  `finicio_nomi` date NOT NULL,
  `ffin_nomi` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_nnpuesto`
--

CREATE TABLE IF NOT EXISTS `tabm_nnpuesto` (
  `cod_pto` decimal(4,0) NOT NULL,
  `tipo_pto` varchar(25) NOT NULL,
  `estado_pto` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_nnpuesto`
--

INSERT INTO `tabm_nnpuesto` (`cod_pto`, `tipo_pto`, `estado_pto`) VALUES
('1', 'Jefe', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_nntnomina`
--

CREATE TABLE IF NOT EXISTS `tabm_nntnomina` (
  `cod_tnomi` decimal(4,0) NOT NULL,
  `tipo_tnomi` varchar(25) NOT NULL,
  `descrip_tnomi` varchar(30) NOT NULL,
  `estado_tnomi` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_nntransaccion`
--

CREATE TABLE IF NOT EXISTS `tabm_nntransaccion` (
  `cod_trans` decimal(4,0) NOT NULL,
  `cod_ctacont` decimal(10,0) NOT NULL,
  `tipo_trans` varchar(25) NOT NULL,
  `valor_trans` float NOT NULL,
  `descrip_trans` varchar(30) NOT NULL,
  `estado_trans` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_sgaplicacion`
--

CREATE TABLE IF NOT EXISTS `tabm_sgaplicacion` (
  `cod_app` decimal(4,0) NOT NULL,
  `nomapp_app` varchar(25) NOT NULL,
  `fechcreado_app` date NOT NULL,
  `fechmodif_app` date NOT NULL,
  `estado_app` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_sgaplicacion`
--

INSERT INTO `tabm_sgaplicacion` (`cod_app`, `nomapp_app`, `fechcreado_app`, `fechmodif_app`, `estado_app`) VALUES
('1', 'wfContabilidad', '2014-10-01', '2014-10-01', 1),
('2', 'wfInventario', '2014-10-01', '2014-10-01', 1),
('3', 'wfCuentaxCobrar', '2014-10-01', '2014-10-01', 0),
('4', 'wfCuentasxPagar', '2014-10-01', '2014-10-01', 1),
('10', 'Nomina', '2014-10-01', '2014-10-01', 0),
('17', 'Toallas', '2014-10-01', '2014-10-01', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_sgperfil`
--

CREATE TABLE IF NOT EXISTS `tabm_sgperfil` (
  `cod_pfll` decimal(4,0) NOT NULL,
  `nom_pfl` varchar(25) NOT NULL,
  `fechcreado_pfl` date NOT NULL,
  `fechmodif_pfl` date NOT NULL,
  `cod_pfll_1` decimal(4,0) DEFAULT NULL,
  `estado_pfl` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_sgperfil`
--

INSERT INTO `tabm_sgperfil` (`cod_pfll`, `nom_pfl`, `fechcreado_pfl`, `fechmodif_pfl`, `cod_pfll_1`, `estado_pfl`) VALUES
('1', 'Global', '2014-10-01', '2014-10-01', NULL, 1),
('11', 'Contabilidad', '2014-10-01', '2014-10-01', '1', 1),
('111', 'Jefe Contabilidad', '2014-10-01', '2014-10-01', '11', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_sgpregunta`
--

CREATE TABLE IF NOT EXISTS `tabm_sgpregunta` (
  `cod_preg` decimal(4,0) NOT NULL,
  `nom_preg` varchar(100) NOT NULL,
  `estado_preg` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_sgpregunta`
--

INSERT INTO `tabm_sgpregunta` (`cod_preg`, `nom_preg`, `estado_preg`) VALUES
('1', 'Nombre de tu Mascota??', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_sgprivilegio`
--

CREATE TABLE IF NOT EXISTS `tabm_sgprivilegio` (
  `cod_priv` decimal(4,0) NOT NULL,
  `nom_priv` varchar(25) NOT NULL,
  `fechcreado_privi` date NOT NULL,
  `fechmodif_privi` date NOT NULL,
  `estado_priv` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_sgprivilegio`
--

INSERT INTO `tabm_sgprivilegio` (`cod_priv`, `nom_priv`, `fechcreado_privi`, `fechmodif_privi`, `estado_priv`) VALUES
('1', 'Administrador Global', '2014-10-01', '2014-10-01', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_sgusuario`
--

CREATE TABLE IF NOT EXISTS `tabm_sgusuario` (
  `cod_usr` decimal(4,0) NOT NULL,
  `cod_emp` decimal(4,0) NOT NULL,
  `cod_priv` decimal(4,0) NOT NULL,
  `cod_preg` decimal(4,0) NOT NULL,
  `cuenta_usr` varchar(25) NOT NULL,
  `resp_usr` varchar(50) NOT NULL,
  `pass_usr` varchar(25) NOT NULL,
  `fechcreado_usr` date NOT NULL,
  `fechmodif_usr` date NOT NULL,
  `host_usr` varchar(50) NOT NULL,
  `ipdir_usr` varchar(16) NOT NULL,
  `correo_usr` varchar(40) NOT NULL,
  `foto_usr` longblob NOT NULL,
  `estado_usr` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_sgusuario`
--

INSERT INTO `tabm_sgusuario` (`cod_usr`, `cod_emp`, `cod_priv`, `cod_preg`, `cuenta_usr`, `resp_usr`, `pass_usr`, `fechcreado_usr`, `fechmodif_usr`, `host_usr`, `ipdir_usr`, `correo_usr`, `foto_usr`, `estado_usr`) VALUES
('1', '1', '1', '1', 'JPerez071', 'Mi Chucho', 'JPerez071', '2014-10-01', '2014-10-01', 'MiniKiraPortatil', '%.%.%.%', 'leolpazos071@hotmail.com', 0xffd8ffe000104a46494600010100000100010000fffe003b43524541544f523a2067642d6a7065672076312e3020287573696e6720494a47204a50454720763632292c207175616c697479203d2039330affdb00430002020202020102020202030202030306040303030307050504060807090808070808090a0d0b090a0c0a08080b0f0b0c0d0e0e0f0e090b1011100e110d0e0e0effdb004301020303030303070404070e0908090e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0e0effc0001108013d00c803012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00fdf518cd2f19c7f4a3bf5e2823bd000071edda8c73476a3b9e680023de8ee7d283db9a3b50007ad271451dfb50004f3d28edc74a5149da80178ee6bce7c6bf16fe1bfc3cbdb5b4f1978c34fd0efee137dbd94b217b891738dc22405cae411bb18e3ad687c48d76e7c2ff00013c65e26b3b886d2e349d1ae2f84b38ca28863690e783d94f63f43d2bf1bb4bfda2bc51e10f883e30f11f87f41b55f19f8aafe4d425f10f8d6233dc5a59945f2ad13688d502e19b6ae4056507ee607958dc63c2a4a31bb7f71f4f9364d88cdeaca34a2da8f6697deddedf737e47ec2f82fe2b7c3af88733c7e0af17e9be239635732c5677019e3d842b865eaa54b2e548046e5c8e457a176afc07fd9cbf6cff0012cbfb7de89aff00c40b6b28742d48cba25fdde98af14318b99d1c5c491b330e241192ea46133c1afdb7bff891a2269cf27876d6fbc7174a711dbf87e24984841c102791d2dd71839df2ae318ebc5561b16aad1f6952d1670e6796e232bc4ba3595bb6b7fc4eb758d4a3d2f466b861ba4791628500cee7760aa3e993927b004f6af36b7b2fb5f8eee6fb5b903da2164b2b67c6d9593efcd27ab67851d14038eb5e59e2ff0010fed0be32fb458783bc1de15f055ac6375bdef8875a9aee7766e00f2ade1f295c0dc72934a077c715f3cf8bbe1c7edd7e209ac0c9f107c0f6f12dd6e923b09ee2de4b5620ed6475b5e4907041c8f9b1c8c93e662ea2c454e58cd28fa9e2357dddbd4fbef44bf8758d0ec2f63dbf6796d92e02e381e60dca3f018a59f5fd315a48a376bb2a4ac82188ba02382a4818cfa8cd7e37f882fbf6c6fd9fbc25ab6a7a1eabac78e3c192215d492f67fed5b7b60a592431491ffa4d984d8eb9dbb1581cae457d37f067f6b1f865f183c016b0e87729e0cf889a4db892f7c297b70a44d028f9fecd20c2cea072318607aa8e6bcf7848c5395eebcbf50953adcb7a694add57f91f73d8eb96124a52190bd83388d91c157b573d010dc853dbd3208ca9e32af6d67f0f6a46fb47473116324d610e30e4f2d2420f0ae792c9f75ce7a31dd5cba34435659d50359de4680a30e8b2e540e3ae24c230e9fbc0dc61b76a68dab49acd8df689712b2ea9693b470cc4f25c28914fbee46527b6edc2b8945c25cd1e8717b69b56ea7a9e81af59ebda345716d2ac84a063804641ef83823904104020820f22b78f18af11b799ecef575ad33105c994adedae709e6f018fb06e013ea509c7de5f5ed2f52b7d57458af6d98ec7c828df79181c3291ea0e457dae16b7b6a7aee75539aa91ba2ff722971467f2a3debb8d408e3ffad45145002e693de8ee451cff009140076a33476ffeb51dff00fad400739a3b5140fbb9fe940051fc209341ff003c51f8fe940099c0e297b51dbffad47f4f6a00f96bf6c7f1be99e09fd82fc5b26a39965d61a2d2acedb3c5c3cadb991bfd8f29252ffec86afc15f1627c41f8d7a0da4b06afa8f88b5dbeb8fb3e89a559444dd5fbf418451954e3807a01b98f61fa85fb67f8e2c3c69fb53e89f0534e56d5b5dd3b459aee1d3e2c126f6e1a08615c7f79927017d016f5afa17f653fd96fc3dfb3e7c23b39750f2b5cf895796aa359d659772c39009b6b7cfdc894f04f05c8cb71b557c6c5ce9d397b496ad6c8fa6c3e3ebe0f00f0f4df2f3bbbb6efb6bdbcba9f1d7eceff00f04d6fb07c374bef8e9aa9b5d5aee75b83a1787eeb2605d98314f39dcac49c122251839c48c2bf55dec2d74ed2961b6b7778628c28512e00551803920600adf69d0b944705bd076ac4d4f4b835487ecf74f2792cc0ba2cccab200795600e0a9e841e0826be62b5695477678788c455af18c6a49cadb5f5b1534c5bc76fb5dd5ba25d36447fbcdfe5a6781d00048c6719e7b900569a453a45282448cefb893df9cfff005a912da0b18435b5b0441f78403181f41d6ae5bcf1cf6e248e459636270cbea38c1f7cd72dd9c2a173cfe286083c76b6e00b0df3cb3496f2201e6a480972bd8fef363e46704b67ef57967c4af81bf0d3e2add5ad8f8bfc2764f792d9f9da3eb9689f67d474fb94cf98b15c200e9c15603254957dcac3e53f45ea5a6d96a7a79b7bd844899dc8e09568cf6656182ac3d4106be4df8f3f1a47ece5e01d3f5ef17f853c45e2cf09c7764c7afe850dbca6d2467cac7748f247e5efcec591728dd0ed2403d149ce734a0f525c6749a6b7e9dcf27b0f1e78d7e0a7c56d17c03f1b7588f5df87fa8c17163e10f892c045be5930d1596a8abf24738dadb67184902e7821c8f42f167c4a6f07fed2d776a744bdbeb7bcb48e4d3a6b18f7832c05a53e674d91b89b6ef24afeeb19eb8fcbdf1b7eda937c61d72e744d73c13a9697e027b93711d921f33c8c4ab20964280ee70caae378d8ad82172a18dd8ff6a2f1b7c28d463d5bc19f12754d5f48953e7b2d635037f098fd1449bb6fd57078e3a9adf11ed69c6dcb66fee67dee5fc235732c33c546b41cd2bb827afcdad9fe1e67d5ff00113f6c5f18f817f68bbdf0c78e7e1b45f0e6d668c4ceb7974b7ad71110424b1c8a446eadf30c8c8e581e460617c34ff828d68fa4fc47b9b2f12d8dadde9574ea1fec976167c8e3cc1bbe5772319076eec039ce49db5f09782bf6c1d7fe166a7e3ff0cf88bc65fd91a1cd7d3ea5696b359e9935c5e4514ed6ad708388e0f2bc955f315cc8cce723ef73ff00b417ec2df0aacbe085df8a3e1ce993e95158db99eeec64bc92646836975963690b3ab800820b60ed380a68c2d59c529a6e2fb69fd33b70789c82538e06b61a319bd39bdedf6def75afaa5d743f593c0be3df0c7c48f86ba778b7c1faac5abe897ab98e58f828c3ef23a9e5581e0835d9f6afc52ff826378b35fd13e23f8e7e174fabfda2cbcd6b8b7b7b805b7f978cb03fc2761504f2091d3a11fb5a3a7ff5abec70f57db52523e5735c03cbb192a3d3757decff00cb60e878a28a2ba8f14439cf14bc703b51dfb527e22801dda90fbd1dba8a307d45001d851452f6a004a419ef4bdfb51dfb5001da9acc16366242803249ed4fe31e95e05fb507c445f855fb067c4bf1c6fd935969462b720f3e6ceeb0263df7480fe149e834aeec7c8bf013c1ba4fc4dff82a5fc78fda35d45d69b65e206f0e785598ee56961b4b78af2e07fbab1aa2f60d2c9dc0afb93c73acea96ba75b683e1eb84b2d66fd1ddefe488489a6db263cdb92a786619554539cbb2e4150d8f9fbf62ff000b4fe1bfd84be1825ea6dbe9fc3c9acea2ec30cf77a93b5f4a5bd4859635c9f4c76af75b7962d4a6d3b519086935fd454464f6b6803cb1a8f63b0b1f795abe32bcdcea37e66d56a3a93d7a68bd11a9e15d0d749b7315b79ab628b80d732192e2e64fe39a67392cc4f1d7b7b8027b59ae6f3c73693f9ac9642deea26887dd771322a37e0237c7fbc6ba988e7803007000ac8b758ecf4fb06c63cb45ddedbba9fcc9af356ba98d959189e27b1f11f9697fe16d456df59b5f9c58de1cd9ea283ac32705a324676ca9cab60b09141468b4fd45b53d16dfc4fa2dbcd11906dd4b4b9d42caaea76ba3004812a10578241db8ce36b0ed2f2033da131b6d993946f435c235fa697e288b55da21b5be9d6d3558f3811ce70914bff02f963f53ba3e983556f750a4f92563b086f219ad619a37f320994344fd320d70bae45e1bf12e8daff82bc4d630ea7a15ec6d677f637880a1495490ac3fb8eb92ac3bab2e415c574d2446def2eed106d8a64371063b3e7e71f8920fd49ae17555b49af2db5996267610bd86a6b19c334208911f8fe243f3af705db1d6a69c7deb9c939eb667e1f7c5bf8290feccbfb4ddc78724bb71e15bf46bbf0c6a170df34f6dbb0d0b3746922242b7a82ad801c0af91af6c7c33aefed37a268d6a246b6d4b558a2fb3da0dcb23cae100083bee60703a8cd7ee9fed65f0a47c6dfd8abc65e156896e7e21f82506b3e1eb98c7cf7716c661b3fd99a34962db9c7991a939da2bf167e0afc2ad5bc49fb41fc10bdd2b548d27d6fc5a96aa42106c2486447dc4e7e6250ee1feefbd7d552ab1ad46d3dcfb0ca278ca94a75a83b4a92bbf4d17ddaea7edd7ec5be2c84e9ff11fe12dde8d6ba0eb5e06d7e7b2961b427cabbb79a5926b79c6ee77796c8a7d829e37607b2fc539acb4efd9a7e280d41825a59e8b78ec33cb472a3e07b9130381fdd38ef5f1f7c38f11d8f83bfe0e1df8b9e1312f950f88f43d3da100fc8d345a7c2641f560919ff801ab1ff0517f89f27843e0d2782748b931eb1e215325caa373f66dcbb41faca81be9130ef5e3d7837539975499e46070f571d99535fccf99fa6f27f833e62ff827b5d5c49fb7c6bfe2386179ec2d74cb99aeb60276c6f2244adfa83fe723f7da19a2b8b68e685c4913a06475390c0f208afc90ff008268781bfe11bf837af78f356b34365e28bb3a45ac920e563840ea3babbb15faad7e9ce85349a278a2e3c3974ed25bb9f36c24639ca9c9db9fc1bf1563c06515efe0ad0a2b5dd9ed710e296273595beca4be7bbfcceef2320514dea41cd15ea9f2e29193d39a5ef4d041e9fca94f5e9fa5000339ef4633d68e868f4ff0a003b5283dbbd271fe4503d7fa50018e72052f7a4fd0fd297fcf4a002bf3dbfe0a5779abc1fb00e9561a72466cb53f1859d96a4f21fbb13c536d38ff00ae8233f857e847f3afcf0ff828178cf4a7f81ba6fc2f9eda39ef751bfb2d4da5924c790b0dda1500772c55873d07639e30ab38d387349d8edc2e1eb626b72528dda4dfc92bb7f247d60f691785bf679d46d6c57eced6f61f64b60831b4a4620880fa6d51f857243c43636ffb4ef803c0025517ba66906e245cfde2f04a83f11e59ff00bec7ad77be3cb9b6d3be19bcd72c12d96ee2793270302504d7c51aedc4d63ff055eb9f16bcd2c56169298667c9da9084b28d9be9b9661ff0235f1b4ed34dbf339a309ca4edd353efad36fa1960800901792e2e23520ff14723023ea307f235cfdf8693c57736124c50dfe96b1db2f60f13c8588ffbed3f215c69d7adf45b9d50cc3f75a3f8ea2b7909e36adf47190e7fd90d7b927fd93e957be24de7f629d1b5e321823b6b9920b8981c7930b6c9e57cfb47038fc6b2507cc9773194ad0febc8f4db1ba69f49b69e4f96564c4aa3f85c70c3f039ae1bc6d691c1a7dc5f48a5b4db988db6a4aad82a8dc0941ec549e4f1852c7b0acaf86de29bef177c14b4d5278d2c7c4243dbea76e46160d42025265c0e88cea5877dadd8d7669756dae785184916619a3649a09002548255e36ed956054fd2b1bb84acfa19d597bba991e1dd55f59f86da76a13b892face4305db85c0674631bb01d95b1b87b1158d33083c6f3d8bffab9d526897b6e0fe5b1fae258ff002af3cf8597b7ba47c71f889f0eb52904b12dbc1a9e9b2bb65ee2370d0bb649c9c08e1cb7f79980e95d4f8a6ecdb6a7a25fae0cb24171011df22179323dc34495b72f2d471fbbf33ce9cd4acd987697525978d758b0b95d9a87874a9b79071e7e91727393dbf71345228ebb5231de435f85d716bab7c25ff828cebbe06d32ec69b6da2fc55173a13a4be4bdbc6d72a91f96a0fce4c2e8083f2e3a83915fbb5f11b53b0f0afc4af09f89aed54e9f793c7a5de61722586ee448be6ff611b64873db3ef5f81ffb66cfa8f857fe0a39f14561924b4d5ecae6ca7b5d4d415b9575b1b7d9286cf7da24c8fe263f87ab834a7f3fd0fa5c9711ec275a3276e68b5e4fc99ef7e01f19c7e3eff82e1f81fc65a55c1b81ad788996170bcc96f0583465fe8cb017ff008153bf69f5d6be377edefaf5b68e4ea09fdb30f87b4688728191bcae0fa160cfff006d0d78afec5133687f177c5bf17754b9171a77827c0d7baa59099769fb6164b48a303a7cdf687c1f7c7719fb1ff61ad1a5f13fc7dd3eff0050884e34c865d5679e4192f3487118fa8dc1bfed9d2c6c65ed21189f75c3d1a382a58ac7d45a53a7cabd5ff4bef3f457c1fe06d37e1b7863c2fe0ad2d33a1c1a345a535be30277881659076123319589ee4e0f623d1ef675bff0dc6f3ce5350d332ff6803e778011ba4e79dd1908e4633ba30081bb149e31b08a68ec24909444b80de629c3478e5981ff007378c77071deaf5ad84dad6973ca856db5eb29cc17c8784964551873c7059194e7182ad8208c63be82728371f9ff005dcfcc2329ce4e53d5dd9dae917c751d0e3964411dca1315c460f09229c301ed91907b820f7a2b82f08de4fa7eaf1e9f7eaf04d366d26465e45c42bf213827264836b6738c4639e68af528cdce177b9b277573d3c000d1dc6297fcf5a3b56e3019a3b7b5147e7f9d001c520ea334bf851cd0007a518a5a3fcf5a00683c735f8cbfb71e8a9e23ff00829f7c35d135ad4a4d3b41bcd3e7b7593cc288277b390da96208f945c2ab11dc039afd9b3835f9a5ff000500f0c6a56965e1af887e1ebf9349d760b67b38af2dc812c6430e848ee92ca33d457978f4feaee4ba7fc31f55c3f1f6b8e7413b3a9094574d6d75f7dac7b3fed57e2bfecbfd8ca2bf4b896c6d355905bcb7b1c0d2fd9125b790aca428270adb4938c000938009ae1354d2b44f1778bffe128d0b568ee6d35fb29268b2c5a09d2e92dee6168dbe9b8e14e79ce0f43b77baa43e2cff00825d7c36f116a4cb76d61a769f3ea5e68cac8d06db6b8dc0f51bb7e45799f8afe0af86ac342f0e8b1bc9fe1df8c21b59b46d2f54d36711c6ca26125a078d8ecb985155905b49b95565000c2330f9dc3c613828b972bd75e878f152c2bab52a46fc974d2dfe5fe47addf5bea7e2af086bfa2decc6db53f157840d85cc8a7fd56a963bc1901c70648e51202402042320118ae9359d5d3e29fec0577a9ddae6f6e34059755b74186de899b8450391e647e605efb5d7d6bcd7c22fe364b0b9b1f13dba4be2df0edc41742f2d78835440195645dcc59720491b2392c067961b1ab7341be9bc1daa5f5f69d134be196d4c8d42cfcbc18ede73b95c2f6d81821eb936eaa30326a25783b3dd339d61bdb52f6947de8c95d3efdd7af97911fc30f10def87a4b9999a4beb0b8659ef907ccd2f983cc370b81f7cc8657c0ce55b1c90b8f7ab4d62da5be4d4ac2547d37527026da7fd5dc60056e38c380abc704ec2321b27c9b41f087f656970d9692b13d869c0dbda949f0d2dafde8403b48f950a8079ce0fad6478ba3d73c09a7cbe22d12daf35cf0f382758d25192494c44e5de1c2261d72580ee7238de1e3e794a1527e67463306ead28ce845bd3faf99d05bc705bfedd3a0dcb4be56a29a6dcdac5938171637404a41f568ae2d140e3e559d7bb5763e278f6eafe18180ca35f68197d43c720c57965f5ddbeb3f113e1878cad7503733dbeab1d93ddc48144b6f72d19638c71b9a381c8fe1276f0735eefaa69e2e6fed3713fb8d5d6e013fecf5fd09ade5eeca2fc8f8cb3714bb3ff0023cbbe2ad88d6fe177866d6562b3cda03889b3ff002d9e21e59faef031f5afc85ff8290f87753bbf8fdf0a7c4767a53de6b5e34f09ff0067dfc31261e4beb19b64e401dc078d7e8b5fae1f12ee961f0dfc1bb567f25afb55d1ed064e0b032a33affdf08d5f33fc46d3fc17f12be28f84b5ef176a131d27c0ff001435ed323b5b2b632dd6a62458256b3842f3b9cca7a72421039208efc1c94211949d96a7b541b589d36ff863f3fedbc0da87c2ff00f8255eabaeeb51fd8758f1cf8834fd2f4cb439578b4d8a36be924ed912c915a9ee36842386c9fd28fd827c3d0e9ffb3cff00c258502cdaeeb4d6b0be3ac36d09c63feda3ca3f015f9d7fb697c73d07e30fc46f0df87bc1d76be1bb6f0e09d754d3b5c4fb2dcade958a165f2537ec0896ea006c10491818afd11fd88fe287c3ed4ff668f849f0bf4bf1142fe31d123ba9754b2914a192491a7958c6c461c0f331c73853c62b7ab38d4a8a7e47e838b862a9e4128c69b5cf24ddb5b456d7fb96e7de5e2b8527f0e88d86435e47193e81f087ff0042c7e35b1a2db3cba9da6bf0b0f2b51d2a2fb58cf575c346c07b891c13d70a9e959fe202b2785ee00e48be800c7af9e805743e1edbff00082e93b794fb226dfa6d18fd2bab01d51f0315ef338cf10ab69fe34bebc406341041a8829f799a172b3e3dcc3b57f1a2a6f1b34435bd3207241b9d3afe1ebc0531a313f5f947eb45554aae956925d4a4d5da3d18f27038a5ed49d0e696bd8283b7ff005a93fcf4a33ce3a1a3340076a07d29693b9a003b74a5a4cf155ef2ea1b2d2ee2f2e64115b4113492b9e8aaa324fe4280393f1cf8f3c3fe00f092eabae4aef2cf30b7d3ec2d577dd5fce412b0c2991b9880492485550598aaa961f8a3fb5d7c67f8ebf173f68397e1169169a5e81a1696cb7724160e26fb3a943fbdbbbc60028009e1154761bc804f937c5bfdaa3e207c62fdb6351d57405ba8f452b2d8f85b4cdb9fb1d9a1cc970e0725df6ef6e7aed5c90aa6b81f10fc4b363f0475dd2f55f0d5dc11ea8de43ea9737644e9363225940fbee782324aa800280066b9a52e676e87d56072daf34ea53bde3ab6becaefa1fa59f012cadb55ff00826a78c3e0e0f1643e2fd674eb7bb8269e1b98d8c63508e59610555898f3748eaa1f0dca9e841afaf3c2173a17c50fd9db48975dd3ecfc41617b6a22d46d2f6d9668259a26d92828c082048848c8e9835f881fb1cfc485f0bfed1f2583eb5a4787a2f166963c3fa646164dd75a90904d61772aee2155674542c70a448c2bf47fe0e7c52d2bc31fb5bb7836ea46d33c29f13b4d8fc41e108ee582fd8b518105adf6967d2445861caf0048928ead5f318cc33bbb69d57ea79959c30b8f953a73e78cbadad77e8cfb0cf87b47d234c96df48d2ed74e8593263b685635e07a01e83f4ac1b4d06da6d4a79fcb052ea0f26e571f2c8a3ee93ee3247e27daba7d79b513a7c0fa6c2b7327da2313c6d26c2622db5c83eaa0eec77db8ef57ace1f2acd548c1ef8af9eb4937a9f474ab7261edd4f02f1bf87fe2d69f7b630fc37d6fc35a3e8a6265bf97c43637170ebf302be518a7876000b9259ba9eddbcf1348fda3534895a7d47c17e21bdb5790ded844faad8848b398a412b5ecc8eae841cf96406575e4a9afb30aa32e1941cfad79bcdf0a3c0cde245d5ed7477d2efc4ad29974cbfb8b3de5b05b7085d4303819041071c8af4e8e229d38355209f9dbfe0afccf13151c4578db0f51d377e96fd533e20d57c7bf133c0be37f0c36a3f0cc6a3a7ea9a85a89ad7c3de204bf5b431dd47891f7dbc1f6746e7ef12ac40c30f98d7e8f6b12cb1780f58d47c936d751e9f3cc237604c6db18e09048c823b1af15f1af857c3765a5ee86c95afef2e61b6592572e50348b9da18e013819239621724e057afeb97b15c5bea5a7ab9006a36b63281fc5bda39641ff007ea424fb668ab5e9e21c7921cb6f5fd4f031b84ab86519d69f3ce5ab76b7e08f893f6c2f1f47e0ff008e3fb3e6816f2857b2bbd67c444e7829a568d3346a7d374b22e3d4ad7c5561e21f1bdcfec597fe20b1d52ebc25ae8f8e535e437ba7ce56eae21bad310384383f3b8711e304e5ba5761fb4c2eb3f1bff6fdf14687e0c79353d474ed3adfc2f642c164696d5a6945d5e498da43308d678c88c39c1c36074faa7e0efc10d3fe197c16bb7f8a0b1dddf68777a86bb6d12cc1e2b47fb1c318771d04a91d9cc546e60a59b924023d974e30c2ae6ea74e0650a3efd45cd7e9fd7c8fc67f8c1e02bad47fe0a21e36f095aea97773a85beaa9a735d4b2b4f7334ca151bcd772ccce18943cff00060600007b1fc6cf855e22fd883f6f5f073e81e2abbf14f82f53856fb4cbbbb4115d5aba380f13b271bd72ac1d42821bee822ac7ecb3e11d73e2cffc140b52f125c1136b175ab5c6af34f2292be72f9976ee477cb8031df763bd7d51ff000533fb26b1e11f853a8ac61a479cbab9ea3f76c1d71ec40cfbd66ace2e3bc568be563f439cab6071d84c3c1d9b8de4ba3d5ad57c9fc99fa7fe02f1947e38fd93fc39e3794aa8d4e3b7ba9b9c00c8ebe6e3d83239fc2bda343b6365e0bd26d1c6c3059c48c3d0aa015f1cfeca024baff825afc29b79c893ed303c393d924b992227f0de4fe15f5aea9aa5e3892c343b57bbbdfbaf3636c3067b963c123fba324771ebe8e06fcae4cfcff1b4a14319569c368c9a5e89b38dd5e47d7fe34436900f36cb4db7781981e934d80c41e9f2c7bf39ef8145763e1ef0e43a25b348ec2e2fe5c99a63ea7938fae064f53819e8002bb9528c9b9496ace04bab3a7ef487a52f7149daba8b14f51483a01477f5fc28c81ffeaa005a39fad1fc3498a003b8af977f6c7f1eb7c3bff827e78e7568ae0dadc5e40ba7412ab6191e73b030fa67f2cd7d45dc7f857c1fff000501f0add78cff00654f0ae811ca89673f8ae137aa5c02d1a41348001d4e5d154e3fbd532d8e8a10f695a30eecfc50d57c27aafc3ab1d2fc5f77a8ff00644dab69be658451c4d21fbbba28182f4dfd0e72031e78c11e15aeddebdf10fc7c6da38b6c917c975285cac4dd0aa8f5eb9f7cfbe3e8cf887e30bfb1d065f0b6a11cd7faed948d63a235cedc4320189ae41feec51e0296e433a9390ad9e13c17e2fd07e1ef86da1b5d0db52f14e4f913ccb9863e7efe0e093d0f3edd315c8db8ae649bbf43f4b9fd5675960675a14a10bf354576e5d6c9757db45e67a47857f674b6b4f86d06bfac5fdaf8374f42243ac6af7a2d8961c8310e5ddf80460053d9c9af61f12c7a57c5cb4d262f0978a6e75ad5adfc46ba85b5edb1164b61acb8892765623312ddca61bbfbd8f3239f6602c8d5f1e6b7e2f93c4faa49a8f8abc4173753af091ab9c47ecb8e07e181f5eb5a5f03efb4ebdfda20f866fb589345d3bc4d0b585a6a17186582f0f36aec48240327eec904604a49e0107a2a45548c5a566bf13e63158bca53f6185a5eedfe395f9addd24ecbbf5fccfdaafd9f3f68cbff001c59ff00c2b7f880cba37c50b7b269f4bba9142a7882cd4b22dd46a400b27c84bc78191f3a8c6e54fa4f4bf12ebb1ea4b65abe925c1e3ed702b20cfbab640fa873f4afcbfd32d6c7e2adf58dcafda3c2de31d3ee67d7ddec642b79a3d8699bacf4fb746ea1a478d81fef130120eee7eaabdfda0b48f0868d7be1cf8a52cd078f743db6da91d1ac1e7b7bf98229678768c2f2482ac54020e0e2be3f1383a8a5cf4a374dedd8f66a2c161a51a726ad25757dd74dfd53b775af53eca5ba52373300bf5ae73c53e38f0cf83fc2975acf8935ab3d174b81732dcddceb122fe2c40afca2f88bfb74fc406d620f0f7c35f017f63bddc7218353f1166498aa8c9296e842838e413230f6af8c3584f8a5f183c650eabf12bc657d7aaf27960dc4984b57c331f2e25c220d887ee819cf350b2faaecaabe55f899e1b0bf5a937865cf6766f68aebabf93e9d0fbdbc5dfb5bc7f15bf6e7f845f0e3e1caca9e17b9f1ce951ea5ac4b1156bb45bc89da3894f2b190b82cd82dc8c05e5bea6f8edf1b2c3e167ecdde29f88332092f6f3c41a92e9d6b9e6ee684b69b1283db7470b383fecf7afc87f8296b6fe0afdacbc1de23bc8cdd47a15c9d5bca46e667b5b69e71181fde69200a07a91eb5de7ed8fe3cd4b58f8e1e12f868eb2ffc23be0ed3ed6c249ca111dfdea460dd4b9e8fb66322679e54f3c9af5bea74a35a14e3b25f79f158ba789c5e21c26be07adb6493b7e7a167f65cf12780b57f8eb7b7dfb416b4347bc920bbd4edf539ef459acb7923a96dee0637138c727827918c57e81fed07f19fe0ab7ec0fe2dd3fe1cf8ee1f11f894e9a34e8a089ee19ae5262b0cb247bd42b1085c9619caefeb9cd7e45bd8e9fad4daff0096f0add47a4471c4f200424921ddc7a7ddeb54edb4bd4753f1cf81741b9f11ea2fa6ddea16b6b710df6a46e2205e6456651801060918e4f3d6bd6ab18cfdc6b467b386c042309577357859a5aebafa7f91fa43ff0004cbf0b413fc47f16788e45e60d25d151873ba695573f82c2c3fe075e57ff051af142ea7f19bc07f0eb4ad935ce8da721bdf2f19fb6dc6d4d8de842c68dff6d6be76d2ff00697d7fe07f8d75cb9f875e249f41f16ff68ac3aa599b78a6b09d5109791a164c6e24edc8218f1ce79ad9fd9efc5117ed2bff000538f0adf78deea06d4751f1249a9eab94f2e394a069d511189c23145882e491b947bd7995684e9505cbad9bbfa33dca398e17179b4b1b897c9cb0f756f7695bf1d59fba1f047c1e7c15fb38fc1df073abacb6361e7cf0b70632c8f2b29ff75e551f515f487e15c9d9a2bf8f2090ff00cb3b3980fc648ffc2bace73c7f2aedc0afdc27dcf809549569caa4b7936fef0fce8a3b7ff5a8af4890ef4d6655ea455733e47c80e3dc54443170dd85005bf3001d3e94e0c18fa1aa064dafce48a5f3b04753401a1de8ee6aa0b83b0e063eb592fafda1bf36b04a2eee41c18a1c311f53d07e26803a0e0d7e64ff00c149878821f06fc18d46c2ea4b1d12d7c4374d7971192025c7d9c3419c1e46d5b8f97bd7e972cb218577808c7aa839c7e35f0d7fc145ec7c3daa7fc13535bb3d63528b4fd4ff00b56d1f4356976c935c6f28ea98e4910bccde800a992bab1e8e03114f0b8c856a91e68c5eabba3f02bc47e26b8d6fe376a9ab4b03ea577b63b7b786319c85892527fe04d2e4ff00b8be95c8797af2cf7377a9dac50cb3392573e66d5ec3d0ff002fae335ed9e0dd0f44d0bc3206ef3af6545fb45dc9f7e62aa141f61851c7b773cd50d6121d475c4d2f45b39b58d5ee0ed86d2d2132c8c7d02a8249a69591c9566ead473ee799d9594f7717eeb5d4b11fdd36a001f9573fac6957767310d7ab7e3aac91679fa57bb5b7ecb3f1f6f7c5be1c82f3e1f6abe17835dbb30db5d6af11b748f6aef66914fcc802e4f2b93d00278af6bd0ff625f2bfe0a09e1cf853f137c6f710785fc49a04d73e1abe860fb3453dec0a0cf6f202cd970a7cc4cb608e00c838c9d5a6a6a17d5971a15654dd4b7baba9abfb287ed0be04b6fda123bcf881711d8f8a6f2cedc6a334d751245ac359bb4d07ceedfba91e71033a9f95cc590724257d63e31d1fe1f6a5049e3bd0bc622f350d5ee67bb96c35203f76be6908490b870e0060430ebd08c638dd73f679f849e1ff00809e25b5bfb549fc51e0e30ea3a7348aa7cf81666b6d52c071f32f9d6f34b16efba64b723ee9cb3e30da7c00d07f66af0ec3e0d4f12e97e33bd8e2820d1742bfbbdd7174ec176c768331eece48db1e4f18ad23aaba2e71517cb3bb6adaf97f5b1f3a78cf5ad3af3e32783f536b6862b8b0b3bc6bc8e35c2828a78c7d76f1f5af0cd63c5dacddd82dcc91c3a0692d3a9924bb93613885518a0eac721b8009c135cf7c40f0c7c54f08788a33e30d3359f0ce831ddb470cba95cc36fa903271ba48931285393912608ce4a8e95566d274bb7d164bb588dd5e15e669edfce909f5dcc4ff002ace508cdabf43d3c3e638bc0509d2a3a4676776b5d14969f27a983a178f6ef48f19d86a16d3c972b6320b9f3ee23dad752c65da35db9e10b3e4e7923a815f4a7846593e317ecb5abe9dac38d43c61a23bdddbdcb0fdf4f0b1cc9923ab2920f6cfca39c135f1c480cda94ed213b94f43e9eb5ebff043c653f82be3868f753311a74f73e45d29e9b08dac71df0b2123e94dc23bbe87a7c3f987b1ccf92bbbd3adeecfcd3ebf27a9c1c575369fe2ad5f4ebc90a48d0794ca188cba38e3f2dd5bb1d86abff08e59df40f6ba75d589329b837523bdc156dc876b1c215c01f2fd6a7f8f9a22681fb41ea46c7fd4cc05c41b06015ec07fc07033eb9ae0df55b75f075d29b2b39ae6575916fa66679a30a3ee2f3b429fa679eb5cd36a4a338ebf33d5c351797e33159755a8a09732d63ccddb64b4766fbe9ea61df69d71e2ff008bde20bab5da6e6599e7d99c1917ef123eabce2b57c30ba8f823e25787fc5ba6de4da55d58dfc730bb8065e1c30c9c77e33c77af3db3d6b52d1bc5706a56723417709528c475dbc0cfe007e55ea3e19d72d359b64d2b529e1b29e67db14976e238f9ecce7818f53fe35a5e57f23e6e71c2ba11514d544ddfb35d3d1ee7f549f077c6f61e3df0be8fafe9da926af6773a1c52c57a8bb44e588dcd83c8e02123b126bdcbdebf38ff00e09e2b7b17ec71a1a4f9654bebd5b53b810d6cb2228da470577b31cffb15fa39edf955d14a30b23e7a5151934bb8724d1477ff00ebd15b9253f3e2283af23a81409a220e0f3f4ac2bdd434fd2746b8d4755bfb7d2f4e810bcf757532c71460776663803eb5e4377f17350d7dfecdf09bc1d77e2f0c768d7f510d63a3a7fb49232992e7fed8a329fef8a96d22945cb63dc2ea392480b4371e49c7578c328fa8e0feb5e4fa9f8eb5ab5d52ef47d06c2cbc5fab46b8df612158e07271b65049552382434aa483c73c56769ff0e7c71e221f6af88de319afe29393a3697bacac947f759509771ecee41fd2bd2ecbc2b65a4e910d958c7158d944b88e0b68c468a3d940c52d59568c7ccf291a8f8bf5dd52de6f17c37ba2e872170da7e890bc98c70a1a545691f3ce7e4880edbabd57456d0ec6c52df4b8059a01c4725bbc4e7dcef0189f7357a0d3a049772bb1f726adc8bb1386e9d6a896ee5d840918cac72074f4afe70ff6cafda16e7e34fed6bac7f675f07f02786a7934ed060598159423625b9c7ac8eb907fb81076afdc9fda17c6b73e04fd87fe24f896d65fb2dec3a2c9059386c324f3e208987b86914fe15fcdd4de154974bf2c5b072475c5324fa37f667fd953c7dfb414f0788754bf9bc1df0d55c83aa3266e2f829c325b21e3a820c8df2839c0620ad7e9ae9967f0cbf65fd45b41f027c39846956963e6f887c4f35ec7f6c0e48da8eee0bca5b3bb686545c8007381f9c1fb287ed4fad7c09f1ee9fe01f1c5f4979f09af6e3c98659cee7d06476cf9887fe78963974ed92ebce437d9fe2ef807adfc5dfda0fc61abde78d66b9d22faf629b4fd374e902a08fca00191ca9551f28c603160d9056bc9c5cea411f4f9353cba75dbc637ca96cb76cfa1ad3e33fc38f8b1f0ee1d4b40d6125b9d3efe39bc8b81e5cb0bab6d704743f234838cd717fb59f82af7c4ff00b28bf89fc3c3caf18783ef22d7b44ba5c078e48092e01ff6a2322e3a7cd5d9f87bf653f08f873c13a3a6916d243a85aaabdd44f75208af5c0ff968f92edce796271e84715e99ab456ba8f84f54f0e6a56e6de59ed1e29acee460b23295247675e7aa923b75e2be6f11564aac2a25b753be9ac349ca9d3778b7a27bdbceda7dc7e747837c69a069fe0bd5be27fc46d72ce4b2bfd2a585a2b9997cb6591bccb97d8df78b15011474445ea5d8571975e0997c11f053e1c78c347f176b17be2dd4ed5eeeef57bfbe7b8b8d2e0fb2c970d6b6d2484ed3b7f72180042649cf20f802e9da6f847e02f8eb44f897e12f11596b8b621b47d5e098c31dc6dbb100883025447221676046eddbd8609403d1fe107807e257ed3074ad2745d42efc33f06748b2861b8d66e173319decd23bbb7b71ff002d183b4ca0901235619dc4043f572af4e14799b3cef632963554a91f76ff00823aff008f7e18f03f8b7f632d2fc651eb0ba9eb9704db6a31c8e5a7d424db84f2e319795b20fcce5e463df1851f22780edda7f0c59683e27d36f346f10dac7e4dd5a6a56af6d7031f759e3701977aed7191d181ef5fba9e0bf837e09f03e8b6da3785f42864d4a1b7f29350bd7f36e0277cc8412aa48ced5c2e7a0ae73c7bfb1efc35f1ff0087357d46e7ceb0f88b76de747e2981d84892aa2a2218b3b1a10a8abb0f3804eedc4b1c30f8c8d67cd18da3dce6c753a8da7527cd2edd12febd0fc29f895f0e858e9926b3a48db2c1f34a8bfc4beb5e53637056df4c96445091ce7e7c7238c153fa11ec7dabebef1ce9fadf83fc6be20f00f8ced16d3c43a5c8d6f77183949148caca87f891d48653dc11d2be31f10c6f65677b042e5047731b8c7a6f03ff0041635eb68f63c44da64daff88358f17789a0bdd6ae3ed32456c6089b18ca2bb1c9f7cbff002ae42cb568bc3de35b3b8b8b586f92de4f3e082e103c6cca4603a9fbcbedee2b45ee9619ec2dd158cc60909207ddfb9d7ea73f91ae5f5d88b59c6c461924dc73d71839fe959ba7171e5b687a7471f8aa78d58be6bd44ef77aeabbdf734efdee357d72e7599ec19ad67763298502a467afcbdb2339c0ed91c66ba8b1d162bcf0b6aacf6a5eed02db5ac5b70d25c4ac1610a3a924906a9278dcde7c2fd17c291dac7158e9cd2cf3c889f33966dcccc7b9c0551ed9f5afb0ffe09f1f052e3e367ed97a4f8b7565b9bff000df84f598f54beb63221b75910130f9c8c4360b280bb776e2adc0556ae7a6a56b356ede87d0e715305ed955a151d594d294ddadefbd5a5e8f43f7e7e09fc2f4f86bfb2d7c29f0adbc4b15f683a4c50de718323491e66c9f5dedbbf0f7af74f4a4ec3d28f5e715d69247c5b777717bd14ddc09ea28a623f3ff4cf87ff00b41693e30d3759f895a1e89f1ba5b4ba69a49bfb5bc8201076ac1672c3f6788a9208718738e58d7d0b67f18fc1d6372b278a3c37aff80351650b21d5745919001c60dc5bf9916d1db2e2bd0ed3c55a7ea7a725d695a85bea76cf9292c2e254603fda5e2b66da54bdb322685594f505723f5a9492d8d2526dda5d0afe1ff18785fc55666e3c37e22d375d880f99ac2f639f6fb1da4e3f1ade721d706bceb5ef861f0ef5cb85bbd4bc2f603504ff00577b045e45c467d5648f0c0fb835058783eff4389ce81e34d73ecebf72cf52b95bf897fe0532997ff220a7a91a1db3868d9b0d8a8c658e19b1f5ae22eb55f1de9f3334da768dae5b2ff15bdcc969707d711959149fab8fc2bc6fc65fb4ef817c216b6ffdb165abc1a8c97cf6a2ca3b192e659de35cc896ed6cb2a4928257f76cc9c364918e55d2dc6937b1c4fedef7935b7ec05aac3126e824d5ec3ed2d9fba9f68523ff001e0b5f8f3a75d5ab5bb96c70b5fae77ba3ff00c355fc27f15e8de21f10a786f4e96131e9de1cb4ba492e2da5da248ae6edd49f31958a9f2948452a412cc32bf8b3e37f0f78bbe17fc54d6fc0fe2fb27d375cd3a531c8a73b255fe19633fc48c3041f434d3b89ab1d3e81f0e4fc5cfda0fc27f0fec6436ffdab7bbaf6e231cc16d182f2b8f43b46d5cf1b996bfa14f829e04f0f781fe14c5a2f87ec16db4cb79bc9b7cbb3b9585161f999b2c4868db9249c639afc2efd8bb50ba6fdb76fb55b678a4d42cb4368a286e5b11cb1c92a0906efe1390986e71d30735fbcde00d607fc2bdd104f0c965772db24b2c530c17771bdc83d0e4b13c7af35e0e2dc9d757f852fc4f5a9a87d52d1f89bfc0f59dabb6b93f10e97637d0345776c93c5f7d43af2a471b94f5523b11c8ae95261244194f07dab9ad52e5c5da40399a670918ebfe78c9fc29569c24ac91cf4232550f0ed67e0d68daae816416da27b98a42f6df6bb64b8f2599b76e52df3641e724935d7681e101e18f07d9f87b40b2b3d32c2d94ac68aa70492599c80065998b331ce4b1273cd7acc6231a95bdbec040899b27d4151fd6a4ba8e2055b1824115e74f0aa71bf43d178ea927cacf9f7c7be09f16c9f0e3c5369a3789ce9fafea9639b0fb342d6c9f698c6514ca24665120023246300e4735f9a9aefed19f1207c5df097863e1478af5ad0f5e59a2b5d734df10bfdb7ca9e272b7113c5216da4052091b4e73cf7afd85d70a4ba14e971308c2aeef35db1e5e39dd9ed8eb5f927f16fe337c0cd0ff6ccd4fc656de07d52e3e2cc322c1a9186d120800f2e365662c46e678c44c5864f38cf5ae9a31f691508696fc8f63078f86128d455e9a9a9a7bada5d1ff5d8ee7f6f3f86777e21fd9ebc35f1b6d2c52dfc47a1c515af88440a7f79693300a4f73e54ce31ed2b67a57e2ef88e413595eba8dcef6ef81ef838fd6bf4e3e2cfed9be2bf19fc01f15f822dfe1dda43a46b7a54d64d7171a99924877a101c2040095386033d457e536a7752dbf9eb70af88d0861b39fc87bd7d0d2528c6ccf8c9f2b77455d3d58ea968f39cbbc9863db953fe0056b6ada3c77b7d2c015e43f652cb1c4bb9dd8b2a80a3b9e6a56b3106930c807ccc4631d7ae7fa7eb55f58d7eef47f12e9ada6c421d6eda3df2cc4e7ca390538e99e377fdf35b37644c5372b1e8df0e7e18e97a878ea4f014924e75fb88c402d614125cc970d8db101bb00f23233edcf5afe91bf64afd9e34cfd9cbf656b2f0b2ac7378a2fe4fb6f882f4005a69d8602647558d7e518e33b88fbd5f925ff04c1f83907887e3578afe3c78cede4bf8344985ae97713c4f297bfb8600ca30092c0b0f9bf87249c0e6bf7c3c3de20b1d7fc3b65736f7111ba92ca1b89ed9650d240255dcbb97a8ce1b19eb83e9511dee6953ddf74dd638effad52924cf7fd6a69988c8acf76c838ce6b4301be71590fcd4546b1ef7c11c51401f911acfec79fb4c7c17b9975df815f16ee3c5fa744372e8dab4bb2e8a0fe00d9f9c63f854ae71d2a1f087fc1407e24fc37f14a785fe3dfc369ace685c453dcac2f6f2a9ee78520ffba149f56afd64951a30727ebf3579778fbc0de09f1f786e6d2fc65e1fb4d6ed4a1506e2205d07fb2df787e15c9ec147f86f97f2fb8f763993a9eee2e0aa2eef497deb523f863fb45fc1df8bba6dbc9e18f15dbc77b2e1469f78eb1cc58ff02f255db9fbaa49f502bd9e49d21888561cf0307a57e4af8b7f603b07d66eb5df847e329bc277cb96fb3dcbed403ae0b291c7b70beb9af008fe397ed03f09fc2d7d63e243a8788bc1570ef656de2ad1d8bdbdca2300ed6b2baf96cbc140cbb13ae0b63359fb6ad4ff00891baeebfc8eb580cbf18af84abcb2fe59e9f74968fe697a9fac5e2ef887aaea5e39baf04fc32b38b5cf1646bfe9d7d213fd9fa303fc57122fde7ea442a77377da3241e1df833a044b797be2a693c75e28bf8bcad4b5cd5399245ce4c50a8e218b3ff2cd38c752dd6be70f81ff00b6b7ecdf77e0db0f0d470cbf0e1d3992dee636956490fde77931e648e4f2ce437bb1afb5342f89bf0cbc4564b3f87fc79a06aca07ccb6faac2ce9ecc9bb72fd0806b6855a75767f23cbc46071b84fe2d3693ebba7f35a7e26578a3e1a786fc5661feded06cb55f287ee2696202780ff7a39061d0fba906be23fdafbf66dd12eff658f11f8d2dbc45aeddeb7e1fd3de4d26cb55b95bf323f44816e26ff4854672061a528b92703935f6c78b7e34fc2af04f86751d5bc47e3fd0ac2daca3f32743a9c4f228e83e4562dc9e3a57e2bfed49fb6ae95f182e1fc39e10d796d7c1f1ca55e278e6479c0e32709b707d7774faf1b3d363820af2b499f32fc29f19eb5f063f68fd1fc5b79632dde837101b4bfb8b25f39268db6b4823ddb4b6c75439c0c81c7de15fd00fc10f8cde06f8a7f01f4abdf0af89ad2f2decd7c89adeee1788c654e006132a9edfc3c7bd7f3f3a1ea5e2ef88de25d17c1be11b0b4d4240ac96d179f120271b8b6e660380849e7b1afb37f64bf89d75f0db4cd7bc0d67a09d72eef3549117c9b985520db2c36f24a64657df9924015635f9886e4715cb5229abf53bdd1ab1829d9f23764fa5fc99fb7b6faabc764258b72c03fe5ac3fe950fbf00861f8122b3ed756493549aebed369ac5f80542595c28312f5dbe5b10c0f033d49f61803cae1b3d611bcb40c2e94fcec032907df9ae7b5cf086bfabdcf9f7bf67bb751f23dc6edebf42854fe64d78b52bd05a1dd4f035b756fbcf713e2b48fc6166678a686164788bb42caa18e1b92463f84fe62b5ee35eb4990ba5cc4547a482be70d28f8abc393edb96b8d42c178f2ee24de57dd1f071fee953f515e9ba5f8862bdb77b885e5be8e2ff008f8b7170f1dc424faa33107ea1b071c55c396a43dd911569ba335cf0b195e3af1186d1e3b0b3737935d49868edd4c8de5a8cb1c2e72a4ed43ecf5f893f1de582f7f6e3f184a20311db6ea4b11972b6f129381c8e548c1c1e07b57ec378d7e207c3eb1bdd46eb54d5134f6b3d3f76cd491a331e4b194ee718c6123e41c715f83de33f1dc7e36fda4bc67e30b424e9f7b7c56c8b02330a011a1c1e9955071ef5d384c3aa757993be86389c4b9d0f67ca92bfe46c5d98d74cd8c72d5f337889e09bc55a8b280636b85897d090727f406bd1f5ef14341a7ccb1bee998601cf02bcbf4bb41abea723cb214b0b48da59e403258e7923d493851ee4d7b678c6f1beb2b7b7437055e678d96ca13fc6f8c6e23fbaa0927df03bd67c1e1a9ef34fb8d4d95e796773fbc232d21faf7e6b36e3c2dafeb9ad5edf5a5a90d676be7ac51f3e4c4a7a7ebc9ef935fa81f03fe04d96adf1c3e06f852fa1122dd5eff686a3191906dad104d26ef6760a9ff0315949ddd8eda71705cccfd12f81bfb36f873c19fb047803c0da9592db78816ce1bed4efd1e58a74b89584b3a078648dc704c60eec0da09071827c2ff0678af469fc49a1f87fc7baee9b69a4ebd7b6527da3535bdf206e59ed408e78a4dca6199376244c76ce4d7d8932a97662463a0c578269d03e85fb67f8dacb734767af68565aac201c2b4d0bc96f39c7aed6b6fd2b4492391c9b7766ad95d7c72d22eb65dc9e18f1cd9839ddb26d2ee48f6c19909ffbe4576da6f8baea642badf85755d12703240845da1fa3425bf500d5f4bb3b8a06c11d2b4edef232db652031fe2c75a620d3fc49e1cd475336565ad595c5f2ae5ed16e17ce51ef1e770fc451536a1a5e93ad5908756d2ecf55b71d12ea05957f26068a047397b3c8198ecddea7d3f9579678ebc59a27847c11a8eb9af6a56fa7d9da445dfce9d5371c1dab927827ff00afd01afc0dd73f689bb7f00bda7857c7dace87a9b5b8324f63aa3c449c8241c1e41ae734afda034cd6fe135f68de2bd485fcb730347786fe459124c0eb870707e9401ed9f16fe387c5ff008ccd7367f0cb59b84b6362f1ea3696e11ada68db048891c1e0818ddd591c83c122bcaedbe39fed19e2df09e93e17f12f8f1a0b4d3e58e04b3bbd3a048c227ca23640814ae0007209238ce38ae0f4ad63e1e4df0242e9b78fe1ff0010c170d341776576f1165e8ac1776de9db151782fe2f3788fc050785fc59696bab9f9a3b7bd3b639e275c961bf3df008e7073d8f5e795d6acf630f1a755f242ee4fa5b7f4dcf58f1cfc27b93fd9bafea967a469da55e21fb65c699b93648492ae2366da100c0da31dcfb571b7bf016ee5f0fc9e20d1fe20699e20d1ad914c76569a97973dc4ccea8b6c558800e5f7318f7aec8e4dac48af28f126bbaebea375a7cbac6a1fd8366be625bcb316520328d99e783b80ebd09c575169e384bdd23c351dac2b652a0be8d1236e0b430c1229c74186cf03fbd58a8539caed5cf46b55c660e924a4e37e9fd6c725f1a7f71e33d1fe18783754b5f1158472c421974dcac57d772e034ac08041c92006e55703b64fd33e1cff827078aaebe0ba78afc4be3b8b40b89a146b7b71131f364720222a2ab3b162405006e6240dbcd7c8df06ded9bf6dbf02a6a4e0db2ea3e74af21e0054762c7e98cd7f4ca6f61d07e194ff11fc4960f33697699d0b460006899c08e3500f1f6898b2c793f703ec18cb96da73f66958f9d8a752577ab67f3c7a8fc07f8b5f07be3fdef80269ede4f134da20d42e3fb36ed4c9159b161b5d98a849090576a9c9dc00241cd7ecc7ec7ff00b35e8717c23f00f8d1ed5ec23b206f204bb891a7d4647292c133104848e37323a47fc47639c6307c4fc73f00be2bf8a7e257847c4ba66a705eea3aef8b6c754f1edccce9e4ce525454842b9045bc2a4246aa18ed5248dc496fd77f03787c784fe1cf87bc38ce934ba7d8456f23c4a42b948d54900f2071c57915b130715c8fe2dcf4aaaaf082a75afeeaf7574d5dd96ee3469a367b96bc9de52396f33fa631fa563ceb7d01dde5c3aa41fc514ca125ff0080ba8c7e047e35de5f4abf67d8064b0ae6a44dd29f6af3ebd1846568bb914ea4a5ac8c348b4fbc858db2b2e465e0997122ff008ff4ef5e79afe83259ddff0069e9509fb443c9541838ee38ea3d457aa496b1bc818a90d9e194e0e7b1c8e87dfad24fa6defd99b78dc197ef28c13f51ebee3f4ae195e1ac743d2a58849f2d4774fb9f971fb567c3af1cfc4af866d0f81356d3e389e746d574eba95a1b9c05042e4655d49c9c809d3eef071f8ed7f70da06a77ba54b7514d736970f04c2d98baee462a76b636b0c8ea0e0d7ead7ed5fa178dfc1de36f8b3e35f056bf25b5c4f6da7695a869b21e0d9490b3437108fe19239c4e81bb79ee3a9e3f35b45f83fe3ef107c3293c4fa4784ef354d0937092e6029232904820a06df9041046dafafc336a92726b53cca942a57af28e1e2e56ecafa7c8f2e904facdeac4a4c7016e77705bebcd74b0da43a3a18526595f2a6e111b2ab8e554f6cf39c7d2a1b7d1f4ff00b725bc9362e7763eceb92e4fa10071f8d74fa7e97a6da787350bfb89858b33b98a09bef673b464f4e807e5c66bae4ecae4e0b0b3c4d5708d934afabb6dea5eb7d7358f0f7c2ef1078becd1534cd4278f48924c8241cf9a531d465637fc2be85fd96ff69af0ff00807f6b283e267c54d52eedb49b4f0ccda6683690857691e478cb4a4330c00a303b9c9f4af90ecafb599635d3ece4863b447798288f72ab11b4bfcdd5b1851c70090319627f6fbf620fd98fe19eb7fb0fe97e25f1f78274cf12eb5ad5fdc4b69797b6ea6e6d6da290dbc691c830c83313bfca472e6b05ae8b73692b5ea54578a76b5f7f9fc896ebfe0a61f07a672b69a5ea9a8c00f582da7427f111107f3ae0b58ff828bfc2ab8f8bfe16f122787355b2fecdb3bcb2b88e58e526686e3ca6c0c43d44904679ed9afbceebf65ef874968468736a5a01072abe7a5f463fe0376929c7b022be62f8e5f03bc47a1f80750d6344d2bc19e22bcd16d93576bbb8f088b699edace6599e27701e293237653e4dc09e29f2555f6bf040b1181ff9f1ff009348e62c7fe0a45f01ee6f0fdad759b066ea3ec0e403f575415ec3e17fdb3be05f89ae2116de328ada49301619504b20cfaac25c8fc715e6f07c3cd1df5ad4dfe207ecc3a6dee9d78914df69d02d2daee1814a019852dc0b8556fbc7783ce718e959b71fb2ff00ec67e399db4f6d361f07eb32f4b43786ceed0ffd73b95ddfa54f2d65b4bf01fb5cbe5a4a935e92ff0034cfbe7c2bf10fc17e2b1e4f86bc5fa56b370065ed6def51a64ff7a3cef5fc40a2bf36b57ff8276dfe911fdb7e0dfc71bdd27cb3bedb4ed615a4b50474c905d4ff00dfba29f3d65f653f9ffc01aa1964b5f6d28f9385ff001523f0b93e0ffc50674687c1bac5c31fbbf67d1e490fe8a6a6d5be157c68b0f0a5ddedcfc35f148d32da232dcdcb7852711c28072cee63c281ea4e2bf72a0b9d0df940aa3fd87c568fdba082d655b2d52eed048851d63b838652304119e41f435f2b1cf9dfdea7f89fb856f0be295a9e2257f387f948fe6e6df4fbabebc64f2ee2dc2ffac6102a95fc0115ecfa1c93f86b4151a75924ef70144979b41240c15438240c1e4f39271e95fa5f17c00f0ee85e20d7a7d0750820b0d503f990cf6313bc1b9cb6226230a06ec0c827007d6b73c19f0b7e17783349b9b0d4bc2379af25c486492ed75a10ca09ebb7f74cb8ff0067a726bd179be05daf2b7c99f3b87f0ff8a2309fb2a29b4f7e68a6d795dad3d6ccfcf0bdd175eb9f00dcea9ad346f6b25b116f0db1f984808619c727382bedbb3ce2b9ab4b3d42d3c37a178a234845869d7fbbecd1de2493ba36d12b32f070762479c757c57ec6786349f811e1ed6a4d4bc2c93f86f58689639edbc41a3d9eb763718fef23a975cf7f2a4801c0cd56f89975a37c42f86179e05d0be0ef85f50d42f90476baaf8334a8adaf5a5dc19596da41f228600902772466bd1a188c3557cd4e699f1b9ae559ce5b4553c661650b7da6b47d6dcdaaefb33f1f21d3a7d23e36e95aa69db65bab0b85b8833f7668f87420fa153d7fdaafde8b5fda0bc17e23fd913e13ea1aeeb70dac1ab788acf489de6185fb50865921127f7332429c9e8f8071d47e2b78e742f126811a689ace929a2ebfe14d427d29c8c3380921c412382439889650d9e63298e16b3fc2d35af8e7c63e10f0078975dfec5f0aea3e2584deacb2304b0b92a516e415e700b0c81d7271c939e9a90f6d1e5b9f234a7eca6a56d99fd2cda46b73e10b88a0e24301f2ca9e4381c11ef9e6be92b7916eae2caea2e629611229f5079ff0af993e1e5a47169369636fa826b105a0f24ddc4c592528769209e7195239e78e79afa47c34c1fc2f6b19fbf6a5adff00046da0fe2003f8d7c428b8d774afb33e9f339c6a42151755f99b374b9b3247045600e588efeb5d2dd71a749d8e2b968cb33003a93815ea564e3551e0d1bb8366ad9c01e412372aa78fad5cba9e38ad1cb30071c50e45b69cdb70081f99ac89a051a74b797f70b696aaa59e591b181d7393d0562d4a49a4898f2ca576f43e46fda2bc15a1f897c2915fea56575788f2456f796da71c5e5cc0b26f0b17f79918ef03d8f5e95f8dd37c59f19fc25f0d78d7c03676577a0457970d706cb50876cf6cac555b2a704065d8c08e06e6ef5f70fedf7e23f88b609e0ef10fc3cb29aeb43d375256bd5966f24cc8c54068c9c2aba9561f310c44c0a83b4e3e49f8cbf06fc77f14be12dffc7fd66dae342d7961b1821d16f84925cdf444c713cb23c8d9521e42ca59416553d14a67d8a0a11c2c6339efb7f91ef61b178ac0e61edf0f0d62b5bf556febee3e38b6d4e18a6d675940d61a6c23cdbbb8440d2004fc90c79e0bb631cf1c331e16b9a9fe23d86ada5adbcba12d83473462d6449e5b89e54248757258296e410511464118e7236be23cfa441a50f08f86ee85de99624a3ddaa95fb5cd81e74e7d01236ae7908147635e2be29d0f55f096bf068fa85bc965aa496a93cb1b022489641954c762548cf7e71d8e7d8492563e5e752752a3a927ab77fbcfa1e296d606d3ede2f91af6741f32952107cc783cf6fd2bedbf857fb7e7c4ef84ba2d8f826cbc3ba0ebde10d2e311d8c3730490dc2237ef39951f04e58f254d7e68f86e2f15e93a3e95a9eb1a7cb6fa1cb04eba4dc488154b82aadb73d705c03ef5f5dfc32f077c08f1a7c19b7d53c49f137c53e05f1bdbbb5bea31595a437b68fb005471138046542e7e7e4835c52bfb4b45f43eb29f2c32f6abc3ed27aae96d1f4efdcfd43f07ff00c14efc15a81862f18fc3ad634576003cfa5de4576a3fe02de591f99afa7bc3ff00b587ecebf12742b9d21bc756da5aea16ef6f3596b90bd99d8ea5486671e5f20e3ef77afc15d5bc13f0eeca691bc35f1b60f10a467fe5ff00c1cd6447fbcf15cc83ff001dae5e458603e4c1e20f0f6bc186163b3d53648dedb6748c03ff000234f9eaaeccf3feaf82a9ad9c7e4ffe0fe67f489f03eff4cd73f677d06ea3b8b3d4759b080e8fa86a16ec8ed335a3b443f783ef2f1b8738f9b23ad775ad691a1ead64d63ade9563acda37de82f6d9268cfd43022bf99cf0cfc41d77c1de22907877c49ae783f53842bcad677f244a99e84bab18f0707f8abeb5f047edb7f19f42861fed6d5ec3c77a70c00353b655908ef89a2c163eedba9aae968d585fd9539ae6a3352febe67eb89f821f0fe6ba33e916fa8f83e7272afa06ab359c69f4855bc9fcd0d15f23782ff6f8f035fc51c3e2bd2350f07dc9c03320fb5db7d77280c07fc04fd68ad154835b9c32c162e0ece0ff003fc8fc858e3d3b4b6de3c6fae5a01ff3edaa8e2b4e1f88f169500d9f14b53caf44b99639f3f92e7f5ae58685e039e7f35fc15a8ceadf74b45cfe4641fca9b37803c1baa2edd3fc05aa236396f27763f0576af9ff00ecc72f8e7f823f6d5e2051a3feed84e5f59cbff6de537753fda1b5cb2d3dc69fab45ad9c6034b6de51fae431fe55e5fa87ed03e36bd06dda69ede27383e45c124fb6060d76da0fecafa9f8fb5896d3c29a6ea167247b4dc4b741e08add49c02c5947e00649c600278afd45fd9e3f613f86bf0234bb6f1f7c4f99bc61e2a4224b287518bf776edfc3b21193bb3d01cb93d36e4ad1fd9b85a6b9a497ea6af8e336c541cdce54e1b6f7bbecafab7f3d3ab47cd9fb37fecbff0015fe27dad9f8d7c7baadefc3bf001c49f68be526fef57fbb044e3e5cf3f338e3b2b57e91f8367f877e09d4adf47f04785355b8d26103ed5ac5b14679d948224791d94cdf30ced566039c2a9e2bd25341d73c7970936b119d13c34a00874f0007910740e070063f807cbebbb8c7a2dbd9f86bc3fa6a5ac51dbc3bb118de41690f61cf53ed5e7b9d0a72bd35f33e2332cdf1f993f675e52e4fe44ff17d2e7e6bfeda5fb3cd9fc46f096b3f15fe1bcf3daea378be7789747cb0b7be3128fde86520aba85e7919ee33c57e3cf842d2fbc2df1efc29af4d6f64d6d1eab141767518f7d9b4464092a4bb83614233ee0467f215fd177c5bf127823e1d782afbc47aff009f61a64a3ca996c2295dae09e91958f839f46c0afc08d5b5fb6bdf887ac41a4e9125ce837b0196eed99777ca58b0981190a407501ba1efd715f4381af3ad49dd5add4f8bc7e16185a91b3bdfa753fa39f84be1fd23c3fe098ac346b3b4d3ec559e486dac6258ede3dec6422355e15773b1007622bdb34094dbf89af6d8f11dc2accb91fc406c61f8055fcebf1bff0062bfdaa6db42f10699f07be226ac3ec8c16dfc2faddcb6ddc3a25a4e4fdd6030a8c4e08c2e785ddfafd05d4716ad61741815132a161fdd7217f2ce0fe15f3556955c3e2af3defb9dd5e74f11494a9ed6dbb791d8f89354b7d1fc0da8ea5724f950425b68eac7a0503b927000ee48ae72dee485491b01c0048f4350f8d843a9f86a0d3ddb03edf6f330ff00ae532ca07e682b063bd001dd2055eac4f615bd7c4aa951316130b2741b3b2b9d72d2db4b7d42fd88b68df6471a8cb4cfd940ee6b88d464d53c4132cda8b082d81dd0d9a1f953d0b7f79bdfa0edea6b5abff6ceb22fe4522d2dc6cb389870beaf8fef1fd071eb9e8182e7038005714eac9c3953d0e98528e1ea2697bdf97fc1380d5b4d586112638ce08c57e6b7edfdf163fe101fd9923f0de973f97ad78866f29421e5625c649fa9208ff70d7e90f8fb574d37c3a512e6ded6e2475449ee9b10c1b8e0cb2723f7680976e73b55abf997fda9b5bb9d6ff6d3f1ddb5deaefad8b2d6a5b74bc927693ce8e1fddc6c09e003f3b00a1546ff009554600f532cc3ba9fbc96c99a6618d70a1ecfed497e0791f87eee4b5d2350d72e0ac9258c42589241b849396c42983d46ecb91dc230ef5e81f06fc03e27fda17f6cad1b4cd7b509ef6eb51b8136ad7f21dcd0dac406f6c9e98501573c6e65f5ae1b4cd324b8f0f246c311e7ed328c74e3080ffc072c3feba57e85fec54342f87ff0a7c71f16bc4bafd9f85f47bc99f459f5696dbce9f4fb68ed65b9768013b4c92ca90c6aacadb8c78032457d54e5caae7c9d2a5ed66a29d8d5fdbd3c35a0e8fa4fc2df845e02f0e5ae98348d16eb54482c976b94bab8891739e73fe84edc9ce08f415f96dae586ad63ab1b6d4ed26b1bb203ec75c1ce31b97b107fcf7afae3c61f13b56f1ffed2f7ff00113c4fa8dc4f36a855237bb112bc16d18290c6c22558c158d5412aa01604e39ae23c57e3ab0d5e53a30d1edb5a25c25bb5d27cc4b70193b819c739ae7f67eeaee7a74f1752126a4f993ebadff13c6b499b4996054d6f5dd6605c01b534ff003547e3e67f4af498bc27f086ebc26f7163f1e6df43d6c64ad96a9e16d402371d3cd8a3719edc8c7bd7bf6a5f02be1f5b78662d467d4a7d2bcd5dde5fda81d83d4eee82b8d1f00b40d6b4617ba178b9eea19573097b75923719c7de53fd2a391df6476fd7293fb725fd7a9e4b1f8afc13e1ef0d59680da49d57c48406bff16c7abcf2c52236196382dd762a85c91b9f76704ede703d1fc19e1ff07f8ab54b8897c613f87751600da4b343e64737b17565233eb8c735e07f14be17f883e1bcd6f717612e34db92425c40a762b7a1cd79ee83e2cb9d3a748bcd2029fdd92781edf43fa1fc6b78535189e24eacbdab699f7adffc3ef1df87e412e9bacd8eaf1af2a44cd19fae719cff00c0a8ae2ed3c6bf11fe1ee85a75cf8fbc3f35d7836f0a7d9753b7b88a7fb3ee1955768998038c901b048cf5c1a2b3e4a33d6c99e8c71998525cb09c923f74f42fd92be1978657ed9a94526bb70a7389fe58c7e039fd6bbdb7d13c0da6584b0e97e17d3adada09042d25be9e84b4a7a4518c65e53e9dbab11df6a0f139f17f87af6e2191ec3c2768a0dfeaeca37be40221831c348d91f30e8083d4ad6dc42d7c25e1987c4faa69e96d7c23f27c3fa2a8c8b257e9c7f14cfd598f358ceac62afd0e8c3505cbed2a7c2b4b756fb2fd5f45e6d2704563a5f82f4e835cd7ece36d6ddb1a56876aaade43b0e001c0798e39738000fe155c8f2ef1f7c52f057c328e3f187c59d5d6e35d9417d2b40b2612cb18f48d58a8cf632b95048c0c70a3e43fda13f6bbff00841fc5fa8787bc193da788fe2a3fee2f753b87df65a06f233120e924a3f8bb02006ce360f85e5f12fda35d97c57e36d7a7f18f8c6fa313472de39949923b9dbe44c87841b577803002aa8e338af2a709d79273d23fd7e07d6e07032c6b739c945474bf48f9457f5aeeefa9fa15f103f6b1f8bbe2ef09e9e9f09b41b3d06df5313c50dd3a19a582589c2b4265994209b6fef36984a85c10ed9af91350f0678ffc41e2c1e21f197c46d4752d510c97915ede5dcb333596d525d2266d8924048324217a32a8c1ab907c4689fe1f5de8adabc1a5d8cb791dcd95bd9599bcbc8424864db23168e15dc5b2c56476e00230315cac9aee87adcf18bbd7758d52e6d669e53b353891b74cc59c3247193c96663cf5639cf18eca745435a71b7f5f367b3ecb20c247f78f9dfab7fe4bf33d47e23695af78d3e046a7a7dc78c67baf166816d0477da68d465161a944ac045729006f2d49236318c0024443cab123e4bf84fe26d47e1e7ed1ba46acea74bb4b8952daf646728a409e3942b9fba019234573c7cacc7193babd0af3c41a2687ad5bea3a6697a845736d60d60c6e2f26912780aedf2dd5d00618000f4c0f4af115d5e3d6351bf06549ad2e245942fdf451d31ebca920e3fa0aebe4972383d99f2f8a965788c4b9d1bc5ab35faa7e47ed578d3f649f849f1d7e170d5f4cb1b4f0c788e7877db6b7a3c2a81dc8c86911484955b8249c360f0c2bca3e1efed0bf107f67df167fc296fda42d6ea7b1b64f2749f1547ba63241f7519c8e654c749146f07e575dc09af0afd8d7f695b5f84bf16ffe15bf8bf545b7f879ad5c6dd3ee679098f4dba2d81f313f247264641c056e7a1623f543e3dfc20f0cfc6afd9fb52d0757b58daf05bb4ba4ea0aa3cdb498afcae8de99c657a30e3d08f9f9de8cbd8d7d63dfaaf3479d563cd59ce95937f73f27fe7b9d3e8de3ed1fc7fe17875ef0deb763ade992604b3d85d24aab263e75f949c61811cd5eb9976c6b6c41df2a06607b264e3fefa208fa03ed5f867a67c4ef0b7873f674f0ae91a3ccfe09f8a7a64cf6da8eab632bc33aa447058b2b063b8639e809238005757f0d7f6d1fda46317493785cfc5ed39272ab7c9a24a93851f2a2992dc04e1540cb213dce7be2f07294e5c9d3be87d3622953c06128d494d384d26adbfcd6bf33f7274d658b488907071cfd6ad497091c0d239c01d49afcc8b2fdb37e375de8fe5e9ffb2eeba2e82fdf91eee4407fdd5b507f0cd799f8b7f684fdb53c53693c1a57c356f07db11f2f95e1db83281ff6d83127e8b5cf1c0e21cbde692f368f9e9d7a1293925277ec99f4efed53e2291ff67ff13ea11ea7fd99696ebfbd9506e95a22ac8e912e46e760d80b900e7920735fcf9fc4d13ea9e3ed53c53625aefed8c1eed157e6494280cc064e5588dc319c648e715f4bfc42bcf891aa789a383e2b788b56975477263d3afade587631e40d8eaa17db8fa54df0a7e054ff0016bc6b7f0c778fa3786b4f2bf6fd556169e52f9c08e240412490c33fec9fa1facc2d2584c3da52ba3e7b1955e3710bd9c1ab2b5ba9f3b69da85ac7f086faf96556b890f950c43efb00362003bf000afa57c27fb3a7c45f137ec6afe33d54c3a768d059bdd6956578eead78d02972628957196d8f876e58fb723ee2f869fb19fecfba3ebabaef88b57b9d4e4b4712343aae2d95f1c9f90aab73f535f64f8df4dd3b56f0d785db468513414b982d6da08144712a16014018f941daa83d013eb44f1316d4699d580cba589c5c28d47cbccec7f3ad67ad585aebfa7c37f8789e19142b0fc33f86e1589aed88b4f1447ac594cf36e190d03f9855c0c2919618e38ea2bdbbe3c7c23bdf05fed83e35f0f456969a7c4939bd82c6e2e13fd0ed6655b858c1fe2da182657a94c75e2be7668aeaf2e8bdbc11dbdb03b1034bbf320e4283d4647d4706bad34d2b1cb2a15296b3568b6d27dedbdbb9d069c3c45e2ebdb4d36eb56b992295b2e2ee7d891104fa9cb63d057e807c2cb0d1f48d22cb4c06336f6d6eb1c44f3c0ea78ee7935f9d3345ac41abddcb319905c5c1334319468c8279ea71f8d6dd8eafe37921ba8bc3875c78e07ff475b659657c03d08048c7d0552765a994e926db83564edd9fa9fa59e37f08786bc63e1fbfd06fad56f74cba4dacadd50ff794f623b1afc67f89de04bff879f13aff00489fcc96cc4ce2ce7231bd558ae0fb8c7f23debefdf833e32d4f4dd17546f18eb657529dd4db69b70dfbe85541c9653c82c4f43fdd1eb547c7de1af0ff00c54d23c4b63330b1b9b8b78f53d26e6e57cb78a52a5195b3d012833f5cd5a38daba3c6bf67bf8e56b1f84353f83ff11426ade0dd66dfecd6e9764158ce7e540c7ee90dcc6e31b5b8cf20a95f1e6a5a75f68be23b9d3afe1682f2da5292211e868ae0a98594a57a73714fa591dd4b16a10e5a90526bab6d69f23fb5dd134ed3355d5a11630adb7817c36e63b08872b7972b9df3313f7829ce09ce58939afceefdb13f694bcd2fc403c23e09bd09e2cd46d98dbddab71a3593655aeb3da6979119eaa8370e5973f5ff00c79f885a47c2cfd9ca2d2ed9c5b59955b66c385678c29678c1eceea0aeeec5c31e01afe7d7e2aeb3ac789fe2fea3a80b87bad6b5471737d3aa1e598ed8e345ecaa30a883a00076c572463edaa5feca3de9d4a7f12d211d12eb6ff37bb7d3ee38df12595a696f3a45a82ddbcb0932bf3b896e79ebce70727ffad5ee7f08bf670f895e32f0d5df8c75bb39742f0e44566b9b9bb8d9ef248430df22c5c1caaee6f9f04e3e543915f427ecc3fb35e8e3c471ebdf1111ae7c496be55cc36333652281b3b240dd19b723a96fe12a42e321dbf477e207c5af863f057e16c52eb2e8b27947ec3a2d82069ee31e8bc6d19eacc40fa9e2bd78c3ab3c4a98c945b542f14fa5f43c57e167ec7ff0ca1d62d27f105bb7885f868c5f32ce8e3b12ac3cafc5635afa27c4be03f0c780f5f8aff4fd02d354f0adc5a88b55d163b886364963c086e6312ba464eccc6ea5812ab16dfb986fc8fd77f6c1f1c0f19cb07822da7f09e90b11b6b6d361b96bc96046751192653e5c414ed4042a603e3918af9fbc49e38f1d78a3c5515f78af54bdbd91e4f985f5dc973321e1b0a09014902518c1c32639cd69a23cf94aa54776cfde58b54fd9b2fbc351dfa5e785b4394e7635c5cc369346eac54ab2b30218329041f4af907c5de16f84fa8eb377a2eada7e9de26f0a4d79ff00127d6b48b982e0e9fe73002ddb612d18123111b01b42b2ae57682df991ac699e3cb9d36dbed10eb2b6e1da39e73a5b79649661e62b14e57e68dfa9c8dfe95cde9f2eafa6d85ccb16a46c6f8aa9f2eed4a60ecdc0020ae089536e7d1c1a574c69548bd0fa27e2c7c0987c333dfdde8d29d6b4046ced9b1e6c511ef9c90c17be4f419f6afbe7f62cfda027d6bc07ff000a6fc5fa9bddebfa2db1fec4b9ba7266b9b35e3c96279668b8009e4a63392859bf2b61f895f1374880402f2eb5dd2dcb2886e11ae51d73c01bbe61952a4056efdf06b49757f15f87fc51a1fc51f0bda5df87fc49a14eb74b1cb1314980fbf1b13f7815ca9cf24360e4824f16268471149c7af43af0f5e54ab29495d753ea6f855f027c3bf1affe0a43e2c3aadafda7c19a35edc6a37b6ca70b745ae5bc885b1fc2d92c7d4211debf6c343f0be8da1f876d6c6cb4fb7b4b6822090c30c2a91c4a070aaa06140f415f9aff00f04e1d42d358f03fc4ef10be0dedceb16d1c8c7ef6c4899947e723d7e86f8a3c650e90b05858dbc9abebb764ad969d6c417948ea493c220c8cb1c01c77201f99c65493c4383da364beedcf668c2a3a11f67a735db7f3d8c9f1bea1a6e95a349968d6773f20ce31ee6bcffc3fe09d7fc47abdb6afa93cba268d1b992381a31f68bce382c0ff00ab4ee171b8e06768ca9f43f0df826e1752ff008483c63751ea9ae39dd1dbc7ff001eb65e8b18232e47f7dbaf501738aefaf6faded34c9ae247548a35c926bcdb23d478a9d38aa547de7dcfc6eff829147a468fad7c3782d513fb6d56ec97007986302309b8f70199f1e84b7a9af6efd8d7e1fad8fecc3e1b78edd5aeafd5aeee4ede57928013dfee93ff000235f007ed9be3d6f88ffb6aead7305c79fa3e9423d234e2a7e577525a561eb8964299ff0062bf6a7f66cd0e2d33f673f0c04550068f6aa081d7f74a49fc4e4fe35ee5753a580a707d4e0a3523f5dad5b7e556f9e88f4597c11a54fa4049aca3336dc17dbcd7925fd89d2bc2be28f0db8f922b537f619fe131b07207e233ff007d57d33390911e39ec6bc13c7f6e3fe12cb3943f96df677538fe2deaf1e0fd4486bcba12b578c4f5b035a73aaaa4fa4935f267e33ffc147259acbf6dad1350b8b758e0d474044561c09190960d9ffae73c40fb8f6af8212536cb6f3595c34693329ba254158c86e0e3fafa1afd39ff0082a6e8cc7c3bf027c52a98db64f6b3381d4cb042cb93ff006c1abf2bf4d589c6e95e5881e1fca6c6e1f4208cfbe3f2eb5f614a4a31499f3f5b0b56aca6a0af66d7a6a7d67e019f45d534e48ae2ced27bc8db0ecc8ac587d4fa7f2c57d07a6585a4764ab6d0c5127f75142d7c9bf0eadf45d2a12fa63492cec77cad337ce3e806063f0afa6741d4e1b98555589191b883c835d37b9e47235f12d4d2d5bc3d63a9db7d8f55d32df5081c7ca27855c2fb8c8af0bd5fe1d368dae6832c72c9a4cf7770f6971f6295a4818323320f2e5dc0676004003ad7d146fd85c888b6f810e327d4573ff104f9bf0ca4d451712e9d3437c8dff5ca4576fcd430fc69a6672563e2cf8c7f0975cd7bc3d3f8aec61867bbb1422e145bf913bc6bc72a0b2b7038208fa73457db163043776f22cb109619a329221190ca78228abb9ccd5d9f51fed59e2cb9d7f55f0fe937501b18eda17be92299c33ee62d1a31c1201c79bc027822be72fd9d3e118f16fc5c6f1b6af6fbf47b4999a0120cf9ae0ed2def801907a61cf5da46bfed49e239eeff6bef15f86ed9bfd220167636c3a81ba04933ff7d4bfa9af4b1e20d6be09fc1182d6c2cadeef4b8ed2396de6bb9f1f6490afcd0ba8f9a4cb60a918fbce091b543f2d08a50477d7a965ca8f60f8ebe2df02785fc2da45a1d0f4cf1078b5a06fb35bde5a47347611b606fc3038ced042fb0f6afcc5d77c5d7be32f12de69d65a87daa3b48d449a9cd39691e346d9e4a39270015319901dcb94f77385f107e226b5e32f17dcdbccf3dcea9abcdb6ee643c0ce3f728c0e54b292a8703a0e064545a76b371f0eeda6f1043e179f55974f31cb15fbda836b6d23ee885c391c179360f90fca1909e4e31d32763929c399dd9f547c20fd99e3f16ea56235ed4a3f057872e5448cb711aadede2326d2c636e22124642b34833ba3565520e6bbbf1ba7817e17f8c2f7c35e09d2ed22d46da22b26a3227daef667fe2dd2b9c81d49c617fd915f076a1f1fbc4d7da6dede0bd9c5d4e0f9d299887909f53dfe95d45bf8f34fd3ef2d6c6e609b56b892dade7d4a72d95b999e3590e59bf8177602f3c8c9e6b0773d38a8ad22717f157e27dfdf78a67b593539ef5d0fcb15bb0f2c727ab60276238cfd6bc82cb5df12ea17ca9a659c93a67252cedda790fa6e63d3d78af65f1d7f60789bc6963abb59c16d6902fcf6e8a0ab7fbcdc0c7b1abe9e3fd2ecec52cb45b7b6815171fbada42fe4715574918fb3729fbccc3f87fa4f89ee3e2c5aea9e2cb392d74ab705e28ae261f331e9f2e4f419ea0738afadb52f157879fc3b0c305bc31c88c0e48047073f8d7c5ba9f8da717a65bab9010b7de23fc2ad5e78aa283c1b3df19d64c464c454fde3d87e753ab34ba82b1f487eca7fb487853e0178f7e29e99e25b99acbc33a83349a6bc30bcade75bc922c71055048de8e46e3c0283279afa9bc3dff0515f85da56a9777763e0af12f8875ab85ff4ad4eec5bdac4141e238f323b2c609e320124e48c9afc7f36b14be12b7bc90879c3798cc464924f3c77e4e7f0af40f0e6a9a4c3a6d94725a2476ca372b2afceaaa7e67271cb31c01e9c75c6daf36be1e94e6e5257b9f5794d0789a2a12a965e9afe27eab5effc147b5392f3cab0f85d64e18ed559bc628843609c1dd6ea0100648cf15e3df133f6e7f8a9af7c3ab9b5b5f04a784ac6ea3c36a505cfdb36a1c8ca489f273ce0f1f5af936cafb45d62e7fb2adaceda3b8bb7f26332642216fbec71cf971a0e83976f5c04ab1e20f04d8c5a7ead63e13df1a218a19af241ba6ba9cfcb1431a2e7e6620b045e14038c855ce54a86154afc8b4f53d0c6e5789a714a855d5e96b25f8afeb6dcf22d535b935bf1269337dc3f6a4655ce42a861fa924927d41afe9e7e095bfd93f663f06291863a35ae7f0812bf98b974c97fb458cf6e2cf5788309517044cb82be680380c09c90383d47ab7f457fb26f8e61f1afec15e00d53cd56bab7d3d6c6f141e524b7fdd1cfb9081bfe0429e62f9e8c651ee7c752c356c34e746aab3ff267d2972e360cf35e23e2f3f6af1d2a03fbbb7b196694e33b44714920ff00c7820fc6bd5efefa34b62777415e656b68da9685acead2a9dfacde47a4e9c73cb23483cd61ed84c7fc04d7cee0e0ea62533e930f0f6518a7d5afcf5fc0fcd6ff0082a10887ec55e090c409ec3c4fa65a9c8e413a65c391f93035f8c367213a7c449c6466bf647fe0a8f29b9fd8c7449570af7ff13d9e1f78e0b3b8853f0da13f3afc53d27520d12d94e76cf1ae067bd7d334dd3ba35ca6bd3788929eeff53d6b47d7c5b4f6f891ada743849d7b7b11dc57b6f867c67241adc42e3114a705c67e561fde1ed5f324203a2f1d6b5aebc4f0f8774553a8932e01fb2a29fde13ededeb5546abe6e53d0cdf2ba4e93c441a8db7b9fa11f69b43a349a9cd770da58a279934f3481123039c963c01ef5e3fe30fda7fe17e93e0bd4fc3f656775e36bd9edde06369886d97702a7f7ac39ebd555857c13e25f885e28f16db4567a9ea72ae930ff00a8d3e372214c74247f11f739f6c0e2b90032001d2bd751ee7e5b52af36c7dcbf0c7f69bd3a7bcd37c37e23b483c3a182c29aa4ec6788b74064c15283df047a9039a2be197450093c5158ce94e4ef19b5f77f90a352296b1b9fb29f1c6ff499bfe0af5a83417b0ea3a0dfdcdbdcc1736efe64720fb0c21791feda95c7a8c554fda2fc7336a5e19b3d3eccb3c0bfe913228e5b1c2a8f727a5787ea3e20d3bc4df1c343d6a6778ee6264865e5430466da482a7a8de0e7a8db567e23db666b6d22eae66d425bbbc4dede73c6ae1327850db573b5541c637303c64d694fdd8245558b750e27c2565abe99e0bd6bc4bf624be9ad1e3b9135c26639b712eb111d7e4c48a473c1c7715e6da46ade287b5d4fc2ba4eeb7d075bbe5b8bcd2a072d1cab1bef40c472554f4f4c9f5aeebc47e3eb88be1d3e81a54523d95c4ec6e678e0204f230cbb7b310aa08ff64f4cd5ff000979da6fc3469744b09354f1d6bbba1b48e188c8d696e07ccc00ef8e7ea7fd9ae7a95234d7348f732ec0d6c7d654a8a6df92bbf9232bc3de10d0f53d67fb0ef2e5a3c0cdfdc4281cc23baa8240dc79e3381df38af46f15695f09b4db3d3745f0c586abacde42ab1de5f6ab7a250580c055403002e39da87d335c67867c29e23b3d3e45fb3cb0a4d3c9be49e1db279abf2b00ddf07b03c63a57ba7c2df0fc5a1eb5afddf88bc1163e248aeb4d7b6b09751b8665b1908c0956343f31518c6e231838eb5c32ab371e686be9b1fa8e5f9250c3c9c719174edba92b4bfe1bb6df23e52d7b4fb5d4a548ed349862891ff7a63c128067390071c026a0d0f4d3e06d574ed7a5d22df588a3c3dce9d725962b88fba12bc8e3b8fd46457d0f71e1bd2747b85b1b650c1a4cc8e705989ea49fc00f61c5717e375b55d12f262a04514440f7e3a0aee85ecb98fcff003654a151ba5b5ddbd0e77e11782748f8b9fb49be81792ae93a45c5a1be86157dfe4a9c3045ddcb901b6e3d093fc35e99f17bf653d57e1dcafa969d74faa783e7c34970031fb11ec5d72484ff006b271dce335e29f03aff00c6be1df8ad1f883c2fa77f685d59dbac376bb0f96b13b04c3b60edc91c3762bdebec7f147ed87a6ebff0e6ef4397c2f78b236959bb8677453197000079c1077a9c8e70c38ce40ea4958f8e7394a573f3fa299aceeae74895c4e23919094390c00e83ebfd6bd2adf5593c3de1d816f348b7b98d97e5df079720f43bd73fc87b77c723a6e9f16a3aa5a1768d5d99524da30029e081e8304d7d0fa878721d57e1c6877f6780b25ac5bd7927253249cf39ce7afad164ceaa788ad41de0ec798db6b36c2fec755d36c5edaea42c9034d112aacdd4871f29391c6ee7dab6340d5359d07c46adab5cca6299d920bc0a5de2328c4a513fe7aba8db9cf40003f74a7e937c3df87be0297f606d0dbc51a225cf8825325be931d9449f6ad424666d916d3c38e0e4b70a8acc48504d7867c40f815aaf83bc3f0dc6b36e24b1b952cdf634668e2cf685bef3051d54fcc704ae3e541cd528a6b43e9b2ece6a53affbe775fd7ddfd3df53c1f56d26c75dd2ff00b434b8d6db50b745916deddf2b0263f751bb81996790e58e3000c9c01911fd25fb0ffc721e02f8db37c30d6ae843a0f8a66df60aed84b5d407cb85cff0ca00518eac13debe44bad565f04f88bc8499a4d3e7422196d8ee211c60f97cfde65c82c4e793f5acd4d06cbc47f1cfc2d3af8bb4ff000224daa471dcebf7b73b6cf4c65c36d8d946e94c4a06f9384dee0654618f9f28a945c27b3fcfb9f7599d3c362b0d1ad41de51fcbb3fd3eef25fd28456f73e24d523d2ad5da34719ba9d7fe5847dcff00bc7042fbf3c806b6af1ad13c4127f66a2268fe17b436f691afdd7bc75db8f7d8a40fabd67782353d1355f82625f06f8aecb5a8eeadc81e22b39a2b959e5db832feec95ebd003c74ae7f4fbbbdb651e0eb986d84d6616e1a6b5999fed5e616daee1b90e5812793d0638ae1a308d283b6e7c6f34aad2a9593d62ac9764f472fd34ef73f2ff00fe0a9f0ad8fecf5f01fc3a8d87bcd66fee80ee4431431e7ff2357e36dd7863ed16c5a3cc3768498641dfd8fb57ec1ffc155751864fda23e0ef847703fd8de189af5c67806e67f2ff00f6d2bf362d3497bab5b731283b46e271dabdbc3c57b1573e5255650a9cd16789c1e208ec34bb84bf8cc77f6bf2984f590f6c7f9e95e75a8ea377aa6a8f7777219256e00eca3b003b015d4f8ee39dbc6525e1b47b6b19495b491c60ccabd5f1d7049e0fa62b8c5424fad6f4a8c69b6d6ecebcc335c463e11a737eec7f17dd8c0724718156c3044e467daaddb589752ee36a8ef5bfa2e8535eead1086033cde60088cb953ed5b4a518ee795470f5b10ed4e37b0df0e784f52f1278874eb38a171f6cb810c2c50ed2d82703d4e07ff5e8afd04f07e87e1ab2f80d61e22d2e13ff000916937f6da8c776dc3aaa3ec923dbd176ee39ee7af6a2a7989e4b6e79f411f86e1be6b8b778e37652a6488a9233dc52f8cb5db8bdd1347d6a0d973736b3cb16e957313318c9219464b02030da4632ca7915dacffb3e40d72c90dfa919c65a275ffd98d729ad780478075ad1ac6fef164d3b53be88b989d8988c7229dc41ec41287d9bdabcfc2e1de1938f336bccfbce24cfe9710548d6f60a94d6978ecd7a58e6350f8c7abf8a7e1fe8be056d234dd0b4b83c430eaeb0e9566b6f14732c02077555e17728dc40e09624f5afa2fe0569dac697e0ff001378c3c2b71696dab691a54a97b3ea0a0a0824002ac4bd376e47e7a76f6af9df5af044be1bf8bf7ba04ef0dcdd450c822689d5831f2db674fba4f1c7ff005abdc3e1c47a7bf80a396e62b8b9f15a6a705ae99a7c72116d3812090a4d8e0e72f9cf41faf979b4ed0825dcfd47c2cc3d3a98cad3a967251d2eafa5d5ff000fb8f7ab5f097873c5da8785747f87da25cea5e234b396e75d6d5a668a3791d4832a9c1018b1272a3b76af36d46caf2ffc192e85ad6a71dafd82f8aea305ac85c5caa3baf96cc0a900943c8fee8af67d77c4571adf8dfc59afeb9a80f86face8fa425ad959e973c67ceca970ecc579c93b4018e87ad7c51f10bc6a2ff520fe1bd1bfe11d84d8c705c2c99125ccc325e5707e6c92ddf938ce79e39f071fde5a3b3dfa2edb7467ea7c673a31cb54e7eed456e55bcb5777afda8db6d2cad629c7aad8d9df1d3ec24636b6c4a46cefb8e3bf3f5fe55cb78b7565b9b036caf955f99f3d33dbf2eb5c24f757da5f1790cd048e9e6a1910a9753d1867a83cf358d717725f69773bee0c27cadccc064924e02807d79fc01afa5859c6e8fe3dc7c6b2af28d44d3ecf467dd5f02bc49e14f03feca9796d74914bad6bd76d77a83c83f8554a41093d955497623ee9727a57c3be3ff10c5e27f8c3e21d4f4c431e9b3cea96a07cade4c43cb8c9c7f1155527dcd508b5bd623d1e5b19aee71bc6c40587dd6ebd3a7e1fd48ad3b0d263fb1ef2b8e326b56d1e5d2a12948c9d2b5492db4bb8b17b5692e9c86b7bb572248c8e4a93fc408071dc1af66f0978cb50b7d3adb4d9efe3312228114f1959136a9f978386e8cbd739523f8481e4e22583522f1c61c2e4b02e140046cc927a01bbad6dcab6cf6a6cd02c51a01b980db923a0e7380bb38073829939f2cee7195cd31187951b5fa9faeffb2e78af47f115dc4bac5ec77d7d6b00834f75388eda3c82f12a924ab3100963cb607602beeaf13d8e81e22f025de8dabdb4575a7cf16d656c6578e194f623a835fce8fc36f1ceb5f0f3e245a6ad677b2d94024003282d94ce0075272c0b700673ee4abb2feb2fc3df1c78bbe2a787869adac58e94e02aea1776770de7daab1e7c98ca9572578594b019f9b61c14ad8f31ab1f2a7c74f81d7c9e1af196abe15b5935bd03412cfa8df47f76293866083abb20f9a60385c83f783e3e14b0bdbcd4bc3136936f0aa897093dcb2e6531a9cac484f0899f98edc6e3d49afe95f4fd0340b2f85e9e1dd3ad21b4d2ededfcb8223f301eec4e4b12492c4e4924924939afc1df8a7e07b5f875fb44ebd6d6312db68d25dbcb6b6ea3fd446ce47979f446ca8ff6766735cf5209ea7d265f8baf6749cac9fde7d59ff04edba860f137c40f87faa028ad6d1eafa74b14a62921656114db59704677c3d0ff000d7e9dfc36bb31fed08f26bf7be62dcdb2c71ddcc30b34d0cb2204cf40c41538e33dabf1d3f64ed6e3d3ff006fbf0fc71cbb22d434cbd82423baadbb4c463eb12fe9eb5fb3d68965e12f87bab45e33b7fb2e99a85acf76f34a41f230af33237f75d54310464654f39c03e2d48dabb6f6691ed53ab4b0b4dd29af7649c5bea9369a6bbd9af99f893fb7f78c7fe134ff0082ab78fa286e05c59e8ab6ba3db6d390a22815a45fc26926af9f74f8667d24dbdbc6c659008d768e707827f0193f8572da86ab79e29f8a5e20f14ea12c9717baaea53de4b24adb9d9e590b924fe35f4afecfba0c1ae7ed05a169f7b109619e0bb555c0396fb24db7ff001ec57b515c90b763e1e7673693ba3e1df1b68ba86adf17f51b155e6c6dd57633636284f31bf99ae2edf478c5e143f3953ce2bea6fda43c01aa681fb7778bb4bb381d22ba4b6bab60a3ef23dba723fe04ae3f035e1ba6e9d25bdede5b5cc6639e36c1561cfb56d17749983dce745b093508ed635c72381ea7a57d51f097c0b14ae97d2c41829d8808ebd0935f34c20587c46b43367c8946727b303823f22a7f115f7a7c239edadac4473baf93201b1bb035f3599d49c363fa038070586c4479a5b920d164d13c45a968a772e9dad5bc861c7449f67cc3fe0439faad15ec7e2cd185ef82e5bdb500ded811776e579e633bbf51b87e3456b81c642a505cef55a1e171770ce23039c49e1e1784fde565b5f75f7ebf33a1d4ee61b4b692495844a8bb9a46e0003bd7c51f12bc457de2df15c9736692c1a5447ecf14e22f319ce71f2216504e4f52ca07739e2bd5be36789afb4cb1785099204059d43952f852704fe18af07d1bcdf19e8123dfcc6d608c0f2e1b650026064019fcbf3af6b63f29e5e7394f106b50693aee8f3c17126a9aea224fab5efdb566867949dc447b40daa010a725b2790474af5ef00eae2fbc6d71a7dbea52d9680dacb5f4302394d85ce43e47cd9dad8e08e2be779a08f4fd37c451430412a8b885049345ba440439f95b236fdde7839e3d0577df0ca3bad43c4da618ef1ad1f051dd5031608463af7c301ff0115c58a742349ceb2bc57ccfb6e1979a54cd69e1f2f9b8d4a8ecacf96fe57bad0fd32f15f86bc016df0b535ad2fcb1ad5c22c4d7126f92eee89180809cbb67a01935f36df786bc1bf0fae47897e21db26a1abb2f99a5f842271b89fe17ba61f717becea7f3157b56f1e6a9e1bf1d5b785747529a97d8d64935dba93cfb9556e0ac4a46d88fb807e83ad65695a568faa687e31f1df88ac5f5cb6f0dfef7fb2a5b8206a12ed0dba69482cc39fbb8e71c9238ae05554a9292d22fef67ee92c1ac3e3e58794bdb62617726efc90b6adebac9af2dcf09f883a378875dd0dbe20f89221a7a6af218f45b348f61b8033931af6897d7be7f3f086d3752b5badf2dbbbc618372319c7f3afafceab7fe3dbf3e2ef134ab797cf188ad6dd13641650af0b0c29d1547e67bd61b68d61e21f8bfe13f0dcd08b7b2d435786d67641cec2e0363ea2bbe9c3d841b7f7745e47e359ad6a39de6908d2ddbb393f8a726fe27dbc97448f9a6d2caeaef5612caa001ce00e95e9b656f045a3b248374a3191bb04e7a0fc6bd33fe10ad0e5d57e39dec109b48bc3332a69d6f19f9406ba3173f455fd6b17e1ef80a0f1aa7881eeb5396c60d2b4a9af1638a20c667540c0312781dba74acfeb31507292b6df89ecd0e19a94b1b0a549aa8e4e4974f864d3dfbdafd4f3abfd11a3d363926c799792985427206d28e79e9e82b0174e96cfc4505b5c48ab6a72eaa4e0b1182413d946031fa02410b83de78875093c3fe26d47c26228af23b1bb6b38ae1815da7cd566902e7ef10817924019ef82190c56f7ff10b47b1b985648a6904649eabbd586e1ee08047d2baa94af152ee7c8e7b150aee85ace0daefb37d7aea76763e0e8758f0ab4d3b245b62270c0800631cf704820103900841f33311b9f077e24eb5f0cfe31d8a432c97b6d1ef458e43833459c3a71c000fdde801010676d711a3eab751691731c8ed2c36c256281caf99e5aa9ebd467ccc03d47cc79662c37f53d02d2fefede2b8c193cc90348235c168e343b829181c4815474400e324ee1d699f19249a3ef9d67f6a492e3c3537f6530472bb42a3866624642819ebf5c00324e00247e7a7c59f1dea1e30f14cdadcd199e58b10dc323131aab9db81ebf3153b8f248cf030a3674199affc0b1a1022dd23408547289f2b6d1edf374f6aed7e29e91a3fc3efd9afc3761a7e990df5ff00892ec49757b739cc6b6ee9284551fde60bce7800fae45bd8ca2dc1dd33dabf606f862f27c63d3be36f8d8c5a4f8674f827fec5376db5af26c7965d17ab01bd80e08241c7238fb07f6c3f8f3e00d73f65ef187873c31e35d3eebc54a4589d22dae00bc5676f2e5578cfccb842c0823a6735f99bae7edadf18351f0469fe1dd2f4df08784ac6c6c858d93e91e1a40f0423a2a999a403f0039e7ad73de00d060bab4b9d6f519df52d52fa679ae6e2719692463b998fd49af395073a9cf2d2c75cebfbb65a9e77a5f87655b88a3319de3a2e381f5afa4be19bddf817c53a378a6cd167d5b4ebc8af2da2947c9218dc3846ff0065b183ec6a941a65a2cf248231c1e00e2b611f61814280030e2bd0b2b1c176cfb0ff006a0f855a1fc46f81be06fda23e1dc1f6fb7b0b256bc5080ca74d9096fde01fc56d2ef475edba424e12bf2d3e25f81db4ed42d3c43631136b347893033b909c83ee54e41afd1cfd987e2aebde11fda9f46f8412c71eb9e04f1ac77323585d1e34eb8485a47922e08292aa6d7888c13b58104306f3afda3fc07a47c3bfda2754f86ba5eeb9f0b6a9a5ff006ce990ca3e7d28bbba9811b277a02848ce085214e71b8e30f75f296f63f30f50d0e0bfb725898dbef2c8ab928deb8efe847f80aedbc0fe35d5bc19a85b597886dde5d2666db15e45f346fee0fafa8ebec2b3ae008b5c9ed00ca29383f8d6ae9b726c5e588c315e594a3fd22cee63df14c3dc763e8c304763515e842bc6d23e8327ceb1793575528bd3b1f71f823c67a36b7a408a0be8af6d5fe50c1b3804743e9457c9d3e829e13b7f0f7897c377d71a75b6b4b2b7d81dfcc16e626008dfc6e53bb8046401c96eb457c655cbe74ea35191fd4197f17e1732c246ad5a577b1fffd9, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_bcctacontab`
--

CREATE TABLE IF NOT EXISTS `tabt_bcctacontab` (
  `cod_compconta` decimal(4,0) NOT NULL,
  `cod_ctas` decimal(4,0) NOT NULL,
  `cod_cte` decimal(4,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_bchistoriabanc`
--

CREATE TABLE IF NOT EXISTS `tabt_bchistoriabanc` (
  `codhstbco_hstbco` decimal(4,0) NOT NULL,
  `cod_ctabco` decimal(4,0) NOT NULL,
  `anio_hstbco` decimal(4,0) NOT NULL,
  `trim_hstbco` decimal(1,0) NOT NULL,
  `mes_hstbco` varchar(25) NOT NULL,
  `saldo_hstbco` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_bcmovbanc`
--

CREATE TABLE IF NOT EXISTS `tabt_bcmovbanc` (
  `cod_mov` decimal(4,0) NOT NULL,
  `cod_ctabco` decimal(4,0) NOT NULL,
  `cod_ttrans` decimal(4,0) NOT NULL,
  `cod_tpago` decimal(4,0) NOT NULL,
  `cod_ctas` decimal(4,0) NOT NULL,
  `cod_compconta` decimal(4,0) NOT NULL,
  `cant_movbco` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_bcpagoprem`
--

CREATE TABLE IF NOT EXISTS `tabt_bcpagoprem` (
  `cod_ctabco` decimal(4,0) NOT NULL,
  `codprem_prem` decimal(4,0) NOT NULL,
  `fechcreado_pagoprem` date NOT NULL,
  `cantpag_pagoprem` decimal(4,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_bibitacora`
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
  `host_bita` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_cpdcompra`
--

CREATE TABLE IF NOT EXISTS `tabt_cpdcompra` (
  `cod_compra` decimal(4,0) NOT NULL,
  `cod_prov` decimal(4,0) NOT NULL,
  `cod_catprod` decimal(4,0) NOT NULL,
  `cantidad_dcompra` decimal(4,0) NOT NULL,
  `valor_dcompra` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_ctmovdiario`
--

CREATE TABLE IF NOT EXISTS `tabt_ctmovdiario` (
  `fechcreado_dro` date NOT NULL,
  `codpartd_dro` decimal(10,0) NOT NULL,
  `cod_ctacont` decimal(10,0) NOT NULL,
  `debhab_dro` tinyint(1) NOT NULL,
  `cant_dro` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_ctremune`
--

CREATE TABLE IF NOT EXISTS `tabt_ctremune` (
  `cod_remu` decimal(4,0) NOT NULL,
  `cod_compconta` decimal(4,0) NOT NULL,
  `cod_emp` decimal(4,0) NOT NULL,
  `cod_compconta_1` decimal(10,0) NOT NULL,
  `mes_remu` decimal(2,0) NOT NULL,
  `anio_remu` decimal(4,0) NOT NULL,
  `salario_rem` float NOT NULL,
  `diastrabajados_remu` decimal(4,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_ctsalarioneto`
--

CREATE TABLE IF NOT EXISTS `tabt_ctsalarioneto` (
  `cod_slnet` decimal(4,0) NOT NULL,
  `cod_remu` decimal(4,0) NOT NULL,
  `cod_descempl` decimal(4,0) NOT NULL,
  `salariototal_tlp` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_feddocumentos`
--

CREATE TABLE IF NOT EXISTS `tabt_feddocumentos` (
  `cod_catprod` decimal(4,0) NOT NULL,
  `cod_docs` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `cod_bga` decimal(4,0) NOT NULL,
  `precioc_ddocs` float NOT NULL,
  `preciov_ddocs` float NOT NULL,
  `cant_ddocs` decimal(4,0) NOT NULL,
  `valor_ddocs` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_fedrsva`
--

CREATE TABLE IF NOT EXISTS `tabt_fedrsva` (
  `cod_rsva` decimal(4,0) NOT NULL,
  `cod_amb` decimal(4,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_feexistencias`
--

CREATE TABLE IF NOT EXISTS `tabt_feexistencias` (
  `cod_catprod` decimal(4,0) NOT NULL,
  `cod_bga` decimal(4,0) NOT NULL,
  `cant_exis` float NOT NULL,
  `cantcongelada_exis` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_fefraim`
--

CREATE TABLE IF NOT EXISTS `tabt_fefraim` (
  `cod_imp` decimal(4,0) NOT NULL,
  `cod_fra` decimal(4,0) NOT NULL,
  `cod_srie` decimal(4,0) NOT NULL,
  `cod_suc` decimal(4,0) NOT NULL,
  `total_fraimp` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_nndnomina`
--

CREATE TABLE IF NOT EXISTS `tabt_nndnomina` (
  `cod_nomi` decimal(4,0) NOT NULL,
  `cod_trans` decimal(4,0) NOT NULL,
  `cod_emp` decimal(4,0) NOT NULL,
  `diastrab_dnomi` float NOT NULL,
  `diasnolab_dnomi` float NOT NULL,
  `totasigna_dnomi` float NOT NULL,
  `totdeduc_dnomi` float NOT NULL,
  `suneto_dnomi` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_sgasignapppersonal`
--

CREATE TABLE IF NOT EXISTS `tabt_sgasignapppersonal` (
  `cod_aappp` decimal(4,0) NOT NULL,
  `cod_usr` decimal(4,0) NOT NULL,
  `cod_app` decimal(4,0) NOT NULL,
  `fechcreado_aappp` date NOT NULL,
  `fechmodif_aappp` date NOT NULL,
  `insert_aappp` tinyint(1) NOT NULL,
  `select_aappp` tinyint(1) NOT NULL,
  `update_aappp` tinyint(1) NOT NULL,
  `delete_aappp` tinyint(1) NOT NULL,
  `imprimir_aappp` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_sgperfilapp`
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
  `estado_papp` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabt_sgperfilapp`
--

INSERT INTO `tabt_sgperfilapp` (`cod_papp`, `Id_perfil`, `cod_app`, `fechcreado_papp`, `select_papp`, `insert_paap`, `update_papp`, `delete_papp`, `imprimir_papp`, `estado_papp`) VALUES
('1', '111', '2', '2014-10-01', 1, 0, 1, 0, 1, 1),
('3', '111', '3', '2014-10-01', 1, 1, 1, 0, 0, 0),
('12', '111', '17', '2014-10-01', 1, 1, 1, 1, 0, 0),
('20', '111', '1', '2014-10-01', 1, 1, 1, 0, 0, 1),
('21', '111', '4', '2014-10-01', 1, 0, 0, 0, 1, 1),
('34', '111', '10', '2014-10-01', 1, 0, 1, 0, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_sgperfiusuario`
--

CREATE TABLE IF NOT EXISTS `tabt_sgperfiusuario` (
  `cod_pusr` decimal(4,0) NOT NULL,
  `cod_usr` decimal(4,0) NOT NULL,
  `cod_pfll` decimal(4,0) NOT NULL,
  `fechcreado_plfusr` date NOT NULL,
  `fechmodf_pflusr` date NOT NULL,
  `estado_plfusr` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabt_sgperfiusuario`
--

INSERT INTO `tabt_sgperfiusuario` (`cod_pusr`, `cod_usr`, `cod_pfll`, `fechcreado_plfusr`, `fechmodf_pflusr`, `estado_plfusr`) VALUES
('1', '1', '111', '2014-10-01', '2014-10-01', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_sgsesion`
--

CREATE TABLE IF NOT EXISTS `tabt_sgsesion` (
  `cod_ses` decimal(4,0) NOT NULL,
  `cod_usr` decimal(4,0) NOT NULL,
  `sesact_ses` tinyint(1) NOT NULL,
  `fechinic_ses` datetime NOT NULL,
  `fechfin_ses` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabt_sgsesion`
--

INSERT INTO `tabt_sgsesion` (`cod_ses`, `cod_usr`, `sesact_ses`, `fechinic_ses`, `fechfin_ses`) VALUES
('1', '1', 0, '2014-09-28 08:40:03', '2014-09-28 08:40:23'),
('2', '1', 0, '2014-09-28 08:40:35', '2014-09-28 08:41:02'),
('3', '1', 0, '2014-09-28 10:16:51', '2014-09-28 10:16:55'),
('4', '1', 0, '2014-09-28 10:39:49', '2014-09-28 10:55:19'),
('5', '1', 0, '2014-09-28 11:21:51', '2014-09-28 11:22:46'),
('6', '1', 0, '2014-09-28 11:23:15', '2014-09-28 11:24:03'),
('7', '1', 0, '2014-09-28 11:25:08', '2014-09-28 11:25:47'),
('8', '1', 0, '2014-09-28 11:25:48', '2014-09-28 11:26:07'),
('9', '1', 0, '2014-09-28 11:26:25', '2014-09-28 11:26:33'),
('10', '1', 0, '2014-10-31 09:55:14', '2014-10-31 09:55:22'),
('11', '1', 0, '2014-11-02 11:57:22', '2014-11-02 11:57:46'),
('12', '1', 0, '2014-11-02 11:57:57', '2014-11-02 11:58:00'),
('13', '1', 0, '2014-11-02 11:58:45', '2014-11-02 11:58:48'),
('14', '1', 0, '2014-11-02 12:18:18', '2014-11-02 12:19:23'),
('15', '1', 0, '2014-11-02 12:26:29', '2014-11-02 12:26:32'),
('16', '1', 0, '2014-11-02 14:41:15', '2014-11-02 14:41:21');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tabm_bccuentabanco`
--
ALTER TABLE `tabm_bccuentabanco`
 ADD PRIMARY KEY (`cod_ctabco`);

--
-- Indices de la tabla `tabm_bcprestamo`
--
ALTER TABLE `tabm_bcprestamo`
 ADD PRIMARY KEY (`codprem_prem`);

--
-- Indices de la tabla `tabm_cccpcaja`
--
ALTER TABLE `tabm_cccpcaja`
 ADD PRIMARY KEY (`cod_caja`), ADD KEY `tabm_tipocaja_tabm_caja_fk` (`cod_tpago`);

--
-- Indices de la tabla `tabm_cccpttrans`
--
ALTER TABLE `tabm_cccpttrans`
 ADD PRIMARY KEY (`cod_ttrans`);

--
-- Indices de la tabla `tabm_cctranscc`
--
ALTER TABLE `tabm_cctranscc`
 ADD PRIMARY KEY (`cod_transcc`,`cod_srie`,`cod_fra`,`cod_cte`), ADD KEY `tabm_caja_tabm_transcc_fk` (`cod_caja`), ADD KEY `tabm_serie_tabm_transcc_fk` (`cod_srie`), ADD KEY `tabm_ttrans_tabm_transcc_fk` (`cod_ttrans`), ADD KEY `tabm_cliente_tabm_transcc_fk` (`cod_cte`), ADD KEY `tabm_factura_tabm_transcc_fk` (`cod_fra`);

--
-- Indices de la tabla `tabm_cpcompras`
--
ALTER TABLE `tabm_cpcompras`
 ADD PRIMARY KEY (`cod_compra`,`cod_prov`,`cod_fra`,`cod_srie`,`cod_suc`,`cod_empsa`), ADD KEY `tabm_proveedor_tabm_compras_fk` (`cod_prov`), ADD KEY `tabm_FEfactura_tabm_CPcompras_fk` (`cod_fra`,`cod_srie`,`cod_suc`,`cod_empsa`);

--
-- Indices de la tabla `tabm_cpproveedor`
--
ALTER TABLE `tabm_cpproveedor`
 ADD PRIMARY KEY (`cod_prov`);

--
-- Indices de la tabla `tabm_cptpago`
--
ALTER TABLE `tabm_cptpago`
 ADD PRIMARY KEY (`cod_tpago`);

--
-- Indices de la tabla `tabm_cptranscp`
--
ALTER TABLE `tabm_cptranscp`
 ADD PRIMARY KEY (`cod_transcp`,`cod_empsa`,`cod_prov`,`cod_compra`,`cod_fra`,`cod_srie`,`cod_suc`), ADD KEY `tabt_ctacontab_tabm_CPtranscp_fk` (`cod_compconta`,`cod_ctas`), ADD KEY `tabm_proveedor_tabm_transcp_fk` (`cod_prov`), ADD KEY `tabm_caja_tabm_transcp_fk` (`cod_caja`), ADD KEY `tabm_empresa_tabm_transcp_fk` (`cod_empsa`), ADD KEY `tabm_ttrans_tabm_transcp_fk` (`cod_ttrans`), ADD KEY `tabm_CPcompras_tabm_CPtranscp_fk` (`cod_compra`,`cod_prov`,`cod_fra`,`cod_srie`,`cod_suc`,`cod_empsa`);

--
-- Indices de la tabla `tabm_ctcompconta`
--
ALTER TABLE `tabm_ctcompconta`
 ADD PRIMARY KEY (`cod_compconta`), ADD KEY `tabm_doccomp_tabm_compconta_fk` (`codtipodoc_compcont`);

--
-- Indices de la tabla `tabm_ctctacont`
--
ALTER TABLE `tabm_ctctacont`
 ADD PRIMARY KEY (`cod_ctacont`), ADD KEY `tabm_CTctacont_tabm_CTctacont_fk` (`pertn_ctacont`);

--
-- Indices de la tabla `tabm_ctdescuentoempl`
--
ALTER TABLE `tabm_ctdescuentoempl`
 ADD PRIMARY KEY (`cod_descempl`);

--
-- Indices de la tabla `tabm_ctdiario`
--
ALTER TABLE `tabm_ctdiario`
 ADD PRIMARY KEY (`codpartd_dro`,`fechcreado_dro`), ADD KEY `tabm_compconta_tabm_diario_fk` (`cod_compconta`);

--
-- Indices de la tabla `tabm_ctdoccomp`
--
ALTER TABLE `tabm_ctdoccomp`
 ADD PRIMARY KEY (`codtipodoc_compcont`);

--
-- Indices de la tabla `tabm_ctinventario`
--
ALTER TABLE `tabm_ctinventario`
 ADD PRIMARY KEY (`cod_inv`,`cod_ctacont`), ADD KEY `tabm_ctacont_tabm_inventario_fk` (`cod_ctacont`);

--
-- Indices de la tabla `tabm_feambiente`
--
ALTER TABLE `tabm_feambiente`
 ADD PRIMARY KEY (`cod_amb`), ADD KEY `Tipo_Habitacion_Habitacion_fk` (`cod_tamb`);

--
-- Indices de la tabla `tabm_febodega`
--
ALTER TABLE `tabm_febodega`
 ADD PRIMARY KEY (`cod_bga`), ADD KEY `tabm_sucursal_tabm_bodega_fk` (`cod_suc`);

--
-- Indices de la tabla `tabm_fecatprod`
--
ALTER TABLE `tabm_fecatprod`
 ADD PRIMARY KEY (`cod_catprod`);

--
-- Indices de la tabla `tabm_fecliente`
--
ALTER TABLE `tabm_fecliente`
 ADD PRIMARY KEY (`cod_cte`);

--
-- Indices de la tabla `tabm_fedocumentos`
--
ALTER TABLE `tabm_fedocumentos`
 ADD PRIMARY KEY (`cod_docs`,`cod_empsa`,`cod_srie`,`cod_suc`), ADD KEY `tabm_sucursal_tabm_documentos_fk` (`cod_suc`), ADD KEY `tabm_serie_tabm_documentos_fk` (`cod_srie`), ADD KEY `tabm_empresa_tabm_documentos_fk` (`cod_empsa`), ADD KEY `tabm_tipo_transaccion_tabt_inven_fk` (`cod_ttrans`);

--
-- Indices de la tabla `tabm_feempresa`
--
ALTER TABLE `tabm_feempresa`
 ADD PRIMARY KEY (`cod_empsa`), ADD KEY `tabm_series_tabm_empresa_fk` (`cod_srie`);

--
-- Indices de la tabla `tabm_fefactura`
--
ALTER TABLE `tabm_fefactura`
 ADD PRIMARY KEY (`cod_fra`,`cod_srie`,`cod_suc`,`cod_empsa`), ADD KEY `tabm_sucursal_tabm_factura_fk` (`cod_suc`), ADD KEY `tabm_serie_tabm_factura_fk` (`cod_srie`), ADD KEY `tabm_FEempresa_tabm_FEfactura_fk` (`cod_empsa`), ADD KEY `tabm_foliocliente_tabm_factura_fk` (`cod_flocte`);

--
-- Indices de la tabla `tabm_fefoliocliente`
--
ALTER TABLE `tabm_fefoliocliente`
 ADD PRIMARY KEY (`cod_flocte`), ADD KEY `tabm_catprod_tabm_foliocliente_fk` (`cod_catprod`), ADD KEY `tabm_cliente_tabm_foliocliente_fk` (`cod_cte`), ADD KEY `tabm_reservacion_tabm_foliocliente_fk` (`cod_rsva`);

--
-- Indices de la tabla `tabm_feimpuesto`
--
ALTER TABLE `tabm_feimpuesto`
 ADD PRIMARY KEY (`cod_imp`);

--
-- Indices de la tabla `tabm_fereservacion`
--
ALTER TABLE `tabm_fereservacion`
 ADD PRIMARY KEY (`cod_rsva`), ADD KEY `Cliente_Reservacion_fk` (`cod_cte`);

--
-- Indices de la tabla `tabm_feserie`
--
ALTER TABLE `tabm_feserie`
 ADD PRIMARY KEY (`cod_srie`);

--
-- Indices de la tabla `tabm_fesucursal`
--
ALTER TABLE `tabm_fesucursal`
 ADD PRIMARY KEY (`cod_suc`);

--
-- Indices de la tabla `tabm_fetambiente`
--
ALTER TABLE `tabm_fetambiente`
 ADD PRIMARY KEY (`cod_tamb`);

--
-- Indices de la tabla `tabm_nndepartamento`
--
ALTER TABLE `tabm_nndepartamento`
 ADD PRIMARY KEY (`cod_depto`);

--
-- Indices de la tabla `tabm_nnempleado`
--
ALTER TABLE `tabm_nnempleado`
 ADD PRIMARY KEY (`cod_emp`), ADD KEY `tabm_puesto_tabm_empleado_fk` (`cod_pto`), ADD KEY `tabm_departamento_tabm_empleado_fk` (`cod_depto`), ADD KEY `tabm_tpago_tabm_empleado_fk` (`cod_tpago`), ADD KEY `tabm_empresa_tabm_empleado_fk` (`cod_empsa`);

--
-- Indices de la tabla `tabm_nnnomina`
--
ALTER TABLE `tabm_nnnomina`
 ADD PRIMARY KEY (`cod_nomi`), ADD KEY `tabm_tiponomina_tabm_nomina_fk` (`cod_tnomi`), ADD KEY `tabm_empresa_tabm_nomina_fk` (`cod_empsa`);

--
-- Indices de la tabla `tabm_nnpuesto`
--
ALTER TABLE `tabm_nnpuesto`
 ADD PRIMARY KEY (`cod_pto`);

--
-- Indices de la tabla `tabm_nntnomina`
--
ALTER TABLE `tabm_nntnomina`
 ADD PRIMARY KEY (`cod_tnomi`);

--
-- Indices de la tabla `tabm_nntransaccion`
--
ALTER TABLE `tabm_nntransaccion`
 ADD PRIMARY KEY (`cod_trans`), ADD KEY `tabm_CTctacont_tabm_NNtransaccion_fk` (`cod_ctacont`);

--
-- Indices de la tabla `tabm_sgaplicacion`
--
ALTER TABLE `tabm_sgaplicacion`
 ADD PRIMARY KEY (`cod_app`);

--
-- Indices de la tabla `tabm_sgperfil`
--
ALTER TABLE `tabm_sgperfil`
 ADD PRIMARY KEY (`cod_pfll`), ADD KEY `tabm_SGperfil_tabm_SGperfil_fk` (`cod_pfll_1`);

--
-- Indices de la tabla `tabm_sgpregunta`
--
ALTER TABLE `tabm_sgpregunta`
 ADD PRIMARY KEY (`cod_preg`);

--
-- Indices de la tabla `tabm_sgprivilegio`
--
ALTER TABLE `tabm_sgprivilegio`
 ADD PRIMARY KEY (`cod_priv`);

--
-- Indices de la tabla `tabm_sgusuario`
--
ALTER TABLE `tabm_sgusuario`
 ADD PRIMARY KEY (`cod_usr`), ADD KEY `tabm_pregunta_tabm_usuario_fk` (`cod_preg`), ADD KEY `tabm_privilegio_tabm_usuario_fk` (`cod_priv`), ADD KEY `tabm_empleado_tabm_usuario_fk` (`cod_emp`);

--
-- Indices de la tabla `tabt_bcctacontab`
--
ALTER TABLE `tabt_bcctacontab`
 ADD PRIMARY KEY (`cod_compconta`,`cod_ctas`);

--
-- Indices de la tabla `tabt_bchistoriabanc`
--
ALTER TABLE `tabt_bchistoriabanc`
 ADD PRIMARY KEY (`codhstbco_hstbco`,`cod_ctabco`), ADD KEY `tabm_BCcuentabanco_tabt_BChistoriabanc_fk` (`cod_ctabco`);

--
-- Indices de la tabla `tabt_bcmovbanc`
--
ALTER TABLE `tabt_bcmovbanc`
 ADD PRIMARY KEY (`cod_mov`,`cod_ctabco`), ADD KEY `tabm_cuentabanco_tabt_movbanc_fk` (`cod_ctabco`), ADD KEY `tabt_ctacontab_tabt_movbanc_fk` (`cod_compconta`,`cod_ctas`), ADD KEY `tabm_CPtpago_tabt_movbanc_fk` (`cod_tpago`), ADD KEY `tabm_CCCPttrans_tabt_movbanc_fk` (`cod_ttrans`);

--
-- Indices de la tabla `tabt_bcpagoprem`
--
ALTER TABLE `tabt_bcpagoprem`
 ADD PRIMARY KEY (`cod_ctabco`,`codprem_prem`), ADD KEY `tabm_prestamo_tabt_pagoprem_fk` (`codprem_prem`);

--
-- Indices de la tabla `tabt_bibitacora`
--
ALTER TABLE `tabt_bibitacora`
 ADD PRIMARY KEY (`cod_bita`), ADD KEY `tabm_usuario_tabt_BIbitacora_fk` (`cod_usr`);

--
-- Indices de la tabla `tabt_cpdcompra`
--
ALTER TABLE `tabt_cpdcompra`
 ADD PRIMARY KEY (`cod_compra`,`cod_prov`,`cod_catprod`), ADD KEY `tabm_catprod_tabt_dcompras_fk` (`cod_catprod`);

--
-- Indices de la tabla `tabt_ctmovdiario`
--
ALTER TABLE `tabt_ctmovdiario`
 ADD PRIMARY KEY (`fechcreado_dro`,`codpartd_dro`,`cod_ctacont`), ADD KEY `tabm_ctacont_tabt_movdiario_fk` (`cod_ctacont`), ADD KEY `tabm_diario_tabt_movdiario_fk` (`codpartd_dro`,`fechcreado_dro`);

--
-- Indices de la tabla `tabt_ctremune`
--
ALTER TABLE `tabt_ctremune`
 ADD PRIMARY KEY (`cod_remu`), ADD KEY `tabm_compconta_tabt_remune_fk` (`cod_compconta`);

--
-- Indices de la tabla `tabt_ctsalarioneto`
--
ALTER TABLE `tabt_ctsalarioneto`
 ADD PRIMARY KEY (`cod_slnet`,`cod_remu`), ADD KEY `tabm_descuentoempl_tabt_salarioneto_fk` (`cod_descempl`), ADD KEY `tabt_remune_tabt_salarioneto_fk` (`cod_remu`);

--
-- Indices de la tabla `tabt_feddocumentos`
--
ALTER TABLE `tabt_feddocumentos`
 ADD PRIMARY KEY (`cod_catprod`,`cod_docs`,`cod_srie`), ADD KEY `tabm_serie_tabt_ddocumentos_fk` (`cod_srie`), ADD KEY `tabt_inven_tabt_kardex_fk` (`cod_docs`), ADD KEY `tabm_bodega_tabt_ddocumentos_fk` (`cod_bga`);

--
-- Indices de la tabla `tabt_fedrsva`
--
ALTER TABLE `tabt_fedrsva`
 ADD PRIMARY KEY (`cod_rsva`,`cod_amb`), ADD KEY `Habitacion_Dett_Reservacion_fk` (`cod_amb`);

--
-- Indices de la tabla `tabt_feexistencias`
--
ALTER TABLE `tabt_feexistencias`
 ADD PRIMARY KEY (`cod_catprod`,`cod_bga`), ADD KEY `tabm_bodega_tabt_existencias_fk` (`cod_bga`);

--
-- Indices de la tabla `tabt_fefraim`
--
ALTER TABLE `tabt_fefraim`
 ADD PRIMARY KEY (`cod_imp`,`cod_fra`,`cod_srie`,`cod_suc`), ADD KEY `tabm_FEfactura_tabt_FEfraim_fk` (`cod_fra`,`cod_srie`,`cod_suc`);

--
-- Indices de la tabla `tabt_nndnomina`
--
ALTER TABLE `tabt_nndnomina`
 ADD PRIMARY KEY (`cod_nomi`,`cod_trans`,`cod_emp`), ADD KEY `tabm_NNtransaccion_tabm_NNdnomina_fk` (`cod_trans`), ADD KEY `tabm_NNempleado_tabm_NNdnomina_fk` (`cod_emp`);

--
-- Indices de la tabla `tabt_sgasignapppersonal`
--
ALTER TABLE `tabt_sgasignapppersonal`
 ADD PRIMARY KEY (`cod_aappp`), ADD KEY `tabm_aplicacion_tabt_asignapppersonal_fk` (`cod_app`), ADD KEY `tabm_SGusuario_tabt_SGasignapppersonal_fk` (`cod_usr`);

--
-- Indices de la tabla `tabt_sgperfilapp`
--
ALTER TABLE `tabt_sgperfilapp`
 ADD PRIMARY KEY (`cod_papp`,`Id_perfil`), ADD KEY `tabm_perfil_tabt_perfilapp_fk` (`Id_perfil`), ADD KEY `tabm_aplicacion_tabt_perfilapp_fk` (`cod_app`);

--
-- Indices de la tabla `tabt_sgperfiusuario`
--
ALTER TABLE `tabt_sgperfiusuario`
 ADD PRIMARY KEY (`cod_pusr`), ADD KEY `tabm_perfil_tabt_perfiusuario_fk` (`cod_pfll`), ADD KEY `tabm_usuario_tabt_perfiusuario_fk` (`cod_usr`);

--
-- Indices de la tabla `tabt_sgsesion`
--
ALTER TABLE `tabt_sgsesion`
 ADD PRIMARY KEY (`cod_ses`,`cod_usr`), ADD KEY `tabm_SGusuario_tabt_sesion_fk` (`cod_usr`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tabm_cccpcaja`
--
ALTER TABLE `tabm_cccpcaja`
ADD CONSTRAINT `tabm_tipocaja_tabm_caja_fk` FOREIGN KEY (`cod_tpago`) REFERENCES `tabm_cptpago` (`cod_tpago`);

--
-- Filtros para la tabla `tabm_cctranscc`
--
ALTER TABLE `tabm_cctranscc`
ADD CONSTRAINT `tabm_caja_tabm_transcc_fk` FOREIGN KEY (`cod_caja`) REFERENCES `tabm_cccpcaja` (`cod_caja`),
ADD CONSTRAINT `tabm_cliente_tabm_transcc_fk` FOREIGN KEY (`cod_cte`) REFERENCES `tabm_fecliente` (`cod_cte`),
ADD CONSTRAINT `tabm_factura_tabm_transcc_fk` FOREIGN KEY (`cod_fra`) REFERENCES `tabm_fefactura` (`cod_fra`),
ADD CONSTRAINT `tabm_serie_tabm_transcc_fk` FOREIGN KEY (`cod_srie`) REFERENCES `tabm_feserie` (`cod_srie`),
ADD CONSTRAINT `tabm_ttrans_tabm_transcc_fk` FOREIGN KEY (`cod_ttrans`) REFERENCES `tabm_cccpttrans` (`cod_ttrans`);

--
-- Filtros para la tabla `tabm_cpcompras`
--
ALTER TABLE `tabm_cpcompras`
ADD CONSTRAINT `tabm_FEfactura_tabm_CPcompras_fk` FOREIGN KEY (`cod_fra`, `cod_srie`, `cod_suc`, `cod_empsa`) REFERENCES `tabm_fefactura` (`cod_fra`, `cod_srie`, `cod_suc`, `cod_empsa`),
ADD CONSTRAINT `tabm_proveedor_tabm_compras_fk` FOREIGN KEY (`cod_prov`) REFERENCES `tabm_cpproveedor` (`cod_prov`);

--
-- Filtros para la tabla `tabm_cptranscp`
--
ALTER TABLE `tabm_cptranscp`
ADD CONSTRAINT `tabm_CPcompras_tabm_CPtranscp_fk` FOREIGN KEY (`cod_compra`, `cod_prov`, `cod_fra`, `cod_srie`, `cod_suc`, `cod_empsa`) REFERENCES `tabm_cpcompras` (`cod_compra`, `cod_prov`, `cod_fra`, `cod_srie`, `cod_suc`, `cod_empsa`),
ADD CONSTRAINT `tabm_caja_tabm_transcp_fk` FOREIGN KEY (`cod_caja`) REFERENCES `tabm_cccpcaja` (`cod_caja`),
ADD CONSTRAINT `tabm_empresa_tabm_transcp_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_feempresa` (`cod_empsa`),
ADD CONSTRAINT `tabm_proveedor_tabm_transcp_fk` FOREIGN KEY (`cod_prov`) REFERENCES `tabm_cpproveedor` (`cod_prov`),
ADD CONSTRAINT `tabm_ttrans_tabm_transcp_fk` FOREIGN KEY (`cod_ttrans`) REFERENCES `tabm_cccpttrans` (`cod_ttrans`),
ADD CONSTRAINT `tabt_ctacontab_tabm_CPtranscp_fk` FOREIGN KEY (`cod_compconta`, `cod_ctas`) REFERENCES `tabt_bcctacontab` (`cod_compconta`, `cod_ctas`);

--
-- Filtros para la tabla `tabm_ctcompconta`
--
ALTER TABLE `tabm_ctcompconta`
ADD CONSTRAINT `tabm_doccomp_tabm_compconta_fk` FOREIGN KEY (`codtipodoc_compcont`) REFERENCES `tabm_ctdoccomp` (`codtipodoc_compcont`);

--
-- Filtros para la tabla `tabm_ctctacont`
--
ALTER TABLE `tabm_ctctacont`
ADD CONSTRAINT `tabm_CTctacont_tabm_CTctacont_fk` FOREIGN KEY (`pertn_ctacont`) REFERENCES `tabm_ctctacont` (`cod_ctacont`);

--
-- Filtros para la tabla `tabm_ctdiario`
--
ALTER TABLE `tabm_ctdiario`
ADD CONSTRAINT `tabm_compconta_tabm_diario_fk` FOREIGN KEY (`cod_compconta`) REFERENCES `tabm_ctcompconta` (`cod_compconta`);

--
-- Filtros para la tabla `tabm_ctinventario`
--
ALTER TABLE `tabm_ctinventario`
ADD CONSTRAINT `tabm_ctacont_tabm_inventario_fk` FOREIGN KEY (`cod_ctacont`) REFERENCES `tabm_ctctacont` (`cod_ctacont`);

--
-- Filtros para la tabla `tabm_feambiente`
--
ALTER TABLE `tabm_feambiente`
ADD CONSTRAINT `Tipo_Habitacion_Habitacion_fk` FOREIGN KEY (`cod_tamb`) REFERENCES `tabm_fetambiente` (`cod_tamb`);

--
-- Filtros para la tabla `tabm_febodega`
--
ALTER TABLE `tabm_febodega`
ADD CONSTRAINT `tabm_sucursal_tabm_bodega_fk` FOREIGN KEY (`cod_suc`) REFERENCES `tabm_fesucursal` (`cod_suc`);

--
-- Filtros para la tabla `tabm_fedocumentos`
--
ALTER TABLE `tabm_fedocumentos`
ADD CONSTRAINT `tabm_empresa_tabm_documentos_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_feempresa` (`cod_empsa`),
ADD CONSTRAINT `tabm_serie_tabm_documentos_fk` FOREIGN KEY (`cod_srie`) REFERENCES `tabm_feserie` (`cod_srie`),
ADD CONSTRAINT `tabm_sucursal_tabm_documentos_fk` FOREIGN KEY (`cod_suc`) REFERENCES `tabm_fesucursal` (`cod_suc`),
ADD CONSTRAINT `tabm_tipo_transaccion_tabt_inven_fk` FOREIGN KEY (`cod_ttrans`) REFERENCES `tabm_cccpttrans` (`cod_ttrans`);

--
-- Filtros para la tabla `tabm_feempresa`
--
ALTER TABLE `tabm_feempresa`
ADD CONSTRAINT `tabm_series_tabm_empresa_fk` FOREIGN KEY (`cod_srie`) REFERENCES `tabm_feserie` (`cod_srie`);

--
-- Filtros para la tabla `tabm_fefactura`
--
ALTER TABLE `tabm_fefactura`
ADD CONSTRAINT `tabm_FEempresa_tabm_FEfactura_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_feempresa` (`cod_empsa`),
ADD CONSTRAINT `tabm_foliocliente_tabm_factura_fk` FOREIGN KEY (`cod_flocte`) REFERENCES `tabm_fefoliocliente` (`cod_flocte`),
ADD CONSTRAINT `tabm_serie_tabm_factura_fk` FOREIGN KEY (`cod_srie`) REFERENCES `tabm_feserie` (`cod_srie`),
ADD CONSTRAINT `tabm_sucursal_tabm_factura_fk` FOREIGN KEY (`cod_suc`) REFERENCES `tabm_fesucursal` (`cod_suc`);

--
-- Filtros para la tabla `tabm_fefoliocliente`
--
ALTER TABLE `tabm_fefoliocliente`
ADD CONSTRAINT `tabm_catprod_tabm_foliocliente_fk` FOREIGN KEY (`cod_catprod`) REFERENCES `tabm_fecatprod` (`cod_catprod`),
ADD CONSTRAINT `tabm_cliente_tabm_foliocliente_fk` FOREIGN KEY (`cod_cte`) REFERENCES `tabm_fecliente` (`cod_cte`),
ADD CONSTRAINT `tabm_reservacion_tabm_foliocliente_fk` FOREIGN KEY (`cod_rsva`) REFERENCES `tabm_fereservacion` (`cod_rsva`);

--
-- Filtros para la tabla `tabm_fereservacion`
--
ALTER TABLE `tabm_fereservacion`
ADD CONSTRAINT `Cliente_Reservacion_fk` FOREIGN KEY (`cod_cte`) REFERENCES `tabm_fecliente` (`cod_cte`);

--
-- Filtros para la tabla `tabm_nnempleado`
--
ALTER TABLE `tabm_nnempleado`
ADD CONSTRAINT `tabm_departamento_tabm_empleado_fk` FOREIGN KEY (`cod_depto`) REFERENCES `tabm_nndepartamento` (`cod_depto`),
ADD CONSTRAINT `tabm_empresa_tabm_empleado_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_feempresa` (`cod_empsa`),
ADD CONSTRAINT `tabm_puesto_tabm_empleado_fk` FOREIGN KEY (`cod_pto`) REFERENCES `tabm_nnpuesto` (`cod_pto`),
ADD CONSTRAINT `tabm_tpago_tabm_empleado_fk` FOREIGN KEY (`cod_tpago`) REFERENCES `tabm_cptpago` (`cod_tpago`);

--
-- Filtros para la tabla `tabm_nnnomina`
--
ALTER TABLE `tabm_nnnomina`
ADD CONSTRAINT `tabm_empresa_tabm_nomina_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_feempresa` (`cod_empsa`),
ADD CONSTRAINT `tabm_tiponomina_tabm_nomina_fk` FOREIGN KEY (`cod_tnomi`) REFERENCES `tabm_nntnomina` (`cod_tnomi`);

--
-- Filtros para la tabla `tabm_nntransaccion`
--
ALTER TABLE `tabm_nntransaccion`
ADD CONSTRAINT `tabm_CTctacont_tabm_NNtransaccion_fk` FOREIGN KEY (`cod_ctacont`) REFERENCES `tabm_ctctacont` (`cod_ctacont`);

--
-- Filtros para la tabla `tabm_sgperfil`
--
ALTER TABLE `tabm_sgperfil`
ADD CONSTRAINT `tabm_SGperfil_tabm_SGperfil_fk` FOREIGN KEY (`cod_pfll_1`) REFERENCES `tabm_sgperfil` (`cod_pfll`);

--
-- Filtros para la tabla `tabm_sgusuario`
--
ALTER TABLE `tabm_sgusuario`
ADD CONSTRAINT `tabm_empleado_tabm_usuario_fk` FOREIGN KEY (`cod_emp`) REFERENCES `tabm_nnempleado` (`cod_emp`),
ADD CONSTRAINT `tabm_pregunta_tabm_usuario_fk` FOREIGN KEY (`cod_preg`) REFERENCES `tabm_sgpregunta` (`cod_preg`),
ADD CONSTRAINT `tabm_privilegio_tabm_usuario_fk` FOREIGN KEY (`cod_priv`) REFERENCES `tabm_sgprivilegio` (`cod_priv`);

--
-- Filtros para la tabla `tabt_bcctacontab`
--
ALTER TABLE `tabt_bcctacontab`
ADD CONSTRAINT `tabm_compconta_tabt_ctacontab_fk` FOREIGN KEY (`cod_compconta`) REFERENCES `tabm_ctcompconta` (`cod_compconta`);

--
-- Filtros para la tabla `tabt_bchistoriabanc`
--
ALTER TABLE `tabt_bchistoriabanc`
ADD CONSTRAINT `tabm_BCcuentabanco_tabt_BChistoriabanc_fk` FOREIGN KEY (`cod_ctabco`) REFERENCES `tabm_bccuentabanco` (`cod_ctabco`);

--
-- Filtros para la tabla `tabt_bcmovbanc`
--
ALTER TABLE `tabt_bcmovbanc`
ADD CONSTRAINT `tabm_CCCPttrans_tabt_movbanc_fk` FOREIGN KEY (`cod_ttrans`) REFERENCES `tabm_cccpttrans` (`cod_ttrans`),
ADD CONSTRAINT `tabm_CPtpago_tabt_movbanc_fk` FOREIGN KEY (`cod_tpago`) REFERENCES `tabm_cptpago` (`cod_tpago`),
ADD CONSTRAINT `tabm_cuentabanco_tabt_movbanc_fk` FOREIGN KEY (`cod_ctabco`) REFERENCES `tabm_bccuentabanco` (`cod_ctabco`),
ADD CONSTRAINT `tabt_ctacontab_tabt_movbanc_fk` FOREIGN KEY (`cod_compconta`, `cod_ctas`) REFERENCES `tabt_bcctacontab` (`cod_compconta`, `cod_ctas`);

--
-- Filtros para la tabla `tabt_bcpagoprem`
--
ALTER TABLE `tabt_bcpagoprem`
ADD CONSTRAINT `tabm_cuentabanco_tabt_pagoprem_fk` FOREIGN KEY (`cod_ctabco`) REFERENCES `tabm_bccuentabanco` (`cod_ctabco`),
ADD CONSTRAINT `tabm_prestamo_tabt_pagoprem_fk` FOREIGN KEY (`codprem_prem`) REFERENCES `tabm_bcprestamo` (`codprem_prem`);

--
-- Filtros para la tabla `tabt_bibitacora`
--
ALTER TABLE `tabt_bibitacora`
ADD CONSTRAINT `tabm_usuario_tabt_BIbitacora_fk` FOREIGN KEY (`cod_usr`) REFERENCES `tabm_sgusuario` (`cod_usr`);

--
-- Filtros para la tabla `tabt_cpdcompra`
--
ALTER TABLE `tabt_cpdcompra`
ADD CONSTRAINT `tabm_catprod_tabt_dcompras_fk` FOREIGN KEY (`cod_catprod`) REFERENCES `tabm_fecatprod` (`cod_catprod`),
ADD CONSTRAINT `tabm_compras_tabt_dcompras_fk` FOREIGN KEY (`cod_compra`, `cod_prov`) REFERENCES `tabm_cpcompras` (`cod_compra`, `cod_prov`);

--
-- Filtros para la tabla `tabt_ctmovdiario`
--
ALTER TABLE `tabt_ctmovdiario`
ADD CONSTRAINT `tabm_ctacont_tabt_movdiario_fk` FOREIGN KEY (`cod_ctacont`) REFERENCES `tabm_ctctacont` (`cod_ctacont`),
ADD CONSTRAINT `tabm_diario_tabt_movdiario_fk` FOREIGN KEY (`codpartd_dro`, `fechcreado_dro`) REFERENCES `tabm_ctdiario` (`codpartd_dro`, `fechcreado_dro`);

--
-- Filtros para la tabla `tabt_ctremune`
--
ALTER TABLE `tabt_ctremune`
ADD CONSTRAINT `tabm_compconta_tabt_remune_fk` FOREIGN KEY (`cod_compconta`) REFERENCES `tabm_ctcompconta` (`cod_compconta`);

--
-- Filtros para la tabla `tabt_ctsalarioneto`
--
ALTER TABLE `tabt_ctsalarioneto`
ADD CONSTRAINT `tabm_descuentoempl_tabt_salarioneto_fk` FOREIGN KEY (`cod_descempl`) REFERENCES `tabm_ctdescuentoempl` (`cod_descempl`),
ADD CONSTRAINT `tabt_remune_tabt_salarioneto_fk` FOREIGN KEY (`cod_remu`) REFERENCES `tabt_ctremune` (`cod_remu`);

--
-- Filtros para la tabla `tabt_feddocumentos`
--
ALTER TABLE `tabt_feddocumentos`
ADD CONSTRAINT `cata_producto_tabt_kardex_fk` FOREIGN KEY (`cod_catprod`) REFERENCES `tabm_fecatprod` (`cod_catprod`),
ADD CONSTRAINT `tabm_bodega_tabt_ddocumentos_fk` FOREIGN KEY (`cod_bga`) REFERENCES `tabm_febodega` (`cod_bga`),
ADD CONSTRAINT `tabm_serie_tabt_ddocumentos_fk` FOREIGN KEY (`cod_srie`) REFERENCES `tabm_feserie` (`cod_srie`),
ADD CONSTRAINT `tabt_inven_tabt_kardex_fk` FOREIGN KEY (`cod_docs`) REFERENCES `tabm_fedocumentos` (`cod_docs`);

--
-- Filtros para la tabla `tabt_fedrsva`
--
ALTER TABLE `tabt_fedrsva`
ADD CONSTRAINT `Habitacion_Dett_Reservacion_fk` FOREIGN KEY (`cod_amb`) REFERENCES `tabm_feambiente` (`cod_amb`),
ADD CONSTRAINT `Reservacion_Dett_Reservacion_fk` FOREIGN KEY (`cod_rsva`) REFERENCES `tabm_fereservacion` (`cod_rsva`);

--
-- Filtros para la tabla `tabt_feexistencias`
--
ALTER TABLE `tabt_feexistencias`
ADD CONSTRAINT `tabm_bodega_tabt_existencias_fk` FOREIGN KEY (`cod_bga`) REFERENCES `tabm_febodega` (`cod_bga`),
ADD CONSTRAINT `tabm_catprod_tabt_existencias_fk` FOREIGN KEY (`cod_catprod`) REFERENCES `tabm_fecatprod` (`cod_catprod`);

--
-- Filtros para la tabla `tabt_fefraim`
--
ALTER TABLE `tabt_fefraim`
ADD CONSTRAINT `tabm_FEfactura_tabt_FEfraim_fk` FOREIGN KEY (`cod_fra`, `cod_srie`, `cod_suc`) REFERENCES `tabm_fefactura` (`cod_fra`, `cod_srie`, `cod_suc`),
ADD CONSTRAINT `tabm_FEimpuesto_tabt_FEfraim_fk` FOREIGN KEY (`cod_imp`) REFERENCES `tabm_feimpuesto` (`cod_imp`);

--
-- Filtros para la tabla `tabt_nndnomina`
--
ALTER TABLE `tabt_nndnomina`
ADD CONSTRAINT `tabm_NNempleado_tabm_NNdnomina_fk` FOREIGN KEY (`cod_emp`) REFERENCES `tabm_nnempleado` (`cod_emp`),
ADD CONSTRAINT `tabm_NNnomina_tabm_NNdnomina_fk` FOREIGN KEY (`cod_nomi`) REFERENCES `tabm_nnnomina` (`cod_nomi`),
ADD CONSTRAINT `tabm_NNtransaccion_tabm_NNdnomina_fk` FOREIGN KEY (`cod_trans`) REFERENCES `tabm_nntransaccion` (`cod_trans`);

--
-- Filtros para la tabla `tabt_sgasignapppersonal`
--
ALTER TABLE `tabt_sgasignapppersonal`
ADD CONSTRAINT `tabm_SGusuario_tabt_SGasignapppersonal_fk` FOREIGN KEY (`cod_usr`) REFERENCES `tabm_sgusuario` (`cod_usr`),
ADD CONSTRAINT `tabm_aplicacion_tabt_asignapppersonal_fk` FOREIGN KEY (`cod_app`) REFERENCES `tabm_sgaplicacion` (`cod_app`);

--
-- Filtros para la tabla `tabt_sgperfilapp`
--
ALTER TABLE `tabt_sgperfilapp`
ADD CONSTRAINT `tabm_aplicacion_tabt_perfilapp_fk` FOREIGN KEY (`cod_app`) REFERENCES `tabm_sgaplicacion` (`cod_app`),
ADD CONSTRAINT `tabm_perfil_tabt_perfilapp_fk` FOREIGN KEY (`Id_perfil`) REFERENCES `tabm_sgperfil` (`cod_pfll`);

--
-- Filtros para la tabla `tabt_sgperfiusuario`
--
ALTER TABLE `tabt_sgperfiusuario`
ADD CONSTRAINT `tabm_perfil_tabt_perfiusuario_fk` FOREIGN KEY (`cod_pfll`) REFERENCES `tabm_sgperfil` (`cod_pfll`),
ADD CONSTRAINT `tabm_usuario_tabt_perfiusuario_fk` FOREIGN KEY (`cod_usr`) REFERENCES `tabm_sgusuario` (`cod_usr`);

--
-- Filtros para la tabla `tabt_sgsesion`
--
ALTER TABLE `tabt_sgsesion`
ADD CONSTRAINT `tabm_SGusuario_tabt_sesion_fk` FOREIGN KEY (`cod_usr`) REFERENCES `tabm_sgusuario` (`cod_usr`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
