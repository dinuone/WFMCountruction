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
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EmpID` int(11) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Contact` char(10) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `DOB` varchar(50) NOT NULL,
  `NIC` char(10) NOT NULL,
  `jobPos` varchar(30) NOT NULL,
  `DateNow` date NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `WorkExp` int(11) NOT NULL,
  `avbLeave` int(11) DEFAULT 42,
  `project` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EmpID`, `FirstName`, `LastName`, `Contact`, `Address`, `DOB`, `NIC`, `jobPos`, `DateNow`, `Gender`, `WorkExp`, `avbLeave`, `project`) VALUES
(1, 'tharindu', 'dasun', '0764863190', 'no 23/4 galwea, matale', 'Tuesday, September 9, 1997', 'no 23/4 ga', 'QC', '2021-01-01', 'Male', 1, 38, 'DOM Hostpital'),
(2, 'Dinuwan', 'Maduranga', '0715904735', 'no 20, pubudu mawatha, elwala,ukuwela', 'Thursday, December 31, 1998', 'no 20, pub', 'Supervisor', '2021-01-07', 'Male', 1, 41, 'DOM Hostpital'),
(3, 'Dulanja', 'Dilshan', '0715904735', 'no 23, hualngamuwa road, kubiyangoda', 'Thursday, January 21, 1999', 'no 23, hua', 'Driver', '2021-01-12', 'Male', 1, 41, 'DOM Hostpital'),
(4, 'chamath', 'rupasinghe', '0763456178', 'no 20/1 pallepola,matale', 'Thursday, April 8, 1982', 'no 20/1 pa', 'Labour', '2021-01-12', 'Male', 3, 38, 'DOM Hostpital'),
(5, 'jagath', 'weerasinghe', '0713456789', 'no 23/4 elahera road, miriya gas watta', 'Thursday, January 18, 1990', 'no 23/4 el', 'Labour', '2021-01-19', 'Male', 10, 42, 'DOM Hostpital'),
(6, 'sadun', 'kaluarachchi', '0781234567', 'no 34/1 sooriyawewa,hambanthota', 'Thursday, April 20, 1995', 'no 34/1 so', 'Labour', '2021-02-09', 'Male', 5, 42, 'Tokyo City Center'),
(7, 'kavindu', 'ramanayake', '0781212345', 'kalapititya, matale', 'Tuesday, October 14, 1997', 'kalapitity', 'Labour', '2021-02-09', 'Male', 3, 41, 'Nanyang'),
(8, 'sapumal', 'disnnayake', '0713445678', 'golahen watta, plapathwela', 'Thursday, March 23, 1989', 'golahen wa', 'QC', '2021-02-17', 'Male', 3, 41, 'Nanyang'),
(9, 'sadun', 'karunathilaka', '0761234567', 'no 23/1 dobawela,galkriyagama', 'Thursday, July 13, 1995', 'no 23/1 do', 'Driver', '2021-02-16', 'Male', 3, 42, 'Nanyang'),
(10, 'saman', 'kumara', '0781234567', 'no 23/4 galwela, matale', 'Wednesday, September 18, 1991', 'no 23/4 ga', 'Labour', '2021-02-22', 'Male', 5, 42, 'Nanyang'),
(13, 'sadaru', 'wickaramasinghe', '0764578678', 'no 23/ elahera, ', 'Tuesday, January 17, 1995', 'no 23/ ela', 'QC', '2021-01-19', 'Male', 4, 42, 'Tokyo City Center'),
(14, 'kasun', 'weligama', '0771234567', 'no 21, hulangamuwa ', 'Thursday, May 23, 1996', 'no 21, hul', 'Supervisor', '2021-02-22', 'Male', 7, 42, 'Nanyang'),
(15, 'kasun', 'vishwajith', '0761234567', 'raththota,matale', 'Tuesday, October 21, 1997', 'raththota,', 'Labour', '2021-02-23', 'Male', 3, 42, 'Tokyo City Center'),
(16, 'supun', 'kumarasisir', '0786545125', 'no 23/1 thawalankoya,ukuwela', 'Thursday, March 25, 2021', 'no 23/1 th', 'Labour', '2021-01-07', 'Male', 6, 42, 'Tokyo City Center');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EmpID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `EmpID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
