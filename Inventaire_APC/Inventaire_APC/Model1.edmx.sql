
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/09/2015 15:33:39
-- Generated from EDMX file: C:\Users\Ozstriker\Desktop\Inventaire_APC\Inventaire_APC\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [inventaire_apc];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_bureauxinventaires_bureau]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[inventaires_bureauSet] DROP CONSTRAINT [FK_bureauxinventaires_bureau];
GO
IF OBJECT_ID(N'[dbo].[FK_services_antennesbureaux]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[bureauxSet] DROP CONSTRAINT [FK_services_antennesbureaux];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[bureauxSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[bureauxSet];
GO
IF OBJECT_ID(N'[dbo].[inventaires_bureauSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[inventaires_bureauSet];
GO
IF OBJECT_ID(N'[dbo].[liste_equipementSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[liste_equipementSet];
GO
IF OBJECT_ID(N'[dbo].[services_antennesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[services_antennesSet];
GO
IF OBJECT_ID(N'[dbo].[login_tabSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[login_tabSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'bureauxSet'
CREATE TABLE [dbo].[bureauxSet] (
    [id_bureau] int IDENTITY(1,1) NOT NULL,
    [nom_bureau] nvarchar(max)  NOT NULL,
    [services_antennes_id_service] int  NOT NULL,
    [etat_bureau] int  NOT NULL
);
GO

-- Creating table 'inventaires_bureauSet'
CREATE TABLE [dbo].[inventaires_bureauSet] (
    [id_inventaire] int IDENTITY(1,1) NOT NULL,
    [numero_inventaire] int  NOT NULL,
    [nom_inventaire] nvarchar(max)  NOT NULL,
    [nombre_inventaire] int  NOT NULL,
    [refrence_inventaire] nvarchar(max)  NULL,
    [remarque_inventaire] nvarchar(max)  NULL,
    [bureaux_id_bureau] int  NOT NULL,
    [code_equippent_insert] int  NULL
);
GO

-- Creating table 'liste_equipementSet'
CREATE TABLE [dbo].[liste_equipementSet] (
    [id_equipement] int IDENTITY(1,1) NOT NULL,
    [nom_equipement] nvarchar(max)  NOT NULL,
    [quantite] int  NULL
);
GO

-- Creating table 'services_antennesSet'
CREATE TABLE [dbo].[services_antennesSet] (
    [id_service] int IDENTITY(1,1) NOT NULL,
    [nom_service] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'login_tabSet'
CREATE TABLE [dbo].[login_tabSet] (
    [id_user] int IDENTITY(1,1) NOT NULL,
    [user_names] nvarchar(max)  NOT NULL,
    [passwords] nvarchar(max)  NOT NULL,
    [permissions] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id_bureau] in table 'bureauxSet'
ALTER TABLE [dbo].[bureauxSet]
ADD CONSTRAINT [PK_bureauxSet]
    PRIMARY KEY CLUSTERED ([id_bureau] ASC);
GO

-- Creating primary key on [id_inventaire] in table 'inventaires_bureauSet'
ALTER TABLE [dbo].[inventaires_bureauSet]
ADD CONSTRAINT [PK_inventaires_bureauSet]
    PRIMARY KEY CLUSTERED ([id_inventaire] ASC);
GO

-- Creating primary key on [id_equipement] in table 'liste_equipementSet'
ALTER TABLE [dbo].[liste_equipementSet]
ADD CONSTRAINT [PK_liste_equipementSet]
    PRIMARY KEY CLUSTERED ([id_equipement] ASC);
GO

-- Creating primary key on [id_service] in table 'services_antennesSet'
ALTER TABLE [dbo].[services_antennesSet]
ADD CONSTRAINT [PK_services_antennesSet]
    PRIMARY KEY CLUSTERED ([id_service] ASC);
GO

-- Creating primary key on [id_user] in table 'login_tabSet'
ALTER TABLE [dbo].[login_tabSet]
ADD CONSTRAINT [PK_login_tabSet]
    PRIMARY KEY CLUSTERED ([id_user] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [bureaux_id_bureau] in table 'inventaires_bureauSet'
ALTER TABLE [dbo].[inventaires_bureauSet]
ADD CONSTRAINT [FK_bureauxinventaires_bureau]
    FOREIGN KEY ([bureaux_id_bureau])
    REFERENCES [dbo].[bureauxSet]
        ([id_bureau])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_bureauxinventaires_bureau'
CREATE INDEX [IX_FK_bureauxinventaires_bureau]
ON [dbo].[inventaires_bureauSet]
    ([bureaux_id_bureau]);
GO

-- Creating foreign key on [services_antennes_id_service] in table 'bureauxSet'
ALTER TABLE [dbo].[bureauxSet]
ADD CONSTRAINT [FK_services_antennesbureaux]
    FOREIGN KEY ([services_antennes_id_service])
    REFERENCES [dbo].[services_antennesSet]
        ([id_service])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_services_antennesbureaux'
CREATE INDEX [IX_FK_services_antennesbureaux]
ON [dbo].[bureauxSet]
    ([services_antennes_id_service]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------