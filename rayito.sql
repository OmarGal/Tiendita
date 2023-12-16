-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         8.1.0 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.5.0.6677
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para rayito
CREATE DATABASE IF NOT EXISTS `rayito` /*!40100 DEFAULT CHARACTER SET armscii8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `rayito`;

-- Volcando estructura para tabla rayito.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `IDCliente` int NOT NULL,
  `Nombre` varchar(50) NOT NULL DEFAULT '',
  `Descuento` int NOT NULL,
  PRIMARY KEY (`IDCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=armscii8;

-- Volcando datos para la tabla rayito.clientes: ~6 rows (aproximadamente)
INSERT INTO `clientes` (`IDCliente`, `Nombre`, `Descuento`) VALUES
	(0, 'Sin registrar', 0),
	(1, 'Carolina Aguirre', 5),
	(2, 'Rocio Ruiz', 8),
	(3, 'Aurora Rivera', 15),
	(4, 'Roberto Pavon', 10),
	(5, 'Enrique Martinez', 20);

-- Volcando estructura para tabla rayito.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `IDProducto` int NOT NULL,
  `Producto` varchar(50) CHARACTER SET armscii8 COLLATE armscii8_general_ci DEFAULT NULL,
  `Precio` float DEFAULT NULL,
  `Inventario` int DEFAULT NULL,
  PRIMARY KEY (`IDProducto`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=armscii8;

-- Volcando datos para la tabla rayito.productos: ~10 rows (aproximadamente)
INSERT INTO `productos` (`IDProducto`, `Producto`, `Precio`, `Inventario`) VALUES
	(1, 'Jabon', 27, 97),
	(2, 'Shampoo', 90, 84),
	(3, 'Cereal', 70, 9),
	(4, 'Miel', 68, 31),
	(5, 'Desodorante', 32, 62),
	(6, 'Yogurt', 35, 23),
	(7, 'Papel', 47, 58),
	(8, 'Atun', 24, 68),
	(9, 'Pan', 52, 34),
	(10, 'Mayonesa', 31, 21);

-- Volcando estructura para tabla rayito.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `IDUsuario` int NOT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Apellido` varchar(50) DEFAULT NULL,
  `Posicion` varchar(50) DEFAULT NULL,
  `Clave` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=armscii8;

-- Volcando datos para la tabla rayito.usuarios: ~5 rows (aproximadamente)
INSERT INTO `usuarios` (`IDUsuario`, `Nombre`, `Apellido`, `Posicion`, `Clave`) VALUES
	(1, 'admin', NULL, 'admin', '0000'),
	(2, 'Marvin', NULL, 'admin', '0000'),
	(3, 'Omar', NULL, 'caja', '0000'),
	(4, 'Ramon', NULL, 'caja', '0000'),
	(5, 'Julio', NULL, 'admin', '0000');

-- Volcando estructura para tabla rayito.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `IDVenta` int NOT NULL AUTO_INCREMENT,
  `Total` double DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Hora` time DEFAULT NULL,
  `IDUsuario` int DEFAULT NULL,
  `IDCliente` int DEFAULT NULL,
  PRIMARY KEY (`IDVenta`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=armscii8;

-- Volcando datos para la tabla rayito.ventas: ~5 rows (aproximadamente)
INSERT INTO `ventas` (`IDVenta`, `Total`, `Fecha`, `Hora`, `IDUsuario`, `IDCliente`) VALUES
	(1, 214, '2023-02-11', '10:25:36', 3, 1),
	(2, 129.6, '2023-12-11', '11:48:43', 3, 4),
	(3, 31, '2023-12-11', '11:48:57', 3, 0),
	(4, 999, '2023-12-11', '12:21:36', 3, 0),
	(5, 147.2, '2023-12-11', '18:49:19', 1, 2);

-- Volcando estructura para tabla rayito.ventasproductos
CREATE TABLE IF NOT EXISTS `ventasproductos` (
  `IDVentaProducto` int NOT NULL AUTO_INCREMENT,
  `IDProducto` int DEFAULT NULL,
  `Cantidad` int DEFAULT NULL,
  `Subtotal` double DEFAULT NULL,
  `IDVenta` int DEFAULT NULL,
  PRIMARY KEY (`IDVentaProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=armscii8;

-- Volcando datos para la tabla rayito.ventasproductos: ~7 rows (aproximadamente)
INSERT INTO `ventasproductos` (`IDVentaProducto`, `IDProducto`, `Cantidad`, `Subtotal`, `IDVenta`) VALUES
	(1, 1, 2, 54, 1),
	(2, 3, 1, 70, 1),
	(3, 2, 1, 90, 1),
	(4, 1, 2, 54, 2),
	(5, 2, 1, 90, 2),
	(6, 10, 1, 31, 3),
	(7, 5, 5, 160, 5);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
