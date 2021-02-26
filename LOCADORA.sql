-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: locacao
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
-- Table structure for table `tbcarros`
--

DROP TABLE IF EXISTS `tbcarros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbcarros` (
  `idtbclientes` int NOT NULL AUTO_INCREMENT,
  `MODELO` varchar(100) DEFAULT NULL,
  `MARCA` varchar(100) DEFAULT NULL,
  `CATEGORIA` varchar(100) DEFAULT NULL,
  `PLACA` varchar(8) DEFAULT NULL,
  `CHASSI` varchar(45) DEFAULT NULL,
  `DISPONIBILIDADE` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`idtbclientes`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbcarros`
--

LOCK TABLES `tbcarros` WRITE;
/*!40000 ALTER TABLE `tbcarros` DISABLE KEYS */;
INSERT INTO `tbcarros` VALUES (1,'GOL','WOLKS','PASSEIO','MXS81238','9D99DDDD',NULL);
/*!40000 ALTER TABLE `tbcarros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbclientes`
--

DROP TABLE IF EXISTS `tbclientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbclientes` (
  `idtbclientes` int NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ENDERECO` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CPF` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `RG` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CNH` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TIPOCNH` varchar(5) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TELEFONE` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idtbclientes`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbclientes`
--

LOCK TABLES `tbclientes` WRITE;
/*!40000 ALTER TABLE `tbclientes` DISABLE KEYS */;
INSERT INTO `tbclientes` VALUES (1,'OI OI OI OI OI OI OI OI OI OI OI OI OI OI OI OI OI OI OI OI ','TESTE TESTE TESTE TESTE TESTE TESTE ','01010019119','90128309102','000001999','AB','84981377111');
/*!40000 ALTER TABLE `tbclientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbfuncionarios`
--

DROP TABLE IF EXISTS `tbfuncionarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbfuncionarios` (
  `idtbfuncionarios` int NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) DEFAULT NULL,
  `ENDERECO` varchar(100) DEFAULT NULL,
  `CPF` varchar(100) DEFAULT NULL,
  `RG` varchar(100) DEFAULT NULL,
  `TELEFONE` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idtbfuncionarios`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbfuncionarios`
--

LOCK TABLES `tbfuncionarios` WRITE;
/*!40000 ALTER TABLE `tbfuncionarios` DISABLE KEYS */;
INSERT INTO `tbfuncionarios` VALUES (1,'JOSE DA SILVA XAVIER','RUA DAS JOREMAS','019.129.393-21','0012939129','84-91283833'),(2,'GOGOGOG','GOOGGO','012039039231','0219192','8481293901203');
/*!40000 ALTER TABLE `tbfuncionarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblocacao`
--

DROP TABLE IF EXISTS `tblocacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblocacao` (
  `idtblocacao` int NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) DEFAULT NULL,
  `CARRO` varchar(100) DEFAULT NULL,
  `VALORDIARIA` varchar(45) DEFAULT NULL,
  `QTDDIARIA` varchar(45) DEFAULT NULL,
  `SEGURO` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idtblocacao`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblocacao`
--

LOCK TABLES `tblocacao` WRITE;
/*!40000 ALTER TABLE `tblocacao` DISABLE KEYS */;
INSERT INTO `tblocacao` VALUES (1,'JOSE JOSE JOSE','GOL','50','5','10');
/*!40000 ALTER TABLE `tblocacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'locacao'
--

--
-- Dumping routines for database 'locacao'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-01  8:24:12
