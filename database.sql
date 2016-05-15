-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 08, 2014 at 10:56 AM
-- Server version: 5.6.14
-- PHP Version: 5.5.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `database`
--
CREATE DATABASE IF NOT EXISTS `database` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `database`;

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `getRooms`$$
CREATE DEFINER=`user`@`localhost` PROCEDURE `getRooms`(IN `hotelId` INT(20), IN `from_d` DATE, IN `to_d` DATE, IN `people_no` INT(20) UNSIGNED)
SELECT count(rooms.type) AS AvailableNo, 
	rooms.type AS Type, 
	rooms.number As RoomNo,
	rooms.price AS Price,
	CONCAT(rooms.type,' ', rooms.price) AS RoomTypePrice
FROM rooms, hotels
WHERE hotels.id=hotelId AND hotels.id=rooms.hotel_id AND
		rooms.people_number = people_no AND rooms.number NOT IN (
            SELECT rooms.number
            FROM rooms, hotels, bookings
            WHERE hotels.id = hotelID AND rooms.hotel_id=hotelId AND bookings.hotel_id = hotels.id AND 
            					bookings.room_number = rooms.number AND rooms.people_number = people_no AND
            		((DATE(bookings.first_date) >= from_d AND DATE(bookings.first_date) <= to_d) OR
				(DATE(bookings.first_date) <= from_d AND DATE(bookings.last_date) >= from_d)) 
            )
GROUP BY RoomTypePrice
HAVING DATE(from_d) <= DATE(to_d) 
ORDER BY count(rooms.type) desc$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `addresses`
--

DROP TABLE IF EXISTS `addresses`;
CREATE TABLE IF NOT EXISTS `addresses` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `phone` varchar(14) NOT NULL,
  `country` varchar(20) NOT NULL,
  `city` varchar(20) NOT NULL,
  `street` varchar(20) NOT NULL,
  `zipcode` char(5) NOT NULL,
  `streetNo` int(5) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `phone` (`phone`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=37 ;

--
-- Dumping data for table `addresses`
--

INSERT INTO `addresses` (`id`, `phone`, `country`, `city`, `street`, `zipcode`, `streetNo`) VALUES
(30, '(698) 377-2903', 'Greece', 'Athens', 'Ilidos', '11526', 5),
(31, '(210) 123-4567', 'Greece', 'Athens', 'Vouliagmenis', '12345', 125),
(32, '(210) 765-4321', 'Greece', 'Athens', 'Voulis', '12345', 15),
(33, '(281) 333-1234', 'Greece', 'Heraklion', 'Foyrtoynaki', '15678', 23),
(34, '(697) 875-4310', 'Greece', 'Athens', 'Denksero', '11526', 7),
(35, '(012) 345-6785', 'Zimpambue', 'Makelele', 'Zidane', '12345', 4),
(36, '(123) 412-3412', 'asdasd', 'asdasd', 'adasd', '12311', 12312);

-- --------------------------------------------------------

--
-- Table structure for table `billing`
--

DROP TABLE IF EXISTS `billing`;
CREATE TABLE IF NOT EXISTS `billing` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `book_id` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `way_pay` varchar(20) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `book_id` (`book_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=17 ;

--
-- Dumping data for table `billing`
--

INSERT INTO `billing` (`id`, `book_id`, `amount`, `way_pay`) VALUES
(2, 3, 480, 'Credit Card'),
(3, 4, 360, 'Credit Card'),
(4, 5, 360, 'Credit Card'),
(8, 9, 480, 'Credit Card'),
(15, 16, 180, 'Credit Card'),
(16, 17, 180, 'Credit Card');

--
-- Triggers `billing`
--
DROP TRIGGER IF EXISTS `addReservationDate`;
DELIMITER //
CREATE TRIGGER `addReservationDate` AFTER INSERT ON `billing`
 FOR EACH ROW UPDATE bookings 
SET bookings.book_date=DATE(NOW()) 
WHERE bookings.id = NEW.book_id
//
DELIMITER ;
DROP TRIGGER IF EXISTS `updateReservationDate`;
DELIMITER //
CREATE TRIGGER `updateReservationDate` AFTER UPDATE ON `billing`
 FOR EACH ROW UPDATE bookings 
SET book_date=DATE(NOW()) 
WHERE bookings.id = NEW.book_id
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `bookings`
--

DROP TABLE IF EXISTS `bookings`;
CREATE TABLE IF NOT EXISTS `bookings` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cust_id` int(11) NOT NULL,
  `hotel_id` int(11) NOT NULL,
  `room_number` int(11) NOT NULL,
  `book_date` date NOT NULL,
  `first_date` date NOT NULL,
  `last_date` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `cust_id` (`cust_id`),
  KEY `hotel_id` (`hotel_id`),
  KEY `room_number` (`room_number`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=18 ;

--
-- Dumping data for table `bookings`
--

INSERT INTO `bookings` (`id`, `cust_id`, `hotel_id`, `room_number`, `book_date`, `first_date`, `last_date`) VALUES
(3, 6, 5, 1, '2014-04-29', '2014-08-12', '2014-08-15'),
(4, 6, 5, 5, '2014-04-30', '2014-08-12', '2014-08-15'),
(5, 6, 5, 7, '2014-05-07', '2014-08-12', '2014-08-15'),
(9, 6, 1, 12, '2014-05-08', '2014-08-12', '2014-08-15'),
(16, 6, 1, 7, '2014-05-08', '2014-08-12', '2014-08-15'),
(17, 6, 1, 5, '2014-05-08', '2014-08-12', '2014-08-15');

--
-- Triggers `bookings`
--
DROP TRIGGER IF EXISTS `cancelReservation`;
DELIMITER //
CREATE TRIGGER `cancelReservation` BEFORE DELETE ON `bookings`
 FOR EACH ROW DELETE FROM  billing WHERE billing.book_id = OLD.id
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
CREATE TABLE IF NOT EXISTS `customers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `addr_id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `lastname` varchar(20) NOT NULL,
  `birthdate` date NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `addr_id` (`addr_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`id`, `addr_id`, `name`, `lastname`, `birthdate`) VALUES
(6, 30, 'Tilemachos', 'Charalampous', '1990-08-12'),
(7, 34, 'Flaflakis', 'Floflakis', '1988-01-01');

-- --------------------------------------------------------

--
-- Stand-in structure for view `customersview`
--
DROP VIEW IF EXISTS `customersview`;
CREATE TABLE IF NOT EXISTS `customersview` (
`ID` int(11)
,`Name` varchar(41)
,`Email` text
,`Phone` varchar(14)
,`Address` varchar(84)
);
-- --------------------------------------------------------

--
-- Table structure for table `emails`
--

DROP TABLE IF EXISTS `emails`;
CREATE TABLE IF NOT EXISTS `emails` (
  `email` varchar(40) NOT NULL DEFAULT '',
  `cust_id` int(11) NOT NULL,
  PRIMARY KEY (`email`),
  KEY `cust_id` (`cust_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `emails`
--

INSERT INTO `emails` (`email`, `cust_id`) VALUES
(' tilemachos.charalampous@gmail.com', 6),
('tilemachos.sheva@gmail.com', 6),
('dunno@hotmail.com', 7);

-- --------------------------------------------------------

--
-- Table structure for table `hotels`
--

DROP TABLE IF EXISTS `hotels`;
CREATE TABLE IF NOT EXISTS `hotels` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `addr_id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `type` varchar(20) NOT NULL,
  `stars` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `addr_id` (`addr_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `hotels`
--

INSERT INTO `hotels` (`id`, `addr_id`, `name`, `type`, `stars`) VALUES
(1, 31, 'Vouliagmenis Resort', 'Seaside', 5),
(2, 32, 'Syntagma Hotel', 'Motel', 2),
(5, 33, 'Heraklion Paradise', 'Seaside', 4);

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
CREATE TABLE IF NOT EXISTS `payments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `billing_id` int(11) NOT NULL,
  `date_payed` date NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `billing_id` (`billing_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`id`, `billing_id`, `date_payed`) VALUES
(1, 3, '2014-05-01'),
(2, 2, '2014-05-01'),
(3, 4, '2014-05-07'),
(4, 8, '2014-05-08');

-- --------------------------------------------------------

--
-- Stand-in structure for view `paymentsinfo`
--
DROP VIEW IF EXISTS `paymentsinfo`;
CREATE TABLE IF NOT EXISTS `paymentsinfo` (
`bill_id` int(11)
,`book_id` int(11)
,`cust_id` int(11)
,`phone` varchar(14)
,`Info` varchar(87)
,`Amount` int(11)
,`from_date` date
,`to_date` date
,`hotel_id` int(11)
,`people_number` int(11)
);
-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

DROP TABLE IF EXISTS `rooms`;
CREATE TABLE IF NOT EXISTS `rooms` (
  `number` int(11) NOT NULL AUTO_INCREMENT,
  `hotel_id` int(11) NOT NULL DEFAULT '0',
  `people_number` int(11) NOT NULL,
  `type` varchar(20) NOT NULL,
  `price` int(11) NOT NULL,
  PRIMARY KEY (`number`,`hotel_id`),
  KEY `hotel_id` (`hotel_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=17 ;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`number`, `hotel_id`, `people_number`, `type`, `price`) VALUES
(1, 1, 1, 'Simple', 40),
(1, 2, 3, 'Simple', 20),
(1, 5, 3, 'Simple', 50),
(2, 1, 3, 'Simple', 40),
(2, 2, 3, 'Simple', 20),
(2, 5, 4, 'Simple', 50),
(3, 1, 3, 'Simple', 40),
(3, 2, 5, 'Simple', 20),
(3, 5, 4, 'Simple', 50),
(4, 1, 2, 'Simple', 40),
(4, 2, 2, 'Simple', 20),
(4, 5, 4, 'Simple', 50),
(5, 1, 2, 'Simple', 40),
(5, 5, 2, 'Sea View', 70),
(6, 1, 2, 'Sea View', 60),
(6, 5, 2, 'Sea View', 70),
(7, 1, 2, 'Sea View', 60),
(7, 5, 3, 'Sea View', 70),
(9, 5, 3, 'Suite', 120),
(10, 5, 2, 'Suite', 120),
(11, 1, 3, 'Cool', 150),
(12, 1, 3, 'Cool', 150),
(13, 1, 3, 'Cool', 150),
(14, 1, 3, 'Cool', 150),
(16, 1, 3, 'Cool', 160);

-- --------------------------------------------------------

--
-- Stand-in structure for view `updateablehotelsview`
--
DROP VIEW IF EXISTS `updateablehotelsview`;
CREATE TABLE IF NOT EXISTS `updateablehotelsview` (
`addr_id` int(11)
,`name` varchar(20)
,`type` varchar(20)
,`stars` int(11)
);
-- --------------------------------------------------------

--
-- Structure for view `customersview`
--
DROP TABLE IF EXISTS `customersview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`user`@`localhost` SQL SECURITY DEFINER VIEW `customersview` AS select `customers`.`id` AS `ID`,concat(`customers`.`name`,' ',`customers`.`lastname`) AS `Name`,group_concat(`emails`.`email` separator ', ') AS `Email`,`addresses`.`phone` AS `Phone`,concat(`addresses`.`street`,', ',`addresses`.`streetNo`,', ',`addresses`.`zipcode`,', ',`addresses`.`city`,', ',`addresses`.`country`) AS `Address` from ((`customers` join `addresses`) join `emails`) where ((`customers`.`addr_id` = `addresses`.`id`) and (`emails`.`cust_id` = `customers`.`id`)) group by `customers`.`id`;

-- --------------------------------------------------------

--
-- Structure for view `paymentsinfo`
--
DROP TABLE IF EXISTS `paymentsinfo`;

CREATE ALGORITHM=UNDEFINED DEFINER=`user`@`localhost` SQL SECURITY DEFINER VIEW `paymentsinfo` AS select `billing`.`id` AS `bill_id`,`bookings`.`id` AS `book_id`,`customers`.`id` AS `cust_id`,`addresses`.`phone` AS `phone`,concat(`hotels`.`name`,', room type: ',`rooms`.`type`,' from ',dayofmonth(`bookings`.`first_date`),'-',monthname(`bookings`.`first_date`),' to ',dayofmonth(`bookings`.`last_date`),'-',monthname(`bookings`.`last_date`)) AS `Info`,`billing`.`amount` AS `Amount`,`bookings`.`first_date` AS `from_date`,`bookings`.`last_date` AS `to_date`,`hotels`.`id` AS `hotel_id`,`rooms`.`people_number` AS `people_number` from (((((`customers` join `addresses`) join `hotels`) join `bookings`) join `billing`) join `rooms`) where ((`bookings`.`cust_id` = `customers`.`id`) and (`bookings`.`hotel_id` = `hotels`.`id`) and (`customers`.`addr_id` = `addresses`.`id`) and (`billing`.`book_id` = `bookings`.`id`) and (`bookings`.`room_number` = `rooms`.`number`) and (`rooms`.`hotel_id` = `hotels`.`id`) and (not(`billing`.`id` in (select `billing`.`id` from (`billing` join `payments`) where (`billing`.`id` = `payments`.`billing_id`)))));

-- --------------------------------------------------------

--
-- Structure for view `updateablehotelsview`
--
DROP TABLE IF EXISTS `updateablehotelsview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`user`@`localhost` SQL SECURITY DEFINER VIEW `updateablehotelsview` AS select `hotels`.`addr_id` AS `addr_id`,`hotels`.`name` AS `name`,`hotels`.`type` AS `type`,`hotels`.`stars` AS `stars` from `hotels`;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `billing`
--
ALTER TABLE `billing`
  ADD CONSTRAINT `billing_ibfk_1` FOREIGN KEY (`book_id`) REFERENCES `bookings` (`id`);

--
-- Constraints for table `bookings`
--
ALTER TABLE `bookings`
  ADD CONSTRAINT `bookings_ibfk_1` FOREIGN KEY (`cust_id`) REFERENCES `customers` (`id`),
  ADD CONSTRAINT `bookings_ibfk_2` FOREIGN KEY (`hotel_id`) REFERENCES `hotels` (`id`),
  ADD CONSTRAINT `bookings_ibfk_3` FOREIGN KEY (`room_number`) REFERENCES `rooms` (`number`);

--
-- Constraints for table `customers`
--
ALTER TABLE `customers`
  ADD CONSTRAINT `customers_ibfk_1` FOREIGN KEY (`addr_id`) REFERENCES `addresses` (`id`);

--
-- Constraints for table `emails`
--
ALTER TABLE `emails`
  ADD CONSTRAINT `emails_ibfk_1` FOREIGN KEY (`cust_id`) REFERENCES `customers` (`id`);

--
-- Constraints for table `hotels`
--
ALTER TABLE `hotels`
  ADD CONSTRAINT `hotels_ibfk_1` FOREIGN KEY (`addr_id`) REFERENCES `addresses` (`id`);

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `payments_ibfk_2` FOREIGN KEY (`billing_id`) REFERENCES `billing` (`id`);

--
-- Constraints for table `rooms`
--
ALTER TABLE `rooms`
  ADD CONSTRAINT `rooms_ibfk_1` FOREIGN KEY (`hotel_id`) REFERENCES `hotels` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
