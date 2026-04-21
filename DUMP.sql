-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : db:3306
-- Généré le : mer. 10 déc. 2025 à 15:08
-- Version du serveur : 8.1.0
-- Version de PHP : 8.3.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bts-gsb`
--

-- --------------------------------------------------------

--
-- Structure de la table `Appartient`
--

CREATE TABLE `Appartient` (
  `id_prescription` int NOT NULL,
  `id_medicine` int NOT NULL,
  `quantity` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `Appartient`
--

INSERT INTO `Appartient` (`id_prescription`, `id_medicine`, `quantity`) VALUES
(1, 1, 3),
(1, 2, 2),
(2, 3, 4),
(3, 5, 3),
(5, 1, 3),
(5, 3, 2),
(6, 2, 4),
(7, 3, 4),
(8, 2, 3),
(8, 5, 5),
(9, 2, 4),
(10, 3, 54),
(10, 5, 4);

-- --------------------------------------------------------

--
-- Structure de la table `Medicine`
--

CREATE TABLE `Medicine` (
  `id_medicine` int NOT NULL,
  `id_user` int NOT NULL,
  `name` varchar(150) NOT NULL,
  `molecule` varchar(150) DEFAULT NULL,
  `dosage` varchar(100) DEFAULT NULL,
  `description` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `Medicine`
--

INSERT INTO `Medicine` (`id_medicine`, `id_user`, `name`, `molecule`, `dosage`, `description`) VALUES
(1, 9, 'Paracetamol', 'Paracetamolum', '500 mg', 'Antidouleur et antipyrétique'),
(2, 1, 'Doliprane', 'Paracetamolum', '20 mg', 'Soulage la fièvre et la douleur'),
(3, 1, 'Ibuprofen', 'Ibuprofenum', '10 mg', 'Anti-inflammatoire non stéroïdien'),
(4, 5, 'Amoxicilline', 'Amoxicillin', '50 mg', 'Antibiotique à large spectre'),
(5, 1, 'Xanax', 'Alprazolam', '5 mg', 'Anxiolytique (benzodiazépine)');

-- --------------------------------------------------------

--
-- Structure de la table `Patient`
--

CREATE TABLE `Patient` (
  `id_patient` int NOT NULL,
  `id_user` int NOT NULL,
  `name` varchar(100) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `age` int DEFAULT NULL,
  `gender` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `Patient`
--

INSERT INTO `Patient` (`id_patient`, `id_user`, `name`, `firstname`, `age`, `gender`) VALUES
(1, 3, 'Lefevre', 'Claire', 29, 0),
(2, 4, 'Bernard', 'David', 45, 1),
(5, 1, 'Almeida', 'Joao', 19, 1),
(6, 1, 'Dupont', 'Massin', 19, 1);

-- --------------------------------------------------------

--
-- Structure de la table `Prescription`
--

CREATE TABLE `Prescription` (
  `id_prescription` int NOT NULL,
  `id_patient` int NOT NULL,
  `id_user` int NOT NULL,
  `validity` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `Prescription`
--

INSERT INTO `Prescription` (`id_prescription`, `id_patient`, `id_user`, `validity`) VALUES
(1, 1, 1, '2025-12-31'),
(2, 2, 2, '2025-11-30'),
(3, 1, 5, '2026-01-15'),
(5, 5, 1, '2025-12-26'),
(6, 6, 1, '2025-12-26'),
(7, 1, 1, '2025-12-26'),
(8, 5, 1, '2025-12-26'),
(9, 1, 1, '2026-01-02'),
(10, 6, 9, '2026-01-02');

-- --------------------------------------------------------

--
-- Structure de la table `User`
--

CREATE TABLE `User` (
  `id_user` int NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `role` tinyint(1) NOT NULL,
  `email` varchar(150) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `User`
--

INSERT INTO `User` (`id_user`, `firstname`, `name`, `role`, `email`, `password`) VALUES
(1, 'Alice', 'Martine', 0, 'alice.martin@example.com', '9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08'),
(2, 'Bob', 'Durand', 0, 'bob.durand@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
(3, 'Claire', 'Lefevre', 1, 'claire.lefevre@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
(4, 'David', 'Bernard', 1, 'david.bernard@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
(5, 'Emma', 'Petit', 0, 'emma.petit@example.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
(9, 'doctor', 'doctor', 0, 'doctor', '72f4be89d6ebab1496e21e38bcd7c8ca0a68928af3081ad7dff87e772eb350c2'),
(10, 'admin', 'admin', 1, 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `Appartient`
--
ALTER TABLE `Appartient`
  ADD PRIMARY KEY (`id_prescription`,`id_medicine`),
  ADD KEY `id_medicine` (`id_medicine`);

--
-- Index pour la table `Medicine`
--
ALTER TABLE `Medicine`
  ADD PRIMARY KEY (`id_medicine`),
  ADD KEY `id_user` (`id_user`);

--
-- Index pour la table `Patient`
--
ALTER TABLE `Patient`
  ADD PRIMARY KEY (`id_patient`),
  ADD KEY `id_user` (`id_user`);

--
-- Index pour la table `Prescription`
--
ALTER TABLE `Prescription`
  ADD PRIMARY KEY (`id_prescription`),
  ADD KEY `id_patient` (`id_patient`),
  ADD KEY `id_user` (`id_user`);

--
-- Index pour la table `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `Medicine`
--
ALTER TABLE `Medicine`
  MODIFY `id_medicine` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT pour la table `Patient`
--
ALTER TABLE `Patient`
  MODIFY `id_patient` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `Prescription`
--
ALTER TABLE `Prescription`
  MODIFY `id_prescription` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `User`
--
ALTER TABLE `User`
  MODIFY `id_user` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `Appartient`
--
ALTER TABLE `Appartient`
  ADD CONSTRAINT `Appartient_ibfk_1` FOREIGN KEY (`id_prescription`) REFERENCES `Prescription` (`id_prescription`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Appartient_ibfk_2` FOREIGN KEY (`id_medicine`) REFERENCES `Medicine` (`id_medicine`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `Medicine`
--
ALTER TABLE `Medicine`
  ADD CONSTRAINT `Medicine_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `User` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `Patient`
--
ALTER TABLE `Patient`
  ADD CONSTRAINT `Patient_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `User` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `Prescription`
--
ALTER TABLE `Prescription`
  ADD CONSTRAINT `Prescription_ibfk_1` FOREIGN KEY (`id_patient`) REFERENCES `Patient` (`id_patient`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Prescription_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `User` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
