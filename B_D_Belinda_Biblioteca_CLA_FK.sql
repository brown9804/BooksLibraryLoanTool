SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

ALTER TABLE `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_CLA_Prestamos` 
  ADD CONSTRAINT `ced_alum_B_D_Biblioteca_CLA_Prestamos_FK`
  FOREIGN KEY (`ced_alum_B_D_Biblioteca_CLA_Prestamos` )
  REFERENCES `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_Alumnos` (`ced_alum_B_D_Biblioteca_Alumnos` )
  ON DELETE NO ACTION
  ON UPDATE NO ACTION, 
  ADD CONSTRAINT `cod_lib_B_D_Biblioteca_CLA_Prestamos_FK`
  FOREIGN KEY (`cod_lib_B_D_Biblioteca_CLA_Prestamos` )
  REFERENCES `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_CLA_Libros` (`cod_lib_B_D_Biblioteca_CLA_Libros` )
  ON DELETE NO ACTION
  ON UPDATE NO ACTION
, ADD INDEX `ced_alum_B_D_Biblioteca_CLA_Prestamos_FK_idx` (`ced_alum_B_D_Biblioteca_CLA_Prestamos` ASC) 
, ADD INDEX `cod_lib_B_D_Biblioteca_CLA_Prestamos_FK_idx` (`cod_lib_B_D_Biblioteca_CLA_Prestamos` ASC) ;

ALTER TABLE `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_CLA_Devolucion` 
  ADD CONSTRAINT `cod_lib_B_D_Biblioteca_CLA_Devolucion_FK`
  FOREIGN KEY (`cod_lib_B_D_Biblioteca_CLA_Devolucion` )
  REFERENCES `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_CLA_Libros` (`cod_lib_B_D_Biblioteca_CLA_Libros` )
  ON DELETE NO ACTION
  ON UPDATE NO ACTION, 
  ADD CONSTRAINT `ced_alum_B_D_Biblioteca_CLA_Devolucion`
  FOREIGN KEY (`ced_alum_B_D_Biblioteca_CLA_Devolucion` )
  REFERENCES `B_D_Belinda_Bibliioteca_CLA`.`B_D_Biblioteca_Alumnos` (`ced_alum_B_D_Biblioteca_Alumnos` )
  ON DELETE NO ACTION
  ON UPDATE NO ACTION
, ADD INDEX `cod_lib_B_D_Biblioteca_CLA_Devolucion_FK_idx` (`cod_lib_B_D_Biblioteca_CLA_Devolucion` ASC) 
, ADD INDEX `ced_alum_B_D_Biblioteca_CLA_Devolucion_idx` (`ced_alum_B_D_Biblioteca_CLA_Devolucion` ASC) ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
