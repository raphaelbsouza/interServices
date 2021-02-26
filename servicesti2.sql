-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: servicesti
-- ------------------------------------------------------
-- Server version	8.0.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbcliente`
--

DROP TABLE IF EXISTS `tbcliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbcliente` (
  `idtbcliente` int NOT NULL AUTO_INCREMENT,
  `NOME` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ENDERECO` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TELEFONE` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idtbcliente`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbcliente`
--

LOCK TABLES `tbcliente` WRITE;
/*!40000 ALTER TABLE `tbcliente` DISABLE KEYS */;
INSERT INTO `tbcliente` VALUES (1,'JOSE DA SILVA XAVIER','RUA DAS MAMONAS n 83','84983818181');
/*!40000 ALTER TABLE `tbcliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbfuncionarios`
--

DROP TABLE IF EXISTS `tbfuncionarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbfuncionarios` (
  `idtbfuncionarios` int NOT NULL AUTO_INCREMENT,
  `NOME` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `TELEFONE` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `FUNCAO` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idtbfuncionarios`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbfuncionarios`
--

LOCK TABLES `tbfuncionarios` WRITE;
/*!40000 ALTER TABLE `tbfuncionarios` DISABLE KEYS */;
INSERT INTO `tbfuncionarios` VALUES (1,'JOSE DA SILVA XAVIERRRRRR 2','84912838181','MONTAGEM E MANUTENÇÃO');
/*!40000 ALTER TABLE `tbfuncionarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbservicos`
--

DROP TABLE IF EXISTS `tbservicos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbservicos` (
  `idtbservicos` int NOT NULL AUTO_INCREMENT,
  `CLIENTE` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `TELEFONE` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `ATENDENTE` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `SERVICO` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `DATA` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `HORA` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idtbservicos`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbservicos`
--

LOCK TABLES `tbservicos` WRITE;
/*!40000 ALTER TABLE `tbservicos` DISABLE KEYS */;
INSERT INTO `tbservicos` VALUES (1,'DENOVO DENOVO','(84) 9,1828-2828','DENOVO DENOVO DENOVO','DENOVO','20/12/2020','10:00');
/*!40000 ALTER TABLE `tbservicos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'servicesti'
--

--
-- Dumping routines for database 'servicesti'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-01 11:22:40
