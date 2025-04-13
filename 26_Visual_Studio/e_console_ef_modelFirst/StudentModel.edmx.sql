
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/07/2025 08:23:52
-- Generated from EDMX file: D:\csp\26_Visual_Studio\e_console_ef_modelFirst\StudentModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db_dbfirst];
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

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [StuRoll] int IDENTITY(1,1) NOT NULL,
    [StudentName] nvarchar(max)  NOT NULL,
    [CollegeCollegeid] int  NOT NULL
);
GO

-- Creating table 'Colleges'
CREATE TABLE [dbo].[Colleges] (
    [Collegeid] int IDENTITY(1,1) NOT NULL,
    [CollegeName] nvarchar(max)  NOT NULL,
    [CollegeAddress] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [StuRoll] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([StuRoll] ASC);
GO

-- Creating primary key on [Collegeid] in table 'Colleges'
ALTER TABLE [dbo].[Colleges]
ADD CONSTRAINT [PK_Colleges]
    PRIMARY KEY CLUSTERED ([Collegeid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CollegeCollegeid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_CollegeStudent]
    FOREIGN KEY ([CollegeCollegeid])
    REFERENCES [dbo].[Colleges]
        ([Collegeid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollegeStudent'
CREATE INDEX [IX_FK_CollegeStudent]
ON [dbo].[Students]
    ([CollegeCollegeid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------