-- phpMyAdmin SQL Dump
-- version 5.0.4deb2+deb11u1
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : mar. 18 oct. 2022 à 20:24
-- Version du serveur :  8.0.30
-- Version de PHP : 7.4.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `fulbank`
--
CREATE DATABASE IF NOT EXISTS `fulbank` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `fulbank`;

-- --------------------------------------------------------

--
-- Structure de la table `Account`
--

CREATE TABLE IF NOT EXISTS `Account` (
  `id` int NOT NULL,
  `iban` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `bic` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `sold` double NOT NULL,
  `debt` int DEFAULT NULL,
  `limitSold` int DEFAULT NULL,
  `idPerson` int DEFAULT NULL,
  `idTypeOfAccount` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `Account`
--

INSERT INTO `Account` (`id`, `iban`, `bic`, `sold`, `debt`, `limitSold`, `idPerson`, `idTypeOfAccount`) VALUES
(1, '763000300050971617519420', 'CF452R87', 2385, -100, NULL, 1, 1),
(2, '1.2345678998765432e116', 'CF254R63', 2500, -20, NULL, 2, 1),
(4, 'FR2930003000702964937674V29', ' 	CEPA450', 2385, NULL, 20000, 1, 2);

-- --------------------------------------------------------

--
-- Structure de la table `Cryptocurrency`
--

CREATE TABLE IF NOT EXISTS `Cryptocurrency` (
  `id` int NOT NULL,
  `label` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `rate` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `Operation`
--

CREATE TABLE IF NOT EXISTS `Operation` (
  `id` int NOT NULL,
  `date` datetime NOT NULL,
  `amount` float NOT NULL,
  `description` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `idDebitor` int NOT NULL,
  `idCreditor` int NOT NULL,
  `idType` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `Person`
--

CREATE TABLE IF NOT EXISTS `Person` (
  `id` int NOT NULL,
  `lastName` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `firstName` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `mail` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `phone` bigint NOT NULL,
  `adress` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `pc` int NOT NULL,
  `city` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `country` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `login` bigint NOT NULL,
  `password` text COLLATE utf8mb4_general_ci NOT NULL,
  `idTypeOfPerson` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `Person`
--

INSERT INTO `Person` (`id`, `lastName`, `firstName`, `mail`, `phone`, `adress`, `pc`, `city`, `country`, `login`, `password`, `idTypeOfPerson`) VALUES
(1, 'Martin', 'Louis', 'martin.louis@gmail.com', 670988400, '5 Rue de la Fayette', 28000, 'Chartres', 'France', 1125462937, 'e7e5c1fd137a72b971300ff1d9ec25729bc894865435b8d8925f064323ea1544', 1),
(2, 'Super', 'Admin', 'super.admin@gmail.com', 764389167, '12 Rue de la Fayette', 28000, 'Chartres', 'France', 4897875682, '186cf774c97b60a1c106ef718d10970a6a06e06bef89553d9ae65d938a886eae', 2);

-- --------------------------------------------------------

--
-- Structure de la table `Price`
--

CREATE TABLE IF NOT EXISTS `Price` (
  `id` int NOT NULL,
  `forfait` float DEFAULT NULL,
  `taux` float DEFAULT NULL,
  `annee` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `Price`
--

INSERT INTO `Price` (`id`, `forfait`, `taux`, `annee`) VALUES
(1, NULL, 7.5, 2022),
(2, 5, NULL, 2022);

-- --------------------------------------------------------

--
-- Structure de la table `Type`
--

CREATE TABLE IF NOT EXISTS `Type` (
  `id` int NOT NULL,
  `label` varchar(255) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `Type`
--

INSERT INTO `Type` (`id`, `label`) VALUES
(1, 'Virement'),
(2, 'Retrait'),
(3, 'Prélèvement');

-- --------------------------------------------------------

--
-- Structure de la table `TypeOfAccount`
--

CREATE TABLE IF NOT EXISTS `TypeOfAccount` (
  `id` int NOT NULL,
  `label` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `idPrice` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `TypeOfAccount`
--

INSERT INTO `TypeOfAccount` (`id`, `label`, `idPrice`) VALUES
(1, 'Courant', 1),
(2, 'Epargne', 2);

-- --------------------------------------------------------

--
-- Structure de la table `TypeOfPerson`
--

CREATE TABLE IF NOT EXISTS `TypeOfPerson` (
  `id` int NOT NULL,
  `label` varchar(30) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `TypeOfPerson`
--

INSERT INTO `TypeOfPerson` (`id`, `label`) VALUES
(1, 'Client'),
(2, 'Conseiller');

-- --------------------------------------------------------

--
-- Structure de la table `Wallet`
--

CREATE TABLE IF NOT EXISTS `Wallet` (
  `idCrypto` int NOT NULL,
  `idPerso` int NOT NULL,
  `sold` double NOT NULL,
  `amount` double NOT NULL,
  `date` datetime NOT NULL,
  `sellingRate` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `Account`
--
ALTER TABLE `Account`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_idPerson` (`idPerson`),
  ADD KEY `FK_idTypeOfAccount` (`idTypeOfAccount`);

--
-- Index pour la table `Cryptocurrency`
--
ALTER TABLE `Cryptocurrency`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `Operation`
--
ALTER TABLE `Operation`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_idDebtor` (`idDebitor`),
  ADD KEY `FK_idCreditor` (`idCreditor`),
  ADD KEY `idType` (`idType`);

--
-- Index pour la table `Person`
--
ALTER TABLE `Person`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_idTypeOfPerson` (`idTypeOfPerson`);

--
-- Index pour la table `Price`
--
ALTER TABLE `Price`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `Type`
--
ALTER TABLE `Type`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `TypeOfAccount`
--
ALTER TABLE `TypeOfAccount`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idPrice` (`idPrice`);

--
-- Index pour la table `TypeOfPerson`
--
ALTER TABLE `TypeOfPerson`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `Wallet`
--
ALTER TABLE `Wallet`
  ADD KEY `FK_idCrypto` (`idCrypto`),
  ADD KEY `FK_idPerso` (`idPerso`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `Account`
--
ALTER TABLE `Account`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `Cryptocurrency`
--
ALTER TABLE `Cryptocurrency`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `Operation`
--
ALTER TABLE `Operation`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `Person`
--
ALTER TABLE `Person`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `Price`
--
ALTER TABLE `Price`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `Type`
--
ALTER TABLE `Type`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `TypeOfAccount`
--
ALTER TABLE `TypeOfAccount`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `TypeOfPerson`
--
ALTER TABLE `TypeOfPerson`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `Account`
--
ALTER TABLE `Account`
  ADD CONSTRAINT `FK_idPerson` FOREIGN KEY (`idPerson`) REFERENCES `Person` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT,
  ADD CONSTRAINT `FK_idTypeOfAccount` FOREIGN KEY (`idTypeOfAccount`) REFERENCES `TypeOfAccount` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Contraintes pour la table `Operation`
--
ALTER TABLE `Operation`
  ADD CONSTRAINT `FK_idCreditor` FOREIGN KEY (`idCreditor`) REFERENCES `Account` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `FK_idDebtor` FOREIGN KEY (`idDebitor`) REFERENCES `Account` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `idType` FOREIGN KEY (`idType`) REFERENCES `Type` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Contraintes pour la table `Person`
--
ALTER TABLE `Person`
  ADD CONSTRAINT `FK_idTypeOfPerson` FOREIGN KEY (`idTypeOfPerson`) REFERENCES `TypeOfPerson` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Contraintes pour la table `TypeOfAccount`
--
ALTER TABLE `TypeOfAccount`
  ADD CONSTRAINT `idPrice` FOREIGN KEY (`idPrice`) REFERENCES `Price` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Contraintes pour la table `Wallet`
--
ALTER TABLE `Wallet`
  ADD CONSTRAINT `FK_idCrypto` FOREIGN KEY (`idCrypto`) REFERENCES `Cryptocurrency` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `FK_idPerso` FOREIGN KEY (`idPerso`) REFERENCES `Person` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
