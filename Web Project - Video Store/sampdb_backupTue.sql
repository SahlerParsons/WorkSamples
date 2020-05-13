-- MySQL dump 10.13  Distrib 5.7.21, for Win64 (x86_64)
--
-- Host: localhost    Database: sampdb
-- ------------------------------------------------------
-- Server version	5.7.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `absence`
--

DROP TABLE IF EXISTS `absence`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `absence` (
  `student_id` int(10) unsigned NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`student_id`,`date`),
  CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `student` (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `absence`
--

LOCK TABLES `absence` WRITE;
/*!40000 ALTER TABLE `absence` DISABLE KEYS */;
INSERT INTO `absence` VALUES (3,'2012-09-03'),(5,'2012-09-03'),(10,'2012-09-06'),(10,'2012-09-09'),(17,'2012-09-07'),(20,'2012-09-07');
/*!40000 ALTER TABLE `absence` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `apothegm`
--

DROP TABLE IF EXISTS `apothegm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `apothegm` (
  `attributes` varchar(40) DEFAULT NULL,
  `phrase` text,
  FULLTEXT KEY `phrase` (`phrase`),
  FULLTEXT KEY `attributes` (`attributes`),
  FULLTEXT KEY `phrase_2` (`phrase`,`attributes`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apothegm`
--

LOCK TABLES `apothegm` WRITE;
/*!40000 ALTER TABLE `apothegm` DISABLE KEYS */;
INSERT INTO `apothegm` VALUES ('Aeschylus','Time as he grows old teaches many lessons'),('Alexander Graham Bell','Mr. Watson, come here. I want you!'),('Benjamin Franklin','It is hard for an empty bag to stand upright'),('Benjamin Franklin','Little strokes fell great oaks'),('Benjamin Franklin','Remember that time is money'),('Miguel de Cervantes','Bell, book, and candle'),('Proverbs 15:1','A soft answer turneth away wrath'),('Theodore Roosevelt','Speak softly and carry a big stick'),('William Shakespeare','But, soft! what light through yonder window breaks?'),('Robert Burton','I light my candle from their torches.');
/*!40000 ALTER TABLE `apothegm` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grade_event`
--

DROP TABLE IF EXISTS `grade_event`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grade_event` (
  `date` date NOT NULL,
  `category` enum('T','Q') NOT NULL,
  `event_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`event_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grade_event`
--

LOCK TABLES `grade_event` WRITE;
/*!40000 ALTER TABLE `grade_event` DISABLE KEYS */;
INSERT INTO `grade_event` VALUES ('2012-09-03','Q',1),('2012-09-06','Q',2),('2012-09-09','T',3),('2012-09-16','Q',4),('2012-09-23','Q',5),('2012-10-01','T',6),('2013-01-14','Q',7);
/*!40000 ALTER TABLE `grade_event` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `member`
--

DROP TABLE IF EXISTS `member`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `member` (
  `member_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `last_name` varchar(20) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `suffix` varchar(5) DEFAULT NULL,
  `expiration` date DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `street` varchar(50) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `state` varchar(2) DEFAULT NULL,
  `zip` varchar(10) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `interests` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`member_id`)
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `member`
--

LOCK TABLES `member` WRITE;
/*!40000 ALTER TABLE `member` DISABLE KEYS */;
INSERT INTO `member` VALUES (1,'Solow','Jeanne',NULL,'2013-11-15','jeanne_s@earth.com','16 Ludden Dr.','Austin','TX','33347','964-665-8735','Great Depression,Spanish-American War,Westward movement,Civil Rights,Sports'),(2,'Lundsten','August',NULL,'2015-08-11','august.lundsten@pluto.com','13 O\'Malley St.','Bogalusa','LA','96127','196-481-0897','Korean War,World War I,Civil Rights'),(3,'Erdmann','Kay',NULL,'2013-01-14',NULL,'42 Fremont Av.','Grenada','MI','44953','493-610-3215','Education,Roosevelt,Presidential politics'),(4,'Arbogast','Ruth',NULL,'2015-02-10','arbogast.ruth@mars.net','95 Carnwood Rd.','Paris','IL','31483','539-907-5225','Colonial period,Social Security,Constitution,Lincoln,Gold rush'),(5,'Dorfman','Carol',NULL,'2016-09-15','c.dorfman@uranus.net','21 Winnemac Av.','Trenton','MO','99887','597-290-3955','Revolutionary War,Cold War,immigration'),(6,'Eliason','Jessica',NULL,'2013-12-27','jessica.eliason@pluto.com','60 Century Av.','Osborne','KS','63198','896-268-0569','World War I,Korean War'),(7,'Sawyer','Dennis',NULL,'2014-11-21','s_dennis@jupiter.com','48 Jenifer St.','Denver','CO','23728','775-983-4182','Industrial revolution,Great Depression,Armed services,Education'),(8,'Phillips','Donald','III','2013-03-05','d_phillips@neptune.org','13 Lake St.','San Antonio','TX','87154','898-166-9341','Revolutionary War,Abolition,Armed services,Lincoln,Gold rush'),(9,'Anderson','Marcia',NULL,'2014-02-10',NULL,'31 Bigelow Rd.','Cedar Rapids','IA','45150','445-539-3384','Armed services,immigration,Gold rush,Cold War,Education'),(10,'Kilgore','Leonard',NULL,'2016-05-09',NULL,'19 Pagelow Ln.','Beloit','WI','16235','963-699-2715','Spanish-American War,Founding fathers,World War I,Presidential politics'),(11,'Lederman','Judith',NULL,'2017-07-09','judith_lederman@mercury.net','218 N. Sherman Av.','Appleton','WI','63330','380-077-6632','World War II,Great Depression,War of 1812,Spanish-American War,Vietnam War'),(12,'Bodell','Bonnie',NULL,'2015-02-10',NULL,'674 Marledge St.','Geneva','IL','34619','790-449-4910','War of 1812,Spanish-American War,Korean War,World War I,Constitution'),(13,'Reusch','Diane',NULL,'2013-03-14','reusch_d@venus.org','111 Dogwood Pl.','Burlington','IL','03211','964-681-8054','Vietnam War,Roosevelt'),(14,'Hilby','Bernard',NULL,'2014-06-04','bernard.hilby@saturn.org','111 West St.','Clinton','IA','46161','333-263-2057','Westward movement,Cold War'),(15,'Propper','Harvey',NULL,'2014-04-03','harvey_propper@pluto.com','853 Van Hise Av.','Lansing','MI','39980','184-832-6901','Industrial revolution,Founding fathers,Great Depression,Constitution,Presidential politics'),(16,'Michaels','Amanda',NULL,'2015-10-01',NULL,'805 Chase Blvd.','South Bend','IN','58751','295-458-1334','Abolition,Roosevelt,Vietnam War,Social Security'),(17,'Hagler','Carolyn',NULL,'2016-10-13','hagler.c@mars.net','834 Woods Edge Rd.','Fort Wayne','IN','65594','828-991-7354','Lincoln,Civil Rights,Gold rush,Revolutionary War,Civil War'),(18,'York','Mark','II','2012-08-24','york_mark@earth.com','449 Meyer Av.','Peoria','IL','90108','845-137-2175','Cold War,immigration'),(19,'Feit','Daniel',NULL,'2014-05-04','daniel.feit@pluto.com','181 E. Washington Av.','Stockton','CA','90255','167-064-7158','Colonial period,Vietnam War,Korean War,Presidential politics'),(20,'Overland','Roland',NULL,NULL,NULL,'949 Mineral Point Rd.','Minot','ND','45600','232-732-1438','Gold rush,immigration,Spanish-American War'),(21,'Lacke','Bruce',NULL,'2012-10-10',NULL,'617 West Lawn Av.','Aberdeen','SD','97919','171-132-0360','Vietnam War,Education'),(22,'Hurst','Sally',NULL,'2013-12-31','hurst.s@mars.net','201 Laurel Ln.','Warren','MN','37373','553-257-4344','Spanish-American War'),(23,'Pitas','Clifton',NULL,'2016-02-22','clifton_p@saturn.org','713 Quincy Av.','Duluth','MN','84708','857-652-7766','Industrial revolution,Great Depression,Armed services'),(24,'Wheeler','Mae',NULL,'2014-05-26','mae.wheeler@venus.org','238 Mendota Ct.','Atlanta','GA','78446','636-995-4174','Education,Cold War,Lincoln,Social Security'),(25,'Nelson','Anthony',NULL,'2017-06-10','nelson.anthony@venus.org','739 Hayes Rd.','Akron','OH','21256','844-967-6564','Lincoln,Roosevelt,Spanish-American War,World War II'),(26,'Jones','Richard',NULL,'2013-01-27',NULL,'206 Colladay Point Dr.','Syracuse','NY','01227','839-320-5769','Roosevelt,Abolition,Social Security'),(27,'Moorhead','Susan',NULL,'2013-05-31','susan.m@venus.org','462 Raymond Rd.','New York','NY','82057','256-439-4270','Revolutionary War,Spanish-American War,World War I,Founding fathers,Gold rush'),(28,'Lugaro','Ken',NULL,'2016-06-15','ken_l@venus.org','100 W. Gorham','Caribou','ME','72410','312-149-2847','Industrial revolution'),(29,'Hennessy','Jim',NULL,'2014-01-08',NULL,'222 Miami Pass','Brattleboro','NH','60633','665-455-5472','Founding fathers'),(30,'Pernetti','Jeffrey',NULL,'2015-05-24','jeffrey_pernetti@saturn.org','627 Laramie Ct.','Montpelier','VT','20537','603-395-5806','Revolutionary War'),(31,'Colby','Amy',NULL,'2017-03-01','colby_a@saturn.org','275 Big Sky Dr.','Pottsville','PA','24191','983-484-0425','World War I,immigration,Vietnam War,Constitution'),(32,'Vincent','Edward',NULL,NULL,'v.edward@saturn.org','960 Brody Dr.','Elkins','WV','99473','631-122-4209','Spanish-American War,Founding fathers'),(33,'Nemke','Joel',NULL,'2015-12-19','joel.nemke@uranus.net','243 Windsor Rd.','Greensbora','NC','24400','801-878-6704','Great Depression,Civil War'),(34,'Gjertson','Herbert',NULL,'2016-01-07','herbert_gjertson@mars.net','279 Clark St.','Lake City','SC','59674','477-095-3642','Founding fathers'),(35,'Clift','Melissa',NULL,'2015-12-02','clift.m@uranus.net','279 Vernon Av.','Waycross','GA','38817','172-030-9435','Spanish-American War'),(36,'Neumeyer','Rick',NULL,'2017-05-01','n_rick@uranus.net','664 Sunrise Tr.','Fort Myers','FL','25372','399-169-0661','World War I,Education'),(37,'Hughes','Max','Jr.','2016-09-16',NULL,'814 Ridge Rd.','Huntsville','AL','84310','374-364-4212','Vietnam War,World War II'),(38,'Haug','Linda',NULL,'2017-01-22','linda.haug@pluto.com','746 White Aspen Rd.','Red Bank','TN','22540','948-014-3619','Revolutionary War,Sports,Civil War'),(39,'Mitchell','Eugene',NULL,'2017-04-08','mitchell_e@saturn.org','38 Rustling Oaks Ln.','Hazard','KY','66948','299-337-0004','Presidential politics,World War II,Great Depression,Lincoln,Roosevelt'),(40,'Brower','Paul',NULL,'2016-10-04','paul_brower@saturn.org','238 Barber Dr.','Ocean City','MD','55179','821-905-7597','Armed services,Gold rush,Civil Rights'),(41,'Welch','Jacob',NULL,NULL,'welch.jacob@jupiter.com','512 Madison St.','Wilmington','NJ','10507','913-715-6335','Westward movement'),(42,'Schenk','Cindy',NULL,'2013-03-22',NULL,'542 W. Hudson Rd.','Waterbury','CT','98847','681-415-6637','Founding fathers,Education,Great Depression,Armed services'),(43,'Brown','Gary',NULL,'2016-11-17','gary_brown@pluto.com','342 Marathon Dr.','Providence','RI','14536','612-355-2509','Cold War,Founding fathers,Civil Rights'),(44,'Williams','Darrell',NULL,'2015-03-31','w_darrell@uranus.net','228 E. Johnson St.','Springfield','MA','90181','878-397-4390','Spanish-American War,Revolutionary War,Presidential politics,Sports'),(45,'Block','Christopher',NULL,'2015-07-03','christopher_b@mercury.net','606 Cumberland Ln.','Bruneau','ID','58790','015-680-8696','Colonial period,Spanish-American War,Civil Rights,Education,Presidential politics'),(46,'Thompson','Joan',NULL,'2015-04-26','joan_thompson@venus.org','182 Spaight St.','Roy','NM','25129','798-188-9411','Colonial period,Presidential politics,Abolition,Civil War,Roosevelt'),(47,'Bookstaff','Barbara',NULL,'2014-10-07','bookstaff.b@earth.com','289 Lancashier Ct.','Durango','CO','17762','175-857-5726','Civil War,Industrial revolution'),(48,'Kirby','Timothy',NULL,NULL,NULL,'298 Hollister Av.','Kayenta','AZ','82432','844-673-6051','Colonial period,immigration,Civil War'),(49,'Simmons','David',NULL,'2016-08-31','simmons.david@mercury.net','793 S. Henry St.','Trona','CA','35986','645-327-1588','Civil War,Colonial period'),(50,'Renko','Jan',NULL,'2017-04-27','jan_r@earth.com','296 Dunn Av.','Fallon','NV','04507','344-923-2885','Lincoln,Founding fathers,War of 1812'),(51,'Godfriaux','Harlan',NULL,'2012-12-20','godfriaux_harlan@earth.com','1100 State Rd.','Provo','UT','04896','077-406-7491','World War I,Social Security'),(52,'Little','Margaret',NULL,'2012-10-16',NULL,'8702 Gannon Rd.','Worland','WY','46326','817-461-1949','World War I,Civil Rights,Armed services'),(53,'Weiss','Nicole',NULL,'2015-11-20','nicole.w@mars.net','4488 E. Harmony Dr.','Burns','OR','92532','898-181-7231','World War II,Sports,Spanish-American War,World War I,Civil Rights'),(54,'Olson','Maureen',NULL,'2014-06-07','maureen_olson@venus.org','8388 W. Holt Rd.','Moses Lake','WA','32534','936-060-5258','War of 1812,Roosevelt,Great Depression,Education'),(55,'Cutrell','Michelle',NULL,'2014-02-20',NULL,'1702 Lynne Tr.','Crow Agency','MT','26764','454-457-6125','Great Depression,Roosevelt,Korean War,Social Security'),(56,'Matthews','Bill','Sr.','2015-09-15','matthews.b@saturn.org','9902 Mound St.','Fairbanks','AK','54214','743-150-3797','Colonial period,Revolutionary War'),(57,'Desmond','Clifford',NULL,'2015-06-21','clifford.d@mars.net','4939 Clemons Av.','Kalaheo','HI','26295','776-381-1029','Revolutionary War,World War II,Sports'),(58,'Karn','Simon',NULL,'2016-06-25','k.simon@mars.net','5664 Northridge Ter.','Detroit','MI','34483','712-898-0397','Social Security,Armed services'),(59,'Puntillo','Cheryl',NULL,'2016-12-08','puntillo.c@saturn.org','1270 Kupfer Rd.','Los Angeles','CA','66350','057-300-6645','Education,Cold War,Lincoln,Great Depression,Civil War'),(60,'Camosy','Alan',NULL,'2015-08-23','alan.camosy@pluto.com','15 Kenwood Cir.','Dallas','TX','49786','443-837-6502','Colonial period,Armed services'),(61,'Fassbinder','Valerie',NULL,'2013-07-16',NULL,'5364 Kingston Dr.','Chicago','IL','92813','316-294-6204','Social Security'),(62,'Mcbride','Zachary',NULL,'2015-05-28','mcbride.zachary@venus.org','7849 Martinsville Rd.','Philadelphia','PA','44712','041-786-7072','Sports,Founding fathers,Civil Rights,Great Depression'),(63,'Artel','Mike',NULL,'2016-04-16','mike_artel@venus.org','4264 Lovering Rd.','Miami','FL','12777','075-961-0712','Civil Rights,Education,Revolutionary War'),(64,'Grum','Brenda',NULL,'2017-02-28','brenda.g@neptune.org','8835 School Rd.','New Orleans','LA','88929','119-173-2910','Social Security,Korean War,Civil War,Presidential politics,Roosevelt'),(65,'Schauer','Alma',NULL,'2013-04-25','alma_schauer@venus.org','9625 Topeka Tr.','Mobile','AL','87779','520-883-0715','Cold War,Industrial revolution,Gold rush,Colonial period'),(66,'Kohn','Jane',NULL,'2016-04-03','kohn.j@mercury.net','4961 Pertzborn Dr.','Milwaukee','WI','56155','248-993-0148','War of 1812'),(67,'Page','Sarah',NULL,'2015-02-06','p_sarah@saturn.org','34 Harvest Ln.','St. Paul','MN','02590','520-343-3572','Vietnam War,immigration,Industrial revolution'),(68,'Popham','Robert',NULL,'2015-06-11',NULL,'26 Arizona Cir.','Portland','OR','60820','896-249-4929','Westward movement,Constitution,Armed services,Civil Rights,Abolition'),(69,'Segovia','Brian',NULL,'2017-06-15','brian_s@mars.net','7814 Indian Mound Dr.','Seattle','WA','31340','198-008-3769','Constitution,Industrial revolution,Vietnam War,Colonial period,Sports'),(70,'Freeman','Vincent',NULL,'2014-07-07','freeman.vincent@venus.org','7 Nightingale Ct.','Cody','WY','45797','820-681-3578','World War II,Presidential politics'),(71,'Vines','Toby',NULL,'2013-04-18','t.vines@pluto.com','2750 Oakview Dr.','Coral Gables','FL','20248','718-155-2528','Abolition,Gold rush,World War II'),(72,'Walton','Philp',NULL,'2015-10-09',NULL,'8527 Manitowoc Pkwy.','Lincoln','NE','68799','112-725-0105','Social Security,Founding fathers'),(73,'Abbs','Ron',NULL,'2016-10-25','ron.abbs@neptune.org','77 Beech Ct.','Harrisburg','PA','61511','502-098-0216','Revolutionary War,Spanish-American War,Colonial period,Gold rush,Lincoln'),(74,'Grogan','Vladimir',NULL,'2012-10-25','vladimir_grogan@earth.com','3263 Gilbert Rd.','Ithaca','NY','99357','332-511-5038','Great Depression,Spanish-American War'),(75,'Elgar','Clarence','Jr.','2016-03-22','clarence.elgar@mercury.net','4162 Lakewood Blvd.','Lewiston','ME','48157','992-123-4497','Sports,Armed services'),(76,'Johnson','Robin',NULL,'2017-06-08','robin_j@neptune.org','5606 McKenna Blvd.','Lynchburg','VA','22514','518-780-8914','Constitution,Civil War,Cold War,immigration,Civil Rights'),(77,'Damron','Sandra',NULL,'2013-07-05','s.damron@saturn.org','5024 Craig Av.','Lima','OH','10716','132-700-4450','Sports'),(78,'Dahl','Andrew',NULL,'2016-12-27','andrew.dahl@venus.org','9658 Lynchburg Tr.','Fort Wayne','IN','49606','169-982-0224','War of 1812'),(79,'Albright','Warren',NULL,NULL,NULL,'3740 Privett Rd.','Dodge City','KS','08952','364-454-4966','Social Security,Revolutionary War,Colonial period,Vietnam War'),(80,'Beckett','Luther',NULL,'2014-06-06','luther.b@mars.net','148 Greenbriar Dr.','Sonora','TX','52841','778-028-6040','Spanish-American War'),(81,'Brooks','Carl',NULL,'2015-09-12','brooks_carl@jupiter.com','8755 Dapin Rd.','Sarasota','FL','19735','514-906-3111','War of 1812,Vietnam War,Civil Rights,World War II,Gold rush'),(82,'Edwards','John',NULL,'2012-09-12','john_edwards@venus.org','2218 Heath Av.','Dothan','AL','98158','442-861-2459','Founding fathers,Spanish-American War,Korean War,Vietnam War'),(83,'Brophy','Vickie',NULL,'2016-07-13','vickie_b@uranus.net','1919 Jay Dr.','Alexandria','LA','28794','596-490-7991','War of 1812,Vietnam War,Korean War,Founding fathers'),(84,'Aronson','Nancy',NULL,'2017-06-16','nancy.a@mercury.net','1254 Stagecoach Tr.','Ashland','KY','43979','414-089-0344','War of 1812,Civil War'),(85,'Fiorelli','Neil',NULL,'2015-11-07','fiorelli.neil@mercury.net','5599 Constitution Dr.','Ashland','WI','85083','379-922-7719','Social Security,Spanish-American War,Cold War,World War I'),(86,'Robson','Chris',NULL,'2012-10-28','chris_r@venus.org','8229 Ravenswood Rd.','Chicago','IL','73252','052-949-4117','Korean War,World War I'),(87,'Morris','Andrea',NULL,'2015-03-23',NULL,'530 W. Wilson St.','New York','NY','45606','158-240-4142','World War II'),(88,'Pierson','Stanley',NULL,NULL,'pierson.s@jupiter.com','3810 Northbrook Dr.','Los Angeles','CA','51336','157-304-8749','World War I,Sports'),(89,'Garner','Steve',NULL,'2012-08-03','g.steve@pluto.com','48 Walworth Ct.','Denver','CO','96363','765-848-4515','Gold rush'),(90,'Stehle','Joseph',NULL,'2015-11-13','s.joseph@venus.org','3688 N. Franklin St.','San Antonio','TX','92419','217-542-0789','Industrial revolution,Lincoln,Gold rush,Civil War'),(91,'Downing','Fred',NULL,'2016-05-23','fred_downing@mercury.net','54 Klamer Rd.','Austin','TX','81042','601-143-5252','Great Depression'),(92,'Gladden','Jerome',NULL,'2016-06-19',NULL,'62 Gust Rd.','Detroit','MI','74586','083-144-0721','Korean War,Cold War,Abolition,Spanish-American War'),(93,'Forman','Kevin',NULL,'2013-08-25','kevin.forman@neptune.org','60 Drake St.','Miami','FL','92344','259-329-7863','Presidential politics'),(94,'Harrington','James',NULL,'2017-07-19','james.harrington@earth.com','155 Admiral Dr.','Atlanta','GA','75541','677-105-5966','Roosevelt,Civil War,Lincoln,Civil Rights,immigration'),(95,'Alvis','Michael','IV','2014-04-17','alvis_michael@mars.net','176 Sand Hill Rd.','Philadelphia','PA','38728','203-319-3633','Education,War of 1812,World War II,Armed services'),(96,'Caputo','Eileen',NULL,'2014-01-30','caputo_e@uranus.net','151 Westport Rd.','Seattle','WA','50175','781-213-8580','World War II,Westward movement'),(97,'Harrison','Marita',NULL,'2014-11-07','marita_harrison@earth.com','64 Delaware Dr.','Portland','OR','57577','927-099-6116','Great Depression,Founding fathers,Gold rush,Korean War'),(98,'Smith','Laura',NULL,'2016-05-27','s.laura@neptune.org','5 Post Rd.','San Francisco','CA','75247','724-664-7207','Armed services,immigration,Civil Rights,Great Depression,Vietnam War'),(99,'Sprague','Earl',NULL,'2014-04-18',NULL,'145 N. Thompson Dr.','Oakland','CA','12801','678-463-3510','Lincoln,Korean War,Westward movement'),(100,'Worthington','Ralph',NULL,'2015-05-01','ralph_worthington@jupiter.com','25 Upman St.','Laramie','WY','49984','126-109-9886','Civil Rights,War of 1812,Korean War,Sports,Colonial period'),(101,'Corning','Sonya',NULL,'2016-09-16','sonya.c@jupiter.com','14 Crown Rd.','Lincoln','NE','76293','835-693-7968','Civil War,Sports,Armed services,Spanish-American War,Social Security'),(102,'Clark','Dale',NULL,'2017-08-23',NULL,'958 Sigmont Blvd.','Fort Worth','TX','83720','365-784-5634','Vietnam War,Civil Rights,Roosevelt,Lincoln'),(103,'James','Parsons',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `member` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `pres_age`
--

DROP TABLE IF EXISTS `pres_age`;
/*!50001 DROP VIEW IF EXISTS `pres_age`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `pres_age` AS SELECT 
 1 AS `last_name`,
 1 AS `first_name`,
 1 AS `birth`,
 1 AS `death`,
 1 AS `age`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `pres_age_in_office`
--

DROP TABLE IF EXISTS `pres_age_in_office`;
/*!50001 DROP VIEW IF EXISTS `pres_age_in_office`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `pres_age_in_office` AS SELECT 
 1 AS `last_name`,
 1 AS `first_name`,
 1 AS `birth`,
 1 AS `death`,
 1 AS `age`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `pres_term`
--

DROP TABLE IF EXISTS `pres_term`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pres_term` (
  `pres_id` int(4) unsigned NOT NULL,
  `term start date` date NOT NULL,
  `term End date` date DEFAULT NULL,
  `number of elections won` int(2) unsigned NOT NULL,
  `reason for leaving office` varchar(50) DEFAULT NULL,
  `term_id` int(3) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`term_id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pres_term`
--

LOCK TABLES `pres_term` WRITE;
/*!40000 ALTER TABLE `pres_term` DISABLE KEYS */;
INSERT INTO `pres_term` VALUES (2,'1797-03-04','1801-03-04',1,'Lost reelection',1),(3,'1801-03-04','1809-03-04',2,'Did not seek reelection',2),(4,'1809-03-04','1817-03-04',2,'Did not seek reelection',3),(5,'1817-03-04','1825-03-04',2,'Did not seek reelection',4),(6,'1825-03-04','1829-03-04',1,'Lost reelection',5),(7,'1829-03-04','1837-03-04',2,'Did not seek reelection',6),(8,'1837-03-04','1841-03-04',2,'Did not seek reelection',7),(9,'1841-03-04','1841-04-04',1,'Died in office',8),(10,'1841-04-04','1845-03-04',0,'Did not seek reelection',9),(11,'1845-03-04','1849-03-04',1,'Did not seek reelection',10),(12,'1849-03-04','1850-07-09',1,'Died in office',11),(13,'1850-07-09','1853-03-04',0,'Did not seek reelection¹',12),(14,'1853-03-04','1857-03-04',1,'Did not seek reelection¹ ',13),(15,'1857-03-04','1861-03-04',1,'Did not seek reelection',14),(16,'1861-03-04','1865-04-15',1,'Assassinated',15),(17,'1865-04-15','1869-03-04',0,'Did not seek reelection',16),(18,'1869-03-04','1877-03-04',2,'Did not seek reelection',17),(19,'1877-03-04','1881-03-04',1,'Did not seek reelection',18),(20,'1881-03-04','1881-09-09',1,'Assassinated',19),(21,'1881-09-09','1885-03-04',0,'Did not seek reelection',20),(22,'1885-03-04','1889-03-04',1,'Lost reelection',21),(23,'1889-03-04','1893-03-04',1,'Lost reelection',22),(22,'1893-03-04','1897-03-04',1,'Did not seek reelection',23),(24,'1897-03-04','1901-09-14',2,'Assassinated',24),(25,'1901-09-14','1909-03-04',1,'Did not seek reelection',25),(26,'1909-03-04','1913-03-04',1,'Lost reelection',26),(27,'1913-03-04','1921-03-04',2,'Did not seek reelection',27),(28,'1921-03-04','1923-08-02',1,'Died in office',28),(29,'1923-08-02','1929-03-04',1,'Did not seek reelection',29),(30,'1929-03-04','1933-03-04',1,'Lost reelection',30),(31,'1933-03-04','1945-04-12',4,'Died in office',31),(32,'1945-04-12','1953-01-20',1,'Did not seek reelection',32),(33,'1953-01-20','1961-01-20',2,'Term ended',33),(34,'1961-01-20','1963-11-22',1,'Assassinated',34),(35,'1963-11-22','1969-01-20',1,'Did not seek reelection',35),(36,'1969-01-20','1974-08-09',2,'Resigned',36),(37,'1974-08-09','1977-01-20',0,'Lost election ',37),(38,'1977-01-20','1981-01-20',1,'Lost reelection',38),(39,'1981-01-20','1989-01-20',2,'Term ended',39),(40,'1989-01-20','1993-01-20',1,'Lost reelection',40),(41,'1993-01-20','2001-01-20',2,'Term ended ',41),(42,'2001-01-20','2009-01-20',2,'Term ended ',42),(43,'2009-01-20',NULL,2,NULL,43);
/*!40000 ALTER TABLE `pres_term` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `president`
--

DROP TABLE IF EXISTS `president`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `president` (
  `last_name` varchar(15) NOT NULL,
  `first_name` varchar(15) NOT NULL,
  `suffix` varchar(5) DEFAULT NULL,
  `city` varchar(20) NOT NULL,
  `state` varchar(2) NOT NULL,
  `birth` date NOT NULL,
  `death` date DEFAULT NULL,
  `pres_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`pres_id`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `president`
--

LOCK TABLES `president` WRITE;
/*!40000 ALTER TABLE `president` DISABLE KEYS */;
INSERT INTO `president` VALUES ('Washington','George',NULL,'Wakefield','VA','1732-02-22','1799-12-14',1),('Adams','John',NULL,'Braintree','MA','1735-10-30','1826-07-04',2),('Jefferson','Thomas',NULL,'Albemarle County','VA','1743-04-13','1826-07-04',3),('Madison','James',NULL,'Port Conway','VA','1751-03-16','1836-06-28',4),('Monroe','James',NULL,'Westmoreland County','VA','1758-04-28','1831-07-04',5),('Adams','John Quincy',NULL,'Braintree','MA','1767-07-11','1848-02-23',6),('Jackson','Andrew',NULL,'Waxhaw settlement','SC','1767-03-15','1845-06-08',7),('Van Buren','Martin',NULL,'Kinderhook','NY','1782-12-05','1862-07-24',8),('Harrison','William H.',NULL,'Berkeley','VA','1773-02-09','1841-04-04',9),('Tyler','John',NULL,'Greenway','VA','1790-03-29','1862-01-18',10),('Polk','James K.',NULL,'Pineville','NC','1795-11-02','1849-06-15',11),('Taylor','Zachary',NULL,'Orange County','VA','1784-11-24','1850-07-09',12),('Fillmore','Millard',NULL,'Locke','NY','1800-01-07','1874-03-08',13),('Pierce','Franklin',NULL,'Hillsboro','NH','1804-11-23','1869-10-08',14),('Buchanan','James',NULL,'Mercersburg','PA','1791-04-23','1868-06-01',15),('Lincoln','Abraham',NULL,'Hodgenville','KY','1809-02-12','1865-04-15',16),('Johnson','Andrew',NULL,'Raleigh','NC','1808-12-29','1875-07-31',17),('Grant','Ulysses S.',NULL,'Point Pleasant','OH','1822-04-27','1885-07-23',18),('Hayes','Rutherford B.',NULL,'Delaware','OH','1822-10-04','1893-01-17',19),('Garfield','James A.',NULL,'Orange','OH','1831-11-19','1881-09-19',20),('Arthur','Chester A.',NULL,'Fairfield','VT','1829-10-05','1886-11-18',21),('Cleveland','Grover',NULL,'Caldwell','NJ','1837-03-18','1908-06-24',22),('Harrison','Benjamin',NULL,'North Bend','OH','1833-08-20','1901-03-13',23),('McKinley','William',NULL,'Niles','OH','1843-01-29','1901-09-14',24),('Roosevelt','Theodore',NULL,'New York','NY','1858-10-27','1919-01-06',25),('Taft','William H.',NULL,'Cincinnati','OH','1857-09-15','1930-03-08',26),('Wilson','Woodrow',NULL,'Staunton','VA','1856-12-19','1924-02-03',27),('Harding','Warren G.',NULL,'Blooming Grove','OH','1865-11-02','1923-08-02',28),('Coolidge','Calvin',NULL,'Plymouth Notch','VT','1872-07-04','1933-01-05',29),('Hoover','Herbert C.',NULL,'West Branch','IA','1874-08-10','1964-10-20',30),('Roosevelt','Franklin D.',NULL,'Hyde Park','NY','1882-01-30','1945-04-12',31),('Truman','Harry S',NULL,'Lamar','MO','1884-05-08','1972-12-26',32),('Eisenhower','Dwight D.',NULL,'Denison','TX','1890-10-14','1969-03-28',33),('Kennedy','John F.',NULL,'Brookline','MA','1917-05-29','1963-11-22',34),('Johnson','Lyndon B.',NULL,'Stonewall','TX','1908-08-27','1973-01-22',35),('Nixon','Richard M.',NULL,'Yorba Linda','CA','1913-01-09','1994-04-22',36),('Ford','Gerald R.',NULL,'Omaha','NE','1913-07-14','2006-12-26',37),('Carter','James E.','Jr.','Plains','GA','1924-10-01',NULL,38),('Reagan','Ronald W.',NULL,'Tampico','IL','1911-02-06','2004-06-05',39),('Bush','George H.W.',NULL,'Milton','MA','1924-06-12',NULL,40),('Clinton','William J.',NULL,'Hope','AR','1946-08-19',NULL,41),('Bush','George W.',NULL,'New Haven','CT','1946-07-06',NULL,42),('Obama','Barack H.',NULL,'Honolulu','HI','1961-08-04',NULL,43),('Obama','Barak',NULL,'Honolulu','HA','1961-08-04',NULL,44);
/*!40000 ALTER TABLE `president` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `score`
--

DROP TABLE IF EXISTS `score`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `score` (
  `student_id` int(10) unsigned NOT NULL,
  `event_id` int(10) unsigned NOT NULL,
  `score` int(11) NOT NULL,
  PRIMARY KEY (`event_id`,`student_id`),
  KEY `student_id` (`student_id`),
  CONSTRAINT `score_ibfk_1` FOREIGN KEY (`event_id`) REFERENCES `grade_event` (`event_id`),
  CONSTRAINT `score_ibfk_2` FOREIGN KEY (`student_id`) REFERENCES `student` (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `score`
--

LOCK TABLES `score` WRITE;
/*!40000 ALTER TABLE `score` DISABLE KEYS */;
INSERT INTO `score` VALUES (1,1,20),(3,1,20),(4,1,18),(5,1,13),(6,1,18),(7,1,14),(8,1,14),(9,1,11),(10,1,19),(11,1,18),(12,1,19),(14,1,11),(15,1,20),(16,1,18),(17,1,9),(18,1,20),(19,1,9),(20,1,9),(21,1,13),(22,1,13),(23,1,16),(24,1,11),(25,1,19),(26,1,10),(27,1,15),(28,1,15),(29,1,19),(30,1,17),(31,1,11),(1,2,17),(2,2,8),(3,2,13),(4,2,13),(5,2,17),(6,2,13),(7,2,17),(8,2,8),(9,2,19),(10,2,18),(11,2,15),(12,2,19),(13,2,18),(14,2,18),(15,2,16),(16,2,9),(17,2,13),(18,2,9),(19,2,11),(21,2,12),(22,2,10),(23,2,17),(24,2,19),(25,2,10),(26,2,18),(27,2,8),(28,2,13),(29,2,16),(30,2,12),(31,2,19),(1,3,88),(2,3,84),(3,3,69),(4,3,71),(5,3,97),(6,3,83),(7,3,88),(8,3,75),(9,3,83),(10,3,72),(11,3,74),(12,3,77),(13,3,67),(14,3,68),(15,3,75),(16,3,60),(17,3,79),(18,3,96),(19,3,79),(20,3,76),(21,3,91),(22,3,81),(23,3,81),(24,3,62),(25,3,79),(26,3,86),(27,3,90),(28,3,68),(29,3,66),(30,3,79),(31,3,81),(2,4,7),(3,4,17),(4,4,16),(5,4,20),(6,4,9),(7,4,19),(8,4,12),(9,4,17),(10,4,12),(11,4,16),(12,4,13),(13,4,8),(14,4,11),(15,4,9),(16,4,20),(18,4,11),(19,4,15),(20,4,17),(21,4,13),(22,4,20),(23,4,13),(24,4,12),(25,4,10),(26,4,15),(28,4,17),(30,4,11),(31,4,19),(1,5,15),(2,5,12),(3,5,11),(5,5,13),(6,5,18),(7,5,14),(8,5,13),(9,5,18),(10,5,14),(11,5,18),(12,5,8),(13,5,8),(14,5,16),(15,5,13),(16,5,15),(17,5,11),(18,5,18),(19,5,18),(20,5,14),(21,5,17),(22,5,17),(23,5,15),(25,5,14),(26,5,8),(28,5,20),(29,5,16),(31,5,9),(1,6,100),(2,6,91),(3,6,94),(4,6,74),(5,6,97),(6,6,89),(7,6,76),(8,6,65),(9,6,73),(10,6,63),(11,6,98),(12,6,75),(14,6,77),(15,6,62),(16,6,98),(17,6,94),(18,6,94),(19,6,74),(20,6,62),(21,6,73),(22,6,95),(24,6,68),(25,6,85),(26,6,91),(27,6,70),(28,6,77),(29,6,66),(30,6,68),(31,6,76);
/*!40000 ALTER TABLE `score` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student` (
  `name` varchar(20) NOT NULL,
  `sex` enum('F','M') NOT NULL,
  `student_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB AUTO_INCREMENT=71 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES ('Megan','F',1),('Joseph','M',2),('Kyle','M',3),('Katie','F',4),('Abby','F',5),('Nathan','M',6),('Liesl','F',7),('Ian','M',8),('Colin','M',9),('Peter','M',10),('Michael','M',11),('Thomas','M',12),('Devri','F',13),('Ben','M',14),('Aubrey','F',15),('Rebecca','F',16),('Will','M',17),('Max','M',18),('Rianne','F',19),('Avery','F',20),('Lauren','F',21),('Becca','F',22),('Gregory','M',23),('Sarah','F',24),('Robbie','M',25),('Keaton','M',26),('Carter','M',27),('Teddy','M',28),('Gabrielle','F',29),('Grace','F',30),('Emily','F',31),('James Parsons','M',32),('Francis','F',33),('Xavier','M',34),('Poppy Head','F',70);
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vstudent`
--

DROP TABLE IF EXISTS `vstudent`;
/*!50001 DROP VIEW IF EXISTS `vstudent`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vstudent` AS SELECT 
 1 AS `student_id`,
 1 AS `name`,
 1 AS `date`,
 1 AS `score`,
 1 AS `category`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `pres_age`
--

/*!50001 DROP VIEW IF EXISTS `pres_age`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `pres_age` AS select `president`.`last_name` AS `last_name`,`president`.`first_name` AS `first_name`,`president`.`birth` AS `birth`,`president`.`death` AS `death`,timestampdiff(YEAR,`president`.`birth`,`president`.`death`) AS `age` from `president` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `pres_age_in_office`
--

/*!50001 DROP VIEW IF EXISTS `pres_age_in_office`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `pres_age_in_office` AS select `president`.`last_name` AS `last_name`,`president`.`first_name` AS `first_name`,`president`.`birth` AS `birth`,`president`.`death` AS `death`,timestampdiff(YEAR,`president`.`birth`,`president`.`death`) AS `age` from `president` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vstudent`
--

/*!50001 DROP VIEW IF EXISTS `vstudent`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vstudent` AS select `student`.`student_id` AS `student_id`,`student`.`name` AS `name`,`grade_event`.`date` AS `date`,`score`.`score` AS `score`,`grade_event`.`category` AS `category` from ((`grade_event` join `score`) join `student` on(((`grade_event`.`event_id` = `score`.`event_id`) and (`score`.`student_id` = `student`.`student_id`)))) order by `student`.`name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-04-17  6:21:52
