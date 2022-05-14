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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `jenis_kamar` */

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `kamar` */

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `karyawan` */

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
