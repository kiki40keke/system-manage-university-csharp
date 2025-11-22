-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Lun 20 Juin 2022 à 20:36
-- Version du serveur :  10.1.13-MariaDB
-- Version de PHP :  5.5.37

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gestionuniversite`
--

-- --------------------------------------------------------

--
-- Structure de la table `ancienpaiment`
--

CREATE TABLE `ancienpaiment` (
  `codepc` varchar(20) DEFAULT NULL,
  `Id_Opt` varchar(20) DEFAULT NULL,
  `fraisInscription` int(11) DEFAULT NULL,
  `fraisDentres` int(11) DEFAULT NULL,
  `fraisSession` int(11) DEFAULT NULL,
  `Dateenreg` varchar(50) DEFAULT NULL,
  `dateenregmodif` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `ancienpaiment`
--

INSERT INTO `ancienpaiment` (`codepc`, `Id_Opt`, `fraisInscription`, `fraisDentres`, `fraisSession`, `Dateenreg`, `dateenregmodif`) VALUES
('Paie-Options-4078', 'Options-4078', 250, 2520, 4500, '2022/04/19', '2022/05/26'),
('Paie-Options-4078', 'Options-4078', 250, 2520, 4500, '2022/04/19', '2022/05/26'),
('Paie-Options-4078', 'Options-4078', 250, 2580, 4500, '2022/04/19', '2022/05/26'),
('Paie-Options-7680', 'Options-7680', 300, 1000, 2000, '2022/05/26', '2022/05/26'),
('Paie-Options-4078', 'Options-4078', 44, 44, 44, '2022/04/19', '2022/05/26'),
('Paie-Options-7680', 'Options-7680', 44, 44, 44, '2022/05/26', '2022/05/26'),
('Paie-Options-7680', 'Options-7680', 500, 3000, 2000, '2022/05/26', '2022/06/01'),
('Paie-Options-7680', 'Options-7680', 500, 3000, 2000, '2022/05/26', '2022/06/01'),
('Paie-Options-7680', 'Options-7680', 500, 3000, 2000, '2022/05/26', '2022/06/01'),
('Paie-Options-7680', 'Options-7680', 505, 3000, 2000, '2022/05/26', '2022/06/01'),
('Paie-Options-7680', 'Options-7680', 505, 3000, 2050, '2022/05/26', '2022/06/01'),
('Paie-Options-2144', 'Options-2144', 700, 2000, 3000, '2022/06/05', '2022/06/05'),
('Paie-Options-5009', 'Options-5009', 1500, 2000, 300, '2022/06/06', '2022/06/06'),
('Paie-Options-5245', 'Options-5245', 800, 2000, 2500, '2022/06/10', '2022/06/10');

-- --------------------------------------------------------

--
-- Structure de la table `comptepaiment`
--

CREATE TABLE `comptepaiment` (
  `CodeCompte` varchar(30) NOT NULL,
  `Id_Opt` varchar(20) DEFAULT NULL,
  `Id_Etud` varchar(20) DEFAULT NULL,
  `fraisInscription` double DEFAULT NULL,
  `fraisDentres` double DEFAULT NULL,
  `fraisSession` double DEFAULT NULL,
  `solde` double DEFAULT NULL,
  `Dateenreg` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `comptepaiment`
--

INSERT INTO `comptepaiment` (`CodeCompte`, `Id_Opt`, `Id_Etud`, `fraisInscription`, `fraisDentres`, `fraisSession`, `solde`, `Dateenreg`) VALUES
('Compte-1025', 'Options-9828', 'Etud-6418', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-13057', 'Options-9828', 'Etud-4795', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-15502', 'Options-9828', 'Etud-8327', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-16526', 'Options-9828', 'Etud-1085', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-16698', 'Options-9828', 'Etud-2071', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-16750', 'Options-9828', 'Etud-10521', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-18524', 'Options-9593', 'Etud-10661', 250, 2500, 4500, 0, '2022/05/03'),
('Compte-20072', 'Options-9828', 'Etud-2168', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-22069', 'Options-1165', 'Etud-1286', 300, 1000, 2000, 0, '2022/06/10'),
('Compte-22154', 'Options-9828', 'Etud-10949', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-25410', 'Options-9828', 'Etud-2380', 300, 2500, 1000, 0, '2022/06/01'),
('Compte-26100', 'Options-9828', 'Etud-1156', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-2753', 'Options-9828', 'Etud-6839', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-28329', 'Options-9828', 'Etud-5638', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-28351', 'Options-9828', 'Etud-10265', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-31471', 'Options-9828', 'Etud-1024', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-34828', 'Options-9828', 'Etud-2252', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-41650', 'Options-6610', 'Etud-10215', 250, 2500, 4500, 0, '2022/05/16'),
('Compte-46456', 'Options-9828', 'Etud-9972', 300, 2500, 1000, 0, '2022/04/26'),
('Compte-52899', 'Options-9828', 'Etud-10696', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-55130', 'Options-9828', 'Etud-3700', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-5768', 'Options-9828', 'Etud-6872', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-60089', 'Options-1165', 'Etud-5509', 300, 1000, 2000, 0, '2022/05/16'),
('Compte-63101', 'Options-1165', 'Etud-4640', 300, 1000, 2000, 0, '2022/06/12'),
('Compte-66886', 'Options-9828', 'Etud-4022', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-72196', 'Options-6610', 'Etud-3334', 250, 2500, 4500, 0, '2022/05/16'),
('Compte-76502', 'Options-9828', 'Etud-4664', 300, 2500, 1000, 0, '2022/04/16'),
('Compte-82218', 'Options-9828', 'Etud-5154', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-8769', 'Options-9828', 'Etud-1195', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-89259', 'Options-6610', 'Etud-1378', 250, 2500, 4500, 0, '2022/05/16'),
('Compte-89386', 'Options-9828', 'Etud-7231', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-89389', 'Options-9828', 'Etud-6181', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-9446', 'Options-9828', 'Etud-8778', 300, 2500, 1000, 0, '2022/04/28'),
('Compte-97756', 'Options-9828', 'Etud-229', 300, 2500, 1000, 0, '2022/04/28');

-- --------------------------------------------------------

--
-- Structure de la table `cours`
--

CREATE TABLE `cours` (
  `Id_Cours` varchar(20) NOT NULL,
  `Id_Opt` varchar(20) DEFAULT NULL,
  `codeniv` int(11) DEFAULT NULL,
  `codesession` int(11) DEFAULT NULL,
  `Nom_Cours` varchar(100) DEFAULT NULL,
  `Dateenreg` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `cours`
--

INSERT INTO `cours` (`Id_Cours`, `Id_Opt`, `codeniv`, `codesession`, `Nom_Cours`, `Dateenreg`) VALUES
('Cours-0', 'Options-9828', 1, 2, 'Statisques 2', '2022/04/14'),
('Cours-109', 'Options-9828', 1, 1, 'Architectures des ordinateurs', '2022/04/14'),
('Cours-110', 'Options-1165', 4, 2, 'Xml', '2022/06/06'),
('Cours-1274', 'Options-4227', 2, 2, 'Macroéconomie II', '2022/04/26'),
('Cours-14', 'Options-9828', 1, 2, 'Programmation Fondamentale', '2022/04/14'),
('Cours-141', 'Options-5009', 2, 2, 'Transport', '2022/04/26'),
('Cours-1420', 'Options-9828', 3, 2, 'Système Information 2', '2022/04/14'),
('Cours-149', 'Options-1165', 4, 1, 'Principes du design I', '2022/04/26'),
('Cours-16', 'Options-9828', 1, 1, 'Comptabilité 1', '2022/04/14'),
('Cours-1670', 'Options-9828', 2, 2, 'Système Exploitation 2', '2022/04/14'),
('Cours-18', 'Options-9828', 1, 2, 'Programmation C', '2022/04/14'),
('Cours-1814', 'Options-1165', 3, 2, 'Sciences graphiques II', '2022/04/26'),
('Cours-193', 'Options-5245', 1, 1, 'Math', '2022/06/10'),
('Cours-1945', 'Options-4227', 4, 2, 'Méthodes quantitatives', '2022/04/26'),
('Cours-1999', 'Options-1165', 2, 1, 'Éléments des machines', '2022/04/26'),
('Cours-201', 'Options-9828', 3, 1, 'CFBD 1', '2022/04/14'),
('Cours-2063', 'Options-9828', 3, 1, 'Système Information 1', '2022/04/14'),
('Cours-2228', 'Options-9828', 3, 2, 'Recherche Opérationelle 2', '2022/04/14'),
('Cours-2271', 'Options-9593', 3, 2, 'biotechnologies', '2022/04/26'),
('Cours-23', 'Options-9828', 1, 2, 'Calcul Intégrale', '2022/04/14'),
('Cours-2303', 'Options-5009', 3, 2, 'Construction Civile', '2022/04/26'),
('Cours-2378', 'Options-9828', 2, 2, 'Principes Administration', '2022/04/14'),
('Cours-2584', 'Options-1165', 5, 1, 'Mécanique des fluides I', '2022/04/26'),
('Cours-2679', 'Options-9828', 2, 1, 'Système Exploitation 1', '2022/04/14'),
('Cours-2710', 'Options-4227', 3, 1, 'Économie internationale', '2022/04/26'),
('Cours-2730', 'Options-9828', 2, 1, 'HTML', '2022/04/14'),
('Cours-2905', 'Options-9593', 2, 1, 'sciences de la santé', '2022/04/26'),
('Cours-3086', 'Options-6610', 2, 1, 'Sociologie Du Droit', '2022/04/26'),
('Cours-3167', 'Options-5009', 1, 1, 'Mécanique des Sols', '2022/04/26'),
('Cours-3260', 'Options-9828', 2, 1, 'Ms-Excel', '2022/04/14'),
('Cours-3277', 'Options-9593', 1, 1, 'techniques de santé animale', '2022/04/26'),
('Cours-3454', 'Options-1165', 2, 2, 'Analyse structurelle', '2022/04/26'),
('Cours-3520', 'Options-9828', 3, 1, 'Recherche Opérationelle 1', '2022/04/14'),
('Cours-3635', 'Options-5009', 5, 1, 'Organisation de Chantier', '2022/04/26'),
('Cours-3662', 'Options-4227', 5, 2, 'Économétrie I', '2022/04/26'),
('Cours-3689', 'Options-9593', 1, 1, 'Biologie Medicale', '2022/05/25'),
('Cours-37', 'Options-9828', 1, 1, 'Algèbre de Boole', '2022/04/14'),
('Cours-3714', 'Options-9828', 4, 2, 'Oracle 2', '2022/06/06'),
('Cours-3739', 'Options-9828', 2, 1, 'Programmation C2', '2022/04/14'),
('Cours-3805', 'Options-1165', 4, 2, 'Oracle 2', '2022/06/06'),
('Cours-4004', 'Options-9828', 2, 2, 'PHP', '2022/04/14'),
('Cours-4009', 'Options-9828', 4, 1, 'Oracle', '2022/06/06'),
('Cours-41', 'Options-9828', 1, 1, 'Analyse Mathématique', '2022/04/14'),
('Cours-4189', 'Options-233', 1, 2, 'expériences et méthodes II', '2022/04/26'),
('Cours-4328', 'Options-9593', 2, 2, 'techniques d''hygiène dentaire', '2022/04/26'),
('Cours-4437', 'Options-4078', 5, 2, 'Principes de Gestion', '2022/04/26'),
('Cours-4541', 'Options-233', 3, 2, 'Organisations industrielles II', '2022/04/26'),
('Cours-472', 'Options-9828', 2, 1, 'Assembleur', '2022/04/14'),
('Cours-4809', 'Options-9593', 4, 2, 'techniques d''analyses biomédicales', '2022/04/26'),
('Cours-4895', 'Options-233', 2, 2, 'informatique décisionnelles II', '2022/04/26'),
('Cours-4910', 'Options-1165', 1, 2, 'Mécanique appliquée', '2022/04/26'),
('Cours-4939', 'Options-4078', 1, 1, 'Gestion de Trésorerie I', '2022/04/26'),
('Cours-4943', 'Options-4078', 5, 1, 'Microéconomie', '2022/04/26'),
('Cours-4980', 'Options-1165', 1, 1, 'procédés de fabrication', '2022/04/26'),
('Cours-50', 'Options-9828', 1, 1, 'Anglais', '2022/04/14'),
('Cours-51', 'Options-9828', 1, 1, 'Ms Windows/Dos', '2022/04/14'),
('Cours-5133', 'Options-5009', 3, 1, 'Irrigation', '2022/04/26'),
('Cours-5141', 'Options-9828', 5, 1, 'JavaScript', '2022/06/06'),
('Cours-5226', 'Options-5009', 1, 2, 'Routes', '2022/04/26'),
('Cours-5349', 'Options-9828', 2, 1, 'Concepts Objet', '2022/04/14'),
('Cours-5364', 'Options-9828', 3, 2, 'VB.NET 2', '2022/04/14'),
('Cours-5425', 'Options-4078', 2, 2, 'Inférence Statistique II', '2022/04/26'),
('Cours-5461', 'Options-9828', 2, 2, 'Programmation C++', '2022/04/14'),
('Cours-5670', 'Options-6610', 4, 2, 'Français Et Communication.', '2022/04/26'),
('Cours-5847', 'Options-233', 2, 1, 'informatique décisionnelles I', '2022/04/26'),
('Cours-5900', 'Options-233', 4, 1, 'Automatismes I', '2022/04/26'),
('Cours-5933', 'Options-5009', 5, 2, 'Probabilités', '2022/04/26'),
('Cours-6017', 'Options-6610', 1, 2, 'Droit Pénal', '2022/04/26'),
('Cours-607', 'Options-9828', 3, 2, 'MySQL 2', '2022/04/14'),
('Cours-6073', 'Options-9828', 2, 1, 'Analyse Numérique 1', '2022/04/14'),
('Cours-6241', 'Options-9828', 2, 2, 'Structure de Données', '2022/04/14'),
('Cours-6298', 'Options-9828', 2, 2, 'Infographie', '2022/04/14'),
('Cours-6351', 'Options-6610', 2, 2, 'Comptabilité', '2022/04/26'),
('Cours-636', 'Options-4078', 1, 2, 'Comptabilité de l''assurance', '2022/04/26'),
('Cours-6371', 'Options-1165', 4, 2, 'Principes du design II', '2022/04/26'),
('Cours-6398', 'Options-4078', 3, 2, 'Planification et Contrôle Budgétaire I', '2022/04/26'),
('Cours-6410', 'Options-9593', 4, 1, 'techniques d''électrophysiologie', '2022/04/26'),
('Cours-650', 'Options-4227', 4, 1, 'Économie publique', '2022/04/26'),
('Cours-6523', 'Options-9828', 3, 2, 'Réseaux 2', '2022/04/14'),
('Cours-6580', 'Options-6610', 3, 1, 'Histoire Du Droit.', '2022/04/26'),
('Cours-66', 'Options-9828', 1, 2, 'Ms-Word', '2022/04/14'),
('Cours-6702', 'Options-9828', 3, 1, 'PHP 2', '2022/04/14'),
('Cours-69', 'Options-9828', 1, 2, 'Algèbre Linéaire 2', '2022/04/14'),
('Cours-6921', 'Options-6610', 1, 1, 'Droit Civil', '2022/04/26'),
('Cours-6923', 'Options-5009', 2, 1, 'Hydrologie', '2022/04/26'),
('Cours-6944', 'Options-4227', 5, 1, 'Économie du tourisme', '2022/04/26'),
('Cours-6956', 'Options-9828', 3, 1, 'VB.NET 1', '2022/04/14'),
('Cours-6973', 'Options-233', 1, 1, 'expériences et méthodes', '2022/04/26'),
('Cours-6976', 'Options-5009', 4, 1, 'Drainage', '2022/04/26'),
('Cours-72', 'Options-9828', 1, 1, 'Statisques 1', '2022/04/14'),
('Cours-737', 'Options-9828', 2, 2, 'Ms-Access', '2022/04/14'),
('Cours-74', 'Options-9828', 1, 2, 'Dépannage 1', '2022/04/14'),
('Cours-7484', 'Options-9828', 2, 2, 'Analyse Numérique 2', '2022/04/14'),
('Cours-7559', 'Options-9828', 3, 2, 'Java 2', '2022/04/14'),
('Cours-7798', 'Options-5009', 1, 2, 'Calcul des Structures', '2022/04/26'),
('Cours-7803', 'Options-4227', 2, 1, 'Macroéconomie I', '2022/04/26'),
('Cours-7997', 'Options-6610', 5, 2, 'Procédure Commerciale', '2022/04/26'),
('Cours-80', 'Options-9828', 1, 2, 'Comptabilité 2', '2022/04/14'),
('Cours-8010', 'Options-4078', 5, 2, 'Sociologie Générale', '2022/04/26'),
('Cours-8067', 'Options-9828', 2, 1, 'Français1', '2022/04/14'),
('Cours-815', 'Options-233', 5, 2, 'Bilan personnel d''activités', '2022/04/26'),
('Cours-8193', 'Options-9828', 3, 1, 'MySQL 1', '2022/04/14'),
('Cours-8251', 'Options-4078', 4, 2, 'Vérification', '2022/04/26'),
('Cours-8310', 'Options-4078', 1, 1, 'Comptabilité Financière', '2022/04/26'),
('Cours-835', 'Options-233', 3, 1, 'Organisations industrielles I', '2022/04/26'),
('Cours-8452', 'Options-9593', 5, 1, 'techniques d''inhalothérapie', '2022/04/26'),
('Cours-8544', 'Options-9828', 2, 2, 'EAN', '2022/04/14'),
('Cours-8598', 'Options-9828', 3, 1, 'Langage Formel', '2022/04/14'),
('Cours-8629', 'Options-9828', 2, 1, 'Dépannage 2', '2022/04/14'),
('Cours-87', 'Options-9828', 2, 2, 'Français2', '2022/04/14'),
('Cours-8702', 'Options-4078', 3, 1, 'Gestion de Trésorerie II', '2022/04/26'),
('Cours-8745', 'Options-4227', 3, 2, 'droit et économie', '2022/04/26'),
('Cours-8822', 'Options-4227', 1, 1, 'Microéconomie', '2022/04/26'),
('Cours-8826', 'Options-9828', 3, 1, 'Réseaux 1', '2022/04/14'),
('Cours-8887', 'Options-233', 4, 2, 'Automatismes II', '2022/04/26'),
('Cours-8918', 'Options-6610', 5, 1, 'Sécurité Sociale', '2022/04/26'),
('Cours-8952', 'Options-4078', 2, 1, 'Inférence Statistique I', '2022/04/26'),
('Cours-9018', 'Options-6610', 4, 1, 'Economie Politique.', '2022/04/26'),
('Cours-9064', 'Options-9593', 3, 1, 'soins préhospitaliers d''urgence', '2022/04/26'),
('Cours-91', 'Options-9828', 1, 1, 'Algèbre Linéaire ', '2022/04/14'),
('Cours-9183', 'Options-1165', 3, 1, 'Sciences graphiques I', '2022/04/26'),
('Cours-9234', 'Options-9828', 3, 2, 'CFBD 2', '2022/04/14'),
('Cours-9255', 'Options-5009', 1, 1, 'Vibrations', '2022/04/26'),
('Cours-9359', 'Options-9828', 4, 1, 'Asp.Net', '2022/06/06'),
('Cours-9372', 'Options-4227', 5, 1, 'Méthodologie et histoire', '2022/04/26'),
('Cours-940', 'Options-9828', 5, 1, 'Android', '2022/06/06'),
('Cours-9537', 'Options-5009', 4, 2, 'Fondations', '2022/04/26'),
('Cours-9558', 'Options-9828', 3, 1, 'Java 1', '2022/04/14'),
('Cours-9580', 'Options-9593', 5, 2, 'techniques de radiodiagnostic', '2022/04/26'),
('Cours-9626', 'Options-4227', 1, 2, 'Microéconomie II', '2022/04/26'),
('Cours-9640', 'Options-6610', 3, 2, 'Statistique.', '2022/04/26'),
('Cours-9781', 'Options-4078', 4, 1, 'Planification et Contrôle Budgétaire II', '2022/04/26'),
('Cours-9864', 'Options-9828', 2, 1, 'Circuits Electriques', '2022/04/14'),
('Cours-9929', 'Options-9593', 1, 2, 'lettres et arts', '2022/04/26'),
('Cours-9933', 'Options-1165', 5, 2, 'Mécanique des fluides II', '2022/04/26'),
('Cours-9970', 'Options-233', 5, 1, 'Programmation linéaire', '2022/04/26'),
('Cours-9977', 'Options-5009', 2, 2, 'Dessin', '2022/04/26'),
('Cours-9978', 'Options-9828', 3, 2, 'UML', '2022/04/14');

-- --------------------------------------------------------

--
-- Structure de la table `coursselects`
--

CREATE TABLE `coursselects` (
  `codecs` varchar(10) NOT NULL,
  `Id_prof` varchar(60) DEFAULT NULL,
  `Id_Cours` varchar(20) DEFAULT NULL,
  `Vacations` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `coursselects`
--

INSERT INTO `coursselects` (`codecs`, `Id_prof`, `Id_Cours`, `Vacations`) VALUES
('Cs-1142916', 'Prof-1073008', 'Cours-3277', 'Median'),
('Cs-1934841', 'Prof-250505', 'Cours-4980', 'Median'),
('Cs-2390823', 'Prof-250505', 'Cours-109', 'Median'),
('Cs-2524971', 'Prof-250505', 'Cours-8251', 'Matin'),
('Cs-3254192', 'Prof-903333', 'Cours-149', 'Median'),
('Cs-64129', 'Prof-1073008', 'Cours-3277', 'Matin');

-- --------------------------------------------------------

--
-- Structure de la table `employe`
--

CREATE TABLE `employe` (
  `code` varchar(15) NOT NULL,
  `fonction` varchar(20) DEFAULT NULL,
  `salaire` float NOT NULL,
  `DateEmbauche` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `employe`
--

INSERT INTO `employe` (`code`, `fonction`, `salaire`, `DateEmbauche`) VALUES
('LaKe-79109', 'Coordonateur', 4800, '2022-04-27'),
('DoJh-5919', 'Secretaire', 65, '2022-04-28'),
('JoSt-93139', 'Coordonateur', 45, '2022-04-28'),
('AlSt-92398', 'Administrateur', 45, '2022-04-28'),
('JoKe-52012', 'Secretaire', 85, '2022-04-28'),
('JeVi-23654', 'Comptable', 35, '2022-04-28'),
('CeMi-95055', 'Coordonateur', 18, '2022-04-28'),
('PiMi-80859', 'Gestionaire RH', 80, '2022-05-16'),
('esmu-45561', 'Secretaire', 34, '2022-05-30'),
('eeee-6568', 'Administrateur', 33, '2022-05-30'),
('OmRe-41014', 'Coordonateur', 99, '2022-06-04'),
('NiPi-49480', 'Secretaire', 35, '2022-06-09'),
('NiCo-25423', 'Comptable', 87, '2022-06-09'),
('meMa-64993', 'Coordonateur', 56, '2022-06-09'),
('LaMo-56150', 'Coordonateur', 33, '2022-06-10');

-- --------------------------------------------------------

--
-- Structure de la table `etudiant`
--

CREATE TABLE `etudiant` (
  `Id_Etud` varchar(20) NOT NULL,
  `Nom_Etud` varchar(20) DEFAULT NULL,
  `Prenom_Etud` varchar(20) DEFAULT NULL,
  `sexe` varchar(10) DEFAULT NULL,
  `datNaiss` varchar(90) DEFAULT NULL,
  `nif` varchar(40) DEFAULT NULL,
  `adresse` varchar(70) DEFAULT NULL,
  `email` varchar(70) DEFAULT NULL,
  `phone` varchar(35) DEFAULT NULL,
  `nomResponsable` varchar(25) DEFAULT NULL,
  `numeroRefference` varchar(35) DEFAULT NULL,
  `NomVacation` varchar(30) DEFAULT NULL,
  `Id_Opt` varchar(20) DEFAULT NULL,
  `datEnregistr` varchar(50) DEFAULT NULL,
  `promotion` varchar(30) DEFAULT NULL,
  `codeniv` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `etudiant`
--

INSERT INTO `etudiant` (`Id_Etud`, `Nom_Etud`, `Prenom_Etud`, `sexe`, `datNaiss`, `nif`, `adresse`, `email`, `phone`, `nomResponsable`, `numeroRefference`, `NomVacation`, `Id_Opt`, `datEnregistr`, `promotion`, `codeniv`) VALUES
('Etud-10112', 'Francois', 'Judesse', 'Masculin', '2000/12/31', '222-222-2888', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Judesse', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-10215', 'Louis', 'Donalso', 'Masculin', '2000/12/31', '999-220-2020', 'delmas 84', 'LouisGoredson@gmail.com', '+5093883-8383', 'Laguerre', '+509 2920-2020', 'Matin', 'Options-6610', '2022/05/16', '2022', 1),
('Etud-1024', 'Mesidor', 'Jilot', 'Masculin', '2000/12/31', '555-555-6412', 'imti', 'imti@gmail.com', '+5095555-5555', 'imti', '+509 4444-4444', 'Week-End', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-10265', 'Valmond', 'Nelby', 'Masculin', '2000/12/31', '555-555-3466', 'imti', 'imti@gmail.com', '+5095555-5555', 'imti', '+509 4444-4444', 'Week-End', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-10521', 'Louis', 'Jamesley', 'Masculin', '2000/12/31', '555-555-5555', 'imti', 'imti@gmail.com', '+5095555-5555', 'imti', '+509 4444-4444', 'Week-End', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-10661', 'belnu', 'mathieu', 'Masculin', '2000/12/31', '545-555-5555', 'Infirmieres', 'Alabre@yahoo.com', '+5092333-3344', 'kiki', '+509 2222-2222', 'Matin', 'Options-9593', '2022/05/03', '2022', 1),
('Etud-10696', 'Belonne', 'My Love', 'Masculin', '2000/12/31', '222-222-8728', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Kelly', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-1085', 'Bonhomme', 'Fellanda', 'Masculin', '2000/12/31', '222-222-2222', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Kelly', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-10949', 'Rock', 'Nadie Glianta', 'Masculin', '2000/12/31', '222-222-1954', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Judesse', '+509 2222-2222', 'Soir', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-1156', 'Bijoux', 'Darren', 'Masculin', '2000/12/31', '222-222-7881', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Judesse', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-1195', 'Gilot', 'Natalie', 'Masculin', '2000/12/31', '222-222-3971', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Judesse', '+509 2222-2222', 'Soir', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-1286', 'Bella', 'Monica', 'Feminin', '1990/02/06', '888-229-2929', 'jdjdjd', 'Mina@gmai', '+5092622-7256', 'Mina', '+509 3535-5353', 'Matin', 'Options-1165', '2022/06/10', '2022', 1),
('Etud-1378', 'Jean', 'Kenley', 'Masculin', '2000/08/24', '878-882-8882', 'kafou', 'Kensley@jjj.com', '+5099999-2929', 'Bily', '+509 7677-1771', 'Matin', 'Options-6610', '2022/05/16', '2022', 1),
('Etud-2071', 'Geneus', 'Emmanuel', 'Masculin', '2000/12/31', '222-222-8888', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Judesse', '+509 2222-2222', 'Soir', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-2168', 'Nicolas', 'Cathy', 'Masculin', '2000/12/31', '222-222-2828', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Kelly', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-2252', 'Nazaire', 'Peterson', 'Masculin', '2000/12/31', '111-111-1111', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Kelly', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-229', 'Hypolite', 'Milouise', 'Masculin', '2000/12/31', '555-555-1234', 'imti', 'imti@gmail.com', '+5095555-5555', 'imti', '+509 4444-4444', 'Week-End', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-2380', 'Gejeana', 'omelusa', 'Masculin', '2000/12/31', '333-333-3333', 'delmas 83', 'gege@yahoo.fr', '+5093333-3333', 'kiki', '+509 2222-2222', 'Matin', 'Options-9828', '2022/06/01', '2022', 1),
('Etud-3334', 'Dona', 'Marco', 'Masculin', '1994/08/16', '727-882-8282', 'Kafou 55', 'Dona@yahoo.fr', '+5093999-3939', 'Mama', '+509 2882-2992', 'Matin', 'Options-6610', '2022/05/16', '2022', 1),
('Etud-3700', 'Joseph', 'Snaïder', 'Masculin', '2000/12/31', '222-222-2627', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Kelly', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-4022', 'Regis', 'Lovely', 'Masculin', '2000/12/31', '555-555-5432', 'imti', 'imti@gmail.com', '+5095555-5555', 'imti', '+509 4444-4444', 'Week-End', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-4640', 'Berline', 'Micanor', 'Masculin', '2000/01/01', '489-393-020-2', 'fffcxfdgdxsfdvx', 'Be@gmail.com', '+5093833-3838', 'Lalouche', '+509 3475-7884', 'Matin', 'Options-1165', '2022/06/12', '2022', 1),
('Etud-4664', 'amour', 'Vania', 'Masculin', '2000/12/31', '222-222-9292', 'delmas 83', '98dupuysteph@gmail.com', '+5099000-2002', 'jp', '+509 7738-3393', 'Median', 'Options-9828', '2022/04/16', '2022', 1),
('Etud-4795', 'Casimir', 'Jean Verdy', 'Masculin', '2000/12/31', '222-222-2278', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Kelly', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-5154', 'Louis', 'Marie - Ange', 'Masculin', '2000/12/31', '222-222-6166', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Judesse', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-5509', 'Pierre', 'Louis Joas Mona', 'Masculin', '2000/12/31', '838-333-9939', 'bele 35', 'Joas@yahoo.com', '+5099399-9999', 'Laguerre', '+509 3737-3373', 'Matin', 'Options-1165', '2022/05/16', '2022', 1),
('Etud-5638', 'Francois', 'J''fen Christian', 'Masculin', '2000/12/31', '222-222-2929', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Judesse', '+509 2222-2222', 'Soir', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-6181', 'Toussaint', 'Marie Deulimène', 'Masculin', '2000/12/31', '222-222-2224', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Kelly', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-6418', 'Telisma', 'Dina', 'Masculin', '2000/12/31', '222-222-2882', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Kelly', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-6839', 'Délicieux', 'Milca', 'Masculin', '2000/12/31', '222-222-2788', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Kelly', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-6872', 'Pierre Charles', 'Michelson John Kelly', 'Masculin', '2000/12/31', '555-555-5321', 'imti', 'imti@gmail.com', '+5095555-5555', 'imti', '+509 4444-4444', 'Week-End', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-7231', 'Fortune', 'Lordly', 'Masculin', '2000/12/31', '222-222-2233', 'Imti', 'Moi@gmail.com', '+5092828-2828', 'Kelly', '+509 2222-2222', 'Matin', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-8327', 'Narcisse', 'Velandina', 'Masculin', '2000/12/31', '555-555-6124', 'imti', 'imti@gmail.com', '+5095555-5555', 'imti', '+509 4444-4444', 'Week-End', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-8778', 'Borge', 'Rubens', 'Masculin', '2000/12/31', '555-555-8222', 'imti', 'imti@gmail.com', '+5095555-5555', 'imti', '+509 4444-4444', 'Week-End', 'Options-9828', '2022/04/28', '2022', 1),
('Etud-9972', 'Laguerre', 'tania', 'Masculin', '2000/12/31', '177-727-2727', 'Delmas 66 rue pelerin', 'tata@gmail.com', '+5092727-2727', 'melanie', '+509 2272-7277', 'Median', 'Options-9828', '2022/04/26', '2022', 1);

-- --------------------------------------------------------

--
-- Structure de la table `evaluationsnormal`
--

CREATE TABLE `evaluationsnormal` (
  `codeEvaluationsNormal` varchar(30) NOT NULL,
  `Codepalmares` varchar(30) DEFAULT NULL,
  `TypesNormal` varchar(10) DEFAULT NULL,
  `DescriptionsNormal` varchar(60) DEFAULT NULL,
  `CoeficientNormal` int(11) DEFAULT NULL,
  `DateEvaluationsNormal` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `evaluationsnormal`
--

INSERT INTO `evaluationsnormal` (`codeEvaluationsNormal`, `Codepalmares`, `TypesNormal`, `DescriptionsNormal`, `CoeficientNormal`, `DateEvaluationsNormal`) VALUES
('EvNor-686597', 'Palm-96152', 'Intra', 'Examen', 40, '2022/06/20'),
('EvNor-889525', 'Palm-96152', 'Final', 'Examen', 60, '2022/06/20');

-- --------------------------------------------------------

--
-- Structure de la table `evaluationsreprise`
--

CREATE TABLE `evaluationsreprise` (
  `codeEvaluationsReprise` varchar(30) NOT NULL,
  `Codepalmares` varchar(30) DEFAULT NULL,
  `SerieRepises` varchar(10) DEFAULT NULL,
  `TypeReprise` varchar(60) DEFAULT NULL,
  `CoeficientEvaluationsReprise` int(11) DEFAULT NULL,
  `DateEvaluationsReprise` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `fonction`
--

CREATE TABLE `fonction` (
  `idfonction` int(11) NOT NULL,
  `nomfonction` varchar(50) DEFAULT NULL,
  `salaire_minimum` int(11) DEFAULT NULL,
  `salaire_maximum` int(11) DEFAULT NULL,
  `dateajout` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `fonction`
--

INSERT INTO `fonction` (`idfonction`, `nomfonction`, `salaire_minimum`, `salaire_maximum`, `dateajout`) VALUES
(1, 'Administrateur', 4500, 7000, '2022-06-12'),
(2, 'Coordonnateur', 5000, 8000, '2022-06-12'),
(3, 'Comptable', 4500, 6500, '2022-06-12'),
(4, 'Secretaire', 3000, 5000, '2022-06-12'),
(5, 'Gestionnaire RH', 3050, 6000, '2022-06-12'),
(6, 'Menagere', 1500, 2500, '2022-06-12'),
(7, 'Agent de securite', 2000, 3000, '2022-06-12');

-- --------------------------------------------------------

--
-- Structure de la table `niveaux`
--

CREATE TABLE `niveaux` (
  `codeniv` int(11) NOT NULL,
  `Niveau` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `niveaux`
--

INSERT INTO `niveaux` (`codeniv`, `Niveau`) VALUES
(1, 'Niveau 1'),
(2, 'Niveau 2'),
(3, 'Niveau 3'),
(4, 'Niveau 4'),
(5, 'Niveau 5');

-- --------------------------------------------------------

--
-- Structure de la table `nivoetudiants`
--

CREATE TABLE `nivoetudiants` (
  `codenietud` varchar(10) NOT NULL,
  `Id_Etud` varchar(10) DEFAULT NULL,
  `codeniv` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `nivoetudiants`
--

INSERT INTO `nivoetudiants` (`codenietud`, `Id_Etud`, `codeniv`) VALUES
('Niv-1138', 'Etud-10696', 1),
('Niv-1699', 'Etud-1286', 1),
('Niv-1742', 'Etud-1085', 1),
('Niv-2215', 'Etud-4640', 1),
('Niv-2267', 'Etud-8327', 1),
('Niv-2924', 'Etud-9972', 1),
('Niv-3290', 'Etud-6181', 1),
('Niv-3429', 'Etud-3700', 1),
('Niv-3434', 'Etud-4664', 1),
('Niv-3603', 'Etud-6418', 1),
('Niv-3674', 'Etud-1378', 1),
('Niv-3790', 'Etud-5154', 1),
('Niv-413', 'Etud-3334', 1),
('Niv-4141', 'Etud-7231', 1),
('Niv-4825', 'Etud-229', 1),
('Niv-5129', 'Etud-1195', 1),
('Niv-5290', 'Etud-6839', 1),
('Niv-5683', 'Etud-10265', 1),
('Niv-5816', 'Etud-1156', 1),
('Niv-5880', 'Etud-5638', 1),
('Niv-5889', 'Etud-2168', 1),
('Niv-5988', 'Etud-10521', 1),
('Niv-6378', 'Etud-1024', 1),
('Niv-7629', 'Etud-10215', 1),
('Niv-7744', 'Etud-2252', 1),
('Niv-7905', 'Etud-6872', 1),
('Niv-8170', 'Etud-5509', 1),
('Niv-8268', 'Etud-10661', 1),
('Niv-845', 'Etud-4022', 1),
('Niv-8636', 'Etud-8778', 1),
('Niv-8939', 'Etud-10949', 1),
('Niv-9021', 'Etud-4795', 1),
('Niv-9244', 'Etud-2071', 1),
('Niv-966', 'Etud-2380', 1);

-- --------------------------------------------------------

--
-- Structure de la table `notesnormal`
--

CREATE TABLE `notesnormal` (
  `codenotnormal` varchar(30) NOT NULL,
  `codeEvaluationsNormal` varchar(30) DEFAULT NULL,
  `Id_Etud` varchar(20) DEFAULT NULL,
  `notenormal` double DEFAULT NULL,
  `Dateenregnormal` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `notesnormal`
--

INSERT INTO `notesnormal` (`codenotnormal`, `codeEvaluationsNormal`, `Id_Etud`, `notenormal`, `Dateenregnormal`) VALUES
('Notes-1018265', 'EvNor-889525', 'Etud-6181', 59, '2022/06/20'),
('Notes-1033861', 'EvNor-889525', 'Etud-1085', 45, '2022/06/20'),
('Notes-339171', 'EvNor-686597', 'Etud-10696', 34, '2022/06/20'),
('Notes-356260', 'EvNor-889525', 'Etud-10696', 55, '2022/06/20'),
('Notes-397023', 'EvNor-686597', 'Etud-3700', 26, '2022/06/20'),
('Notes-643906', 'EvNor-686597', 'Etud-6181', 33, '2022/06/20'),
('Notes-769803', 'EvNor-686597', 'Etud-1085', 24, '2022/06/20');

-- --------------------------------------------------------

--
-- Structure de la table `notesreprises`
--

CREATE TABLE `notesreprises` (
  `codenotreprise` varchar(30) NOT NULL,
  `codeEvaluationsReprise` varchar(30) DEFAULT NULL,
  `Id_Etud` varchar(20) DEFAULT NULL,
  `notereprise` float DEFAULT NULL,
  `Dateenregreprise` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `options`
--

CREATE TABLE `options` (
  `Id_Opt` varchar(20) NOT NULL,
  `Nom_Opt` varchar(30) DEFAULT NULL,
  `Dateenreg` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `options`
--

INSERT INTO `options` (`Id_Opt`, `Nom_Opt`, `Dateenreg`) VALUES
('Options-1165', 'Genie Mecanique', '2022/04/18'),
('Options-2144', 'Chimie Medecine', '2022/06/04'),
('Options-233', 'Genie Industrielle', '2022/04/18'),
('Options-4078', 'Sciences Comptables', '2022/04/17'),
('Options-4227', 'Sciences Economie', '2022/04/18'),
('Options-5009', 'Genie Civil', '2022/04/26'),
('Options-5245', 'Genie Electronique', '2022/06/10'),
('Options-6610', 'Sciences Judiriques', '2022/04/18'),
('Options-7680', 'Inteligence Artificielle', '2022/05/25'),
('Options-812', 'Chimie Industrielle', '2022/06/04'),
('Options-9593', 'Sciences Infirmieres', '2022/04/18'),
('Options-9828', 'Sciences Informatiques', '2022/04/14');

-- --------------------------------------------------------

--
-- Structure de la table `paiment`
--

CREATE TABLE `paiment` (
  `codepc` varchar(20) NOT NULL,
  `Id_Opt` varchar(20) DEFAULT NULL,
  `fraisInscription` int(11) DEFAULT NULL,
  `fraisDentres` int(11) DEFAULT NULL,
  `fraisSession` int(11) DEFAULT NULL,
  `Dateenreg` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `paiment`
--

INSERT INTO `paiment` (`codepc`, `Id_Opt`, `fraisInscription`, `fraisDentres`, `fraisSession`, `Dateenreg`) VALUES
('Paie-Options-1165', 'Options-1165', 300, 1000, 2000, '2022/04/18'),
('Paie-Options-2144', 'Options-2144', 700, 2000, 3000, '2022/06/05'),
('Paie-Options-233', 'Options-233', 200, 300, 4500, '2022/04/18'),
('Paie-Options-4078', 'Options-4078', 500, 3000, 2000, '2022/04/19'),
('Paie-Options-4227', 'Options-4227', 250, 2500, 4500, '2022/04/19'),
('Paie-Options-5009', 'Options-5009', 1500, 2000, 300, '2022/06/06'),
('Paie-Options-5245', 'Options-5245', 850, 2000, 2500, '2022/06/10'),
('Paie-Options-6610', 'Options-6610', 250, 2500, 4500, '2022/04/19'),
('Paie-Options-7680', 'Options-7680', 505, 3000, 2050, '2022/05/26'),
('Paie-Options-812', 'Options-812', 500, 2500, 4500, '2022/06/05'),
('Paie-Options-9593', 'Options-9593', 250, 2500, 4500, '2022/04/19'),
('Paie-Options-9828', 'Options-9828', 300, 2500, 1000, '2022/04/15');

-- --------------------------------------------------------

--
-- Structure de la table `palmares`
--

CREATE TABLE `palmares` (
  `Codepalmares` varchar(30) NOT NULL,
  `Id_Opt` varchar(20) DEFAULT NULL,
  `Id_Cours` varchar(20) DEFAULT NULL,
  `NomVacation` varchar(30) DEFAULT NULL,
  `Coeficienttotal` int(11) DEFAULT NULL,
  `Promotion` varchar(50) DEFAULT NULL,
  `Datepalmares` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `palmares`
--

INSERT INTO `palmares` (`Codepalmares`, `Id_Opt`, `Id_Cours`, `NomVacation`, `Coeficienttotal`, `Promotion`, `Datepalmares`) VALUES
('Palm-96152', 'Options-9828', 'Cours-109', 'Matin', 100, '2022', '2022/06/20');

-- --------------------------------------------------------

--
-- Structure de la table `personne`
--

CREATE TABLE `personne` (
  `code` varchar(15) NOT NULL,
  `nom` varchar(30) NOT NULL,
  `prenom` varchar(40) NOT NULL,
  `sexe` varchar(10) DEFAULT NULL,
  `nif` varchar(15) DEFAULT NULL,
  `adresse` varchar(100) DEFAULT NULL,
  `telephone` varchar(15) DEFAULT NULL,
  `email` varchar(25) DEFAULT NULL,
  `dateNaissance` varchar(50) DEFAULT NULL,
  `Statut` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `personne`
--

INSERT INTO `personne` (`code`, `nom`, `prenom`, `sexe`, `nif`, `adresse`, `telephone`, `email`, `dateNaissance`, `Statut`) VALUES
('AlSt-92398', 'Alabre', 'Steeven', 'Masculin', '637-373-8882', 'Douya 33 rue mama # 9', '(+509)2526-2782', 'Alabre@yahoo.fr', '1989/10/19', 'Celibataire '),
('CeMi-95055', 'Cear', 'Michel-Ange', 'Feminin', '828-292-9299', 'Delmas 31 rue bo siten #6', '(+509)3890-8828', 'Cear@yahoo.fr', '1993/08/29', 'Celibataire '),
('DoJh-5919', 'Dorlus', 'Jhon Peter', 'Masculin', '929-292-2929', 'carrefour peyan 33', '(+509)2772-7272', 'Jp@yahoo.fr', '1989/12/13', 'Celibataire '),
('eeee-6568', 'eeeee', 'eeeeeeeeeeee', 'Feminin', '33333', '33', '333', '33', '1997/3/34', 'Celibataire '),
('esmu-45561', 'essaie', 'muti', 'Masculin', '83883', 'xjxjjxjxj', '4566666666', 'ess@', '', 'Celibataire '),
('JeVi-23654', 'Jean', 'Viviane', 'Feminin', '346-738-3883', 'Croix des Bouquets rue Michot', '(+509)3467-2727', 'Viviane@yahoo.fr', '1992/10/29', 'En Couple'),
('JoKe-52012', 'Joseph', 'Kensy', 'Feminin', '277-282-8828', 'Croix des missions', '(+509)2622-8282', 'Kensy@yahoo.fr', '1989/10/19', 'En Couple'),
('JoSt-93139', 'Joseph', 'Stravinshi', 'Masculin', '267-282-8282', 'Delmas 33 rue casc # 9', '(+509)2346-6666', 'Vinshi@yahoo.fr', '1990/08/25', 'Celibataire '),
('LaKe-79109', 'Laguerre', 'Kellyda', 'Masculin', '282-828-8288', 'Delmas 33 rue nabussan', '(+509)3477-8889', 'lala@yahoo.fr', '1988/04/14', 'Celibataire '),
('LaMo-56150', 'Laura', 'Monick', 'Feminin', '282-828-2929', 'Delmas', '(+509)3456-6666', 'Laura@gmal', '1994/07/23', 'Celibataire '),
('meMa-64993', 'melonie', 'Mara', 'Masculin', '288-292-9929', 'Mirbalais', '(+509)2992-9929', 'Mara@hotmail.com', '1996/12/31', 'Celibataire '),
('NiCo-25423', 'Nivelas', 'Coni', 'Masculin', '292-200-0202', 'Belonie', '(+509)2222-9929', 'Coni@gmail.com', '1996/12/31', 'Celibataire '),
('NiPi-49480', 'Nicolas', 'Pierre', 'Masculin', '229-292-9922', 'delmas 33 rue ferie', '(+509)3330-9292', 'nini@gmail.com', '1993/09/15', 'Celibataire '),
('OmRe-41014', 'Omelus', 'Maya', 'Feminin', '959-944-0404', 'Belloni', '(+509)4444-4444', 'maya@gmail.com', '1995/09/21', 'En Couple'),
('PiMi-80859', 'Pierre', 'Minouche', 'Feminin', '119-919-9191', 'delmas 33 rue nabussan', '(+509)2992-9292', 'lageyueue', '2000/12/31', 'En Couple');

-- --------------------------------------------------------

--
-- Structure de la table `professeur`
--

CREATE TABLE `professeur` (
  `Id_prof` varchar(60) NOT NULL,
  `Matricule_prof` varchar(60) DEFAULT NULL,
  `Nom_prof` varchar(40) DEFAULT NULL,
  `Prenom_prof` varchar(40) DEFAULT NULL,
  `Sexe_prof` varchar(59) DEFAULT NULL,
  `Tel_prof` varchar(40) DEFAULT NULL,
  `Email_prof` varchar(80) DEFAULT NULL,
  `Adresse_prof` varchar(120) DEFAULT NULL,
  `NumrefProf` varchar(120) DEFAULT NULL,
  `DateNaissance_prof` varchar(120) DEFAULT NULL,
  `professionprof` varchar(120) DEFAULT NULL,
  `Etat_prof` varchar(120) DEFAULT NULL,
  `DateInscription_prof` varchar(70) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `professeur`
--

INSERT INTO `professeur` (`Id_prof`, `Matricule_prof`, `Nom_prof`, `Prenom_prof`, `Sexe_prof`, `Tel_prof`, `Email_prof`, `Adresse_prof`, `NumrefProf`, `DateNaissance_prof`, `professionprof`, `Etat_prof`, `DateInscription_prof`) VALUES
('Prof-1073008', '339-927-2337', 'Dorlus', 'Marcus', 'Masculin', '(+509)4789-9929', 'marcus2457@gmail.com', 'tabarre 27 rue clercine', '(+509)4789-2922', '1991/09/17', 'Avocat', 'Actif', '2022/04/26'),
('Prof-1087431', '838-838-3838', 'Bellonu', 'mica', 'Masculin', '(+509)2762-7272', 'Bellonu@gmail.com', 'Delmas 87', '(+509)7782-8272', '1995/09/11', 'Docteur', 'Actif', '2022/06/10'),
('Prof-250505', '737-374-7444', 'Renal', 'Wilky', 'Masculin', '(+509)2394-9494', 'Rene@gmail.com', 'Delmas 83 , salomon rue # 7', '(+509)3474-4488', '1991/09/10', 'Informaticien', 'Actif', '2022/04/26'),
('Prof-425474', '367-228-2292', 'Pierre', 'Mona', 'Masculin', '(+509)3578-3989', 'Pierre23@gmail.com', 'Delmas 63 , mongol rue # 9', '(+509)3829-8929', '1991/09/10', 'Gestionnaire', 'Actif', '2022/04/26'),
('Prof-768178', '788-939-3993', 'Omelus', 'Guerjean', 'Masculin', '(+509)3848-8444', 'Ome@gmail.com', 'Delmas 58', '(+509)2333-3333', '1995/01/01', 'Agronome', 'Actif', '2022/06/04'),
('Prof-836041', '222-999-9292', 'Jean-aime', 'Mytho', 'Masculin', '(+509)3546-4647', 'Jean@gmail.com', 'Carrefour # 7', '(+509)3478-3838', '1991/07/17', 'Informaticien', 'Actif', '2022/04/26'),
('Prof-903333', '738-383-9933', 'Donacien', 'Bill', 'Masculin', '(+509)4567-9099', 'Dona34@gmail.com', 'petion ville Jalousie', '(+509)3628-1199', '1991/09/25', 'Gestionnaire', 'Actif', '2022/04/26');

-- --------------------------------------------------------

--
-- Structure de la table `sessionx`
--

CREATE TABLE `sessionx` (
  `codesession` int(11) NOT NULL,
  `NomSession` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `sessionx`
--

INSERT INTO `sessionx` (`codesession`, `NomSession`) VALUES
(1, 'Session 1'),
(2, 'Session 2');

-- --------------------------------------------------------

--
-- Structure de la table `tantative`
--

CREATE TABLE `tantative` (
  `ID` int(10) NOT NULL,
  `NomUser` varchar(20) NOT NULL,
  `DatEnregistr` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `tantative`
--

INSERT INTO `tantative` (`ID`, `NomUser`, `DatEnregistr`) VALUES
(1, 'Cear', '2022-06-10 18:25:08'),
(2, 'Cear', '2022-06-10 18:25:17'),
(3, 'Cear', '2022-06-10 18:25:22');

-- --------------------------------------------------------

--
-- Structure de la table `transacrionsetudiants`
--

CREATE TABLE `transacrionsetudiants` (
  `codedepot` varchar(30) NOT NULL,
  `CodeCompte` varchar(30) DEFAULT NULL,
  `montant` double DEFAULT NULL,
  `Dateenreg` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `transacrionsetudiants`
--

INSERT INTO `transacrionsetudiants` (`codedepot`, `CodeCompte`, `montant`, `Dateenreg`) VALUES
('Tr-2165', 'Compte-76502', 2000, '2022/06/06'),
('Tr-2745', 'Compte-22069', 300, '2022/06/10'),
('Tr-2918', 'Compte-76502', 1800, '2022/06/06'),
('Tr-487', 'Compte-76502', 7000, '2022/06/13'),
('Tr-4930', 'Compte-60089', 3300, '2022/06/10'),
('Tr-6281', 'Compte-22069', 3000, '2022/06/10'),
('Tr-6827', 'Compte-76502', 3800, '2022/06/13'),
('Tr-75', 'Compte-76502', 7000, '2022/06/13'),
('Tr-8345', 'Compte-46456', 3800, '2022/06/07'),
('Tr-9566', 'Compte-46456', 3800, '2022/06/07'),
('Tr-9769', 'Compte-76502', 7000, '2022/06/13');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `code` varchar(15) NOT NULL,
  `nomUtilisateur` varchar(50) NOT NULL,
  `MotPasse` varchar(20) NOT NULL,
  `etat` smallint(3) NOT NULL,
  `Dateenreg` varchar(65) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `utilisateur`
--

INSERT INTO `utilisateur` (`code`, `nomUtilisateur`, `MotPasse`, `etat`, `Dateenreg`) VALUES
('AlSt-92398', 'Alabre', '1234', 1, '2022/04/28'),
('CeMi-95055', 'Cear', 'Cear1234', 0, '2022/04/28'),
('DoJh-5919', 'Jp', 'Jp1234', 1, '2022/04/28'),
('JoKe-52012', 'Kensy', 'Kensy1234', 1, '2022/04/28'),
('LaKe-79109', 'kiki', 'kiki40', 1, '2022/04/28'),
('LaMo-56150', 'Laura', 'Lala', 1, '2022/06/10'),
('eeee-6568', 'lolo', 'lela', 1, '2022/05/31'),
('OmRe-41014', 'maya2', 'maya1234', 1, '2022/06/05'),
('JeVi-23654', 'Printemps', '1234', 1, '2022/04/28'),
('PiMi-80859', 'Stephane', 'Steph2020', 1, '2022/06/10'),
('JoSt-93139', 'Vinshi', 'Vinshi1234', 1, '2022/04/28');

-- --------------------------------------------------------

--
-- Structure de la table `vacations`
--

CREATE TABLE `vacations` (
  `codevacation` int(11) NOT NULL,
  `NomVacation` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `vacations`
--

INSERT INTO `vacations` (`codevacation`, `NomVacation`) VALUES
(1, 'Matin'),
(2, 'Median'),
(3, 'Soir'),
(4, 'Week-End');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `ancienpaiment`
--
ALTER TABLE `ancienpaiment`
  ADD KEY `AncienPaiment` (`codepc`);

--
-- Index pour la table `comptepaiment`
--
ALTER TABLE `comptepaiment`
  ADD PRIMARY KEY (`CodeCompte`),
  ADD KEY `ComptePaiment` (`Id_Opt`),
  ADD KEY `compteetu` (`Id_Etud`);

--
-- Index pour la table `cours`
--
ALTER TABLE `cours`
  ADD PRIMARY KEY (`Id_Cours`),
  ADD KEY `opt_fk_f` (`Id_Opt`),
  ADD KEY `niv_fk_f` (`codeniv`),
  ADD KEY `ses_fk_f` (`codesession`);

--
-- Index pour la table `coursselects`
--
ALTER TABLE `coursselects`
  ADD PRIMARY KEY (`codecs`),
  ADD KEY `courcs_fk_f` (`Id_prof`),
  ADD KEY `courcs_fk_cs` (`Id_Cours`);

--
-- Index pour la table `employe`
--
ALTER TABLE `employe`
  ADD KEY `FK_code` (`code`);

--
-- Index pour la table `etudiant`
--
ALTER TABLE `etudiant`
  ADD PRIMARY KEY (`Id_Etud`),
  ADD KEY `etumopt_fk` (`Id_Opt`),
  ADD KEY `nivetud` (`codeniv`);

--
-- Index pour la table `evaluationsnormal`
--
ALTER TABLE `evaluationsnormal`
  ADD PRIMARY KEY (`codeEvaluationsNormal`),
  ADD KEY `evalpalm_fk` (`Codepalmares`);

--
-- Index pour la table `evaluationsreprise`
--
ALTER TABLE `evaluationsreprise`
  ADD PRIMARY KEY (`codeEvaluationsReprise`),
  ADD KEY `evalrpalm_fk` (`Codepalmares`);

--
-- Index pour la table `fonction`
--
ALTER TABLE `fonction`
  ADD PRIMARY KEY (`idfonction`);

--
-- Index pour la table `niveaux`
--
ALTER TABLE `niveaux`
  ADD PRIMARY KEY (`codeniv`);

--
-- Index pour la table `nivoetudiants`
--
ALTER TABLE `nivoetudiants`
  ADD PRIMARY KEY (`codenietud`),
  ADD KEY `nivcous` (`codeniv`),
  ADD KEY `nivetu` (`Id_Etud`);

--
-- Index pour la table `notesnormal`
--
ALTER TABLE `notesnormal`
  ADD PRIMARY KEY (`codenotnormal`),
  ADD KEY `notesevaln_fk` (`codeEvaluationsNormal`),
  ADD KEY `noteetu_fk` (`Id_Etud`);

--
-- Index pour la table `notesreprises`
--
ALTER TABLE `notesreprises`
  ADD PRIMARY KEY (`codenotreprise`),
  ADD KEY `notesevalre_fk` (`codeEvaluationsReprise`),
  ADD KEY `noteretu_fk` (`Id_Etud`);

--
-- Index pour la table `options`
--
ALTER TABLE `options`
  ADD PRIMARY KEY (`Id_Opt`);

--
-- Index pour la table `paiment`
--
ALTER TABLE `paiment`
  ADD PRIMARY KEY (`codepc`),
  ADD KEY `paiement` (`Id_Opt`);

--
-- Index pour la table `palmares`
--
ALTER TABLE `palmares`
  ADD PRIMARY KEY (`Codepalmares`),
  ADD KEY `palmopt_fk` (`Id_Opt`),
  ADD KEY `palmcours_fk` (`Id_Cours`);

--
-- Index pour la table `personne`
--
ALTER TABLE `personne`
  ADD PRIMARY KEY (`code`);

--
-- Index pour la table `professeur`
--
ALTER TABLE `professeur`
  ADD PRIMARY KEY (`Id_prof`);

--
-- Index pour la table `sessionx`
--
ALTER TABLE `sessionx`
  ADD PRIMARY KEY (`codesession`);

--
-- Index pour la table `tantative`
--
ALTER TABLE `tantative`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `transacrionsetudiants`
--
ALTER TABLE `transacrionsetudiants`
  ADD PRIMARY KEY (`codedepot`),
  ADD KEY `Transetu` (`CodeCompte`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`nomUtilisateur`),
  ADD KEY `FK_coode` (`code`);

--
-- Index pour la table `vacations`
--
ALTER TABLE `vacations`
  ADD PRIMARY KEY (`codevacation`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `tantative`
--
ALTER TABLE `tantative`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `ancienpaiment`
--
ALTER TABLE `ancienpaiment`
  ADD CONSTRAINT `AncienPaiment` FOREIGN KEY (`codepc`) REFERENCES `paiment` (`codepc`);

--
-- Contraintes pour la table `comptepaiment`
--
ALTER TABLE `comptepaiment`
  ADD CONSTRAINT `ComptePaiment` FOREIGN KEY (`Id_Opt`) REFERENCES `options` (`Id_Opt`),
  ADD CONSTRAINT `compteetu` FOREIGN KEY (`Id_Etud`) REFERENCES `etudiant` (`Id_Etud`);

--
-- Contraintes pour la table `cours`
--
ALTER TABLE `cours`
  ADD CONSTRAINT `niv_fk_f` FOREIGN KEY (`codeniv`) REFERENCES `niveaux` (`codeniv`),
  ADD CONSTRAINT `opt_fk_f` FOREIGN KEY (`Id_Opt`) REFERENCES `options` (`Id_Opt`),
  ADD CONSTRAINT `ses_fk_f` FOREIGN KEY (`codesession`) REFERENCES `sessionx` (`codesession`);

--
-- Contraintes pour la table `coursselects`
--
ALTER TABLE `coursselects`
  ADD CONSTRAINT `courcs_fk_cs` FOREIGN KEY (`Id_Cours`) REFERENCES `cours` (`Id_Cours`),
  ADD CONSTRAINT `courcs_fk_f` FOREIGN KEY (`Id_prof`) REFERENCES `professeur` (`Id_prof`);

--
-- Contraintes pour la table `employe`
--
ALTER TABLE `employe`
  ADD CONSTRAINT `FK_code` FOREIGN KEY (`code`) REFERENCES `personne` (`code`);

--
-- Contraintes pour la table `etudiant`
--
ALTER TABLE `etudiant`
  ADD CONSTRAINT `etumopt_fk` FOREIGN KEY (`Id_Opt`) REFERENCES `options` (`Id_Opt`),
  ADD CONSTRAINT `nivetud` FOREIGN KEY (`codeniv`) REFERENCES `niveaux` (`codeniv`);

--
-- Contraintes pour la table `evaluationsnormal`
--
ALTER TABLE `evaluationsnormal`
  ADD CONSTRAINT `evalpalm_fk` FOREIGN KEY (`Codepalmares`) REFERENCES `palmares` (`Codepalmares`);

--
-- Contraintes pour la table `evaluationsreprise`
--
ALTER TABLE `evaluationsreprise`
  ADD CONSTRAINT `evalrpalm_fk` FOREIGN KEY (`Codepalmares`) REFERENCES `palmares` (`Codepalmares`);

--
-- Contraintes pour la table `nivoetudiants`
--
ALTER TABLE `nivoetudiants`
  ADD CONSTRAINT `nivcous` FOREIGN KEY (`codeniv`) REFERENCES `niveaux` (`codeniv`),
  ADD CONSTRAINT `nivetu` FOREIGN KEY (`Id_Etud`) REFERENCES `etudiant` (`Id_Etud`);

--
-- Contraintes pour la table `notesnormal`
--
ALTER TABLE `notesnormal`
  ADD CONSTRAINT `noteetu_fk` FOREIGN KEY (`Id_Etud`) REFERENCES `etudiant` (`Id_Etud`),
  ADD CONSTRAINT `notesevaln_fk` FOREIGN KEY (`codeEvaluationsNormal`) REFERENCES `evaluationsnormal` (`codeEvaluationsNormal`);

--
-- Contraintes pour la table `notesreprises`
--
ALTER TABLE `notesreprises`
  ADD CONSTRAINT `noteretu_fk` FOREIGN KEY (`Id_Etud`) REFERENCES `etudiant` (`Id_Etud`),
  ADD CONSTRAINT `notesevalre_fk` FOREIGN KEY (`codeEvaluationsReprise`) REFERENCES `evaluationsreprise` (`codeEvaluationsReprise`);

--
-- Contraintes pour la table `paiment`
--
ALTER TABLE `paiment`
  ADD CONSTRAINT `paiement` FOREIGN KEY (`Id_Opt`) REFERENCES `options` (`Id_Opt`);

--
-- Contraintes pour la table `palmares`
--
ALTER TABLE `palmares`
  ADD CONSTRAINT `palmcours_fk` FOREIGN KEY (`Id_Cours`) REFERENCES `cours` (`Id_Cours`),
  ADD CONSTRAINT `palmopt_fk` FOREIGN KEY (`Id_Opt`) REFERENCES `options` (`Id_Opt`);

--
-- Contraintes pour la table `transacrionsetudiants`
--
ALTER TABLE `transacrionsetudiants`
  ADD CONSTRAINT `Transetu` FOREIGN KEY (`CodeCompte`) REFERENCES `comptepaiment` (`CodeCompte`);

--
-- Contraintes pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `FK_coode` FOREIGN KEY (`code`) REFERENCES `personne` (`code`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
