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

/*Table structure for table `detail_fasilitas` */

DROP TABLE IF EXISTS `detail_fasilitas`;

CREATE TABLE `detail_fasilitas` (
  `id_detail_fasilitas` int(11) NOT NULL AUTO_INCREMENT,
  `id_jenis_kamar` int(11) NOT NULL,
  `kode_fasilitas` varchar(7) NOT NULL,
  PRIMARY KEY (`id_detail_fasilitas`),
  KEY `id_jenis_kamar` (`id_jenis_kamar`),
  KEY `kode_fasilitas` (`kode_fasilitas`),
  CONSTRAINT `detail_fasilitas_ibfk_1` FOREIGN KEY (`id_jenis_kamar`) REFERENCES `jenis_kamar` (`id_jenis_kamar`),
  CONSTRAINT `detail_fasilitas_ibfk_2` FOREIGN KEY (`kode_fasilitas`) REFERENCES `fasilitas` (`kode_fasilitas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `detail_fasilitas` */

/*Table structure for table `detail_pemesanan_makanan` */

DROP TABLE IF EXISTS `detail_pemesanan_makanan`;

CREATE TABLE `detail_pemesanan_makanan` (
  `id_detail_pemesanan` int(11) NOT NULL AUTO_INCREMENT,
  `kode_pemesanan` varchar(15) NOT NULL,
  `id_makanan` int(11) NOT NULL,
  `jumlah_pemesanan` int(5) NOT NULL,
  `subtotal_biaya_pemesanan` int(16) NOT NULL,
  PRIMARY KEY (`id_detail_pemesanan`),
  KEY `kode_pemesanan` (`kode_pemesanan`),
  KEY `id_makanan` (`id_makanan`),
  CONSTRAINT `detail_pemesanan_makanan_ibfk_1` FOREIGN KEY (`kode_pemesanan`) REFERENCES `pemesanan_makanan` (`kode_pemesanan`),
  CONSTRAINT `detail_pemesanan_makanan_ibfk_2` FOREIGN KEY (`id_makanan`) REFERENCES `makanan` (`id_makanan`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4;

/*Data for the table `detail_pemesanan_makanan` */

insert  into `detail_pemesanan_makanan`(`id_detail_pemesanan`,`kode_pemesanan`,`id_makanan`,`jumlah_pemesanan`,`subtotal_biaya_pemesanan`) values 
(1,'NOTA26042200001',36,2,276000),
(2,'NOTA26042200001',48,1,148000),
(3,'NOTA26042200001',170,1,55000),
(4,'NOTA26042200002',124,2,376000),
(5,'NOTA26042200002',74,1,478000),
(6,'NOTA26042200002',56,2,136000),
(7,'NOTA26042200002',2,1,158000),
(8,'NOTA01052200001',14,3,534000),
(9,'NOTA01052200001',15,3,414000),
(10,'NOTA04052200001',180,1,70000),
(11,'NOTA16052200001',53,2,270000),
(12,'NOTA16052200001',58,2,136000);

/*Table structure for table `extra_fasilitas` */

DROP TABLE IF EXISTS `extra_fasilitas`;

CREATE TABLE `extra_fasilitas` (
  `id_extra_fasilitas` int(11) NOT NULL AUTO_INCREMENT,
  `kode_extra_fasilitas` varchar(7) NOT NULL,
  `nama_extra_fasilitas` varchar(255) NOT NULL,
  `stok_extra_fasilitas` int(5) NOT NULL,
  `harga_extra_fasilitas` int(16) NOT NULL,
  PRIMARY KEY (`id_extra_fasilitas`),
  UNIQUE KEY `kode_extra_fasilitas` (`kode_extra_fasilitas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `extra_fasilitas` */

/*Table structure for table `fasilitas` */

DROP TABLE IF EXISTS `fasilitas`;

CREATE TABLE `fasilitas` (
  `id_fasilitas` int(11) NOT NULL AUTO_INCREMENT,
  `kode_fasilitas` varchar(7) NOT NULL,
  `nama_fasilitas` varchar(255) NOT NULL,
  PRIMARY KEY (`id_fasilitas`),
  UNIQUE KEY `kode_fasilitas` (`kode_fasilitas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `fasilitas` */

/*Table structure for table `jenis_kamar` */

DROP TABLE IF EXISTS `jenis_kamar`;

CREATE TABLE `jenis_kamar` (
  `id_jenis_kamar` int(11) NOT NULL AUTO_INCREMENT,
  `nama_jenis_kamar` varchar(255) NOT NULL,
  `harga_jenis_kamar` int(16) NOT NULL,
  PRIMARY KEY (`id_jenis_kamar`),
  UNIQUE KEY `nama_jenis_kamar` (`nama_jenis_kamar`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;

/*Data for the table `jenis_kamar` */

insert  into `jenis_kamar`(`id_jenis_kamar`,`nama_jenis_kamar`,`harga_jenis_kamar`) values 
(1,'Superior King',890000),
(2,'Superior Twin',930000),
(3,'Deluxe King',1060000),
(4,'Deluxe Twin',1100000),
(5,'Premium King',1260000),
(6,'Premium Twin',1300000),
(7,'Club King',1610000),
(8,'Club Twin',1650000),
(9,'Junior Suite',1900000),
(10,'Deluxe Suite',2600000),
(11,'Executive Suite',2900000),
(12,'Royal Suite',3600000),
(13,'Presidential Suite',9100000);

/*Table structure for table `jenis_makanan` */

DROP TABLE IF EXISTS `jenis_makanan`;

CREATE TABLE `jenis_makanan` (
  `id_jenis_makanan` int(11) NOT NULL AUTO_INCREMENT,
  `nama_jenis_makanan` varchar(255) NOT NULL,
  PRIMARY KEY (`id_jenis_makanan`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4;

/*Data for the table `jenis_makanan` */

insert  into `jenis_makanan`(`id_jenis_makanan`,`nama_jenis_makanan`) values 
(1,'Starters & Salad'),
(2,'Soups'),
(3,'Pasta & Risotto'),
(4,'Pizza'),
(5,'Sandwich & Burgers'),
(6,'Meat'),
(7,'Grilled'),
(8,'Barbecues & Marinations'),
(9,'Seafood'),
(10,'Rice'),
(11,'Noodles'),
(12,'Seasonal Vegetables'),
(13,'Dim Sum & Bento'),
(14,'Sushi & Sashimi'),
(15,'Hot Pot'),
(16,'Vegetarian'),
(17,'Dessert'),
(18,'Coffee'),
(19,'Mineral Water'),
(20,'Tea'),
(21,'Fresh Juices'),
(22,'Soft Drinks'),
(23,'Beer');

/*Table structure for table `kamar` */

DROP TABLE IF EXISTS `kamar`;

CREATE TABLE `kamar` (
  `id_kamar` int(11) NOT NULL AUTO_INCREMENT,
  `kode_kamar` varchar(7) NOT NULL,
  `nomor_kamar` int(4) NOT NULL,
  `nomor_lantai` int(2) NOT NULL,
  `status_kamar` int(1) NOT NULL,
  `id_jenis_kamar` int(11) NOT NULL,
  PRIMARY KEY (`id_kamar`),
  UNIQUE KEY `kode_kamar` (`kode_kamar`),
  UNIQUE KEY `nomor_kamar` (`nomor_kamar`),
  KEY `id_jenis_kamar` (`id_jenis_kamar`),
  CONSTRAINT `kamar_ibfk_1` FOREIGN KEY (`id_jenis_kamar`) REFERENCES `jenis_kamar` (`id_jenis_kamar`)
) ENGINE=InnoDB AUTO_INCREMENT=213 DEFAULT CHARSET=utf8mb4;

/*Data for the table `kamar` */

insert  into `kamar`(`id_kamar`,`kode_kamar`,`nomor_kamar`,`nomor_lantai`,`status_kamar`,`id_jenis_kamar`) values 
(1,'SUK101',101,1,1,1),
(2,'SUK102',102,1,1,1),
(3,'SUK103',103,1,1,1),
(4,'SUK104',104,1,1,1),
(5,'SUK105',105,1,1,1),
(6,'SUK106',106,1,1,1),
(7,'SUK107',107,1,1,1),
(8,'SUK108',108,1,1,1),
(9,'SUT109',109,1,1,2),
(10,'SUT110',110,1,1,2),
(11,'SUT111',111,1,1,2),
(12,'SUT112',112,1,1,2),
(13,'SUT113',113,1,1,2),
(14,'SUT114',114,1,1,2),
(15,'SUK115',115,1,1,1),
(16,'SUK116',116,1,1,1),
(17,'SUK117',117,1,1,1),
(18,'SUK118',118,1,1,1),
(19,'SUK119',119,1,1,1),
(20,'SUK120',120,1,1,1),
(21,'SUT121',121,1,1,2),
(22,'SUT122',122,1,1,2),
(23,'SUT123',123,1,1,2),
(24,'SUT124',124,1,1,2),
(25,'SUK201',201,2,1,1),
(26,'SUK202',202,2,1,1),
(27,'SUK203',203,2,1,1),
(28,'SUK204',204,2,1,1),
(29,'SUK205',205,2,1,1),
(30,'SUK206',206,2,1,1),
(31,'SUK207',207,2,1,1),
(32,'SUK208',208,2,1,1),
(33,'SUT209',209,2,1,2),
(34,'SUT210',210,2,1,2),
(35,'SUT211',211,2,1,2),
(36,'SUT212',212,2,1,2),
(37,'SUT213',213,2,1,2),
(38,'SUT214',214,2,1,2),
(39,'SUK215',215,2,1,1),
(40,'SUK216',216,2,1,1),
(41,'SUK217',217,2,1,1),
(42,'SUK218',218,2,1,1),
(43,'SUK219',219,2,1,1),
(44,'SUK220',220,2,1,1),
(45,'SUT221',221,2,1,2),
(46,'SUT222',222,2,1,2),
(47,'SUT223',223,2,1,2),
(48,'SUT224',224,2,1,2),
(49,'DEK301',301,3,1,3),
(50,'DEK302',302,3,1,3),
(51,'DEK303',303,3,1,3),
(52,'DEK304',304,3,1,3),
(53,'DEK305',305,3,1,3),
(54,'DEK306',306,3,1,3),
(55,'DEK307',307,3,1,3),
(56,'DEK308',308,3,1,3),
(57,'DET309',309,3,1,4),
(58,'DET310',310,3,1,4),
(59,'DET311',311,3,1,4),
(60,'DET312',312,3,1,4),
(61,'DET313',313,3,1,4),
(62,'DET314',314,3,1,4),
(63,'DET315',315,3,1,4),
(64,'DET316',316,3,1,4),
(65,'DET317',317,3,1,4),
(66,'DET318',318,3,1,4),
(67,'DEK319',319,3,1,3),
(68,'DEK320',320,3,1,3),
(69,'DEK401',401,4,1,3),
(70,'DEK402',402,4,1,3),
(71,'DEK403',403,4,1,3),
(72,'DEK404',404,4,1,3),
(73,'DEK405',405,4,1,3),
(74,'DEK406',406,4,1,3),
(75,'DEK407',407,4,1,3),
(76,'DEK408',408,4,1,3),
(77,'DET409',409,4,1,4),
(78,'DET410',410,4,1,4),
(79,'DET411',411,4,1,4),
(80,'DET412',412,4,1,4),
(81,'DET413',413,4,1,4),
(82,'DET414',414,4,1,4),
(83,'DET415',415,4,1,4),
(84,'DET416',416,4,1,4),
(85,'DET417',417,4,1,4),
(86,'DET418',418,4,1,4),
(87,'DEK419',419,4,1,3),
(88,'DEK420',420,4,1,3),
(89,'PRK501',501,5,1,5),
(90,'PRK502',502,5,1,5),
(91,'PRK503',503,5,1,5),
(92,'PRK504',504,5,1,5),
(93,'PRT505',505,5,1,6),
(94,'PRT506',506,5,1,6),
(95,'PRT507',507,5,1,6),
(96,'PRT508',508,5,1,6),
(97,'PRT509',509,5,1,6),
(98,'PRT510',510,5,1,6),
(99,'PRK511',511,5,1,5),
(100,'PRK512',512,5,1,5),
(101,'PRK513',513,5,1,5),
(102,'PRK514',514,5,1,5),
(103,'PRT515',515,5,1,6),
(104,'PRT516',516,5,1,6),
(105,'PRT517',517,5,1,6),
(106,'PRT518',518,5,1,6),
(107,'PRK601',601,6,1,5),
(108,'PRK602',602,6,1,5),
(109,'PRK603',603,6,1,5),
(110,'PRK604',604,6,1,5),
(111,'PRT605',605,6,1,6),
(112,'PRT606',606,6,1,6),
(113,'PRT607',607,6,1,6),
(114,'PRT608',608,6,1,6),
(115,'PRT609',609,6,1,6),
(116,'PRT610',610,6,1,6),
(117,'PRK611',611,6,1,5),
(118,'PRK612',612,6,1,5),
(119,'PRK613',613,6,1,5),
(120,'PRK614',614,6,1,5),
(121,'PRT615',615,6,1,6),
(122,'PRT616',616,6,1,6),
(123,'PRT617',617,6,1,6),
(124,'PRT618',618,6,1,6),
(125,'CLK701',701,7,1,7),
(126,'CLK702',702,7,1,7),
(127,'CLK703',703,7,1,7),
(128,'CLK704',704,7,1,7),
(129,'CLK705',705,7,1,7),
(130,'CLK706',706,7,1,7),
(131,'CLK707',707,7,1,7),
(132,'CLK708',708,7,1,7),
(133,'CLT709',709,7,1,8),
(134,'CLT710',710,7,1,8),
(135,'CLT711',711,7,1,8),
(136,'CLT712',712,7,1,8),
(137,'CLT713',713,7,1,8),
(138,'CLT714',714,7,1,8),
(139,'CLK715',715,7,1,7),
(140,'CLK716',716,7,1,7),
(141,'CLT717',717,7,1,8),
(142,'CLT718',718,7,1,8),
(143,'JUS801',801,8,1,9),
(144,'JUS802',802,8,1,9),
(145,'JUS803',803,8,1,9),
(146,'JUS804',804,8,1,9),
(147,'JUS805',805,8,1,9),
(148,'JUS806',806,8,1,9),
(149,'JUS807',807,8,1,9),
(150,'JUS808',808,8,1,9),
(151,'JUS809',809,8,1,9),
(152,'JUS810',810,8,1,9),
(153,'JUS811',811,8,1,9),
(154,'JUS812',812,8,1,9),
(155,'JUS813',813,8,1,9),
(156,'JUS814',814,8,1,9),
(157,'DES901',901,9,1,10),
(158,'DES902',902,9,1,10),
(159,'DES903',903,9,1,10),
(160,'DES904',904,9,1,10),
(161,'DES905',905,9,1,10),
(162,'DES906',906,9,1,10),
(163,'DES907',907,9,1,10),
(164,'DES908',908,9,1,10),
(165,'DES909',909,9,1,10),
(166,'DES910',910,9,1,10),
(167,'DES911',911,9,1,10),
(168,'DES912',912,9,1,10),
(169,'DES913',913,9,1,10),
(170,'DES914',914,9,1,10),
(171,'EXS1001',1001,10,1,11),
(172,'EXS1002',1002,10,1,11),
(173,'EXS1003',1003,10,1,11),
(174,'EXS1004',1004,10,1,11),
(175,'EXS1005',1005,10,1,11),
(176,'EXS1006',1006,10,1,11),
(177,'EXS1007',1007,10,1,11),
(178,'EXS1008',1008,10,1,11),
(179,'EXS1009',1009,10,1,11),
(180,'EXS1010',1010,10,1,11),
(181,'EXS1011',1011,10,1,11),
(182,'EXS1012',1012,10,1,11),
(183,'EXS1013',1013,10,1,11),
(184,'EXS1014',1014,10,1,11),
(185,'ROS1101',1101,11,1,12),
(186,'ROS1102',1102,11,1,12),
(187,'ROS1103',1103,11,1,12),
(188,'ROS1104',1104,11,1,12),
(189,'ROS1105',1105,11,1,12),
(190,'ROS1106',1106,11,1,12),
(191,'ROS1107',1107,11,1,12),
(192,'ROS1108',1108,11,1,12),
(193,'ROS1109',1109,11,1,12),
(194,'ROS1110',1110,11,1,12),
(195,'ROS1111',1111,11,1,12),
(196,'ROS1112',1112,11,1,12),
(197,'ROS1113',1113,11,1,12),
(198,'ROS1114',1114,11,1,12),
(199,'PRS1201',1201,12,1,13),
(200,'PRS1202',1202,12,1,13),
(201,'PRS1203',1203,12,1,13),
(202,'PRS1204',1204,12,1,13),
(203,'PRS1205',1205,12,1,13),
(204,'PRS1206',1206,12,1,13),
(205,'PRS1207',1207,12,1,13),
(206,'PRS1208',1208,12,1,13),
(207,'PRS1209',1209,12,1,13),
(208,'PRS1210',1210,12,1,13),
(209,'PRS1211',1211,12,1,13),
(210,'PRS1212',1212,12,1,13),
(211,'PRS1213',1213,12,1,13),
(212,'PRS1214',1214,12,1,13);

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

CREATE TABLE `karyawan` (
  `id_karyawan` int(11) NOT NULL AUTO_INCREMENT,
  `kode_karyawan` varchar(5) NOT NULL,
  `username` varchar(255) NOT NULL,
  `nama_karyawan` varchar(255) NOT NULL,
  `jenis_kelamin_karyawan` varchar(1) NOT NULL,
  `tanggal_lahir_karyawan` date NOT NULL,
  `alamat_karyawan` varchar(255) NOT NULL,
  `nomor_telepon_karyawan` varchar(13) NOT NULL,
  `email_karyawan` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `roles` varchar(11) NOT NULL,
  PRIMARY KEY (`id_karyawan`),
  UNIQUE KEY `kode_karyawan` (`kode_karyawan`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

/*Data for the table `karyawan` */

insert  into `karyawan`(`id_karyawan`,`kode_karyawan`,`username`,`nama_karyawan`,`jenis_kelamin_karyawan`,`tanggal_lahir_karyawan`,`alamat_karyawan`,`nomor_telepon_karyawan`,`email_karyawan`,`password`,`roles`) values 
(1,'AD001','ExE','Aaron Linggo Satria','L','2002-01-01','Jl. Isekai 1, Isekai','081234567890','aaron_l20@mhs.istts.ac.id','admin1234','Admin'),
(2,'AD002','acxel','Acxel Derian Afandi','L','2002-03-01','Jl. Isekai 2, Isekai','081245678903','acxel_d20@mhs.istts.ac.id','admin1234','Admin'),
(3,'AD003','MrKarep','Ignatius Odi','L','2002-05-01','Jl. Isekai 3, Isekai','081256789034','ignatius_o20@mhs.istts.ac.id','admin1234','Admin'),
(4,'AD004','SamGun_Official','Samuel Gunawan','L','2002-07-01','Jl. Isekai 4, Isekai','081267890345','samuel_20@mhs.istts.ac.id','admin1234','Admin'),
(5,'RE001','Kosmas','Kenny','P','2002-02-01','Jl. Ngagel Jaya 73, Surabaya','089265430987','kenny_20@mhs.istts.ac.id','12345678','Resepsionis'),
(6,'RE002','KaiserX00','Mikhael Chris','L','2002-04-01','Jl. Ngagel Jaya 74, Surabaya','089254309876','mikhael_c20@mhs.istts.ac.id','12345678','Resepsionis'),
(7,'RE003','CBEngineer','Alexander Kevin','L','2002-06-01','Jl. Ngagel Jaya 75, Surabaya','089243098765','alexander_k20@mhs.istts.ac.id','12345678','Resepsionis');

/*Table structure for table `makanan` */

DROP TABLE IF EXISTS `makanan`;

CREATE TABLE `makanan` (
  `id_makanan` int(11) NOT NULL AUTO_INCREMENT,
  `nama_makanan` varchar(255) NOT NULL,
  `harga_makanan` int(16) NOT NULL,
  `stok_makanan` int(5) NOT NULL,
  `status_makanan` int(1) NOT NULL,
  `id_jenis_makanan` int(11) NOT NULL,
  PRIMARY KEY (`id_makanan`),
  KEY `id_jenis_makanan` (`id_jenis_makanan`),
  CONSTRAINT `makanan_ibfk_1` FOREIGN KEY (`id_jenis_makanan`) REFERENCES `jenis_makanan` (`id_jenis_makanan`)
) ENGINE=InnoDB AUTO_INCREMENT=213 DEFAULT CHARSET=utf8mb4;

/*Data for the table `makanan` */

insert  into `makanan`(`id_makanan`,`nama_makanan`,`harga_makanan`,`stok_makanan`,`status_makanan`,`id_jenis_makanan`) values 
(1,'Caesar Salad with Roasted Chicken Fillets',108000,0,1,1),
(2,'Caesar Salad with Smoked Salmon',158000,0,1,1),
(3,'Chef Salad',68000,0,1,1),
(4,'Mushroom Soup',68000,0,1,2),
(5,'Tomato Soup',68000,0,1,2),
(6,'Tom Yam Goong',128000,0,1,2),
(7,'Rawon Oxtail Soup',138000,0,1,2),
(8,'Bromo Special Oxtail',138000,0,1,2),
(9,'Soto Lamongan',98000,0,1,2),
(10,'Indonesian Fried Rice with Seafood',120000,0,1,10),
(11,'Nasi Bakar Tuna',128000,0,1,10),
(12,'Rujak Cingur',88000,0,1,1),
(13,'Gado Gado',78000,0,1,1),
(14,'Iga Bakar Sapi',178000,0,1,7),
(15,'Bebek Betutu',138000,0,1,6),
(16,'Chicken Taliwang',138000,0,1,7),
(17,'Oxtail Fried Rice',120000,0,1,10),
(18,'Javanese Fried Noodles',118000,0,1,11),
(19,'Madurese Satay (12 pcs)',138000,0,1,6),
(20,'Chicken Adobo (Philippines)',98000,0,1,10),
(21,'Japanese Curry Beef Katsu Udon',158000,0,1,11),
(22,'Beef Tenderloin Steak - 200 grams',388000,0,1,7),
(23,'Rib Eye Steak - 250 grams',348000,0,1,7),
(24,'Sirloin Steak - 250 grams',315000,0,1,7),
(25,'Lamb Chops - 220 grams (3 pieces)',378000,0,1,7),
(26,'Chicken Breast - 160 grams',160000,0,1,7),
(27,'Salmon Fillet - 180 grams',298000,0,1,9),
(28,'Wagyu Burger (180 gr)',208000,0,1,5),
(29,'Club Sandwich',130000,0,1,5),
(30,'Country Tuna',138000,0,1,5),
(31,'Bulgogi Sandwich',138000,0,1,5),
(32,'Chicken Tortilla Rujak Sauce',108000,0,1,5),
(33,'Tagliatelle Pasta with Wild Mushrooms and Pancetta',148000,0,1,3),
(34,'Wild Mushroom Risotto',148000,0,1,3),
(35,'Pappardelle with Lamb Ragu',168000,0,1,3),
(36,'Beef Lasagna Bolognese',138000,0,1,3),
(37,'Spaghetti Carbonara',148000,0,1,3),
(38,'Spaghetti Aglio E Olio',110000,0,1,3),
(39,'Ricotta Cheese and Mushroom Tortelloni',188000,0,1,3),
(40,'Gnocchi with Basil Pesto',168000,0,1,3),
(41,'Margherita Pizza',98000,0,1,4),
(42,'Quattro Formaggi',160000,0,1,4),
(43,'Capricciosa Pizza',138000,0,1,4),
(44,'Diavola Pizza',138000,0,1,4),
(45,'Sauteed Mushrooms Pizza',148000,0,1,4),
(46,'Tuna Pizza',148000,0,1,4),
(47,'Grilled Chicken Pizza',148000,0,1,4),
(48,'Beef Pepperoni Pizza',148000,0,1,4),
(49,'Smoked Beef Ham Pizza',148000,0,1,4),
(50,'Tandoori Roti',168000,0,1,5),
(51,'Naan Bread with Buttered Garlic and Cheese',68000,0,1,5),
(52,'Rice Briyani with Lamb',148000,0,1,10),
(53,'Chicken Butter Masala',135000,0,1,7),
(54,'Tandoori with Chicken and Prawns',138000,0,1,8),
(55,'Deep Fried Banana with Cinnamon',78000,0,1,17),
(56,'Tiramisu',68000,0,1,17),
(57,'Seasonal Local Fruits Platter',78000,0,1,17),
(58,'Vanilla/Strawberry/Chocolate/Oreo/Coffee Gelato Ice Cream (2 scoops)',68000,0,1,17),
(59,'Espresso Parfait',88000,0,1,17),
(60,'Chocolate Salami',78000,0,1,17),
(61,'Wok-Fried Crispy Pork Belly Cantonese Style',208000,0,1,8),
(62,'Salted Egg with Crispy Fragrant Fish Skin',128000,0,1,8),
(63,'Poached Chicken with Fragrant Ma La Sauce',208000,0,1,8),
(64,'Fragrant Sliced Pecking Duck with Cucumber and Crispy Corn',128000,0,1,8),
(65,'Fragrant Sliced Top-Shell with Spicy Sour',308000,0,1,8),
(66,'Crystal Barbecued Pork Belly \"Char Siew\"',176000,0,1,8),
(67,'Barbecued Meat Platter',298000,0,1,8),
(68,'Peking Duck - Two Ways',288000,0,1,8),
(69,'Cantonese Crispy Chicken',148000,0,1,8),
(70,'Szechuan Seafood Soup',68000,0,1,2),
(71,'Golden Carrot Soup',68000,0,1,2),
(72,'Double Boiled Dried Scallop, Fish Maw, and Sea Cucumber Soup',108000,0,1,2),
(73,'Golden Fragrant Fish Lip Soup',88000,0,1,2),
(74,'Double Boiled Three-Treasure Soup',478000,0,1,2),
(75,'Steamed Hokkaido Scallops with Minced Garlic Butter and Glass Noodles',658000,0,1,9),
(76,'Steamed Tiger Prawns with Minced Garlic Butter and Glass Noodles',248000,0,1,9),
(77,'Wok-Fried Fragrant Prawns',388000,0,1,9),
(78,'Wok-Fried Marble Fish Fillet (100 gram)',128000,0,1,9),
(79,'Wok-Fried Gurami Fish Fillet (100 gram)',60000,0,1,9),
(80,'Wok-Fried Red Tilapia Fish Fillet (100 gram)',65000,0,1,9),
(81,'Grouper Fish Steamed with Garlic Butter',88000,0,1,9),
(82,'Baby Lobster',258000,0,1,9),
(83,'Green Lobster',288000,0,1,9),
(84,'Wok-Fried/Pan Seared Beef with Black Pepper Sauce',338000,0,1,6),
(85,'Wok-Fried/Pan Seared Beef with Red Wine Sauce',348000,0,1,6),
(86,'Wok-Fried/Pan Seared Beef with Mongolian Sauce',298000,0,1,6),
(87,'Wok-Fried Pork with Sweet and Sour Sauce',158000,0,1,6),
(88,'Wok-Fried Pork with Red Wine Sauce',218000,0,1,6),
(89,'Wok-Fried Pork with Wok-Fried Ginger, Sliced Spring Onion and Garlic',158000,0,1,6),
(90,'Wok-Fried Chicken with Three Cup Sauce',158000,0,1,6),
(91,'Wok-Fried Chicken with Fragrant Butter Sauce',158000,0,1,6),
(92,'Wok-Fried Chicken with Walnut Sauce',158000,0,1,6),
(93,'Wok-Fried Chicken with X.O. Sauce',288000,0,1,6),
(94,'Eight Treasure Flamed Chicken in Clay (Pre-order only)',988000,0,1,6),
(95,'Stir-Fried French Bean with Shimeji Mushrooms and Minced Chicken \"Sichuan\" Style',138000,0,1,12),
(96,'Braised Eggplant with Minced Chicken in Hot Bean Paste',138000,0,1,12),
(97,'Crispy Homemade Beancurd with Fruit Sauce',138000,0,1,12),
(98,'Blanched is Spinach with Enoki Mushrooms, Wolfberries and Beancurd skin',148000,0,1,12),
(99,'Broccoli/Spinach/Chinese Cabbage/Celery/Kai-lan/Seasonal Vegetables',118000,0,1,12),
(100,'Young Chow Seafood Fried Rice',208000,0,1,10),
(101,'Crispy Fried Rice with Caviar and Seafood',208000,0,1,10),
(102,'X.O. Seafood Fried Rice',258000,0,1,10),
(103,'Steamed Dumpling Prawn in Fragrant Ma La Sauce',138000,0,1,13),
(104,'Steamed Chicken with Mushroom Pau (4 pieces)',98000,0,1,13),
(105,'Baked Eight-Minute Rice with Seafood in Curry Sauce Nanyang Style',258000,0,1,10),
(106,'Boiled Pork Dumplings with Minced Chinese Celery Stuffing (8 pieces)',108000,0,1,13),
(107,'Braised Noodles with Seafood Cantonese Style',208000,0,1,11),
(108,'Crispy Noodles with Chicken Cantonese Style',188000,0,1,11),
(109,'Dry Wanton Noodles with Chicken',188000,0,1,11),
(110,'Beef Noodle Soup',208000,0,1,11),
(111,'Stir-Fried Flat Rice Noodles with Sliced Beef Tenderloin Onion and Bean Sprouts',208000,0,1,11),
(112,'Rice Noodles Meesua with Ginger Wine and Fried Egg Soup',188000,0,1,11),
(113,'Singaporean Fried Vermicelli Noodles with Seafood',208000,0,1,11),
(114,'Braised Vermicelli Noodles with Pork',188000,0,1,11),
(115,'Rice Noodles Meesua with Seafood & Fish Bone Soup',258000,0,1,11),
(116,'Steamed Pork Spare Ribs',38000,0,1,13),
(117,'Glatinous Rice Dumplings with Minced Duck in Black Pepper Sauce',38000,0,1,13),
(118,'Steamed Beancurd Skin with Pork Vegetable and Thai Chili Sauce',38000,0,1,13),
(119,'Steamed Bacon Rolls with King Sauce',38000,0,1,13),
(120,'Barbecue Pork Bun',38000,0,1,13),
(121,'Nishimura Bento',598000,0,1,13),
(122,'Maiko Bento',338000,0,1,13),
(123,'Sushi Bento',268000,0,1,13),
(124,'Grilled Beef with Teriyaki Sauce',188000,0,1,7),
(125,'Grilled Chicken with Teriyaki Sauce',88000,0,1,7),
(126,'Assorted Grilled Chicken Skewers',118000,0,1,7),
(127,'Grilled Eggplant',58000,0,1,7),
(128,'Grilled Mackarel',118000,0,1,7),
(129,'Grilled Squid with Salt',88000,0,1,7),
(130,'Grilled Saury Fish',88000,0,1,7),
(131,'Grilled Marinated Cod Fish with Miso',538000,0,1,7),
(132,'Grilled Salmon with Teriyaki Sauce or Salt',148000,0,1,7),
(133,'Assorted Deluxe Sushi',458000,0,1,14),
(134,'Marinated Tuna on Sushi Rice',135000,0,1,14),
(135,'Vinegar Mackarel on Sushi Rice',880000,0,1,14),
(136,'Vinegar Salmon on Sushi Rice',108000,0,1,14),
(137,'Salmon and Salmon Roe on Sushi Rice',188000,0,1,14),
(138,'Sushi with Tempura Prawn',128000,0,1,14),
(139,'Soft Shell Crab Roll',188000,0,1,14),
(140,'Grilled Salmon Salad Roll',168000,0,1,14),
(141,'Tempura Sushi Rool with Sea Eel',118000,0,1,14),
(142,'Crab Stick Sashimi',78000,0,1,14),
(143,'Assorted Deluxe Sashimi',458000,0,1,14),
(144,'Sansyu Sashimi Moriawase (Three kinds of Sashimi)',98000,0,1,14),
(145,'Cold Noodles',158000,0,1,11),
(146,'Hot Sweet Fried Tofu Noodles',148000,0,1,11),
(147,'Egg and Fried Tofu Hot Noodles',168000,0,1,11),
(148,'Tempura Hot Noodles',138000,0,1,11),
(149,'Beef Hot Noodles',158000,0,1,11),
(150,'Seafood Hot Noodles',178000,0,1,11),
(151,'Green Tea Noodles',98000,0,1,11),
(152,'White Thin Noodles',68000,0,1,11),
(153,'Shabu-Shabu Imported Beef',318000,0,1,15),
(154,'Shabu-Shabu Wagyu Beef',888000,0,1,15),
(155,'Sukiyaki Imported Beef',308000,0,1,15),
(156,'Sukiyaki Wagyu Beef',888000,0,1,15),
(157,'Chilled Chinese Pear with Honey and Lemon',188000,0,1,17),
(158,'Refreshing Lemongrass Jelly with Lime Sorbet',38000,0,1,17),
(159,'Double-Bouled Imperial Bird\'s Nest with Honey and Lemon',188000,0,1,17),
(160,'Tempura Custard Milk Cream',38000,0,1,17),
(161,'Deep-Fried Crumbled Taro Ice Cream',58000,0,1,17),
(162,'Asparagus with Cream Corn Soup',68000,0,1,16),
(163,'Vegetarian Duck with Chinese Flower Buns and Condiments',138000,0,1,16),
(164,'Braised Assorted Wild Mushrooms with Pak Choy',138000,0,1,16),
(165,'Sauteed Mixed Vegetables with Cashew Nuts',138000,0,1,16),
(166,'Vegetarian Fried Rice',138000,0,1,16),
(167,'Orange Juice',75000,0,1,21),
(168,'Pineapple Juice',55000,0,1,21),
(169,'Watermelon Juice',55000,0,1,21),
(170,'Avocado Juice',55000,0,1,21),
(171,'Melon Juice',55000,0,1,21),
(172,'Coca-Cola (Regular, Zero, Diet)',45000,0,1,22),
(173,'Sprite',45000,0,1,22),
(174,'Tonic Water',45000,0,1,22),
(175,'Soda Water',45000,0,1,22),
(176,'Ginger Ale',45000,0,1,22),
(177,'Green Sands',45000,0,1,22),
(178,'Cold Ocha',40000,0,1,22),
(179,'Sapporo',125000,0,1,23),
(180,'Bintang Beer 300 ml',70000,0,1,23),
(181,'Heineken 300 ml',90000,0,1,23),
(182,'San Miguel 300 ml',78000,0,1,23),
(183,'Carlsberg 300 ml',78000,0,1,23),
(184,'Guinness Stout 300 ml',83000,0,1,23),
(185,'Acqua Panna Natural 500 ml',65000,0,1,19),
(186,'Acqua Panna Natural 1000 ml',110000,0,1,19),
(187,'San Pellegrino Sparkling 500 ml',65000,0,1,19),
(188,'San Pellegrino Sparkling 1000 ml',110000,0,1,19),
(189,'Evian 500 ml',55000,0,1,19),
(190,'Fiji Water 500 ml',55000,0,1,19),
(191,'Equil Still 330 ml',48000,0,1,19),
(192,'Equil Sparkling 330 ml',48000,0,1,19),
(193,'Aqua Reflection Still 500 ml',48000,0,1,19),
(194,'Aqua Reflection Sparkling 500 ml',48000,0,1,19),
(195,'French Earl Grey',65000,0,1,20),
(196,'Chamomile',65000,0,1,20),
(197,'Moroccan Mint',65000,0,1,20),
(198,'Jasmine Queen',65000,0,1,20),
(199,'Oolong Prestige',65000,0,1,20),
(200,'Ice Tea',55000,0,1,20),
(201,'Ice Lemon Tea',55000,0,1,20),
(202,'Ice Strawberry Tea',55000,0,1,20),
(203,'Ice Lychee Tea',55000,0,1,20),
(204,'Café Mocha',65000,0,1,18),
(205,'Black Coffee (Americano)',59000,0,1,18),
(206,'Cappuccino',59000,0,1,18),
(207,'Piccolo Latte',59000,0,1,18),
(208,'Espresso',59000,0,1,18),
(209,'Macchiato',59000,0,1,18),
(210,'Ristretto',59000,0,1,18),
(211,'Corretto',150000,0,1,18),
(212,'Flat White',65000,0,1,18);

/*Table structure for table `pemesanan_makanan` */

DROP TABLE IF EXISTS `pemesanan_makanan`;

CREATE TABLE `pemesanan_makanan` (
  `id_pemesanan` int(11) NOT NULL AUTO_INCREMENT,
  `kode_pemesanan` varchar(15) NOT NULL,
  `tanggal_pemesanan` date NOT NULL,
  `kode_tamu` varchar(7) NOT NULL,
  `total_biaya_pemesanan` int(16) NOT NULL,
  PRIMARY KEY (`id_pemesanan`),
  UNIQUE KEY `kode_pemesanan` (`kode_pemesanan`),
  KEY `kode_tamu` (`kode_tamu`),
  CONSTRAINT `pemesanan_makanan_ibfk_2` FOREIGN KEY (`kode_tamu`) REFERENCES `tamu` (`kode_tamu`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `pemesanan_makanan` */

insert  into `pemesanan_makanan`(`id_pemesanan`,`kode_pemesanan`,`tanggal_pemesanan`,`kode_tamu`,`total_biaya_pemesanan`) values 
(1,'NOTA26042200001','2022-04-26','JEHU001',479000),
(2,'NOTA26042200002','2022-04-26','DANA002',1148000),
(3,'NOTA01052200001','2022-05-01','YIJI001',948000),
(4,'NOTA04052200001','2022-05-04','YIJI001',70000),
(5,'NOTA16052200001','2022-05-16','LEHY001',406000);

/*Table structure for table `reservasi` */

DROP TABLE IF EXISTS `reservasi`;

CREATE TABLE `reservasi` (
  `id_reservasi` int(11) NOT NULL AUTO_INCREMENT,
  `kode_reservasi` varchar(15) NOT NULL,
  `kode_tamu` varchar(7) NOT NULL,
  `kode_kamar` varchar(7) NOT NULL,
  `down_payment` int(16) NOT NULL,
  `deposito` int(16) NOT NULL,
  `tanggal_check_in` date DEFAULT NULL,
  `tanggal_check_out` date DEFAULT NULL,
  `total_biaya` int(16) DEFAULT NULL,
  `kode_karyawan` varchar(5) NOT NULL,
  PRIMARY KEY (`id_reservasi`),
  UNIQUE KEY `kode_reservasi` (`kode_reservasi`),
  KEY `kode_tamu` (`kode_tamu`),
  KEY `kode_kamar` (`kode_kamar`),
  KEY `kode_karyawan` (`kode_karyawan`),
  CONSTRAINT `reservasi_ibfk_1` FOREIGN KEY (`kode_tamu`) REFERENCES `tamu` (`kode_tamu`),
  CONSTRAINT `reservasi_ibfk_2` FOREIGN KEY (`kode_kamar`) REFERENCES `kamar` (`kode_kamar`),
  CONSTRAINT `reservasi_ibfk_3` FOREIGN KEY (`kode_karyawan`) REFERENCES `karyawan` (`kode_karyawan`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4;

/*Data for the table `reservasi` */

insert  into `reservasi`(`id_reservasi`,`kode_reservasi`,`kode_tamu`,`kode_kamar`,`down_payment`,`deposito`,`tanggal_check_in`,`tanggal_check_out`,`total_biaya`,`kode_karyawan`) values 
(1,'RSV120422FW1102','FRWI001','ROS1102',1800000,4850000,'2022-04-25','2022-04-27',3600000,'RE001'),
(2,'RSV140422BG0911','BOGA001','DES911',1300000,4350000,'2022-04-29','2022-05-01',2600000,'RE002'),
(3,'RSV170422JM0418','JAMO001','DET418',550000,3000000,'2022-04-20','2022-04-24',1100000,'RE001'),
(4,'RSV180422JB1005','JIBO001','EXS1005',1450000,4700000,'2022-04-22','2022-04-26',2900000,'RE001'),
(5,'RSV180422JH0603','JEHU001','PRK603',1130000,3100000,'2022-04-25','2022-04-29',2260000,'RE003'),
(6,'RSV220422DN0212','DANA001','SUT212',465000,2750000,'2022-04-27','2022-04-29',930000,'RE001'),
(7,'RSV230422DN0119','DANA002','SUK119',445000,2500000,'2022-04-26',NULL,890000,'RE002'),
(8,'RSV250422CK0812','CHKA001','JUS812',950000,4000000,'2022-05-06','2022-05-09',1900000,'RE003'),
(9,'RSV270422YJ0605','YIJI001','PRT605',1150000,3250000,'2022-04-30','2022-05-05',2300000,'RE001'),
(10,'RSV010522LC0711','LECH001','CLT711',825000,3700000,'2022-05-11','2022-05-14',1650000,'RE003'),
(11,'RSV040522MM0716','MYMI001','CLK716',805000,3400000,'2022-05-13',NULL,1610000,'RE003'),
(12,'RSV070522SY0406','SUYU001','DEK406',530000,2850000,NULL,NULL,NULL,'RE002'),
(13,'RSV160522LJ1210','LEJI001','PRS1210',4550000,5000000,'2022-05-16',NULL,9100000,'RE002'),
(14,'RSV160522KM1211','KIMI001','PRS1211',4550000,5000000,'2022-05-16',NULL,9100000,'RE003'),
(15,'RSV160522LH1212','LEHY001','PRS1212',4550000,5000000,'2022-05-16',NULL,9100000,'RE002');

/*Table structure for table `tamu` */

DROP TABLE IF EXISTS `tamu`;

CREATE TABLE `tamu` (
  `id_tamu` int(11) NOT NULL AUTO_INCREMENT,
  `kode_tamu` varchar(7) NOT NULL,
  `nama_tamu` varchar(255) NOT NULL,
  `jenis_kelamin_tamu` varchar(1) NOT NULL,
  `tanggal_lahir_tamu` date NOT NULL,
  `alamat_tamu` varchar(255) NOT NULL,
  `negara_asal` varchar(255) NOT NULL,
  `nomor_telepon_tamu` varchar(13) NOT NULL,
  `email_tamu` varchar(255) NOT NULL,
  PRIMARY KEY (`id_tamu`),
  UNIQUE KEY `kode_tamu` (`kode_tamu`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tamu` */

insert  into `tamu`(`id_tamu`,`kode_tamu`,`nama_tamu`,`jenis_kelamin_tamu`,`tanggal_lahir_tamu`,`alamat_tamu`,`negara_asal`,`nomor_telepon_tamu`,`email_tamu`) values 
(1,'FRWI001','Frank Williams','L','1978-10-17','Jl. Siliwangi 381, Jawa Tengah','United States','0247608795','frankdwilliams@armyspy.com'),
(2,'BOGA001','Bobby Gainer','L','1977-07-22','Jl. Hayam Wuruk Glodok Jaya Blok C/28 Lt. Dasar, DKI Jakarta','United States','5152746701','bobbyagainer@dayrep.com'),
(3,'JAMO001','Janice Moore','P','1998-01-19','Jl. Ngagel Jaya Indah I/10, Jawa Timur','United States',' 0315025552','janicetmoore@teleworm.us'),
(4,'JIBO001','Jimmy Boggs','L','1980-06-10','Jl. Kalibutuh 195-197, Jawa Timur','United States','0315311552','jimmysboggs@rhyta.com'),
(5,'JEHU001','Jennie Huff','P','1990-05-13','Jl. Cempaka Putih XIX 8 RT 007/07, DKI Jakarta','United States','0214264274','jennielhuff@jourrapide.com'),
(6,'DANA001','Dalia Napolitano','P','1986-10-27','Jl. Rawagatel Kav. III Blok S-39, DKI Jakarta','Italy','0214894934','dalianapolitano@rhyta.com'),
(7,'DANA002','Dalgisa Napolitano','P','1996-07-12','Jl. Jayakarta 141 Blok C/14, DKI Jakarta','Italy','0216289758','dalgisanapolitano@armyspy.com'),
(8,'CHKA001','Chen Kang','L','1980-02-11','Jl. Jend Sudirman Kav. 33 A Wisma Standard Chartered Bank, DKI Jakarta','China','0215721057','chenkang@teleworm.us'),
(9,'YIJI001','Yi Jie Tseng','P','1989-10-28','Jl. Letjen Haryono MT 821, Jawa Tengah','Taiwan','0248316638','yijietseng@teleworm.us'),
(10,'LECH001','Lee Chou','L','1991-01-03','Kompleks Palem Indah Blok R-1/4 RT 011/011, DKI Jakarta','China','02186903256','leechou@teleworm.us'),
(11,'MYMI001','Myoui Mina','P','1997-03-24','Jl. Raya Kuta 56 Blok D-E, Bali','Japan','0361754391','minamyoui@twicejapan.com'),
(12,'SUYU001','Suzuhana Yuko','P','1983-06-07','Jl. Kelapa Puyuh 11 Kompleks Kelapa Gading Permai Blok KD/30, DKI Jakarta','Japan','0214520325','yukosuzuhana@wagakkiband.com'),
(13,'LEJI001','Lee Ji-eun','P','1993-05-16','Jl. Kol. Yos Sudarso 11 B, DKI Jakarta','South Korea','02143902350','dlwlrma@edam-ent.com'),
(14,'KIMI001','Kim Min-jeong','P','2001-01-01','Jl. Tarumanegara 67, DKI Jakarta','South Korea','0217499840','winter@sm-entertainment.com'),
(15,'LEHY001','Lee Hye-ri','P','1994-06-09','Jl. Purwakarta 169, Jawa Barat','South Korea','0227270229','hyerissi@gumiho.tv');

/*Table structure for table `use_extra_fasilitas` */

DROP TABLE IF EXISTS `use_extra_fasilitas`;

CREATE TABLE `use_extra_fasilitas` (
  `id_use_extra_fasilitas` int(11) NOT NULL AUTO_INCREMENT,
  `kode_kamar` varchar(7) NOT NULL,
  `kode_tamu` varchar(7) NOT NULL,
  `kode_extra_fasilitas` varchar(7) NOT NULL,
  `jumlah_extra_fasilitas` int(5) NOT NULL,
  PRIMARY KEY (`id_use_extra_fasilitas`),
  KEY `kode_kamar` (`kode_kamar`),
  KEY `kode_tamu` (`kode_tamu`),
  KEY `kode_extra_fasilitas` (`kode_extra_fasilitas`),
  CONSTRAINT `use_extra_fasilitas_ibfk_1` FOREIGN KEY (`kode_tamu`) REFERENCES `tamu` (`kode_tamu`),
  CONSTRAINT `use_extra_fasilitas_ibfk_2` FOREIGN KEY (`kode_kamar`) REFERENCES `kamar` (`kode_kamar`),
  CONSTRAINT `use_extra_fasilitas_ibfk_3` FOREIGN KEY (`kode_extra_fasilitas`) REFERENCES `extra_fasilitas` (`kode_extra_fasilitas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `use_extra_fasilitas` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
