-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 05.04.2023 klo 13:05
-- Palvelimen versio: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Hotellitietokanta`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `asiakas`
--

CREATE TABLE `asiakas` (
  `tunnus` int(10) NOT NULL,
  `etu_nimi` varchar(50) NOT NULL,
  `suku_nimi` varchar(50) NOT NULL,
  `lahi_osoite` varchar(60) NOT NULL,
  `postinro` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `asiakas`
--

INSERT INTO `asiakas` (`tunnus`, `etu_nimi`, `suku_nimi`, `lahi_osoite`, `postinro`) VALUES
(8, 'Veijo', 'väliliha', 'osoite', '656465'),
(9, 'Jokke', 'Jakke', 'Jou 2', '02520'),
(10, 'Juu', 'Jaa', 'Jaatie 4', '02020');

-- --------------------------------------------------------

--
-- Rakenne taululle `huone`
--

CREATE TABLE `huone` (
  `numero` int(11) NOT NULL,
  `tyyppi` int(11) NOT NULL,
  `puhelin` varchar(50) NOT NULL,
  `vapaa` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `huone`
--

INSERT INTO `huone` (`numero`, `tyyppi`, `puhelin`, `vapaa`) VALUES
(1, 1, '121212', 'EI'),
(2, 2, '69696969', 'EI'),
(3, 3, '', 'Kyllä'),
(4, 4, '', 'Kyllä'),
(23, 2, '12123', 'EI'),
(33, 1, '1234656', 'EI');

-- --------------------------------------------------------

--
-- Rakenne taululle `huoneet`
--

CREATE TABLE `huoneet` (
  `valikoima_id` int(11) NOT NULL,
  `nimike` varchar(100) NOT NULL,
  `hinta` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `huoneet`
--

INSERT INTO `huoneet` (`valikoima_id`, `nimike`, `hinta`) VALUES
(1, 'yhdenhengen', '160'),
(2, 'kahdenhengen', '320'),
(3, 'perhe huone', '500'),
(4, 'sviitti', '2500');

-- --------------------------------------------------------

--
-- Rakenne taululle `kayttajat`
--

CREATE TABLE `kayttajat` (
  `id` int(11) NOT NULL,
  `kayttajanimi` varchar(50) NOT NULL,
  `salasana` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `kayttajat`
--

INSERT INTO `kayttajat` (`id`, `kayttajanimi`, `salasana`) VALUES
(1, 'admin', 'password');

-- --------------------------------------------------------

--
-- Rakenne taululle `varaukset`
--

CREATE TABLE `varaukset` (
  `varausID` int(11) NOT NULL,
  `huoneID` int(11) NOT NULL,
  `asiakasID` int(11) NOT NULL,
  `paivaSisaan` date NOT NULL,
  `paivaulos` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `varaukset`
--

INSERT INTO `varaukset` (`varausID`, `huoneID`, `asiakasID`, `paivaSisaan`, `paivaulos`) VALUES
(23, 1, 9, '2023-03-24', '2023-03-24'),
(25, 23, 8, '2023-03-24', '2023-03-30'),
(26, 33, 10, '2023-03-24', '2023-04-06'),
(28, 2, 8, '2023-03-27', '2023-03-27');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakas`
--
ALTER TABLE `asiakas`
  ADD PRIMARY KEY (`tunnus`);

--
-- Indexes for table `huone`
--
ALTER TABLE `huone`
  ADD PRIMARY KEY (`numero`),
  ADD KEY `fk_type_id` (`tyyppi`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`valikoima_id`);

--
-- Indexes for table `kayttajat`
--
ALTER TABLE `kayttajat`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`varausID`),
  ADD KEY `fk_client_id` (`asiakasID`),
  ADD KEY `fk_room_number` (`huoneID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asiakas`
--
ALTER TABLE `asiakas`
  MODIFY `tunnus` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `huoneet`
--
ALTER TABLE `huoneet`
  MODIFY `valikoima_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `kayttajat`
--
ALTER TABLE `kayttajat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `varausID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- Rajoitteet vedostauluille
--

--
-- Rajoitteet taululle `huone`
--
ALTER TABLE `huone`
  ADD CONSTRAINT `fk_type_id` FOREIGN KEY (`tyyppi`) REFERENCES `huoneet` (`valikoima_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Rajoitteet taululle `varaukset`
--
ALTER TABLE `varaukset`
  ADD CONSTRAINT `fk_client_id` FOREIGN KEY (`asiakasID`) REFERENCES `asiakas` (`tunnus`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_room_number` FOREIGN KEY (`huoneID`) REFERENCES `huone` (`numero`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
