USE [master]
GO
/****** Object:  Database [Payement_des_etudiants]    Script Date: 16/10/2023 18:20:13 ******/
CREATE DATABASE [Payement_des_etudiants]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Payement_des_etudiants', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Payement_des_etudiants.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Payement_des_etudiants_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Payement_des_etudiants_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Payement_des_etudiants].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Payement_des_etudiants] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET ARITHABORT OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Payement_des_etudiants] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Payement_des_etudiants] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Payement_des_etudiants] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Payement_des_etudiants] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET RECOVERY FULL 
GO
ALTER DATABASE [Payement_des_etudiants] SET  MULTI_USER 
GO
ALTER DATABASE [Payement_des_etudiants] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Payement_des_etudiants] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Payement_des_etudiants] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Payement_des_etudiants] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Payement_des_etudiants] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Payement_des_etudiants', N'ON'
GO
ALTER DATABASE [Payement_des_etudiants] SET QUERY_STORE = OFF
GO
USE [Payement_des_etudiants]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Payement_des_etudiants]
GO
/****** Object:  Table [dbo].[Etudiants]    Script Date: 16/10/2023 18:20:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etudiants](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_utilisateur] [int] NULL,
	[Id_Nom_facultes] [int] NULL,
	[Id_Nom_promotion] [int] NULL,
	[Noms] [varchar](100) NULL,
	[Prenom] [varchar](20) NULL,
	[Nomsresponsable] [varchar](30) NULL,
	[Contactrsp] [varchar](20) NULL,
	[Datenaissance] [varchar](50) NULL,
	[Sexe] [varchar](10) NULL,
	[Contact] [varchar](20) NULL,
	[Photo] [varchar](max) NULL,
	[Adressemail] [varchar](50) NULL,
	[Adresse] [varchar](50) NULL,
	[matricule] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [un_matricule] UNIQUE NONCLUSTERED 
(
	[matricule] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Facultes]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facultes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom_facultes] [varchar](30) NOT NULL,
	[Sigle] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Frais]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Frais](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_utilisateur] [int] NULL,
	[Id_Nom_facultes] [int] NULL,
	[Id_Nom_promotion] [int] NULL,
	[Inscription] [int] NULL,
	[Tranche1] [int] NULL,
	[Tranche2] [int] NULL,
	[Tranche3] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Limite_frais]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Limite_frais](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_frais] [int] NULL,
	[Numero_tranche] [varchar](30) NULL,
	[Date_debut] [date] NULL,
	[Date_fin] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payement]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_utilisateur] [int] NULL,
	[Id_Etudiant] [varchar](50) NULL,
	[Montant] [int] NULL,
	[Date_paye] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Promotion]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom_promotion] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Typeutilisateurtb]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Typeutilisateurtb](
	[Typeutilisateurid] [int] IDENTITY(1,1) NOT NULL,
	[Nomtype] [varchar](50) NOT NULL,
	[Description] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Typeutilisateurid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Typeutilisateur_id] [int] NULL,
	[Noms] [varchar](50) NOT NULL,
	[Nom_utilisateur] [varchar](50) NOT NULL,
	[Mot_de_passe] [varchar](20) NOT NULL,
	[Numero_tel] [varchar](20) NOT NULL,
	[Adresse_mail] [varchar](100) NOT NULL,
	[Adresse] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Etudiants]  WITH CHECK ADD  CONSTRAINT [fk_fac] FOREIGN KEY([Id_Nom_facultes])
REFERENCES [dbo].[Facultes] ([Id])
GO
ALTER TABLE [dbo].[Etudiants] CHECK CONSTRAINT [fk_fac]
GO
ALTER TABLE [dbo].[Etudiants]  WITH CHECK ADD  CONSTRAINT [fk_prom] FOREIGN KEY([Id_Nom_promotion])
REFERENCES [dbo].[Promotion] ([Id])
GO
ALTER TABLE [dbo].[Etudiants] CHECK CONSTRAINT [fk_prom]
GO
ALTER TABLE [dbo].[Etudiants]  WITH CHECK ADD  CONSTRAINT [fk_utilisateur] FOREIGN KEY([Id_utilisateur])
REFERENCES [dbo].[Utilisateur] ([Id])
GO
ALTER TABLE [dbo].[Etudiants] CHECK CONSTRAINT [fk_utilisateur]
GO
ALTER TABLE [dbo].[Frais]  WITH CHECK ADD  CONSTRAINT [fk_faculte] FOREIGN KEY([Id_Nom_facultes])
REFERENCES [dbo].[Facultes] ([Id])
GO
ALTER TABLE [dbo].[Frais] CHECK CONSTRAINT [fk_faculte]
GO
ALTER TABLE [dbo].[Frais]  WITH CHECK ADD  CONSTRAINT [fk_promotion] FOREIGN KEY([Id_Nom_promotion])
REFERENCES [dbo].[Promotion] ([Id])
GO
ALTER TABLE [dbo].[Frais] CHECK CONSTRAINT [fk_promotion]
GO
ALTER TABLE [dbo].[Frais]  WITH CHECK ADD  CONSTRAINT [fk_user] FOREIGN KEY([Id_utilisateur])
REFERENCES [dbo].[Utilisateur] ([Id])
GO
ALTER TABLE [dbo].[Frais] CHECK CONSTRAINT [fk_user]
GO
ALTER TABLE [dbo].[Limite_frais]  WITH CHECK ADD  CONSTRAINT [fk_frais] FOREIGN KEY([Id_frais])
REFERENCES [dbo].[Frais] ([Id])
GO
ALTER TABLE [dbo].[Limite_frais] CHECK CONSTRAINT [fk_frais]
GO
ALTER TABLE [dbo].[Payement]  WITH CHECK ADD  CONSTRAINT [fk_paye_etudiant] FOREIGN KEY([Id_Etudiant])
REFERENCES [dbo].[Etudiants] ([matricule])
GO
ALTER TABLE [dbo].[Payement] CHECK CONSTRAINT [fk_paye_etudiant]
GO
ALTER TABLE [dbo].[Payement]  WITH CHECK ADD  CONSTRAINT [fk_paye_utilisateur] FOREIGN KEY([Id_utilisateur])
REFERENCES [dbo].[Utilisateur] ([Id])
GO
ALTER TABLE [dbo].[Payement] CHECK CONSTRAINT [fk_paye_utilisateur]
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD  CONSTRAINT [fk_typeeutilisateurid] FOREIGN KEY([Typeutilisateur_id])
REFERENCES [dbo].[Typeutilisateurtb] ([Typeutilisateurid])
GO
ALTER TABLE [dbo].[Utilisateur] CHECK CONSTRAINT [fk_typeeutilisateurid]
GO
ALTER TABLE [dbo].[Etudiants]  WITH CHECK ADD  CONSTRAINT [chk_sexe] CHECK  (([Sexe]='M' OR [Sexe]='F'))
GO
ALTER TABLE [dbo].[Etudiants] CHECK CONSTRAINT [chk_sexe]
GO
/****** Object:  StoredProcedure [dbo].[aff_faculte]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[aff_faculte]
as
begin
 select * from Facultes
end
GO
/****** Object:  StoredProcedure [dbo].[Create_typeutilisateur]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Create_typeutilisateur]
(@nomtype varchar(20), @description varchar(100))
as
begin
	insert into Typeutilisateurtb(Nomtype,Description)values(@nomtype,@description)
end
GO
/****** Object:  StoredProcedure [dbo].[Create_utilisateur]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Create_utilisateur]
(@typeutilisateurid int,@noms varchar(20),@nom_utilisateur varchar(20),@motedepasse varchar(20),@numerotel varchar(20),@mail varchar(20),@adresse varchar(30))
as
begin
	insert into Utilisateur (Typeutilisateur_id, Noms, Nom_utilisateur, Mot_de_passe, Numero_tel, Adresse_mail, Adresse)
	values(@typeutilisateurid,@noms,@nom_utilisateur,@motedepasse,@numerotel,@mail,@adresse)
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_typeutilisateur]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_typeutilisateur]
(@typeutilisateurid int)
as
begin
	delete from Typeutilisateurtb where Typeutilisateurid=@typeutilisateurid
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_utilisateur]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Delete_utilisateur]
(@utilisateurid int)
as
begin
delete from Utilisateur where Id = @utilisateurid
end
GO
/****** Object:  StoredProcedure [dbo].[get_payement_by_matricule]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[get_payement_by_matricule]
(@id int )
as
begin
declare @matricule varchar(50), @faculte varchar(50), @promotion varchar(5), @insc int, @t1 int, @t2 int, @t3 int
set @matricule = (select Id_Etudiant from Payement where id = @id)
set @faculte = (select Id_Nom_facultes from Etudiants where matricule = @matricule)
set @promotion = (select Id_Nom_promotion from Etudiants where matricule = @matricule)

set @insc = (select Inscription from Frais where Id_Nom_facultes = @faculte and Id_Nom_promotion = @promotion)
set @t1 = (select Tranche1 from Frais where Id_Nom_facultes = @faculte and Id_Nom_promotion = @promotion)
set @t2 = (select Tranche2 from Frais where Id_Nom_facultes = @faculte and Id_Nom_promotion = @promotion)
set @t3 = (select Tranche3 from Frais where Id_Nom_facultes = @faculte and Id_Nom_promotion = @promotion)

select p.Id_Etudiant, (UPPER(e.Noms)+' '+ e.Prenom) as Noms, f.Nom_facultes, prom.Nom_promotion,SUM(p.Montant) as Montant,
((@insc+ @t1+ @t2+ @t3)-SUM(p.Montant)) as Reste 
from Payement p 
inner join Etudiants e 
on e.matricule = p.Id_Etudiant  inner join Facultes f on f.Id =  e.Id_Nom_facultes
inner join Promotion prom on prom.Id = e.Id_Nom_promotion
where p.Id_Etudiant = @matricule
group by Id_Etudiant, Noms, Prenom, Nom_facultes, Nom_promotion
end
GO
/****** Object:  StoredProcedure [dbo].[insert_etudiant]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_etudiant]
(@idnomfac int, @idprom int, @nom varchar(100), @prenom varchar(50), @nomresp varchar(50), @contactresp varchar(50), @datenaiss date,
@sexe varchar(20), @contact varchar(50), @photo varchar(500), @mail varchar(100), @adresse varchar(250)) 
as
begin
 insert into Etudiants (Id_Nom_facultes, Id_Nom_promotion, Noms, Prenom, Nomsresponsable, 
Contactrsp, Datenaissance, Sexe, Contact, Photo, Adressemail, Adresse) values
(@idnomfac , @idprom, @nom, @prenom, @nomresp, @contactresp, @datenaiss,
@sexe, @contact, @photo, @mail, @adresse)
end
GO
/****** Object:  StoredProcedure [dbo].[liste_payement]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[liste_payement]
as
begin
select p.id, p.Id_Etudiant, (UPPER(e.Noms)+' '+ e.Prenom) as Noms, 
f.Nom_facultes, prom.Nom_promotion,p.Montant, p.Date_paye from Payement p inner join Etudiants e 
on e.matricule = p.Id_Etudiant  inner join Facultes f
on f.Id =  e.Id_Nom_facultes inner join Promotion prom on prom.id = e.Id_Nom_promotion order by id desc
end
GO
/****** Object:  StoredProcedure [dbo].[liste_payement_par_etudiant]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[liste_payement_par_etudiant]
(@matricules varchar(250))
as
begin
------------------
Declare @somme int
set @somme = (select top(1)sum(Montant) from Payement where Id_Etudiant = @matricules)

select p.Id_Etudiant, e.Noms, e.Prenom, f.Nom_facultes, prom.Nom_promotion, p.Montant, p.Date_paye,
(select @somme) as Somme
from Payement p 
inner join Etudiants e on e.matricule = p.Id_Etudiant
inner join Facultes f on f.Id = e.Id_Nom_facultes
inner join Promotion prom on prom.Id = e.Id_Nom_promotion
where Id_Etudiant = @matricules

end
GO
/****** Object:  StoredProcedure [dbo].[login_user]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[login_user]
(@nomuser varchar(50), @mtdpasse varchar(50), @Isvalid bit out)
as
begin
	set @isvalid = (select count(1) from Utilisateur where Nom_utilisateur = @nomuser and Mot_de_passe = @mtdpasse)
end
GO
/****** Object:  StoredProcedure [dbo].[nom_liste_payement]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[nom_liste_payement]
(@matricules varchar(250))
as
begin
select p.Id_Etudiant, (UPPER(e.Noms)+''+UPPER( e.Prenom)) as Noms, f.Nom_facultes, prom.Nom_promotion,
sum(p.Montant) as Somme,e.Photo as Photo
from Payement p 
inner join Etudiants e on e.matricule = p.Id_Etudiant
inner join Facultes f on f.Id = e.Id_Nom_facultes
inner join Promotion prom on prom.Id = e.Id_Nom_promotion
where Id_Etudiant = @matricules group by p.Id_Etudiant, e.Noms, e.Prenom, f.Nom_facultes, prom.Nom_promotion, e.Photo

end
GO
/****** Object:  StoredProcedure [dbo].[recu_payement]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[recu_payement]
(@id int )
as
begin
declare @matricule varchar(50), @faculte varchar(50), @promotion varchar(5), @insc int, @t1 int, @t2 int, @t3 int,
@noms varchar(250), @reste int, @montant_du_jour varchar(50), @photo varchar(50), @datedujour varchar(50), @ident varchar(50),
@datetime varchar(100)
set @matricule = (select Id_Etudiant from Payement where id = @id)
set @faculte = (select Id_Nom_facultes from Etudiants where matricule = @matricule)
set @promotion = (select Id_Nom_promotion from Etudiants where matricule = @matricule)
set @montant_du_jour = (select Montant from Payement where id = @id)
set @datedujour = (select format(Date_paye,'dd/MM/yyyy' )from Payement where id = @id)
set @datetime = (select format(getdate(),'dd/MM/yyyy hh:mm:ss'))
set @ident = (select '00'+ cast(@id as varchar(250))+'/'+ format(getdate(),'yyyy'))

set @insc = (select Inscription from Frais where Id_Nom_facultes = @faculte and Id_Nom_promotion = @promotion)
set @t1 = (select Tranche1 from Frais where Id_Nom_facultes = @faculte and Id_Nom_promotion = @promotion)
set @t2 = (select Tranche2 from Frais where Id_Nom_facultes = @faculte and Id_Nom_promotion = @promotion)
set @t3 = (select Tranche3 from Frais where Id_Nom_facultes = @faculte and Id_Nom_promotion = @promotion)

Declare Cur_recu_pay Cursor
for select p.Id_Etudiant, (UPPER(e.Noms)+' '+UPPER(e.Prenom)) as Noms, f.Sigle, prom.Nom_promotion,
((@insc+ @t1+ @t2+ @t3)-SUM(p.Montant)) as Reste, e.Photo 
from Payement p 
inner join Etudiants e 
on e.matricule = p.Id_Etudiant  inner join Facultes f on f.Id =  e.Id_Nom_facultes
inner join Promotion prom on prom.Id = e.Id_Nom_promotion
where p.Id_Etudiant = @matricule
group by Id_Etudiant, Noms, Prenom, Sigle, Nom_promotion, photo

Open Cur_recu_pay
Fetch Next from Cur_recu_pay into @matricule, @noms, @faculte, @promotion, @reste, @photo

While @@fetch_status=0
Begin

				
		select @matricule as Matricule, @noms as Noms, @faculte as Faculte,
		@promotion as Promotion, @montant_du_jour as Montantpaye,@reste as Reste, @photo as Photo, 
		@datedujour as Datedepaye, @datetime as Date_time, @ident as numrecu
			
	
Fetch Next from Cur_recu_pay into @matricule, @noms, @faculte, @promotion, @reste, @photo
End
Close Cur_recu_pay
Deallocate Cur_recu_pay
end
GO
/****** Object:  StoredProcedure [dbo].[select_etudiant]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[select_etudiant]
as
begin
select f.Nom_facultes, p.Nom_promotion,e.Id, e.Noms, e.Prenom, e.Nomsresponsable, e.Contactrsp,
e.Datenaissance, e.Sexe, e.Contact, e.Photo, e.Adressemail, e.Adresse, e.matricule 
from Etudiants e inner join Facultes f on f.Id = e.Id_Nom_facultes inner join Promotion p on p.Id = e.Id_Nom_promotion    
end
GO
/****** Object:  StoredProcedure [dbo].[Select_etudiant_by_id]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_etudiant_by_id]
	(@id int)
AS
begin
select f.Nom_facultes, p.Nom_promotion,e.Id, e.Noms, e.Prenom, e.Nomsresponsable, e.Contactrsp,
e.Datenaissance, e.Sexe, e.Contact, e.Photo, e.Adressemail, e.Adresse, e.matricule 
from Etudiants e inner join Facultes f on f.Id = e.Id_Nom_facultes inner join Promotion p on p.Id = e.Id_Nom_promotion
where e.Id= @id
end
GO
/****** Object:  StoredProcedure [dbo].[select_fac]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[select_fac]
as
begin
select * from Facultes
end
GO
/****** Object:  StoredProcedure [dbo].[Select_frais]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_frais]
as
begin
select f.Id,fac.Nom_facultes,p.Nom_promotion,f.Inscription,f.Tranche1,f.Tranche2,f.Tranche3 from Frais f
inner join Facultes fac on fac.Id = f.Id_Nom_facultes 
inner join Promotion p on p.Id = f.Id_Nom_promotion
end
GO
/****** Object:  StoredProcedure [dbo].[select_prom]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[select_prom]
as
begin
select * from Promotion
end
GO
/****** Object:  StoredProcedure [dbo].[Select_typeutilisateur]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_typeutilisateur]
as
begin
	select * from Typeutilisateurtb
end
GO
/****** Object:  StoredProcedure [dbo].[Select_typeutilisateurbyid]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_typeutilisateurbyid]
(@typeutilisateurid int)
as
begin
	select * from Typeutilisateurtb where Typeutilisateurid=@typeutilisateurid
end
GO
/****** Object:  StoredProcedure [dbo].[Select_utilisateur]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_utilisateur]
as 
begin
	select t.Nomtype,u.id, u.Noms, u.Nom_utilisateur, u.Numero_tel, u.Adresse_mail, u.Adresse from Utilisateur u 
	inner join Typeutilisateurtb t on t.Typeutilisateurid = u.Typeutilisateur_id
end
GO
/****** Object:  StoredProcedure [dbo].[Select_utilisateurbyid]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Select_utilisateurbyid]
(@utilisateurid int)
as
	
begin
	select t.Nomtype,u.id, u.Noms, u.Nom_utilisateur, u.Numero_tel, u.Adresse_mail, u.Adresse from Utilisateur u 
	inner join Typeutilisateurtb t on t.Typeutilisateurid = u.Typeutilisateur_id where u.id = @utilisateurid
end
GO
/****** Object:  StoredProcedure [dbo].[Upadate_typeutilisateur]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Upadate_typeutilisateur]
(@typeutilisateurid int=0,@nomtype varchar(20)='', @description varchar(100)='')
as
begin
	update Typeutilisateurtb set Nomtype = @nomtype, Description = @description where Typeutilisateurid =  @typeutilisateurid
end
GO
/****** Object:  StoredProcedure [dbo].[Upadate_utilisateur]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Upadate_utilisateur]
(@typeutilisateurid int,@noms varchar(20),@nom_utilisateur varchar(20),@motedepasse varchar(20),@numerotel varchar(20),@mail varchar(20),@adresse varchar(30))
as
begin
	update Utilisateur set Typeutilisateur_id = @typeutilisateurid, Noms = @noms, Nom_utilisateur = @nom_utilisateur,
	 Mot_de_passe = @motedepasse , Numero_tel = @numerotel, Adresse_mail = @mail, Adresse = @adresse where Id = @typeutilisateurid
	
end
GO
/****** Object:  StoredProcedure [dbo].[valide_payement]    Script Date: 16/10/2023 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[valide_payement]
(@id int, @montant varchar(250))
as
begin
declare @matricule varchar(50)
set @matricule = (select matricule from Etudiants where id = @id)
	insert into Payement (Id_Etudiant, Montant, Date_paye)values(@matricule, @montant, format(getDate(), 'yyyy/MM/d  H : m : ss'))
end

GO
USE [master]
GO
ALTER DATABASE [Payement_des_etudiants] SET  READ_WRITE 
GO
