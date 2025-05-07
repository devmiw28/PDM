-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 07, 2025 at 06:05 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pdm_airline_db1`
--

-- --------------------------------------------------------

--
-- Table structure for table `bookings`
--

CREATE TABLE `bookings` (
  `booking_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `depart_flight_id` int(11) NOT NULL,
  `return_flight_id` int(11) DEFAULT NULL,
  `booking_reference` varchar(30) NOT NULL,
  `booking_date` datetime NOT NULL DEFAULT current_timestamp(),
  `trip_type` varchar(10) DEFAULT 'One-way',
  `origin` varchar(50) DEFAULT NULL,
  `destination` varchar(50) DEFAULT NULL,
  `total_price` decimal(10,2) NOT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'confirmed'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookings`
--

INSERT INTO `bookings` (`booking_id`, `user_id`, `depart_flight_id`, `return_flight_id`, `booking_reference`, `booking_date`, `trip_type`, `origin`, `destination`, `total_price`, `status`) VALUES
(1, 3, 7, 6, 'BOOK202505070213147732', '2025-05-07 02:13:14', 'Round-trip', 'Marilao   MRL', 'Cebu   CEB', 2600.00, 'confirmed'),
(3, 3, 7, NULL, 'BOOK202505070416063420', '2025-05-07 04:16:06', 'One-way', 'Marilao   MRL', 'Cebu   CEB', 1300.00, 'confirmed'),
(4, 3, 6, 7, 'BOOK202505070428013846', '2025-05-07 04:28:01', 'Round-trip', 'Marilao   MRL', 'Davao   DVO', 19200.00, 'confirmed'),
(5, 3, 5, NULL, 'BOOK202505070435409548', '2025-05-07 04:35:40', 'One-way', 'Marilao   MRL', 'Cebu   CEB', 6900.00, 'confirmed'),
(6, 3, 7, NULL, 'BOOK202505070452192248', '2025-05-07 04:52:19', 'One-way', 'Marilao   MRL', 'Cebu   CEB', 800.00, 'confirmed'),
(7, 3, 5, NULL, 'BOOK202505070514069904', '2025-05-07 05:14:06', 'One-way', 'Marilao   MRL', 'Cebu   CEB', 2300.00, 'confirmed'),
(8, 3, 5, NULL, 'BOOK202505070514467445', '2025-05-07 05:14:46', 'One-way', 'Marilao   MRL', 'Cebu   CEB', 2300.00, 'confirmed'),
(9, 3, 5, NULL, 'BOOK202505070516018446', '2025-05-07 05:16:01', 'One-way', 'Marilao   MRL', 'Cebu   CEB', 2300.00, 'confirmed'),
(10, 3, 5, NULL, 'BOOK202505070518567016', '2025-05-07 05:18:56', 'One-way', 'Marilao   MRL', 'Cebu   CEB', 2300.00, 'confirmed'),
(11, 3, 5, NULL, 'BOOK202505070554564468', '2025-05-07 05:54:56', 'One-way', 'Marilao   MRL', 'Cebu   CEB', 2300.00, 'confirmed'),
(12, 3, 5, NULL, 'BOOK202505070600499391', '2025-05-07 06:00:49', 'One-way', 'Marilao   MRL', 'Cebu   CEB', 800.00, 'confirmed');

-- --------------------------------------------------------

--
-- Table structure for table `depart_flights`
--

CREATE TABLE `depart_flights` (
  `depart_flight_id` int(11) NOT NULL,
  `depart_flight_number` varchar(20) NOT NULL,
  `depart_date` date NOT NULL,
  `depart_time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `depart_flights`
--

INSERT INTO `depart_flights` (`depart_flight_id`, `depart_flight_number`, `depart_date`, `depart_time`) VALUES
(1, 'asd', '2025-05-05', '02:00:00'),
(2, '123', '2025-05-05', '03:00:00'),
(4, 'ewq', '2025-05-06', '11:00:00'),
(5, 'abc', '2025-05-09', '10:00:00'),
(6, 'qwe', '2025-05-08', '23:00:00'),
(7, 'zxc', '2025-05-08', '01:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `payment_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `payment_method` enum('credit_card','gcash','paymaya') NOT NULL,
  `payment_amount` decimal(10,2) NOT NULL,
  `payment_date` datetime NOT NULL DEFAULT current_timestamp(),
  `payment_status` enum('pending','completed','failed') NOT NULL DEFAULT 'pending',
  `transaction_reference` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`payment_id`, `user_id`, `payment_method`, `payment_amount`, `payment_date`, `payment_status`, `transaction_reference`) VALUES
(24, 3, 'paymaya', 4600.00, '2025-05-06 23:32:26', 'completed', 'TXN20250506233226'),
(27, 3, 'gcash', 1800.00, '2025-05-07 00:39:25', 'completed', 'TXN20250507003925'),
(28, 3, 'gcash', 800.00, '2025-05-07 00:54:26', 'completed', 'TXN20250507005426'),
(34, 3, 'paymaya', 2600.00, '2025-05-07 02:13:14', 'completed', 'TXN20250507021314'),
(36, 3, 'gcash', 1300.00, '2025-05-07 04:16:06', 'completed', 'TXN20250507041606'),
(37, 3, 'gcash', 19200.00, '2025-05-07 04:28:00', 'completed', 'TXN20250507042800'),
(38, 3, 'gcash', 6900.00, '2025-05-07 04:35:39', 'completed', 'TXN20250507043539'),
(39, 3, 'gcash', 800.00, '2025-05-07 04:52:19', 'completed', 'TXN20250507045219'),
(40, 3, 'gcash', 2300.00, '2025-05-07 05:14:06', 'completed', 'TXN20250507051406'),
(41, 3, 'gcash', 2300.00, '2025-05-07 05:14:45', 'completed', 'TXN20250507051445'),
(42, 3, 'gcash', 2300.00, '2025-05-07 05:16:01', 'completed', 'TXN20250507051601'),
(43, 3, 'gcash', 2300.00, '2025-05-07 05:18:56', 'completed', 'TXN20250507051856'),
(44, 3, 'gcash', 2300.00, '2025-05-07 05:54:56', 'completed', 'TXN20250507055456'),
(45, 3, 'gcash', 800.00, '2025-05-07 06:00:49', 'completed', 'TXN20250507060049');

-- --------------------------------------------------------

--
-- Table structure for table `return_flights`
--

CREATE TABLE `return_flights` (
  `return_flight_id` int(11) NOT NULL,
  `return_flight_number` varchar(20) NOT NULL,
  `return_date` date NOT NULL,
  `return_time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `return_flights`
--

INSERT INTO `return_flights` (`return_flight_id`, `return_flight_number`, `return_date`, `return_time`) VALUES
(1, '231', '2025-05-04', '01:00:00'),
(2, 'zxc', '2025-05-05', '13:00:00'),
(3, 'asd', '2025-05-05', '00:00:00'),
(4, 'xxx', '2025-05-06', '23:00:00'),
(5, 'cxz', '2025-05-06', '11:00:00'),
(6, 'dsa', '2025-05-10', '12:00:00'),
(7, '3ad', '2025-05-09', '15:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `seat_selected`
--

CREATE TABLE `seat_selected` (
  `seat_selected_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `flight_number` varchar(20) NOT NULL,
  `datetime` datetime NOT NULL,
  `seat_code` varchar(10) NOT NULL,
  `trip_leg` enum('Departure','Return') NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `seat_selected`
--

INSERT INTO `seat_selected` (`seat_selected_id`, `user_id`, `flight_number`, `datetime`, `seat_code`, `trip_leg`, `created_at`) VALUES
(1, 1, 'asd', '2025-05-05 02:00:00', 'F11', 'Departure', '2025-05-04 16:32:45'),
(9, 3, 'ewq', '2025-05-06 11:00:00', 'F14', 'Departure', '2025-05-05 17:54:16'),
(10, 3, 'xxx', '2025-05-06 23:00:00', 'F14', 'Return', '2025-05-05 17:54:17'),
(11, 3, 'ewq', '2025-05-06 11:00:00', 'F11', 'Departure', '2025-05-05 18:04:41'),
(12, 3, 'xxx', '2025-05-06 23:00:00', 'E11', 'Return', '2025-05-05 18:04:41'),
(13, 3, 'ewq', '2025-05-06 11:00:00', 'F14', 'Departure', '2025-05-05 18:07:46'),
(14, 3, 'xxx', '2025-05-06 23:00:00', 'F14', 'Return', '2025-05-05 18:07:46'),
(23, 3, 'zxc', '2025-05-08 01:00:00', 'F1', 'Departure', '2025-05-06 15:32:26'),
(24, 3, '3ad', '2025-05-09 15:00:00', 'E3', 'Return', '2025-05-06 15:32:26'),
(29, 3, 'qwe', '2025-05-08 23:00:00', 'B1', 'Departure', '2025-05-06 16:39:25'),
(30, 3, '3ad', '2025-05-09 15:00:00', 'D11', 'Return', '2025-05-06 16:39:25'),
(41, 3, 'zxc', '2025-05-08 01:00:00', 'E10', 'Departure', '2025-05-06 18:13:14'),
(42, 3, 'dsa', '2025-05-10 12:00:00', 'D7', 'Return', '2025-05-06 18:13:14'),
(45, 3, 'zxc', '2025-05-08 01:00:00', 'F5', 'Departure', '2025-05-06 20:16:06'),
(46, 3, 'qwe', '2025-05-08 23:00:00', 'D11', 'Departure', '2025-05-06 20:28:01'),
(47, 3, 'qwe', '2025-05-08 23:00:00', 'F11', 'Departure', '2025-05-06 20:28:01'),
(48, 3, 'qwe', '2025-05-08 23:00:00', 'E11', 'Departure', '2025-05-06 20:28:01'),
(49, 3, 'qwe', '2025-05-08 23:00:00', 'D12', 'Departure', '2025-05-06 20:28:01'),
(50, 3, '3ad', '2025-05-09 15:00:00', 'E1', 'Return', '2025-05-06 20:28:01'),
(51, 3, '3ad', '2025-05-09 15:00:00', 'F1', 'Return', '2025-05-06 20:28:01'),
(52, 3, '3ad', '2025-05-09 15:00:00', 'E2', 'Return', '2025-05-06 20:28:01'),
(53, 3, '3ad', '2025-05-09 15:00:00', 'F2', 'Return', '2025-05-06 20:28:01'),
(54, 3, 'abc', '2025-05-09 10:00:00', 'E1', 'Departure', '2025-05-06 20:35:40'),
(55, 3, 'abc', '2025-05-09 10:00:00', 'F1', 'Departure', '2025-05-06 20:35:40'),
(56, 3, 'abc', '2025-05-09 10:00:00', 'E2', 'Departure', '2025-05-06 20:35:40'),
(57, 3, 'zxc', '2025-05-08 01:00:00', 'F19', 'Departure', '2025-05-06 20:52:19'),
(58, 3, 'abc', '2025-05-09 10:00:00', 'B1', 'Departure', '2025-05-06 21:14:06'),
(59, 3, 'abc', '2025-05-09 10:00:00', 'A1', 'Departure', '2025-05-06 21:14:46'),
(60, 3, 'abc', '2025-05-09 10:00:00', 'F2', 'Departure', '2025-05-06 21:16:01'),
(61, 3, 'abc', '2025-05-09 10:00:00', 'B2', 'Departure', '2025-05-06 21:18:56'),
(62, 3, 'abc', '2025-05-09 10:00:00', 'A2', 'Departure', '2025-05-06 21:54:56'),
(63, 3, 'abc', '2025-05-09 10:00:00', 'F15', 'Departure', '2025-05-06 22:00:49');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `role` enum('admin','user') NOT NULL DEFAULT 'user',
  `is_verified` tinyint(1) DEFAULT 0,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password_hash`, `role`, `is_verified`, `created_at`) VALUES
(1, 'cjphonehome', '$2a$11$yQAEib55Ax1sxJdgn92BpuO2IUQNDuiPZLxMl7wkiB3s1hfzaIk7u', 'user', 1, '2025-05-03 14:54:22'),
(2, 'admin', '$2a$11$bdFSqa5aGlLofYCb2xy0a.mWQWxkXKvFWazXCk.cxLFkpXXC0WMiK', 'admin', 1, '2025-05-03 14:54:46'),
(3, '1', '$2a$11$OOBnkQR0bhzuZ1GmT4jJ0ul02P4N.6UtRF1sNjeQVVgUwtZcdneZG', 'user', 1, '2025-05-03 15:38:26');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bookings`
--
ALTER TABLE `bookings`
  ADD PRIMARY KEY (`booking_id`),
  ADD UNIQUE KEY `booking_reference` (`booking_reference`),
  ADD KEY `fk_booking_user` (`user_id`),
  ADD KEY `fk_depart_flight` (`depart_flight_id`),
  ADD KEY `fk_return_flight` (`return_flight_id`);

--
-- Indexes for table `depart_flights`
--
ALTER TABLE `depart_flights`
  ADD PRIMARY KEY (`depart_flight_id`),
  ADD UNIQUE KEY `UC_FlightNumber_Depart` (`depart_flight_number`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`payment_id`),
  ADD KEY `fk_payments_user` (`user_id`);

--
-- Indexes for table `return_flights`
--
ALTER TABLE `return_flights`
  ADD PRIMARY KEY (`return_flight_id`),
  ADD UNIQUE KEY `UC_FlightNumber_Return` (`return_flight_number`);

--
-- Indexes for table `seat_selected`
--
ALTER TABLE `seat_selected`
  ADD PRIMARY KEY (`seat_selected_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `email` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookings`
--
ALTER TABLE `bookings`
  MODIFY `booking_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `depart_flights`
--
ALTER TABLE `depart_flights`
  MODIFY `depart_flight_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT for table `return_flights`
--
ALTER TABLE `return_flights`
  MODIFY `return_flight_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `seat_selected`
--
ALTER TABLE `seat_selected`
  MODIFY `seat_selected_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=64;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bookings`
--
ALTER TABLE `bookings`
  ADD CONSTRAINT `fk_booking_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_depart_flight` FOREIGN KEY (`depart_flight_id`) REFERENCES `depart_flights` (`depart_flight_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_return_flight` FOREIGN KEY (`return_flight_id`) REFERENCES `return_flights` (`return_flight_id`) ON DELETE SET NULL;

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `fk_payments_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `seat_selected`
--
ALTER TABLE `seat_selected`
  ADD CONSTRAINT `seat_selected_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
