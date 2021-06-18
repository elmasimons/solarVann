CREATE TABLE dbo.solardetails (
    Id int IDENTITY(1,1) PRIMARY KEY,
    ProviderName varchar(255),
    AvilabilityStatus varchar(255),
    Latitude float,
	Longitude float,
	Pincode int,
	Cost bigint,
	SoalrUnitVoltage varchar(255,
	Module varchar(255,
	Place varchar(255),
	Quantity int,
    Capacity 	 varchar(255)
);
##Insert Script
INSERT INTO dbo.solardetails (ProviderName,AvilabilityStatus,Latitude,Longitude,Pincode,Cost,SoalrUnitVoltage,Module,Place,Quantity,Capacity)
                           VALUES ('TATA Power Solar','Yes',22.3539,88.7833,700028,20000,'2 KVA','4 nos Modules of 320Wp each','Dumdum',2,'1,400 units annually');