# Système de Gestion des Ordonnances Médicales GSB

<div align="center">

<p align="center">
<img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" style="display: inline-block; margin: 0 2px;"/>
<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" style="display: inline-block; margin: 0 2px;"/>
<img src="https://img.shields.io/badge/MySQL-8.1-4479A1?style=for-the-badge&logo=mysql&logoColor=white" alt="MySQL" style="display: inline-block; margin: 0 2px;"/>
<img src="https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms" style="display: inline-block; margin: 0 2px;"/>
<img src="https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white" alt="Docker" style="display: inline-block; margin: 0 2px;"/>
<img src="https://img.shields.io/badge/Licence-MIT-green?style=for-the-badge" alt="Licence" style="display: inline-block; margin: 0 2px;"/>
</p>

**Une application complète de gestion des ordonnances médicales développée pour l'épreuve finale du BTS SIO SLAM**

[Fonctionnalités](#fonctionnalités) • [Installation](#installation) • [Guide Utilisateur](./GUIDE.fr.md) • [Architecture](#architecture) • [Base de données](./DATABASE.fr.md)

[English version](./README.md)

</div>

---

## Table des matières

- [À propos](#à-propos-du-projet)
- [Fonctionnalités](#fonctionnalités)
- [Stack technique](#stack-technique)
- [Installation](#installation)
- [Guide Utilisateur Complet](./GUIDE.fr.md) [ Emplacement : [./GUIDE.fr.md](./GUIDE.fr.md) ]
  - [Système d'authentification]()
  - [Interface Médecin]()
  - [Interface Administrateur]()
- [Architecture](#architecture)
- [Base de données](./DATABASE.fr.md) [ Emplacement : [./DATABASE.fr.md](./DATABASE.fr.md) ]
- [Dump](./DUMP.sql) [ Emplacement : [./DUMP.sql](./DUMP.sql) ]
- [Sécurité](#sécurité)
- [Crédits](#crédits)

---

## À propos du projet

Le **Système de Gestion des Ordonnances Médicales GSB** est une application Windows Forms développée dans le cadre du cursus BTS SIO SLAM. Ce logiciel permet aux établissements de santé de gérer les patients, les médicaments, les ordonnances et les utilisateurs via une interface bureau intuitive.

### Objectifs principaux

- **Contrôle d'accès basé sur les rôles** : Interfaces séparées pour les Médecins et les Administrateurs
- **Opérations CRUD complètes** : Fonctionnalités complètes de Création, Lecture, Mise à jour et Suppression pour toutes les entités
- **Export PDF** : Génération de documents d'ordonnances médicales professionnels
- **Intégrité des données** : Base de données MySQL avec opérations en cascade et intégrité référentielle
- **Sécurité** : Hachage des mots de passe en SHA-256 et prévention des injections SQL

---

## Fonctionnalités

### Pour les Médecins

- **Gestion des patients** : Créer, consulter et supprimer les dossiers patients
- **Catalogue de médicaments** : Maintenir une base de données complète de médicaments avec molécules, dosages et descriptions
- **Création d'ordonnances** : Construire des ordonnances multi-médicaments avec quantités
- **Export PDF** : Générer des documents d'ordonnances professionnels
- **Édition en ligne** : Mises à jour rapides des informations sur les médicaments directement dans la grille
- **Réinitialisation du mot de passe en libre-service** : Modifier son mot de passe en toute sécurité

### Pour les Administrateurs

- **Gestion des utilisateurs** : Créer, mettre à jour et supprimer des comptes utilisateurs (médecins et administrateurs)
- **Attribution des rôles** : Octroyer des privilèges d'administrateur ou de médecin
- **Gestion des mots de passe** : Réinitialiser les mots de passe de n'importe quel utilisateur
- **Édition utilisateur en ligne** : Édition directe dans la grille avec mises à jour en temps réel de la base de données
- **Supervision du système** : Contrôle complet de tous les utilisateurs du système

---

## Stack technique

### Frontend
- **Windows Forms (.NET 8.0)** : Framework UI bureau moderne
- **C#** : Langage de programmation principal

### Backend
- **ADO.NET** : Accès direct à la base de données avec MySql.Data
- **Architecture 3 couches** : Modèles, DAO (Data Access Objects), Formulaires

### Base de données
- **MySQL 8.1** : Base de données relationnelle conforme ACID
- **Docker** : Déploiement de la base de données en conteneur
- **phpMyAdmin** : Administration de base de données via interface web

### Bibliothèques & Paquets
- **iText7** (v9.4.0) : Génération de PDF professionnelle
- **MySql.Data** (v9.5.0) : Connecteur MySQL pour .NET
- **iText7.bouncy-castle-adapter** (v9.4.0) : Support cryptographique pour les PDF

---

## Installation

### Prérequis

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) ou Runtime (Windows)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (pour la base de données MySQL)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou plus récent (recommandé)
- Git (pour cloner le dépôt)

### Étape 1 : Cloner le dépôt

```bash
git clone https://github.com/jalmeida17/bts-gsb-winform
cd bts-gsb-winform
```

### Étape 2 : Démarrer la base de données

```bash
docker-compose up -d
```

Cela démarrera :
- **Serveur MySQL** sur le port `3307`
- **phpMyAdmin** sur le port `8080` ([http://localhost:8080](http://localhost:8080))

### Étape 3 : Créer la base de données

1. Accéder à phpMyAdmin sur [http://localhost:8080](http://localhost:8080)
2. Se connecter avec :
   - **Serveur** : `db`
   - **Nom d'utilisateur** : `root`
   - **Mot de passe** : `rootpassword`
3. Créer une nouvelle base de données nommée `bts-gsb`
4. Exécuter le schéma SQL depuis [DATABASE.fr.md](DATABASE.fr.md)
5. Exécuter le DUMP dans [DUMP.sql](DUMP.sql)

### Étape 4 : Créer le premier utilisateur Administrateur (NON NÉCESSAIRE, LES COMPTES EXISTENT DÉJÀ — VOIR LES IDENTIFIANTS DE CONNEXION PAR DÉFAUT CI-DESSOUS)

Exécuter cette requête SQL pour créer votre premier compte administrateur :

```sql
INSERT INTO User (firstname, name, role, email, password)
VALUES ('Admin', 'User', 1, 'admin@gsb.fr', SHA2('admin123', 256));
```

### Étape 5 : Compiler et exécuter l'application

**Avec Visual Studio :**
1. Ouvrir `bts-gsb.sln`
2. Appuyer sur `F5` ou cliquer sur "Démarrer"

**En ligne de commande :**
```bash
dotnet build bts-gsb.sln
dotnet run --project bts-gsb.csproj
```

### Identifiants de connexion par défaut

- **Email Médecin** : `doctor`
- **Mot de passe Médecin** : `doctor`

- **Email Admin** : `admin`
- **Mot de passe Admin** : `admin`

---


## Architecture

### Diagramme d'architecture du système

```
┌───────────────────────────────────────────────────────────────┐
│                       COUCHE DE PRÉSENTATION                  │
│                        (UI Windows Forms)                     │
├───────────────────────────────────────────────────────────────┤
│  ┌─────────────┐  ┌─────────────┐  ┌──────────────────────┐   │
│  │  MainForm   │  │  AdminForm  │  │    DoctorForm        │   │
│  │ (Connexion) │  │(Utilisateurs│  │ (Patients/Méds/Ord.) │   │
│  └─────────────┘  └─────────────┘  └──────────────────────┘   │
│  ┌──────────────────┐  ┌──────────────────┐  ┌──────────────┐ │
│  │ PasswordForm     │  │ UserCreatorForm  │  │ PatientForm  │ │
│  └──────────────────┘  └──────────────────┘  └──────────────┘ │
│  ┌──────────────────┐  ┌────────────────────────────────────┐ │
│  │ MedicineForm     │  │   PrescriptionForm                 │ │
│  └──────────────────┘  └────────────────────────────────────┘ │
└────────────────────────────┬──────────────────────────────────┘
                             │ Utilise
                             ▼
┌───────────────────────────────────────────────────────────────┐
│                    COUCHE LOGIQUE MÉTIER                      │
│                   (Data Access Objects)                       │
├───────────────────────────────────────────────────────────────┤
│  ┌──────────┐  ┌───────────┐  ┌──────────────┐  ┌───────────┐ │
│  │ UserDAO  │  │PatientDAO │  │ MedicineDAO  │  │ PrescriptionDAO│
│  └──────────┘  └───────────┘  └──────────────┘  └───────────┘ │
│  ┌──────────────┐  ┌──────────────────────────────────────┐   │
│  │ AppartientDAO│  │        Database.cs                   │   │
│  └──────────────┘  └──────────────────────────────────────┘   │
└────────────────────────────┬──────────────────────────────────┘
                             │ Mappe vers
                             ▼
┌───────────────────────────────────────────────────────────────┐
│                  COUCHE MODÈLE DE DONNÉES                     │
│                    (Classes d'entités)                        │
├───────────────────────────────────────────────────────────────┤
│  ┌────────┐  ┌─────────┐  ┌──────────┐  ┌──────────────┐      │
│  │  User  │  │ Patient │  │ Medicine │  │ Prescription │      │
│  └────────┘  └─────────┘  └──────────┘  └──────────────┘      │
│  ┌─────────────┐                                              │
│  │ Appartient  │  (Modèle de jointure)                        │
│  └─────────────┘                                              │
└────────────────────────────┬──────────────────────────────────┘
                             │ Persisté dans
                             ▼
┌─────────────────────────────────────────────────────────────────┐
│                       COUCHE DE DONNÉES                         │
│                    (Base de données MySQL)                      │
├─────────────────────────────────────────────────────────────────┤
│  Base : bts-gsb (MySQL 8.1)                                     │
│  Connexion : MySql.Data via ADO.NET                             │
│  Port : 3307 (conteneur Docker)                                 │
│  ┌──────────────────────────────────────────────────────────┐   │
│  │ Tables : User, Patient, Medicine, Prescription, Appartient│  │
│  │ Contraintes : Clés étrangères, Cascade Delete, Email Unique│ │
│  └──────────────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────────────┘
```

### Patterns architecturaux

**1. Architecture en trois couches**
- **Couche de présentation** : Windows Forms (logique UI, gestion des événements, validation)
- **Couche logique métier** : Classes DAO (opérations CRUD, requêtes SQL)
- **Couche de données** : Base de données MySQL (persistance des données, contraintes)

**2. Pattern Data Access Object (DAO)**
- Abstrait les opérations de base de données derrière des interfaces propres
- Chaque entité dispose d'une classe DAO dédiée
- Encapsule les requêtes SQL et la gestion des connexions

**3. Pattern Modèle-Vue**
- Les modèles représentent les entités de la base de données avec des propriétés de navigation
- Les formulaires (Vues) affichent et manipulent les modèles
- Pas de couche Contrôleur explicite (logique dans les Formulaires)

### Exemple de flux de données : Création d'une ordonnance

```
1. Action utilisateur
   └─> Le médecin sélectionne un patient, clique sur le bouton "+ Nouvelle ordonnance"

2. Affichage du formulaire
   └─> PrescriptionForm s'ouvre avec le contexte du patient

3. Sélection des médicaments
   └─> Le médecin sélectionne les médicaments et les quantités
   └─> Les objets MedicineSelection sont stockés dans une liste locale

4. Soumission du formulaire
   └─> Clic sur le bouton "Créer l'ordonnance"

5. Création de l'ordonnance (Couche DAO)
   └─> PrescriptionDAO.Create(prescription, userId)
       └─> SQL : INSERT INTO Prescription (id_patient, id_user, validity) VALUES (...)
       └─> Retourne : nouvel ID d'ordonnance (LAST_INSERT_ID)

6. Association des médicaments (Couche DAO)
   └─> Pour chaque médicament sélectionné :
       └─> AppartientDAO.AddMedicineToPrescription(prescriptionId, medicineId, quantity)
           └─> SQL : INSERT INTO Appartient (id_prescription, id_medicine, quantity) VALUES (...)

7. Persistance en base de données
   └─> MySQL stocke les enregistrements avec intégrité référentielle

8. Mise à jour de l'UI
   └─> Le formulaire se ferme avec DialogResult.OK
   └─> DoctorForm rafraîchit la grille des ordonnances
   └─> La nouvelle ordonnance est visible dans la grille
```

### Couches de la stack technologique

```
┌─────────────────────────────────────────┐
│         Couche Application              │
│  .NET 8.0 Windows Forms (C#)            │
└─────────────────────────────────────────┘
                   ↕
┌─────────────────────────────────────────┐
│       Couche d'accès aux données        │
│  ADO.NET (MySql.Data 9.5.0)             │
│  Requêtes paramétrées                   │
└─────────────────────────────────────────┘
                   ↕
┌─────────────────────────────────────────┐
│       Couche base de données            │
│  MySQL 8.1 (Conteneur Docker)           │
│  Port : 3307                            │
└─────────────────────────────────────────┘
                   ↕
┌─────────────────────────────────────────┐
│       Couche Infrastructure             │
│  Docker Desktop                         │
│  phpMyAdmin (Port 8080)                 │
└─────────────────────────────────────────┘
```

### Bibliothèques additionnelles

**Génération de PDF :**
- iText7 (v9.4.0) : Création de documents, mise en page, tableaux
- iText7.bouncy-castle-adapter (v9.4.0) : Fonctions cryptographiques

**Liaison de l'UI :**
- BindingList<T> : Liaison de données bidirectionnelle pour DataGridView
- DataGridView : Contrôle WinForms natif pour les données tabulaires

---



## Sécurité

### Authentification & Autorisation

**Sécurité des mots de passe :**
- Hachage : SHA-256 (hash cryptographique de 256 bits)
- Stockage : seul le hash est stocké dans la base (chaîne hexadécimale de 64 caractères)
- Connexion : mot de passe haché au niveau de la base de données lors de la comparaison
- Mise à jour : les nouveaux mots de passe sont immédiatement hachés avant stockage

**Contrôle d'accès basé sur les rôles :**
- Deux rôles : Admin (true) et Médecin (false)
- Autorisation par routage : la connexion redirige selon le rôle
- Ségrégation des interfaces : administrateurs et médecins voient des formulaires différents
- Pas de sécurité au niveau ligne : les utilisateurs peuvent accéder à tous les enregistrements de leur interface

### Prévention des injections SQL

**Requêtes paramétrées :**
Toutes les opérations sur la base utilisent des requêtes paramétrées :
```csharp
command.CommandText = "SELECT * FROM User WHERE email = @email";
command.Parameters.AddWithValue("@email", email);
```

**Avantages :**
- Les saisies de l'utilisateur sont traitées comme des données, pas comme du code exécutable
- Empêche les attaques par injection SQL malveillantes
- Pas besoin d'échappement manuel des caractères spéciaux


---

## Crédits

**PdfExport par :** [RyukSylux](https://github.com/RyukSylux)

**Dépôt GitHub :** [bts-gsb-winform](https://github.com/jalmeida17/bts-gsb-winform)

**Contexte académique :** Projet d'épreuve finale du BTS SIO SLAM

**Technologies :**
- Microsoft .NET Framework Team — .NET 8.0
- Oracle Corporation — Base de données MySQL
- iText Software — Bibliothèque PDF iText7
- Docker Inc. — Conteneurisation Docker

---

## Licence

Ce projet est sous licence MIT.

---

## Avertissement pédagogique

Ce projet a été développé en tant que travail académique pour l'épreuve finale du BTS SIO SLAM. Il n'est pas destiné à un usage en production dans un environnement médical réel. Pour des applications de santé en production, des mesures de sécurité supplémentaires, la conformité réglementaire (HIPAA, RGPD) et des pratiques professionnelles de développement de logiciels médicaux seraient nécessaires.

---

<div align="center">

**Réalisé par [jalmeida17](https://github.com/jalmeida17) pour le cursus BTS SIO SLAM**


</div>
