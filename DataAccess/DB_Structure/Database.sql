-- MAKE SURE TO MANUALLY CREATE A DATABASE "Mediathek" FIRST, BEFORE RUNNING THIS SCRIPT
USE [Mediathek] -- Change when necessary

/*
USE [master]
GO
*/

/*
CREATE DATABASE [Mediathek] ON  PRIMARY 
( NAME = N'Mediathek', FILENAME = N'P:\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Mediathek.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Mediathek_log', FILENAME = N'P:\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Mediathek_log.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Mediathek] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Mediathek].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Mediathek] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Mediathek] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Mediathek] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Mediathek] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Mediathek] SET ARITHABORT OFF 
GO

ALTER DATABASE [Mediathek] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Mediathek] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Mediathek] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Mediathek] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Mediathek] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Mediathek] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Mediathek] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Mediathek] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Mediathek] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Mediathek] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Mediathek] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Mediathek] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Mediathek] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Mediathek] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Mediathek] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Mediathek] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Mediathek] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Mediathek] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Mediathek] SET  READ_WRITE 
GO

ALTER DATABASE [Mediathek] SET RECOVERY FULL 
GO

ALTER DATABASE [Mediathek] SET  MULTI_USER 
GO

ALTER DATABASE [Mediathek] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Mediathek] SET DB_CHAINING OFF 
GO

*/

-- MAKE SURE TO MANUALLY CREATE A DATABASE "Mediathek" FIRST, BEFORE RUNNING THIS SCRIPT

--USE [MTTest]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categories](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [text] NULL,
	[parent_category_id] [int] NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Titles]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Titles](
	[title_id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](20) NOT NULL,
 CONSTRAINT [PK_titles] PRIMARY KEY CLUSTERED 
(
	[title_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Settings](
	[setting_name] [varchar](30) NOT NULL,
	[setting_value] [varchar](255) NULL,
 CONSTRAINT [PK_settings] PRIMARY KEY CLUSTERED 
(
	[setting_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MediaTypes]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MediaTypes](
	[media_type_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](15) NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_media_types] PRIMARY KEY CLUSTERED 
(
	[media_type_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MediaStates]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MediaStates](
	[media_state_id] [int] IDENTITY(1,1) NOT NULL,
	[state_name] [varchar](20) NOT NULL,
 CONSTRAINT [PK_MediaStates] PRIMARY KEY CLUSTERED 
(
	[media_state_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Administrators]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Administrators](
	[admin_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](15) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[email] [varchar](255) NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_administrators] PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Administrators_Unique_Username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Media]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Media](
	[media_id] [int] IDENTITY(1,1) NOT NULL,
	[media_type_id] [int] NOT NULL,
	[media_state_id] [int] NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[category_id] [int] NOT NULL,
	[title] [varchar](100) NOT NULL,
	[tag] [varchar](255) NULL,
	[description] [text] NULL,
	[image] [image] NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_media] PRIMARY KEY CLUSTERED 
(
	[media_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AdministratorMessages]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdministratorMessages](
	[message_id] [int] NOT NULL,
	[caption] [varchar](30) NULL,
	[message] [text] NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[admin_id] [int] NOT NULL,
 CONSTRAINT [PK_administrator_messages] PRIMARY KEY CLUSTERED 
(
	[message_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[email] [varchar](255) NULL,
	[title_id] [int] NULL,
	[street] [varchar](50) NOT NULL,
	[zip] [varchar](10) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[country_iso] [varchar](2) NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AdminMessagesForUsers]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminMessagesForUsers](
	[message_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[unread] [bit] NOT NULL,
 CONSTRAINT [PK_admin_messages_per_user] PRIMARY KEY CLUSTERED 
(
	[message_id] ASC,
	[user_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserMessages]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserMessages](
	[message_id] [int] IDENTITY(1,1) NOT NULL,
	[sender_user_id] [int] NOT NULL,
	[caption] [varchar](30) NULL,
	[message] [text] NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[unread] [bit] NOT NULL,
 CONSTRAINT [PK_user_messages] PRIMARY KEY CLUSTERED 
(
	[message_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[reservation_id] [int] IDENTITY(1,1) NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[media_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[end_date] [datetime] NULL,
 CONSTRAINT [PK_reservations] PRIMARY KEY CLUSTERED 
(
	[reservation_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MediaVideos]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MediaVideos](
	[media_id] [int] NOT NULL,
	[director] [varchar](50) NULL,
	[length] [int] NULL,
	[actors] [text] NULL,
 CONSTRAINT [PK_media_videos] PRIMARY KEY CLUSTERED 
(
	[media_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MediaRentings]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MediaRentings](
	[media_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[checkout_date] [datetime] NOT NULL,
	[checkin_date] [datetime] NULL,
 CONSTRAINT [PK_media_rentings] PRIMARY KEY CLUSTERED 
(
	[media_id] ASC,
	[user_id] ASC,
	[checkout_date] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MediaMusic]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MediaMusic](
	[media_id] [int] NOT NULL,
	[artist] [varchar](50) NULL,
	[genre] [varchar](20) NULL,
	[tracklist] [text] NULL,
 CONSTRAINT [PK_media_music] PRIMARY KEY CLUSTERED 
(
	[media_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MediaMisc]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MediaMisc](
	[media_id] [int] NOT NULL,
	[short_description] [varchar](255) NULL,
 CONSTRAINT [PK_media_misc] PRIMARY KEY CLUSTERED 
(
	[media_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MediaBooks]    Script Date: 08/04/2009 18:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MediaBooks](
	[media_id] [int] NOT NULL,
	[author] [varchar](100) NULL,
	[publisher] [varchar](50) NULL,
	[publishing_year] [int] NULL,
	[isbn] [varchar](50) NULL,
 CONSTRAINT [PK_media_books] PRIMARY KEY CLUSTERED 
(
	[media_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Administrators_deleted]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[Administrators] ADD  CONSTRAINT [DF_Administrators_deleted]  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF_Media_deleted]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[Media] ADD  CONSTRAINT [DF_Media_deleted]  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF_Users_deleted]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_deleted]  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  Default [DF_admin_messages_per_user_unread]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[AdminMessagesForUsers] ADD  CONSTRAINT [DF_admin_messages_per_user_unread]  DEFAULT ((1)) FOR [unread]
GO
/****** Object:  Default [DF_user_messages_unread]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[UserMessages] ADD  CONSTRAINT [DF_user_messages_unread]  DEFAULT ((1)) FOR [unread]
GO
/****** Object:  ForeignKey [FK_categories_parent_categories]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_categories_parent_categories] FOREIGN KEY([parent_category_id])
REFERENCES [dbo].[Categories] ([category_id])
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_categories_parent_categories]
GO
/****** Object:  ForeignKey [FK_media_category]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[Media]  WITH CHECK ADD  CONSTRAINT [FK_media_category] FOREIGN KEY([category_id])
REFERENCES [dbo].[Categories] ([category_id])
GO
ALTER TABLE [dbo].[Media] CHECK CONSTRAINT [FK_media_category]
GO
/****** Object:  ForeignKey [FK_media_state]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[Media]  WITH CHECK ADD  CONSTRAINT [FK_media_state] FOREIGN KEY([media_state_id])
REFERENCES [dbo].[MediaStates] ([media_state_id])
GO
ALTER TABLE [dbo].[Media] CHECK CONSTRAINT [FK_media_state]
GO
/****** Object:  ForeignKey [FK_type]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[Media]  WITH CHECK ADD  CONSTRAINT [FK_type] FOREIGN KEY([media_type_id])
REFERENCES [dbo].[MediaTypes] ([media_type_id])
GO
ALTER TABLE [dbo].[Media] CHECK CONSTRAINT [FK_type]
GO
/****** Object:  ForeignKey [FK_adm_mess_creator]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[AdministratorMessages]  WITH CHECK ADD  CONSTRAINT [FK_adm_mess_creator] FOREIGN KEY([admin_id])
REFERENCES [dbo].[Administrators] ([admin_id])
GO
ALTER TABLE [dbo].[AdministratorMessages] CHECK CONSTRAINT [FK_adm_mess_creator]
GO
/****** Object:  ForeignKey [FK_title]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_title] FOREIGN KEY([title_id])
REFERENCES [dbo].[Titles] ([title_id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_title]
GO
/****** Object:  ForeignKey [FK_adm_mess_user]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[AdminMessagesForUsers]  WITH CHECK ADD  CONSTRAINT [FK_adm_mess_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[AdminMessagesForUsers] CHECK CONSTRAINT [FK_adm_mess_user]
GO
/****** Object:  ForeignKey [FK_admin_mess_messages]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[AdminMessagesForUsers]  WITH CHECK ADD  CONSTRAINT [FK_admin_mess_messages] FOREIGN KEY([message_id])
REFERENCES [dbo].[AdministratorMessages] ([message_id])
GO
ALTER TABLE [dbo].[AdminMessagesForUsers] CHECK CONSTRAINT [FK_admin_mess_messages]
GO
/****** Object:  ForeignKey [FK_user_messages_sender]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[UserMessages]  WITH CHECK ADD  CONSTRAINT [FK_user_messages_sender] FOREIGN KEY([sender_user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[UserMessages] CHECK CONSTRAINT [FK_user_messages_sender]
GO
/****** Object:  ForeignKey [FK_reservations_media]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_reservations_media] FOREIGN KEY([media_id])
REFERENCES [dbo].[Media] ([media_id])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_reservations_media]
GO
/****** Object:  ForeignKey [FK_reservations_user]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_reservations_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_reservations_user]
GO
/****** Object:  ForeignKey [FK_media_video]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[MediaVideos]  WITH CHECK ADD  CONSTRAINT [FK_media_video] FOREIGN KEY([media_id])
REFERENCES [dbo].[Media] ([media_id])
GO
ALTER TABLE [dbo].[MediaVideos] CHECK CONSTRAINT [FK_media_video]
GO
/****** Object:  ForeignKey [FK_media_rentings_media]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[MediaRentings]  WITH CHECK ADD  CONSTRAINT [FK_media_rentings_media] FOREIGN KEY([media_id])
REFERENCES [dbo].[Media] ([media_id])
GO
ALTER TABLE [dbo].[MediaRentings] CHECK CONSTRAINT [FK_media_rentings_media]
GO
/****** Object:  ForeignKey [FK_media_rentings_users]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[MediaRentings]  WITH CHECK ADD  CONSTRAINT [FK_media_rentings_users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[MediaRentings] CHECK CONSTRAINT [FK_media_rentings_users]
GO
/****** Object:  ForeignKey [FK_media_music]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[MediaMusic]  WITH CHECK ADD  CONSTRAINT [FK_media_music] FOREIGN KEY([media_id])
REFERENCES [dbo].[Media] ([media_id])
GO
ALTER TABLE [dbo].[MediaMusic] CHECK CONSTRAINT [FK_media_music]
GO
/****** Object:  ForeignKey [FK_media_misc]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[MediaMisc]  WITH CHECK ADD  CONSTRAINT [FK_media_misc] FOREIGN KEY([media_id])
REFERENCES [dbo].[Media] ([media_id])
GO
ALTER TABLE [dbo].[MediaMisc] CHECK CONSTRAINT [FK_media_misc]
GO
/****** Object:  ForeignKey [FK_media_books_media]    Script Date: 08/04/2009 18:38:00 ******/
ALTER TABLE [dbo].[MediaBooks]  WITH CHECK ADD  CONSTRAINT [FK_media_books_media] FOREIGN KEY([media_id])
REFERENCES [dbo].[Media] ([media_id])
GO
ALTER TABLE [dbo].[MediaBooks] CHECK CONSTRAINT [FK_media_books_media]
GO


-- ADD basic data
SET IDENTITY_INSERT [Administrators] ON
INSERT INTO [Administrators] ([admin_id],[username],[password],[email],[deleted])VALUES(1,'admin','test','test@test.ch',0)
SET IDENTITY_INSERT [Administrators] OFF

SET IDENTITY_INSERT [MediaStates] ON
INSERT INTO [MediaStates] ([media_state_id],[state_name])VALUES(1,'Verfügbar')
INSERT INTO [MediaStates] ([media_state_id],[state_name])VALUES(2,'Ausgeliehen')
SET IDENTITY_INSERT [MediaStates] OFF

SET IDENTITY_INSERT [Categories] ON
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(1,'Bücher',NULL,NULL)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(2,'Musik',NULL,NULL)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(3,'Videos',NULL,NULL)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(4,'Diverses',NULL,NULL)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(5,'Comics',NULL,1)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(6,'Sachbücher',NULL,1)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(7,'Belletristik',NULL,1)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(8,'Zeitschriften',NULL,1)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(9,'Kinderbücher',NULL,1)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(10,'Manga',NULL,5)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(11,'Westliche Comics',NULL,5)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(12,'Geologie',NULL,6)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(13,'Geographie',NULL,6)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(14,'Geschichte',NULL,6)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(15,'Raumfahrt',NULL,6)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(16,'Auto',NULL,6)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(17,'Computer',NULL,6)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(18,'Handwerk',NULL,6)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(19,'Botanik',NULL,6)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(20,'Tiere',NULL,6)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(21,'Romane',NULL,7)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(22,'Novellen',NULL,7)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(23,'Nachkriegsliteratur',NULL,7)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(24,'Liebesromane',NULL,21)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(25,'Männerzeitschriften',NULL,8)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(26,'Frauenzeitschriften',NULL,8)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(27,'Teenager-Zeitschriften',NULL,8)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(28,'Malbücher',NULL,9)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(29,'Kindergeschichten',NULL,9)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(30,'Seien',NULL,10)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(31,'Shonen',NULL,10)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(32,'Erotische Manga',NULL,10)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(33,'Pop',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(34,'80er',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(35,'90er',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(36,'70er',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(37,'60er',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(38,'50er',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(39,'Jazz',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(40,'Blues',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(41,'Techno',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(42,'Rock',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(43,'Metal',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(44,'Speed Metal',NULL,43)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(45,'Death Metal',NULL,43)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(46,'Softrock',NULL,2)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(47,'Boygroups',NULL,33)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(48,'Girlgroups',NULL,33)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(49,'House',NULL,41)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(50,'Trance',NULL,41)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(51,'Progressive House',NULL,49)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(52,'Spiele',NULL,4)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(53,'Spielzeug',NULL,4)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(54,'Spielfilme',NULL,3)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(55,'Serien',NULL,3)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(56,'Kriegsfilme',NULL,54)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(57,'Liebesfilme',NULL,54)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(58,'Actionfilme',NULL,54)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(59,'Komödien',NULL,54)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(60,'Musicals',NULL,54)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(61,'Trashfilme',NULL,54)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(62,'Horrorfilme',NULL,54)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(63,'Teenager-Serien',NULL,55)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(64,'Action-Serien',NULL,55)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(65,'Drama-Serien',NULL,55)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(66,'Fantasy-Serien',NULL,55)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(67,'Fantasy',NULL,54)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(68,'Erotikfilme',NULL,54)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(69,'Detektiv-Serien',NULL,55)
INSERT INTO [Categories] ([category_id],[name],[description],[parent_category_id])VALUES(70,'Noire',NULL,69)
SET IDENTITY_INSERT [Categories] OFF

SET IDENTITY_INSERT [MediaTypes] ON
INSERT INTO [MediaTypes] ([media_type_id],[name],[description])VALUES(1,'Bücher','Literatur aller Art')
INSERT INTO [MediaTypes] ([media_type_id],[name],[description])VALUES(2,'Musik','Musik, CDs, Kasetten, Schallplatten')
INSERT INTO [MediaTypes] ([media_type_id],[name],[description])VALUES(3,'Videos','Filme, Serien, DVDs, VHS')
INSERT INTO [MediaTypes] ([media_type_id],[name],[description])VALUES(4,'Diverses','Spiele, andere nicht näher spezifizierte Artikel')
SET IDENTITY_INSERT [MediaTypes] OFF

INSERT INTO [Settings] ([setting_name],[setting_value])VALUES('MaxOpenReservations','10')

SET IDENTITY_INSERT [Titles] ON
INSERT INTO [Titles] ([title_id],[description])VALUES(1,'Herr')
INSERT INTO [Titles] ([title_id],[description])VALUES(2,'Frau')
INSERT INTO [Titles] ([title_id],[description])VALUES(3,'Prof.')
INSERT INTO [Titles] ([title_id],[description])VALUES(4,'Dr.')
SET IDENTITY_INSERT [Titles] OFF
