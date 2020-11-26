-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 26, 2020 at 12:54 PM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `bisu_time_stamp`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE IF NOT EXISTS `admin` (
  `admin_id` int(255) NOT NULL AUTO_INCREMENT,
  `admin_name` varchar(255) NOT NULL,
  `admin_user` varchar(255) NOT NULL,
  `admin_password` varchar(255) NOT NULL,
  `admin_role` varchar(255) NOT NULL,
  PRIMARY KEY (`admin_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `admin_name`, `admin_user`, `admin_password`, `admin_role`) VALUES
(1, 'Kitt', 'kittcy12', 'mhielagro', 'admin'),
(5, 'ray', 'ray123', '123', 'guard');

-- --------------------------------------------------------

--
-- Table structure for table `file_path`
--

CREATE TABLE IF NOT EXISTS `file_path` (
  `file_id` int(255) NOT NULL AUTO_INCREMENT,
  `file_location` varchar(255) NOT NULL,
  PRIMARY KEY (`file_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `file_path`
--

INSERT INTO `file_path` (`file_id`, `file_location`) VALUES
(1, '');

-- --------------------------------------------------------

--
-- Table structure for table `student_list`
--

CREATE TABLE IF NOT EXISTS `student_list` (
  `student_no` int(255) NOT NULL AUTO_INCREMENT,
  `student_id` int(255) NOT NULL,
  `student_fname` varchar(255) NOT NULL,
  `student_mname` varchar(255) NOT NULL,
  `student_lname` varchar(255) NOT NULL,
  `student_dept` varchar(255) NOT NULL,
  `student_year` int(255) NOT NULL,
  `student_course` varchar(255) NOT NULL,
  `student_section` varchar(255) NOT NULL,
  `log_status` int(5) NOT NULL,
  PRIMARY KEY (`student_no`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `student_list`
--

INSERT INTO `student_list` (`student_no`, `student_id`, `student_fname`, `student_mname`, `student_lname`, `student_dept`, `student_year`, `student_course`, `student_section`, `log_status`) VALUES
(1, 227785, 'Kitt Cymonne', 'Gulle', 'Japson', 'CEA', 3, 'CpE', 'B', 1),
(2, 252959, 'Caryl Jean', 'Salon', 'Quimado', 'CEA', 3, 'CpE', 'B', 0),
(3, 290749, 'Daynesa ', 'Saren', 'Fernandez ', 'CEA', 3, 'CpE', 'B', 0),
(4, 885829, 'Ric Ian', 'Ludivese', 'Jamora', 'CEA', 3, 'CpE', 'B', 0),
(5, 308287, 'Girley Kay', 'Lambiguit', 'Suarez', 'CEA', 3, 'CpE', 'B', 0),
(6, 340611, 'Maria Fliona', 'Aguiles', 'Ramirez', 'CEA', 3, 'CpE', 'B', 0),
(7, 752130, 'Andrea', 'Aliñab', 'Poliran', 'CEA', 3, 'CpE', 'B', 0),
(8, 611489, 'Grant Gregory', 'Castañares', 'Lopena', 'CEA', 3, 'CpE', 'B', 0),
(9, 393256, 'Jade Harris', 'Estillore', 'Roperos', 'CEA', 3, 'CpE', 'B', 0),
(10, 759037, 'Erwin', 'Erwin', 'Galler', 'CEA', 3, 'CpE', 'B', 0),
(11, 780311, 'John Michael', 'Gumop-as', 'Cadao', 'CEA', 3, 'CpE', 'B', 0),
(12, 196930, 'Ma Jezabelle', 'Alago', 'Belecina', 'CEA', 3, 'CpE', 'B', 0),
(13, 876666, 'Elvan', 'Baguhin', 'Budiongan', 'CEA', 3, 'CpE', 'B', 0),
(14, 743232, 'Shiela Mae', 'Logroño', 'Bitasolo', 'CEA', 3, 'CpE', 'B', 0);

-- --------------------------------------------------------

--
-- Table structure for table `student_log`
--

CREATE TABLE IF NOT EXISTS `student_log` (
  `log_no` int(255) NOT NULL AUTO_INCREMENT,
  `student_id` int(255) NOT NULL,
  `log_in` varchar(255) NOT NULL,
  `log_out` varchar(255) NOT NULL,
  `log_date` varchar(255) NOT NULL,
  `log_guard_id_in` int(255) NOT NULL,
  `log_guard_id_out` int(255) NOT NULL,
  PRIMARY KEY (`log_no`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `student_log`
--

INSERT INTO `student_log` (`log_no`, `student_id`, `log_in`, `log_out`, `log_date`, `log_guard_id_in`, `log_guard_id_out`) VALUES
(1, 227785, '12:11', '12:11', 'Nov 18, 2020', 1, 1),
(2, 743232, '12:11', '12:11', 'Nov 18, 2020', 1, 1),
(3, 227785, '12:13', '12:13', 'Nov 18, 2020', 1, 1),
(4, 227785, '23:46', '23:50', 'Nov 20, 2020', 1, 1),
(5, 227785, '23:50', '23:51', 'Nov 20, 2020', 1, 1),
(7, 227785, '18:56', '21:40', 'Nov 21, 2020', 1, 1),
(8, 227785, '21:42', '21:44', 'Nov 24, 2020', 1, 1),
(9, 227785, '21:44', '19:07', 'Nov 24, 2020', 1, 1),
(10, 227785, '22:31', '22:32', 'Nov 25, 2020', 1, 1),
(11, 227785, '10:50', '', 'Nov 26, 2020', 1, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
