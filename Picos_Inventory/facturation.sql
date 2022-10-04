-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Client: localhost
-- Généré le: Lun 10 Février 2020 à 15:23
-- Version du serveur: 5.6.12-log
-- Version de PHP: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `facturation`
--
CREATE DATABASE IF NOT EXISTS `facturation` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `facturation`;

-- --------------------------------------------------------

--
-- Structure de la table `article`
--

CREATE TABLE IF NOT EXISTS `article` (
  `codeArticle` varchar(10) NOT NULL,
  `designationArticle` varchar(255) NOT NULL,
  `prixUnitaire` double NOT NULL,
  `qteArticle` int(11) NOT NULL,
  `typeArticle` varchar(100) NOT NULL,
  PRIMARY KEY (`codeArticle`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `numClt` int(11) NOT NULL AUTO_INCREMENT,
  `nomClt` varchar(35) NOT NULL,
  `prenomsClt` int(100) NOT NULL,
  `numTelClt` int(11) NOT NULL,
  `adrClt` text NOT NULL,
  PRIMARY KEY (`numClt`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

CREATE TABLE IF NOT EXISTS `commande` (
  `numCmd` int(11) NOT NULL AUTO_INCREMENT,
  `numClt` int(11) NOT NULL,
  `dateCmd` date NOT NULL,
  `montantCmd` double NOT NULL,
  PRIMARY KEY (`numCmd`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `detail_cmd`
--

CREATE TABLE IF NOT EXISTS `detail_cmd` (
  `numDetCmd` int(11) NOT NULL AUTO_INCREMENT,
  `numCmd` int(11) NOT NULL,
  `codeArticle` varchar(10) NOT NULL,
  `qteArticle` int(11) NOT NULL,
  PRIMARY KEY (`numDetCmd`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `type_article`
--

CREATE TABLE IF NOT EXISTS `type_article` (
  `numTypeArticle` int(11) NOT NULL AUTO_INCREMENT,
  `nomTypeArticle` varchar(100) NOT NULL,
  PRIMARY KEY (`numTypeArticle`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE IF NOT EXISTS `utilisateur` (
  `numUser` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`numUser`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
