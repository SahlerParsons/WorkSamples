-- MySQL Script generated by MySQL Workbench
-- Tue Apr 17 06:36:23 2018
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema videostore
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema videostore
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `videostore` DEFAULT CHARACTER SET utf8 ;
USE `videostore` ;

-- -----------------------------------------------------
-- Table `videostore`.`customer`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `videostore`.`customer` (
  `customerID` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `FirstName` VARCHAR(45) NOT NULL,
  `LastName` VARCHAR(45) NOT NULL,
  `BirthDate` DATE NULL DEFAULT NULL,
  `Address` VARCHAR(45) NOT NULL,
  `Phone` INT(11) NOT NULL,
  `Email` VARCHAR(60) NOT NULL,
  PRIMARY KEY (`customerID`))
ENGINE = InnoDB
AUTO_INCREMENT = 11
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `videostore`.`video`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `videostore`.`video` (
  `videoID` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(100) NOT NULL,
  `genre` VARCHAR(20) NOT NULL,
  `director` VARCHAR(50) NOT NULL,
  `producer` VARCHAR(50) NOT NULL,
  `year` DATE NOT NULL,
  `actor1` VARCHAR(50) NULL DEFAULT NULL,
  `actor2` VARCHAR(45) NULL DEFAULT NULL,
  `rented` TINYINT(3) UNSIGNED NULL DEFAULT NULL,
  PRIMARY KEY (`videoID`))
ENGINE = InnoDB
AUTO_INCREMENT = 21
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `videostore`.`rental`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `videostore`.`rental` (
  `rentalID` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `customerID` INT(10) UNSIGNED NOT NULL,
  `videoID` INT(10) UNSIGNED NOT NULL,
  `dateRented` DATETIME NOT NULL,
  `duedate` DATETIME NOT NULL,
  `dateReturned` DATETIME NOT NULL,
  `daysLate` INT(2) UNSIGNED ZEROFILL NULL DEFAULT NULL,
  `feeCharge` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`rentalID`, `customerID`, `videoID`),
  INDEX `fk_customerID_idx` (`customerID` ASC),
  INDEX `fk_videoID_idx` (`videoID` ASC),
  CONSTRAINT `fk_customerID`
    FOREIGN KEY (`customerID`)
    REFERENCES `videostore`.`customer` (`customerID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_videoID`
    FOREIGN KEY (`videoID`)
    REFERENCES `videostore`.`video` (`videoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;

USE `videostore` ;

-- -----------------------------------------------------
-- Placeholder table for view `videostore`.`late_rental`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `videostore`.`late_rental` (`customerid` INT, `dateRented` INT, `duedate` INT, `datereturned` INT, `dayslate` INT);

-- -----------------------------------------------------
-- Placeholder table for view `videostore`.`late_rental2`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `videostore`.`late_rental2` (`customerid` INT, `dateRented` INT, `dateReturned` INT, `dayslate` INT);

-- -----------------------------------------------------
-- View `videostore`.`late_rental`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `videostore`.`late_rental`;
USE `videostore`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `videostore`.`late_rental` AS select `videostore`.`rental`.`customerID` AS `customerid`,`videostore`.`rental`.`dateRented` AS `dateRented`,`videostore`.`rental`.`duedate` AS `duedate`,`videostore`.`rental`.`dateReturned` AS `datereturned`,timestampdiff(DAY,`videostore`.`rental`.`duedate`,`videostore`.`rental`.`dateReturned`) AS `dayslate` from `videostore`.`rental`;

-- -----------------------------------------------------
-- View `videostore`.`late_rental2`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `videostore`.`late_rental2`;
USE `videostore`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `videostore`.`late_rental2` AS select `videostore`.`rental`.`customerID` AS `customerid`,date_format(`videostore`.`rental`.`dateRented`,'%d/%m/%Y') AS `dateRented`,date_format(`videostore`.`rental`.`dateReturned`,'%d/%m/%Y') AS `dateReturned`,timestampdiff(DAY,`videostore`.`rental`.`duedate`,`videostore`.`rental`.`dateReturned`) AS `dayslate` from `videostore`.`rental`;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
