-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 30, 2021 at 06:17 PM
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
-- Table structure for table `empleave`
--

CREATE TABLE `empleave` (
  `LID` int(11) NOT NULL,
  `EmpID` int(11) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Contact` char(10) NOT NULL,
  `NIC` char(10) NOT NULL,
  `JobPos` varchar(20) NOT NULL,
  `LeaveDate` date NOT NULL,
  `LeaveType` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `empleave`
--

INSERT INTO `empleave` (`LID`, `EmpID`, `FirstName`, `LastName`, `Contact`, `NIC`, `JobPos`, `LeaveDate`, `LeaveType`) VALUES
(5, 1, 'tharindu', 'dasun', '0764863190', '983660827v', 'QC', '2021-01-13', 'casual'),
(6, 1, 'tharindu', 'dasun', '0764863190', '983660827v', 'QC', '2021-01-18', 'casual'),
(7, 2, 'Dinuwan', 'Maduranga', '0715904735', 'no 20, pub', 'Supervisser ', '2021-01-06', 'casual'),
(8, 3, 'Dulanja', 'Dilshan', '0715904735', '996712369V', 'Driver', '2021-01-20', 'casual'),
(9, 4, 'chamath', 'rupasinghe', '0763456178', '981298123v', 'Labour', '2021-01-21', 'Medical'),
(10, 4, 'chamath', 'rupasinghe', '0763456178', '981298123v', 'Labour', '2021-01-21', 'casual'),
(11, 4, 'chamath', 'rupasinghe', '0763456178', 'no 20/1 pa', 'Labour', '2021-01-27', 'casual'),
(12, 8, 'sapumal', 'disnnayake', '0713445678', 'golahen wa', 'QC', '2021-01-31', 'Medical');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `empleave`
--
ALTER TABLE `empleave`
  ADD PRIMARY KEY (`LID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `empleave`
--
ALTER TABLE `empleave`
  MODIFY `LID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
