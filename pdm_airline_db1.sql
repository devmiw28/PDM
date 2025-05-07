-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 07, 2025 at 11:59 PM
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
(1, 2, 3, 5, 'BOOK202505080504105028', '2025-05-08 05:04:10', 'Round-trip', 'Marilao   MRL', 'Cebu   CEB', 1600.00, 'confirmed'),
(2, 2, 19, 21, 'BOOK202505080520476315', '2025-05-08 05:20:47', 'Round-trip', 'Marilao   MRL', 'Davao   DVO', 1800.00, 'confirmed'),
(3, 2, 17, 19, 'BOOK202505080522048856', '2025-05-08 05:22:04', 'Round-trip', 'Marilao   MRL', 'Iloilo   ILO', 1200.00, 'confirmed'),
(4, 2, 21, 33, 'BOOK202505080524281436', '2025-05-08 05:24:28', 'Round-trip', 'Marilao   MRL', 'Palawan   PAL', 7000.00, 'confirmed'),
(5, 2, 22, 34, 'BOOK202505080532143547', '2025-05-08 05:32:14', 'Round-trip', 'Marilao   MRL', 'Davao   DVO', 1800.00, 'confirmed'),
(6, 2, 5, NULL, 'BOOK202505080537003476', '2025-05-08 05:37:01', 'One-way', 'Marilao   MRL', 'Cebu   CEB', 2300.00, 'confirmed');

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
(1, 'FN1ZC1UB', '2025-05-08', '10:00:00'),
(2, 'FN1ZC2UB', '2025-05-08', '20:00:00'),
(3, 'FN2ZC1UB', '2025-05-09', '09:00:00'),
(4, 'FN2ZC2UB', '2025-05-09', '19:00:00'),
(5, 'FN3ZC1UB', '2025-05-10', '08:30:00'),
(6, 'FN3ZC2UB', '2025-05-10', '18:30:00'),
(7, 'FN4ZC1UB', '2025-05-11', '09:15:00'),
(8, 'FN4ZC2UB', '2025-05-11', '19:15:00'),
(9, 'FN5ZC1UB', '2025-05-12', '07:45:00'),
(10, 'FN5ZC2UB', '2025-05-12', '17:45:00'),
(11, 'FN6ZC1UB', '2025-05-13', '10:00:00'),
(12, 'FN6ZC2UB', '2025-05-13', '20:00:00'),
(13, 'FN7ZC1UB', '2025-05-14', '08:30:00'),
(14, 'FN7ZC2UB', '2025-05-14', '18:30:00'),
(15, 'FN8ZC1UB', '2025-05-15', '09:00:00'),
(16, 'FN8ZC2UB', '2025-05-15', '19:00:00'),
(17, 'FN9ZC1UB', '2025-05-16', '07:30:00'),
(18, 'FN9ZC2UB', '2025-05-16', '17:30:00'),
(19, 'FN10ZC1UB', '2025-05-17', '10:00:00'),
(20, 'FN10ZC2UB', '2025-05-17', '20:00:00'),
(21, 'FN11ZC1UB', '2025-05-18', '09:15:00'),
(22, 'FN11ZC2UB', '2025-05-18', '19:15:00'),
(23, 'FN12ZC1UB', '2025-05-19', '08:45:00'),
(24, 'FN12ZC2UB', '2025-05-19', '18:45:00'),
(25, 'FN13ZC1UB', '2025-05-20', '09:00:00'),
(26, 'FN13ZC2UB', '2025-05-20', '19:00:00'),
(27, 'FN14ZC1UB', '2025-05-21', '08:30:00'),
(28, 'FN14ZC2UB', '2025-05-21', '18:30:00'),
(29, 'FN15ZC1UB', '2025-05-22', '09:15:00'),
(30, 'FN15ZC2UB', '2025-05-22', '19:15:00'),
(31, 'FN16ZC1UB', '2025-05-23', '07:45:00'),
(32, 'FN16ZC2UB', '2025-05-23', '17:45:00'),
(33, 'FN17ZC1UB', '2025-05-24', '10:00:00'),
(34, 'FN17ZC2UB', '2025-05-24', '20:00:00'),
(35, 'FN18ZC1UB', '2025-05-25', '09:00:00'),
(36, 'FN18ZC2UB', '2025-05-25', '19:00:00'),
(37, 'FN19ZC1UB', '2025-05-26', '08:30:00'),
(38, 'FN19ZC2UB', '2025-05-26', '18:30:00'),
(39, 'FN20ZC1UB', '2025-05-27', '09:00:00'),
(40, 'FN20ZC2UB', '2025-05-27', '19:00:00'),
(41, 'FN21ZC1UB', '2025-05-28', '07:30:00'),
(42, 'FN21ZC2UB', '2025-05-28', '17:30:00'),
(43, 'FN22ZC1UB', '2025-05-29', '10:00:00'),
(44, 'FN22ZC2UB', '2025-05-29', '20:00:00'),
(45, 'FN23ZC1UB', '2025-05-30', '09:15:00'),
(46, 'FN23ZC2UB', '2025-05-30', '19:15:00'),
(47, 'FN24ZC1UB', '2025-05-31', '08:45:00'),
(48, 'FN24ZC2UB', '2025-05-31', '18:45:00'),
(49, 'FN25ZC1UB', '2025-06-01', '09:00:00'),
(50, 'FN25ZC2UB', '2025-06-02', '19:00:00'),
(51, 'FN26ZC1UB', '2025-06-03', '08:30:00'),
(52, 'FN26ZC2UB', '2025-06-04', '18:30:00'),
(53, 'FN27ZC1UB', '2025-06-05', '09:00:00'),
(54, 'FN27ZC2UB', '2025-06-06', '19:00:00'),
(55, 'FN28ZC1UB', '2025-06-07', '08:30:00'),
(56, 'FN28ZC2UB', '2025-06-08', '18:30:00'),
(57, 'FN29ZC1UB', '2025-06-09', '09:00:00'),
(58, 'FN29ZC2UB', '2025-06-10', '19:00:00'),
(59, 'FN30ZC1UB', '2025-06-11', '08:30:00'),
(60, 'FN30ZC2UB', '2025-06-12', '18:30:00'),
(61, 'FN31ZC1UB', '2025-06-13', '09:00:00'),
(62, 'FN31ZC2UB', '2025-06-14', '19:00:00'),
(63, 'FN32ZC1UB', '2025-06-15', '08:30:00'),
(64, 'FN32ZC2UB', '2025-06-16', '18:30:00'),
(65, 'FN33ZC1UB', '2025-06-17', '09:00:00'),
(66, 'FN33ZC2UB', '2025-06-18', '19:00:00'),
(67, 'FN34ZC1UB', '2025-06-19', '08:30:00'),
(68, 'FN34ZC2UB', '2025-06-20', '18:30:00'),
(69, 'FN35ZC1UB', '2025-06-21', '09:00:00'),
(70, 'FN35ZC2UB', '2025-06-22', '19:00:00'),
(71, 'FN36ZC1UB', '2025-06-23', '08:30:00'),
(72, 'FN36ZC2UB', '2025-06-24', '18:30:00'),
(73, 'FN37ZC1UB', '2025-06-25', '09:00:00'),
(74, 'FN37ZC2UB', '2025-06-26', '19:00:00'),
(75, 'FN38ZC1UB', '2025-06-27', '08:30:00'),
(76, 'FN38ZC2UB', '2025-06-28', '18:30:00'),
(77, 'FN39ZC1UB', '2025-06-29', '09:00:00'),
(78, 'FN39ZC2UB', '2025-06-30', '19:00:00'),
(79, 'FN40ZC1UB', '2025-07-01', '08:30:00'),
(80, 'FN40ZC2UB', '2025-07-02', '18:30:00'),
(81, 'FN41ZC1UB', '2025-07-03', '09:00:00'),
(82, 'FN41ZC2UB', '2025-07-04', '19:00:00'),
(83, 'FN42ZC1UB', '2025-07-05', '08:30:00'),
(84, 'FN42ZC2UB', '2025-07-06', '18:30:00'),
(85, 'FN43ZC1UB', '2025-07-07', '09:00:00'),
(86, 'FN43ZC2UB', '2025-07-08', '19:00:00'),
(87, 'FN44ZC1UB', '2025-07-09', '08:30:00'),
(88, 'FN44ZC2UB', '2025-07-10', '18:30:00'),
(89, 'FN45ZC1UB', '2025-07-11', '09:00:00'),
(90, 'FN45ZC2UB', '2025-07-12', '19:00:00'),
(91, 'FN46ZC1UB', '2025-07-13', '08:30:00'),
(92, 'FN46ZC2UB', '2025-07-14', '18:30:00'),
(93, 'FN47ZC1UB', '2025-07-15', '09:00:00'),
(94, 'FN47ZC2UB', '2025-07-16', '19:00:00'),
(95, 'FN48ZC1UB', '2025-07-17', '08:30:00'),
(96, 'FN48ZC2UB', '2025-07-18', '18:30:00'),
(97, 'FN49ZC1UB', '2025-07-19', '09:00:00'),
(98, 'FN49ZC2UB', '2025-07-20', '19:00:00'),
(99, 'FN50ZC1UB', '2025-07-21', '08:30:00'),
(100, 'FN50ZC2UB', '2025-07-22', '18:30:00');

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
(1, 2, 'gcash', 1600.00, '2025-05-08 05:04:09', 'completed', 'TXN20250508050409'),
(2, 2, 'gcash', 1800.00, '2025-05-08 05:20:46', 'completed', 'TXN20250508052046'),
(3, 2, 'gcash', 1200.00, '2025-05-08 05:22:04', 'completed', 'TXN20250508052204'),
(4, 2, 'gcash', 7000.00, '2025-05-08 05:24:28', 'completed', 'TXN20250508052428'),
(5, 2, 'gcash', 1800.00, '2025-05-08 05:32:13', 'completed', 'TXN20250508053213'),
(6, 2, 'gcash', 2300.00, '2025-05-08 05:37:00', 'completed', 'TXN20250508053700');

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
(1, 'FNAB1XY', '2025-05-08', '11:30:00'),
(2, 'FNBC2YZ', '2025-05-08', '21:30:00'),
(3, 'FNDX1LM', '2025-05-09', '10:15:00'),
(4, 'FNEK2PJ', '2025-05-09', '20:15:00'),
(5, 'FNFZ3QS', '2025-05-10', '09:00:00'),
(6, 'FNTG4RX', '2025-05-10', '19:00:00'),
(7, 'FNUK5SD', '2025-05-11', '10:30:00'),
(8, 'FNLX6YH', '2025-05-11', '20:30:00'),
(9, 'FNKY7ZT', '2025-05-12', '08:00:00'),
(10, 'FNSH8CW', '2025-05-12', '18:00:00'),
(11, 'FNTM9UQ', '2025-05-13', '11:30:00'),
(12, 'FNPQ0GV', '2025-05-13', '21:30:00'),
(13, 'FNOI1HE', '2025-05-14', '09:45:00'),
(14, 'FNNJ2FI', '2025-05-14', '19:45:00'),
(15, 'FNSK3GJ', '2025-05-15', '10:30:00'),
(16, 'FNLI4HL', '2025-05-15', '20:30:00'),
(17, 'FNJS5CK', '2025-05-16', '09:00:00'),
(18, 'FNHJ6BH', '2025-05-16', '19:00:00'),
(19, 'FNQI7GN', '2025-05-17', '11:30:00'),
(20, 'FNRT8MP', '2025-05-17', '21:30:00'),
(21, 'FNSF9VA', '2025-05-18', '10:15:00'),
(22, 'FNXZ0UJ', '2025-05-18', '20:15:00'),
(23, 'FNPA1LO', '2025-05-19', '09:30:00'),
(24, 'FNZM2KI', '2025-05-19', '19:30:00'),
(25, 'FNTB3PQ', '2025-05-20', '10:00:00'),
(26, 'FNYA4DR', '2025-05-20', '20:00:00'),
(27, 'FNVF5EZ', '2025-05-21', '09:15:00'),
(28, 'FNEP6JS', '2025-05-21', '19:15:00'),
(29, 'FNVJ7GU', '2025-05-22', '11:00:00'),
(30, 'FNMR8DY', '2025-05-22', '21:00:00'),
(31, 'FNLU9KT', '2025-05-23', '09:45:00'),
(32, 'FNYO0BV', '2025-05-23', '19:45:00'),
(33, 'FNTW1HZ', '2025-05-24', '10:15:00'),
(34, 'FNYX2CY', '2025-05-24', '20:15:00'),
(35, 'FNDQ3GK', '2025-05-25', '09:00:00'),
(36, 'FNEX4IL', '2025-05-25', '19:00:00'),
(37, 'FNHY5JO', '2025-05-26', '10:30:00'),
(38, 'FNZM6FQ', '2025-05-26', '20:30:00'),
(39, 'FNJG7HA', '2025-05-27', '09:15:00'),
(40, 'FNYI8BD', '2025-05-27', '19:15:00'),
(41, 'FNTQ9KH', '2025-05-28', '10:00:00'),
(42, 'FNUG0SI', '2025-05-28', '20:00:00'),
(43, 'FNKI1GN', '2025-05-29', '09:30:00'),
(44, 'FNSP2MO', '2025-05-29', '19:30:00'),
(45, 'FNUF3DJ', '2025-05-30', '10:15:00'),
(46, 'FNTL4RX', '2025-05-30', '20:15:00'),
(47, 'FNUV5XY', '2025-05-31', '09:00:00'),
(48, 'FNMX6WA', '2025-05-31', '19:00:00'),
(49, 'FNYB7ZH', '2025-06-01', '10:30:00'),
(50, 'FNAX8QC', '2025-06-02', '20:30:00'),
(51, 'FNZB9PD', '2025-06-03', '09:45:00'),
(52, 'FNCL0QE', '2025-06-04', '19:45:00'),
(53, 'FNJK1VT', '2025-06-05', '10:00:00'),
(54, 'FNZW2UE', '2025-06-06', '20:00:00'),
(55, 'FNUR3SK', '2025-06-07', '09:30:00'),
(56, 'FNWT4GV', '2025-06-08', '19:30:00'),
(57, 'FNSX5DJ', '2025-06-09', '10:15:00'),
(58, 'FNTC6WQ', '2025-06-10', '20:15:00'),
(59, 'FNZG7LX', '2025-06-11', '09:00:00'),
(60, 'FNTI8WB', '2025-06-12', '19:00:00'),
(61, 'FNPI9DF', '2025-06-13', '10:30:00'),
(62, 'FNTQ0EJ', '2025-06-14', '20:30:00'),
(63, 'FNXY1RU', '2025-06-15', '09:45:00'),
(64, 'FNUE2FT', '2025-06-16', '19:45:00'),
(65, 'FNVF3SO', '2025-06-17', '10:00:00'),
(66, 'FNYG4UL', '2025-06-18', '20:00:00'),
(67, 'FNBD5KM', '2025-06-19', '09:15:00'),
(68, 'FNJQ6EW', '2025-06-20', '19:15:00'),
(69, 'FNYB7LV', '2025-06-21', '10:30:00'),
(70, 'FNSF8HZ', '2025-06-22', '20:30:00'),
(71, 'FNTL9AC', '2025-06-23', '09:00:00'),
(72, 'FNXA0UD', '2025-06-24', '19:00:00'),
(73, 'FNRB1FI', '2025-06-25', '10:15:00'),
(74, 'FNMC2GC', '2025-06-26', '20:15:00'),
(75, 'FNBG3UJ', '2025-06-27', '09:30:00'),
(76, 'FNAP4RZ', '2025-06-28', '19:30:00'),
(77, 'FNOU5SP', '2025-06-29', '10:00:00'),
(78, 'FNSQ6YH', '2025-06-30', '20:00:00'),
(79, 'FNHR7ML', '2025-07-01', '09:15:00'),
(80, 'FNJW8DK', '2025-07-02', '19:15:00'),
(81, 'FNAK9UB', '2025-07-03', '10:30:00'),
(82, 'FNVR0SK', '2025-07-04', '20:30:00'),
(83, 'FNHP1D', '2025-07-05', '09:45:00'),
(84, 'FNSX2W', '2025-07-06', '19:45:00'),
(85, 'FNVZ3FY', '2025-07-07', '10:00:00'),
(86, 'FNZP4EX', '2025-07-08', '20:00:00'),
(87, 'FNTG5UQ', '2025-07-09', '09:30:00'),
(88, 'FNXO6WA', '2025-07-10', '19:30:00'),
(89, 'FNPI7VL', '2025-07-11', '10:15:00'),
(90, 'FNVQ8EZ', '2025-07-12', '20:15:00'),
(91, 'FNRE9QT', '2025-07-13', '09:00:00'),
(92, 'FNDP0SW', '2025-07-14', '19:00:00'),
(93, 'FNHX1PR', '2025-07-15', '10:30:00'),
(94, 'FNKD2JX', '2025-07-16', '20:30:00'),
(95, 'FNBL3EZ', '2025-07-17', '09:15:00'),
(96, 'FNWL4GD', '2025-07-18', '19:15:00'),
(97, 'FNRM5UB', '2025-07-19', '10:00:00'),
(98, 'FNGY6XZ', '2025-07-20', '20:00:00'),
(99, 'FNAB7QL', '2025-07-21', '09:30:00'),
(100, 'FNVZ8WD', '2025-07-22', '19:30:00');

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
(1, 2, 'FN2ZC1UB', '2025-05-09 09:00:00', 'E13', 'Departure', '2025-05-07 21:04:10'),
(2, 2, 'FNFZ3QS', '2025-05-10 09:00:00', 'A11', 'Return', '2025-05-07 21:04:10'),
(3, 2, 'FN10ZC1UB', '2025-05-17 10:00:00', 'C11', 'Departure', '2025-05-07 21:20:47'),
(4, 2, 'FNSF9VA', '2025-05-18 10:15:00', 'C14', 'Return', '2025-05-07 21:20:47'),
(5, 2, 'FN9ZC1UB', '2025-05-16 07:30:00', 'C7', 'Departure', '2025-05-07 21:22:04'),
(6, 2, 'FNQI7GN', '2025-05-17 11:30:00', 'D11', 'Return', '2025-05-07 21:22:04'),
(7, 2, 'FN11ZC1UB', '2025-05-18 09:15:00', 'B1', 'Departure', '2025-05-07 21:24:28'),
(8, 2, 'FN11ZC1UB', '2025-05-18 09:15:00', 'F1', 'Departure', '2025-05-07 21:24:28'),
(9, 2, 'FN11ZC1UB', '2025-05-18 09:15:00', 'E2', 'Departure', '2025-05-07 21:24:28'),
(10, 2, 'FN11ZC1UB', '2025-05-18 09:15:00', 'F2', 'Departure', '2025-05-07 21:24:28'),
(11, 2, 'FN11ZC1UB', '2025-05-18 09:15:00', 'E3', 'Departure', '2025-05-07 21:24:28'),
(12, 2, 'FNTW1HZ', '2025-05-24 10:15:00', 'F21', 'Return', '2025-05-07 21:24:28'),
(13, 2, 'FNTW1HZ', '2025-05-24 10:15:00', 'E21', 'Return', '2025-05-07 21:24:28'),
(14, 2, 'FNTW1HZ', '2025-05-24 10:15:00', 'D22', 'Return', '2025-05-07 21:24:28'),
(15, 2, 'FNTW1HZ', '2025-05-24 10:15:00', 'F22', 'Return', '2025-05-07 21:24:28'),
(16, 2, 'FNTW1HZ', '2025-05-24 10:15:00', 'E22', 'Return', '2025-05-07 21:24:28'),
(17, 2, 'FN11ZC2UB', '2025-05-18 19:15:00', 'F11', 'Departure', '2025-05-07 21:32:14'),
(18, 2, 'FNYX2CY', '2025-05-24 20:15:00', 'A11', 'Return', '2025-05-07 21:32:14'),
(19, 2, 'FN3ZC1UB', '2025-05-10 08:30:00', 'F1', 'Departure', '2025-05-07 21:37:00');

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
(1, 'admin', '$2a$11$a8m7vUpzv6ogIFg8CD38Cu/4AVN4CkeawwoGHUu2iF3g/CZVJuW2W', 'admin', 1, '2025-05-07 19:29:37'),
(2, 'david28', '$2a$11$qfEPdTqo/nr85Vg5LlFxaeiq4J6lWJNPiefRlin5/P.xGA2ZAXCHW', 'user', 1, '2025-05-07 19:35:46');

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
  ADD UNIQUE KEY `transaction_reference` (`transaction_reference`),
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
  MODIFY `booking_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `depart_flights`
--
ALTER TABLE `depart_flights`
  MODIFY `depart_flight_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `return_flights`
--
ALTER TABLE `return_flights`
  MODIFY `return_flight_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT for table `seat_selected`
--
ALTER TABLE `seat_selected`
  MODIFY `seat_selected_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

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
