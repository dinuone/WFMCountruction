-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 30, 2021 at 06:18 PM
-- Server version: 10.4.16-MariaDB
-- PHP Version: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wfm`
--

-- --------------------------------------------------------

--
-- Table structure for table `project`
--

CREATE TABLE `project` (
  `prjID` int(11) NOT NULL,
  `ProjectName` varchar(60) NOT NULL,
  `ClientName` varchar(100) NOT NULL,
  `StartDate` date NOT NULL,
  `Duration` date NOT NULL,
  `Cost` int(100) NOT NULL,
  `Status` varchar(60) NOT NULL DEFAULT 'Newly Added',
  `profit` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `project`
--

INSERT INTO `project` (`prjID`, `ProjectName`, `ClientName`, `StartDate`, `Duration`, `Cost`, `Status`, `profit`) VALUES
(1, 'DOM Hostpital', 'Sun Lanka (pvt)Ltd', '2021-01-08', '2021-08-01', 20000000, 'Ongoing', 19370000),
(2, 'Nanyang', 'Veniro Ventures', '2021-01-14', '2021-10-21', 30000000, 'Ongoing', 29415000),
(3, 'IGH Institute', 'Mr.Lakshitha kumara', '2021-01-25', '2021-12-30', 40000000, 'Newly Added', NULL),
(6, 'Tokyo City Center', 'Sun Lanka (pvt)Ltd', '2021-01-21', '2021-08-19', 20000000, 'Ongoing', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `project`
--
ALTER TABLE `project`
  ADD PRIMARY KEY (`prjID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `project`
--
ALTER TABLE `project`
  MODIFY `prjID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
