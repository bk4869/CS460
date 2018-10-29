--table

CREATE TABLE [dbo].[ApartRequestForms]
(
	[ID]		INT IDENTITY (1,1)	NOT NULL,
	[FirstName]	NVARCHAR(64)		NOT NULL,
	[LastName]	NVARCHAR(128)		NOT NULL,
	[PhoneNumber] NVARCHAR(13)		NOT NULL,
	[ApartName] NVARCHAR(128)		NOT NULL,
	[UnitNum]   INT					NOT NULL,
	[Permission] BIT				NOT NULL,
	[CurrTime]	DateTime			NOT NULL,
	CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED ([ID] ASC)
);


INSERT INTO dbo.ApartRequestForms(FirstName, LastName, PhoneNumber, ApartName, UnitNum, Permission, CurrTime) 
VALUES
 ('Yumin','Chen','6268187811','China Apartment',110,0,'2010-2-19 07:36:10'),
 ('Tom','Cruise','5033451876','USA Apartment',9,1,'2016-5-18 15:29:19'),
 ('Fukuyama','Masaharu','5167865643','Japan Apartment',86,1,'2003-5-9 17:03:49'),
 ('Benedict','Cumberbatch','9716785209','UK Apartment',82,0,'2011-11-11 11:11:11')
