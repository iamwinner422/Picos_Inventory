-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : mar. 08 sep. 2020 à 20:06
-- Version du serveur :  5.7.24
-- Version de PHP : 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `facturation`
--

-- --------------------------------------------------------

--
-- Structure de la table `clients`
--

CREATE TABLE `clients` (
  `num_clt` int(11) NOT NULL,
  `nom_clt` varchar(35) NOT NULL,
  `prenoms_clt` varchar(55) NOT NULL,
  `num_tel` char(8) NOT NULL,
  `adr_clt` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `clients`
--

INSERT INTO `clients` (`num_clt`, `nom_clt`, `prenoms_clt`, `num_tel`, `adr_clt`) VALUES
(5, 'Aleck', 'Bernard', '91181271', '3355 Madison Ave'),
(6, 'Segbe', 'Koffi Mathieu', '91716303', '12 Rue de la Kara'),
(7, 'Igodo', 'Saddat', '97432505', '120 Agoe Blabla'),
(8, 'Bilante', 'Honoré', '92868204', '102 Rue de Niamtougou'),
(10, 'Dzegle', 'Kwadzo Winner', '98023036', '11 Rue Avenue Akei'),
(11, 'Toto', 'toto', '91121871', 'toto');

-- --------------------------------------------------------

--
-- Structure de la table `commandes`
--

CREATE TABLE `commandes` (
  `num_cmd` int(11) NOT NULL,
  `num_clt` int(11) NOT NULL,
  `date_cmd` varchar(10) NOT NULL DEFAULT '',
  `montant_cmd` float NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `commandes`
--

INSERT INTO `commandes` (`num_cmd`, `num_clt`, `date_cmd`, `montant_cmd`) VALUES
(1, 8, '8/9/2020', 877000),
(2, 8, '8/9/2020', 120000),
(3, 5, '8/9/2020', 326000),
(4, 11, '8/9/2020', 711000);

-- --------------------------------------------------------

--
-- Structure de la table `details_cmd`
--

CREATE TABLE `details_cmd` (
  `num_det` int(11) NOT NULL,
  `num_cmd` int(11) NOT NULL,
  `num_prod` int(11) NOT NULL,
  `qte_cmdee` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `details_cmd`
--

INSERT INTO `details_cmd` (`num_det`, `num_cmd`, `num_prod`, `qte_cmdee`) VALUES
(1, 1, 1, 3),
(2, 1, 3, 2),
(3, 1, 2, 4),
(4, 1, 4, 6),
(5, 1, 5, 1),
(6, 2, 1, 2),
(7, 2, 3, 1),
(8, 3, 2, 1),
(9, 3, 4, 3),
(10, 3, 3, 1),
(11, 4, 1, 10),
(12, 4, 4, 3);

-- --------------------------------------------------------

--
-- Structure de la table `details_temp`
--

CREATE TABLE `details_temp` (
  `num_prod` int(11) DEFAULT NULL,
  `designation_prod` varchar(255) DEFAULT NULL,
  `qte_prod` int(11) DEFAULT NULL,
  `prix_unitaire` float DEFAULT NULL,
  `prix_total` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `histo_prod`
--

CREATE TABLE `histo_prod` (
  `num_his` int(11) NOT NULL,
  `nom_prod` varchar(255) NOT NULL,
  `qte_add` int(11) NOT NULL,
  `date_add` varchar(11) NOT NULL,
  `qte_actuelle` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `histo_prod`
--

INSERT INTO `histo_prod` (`num_his`, `nom_prod`, `qte_add`, `date_add`, `qte_actuelle`) VALUES
(1, 'iPhone SE 32Go', 2, '30/8/2020', 15),
(2, 'iPhone SE 32Go', 10, '7/9/2020', 11),
(3, 'LG Aristo 16Go', 17, '7/9/2020', 20),
(4, 'Samsung S7 Edge ', 12, '7/9/2020', 19),
(5, 'iPhone 4s 16Go', 14, '7/9/2020', 20),
(6, 'iPhone SE 32Go', 13, '7/9/2020', 16),
(7, 'iPhone 4s 16Go', 2, '7/9/2020', 12),
(8, 'LG G4 32Go', 3, '7/9/2020', 13),
(9, 'iPhone SE 32Go', 20, '8/9/2020', 25),
(10, 'LG Aristo 16Go', 14, '8/9/2020', 15),
(11, 'Samsung S7 Edge ', 8, '8/9/2020', 14),
(12, 'iPhone 4s 16Go', 7, '8/9/2020', 18);

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

CREATE TABLE `produits` (
  `num_prod` int(11) NOT NULL,
  `designation_prod` varchar(60) NOT NULL,
  `prix_unitaire` double NOT NULL,
  `qte_prod` int(11) NOT NULL,
  `date_add` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `produits`
--

INSERT INTO `produits` (`num_prod`, `designation_prod`, `prix_unitaire`, `qte_prod`, `date_add`) VALUES
(1, 'iPhone SE 32Go', 45000, 10, '27/8/2020'),
(2, 'LG Aristo 16Go', 35000, 10, '27/8/2020'),
(3, 'LG G4 32Go', 30000, 9, '27/8/2020'),
(4, 'Samsung S7 Edge ', 87000, 2, '27/8/2020'),
(5, 'iPhone 4s 16Go', 20000, 17, '27/8/2020');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

CREATE TABLE `utilisateurs` (
  `num_user` int(11) NOT NULL,
  `login_user` varchar(70) NOT NULL,
  `pass_user` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`num_user`, `login_user`, `pass_user`) VALUES
(1, 'Admin', '@dmin'),
(2, 'Ghost228', '0422');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`num_clt`);

--
-- Index pour la table `commandes`
--
ALTER TABLE `commandes`
  ADD PRIMARY KEY (`num_cmd`),
  ADD KEY `numero_client` (`num_clt`);

--
-- Index pour la table `details_cmd`
--
ALTER TABLE `details_cmd`
  ADD PRIMARY KEY (`num_det`),
  ADD KEY `numero_commande` (`num_cmd`),
  ADD KEY `numero_produit` (`num_prod`);

--
-- Index pour la table `histo_prod`
--
ALTER TABLE `histo_prod`
  ADD PRIMARY KEY (`num_his`);

--
-- Index pour la table `produits`
--
ALTER TABLE `produits`
  ADD PRIMARY KEY (`num_prod`);

--
-- Index pour la table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  ADD PRIMARY KEY (`num_user`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `clients`
--
ALTER TABLE `clients`
  MODIFY `num_clt` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pour la table `commandes`
--
ALTER TABLE `commandes`
  MODIFY `num_cmd` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `details_cmd`
--
ALTER TABLE `details_cmd`
  MODIFY `num_det` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pour la table `histo_prod`
--
ALTER TABLE `histo_prod`
  MODIFY `num_his` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pour la table `produits`
--
ALTER TABLE `produits`
  MODIFY `num_prod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  MODIFY `num_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
