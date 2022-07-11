-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 11, 2022 at 02:06 PM
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
(3, 'The Purpose-Driven Life: What on Earth Am I Here F', 'Rick Warren', 'Self-Improvement', '2003', 'Rick Warren', 1, '2022-07-09 14:56:48'),
(4, 'Start Where You Are: A Guide to Compassionate Livi', 'Pema Chodron', 'Self-Improvement', '2007', 'Pema Chodron', 3, '2022-07-09 15:02:37'),
(5, 'You Are a Badass: How to Stop Doubting Your Greatn', 'Jen Sincero', 'Self-Improvement', '2015', 'Jen Sincero', 2, '2022-07-09 15:11:20'),
(6, 'self title', 'self author', 'self genre', '2022', 'self publisher', 1, '2022-07-09 16:04:09'),
(7, 'asd', 'Pema Chodron', 'qwe', '2022', '123asd', 1, '2022-07-09 16:37:15'),
(8, 'Physics', 'awit', 'qwe', '2022', '123', 1, '2022-07-09 17:38:13'),
(9, 'Physics', 'as', 'zxc', '2022', 'qwe', 1, '2022-07-09 17:38:55'),
(10, 'Physics', 'asd', 'qwe', '2022', '12', 1, '2022-07-09 17:39:51'),
(11, 'Physics', 'qwe', '123', '2022', 'asd', 1, '2022-07-09 17:42:17'),
(12, 'Physics', 'einstein', 'zxca', '2022', 'qwe', 1, '2022-07-09 17:44:55'),
(13, 'Physics', 'Einstein', 'Comedy', '2022', '12', 31, '2022-07-09 18:08:46');

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

--
-- Dumping data for table `tbl_borrowed_book`
--

INSERT INTO `tbl_borrowed_book` (`Borrowed_Book_ID`, `Book_ID`, `Borrower_ID`, `Borrowed_Book_Date_Borrowed`, `Borrowed_Book_Due_Date`, `Borrowed_Book_Due_Status`, `Borrowed_Book_Date_Returned`, `Borrowed_Book_Number_of_Copies`, `Borrowed_Book_Date_Encoded`) VALUES
(3, 3, 7, '7/11/2022 7:27:38 PM', '7/11/2022 7:27:38 PM', 'Not Overdue', '', 1, '2022-07-11 19:27:48'),
(4, 5, 8, '7/11/2022 7:29:44 PM', '7/11/2022 7:29:44 PM', 'Not Overdue', '', 1, '2022-07-11 19:29:52'),
(6, 4, 10, '7/11/2022 7:29:44 PM', '7/11/2022 7:29:44 PM', 'Not Overdue', '', 1, '2022-07-11 19:30:22'),
(7, 5, 11, '7/11/2022 7:29:44 PM', '7/11/2022 7:29:44 PM', 'Not Overdue', '', 1, '2022-07-11 19:30:30'),
(8, 3, 8, '7/11/2022 7:29:44 PM', '7/11/2022 7:29:44 PM', 'Not Overdue', '', 1, '2022-07-11 19:30:42');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_borrower`
--

CREATE TABLE `tbl_borrower` (
  `Borrower_ID` int(11) NOT NULL,
  `Borrower_First_Name` varchar(50) NOT NULL,
  `Borrower_Middle_Name` varchar(50) NOT NULL,
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
(7, 'Frederick', 'B.', 'Tan', 'Male', 'Marikina City', '09123456789', '4/17/1997 5:16:14 PM', 'School ID', '2022-07-11 17:17:26'),
(8, 'Johndell', 'S.', 'Kitts', 'Male', 'Manila City', '09123456789', '1/1/1999 5:16:14 PM', 'School ID', '2022-07-11 17:19:02'),
(9, 'Jaira', 'B.', 'Cagomoc', 'Female', 'Phillipines', '09123456789', '4/18/1997 5:16:14 PM', 'School ID', '2022-07-11 17:19:59'),
(10, 'Kristal', 'L.', 'Calilung', 'Female', 'Pinas', '09123456789', '4/18/1998 5:16:14 PM', 'School ID', '2022-07-11 17:20:47'),
(11, 'Czr', 'A.', 'Coreo', 'Male', 'Tondo', '09123456789', '5/4/1999 5:16:14 PM', 'School ID', '2022-07-11 17:21:36'),
(12, 'Albert', 'T.', 'Einstein', 'Male', 'Germany', '09123456789', '3/14/1997 5:16:14 PM', 'School ID', '2022-07-11 17:24:28'),
(13, 'Nikola', 'B.', 'Tesla', 'Male', 'Croatia', '09123456789', '6/10/1997 5:16:14 PM', 'School ID', '2022-07-11 17:26:08'),
(14, 'Isaac', 'F.', 'Newton', 'Male', 'Engalnd', '09123456789', '1/4/1997 5:16:14 PM', 'School ID', '2022-07-11 17:27:31'),
(15, 'Marie', 'C.', 'Curie', 'Female', 'Poland', '09123456789', '11/7/1997 5:16:14 PM', 'School ID', '2022-07-11 17:29:00'),
(16, 'Amelia', 'E.', 'Earhart', 'Female', 'Kansas', '09123456789', '7/24/1997 5:16:14 PM', 'School ID', '2022-07-11 17:31:02'),
(17, 'Ada', 'G.', 'Lovelace', 'Female', 'London', '09123456789', '12/10/2022 5:31:48 PM', 'Schooll ID', '2022-07-11 17:33:04');

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
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_book`
--
ALTER TABLE `tbl_book`
  MODIFY `Book_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbl_borrowed_book`
--
ALTER TABLE `tbl_borrowed_book`
  MODIFY `Borrowed_Book_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbl_borrower`
--
ALTER TABLE `tbl_borrower`
  MODIFY `Borrower_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_borrowed_book`
--
ALTER TABLE `tbl_borrowed_book`
  ADD CONSTRAINT `tbl_borrowed_book_ibfk_1` FOREIGN KEY (`Book_ID`) REFERENCES `tbl_book` (`Book_ID`),
  ADD CONSTRAINT `tbl_borrowed_book_ibfk_2` FOREIGN KEY (`Borrower_ID`) REFERENCES `tbl_borrower` (`Borrower_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
