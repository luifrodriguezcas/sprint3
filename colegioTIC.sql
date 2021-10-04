USE [master]
GO

/****** Object:  Database [colegioTIC]    Script Date: 3/10/2021 10:40:28 a. m. ******/
CREATE DATABASE [colegioTIC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'colegioTIC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\colegioTIC.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'colegioTIC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\colegioTIC_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [colegioTIC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [colegioTIC] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [colegioTIC] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [colegioTIC] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [colegioTIC] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [colegioTIC] SET ARITHABORT OFF 
GO

ALTER DATABASE [colegioTIC] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [colegioTIC] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [colegioTIC] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [colegioTIC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [colegioTIC] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [colegioTIC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [colegioTIC] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [colegioTIC] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [colegioTIC] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [colegioTIC] SET  DISABLE_BROKER 
GO

ALTER DATABASE [colegioTIC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [colegioTIC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [colegioTIC] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [colegioTIC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [colegioTIC] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [colegioTIC] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [colegioTIC] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [colegioTIC] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [colegioTIC] SET  MULTI_USER 
GO

ALTER DATABASE [colegioTIC] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [colegioTIC] SET DB_CHAINING OFF 
GO

ALTER DATABASE [colegioTIC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [colegioTIC] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [colegioTIC] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [colegioTIC] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [colegioTIC] SET QUERY_STORE = OFF
GO

ALTER DATABASE [colegioTIC] SET  READ_WRITE 
GO
