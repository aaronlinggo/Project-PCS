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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `jenis_makanan` */

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `makanan` */

/*Table structure for table `pemesanan_makanan` */

DROP TABLE IF EXISTS `pemesanan_makanan`;

CREATE TABLE `pemesanan_makanan` (
  `id_pemesanan` int(11) NOT NULL AUTO_INCREMENT,
  `kode_pemesanan` varchar(13) NOT NULL,
  `id_makanan` int(11) NOT NULL,
  `tanggal_pemesanan` date NOT NULL,
  `kode_tamu` varchar(7) NOT NULL,
  `jumlah_pemesanan` int(5) NOT NULL,
  PRIMARY KEY (`id_pemesanan`),
  UNIQUE KEY `kode_pemesanan` (`kode_pemesanan`),
  KEY `kode_tamu` (`kode_tamu`),
  KEY `id_makanan` (`id_makanan`),
  CONSTRAINT `pemesanan_makanan_ibfk_1` FOREIGN KEY (`id_makanan`) REFERENCES `makanan` (`id_makanan`),
  CONSTRAINT `pemesanan_makanan_ibfk_2` FOREIGN KEY (`kode_tamu`) REFERENCES `tamu` (`kode_tamu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `pemesanan_makanan` */

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
  `total_tarif_kamar` int(16) NOT NULL,
  `kode_karyawan` varchar(5) NOT NULL,
  PRIMARY KEY (`id_reservasi`),
  UNIQUE KEY `kode_reservasi` (`kode_reservasi`),
  KEY `kode_tamu` (`kode_tamu`),
  KEY `kode_kamar` (`kode_kamar`),
  KEY `kode_karyawan` (`kode_karyawan`),
  CONSTRAINT `reservasi_ibfk_1` FOREIGN KEY (`kode_tamu`) REFERENCES `tamu` (`kode_tamu`),
  CONSTRAINT `reservasi_ibfk_2` FOREIGN KEY (`kode_kamar`) REFERENCES `kamar` (`kode_kamar`),
  CONSTRAINT `reservasi_ibfk_3` FOREIGN KEY (`kode_karyawan`) REFERENCES `karyawan` (`kode_karyawan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `reservasi` */

/*Table structure for table `tamu` */

DROP TABLE IF EXISTS `tamu`;

CREATE TABLE `tamu` (
  `id_tamu` int(11) NOT NULL AUTO_INCREMENT,
  `kode_tamu` varchar(7) NOT NULL,
  `nama_tamu` varchar(255) NOT NULL,
  `jenis_kelamin_tamu` varchar(1) NOT NULL,
  `tanggal_lahir_tamu` date NOT NULL,
  `alamat_tamu` varchar(255) NOT NULL,
  `nomor_telepon_tamu` varchar(13) NOT NULL,
  `email_tamu` varchar(255) NOT NULL,
  PRIMARY KEY (`id_tamu`),
  UNIQUE KEY `kode_tamu` (`kode_tamu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tamu` */

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
