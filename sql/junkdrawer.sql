-- phpMyAdmin SQL Dump
-- version 4.0.10.7
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 20, 2015 at 10:00 AM
-- Server version: 5.5.32-cll-lve
-- PHP Version: 5.4.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `junkdrawer`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE IF NOT EXISTS `categories` (
  `category_id` int(11) NOT NULL AUTO_INCREMENT,
  `category` varchar(150) NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`category_id`, `category`) VALUES
(1, 'Software');

-- --------------------------------------------------------

--
-- Table structure for table `ideas`
--

CREATE TABLE IF NOT EXISTS `ideas` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(1000) NOT NULL,
  `author` varchar(100) NOT NULL,
  `category_id` int(11) NOT NULL,
  `votes` int(11) NOT NULL,
  `expires` date NOT NULL,
  `permanent` tinyint(4) NOT NULL,
  `idea_name` varchar(150) NOT NULL,
  `links` varchar(10) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Dumping data for table `ideas`
--

INSERT INTO `ideas` (`ID`, `description`, `author`, `category_id`, `votes`, `expires`, `permanent`, `idea_name`, `links`) VALUES
(11, 'An open source solution to sharing ideas and creating new projects faster and easier. Add your idea to the queue for voting. If its successful, you then will be able to look at other ideas and link them together with the intent to improve upon them both.', 'Anonymous', 1, 1, '2015-12-21', 0, 'Junk Drawer', '0'),
(13, 'We should somehow wak our dogs smarter by creating routes for ourselves to follow and track steps, distacnce, etc.', 'Anonymous', 1, 16, '2015-12-21', 1, 'Idea for Dog walking', '14'),
(14, 'An app that displays map data for people who want to know distances theyve walked and jogged', 'Anonymous', 1, 14, '2015-12-21', 1, 'Map App', '0'),
(16, 'Create NFC tags to share with your friends. When you have company and they need the wifi password, it will be much easier to distribute it.', 'Anonymous', 1, -1, '2015-12-21', 0, 'Wifi NFC Tag', '');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
