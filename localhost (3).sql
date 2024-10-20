-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 06, 2024 at 11:11 PM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbkiosk`
--
CREATE DATABASE `dbkiosk` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `dbkiosk`;

-- --------------------------------------------------------

--
-- Table structure for table `tbadmin`
--

CREATE TABLE IF NOT EXISTS `tbadmin` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `userrole` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbadmin`
--

INSERT INTO `tbadmin` (`username`, `password`, `userrole`) VALUES
('cashier', 'cash', 'cashier'),
('manager', 'manager', 'manager'),
('admin', 'admin123', 'admin'),
('cantre', 'cantre123', 'haha');

-- --------------------------------------------------------

--
-- Table structure for table `tbinventory`
--

CREATE TABLE IF NOT EXISTS `tbinventory` (
  `prodid` int(100) NOT NULL AUTO_INCREMENT,
  `prodname` varchar(100) NOT NULL,
  `category` varchar(100) NOT NULL,
  `price` int(100) NOT NULL,
  `stock` int(100) NOT NULL,
  `image` varchar(100) NOT NULL,
  `productdesc` varchar(10000) NOT NULL,
  PRIMARY KEY (`prodid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tbinventory`
--

INSERT INTO `tbinventory` (`prodid`, `prodname`, `category`, `price`, `stock`, `image`, `productdesc`) VALUES
(1, 'manok', 'isda', 123, 123, 'sdadsasdasda', ''),
(2, 'sabaw', 'talbos', 456, 456, 'ddxczcxcxzc', ''),
(3, 'rex', 'ulaga', 143, 143, 'sadasdasdas', 'pabida');

-- --------------------------------------------------------

--
-- Table structure for table `tbqueing`
--

CREATE TABLE IF NOT EXISTS `tbqueing` (
  `orderno` int(20) NOT NULL AUTO_INCREMENT,
  `orders` varchar(1000) NOT NULL,
  `totalamount` int(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`orderno`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tbqueing`
--

INSERT INTO `tbqueing` (`orderno`, `orders`, `totalamount`, `status`) VALUES
(1, 'sdasdasd', 1000, 'dine in'),
(2, 'adasdasdasda', 1000, 'take out');
