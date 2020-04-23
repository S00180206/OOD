
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/23/2020 13:47:51
-- Generated from EDMX file: C:\Users\Carmel O'Donnell\Documents\GitHub\OOD\selfAssessment\IndividualProject_S00180206\IndividualProject_S00180206\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ComicShows];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Shows'
CREATE TABLE [dbo].[Shows] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Release] datetime  NOT NULL,
    [Company] nvarchar(max)  NOT NULL,
    [ShowImage] nvarchar(max)  NOT NULL,
    [CompanyId] int  NOT NULL,
    [ShowDiscription_Id] int  NOT NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CompanyName] nvarchar(max)  NOT NULL,
    [StreamingService] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ShowDiscriptions'
CREATE TABLE [dbo].[ShowDiscriptions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Genre] nvarchar(max)  NOT NULL,
    [NumberOfSeasons] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ViewerCount] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Shows'
ALTER TABLE [dbo].[Shows]
ADD CONSTRAINT [PK_Shows]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ShowDiscriptions'
ALTER TABLE [dbo].[ShowDiscriptions]
ADD CONSTRAINT [PK_ShowDiscriptions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CompanyId] in table 'Shows'
ALTER TABLE [dbo].[Shows]
ADD CONSTRAINT [FK_CompanyShow]
    FOREIGN KEY ([CompanyId])
    REFERENCES [dbo].[Companies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyShow'
CREATE INDEX [IX_FK_CompanyShow]
ON [dbo].[Shows]
    ([CompanyId]);
GO

-- Creating foreign key on [ShowDiscription_Id] in table 'Shows'
ALTER TABLE [dbo].[Shows]
ADD CONSTRAINT [FK_ShowShowDiscription]
    FOREIGN KEY ([ShowDiscription_Id])
    REFERENCES [dbo].[ShowDiscriptions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ShowShowDiscription'
CREATE INDEX [IX_FK_ShowShowDiscription]
ON [dbo].[Shows]
    ([ShowDiscription_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------