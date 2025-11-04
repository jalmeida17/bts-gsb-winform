-- ==========================
-- TABLE : User
-- ==========================
CREATE TABLE User (
    id_user INT AUTO_INCREMENT PRIMARY KEY,
    firstname VARCHAR(100) NOT NULL,
    name VARCHAR(100) NOT NULL,
    role BOOLEAN NOT NULL,
    email VARCHAR(150) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL
);

-- ==========================
-- TABLE : Patient
-- ==========================
CREATE TABLE Patient (
    id_patient INT AUTO_INCREMENT PRIMARY KEY,
    id_user INT NOT NULL,
    name VARCHAR(100) NOT NULL,
    firstname VARCHAR(100) NOT NULL,
    age INT,
    gender BOOLEAN, -- 0 = Femme, 1 = Homme
    FOREIGN KEY (id_user) REFERENCES User(id_user)
        ON DELETE CASCADE ON UPDATE CASCADE
);

-- ==========================
-- TABLE : Medicine
-- ==========================
CREATE TABLE Medicine (
    id_medicine INT AUTO_INCREMENT PRIMARY KEY,
    id_user INT NOT NULL,
    name VARCHAR(150) NOT NULL,
    molecule VARCHAR(150),
    dosage VARCHAR(100),
    description TEXT,
    FOREIGN KEY (id_user) REFERENCES User(id_user)
        ON DELETE CASCADE ON UPDATE CASCADE
);

-- ==========================
-- TABLE : Prescription
-- ==========================
CREATE TABLE Prescription (
    id_prescription INT AUTO_INCREMENT PRIMARY KEY,
    id_patient INT NOT NULL,
    id_user INT NOT NULL,
    quantity INT,
    validity DATE,
    FOREIGN KEY (id_patient) REFERENCES Patient(id_patient)
        ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_user) REFERENCES User(id_user)
        ON DELETE CASCADE ON UPDATE CASCADE
);

-- ==========================
-- TABLE : Appartient (relation Prescription ↔ Medicine)
-- ==========================
CREATE TABLE Appartient (
    id_prescription INT NOT NULL,
    id_medicine INT NOT NULL,
    PRIMARY KEY (id_prescription, id_medicine),
    FOREIGN KEY (id_prescription) REFERENCES Prescription(id_prescription)
        ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_medicine) REFERENCES Medicine(id_medicine)
        ON DELETE CASCADE ON UPDATE CASCADE
);