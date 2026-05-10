-- Create the database if it doesn't exist
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Project')
BEGIN
    CREATE DATABASE Project;
END
GO

USE Project;
GO

-- Create the USERS table
CREATE TABLE USERS (
    user_id INT IDENTITY(1,1) PRIMARY KEY, -- Use IDENTITY for auto-increment
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    contact_no VARCHAR(20),
    role VARCHAR(10) CHECK (role IN ('donor', 'admin')),
    is_active BIT DEFAULT 1,
    created_at DATETIME DEFAULT GETDATE() -- Use GETDATE() for SQL Server
);
GO

INSERT INTO USERS (username, password, contact_no, role, is_active) 
VALUES 
('abc', '123', '0101', 'admin', 1),
('def', '123', '0202', 'admin', 1),
('ghi', '123', '0303', 'donor', 1),
('jkl', '123', '0404', 'donor', 0);

-- View the results
SELECT * FROM USERS;

INSERT INTO USERS (username, password, contact_no, role, is_active) VALUES 
('yo', '123', '0101', 'admin', 1)

SELECT * FROM users WHERE Username = 'abc'

USE Project;
GO

CREATE TABLE ORGANIZATIONS (
    org_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(150) NOT NULL,
    category VARCHAR(50), -- e.g., 'Food', 'Education', 'Healthcare'
    contact_phone VARCHAR(20),
    bank_details TEXT, -- For record-keeping
    is_active BIT DEFAULT 1,
    is_verified BIT DEFAULT 0,
    created_at DATETIME DEFAULT GETDATE()
);
GO

USE Project;
GO

-- CREATING THE TABLE FOR ORGANIZATION

INSERT INTO ORGANIZATIONS (name, category, contact_phone, bank_details, is_active, is_verified)
VALUES 
-- 1. The Poor
('Dhaka Poverty Alleviation', 'Poor', '+8802111', 'Bank Asia, Acct: 10122', 1, 1),
('Global Relief Network', 'Poor', '+44207123', 'HSBC, IBAN: GB22...', 1, 1),

-- 2. The Needy
('Chittagong Food Bank', 'Needy', '+8803122', 'UCB, Acct: 30344', 1, 1),
('Shelter for All', 'Needy', '+1212555', 'Chase, Acct: 40455', 1, 1),

-- 3. Zakat Administrators
('Central Zakat Board BD', 'Administrators', '+8802333', 'Sonali Bank, Acct: 50566', 1, 1),
('Regional Zakat Collectors', 'Administrators', '+8802444', 'Agrani Bank, Acct: 60677', 1, 0),

-- 4. Reconciling Hearts (New Converts/Allies)
('New Muslim Support Center', 'Reconciling Hearts', '+8801555', 'City Bank, Acct: 70788', 1, 1),
('Interfaith Harmony Initiative', 'Reconciling Hearts', '+8801666', 'EBL, Acct: 80899', 1, 0),

-- 5. Freeing Captives (Bonded Labor/Slavery)
('Migrant Worker Legal Aid', 'Freeing Captives', '+8801777', 'Prime Bank, Acct: 90911', 1, 1),
('Human Rights Watch BD', 'Freeing Captives', '+8801888', 'Standard Chartered, Acct: 11122', 1, 1),

-- 6. Those in Debt
('Debt Relief Foundation', 'Debtors', '+8801999', 'Janata Bank, Acct: 22233', 1, 1),
('Farmers Cooperative Fund', 'Debtors', '+8801000', 'Krishi Bank, Acct: 33344', 1, 1),

-- 7. In the Path of Allah (Religious/Community causes)
('Islamic Education Trust', 'Path of Allah', '+8801211', 'Islami Bank, Acct: 44455', 1, 1),
('Masjid Construction Fund', 'Path of Allah', '+8801311', 'Al-Arafah Bank, Acct: 55566', 1, 1),

-- 8. The Wayfarer (Stranded Travelers)
('Traveler Assistance Dhaka', 'Wayfarers', '+8801411', 'Dutch Bangla, Acct: 66677', 1, 1),
('Refugee Transit Home', 'Wayfarers', '+8801511', 'Mutual Trust Bank, Acct: 77788', 1, 0);

GO

-- View the newly inserted organizations
SELECT * FROM ORGANIZATIONS;