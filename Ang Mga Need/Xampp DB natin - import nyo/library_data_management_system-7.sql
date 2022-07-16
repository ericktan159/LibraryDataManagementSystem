-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 16, 2022 at 02:54 AM
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
  MODIFY `Book_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `tbl_borrowed_book`
--
ALTER TABLE `tbl_borrowed_book`
  MODIFY `Borrowed_Book_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tbl_borrower`
--
ALTER TABLE `tbl_borrower`
  MODIFY `Borrower_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `tbl_logs`
--
ALTER TABLE `tbl_logs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

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
