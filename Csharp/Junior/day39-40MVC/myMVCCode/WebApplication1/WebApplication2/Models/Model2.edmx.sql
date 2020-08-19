
-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 08/18/2020 12:14:52

-- Generated from EDMX file: D:\SoftWare\VS2017Pro\vs2019Workspace\repos\WebApplication1\WebApplication2\Models\Model2.edmx
-- Target version: 3.0.0.0

-- --------------------------------------------------


DROP DATABASE IF EXISTS `myTestDatabase`;
CREATE DATABASE `myTestDatabase`;
USE `myTestDatabase`;


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------



-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;

SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------


CREATE TABLE `uuPussySet`(
	`uid` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`uprice` double NOT NULL, 
	`uage` int NOT NULL, 
	`uisfirst` bool NOT NULL);

ALTER TABLE `uuPussySet` ADD PRIMARY KEY (`uid`);







-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
