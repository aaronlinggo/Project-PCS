/*
SQLyog Community v13.1.9 (64 bit)
MySQL - 10.4.20-MariaDB : Database - db_hotel_samgun
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_hotel_samgun` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `db_hotel_samgun`;

/*Table structure for table `fasilitas` */

DROP TABLE IF EXISTS `fasilitas`;

CREATE TABLE `fasilitas` (
  `id_fasilitas` int(11) NOT NULL AUTO_INCREMENT,
  `nama_fasilitas` varchar(255) NOT NULL,
  `status_fasilitas` int(1) NOT NULL,
  PRIMARY KEY (`id_fasilitas`)
) ENGINE=InnoDB AUTO_INCREMENT=80 DEFAULT CHARSET=utf8mb4;

/*Data for the table `fasilitas` */

insert  into `fasilitas`(`id_fasilitas`,`nama_fasilitas`,`status_fasilitas`) values 
(1,'King Bed',1),
(2,'Double Bed',1),
(3,'Club lounge access',1),
(4,'Private access floor',1),
(5,'Hot buffet breakfast',1),
(6,'Midday snack',1),
(7,'Afternoon tea',1),
(8,'Dessert',1),
(9,'Late night snack',1),
(10,'Cocktails, for a fee',1),
(11,'Complimentary cocktails',1),
(12,'Complimentary non-alcoholic beverages',1),
(13,'Business services, for a fee',1),
(14,'Complimentary business services',1),
(15,'Complimentary pressing, 2 garments per stay',1),
(16,'Complimentary pressing, 5 garments per stay',1),
(17,'Expanded ala carte menu (for purchase)',1),
(18,'Evening Bar Service',1),
(19,'Featherbed',1),
(20,'Duvet',1),
(21,'Air Conditioner',1),
(22,'Non-smoking room',1),
(23,'Living/sitting area',1),
(24,'Dining room',1),
(25,'Dining room is separated',1),
(26,'Living room is separated from bed by privacy wall',1),
(27,'Study',1),
(28,'Walk-in closet',1),
(29,'Hooks',1),
(30,'Windows, soundproof',1),
(31,'USB Outlets',1),
(32,'Marble Bathroom',1),
(33,'Shower/Tub Combination',1),
(34,'Bidet',1),
(35,'Lighted Makeup Mirror',1),
(36,'Hair Dryer',1),
(37,'Robe',1),
(38,'Slippers',1),
(39,'Sofa',1),
(40,'Chair',1),
(41,'Alarm Clock',1),
(42,'Safe, in room',1),
(43,'Outlet with Dual Voltage Adaptors',1),
(44,'Table with seating for 1',1),
(45,'Table with seating for 2',1),
(46,'Table with seating for 4',1),
(47,'Table with seating for 5',1),
(48,'Desk, writing/work, electrical outlet',1),
(49,'Desk, writing/work, with ergonomic chair, and electrical outlet',1),
(50,'Electrical Outlet',1),
(51,'Iron and Ironing Board',1),
(52,'Room Service, 24-Hour',1),
(53,'Bottled Water',1),
(54,'Coffee/tea maker',1),
(55,'Instant Hot Water',1),
(56,'Mini-bar, for a fee',1),
(57,'Appetizer',1),
(58,'Refrigerator',1),
(59,'Mini-refrigerator',1),
(60,'Phones: 1',1),
(61,'Phones: 3',1),
(62,'Phones: 4',1),
(63,'Speaker phone',1),
(64,'High-Speed Internet',1),
(65,'Complimentary High-Speed Internet',1),
(66,'Wireless Internet',1),
(67,'Complimentary Wireless Internet',1),
(68,'Evening Turndown Service',1),
(69,'Butler Service',1),
(70,'Newspaper delivered to room on request',1),
(71,'TV with Remote Control, 32in/81cm',1),
(72,'TV with Remote Control, 32in/81cm, and Flat screen',1),
(73,'TV with Remote Control, 32in/81cm, and LED screen',1),
(74,'TV with Remote Control, largest 55in/140cm, and LED screen',1),
(75,'Plug-in High Tech Room',1),
(76,'Premium Movie Channels',1),
(77,'International Cable/Satellite TV',1),
(78,'Radio',1),
(79,'iPod Dock',1);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
