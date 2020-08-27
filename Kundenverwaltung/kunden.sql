-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 27. Aug 2020 um 09:46
-- Server-Version: 10.1.40-MariaDB
-- PHP-Version: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `kunden`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kundenliste`
--

CREATE TABLE `kundenliste` (
  `kdnr` int(10) UNSIGNED NOT NULL,
  `vorname` varchar(100) CHARACTER SET utf8 NOT NULL,
  `nachname` varchar(100) CHARACTER SET utf8 NOT NULL,
  `strasse` varchar(100) CHARACTER SET utf8 NOT NULL,
  `plz` varchar(100) CHARACTER SET utf8 NOT NULL,
  `ort` varchar(168) CHARACTER SET utf8 NOT NULL,
  `email` varchar(100) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `kundenliste`
--

INSERT INTO `kundenliste` (`kdnr`, `vorname`, `nachname`, `strasse`, `plz`, `ort`, `email`) VALUES
(1, 'gdfg', 'dfgdfg', 'Megastr. 42', '12378', 'Berlin', 'tim@ccc.de'),
(2, 'Tim', 'Pritlove', 'Megastr. 42', '12378', 'Berlin', 'tim@ccc.de'),
(4, 'Clemens', 'Schrimpe', 'Pappelallee 13', '12765', 'Berlin', 'clemens@metaebene.de'),
(5, 'Clemens', 'Schrimpe', 'Pappelallee 13', '12765', 'Berlin', 'clemens@metaebene.de');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `kundenliste`
--
ALTER TABLE `kundenliste`
  ADD PRIMARY KEY (`kdnr`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
