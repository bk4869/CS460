--table

CREATE TABLE [dbo].[ApartRequestForms] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (20)  NOT NULL,
    [LastName]    NVARCHAR (20)  NOT NULL,
    [PhoneNumber] NVARCHAR (12)  NOT NULL,
    [ApartName]   NVARCHAR (MAX) NOT NULL,
    [Details]     NVARCHAR (MAX) NOT NULL,
    [UnitNum]     INT            NOT NULL,
    [Permission]  BIT            NOT NULL,
    [CurrTime]    DATETIME       NOT NULL,
    CONSTRAINT [PK_dbo.ApartRequestForms] PRIMARY KEY CLUSTERED ([ID] ASC)
);


insert INTO dbo.ApartRequestForms(FirstName, LastName, PhoneNumber, ApartName, Details, UnitNum, Permission, CurrTime)
VALUES 
 ('Tom','Cruise','503-345-1876','USA Apartment','Syndicate destroyed my apartment',9,1,'2016-5-18 15:29:19'),
 ('Fukuyama','Masaharu','516-786-5643','Japan Apartment','No Water',86,1,'2003-5-9 17:03:49'),
 ('Benedict','Cumberbatch','971-678-5209','UK Apartment','Moriarty is coming',82,0,'2011-11-11 11:11:11'),
 ('Yumin','Chen','626-818-7811','China Apartment','Earthquake destroyed my apartment',110,0,'2010-2-19 07:36:10')
