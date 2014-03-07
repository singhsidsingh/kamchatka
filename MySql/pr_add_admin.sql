-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$

CREATE PROCEDURE `pr_add_admin` (IN p_in_empid_admin varchar(7), in p_in_email_admin varchar(60), in p_in_password_admin varchar(60), in p_in_firstname_admin varchar(50), in p_in_lastname_admin varchar(50), in p_in_account_admin varchar(70), in p_in_datecreated_admin datetime, in p_in_role_admin varchar(30), in p_in_project_admin varchar(100))
BEGIN

INSERT INTO tbl_kamchatka_admin VALUES(p_in_empid_admin, p_in_email_admin, p_in_password_admin, p_in_firstname_admin, p_in_lastname_admin, p_in_account_admin, p_in_datecreated_admin, p_in_role_admin, p_in_project_admin);

END