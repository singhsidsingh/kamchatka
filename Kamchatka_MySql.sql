CREATE database kamchatka_db;

use kamchatka_db;

CREATE TABLE IF NOT EXISTS `kamchatka_db`.`tbl_kamchatka_admin` (
  `empid_admin` VARCHAR(7) NOT NULL,
  `email_admin` VARCHAR(60) NOT NULL,
  `password_admin` VARCHAR(60) NOT NULL,
  `firstname_admin` VARCHAR(50) NOT NULL,
  `lastname_admin` VARCHAR(50) NOT NULL,
  `account_admin` VARCHAR(70) NOT NULL,
  `datecreated_admin` DATETIME NOT NULL,
  `role_admin` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`empid_admin`))
ENGINE = InnoDB


select * from tbl_kamchatka_admin;

CREATE PROCEDURE `pr_add_admin` (IN p_in_empid_admin varchar(7), in p_in_email_admin varchar(60), in p_in_password_admin varchar(60), in p_in_firstname_admin varchar(50), in p_in_lastname_admin varchar(50), in p_in_account_admin varchar(70), in p_in_datecreated_admin datetime, in p_in_role_admin varchar(30), in p_in_project_admin varchar(100))
BEGIN

INSERT INTO tbl_kamchatka_admin VALUES(p_in_empid_admin, p_in_email_admin, p_in_password_admin, p_in_firstname_admin, p_in_lastname_admin, p_in_account_admin, p_in_datecreated_admin, p_in_role_admin, p_in_project_admin);

END

tbl_kamchatka_admin