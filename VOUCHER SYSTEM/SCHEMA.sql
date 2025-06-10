create database vgs;
use vgs;

create table STD (
ID INT AUTO_INCREMENT PRIMARY KEY,
Name varchar(20) not null,
Class varchar(20) not null,
Age int not null,
Batch varchar(20),
Fee DECIMAL(10, 2) NOT NULL 
);

DELIMITER //
CREATE TRIGGER set_fee_insert
BEFORE INSERT ON STD
FOR EACH ROW
BEGIN
    IF NEW.Class = 'CLASS 6' THEN
        SET NEW.Fee = 1000.00;
    ELSEIF NEW.Class = 'CLASS 7' THEN
        SET NEW.Fee = 1500.00;
    ELSEIF NEW.Class = 'CLASS 8' THEN
        SET NEW.Fee = 2000.00;
    ELSEIF NEW.Class = 'CLASS 9' THEN
        SET NEW.Fee = 2500.00;
	ELSEIF NEW.Class = 'CLASS 10' THEN
        SET NEW.Fee = 3000.00;
    END IF;
END; //
DELIMITER ;

DELIMITER //
CREATE TRIGGER set_fee_update
BEFORE UPDATE ON STD
FOR EACH ROW
BEGIN
    IF NEW.Class = 'CLASS 6' THEN
        SET NEW.Fee = 1000.00;
    ELSEIF NEW.Class = 'CLASS 7' THEN
        SET NEW.Fee = 1500.00;
    ELSEIF NEW.Class = 'CLASS 8' THEN
        SET NEW.Fee = 2000.00;
    ELSEIF NEW.Class = 'CLASS 9' THEN
        SET NEW.Fee = 2500.00;
	ELSEIF NEW.Class = 'CLASS 10' THEN
        SET NEW.Fee = 3000.00;
    END IF;
END; //
DELIMITER ;
