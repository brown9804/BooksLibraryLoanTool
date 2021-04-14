SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `B_D_Belinda_Bibliioteca_CLA` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `B_D_Belinda_Bibliioteca_CLA` ;

-- -----------------------------------------------------
-- Table `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_CLA_Libros`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_CLA_Libros` (
  `cod_lib_B_D_Biblioteca_CLA_Libros` INT NOT NULL ,
  `tit_lib_B_D_Biblioteca_CLA_Libros` VARCHAR(50) NOT NULL ,
  `descrip_libr_B_D_Biblioteca_CLA_Libros` VARCHAR(150) NOT NULL ,
  `categ_lib_B_D_Biblioteca_CLA_Libros` VARCHAR(30) NOT NULL ,
  `edito_lib_B_D_Biblioteca_CLA_Libros` VARCHAR(35) NOT NULL ,
  `autor_lib_B_D_Biblioteca_CLA_Libros` VARCHAR(25) NOT NULL ,
  `idio_lib_B_D_Biblioteca_CLA_Libros` VARCHAR(15) NOT NULL ,
  `año_lib_B_D_Biblioteca_CLA_Libros` INT NOT NULL ,
  `cant_lib_B_D_Biblioteca_CLA_Libros` INT NOT NULL ,
  `cost_lib_B_D_Biblioteca_CLA_Libros` INT NOT NULL ,
  `obser_lib_B_D_Biblioteca_CLA_Libros` VARCHAR(150) NOT NULL ,
  PRIMARY KEY (`cod_lib_B_D_Biblioteca_CLA_Libros`) ,
  UNIQUE INDEX `cod_lib_B_D_Biblioteca_CLA_Libros_UNIQUE` (`cod_lib_B_D_Biblioteca_CLA_Libros` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_Alumnos`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_Alumnos` (
  `ced_alum_B_D_Biblioteca_Alumnos` VARCHAR(11) NOT NULL ,
  `nom_alum_B_D_Biblioteca_Alumnos` VARCHAR(15) NOT NULL ,
  `ape_alum_B_D_Biblioteca_Alumnos` VARCHAR(25) NOT NULL ,
  `telef_alum_B_D_Biblioteca_Alumnos` VARCHAR(11) NOT NULL ,
  `genero_alum_B_D_Biblioteca_Alumnos` VARCHAR(10) NOT NULL ,
  `dire_alum_B_D_Biblioteca_Alumnos` VARCHAR(150) NOT NULL ,
  `email_alum_B_D_Biblioteca_Alumnos` VARCHAR(55) NOT NULL ,
  `obser_alum_B_D_Biblioteca_Alumnos` VARCHAR(150) NOT NULL ,
  PRIMARY KEY (`ced_alum_B_D_Biblioteca_Alumnos`) ,
  UNIQUE INDEX `ced_alum_B_D_Biblioteca_CLA_Libros_UNIQUE` (`ced_alum_B_D_Biblioteca_Alumnos` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_CLA_Prestamos`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_CLA_Prestamos` (
  `cod_pres_B_D_Biblioteca_CLA_Prestamos` INT NOT NULL ,
  `ced_alum_B_D_Biblioteca_CLA_Prestamos` VARCHAR(11) NOT NULL ,
  `nom_alum_B_D_Biblioteca_CLA_Prestamos` VARCHAR(15) NOT NULL ,
  `ape_alum_B_D_Biblioteca_CLA_Prestamos` VARCHAR(25) NOT NULL ,
  `cod_lib_B_D_Biblioteca_CLA_Prestamos` INT NOT NULL ,
  `fech_pres_B_D_Biblioteca_CLA_Prestamos` VARCHAR(10) NOT NULL ,
  `fech_entr_B_D_Biblioteca_CLA_Prestamos` VARCHAR(10) NOT NULL ,
  `obser_B_D_Biblioteca_CLA_Prestamos` VARCHAR(150) NOT NULL ,
  `tit_lib_B_D_Biblioteca_CLA_Prestamos` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`cod_pres_B_D_Biblioteca_CLA_Prestamos`) ,
  UNIQUE INDEX `cod_pres_B_D_Biblioteca_CLA_Prestamos_UNIQUE` (`cod_pres_B_D_Biblioteca_CLA_Prestamos` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_CLA_Devolucion`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_CLA_Devolucion` (
  `cod_dev_B_D_Biblioteca_CLA_Devolucion` INT NOT NULL ,
  `cod_lib_B_D_Biblioteca_CLA_Devolucion` INT NOT NULL ,
  `ced_alum_B_D_Biblioteca_CLA_Devolucion` VARCHAR(11) NOT NULL ,
  `nom_alum_B_D_Biblioteca_CLA_Devolucion` VARCHAR(15) NOT NULL ,
  `ape_alum_B_D_Biblioteca_CLA_Devolucion` VARCHAR(25) NOT NULL ,
  `fech_pres_B_D_Biblioteca_CLA_Devolucion` VARCHAR(10) NOT NULL ,
  `tip_dev_B_D_Biblioteca_CLA_Devolucion` VARCHAR(10) NOT NULL ,
  `tip_cob_B_D_Biblioteca_CLA_Devolucion` VARCHAR(10) NOT NULL ,
  `mont_cob_B_D_Biblioteca_CLA_Devolucion` INT NOT NULL ,
  `mont_pag_B_D_Biblioteca_CLA_Devolucion` INT NOT NULL ,
  `camb_B_D_Biblioteca_CLA_Devolucion` INT NOT NULL ,
  PRIMARY KEY (`cod_dev_B_D_Biblioteca_CLA_Devolucion`) ,
  UNIQUE INDEX `cod_dev_B_D_Biblioteca_CLA_Devolucion_UNIQUE` (`cod_dev_B_D_Biblioteca_CLA_Devolucion` ASC) )
ENGINE = InnoDB;

USE `B_D_Belinda_Bibliioteca_CLA` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
