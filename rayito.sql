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

-- Volcando datos para la tabla rayito.clientes: ~5 rows (aproximadamente)
INSERT INTO `clientes` (`IDCliente`, `Nombre`, `Descuento`) VALUES
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
	(1, 'Jabon', 27, 10),
	(2, 'Shampoo', 90, 118),
	(3, 'Cereal', 70, 13),
	(4, 'Miel', 68, 31),
	(5, 'Desodorante', 32, 67),
	(6, 'Yogurt', 35, 5),
	(7, 'Papel', 47, 58),
	(8, 'Atun', 24, 2),
	(9, 'Pan', 52, 7),
	(10, 'Mayonesa', 31, 22);

-- Volcando estructura para tabla rayito.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `IDVenta` int DEFAULT NULL,
  `Total` double DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Hora` time DEFAULT NULL,
  `IDCliente` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=armscii8;

-- Volcando datos para la tabla rayito.ventas: ~0 rows (aproximadamente)

-- Volcando estructura para tabla rayito.ventasproductos
CREATE TABLE IF NOT EXISTS `ventasproductos` (
  `IDVentaProducto` int DEFAULT NULL,
  `IDProducto` int DEFAULT NULL,
  `Precio` double DEFAULT NULL,
  `Cantidad` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=armscii8;

-- Volcando datos para la tabla rayito.ventasproductos: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
