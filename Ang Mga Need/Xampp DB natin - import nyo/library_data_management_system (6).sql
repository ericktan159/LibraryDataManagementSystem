-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 15, 2022 at 05:20 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library_data_management_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_book`
--

CREATE TABLE `tbl_book` (
  `Book_ID` int(11) NOT NULL,
  `Book_Title` varchar(255) NOT NULL,
  `Book_Author` varchar(50) NOT NULL,
  `Book_Genre` varchar(50) NOT NULL,
  `Book_Year_Published` varchar(50) NOT NULL,
  `Book_Publisher` varchar(50) NOT NULL,
  `Book_Number_Of_Quantity` int(11) NOT NULL,
  `Book_Date_Encoded` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_book`
--

INSERT INTO `tbl_book` (`Book_ID`, `Book_Title`, `Book_Author`, `Book_Genre`, `Book_Year_Published`, `Book_Publisher`, `Book_Number_Of_Quantity`, `Book_Date_Encoded`) VALUES
(3, 'Hhh', 'Rick Warren', 'Self-Improvement', '2003', 'Rick Warren', 1, '2022-07-09 14:56:48'),
(4, 'Start Where You Are: A Guide To Compassionate Livi', 'Pema Chodron', 'Self-Improvement', '2007', 'Pema Chodron', 6, '2022-07-09 15:02:37'),
(5, 'You Are a Badass: How to Stop Doubting Your Greatn', 'Jen Sincero', 'Self-Improvement', '2015', 'Jen Sincero', 2, '2022-07-09 15:11:20'),
(6, 'self title', 'self author', 'self genre', '2022', 'self publisher', 2, '2022-07-09 16:04:09'),
(7, 'asd', 'Pema Chodron', 'qwe', '2022', '123asd', 1, '2022-07-09 16:37:15'),
(8, 'Try', 'Awit', 'Qwe', '2022', '123', 1, '2022-07-09 17:38:13'),
(14, 'Self Title', 'Self Author', 'Self Genre', '2022', 'Self Publisher', 2, '2022-07-14 14:16:29'),
(15, 'Time', 'NF', 'Romance', '2022', 'NF', 1, '2022-07-14 15:43:56'),
(16, 'Time', 'We', 'Romance', '2022', 'We', 1, '2022-07-14 15:45:45'),
(17, 'Ako Ikaw', 'Ako', 'Comedy', '2022', 'Ikaw', 1, '2022-07-14 16:02:12'),
(18, 'Panibago', 'We', 'Qw', '2022', 'Er', 1, '2022-07-14 16:04:51'),
(19, 'Agalay Sayo', 'Qw', 'Er', '2022', 'Qw', 1, '2022-07-14 16:06:03'),
(20, 'Tryadd', 'Qwe', 'Xzc', '2022', 'Asd', 1, '2022-07-14 16:16:08'),
(21, 'Tryupdatenew', 'Zxc', 'Qwe', '2022', 'Sd', 2, '2022-07-14 16:17:45'),
(22, 'Avatar', 'Aang', 'Comedy', '2011', 'Monks', 1, '2022-07-14 18:23:45');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_borrowed_book`
--

CREATE TABLE `tbl_borrowed_book` (
  `Borrowed_Book_ID` int(11) NOT NULL,
  `Book_ID` int(11) NOT NULL,
  `Borrower_ID` int(11) NOT NULL,
  `Borrowed_Book_Date_Borrowed` varchar(50) NOT NULL,
  `Borrowed_Book_Due_Date` varchar(50) NOT NULL,
  `Borrowed_Book_Due_Status` varchar(50) NOT NULL,
  `Borrowed_Book_Date_Returned` varchar(50) NOT NULL,
  `Borrowed_Book_Number_of_Copies` int(11) NOT NULL,
  `Borrowed_Book_Date_Encoded` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_borrower`
--

CREATE TABLE `tbl_borrower` (
  `Borrower_ID` int(11) NOT NULL,
  `Borrower_First_Name` varchar(50) NOT NULL,
  `Borrower_Middle_Name` varchar(50) DEFAULT '',
  `Borrower_Last_Name` varchar(50) NOT NULL,
  `Borrower_Gender` varchar(50) NOT NULL,
  `Borrower_Address` varchar(150) NOT NULL,
  `Borrower_Contact_Number` varchar(11) NOT NULL,
  `Borrower_BirthDate` varchar(50) NOT NULL,
  `Borrower_Type_of_Valid_ID` varchar(50) NOT NULL,
  `Borrower_Date_Encoded` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_borrower`
--

INSERT INTO `tbl_borrower` (`Borrower_ID`, `Borrower_First_Name`, `Borrower_Middle_Name`, `Borrower_Last_Name`, `Borrower_Gender`, `Borrower_Address`, `Borrower_Contact_Number`, `Borrower_BirthDate`, `Borrower_Type_of_Valid_ID`, `Borrower_Date_Encoded`) VALUES
(22, 'Jaydee', 'Senyee', 'Ketch', 'Male', 'Awitize', '12312312312', '06-17-1999', 'SSS ID', '2022-07-15 13:07:09'),
(23, 'Abigail', 'M', 'Kitts', 'Female', '8123  asdqwe ', '09123123123', '07-12-2022', 'Philhealth ID', '2022-07-15 13:54:28');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_logs`
--

CREATE TABLE `tbl_logs` (
  `log_id` int(11) NOT NULL,
  `log_description` text NOT NULL,
  `log_type` int(11) NOT NULL,
  `log_date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_logs`
--

INSERT INTO `tbl_logs` (`log_id`, `log_description`, `log_type`, `log_date`) VALUES
(4, 'Added new book with the id: 19', 3, '2022-07-14 16:06:04'),
(5, 'Added new book with the id: 19', 3, '2022-07-14 16:16:08'),
(6, 'Added new book with the id: 21', 3, '2022-07-14 16:17:45'),
(7, 'Updated book with the id: 21', 4, '2022-07-14 16:18:11'),
(8, 'Updated book with the id: 21', 4, '2022-07-14 16:20:38'),
(9, 'Updated book with the id: 21', 4, '2022-07-14 16:25:37'),
(10, 'Deleted book with the id: 13', 5, '2022-07-14 16:28:20'),
(11, 'testmember', 6, '2022-07-14 18:09:42'),
(12, 'test member update', 7, '2022-07-14 18:10:31'),
(13, 'id:23 user borrowed id:12 book', 1, '2022-07-14 18:11:06'),
(14, 'id:24 book has been returned by id:1 member', 2, '2022-07-14 18:11:36'),
(15, 'Added new book with the id: 22', 3, '2022-07-14 18:23:46'),
(16, 'Updated book with the id: 22', 4, '2022-07-14 18:25:39'),
(17, 'Deleted book with the id: 10', 5, '2022-07-14 18:28:43'),
(18, 'Deleted book with the id: 11', 5, '2022-07-14 18:28:47'),
(19, 'Deleted book with the id: 9', 5, '2022-07-14 18:28:50'),
(20, 'Updated book with the id: 3', 4, '2022-07-14 18:40:39'),
(21, 'Deleted book with the id: 12', 5, '2022-07-14 20:04:26'),
(22, 'Updated book with the id: 4', 4, '2022-07-14 20:49:34'),
(23, 'Registered New Member id: 23', 6, '2022-07-15 13:54:28'),
(24, 'Member:9 returned 1 Book:4;transaction ID:14', 2, '2022-07-15 18:48:21'),
(25, 'Member:9 returned All Book:4;transaction ID:14', 2, '2022-07-15 18:48:35'),
(26, 'Member:8 returned All Book:3;transaction ID:15', 2, '2022-07-15 18:49:08');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_log_types`
--

CREATE TABLE `tbl_log_types` (
  `id` int(11) NOT NULL,
  `description` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_log_types`
--

INSERT INTO `tbl_log_types` (`id`, `description`) VALUES
(1, 'Borrow'),
(2, 'Return'),
(3, 'Book Add'),
(4, 'Book Update'),
(5, 'Book Delete'),
(6, 'Member Add'),
(7, 'Member Update'),
(8, 'Member Delete');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_book`
--
ALTER TABLE `tbl_book`
  ADD PRIMARY KEY (`Book_ID`);

--
-- Indexes for table `tbl_borrowed_book`
--
ALTER TABLE `tbl_borrowed_book`
  ADD PRIMARY KEY (`Borrowed_Book_ID`),
  ADD KEY `Book_ID` (`Book_ID`),
  ADD KEY `Borrower_ID` (`Borrower_ID`);

--
-- Indexes for table `tbl_borrower`
--
ALTER TABLE `tbl_borrower`
  ADD PRIMARY KEY (`Borrower_ID`);

--
-- Indexes for table `tbl_logs`
--
ALTER TABLE `tbl_logs`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `log_type` (`log_type`);

--
-- Indexes for table `tbl_log_types`
--
ALTER TABLE `tbl_log_types`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_book`
--
ALTER TABLE `tbl_book`
  MODIFY `Book_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `tbl_borrowed_book`
--
ALTER TABLE `tbl_borrowed_book`
  MODIFY `Borrowed_Book_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tbl_borrower`
--
ALTER TABLE `tbl_borrower`
  MODIFY `Borrower_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `tbl_logs`
--
ALTER TABLE `tbl_logs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `tbl_log_types`
--
ALTER TABLE `tbl_log_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_borrowed_book`
--
ALTER TABLE `tbl_borrowed_book`
  ADD CONSTRAINT `tbl_borrowed_book_ibfk_1` FOREIGN KEY (`Book_ID`) REFERENCES `tbl_book` (`Book_ID`),
  ADD CONSTRAINT `tbl_borrowed_book_ibfk_2` FOREIGN KEY (`Borrower_ID`) REFERENCES `tbl_borrower` (`Borrower_ID`);

--
-- Constraints for table `tbl_logs`
--
ALTER TABLE `tbl_logs`
  ADD CONSTRAINT `tbl_logs_ibfk_1` FOREIGN KEY (`log_type`) REFERENCES `tbl_log_types` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
