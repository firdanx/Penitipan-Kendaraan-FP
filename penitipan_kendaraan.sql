-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 05, 2022 at 06:14 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `penitipan_kendaraan`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_kendaraan`
--

CREATE TABLE `tbl_kendaraan` (
  `id_kendaraan` char(5) NOT NULL,
  `merk_kendaraan` varchar(25) NOT NULL,
  `model_kendaraan` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_kendaraan`
--

INSERT INTO `tbl_kendaraan` (`id_kendaraan`, `merk_kendaraan`, `model_kendaraan`) VALUES
('K0001', 'Toyota', 'Avanza'),
('K0002', 'Lamborghinis', 'Gallardos');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_lokasi`
--

CREATE TABLE `tbl_lokasi` (
  `id_lokasi` char(5) NOT NULL,
  `letak_lokasi` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_lokasi`
--

INSERT INTO `tbl_lokasi` (`id_lokasi`, `letak_lokasi`) VALUES
('L0001', 'Block A'),
('L0002', 'Block B'),
('L0003', 'Block C');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pegawai`
--

CREATE TABLE `tbl_pegawai` (
  `id_pegawai` char(5) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL,
  `nama` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_pegawai`
--

INSERT INTO `tbl_pegawai` (`id_pegawai`, `username`, `password`, `nama`) VALUES
('P0001', 'peg1', 'peg1', 'WANGWUNG');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pemilik`
--

CREATE TABLE `tbl_pemilik` (
  `plat_nomor` varchar(15) NOT NULL,
  `id_kendaraan` char(5) NOT NULL,
  `nama_pemilik` varchar(15) NOT NULL,
  `alamat` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_pemilik`
--

INSERT INTO `tbl_pemilik` (`plat_nomor`, `id_kendaraan`, `nama_pemilik`, `alamat`) VALUES
('K 1234 RJ', 'K0001', 'Raihan', 'Purwodadi'),
('K 4321 RJ', 'K0001', 'Fajar', 'Grobogan');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pencatatan`
--

CREATE TABLE `tbl_pencatatan` (
  `id_pencatatan` char(5) NOT NULL,
  `plat_nomor` varchar(15) NOT NULL,
  `id_lokasi` char(5) NOT NULL,
  `id_pegawai` char(5) NOT NULL,
  `waktu_kedatangan` datetime NOT NULL,
  `waktu_pengambilan` datetime NOT NULL,
  `jumlah_hari` int(11) NOT NULL,
  `tagihan` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_pencatatan`
--

INSERT INTO `tbl_pencatatan` (`id_pencatatan`, `plat_nomor`, `id_lokasi`, `id_pegawai`, `waktu_kedatangan`, `waktu_pengambilan`, `jumlah_hari`, `tagihan`) VALUES
('PC001', 'K 1234 RJ', 'L0002', 'P0001', '2022-07-02 19:02:29', '2022-07-04 19:02:29', 2, 100000),
('PC002', 'K 4321 RJ', 'L0003', 'P0001', '2022-07-04 20:07:15', '2022-07-06 20:07:15', 2, 100000),
('PC003', 'K 1234 RJ', 'L0001', 'P0001', '2022-07-04 22:50:12', '2022-07-05 22:50:12', 1, 1),
('PC004', 'K 1234 RJ', 'L0002', 'P0001', '2022-07-04 22:47:14', '2022-07-04 22:47:14', 1, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_kendaraan`
--
ALTER TABLE `tbl_kendaraan`
  ADD PRIMARY KEY (`id_kendaraan`);

--
-- Indexes for table `tbl_lokasi`
--
ALTER TABLE `tbl_lokasi`
  ADD PRIMARY KEY (`id_lokasi`);

--
-- Indexes for table `tbl_pegawai`
--
ALTER TABLE `tbl_pegawai`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indexes for table `tbl_pemilik`
--
ALTER TABLE `tbl_pemilik`
  ADD PRIMARY KEY (`plat_nomor`),
  ADD KEY `id_kendaraan` (`id_kendaraan`);

--
-- Indexes for table `tbl_pencatatan`
--
ALTER TABLE `tbl_pencatatan`
  ADD PRIMARY KEY (`id_pencatatan`),
  ADD KEY `plat_nomor` (`plat_nomor`),
  ADD KEY `id_lokasi` (`id_lokasi`),
  ADD KEY `id_pegawai` (`id_pegawai`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_pemilik`
--
ALTER TABLE `tbl_pemilik`
  ADD CONSTRAINT `tbl_pemilik_ibfk_1` FOREIGN KEY (`id_kendaraan`) REFERENCES `tbl_kendaraan` (`id_kendaraan`);

--
-- Constraints for table `tbl_pencatatan`
--
ALTER TABLE `tbl_pencatatan`
  ADD CONSTRAINT `tbl_pencatatan_ibfk_1` FOREIGN KEY (`plat_nomor`) REFERENCES `tbl_pemilik` (`plat_nomor`),
  ADD CONSTRAINT `tbl_pencatatan_ibfk_2` FOREIGN KEY (`id_lokasi`) REFERENCES `tbl_lokasi` (`id_lokasi`),
  ADD CONSTRAINT `tbl_pencatatan_ibfk_3` FOREIGN KEY (`id_pegawai`) REFERENCES `tbl_pegawai` (`id_pegawai`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
