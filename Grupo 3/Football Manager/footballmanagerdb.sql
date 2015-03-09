-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 27-08-2014 a las 05:44:46
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `footballmanagerdb`
--
CREATE DATABASE `footballmanagerdb` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `footballmanagerdb`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_campeonato`
--

DROP TABLE IF EXISTS `tabm_campeonato`;
CREATE TABLE IF NOT EXISTS `tabm_campeonato` (
  `cod_camp` int(7) NOT NULL,
  `nom_camp` varchar(25) NOT NULL,
  `fechini_camp` datetime NOT NULL,
  `fechfin_camp` datetime NOT NULL,
  `estado_camp` int(1) NOT NULL,
  PRIMARY KEY (`cod_camp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_cancha`
--

DROP TABLE IF EXISTS `tabm_cancha`;
CREATE TABLE IF NOT EXISTS `tabm_cancha` (
  `cod_cha` int(7) NOT NULL,
  `nom_cha` varchar(25) NOT NULL,
  `activo_cha` int(1) NOT NULL,
  PRIMARY KEY (`cod_cha`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_cancha`
--

INSERT INTO `tabm_cancha` (`cod_cha`, `nom_cha`, `activo_cha`) VALUES
(1, 'Camp Nou', 1),
(2, 'Allianz Arena', 1),
(3, 'Signal Iduna Park', 1),
(4, 'Stamford Bridge', 1),
(5, 'Emirates Stadium', 1),
(6, 'Bernabeu', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_control`
--

DROP TABLE IF EXISTS `tabm_control`;
CREATE TABLE IF NOT EXISTS `tabm_control` (
  `cod_ctrl` int(7) NOT NULL,
  `cod_usr` int(7) NOT NULL,
  `fechhora_ctrl` datetime NOT NULL,
  `accion_ctrl` varchar(50) NOT NULL,
  `ip_ctrl` varchar(25) NOT NULL,
  `maquina_ctrl` varchar(50) NOT NULL,
  PRIMARY KEY (`cod_ctrl`),
  KEY `fk_tabm_control_tabm_usuario1` (`cod_usr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_empleado`
--

DROP TABLE IF EXISTS `tabm_empleado`;
CREATE TABLE IF NOT EXISTS `tabm_empleado` (
  `cod_emp` int(7) NOT NULL,
  `cod_temp` int(7) NOT NULL,
  `nom_emp` varchar(25) NOT NULL,
  `apell_emp` varchar(25) NOT NULL,
  `dire_emp` varchar(50) NOT NULL,
  `tel_emp` int(8) NOT NULL,
  `salario_emp` float NOT NULL,
  `activo_emp` int(1) NOT NULL,
  PRIMARY KEY (`cod_emp`),
  KEY `fk_tabm_empleado_tabm_tipoemp1` (`cod_temp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_empleado`
--

INSERT INTO `tabm_empleado` (`cod_emp`, `cod_temp`, `nom_emp`, `apell_emp`, `dire_emp`, `tel_emp`, `salario_emp`, `activo_emp`) VALUES
(1, 1, 'Anthony', 'Molineros', 'Zona 2, Guatemala', 21240092, 5000, 1),
(2, 3, 'Andrea', 'Perez', 'Zona 4, Guatemala', 23229480, 3500, 1),
(3, 2, 'Daniel', 'Moreno', 'Zona 2, Guatemala', 56459093, 3500, 1),
(4, 3, 'Jeniffer', 'Lopez', 'Carretera al Salvador', 54098345, 3500, 1),
(5, 2, 'Kevin', 'Gutierrez', 'Zona 6, Guatemala', 54890092, 3000, 1),
(6, 4, 'Marlon', 'Aldana', 'Boca del Monte', 23320945, 3000, 1),
(7, 2, 'Juan', 'Ramirez', '23av 2-134 z.12', 12344353, 2000, 1),
(8, 2, 'Isaias', 'Perez', '5av 2-31 z.6', 23492831, 1500, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_equipo`
--

DROP TABLE IF EXISTS `tabm_equipo`;
CREATE TABLE IF NOT EXISTS `tabm_equipo` (
  `cod_eqp` int(7) NOT NULL,
  `nom_eqp` varchar(25) NOT NULL,
  `escudo_eqp` varchar(100) NOT NULL,
  `activo_eqp` int(1) NOT NULL,
  PRIMARY KEY (`cod_eqp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_equipo`
--

INSERT INTO `tabm_equipo` (`cod_eqp`, `nom_eqp`, `escudo_eqp`, `activo_eqp`) VALUES
(0, ' ', '', 0),
(2, 'Bayern Munich', '\\\\192.168.10.50\\FootballManager\\Equipos\\2.jpg', 1),
(3, 'Borussia Dortmund', '\\\\192.168.10.50\\FootballManager\\Equipos\\3.jpg', 1),
(4, 'FC Barcelona', '\\\\192.168.10.50\\FootballManager\\Equipos\\4.jpg', 1),
(5, 'Arsenal', '\\\\192.168.10.50\\FootballManager\\Equipos\\5.jpg', 1),
(6, 'Chelsea', '\\\\192.168.10.50\\FootballManager\\Equipos\\6.jpg', 1),
(7, 'Real Madrid', '\\\\192.168.10.50\\FootballManager\\Equipos\\7.jpg', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_jugador`
--

DROP TABLE IF EXISTS `tabm_jugador`;
CREATE TABLE IF NOT EXISTS `tabm_jugador` (
  `cod_jdr` int(7) NOT NULL,
  `nom_jdr` varchar(25) NOT NULL,
  `apell_jdr` varchar(25) NOT NULL,
  `dire_jdr` varchar(50) NOT NULL,
  `tel_jdr` int(8) NOT NULL,
  `foto_jdr` varchar(100) NOT NULL,
  `activo_jdr` int(1) NOT NULL,
  PRIMARY KEY (`cod_jdr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_jugador`
--

INSERT INTO `tabm_jugador` (`cod_jdr`, `nom_jdr`, `apell_jdr`, `dire_jdr`, `tel_jdr`, `foto_jdr`, `activo_jdr`) VALUES
(1, 'Gareth Frank', 'Bale', 'Gales', 11111111, '\\\\192.168.10.50\\FootballManager\\Jugadores\\1.jpg', 1),
(2, 'James David', 'Rodriguez Rubio', 'Colombia', 22222222, '\\\\192.168.10.50\\FootballManager\\Jugadores\\2.jpg', 1),
(3, 'Lionel Andres', 'Messi Cuccittini', 'Argentina', 33333333, '\\\\192.168.10.50\\FootballManager\\Jugadores\\3.jpg', 1),
(4, 'Luis Alberto', 'Suarez Diaz', 'Uruguay', 44444444, '\\\\192.168.10.50\\FootballManager\\Jugadores\\4.jpg', 1),
(5, 'Neymar', 'da Silva Santos', 'Brasil', 55555555, '\\\\192.168.10.50\\FootballManager\\Jugadores\\5.jpg', 1),
(6, 'Arjen', 'Robben', 'Holanda', 66666666, '\\\\192.168.10.50\\FootballManager\\Jugadores\\6.jpg', 1),
(7, 'Robert', ' Lewandowski', 'Polonia', 77777777, '\\\\192.168.10.50\\FootballManager\\Jugadores\\7.jpg', 1),
(8, 'Mario', 'Gotze', 'Alemania', 88888888, '\\\\192.168.10.50\\FootballManager\\Jugadores\\8.jpg', 1),
(9, 'Marco', 'Reus', 'Alemania', 99999999, '\\\\192.168.10.50\\FootballManager\\Jugadores\\9.jpg', 1),
(10, 'Mats', 'Hummels', 'Alemania', 10101010, '\\\\192.168.10.50\\FootballManager\\Jugadores\\10.jpg', 1),
(11, 'Ilkay', 'Gundogan', 'Alemania', 11110000, '\\\\192.168.10.50\\FootballManager\\Jugadores\\11.jpg', 1),
(12, 'Mezut', 'Ozil', 'Alemani', 12121212, '\\\\192.168.10.50\\FootballManager\\Jugadores\\12.jpg', 1),
(13, 'Santi', 'Cazorla', 'Espania', 13131313, '\\\\192.168.10.50\\FootballManager\\Jugadores\\13.jpg', 1),
(14, 'Lukas', 'Podolski', 'Alemania', 14141414, '\\\\192.168.10.50\\FootballManager\\Jugadores\\14.jpg', 1),
(15, 'Fernando', 'Torres', 'Espania', 15151515, '\\\\192.168.10.50\\FootballManager\\Jugadores\\15.jpg', 1),
(16, 'Diego', 'Costa', 'Espania', 16161616, '\\\\192.168.10.50\\FootballManager\\Jugadores\\16.jpg', 1),
(17, 'Didier', 'Drogba', 'Costa de Marfil', 17171717, '\\\\192.168.10.50\\FootballManager\\Jugadores\\17.jpg', 1),
(18, 'Cristiano Ronaldo', 'Dos Santos Aveiro', 'Portugal', 10101011, '\\\\192.168.10.50\\FootballManager\\Jugadores\\18.jpg', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_nivel`
--

DROP TABLE IF EXISTS `tabm_nivel`;
CREATE TABLE IF NOT EXISTS `tabm_nivel` (
  `cod_nvl` int(7) NOT NULL,
  `nivel_nvl` varchar(25) NOT NULL,
  `activo_nvl` int(1) NOT NULL,
  PRIMARY KEY (`cod_nvl`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_nivel`
--

INSERT INTO `tabm_nivel` (`cod_nvl`, `nivel_nvl`, `activo_nvl`) VALUES
(1, 'DBA', 1),
(2, 'Gerencial', 1),
(3, 'Administrativo', 1),
(4, 'Operativo', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_partido`
--

DROP TABLE IF EXISTS `tabm_partido`;
CREATE TABLE IF NOT EXISTS `tabm_partido` (
  `cod_ptd` int(7) NOT NULL,
  `cod_camp` int(7) NOT NULL,
  `cod_emp` int(7) NOT NULL,
  `cod_cha` int(7) NOT NULL,
  `jornada_ptd` int(2) NOT NULL,
  `fechhora_ptd` datetime NOT NULL,
  `elocal_ptd` int(7) NOT NULL,
  `mlocal_ptd` int(2) NOT NULL,
  `mvisitante_ptd` int(2) NOT NULL,
  `evisitante_ptd` int(7) NOT NULL,
  `jugado_ptd` int(1) NOT NULL,
  PRIMARY KEY (`cod_ptd`),
  KEY `fk_tabm_partido_tabm_equipo2` (`elocal_ptd`),
  KEY `fk_tabm_partido_tabm_campeonato1` (`cod_camp`),
  KEY `fk_tabm_partido_tabm_equipo1` (`evisitante_ptd`),
  KEY `fk_tabm_partido_tabm_empleado1` (`cod_emp`),
  KEY `fk_tabm_partido_tabm_cancha1` (`cod_cha`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_tipoemp`
--

DROP TABLE IF EXISTS `tabm_tipoemp`;
CREATE TABLE IF NOT EXISTS `tabm_tipoemp` (
  `cod_temp` int(7) NOT NULL,
  `tipo_temp` varchar(25) NOT NULL,
  `activo_temp` int(1) NOT NULL,
  PRIMARY KEY (`cod_temp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_tipoemp`
--

INSERT INTO `tabm_tipoemp` (`cod_temp`, `tipo_temp`, `activo_temp`) VALUES
(1, 'DBA', 1),
(2, 'Arbitro', 1),
(3, 'Secretaria', 1),
(4, 'Gerente', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_usuario`
--

DROP TABLE IF EXISTS `tabm_usuario`;
CREATE TABLE IF NOT EXISTS `tabm_usuario` (
  `cod_usr` int(7) NOT NULL,
  `cod_nvl` int(7) NOT NULL,
  `cod_emp` int(7) NOT NULL,
  `usuario_usr` varchar(10) NOT NULL,
  `contrasena_usr` varchar(10) NOT NULL,
  `activo_usr` int(1) NOT NULL,
  PRIMARY KEY (`cod_usr`),
  KEY `fk_tabm_usuario_tabm_empleado1` (`cod_emp`),
  KEY `fk_tabm_usuario_tabm_nivel1` (`cod_nvl`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_usuario`
--

INSERT INTO `tabm_usuario` (`cod_usr`, `cod_nvl`, `cod_emp`, `usuario_usr`, `contrasena_usr`, `activo_usr`) VALUES
(1, 1, 1, 'amolineros', 'anthony', 1),
(2, 3, 2, 'aperez', 'andrea', 1),
(3, 4, 3, 'dmoreno', 'daniel', 1),
(4, 3, 4, 'jlopez', 'jeniffer', 1),
(5, 4, 5, 'kgutierrez', 'kevin', 1),
(6, 2, 6, 'maldana', 'marlon', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_dettcamp`
--

DROP TABLE IF EXISTS `tabt_dettcamp`;
CREATE TABLE IF NOT EXISTS `tabt_dettcamp` (
  `cod_dcamp` int(2) NOT NULL,
  `cod_camp` int(7) NOT NULL,
  `cod_eqp` int(7) NOT NULL,
  `jornada_dcamp` int(2) NOT NULL,
  `pj_dcamp` int(2) NOT NULL,
  `pg_dcamp` int(2) NOT NULL,
  `pe_dcamp` int(2) NOT NULL,
  `pp_dcamp` int(2) NOT NULL,
  `gf_dcamp` int(2) NOT NULL,
  `gc_dcamp` int(2) NOT NULL,
  PRIMARY KEY (`cod_dcamp`),
  KEY `fk_tabt_dettcamp_tabm_campeonato1` (`cod_camp`),
  KEY `fk_tabt_dettcamp_tabm_equipo1` (`cod_eqp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_dettjugador`
--

DROP TABLE IF EXISTS `tabt_dettjugador`;
CREATE TABLE IF NOT EXISTS `tabt_dettjugador` (
  `cod_djdr` int(7) NOT NULL,
  `cod_camp` int(7) NOT NULL,
  `cod_eqp` int(7) NOT NULL,
  `cod_jdr` int(7) NOT NULL,
  PRIMARY KEY (`cod_djdr`),
  KEY `fk_tabt_dettjugador_tabm_campeonato` (`cod_camp`),
  KEY `fk_tabt_dettjugador_tabm_equipo1` (`cod_eqp`),
  KEY `fk_tabt_dettjugador_tabm_jugador1` (`cod_jdr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_dettpartido`
--

DROP TABLE IF EXISTS `tabt_dettpartido`;
CREATE TABLE IF NOT EXISTS `tabt_dettpartido` (
  `cod_dptd` int(7) NOT NULL,
  `cod_ptd` int(7) NOT NULL,
  `cod_djdr` int(7) NOT NULL,
  `ta_dptd` int(2) NOT NULL,
  `tr_dptd` int(2) NOT NULL,
  `gl_dptd` int(2) NOT NULL,
  PRIMARY KEY (`cod_dptd`),
  KEY `fk_tabt_dettpartido_tabm_partido1` (`cod_ptd`),
  KEY `fk_tabt_dettpartido_tabt_dettjugador1` (`cod_djdr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tabm_control`
--
ALTER TABLE `tabm_control`
  ADD CONSTRAINT `fk_tabm_control_tabm_usuario1` FOREIGN KEY (`cod_usr`) REFERENCES `tabm_usuario` (`cod_usr`);

--
-- Filtros para la tabla `tabm_empleado`
--
ALTER TABLE `tabm_empleado`
  ADD CONSTRAINT `fk_tabm_empleado_tabm_tipoemp1` FOREIGN KEY (`cod_temp`) REFERENCES `tabm_tipoemp` (`cod_temp`);

--
-- Filtros para la tabla `tabm_partido`
--
ALTER TABLE `tabm_partido`
  ADD CONSTRAINT `fk_tabm_partido_tabm_campeonato1` FOREIGN KEY (`cod_camp`) REFERENCES `tabm_campeonato` (`cod_camp`),
  ADD CONSTRAINT `fk_tabm_partido_tabm_cancha1` FOREIGN KEY (`cod_cha`) REFERENCES `tabm_cancha` (`cod_cha`),
  ADD CONSTRAINT `fk_tabm_partido_tabm_empleado1` FOREIGN KEY (`cod_emp`) REFERENCES `tabm_empleado` (`cod_emp`),
  ADD CONSTRAINT `fk_tabm_partido_tabm_equipo1` FOREIGN KEY (`evisitante_ptd`) REFERENCES `tabm_equipo` (`cod_eqp`),
  ADD CONSTRAINT `fk_tabm_partido_tabm_equipo2` FOREIGN KEY (`elocal_ptd`) REFERENCES `tabm_equipo` (`cod_eqp`);

--
-- Filtros para la tabla `tabm_usuario`
--
ALTER TABLE `tabm_usuario`
  ADD CONSTRAINT `fk_tabm_usuario_tabm_empleado1` FOREIGN KEY (`cod_emp`) REFERENCES `tabm_empleado` (`cod_emp`),
  ADD CONSTRAINT `fk_tabm_usuario_tabm_nivel1` FOREIGN KEY (`cod_nvl`) REFERENCES `tabm_nivel` (`cod_nvl`);

--
-- Filtros para la tabla `tabt_dettcamp`
--
ALTER TABLE `tabt_dettcamp`
  ADD CONSTRAINT `fk_tabt_dettcamp_tabm_campeonato1` FOREIGN KEY (`cod_camp`) REFERENCES `tabm_campeonato` (`cod_camp`),
  ADD CONSTRAINT `fk_tabt_dettcamp_tabm_equipo1` FOREIGN KEY (`cod_eqp`) REFERENCES `tabm_equipo` (`cod_eqp`);

--
-- Filtros para la tabla `tabt_dettjugador`
--
ALTER TABLE `tabt_dettjugador`
  ADD CONSTRAINT `fk_tabt_dettjugador_tabm_campeonato` FOREIGN KEY (`cod_camp`) REFERENCES `tabm_campeonato` (`cod_camp`),
  ADD CONSTRAINT `fk_tabt_dettjugador_tabm_equipo1` FOREIGN KEY (`cod_eqp`) REFERENCES `tabm_equipo` (`cod_eqp`),
  ADD CONSTRAINT `fk_tabt_dettjugador_tabm_jugador1` FOREIGN KEY (`cod_jdr`) REFERENCES `tabm_jugador` (`cod_jdr`);

--
-- Filtros para la tabla `tabt_dettpartido`
--
ALTER TABLE `tabt_dettpartido`
  ADD CONSTRAINT `fk_tabt_dettpartido_tabm_partido1` FOREIGN KEY (`cod_ptd`) REFERENCES `tabm_partido` (`cod_ptd`),
  ADD CONSTRAINT `fk_tabt_dettpartido_tabt_dettjugador1` FOREIGN KEY (`cod_djdr`) REFERENCES `tabt_dettjugador` (`cod_djdr`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
