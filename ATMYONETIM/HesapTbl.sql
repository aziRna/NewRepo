CREATE TABLE [dbo].[HesapTbl] (
    [HesapNo] INT          NOT NULL,
    [Isim]    VARCHAR (50) NOT NULL,
    [Soyisim] VARCHAR (50) NOT NULL,
    [Dogum]   VARCHAR (50) NOT NULL,
    [Telefon] VARCHAR (50) NOT NULL,
    [Adres]   VARCHAR (50) NOT NULL,
    [Egitim]  VARCHAR (50) NOT NULL,
    [Meslek]  VARCHAR (50) NOT NULL,
    [Pin]     INT          NOT NULL,
    [Bakiye]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([HesapNo] ASC)
);

