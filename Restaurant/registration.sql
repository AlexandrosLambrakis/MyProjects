-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Φιλοξενητής: 127.0.0.1
-- Χρόνος δημιουργίας: 26 Μάη 2017 στις 15:07:50
-- Έκδοση διακομιστή: 10.1.21-MariaDB
-- Έκδοση PHP: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Βάση δεδομένων: `registration`
--

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `book`
--

CREATE TABLE `book` (
  `id` int(200) NOT NULL,
  `username` varchar(25) COLLATE utf8_bin NOT NULL,
  `date` varchar(20) COLLATE utf8_bin NOT NULL,
  `time` varchar(20) COLLATE utf8_bin NOT NULL,
  `persons` int(20) NOT NULL,
  `tables` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Άδειασμα δεδομένων του πίνακα `book`
--

INSERT INTO `book` (`id`, `username`, `date`, `time`, `persons`, `tables`) VALUES
(2, 'john', '05/23/2017', '13:00 PM', 4, 1),
(7, 'john', '05/10/2017', '19:00 PM', 2, 1);

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `users`
--

CREATE TABLE `users` (
  `id` int(200) NOT NULL,
  `roles` varchar(50) COLLATE utf8_bin NOT NULL,
  `firstname` text COLLATE utf8_bin NOT NULL,
  `lastname` text COLLATE utf8_bin NOT NULL,
  `email` varchar(50) COLLATE utf8_bin NOT NULL,
  `phone` int(10) NOT NULL,
  `username` varchar(50) COLLATE utf8_bin NOT NULL,
  `password` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Άδειασμα δεδομένων του πίνακα `users`
--

INSERT INTO `users` (`id`, `roles`, `firstname`, `lastname`, `email`, `phone`, `username`, `password`) VALUES
(1, 'admin', 'Admin', 'Admin', 'admin@hotmail.com', 698727492, 'admin', 1111),
(2, 'user', 'Alexandros', 'Dimitrakopoulos', 'alexdim@sda.com', 694928376, 'alexdim', 1997),
(3, 'user', 'Kostas', 'Ntroutsis', 'kostas12@hotmail.com', 657837573, 'kostasn', 4321),
(4, 'user', 'Xristos', 'Lambrakis', 'xristoslam13@hotmail.com', 695456980, 'xristoslam', 6472),
(5, 'user', 'Maria', 'Kantioti', 'mariak@hotmail.com', 687583921, 'mariak', 5829),
(6, 'user', 'Giannis', 'Georgiou', 'giannisg@hotmail.com', 698729382, 'giannisg', 9402),
(7, 'user', 'Giannis', 'Antoniou', 'giannaras13@homtail.com', 698787932, 'john', 1234),
(8, 'user', 'Anna', 'Papageorgiou', 'annap@hotmail.com', 698375823, 'annap', 1234);

--
-- Ευρετήρια για άχρηστους πίνακες
--

--
-- Ευρετήρια για πίνακα `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`id`);

--
-- Ευρετήρια για πίνακα `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT για άχρηστους πίνακες
--

--
-- AUTO_INCREMENT για πίνακα `book`
--
ALTER TABLE `book`
  MODIFY `id` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT για πίνακα `users`
--
ALTER TABLE `users`
  MODIFY `id` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
