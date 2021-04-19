--Create Database
ALTER DATABASE WatchBands SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
ALTER DATABASE WatchbANDS SET MULTI_USER;

USE master;

DROP DATABASE IF EXISTS WatchBands;

CREATE DATABASE WatchBands;

USE WatchBands;



--Create Vehicle Table
DROP TABLE IF EXISTS WatchBands
CREATE TABLE WatchBands
(
	watchbandid		INT				NOT NULL,
	color			NVARCHAR(30)	NULL,
	type			NVARCHAR(20)	NOT NULL,
	watchFitment	NVARCHAR(5)		NULL,
		CHECK (watchFitment = '44MM'),
	year			INT				NOT NULL,
		CHECK (year >= 2015 AND year <= 2021),
		CHECK (year IN (2015, 2016, 2017, 2018, 2019, 2020, 2021)),
);



--Add Primary Key
ALTER TABLE WatchbaNDS
	ADD CONSTRAINT PK_WatchBands
	PRIMARY KEY(watchbandid);



--Add data into table
INSERT
	INTO WatchBands
	(watchbandid, color, type, watchFitment, year)
	VALUES
		(01425, 'Black/Hyper Grape', 'Nike Sport', '44MM', 2019),
		(98967, 'Blue Black/Bright Mango', 'Nike Sport', '44MM', 2020),
		(98954, 'Black Unity', 'Sport', '44MM', 2021),
		(18464, 'Blue Stripe', 'Woven Nylon', '44MM', 2018),
		(99691, 'Deep Navy', 'Solo Loop', '44MM', 2020),
		(80368, 'Black', 'Leather Loop', '44MM', 2015),
		(18555, 'California Poppy', 'Leather Link', '44MM', 2020);

SELECT watchbandid, color, type, watchFitment, year FROM WatchBands
