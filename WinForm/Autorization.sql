USE [master]
GO

/****** Object:  Database [Authorization]    Script Date: 23.04.2019 21:04:14 ******/
CREATE DATABASE [Authorization]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Authorization', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Authorization.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Authorization_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Authorization_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Authorization] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Authorization].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

create table Form1
(
	Id	int IDENTITY(1,1),
	Login nvarchar(20) not null,
	Password  nvarchar(20) not null,
	Email nvarchar(50) not null,
	constraint Form_PK_Id primary key (Id)
)
go

insert into Form1(Login, Password, Email)
	values ('admin', 'Qq123', 'admin@tut.by')

insert into Form1(Login, Password, Email)
	values ('test', 'test', 'test@tut.by')