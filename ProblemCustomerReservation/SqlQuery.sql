CREATE DATABASE HotelReservations
GO
USE HotelReservations
CREATE TABLE Customer (  
    Id			INT				IDENTITY (1, 1) NOT NULL PRIMARY KEY,  
    FirstName	NVARCHAR(255)	NOT NULL,  
    LastName 	NVARCHAR(255)	NOT NULL
);  
GO  
CREATE TABLE Reservation (  
    Id           INT       IDENTITY (1, 1) NOT NULL PRIMARY KEY,  
    CustomerId   INT       NOT NULL FOREIGN KEY REFERENCES Customer(Id),  
    CheckInDate  DATETIME  NOT NULL,  
    CheckOutDate DATETIME  NULL
);
GO

INSERT INTO Customer VALUES  
	(N'Olivia', N'Stan'),
	(N'Razvan', N'Barbu'),
	(N'Grigore', N'Stoica'),
	(N'Lidia', N'Mazilescu'),
	(N'Sofia', N'Cristea');

GO
INSERT INTO Reservation VALUES  
		(1, '20120918 03:00:00 PM', '20120920 03:00:00 PM'),
		(3, '20180618 03:00:00 PM', ''),
		(2, '20170320 03:00:00 PM', '20170322 03:00:00 PM'),
		(4, '20120601 03:00:00 PM', ''),
		(4, '20180618 03:00:00 PM', '20180820 03:00:00 PM'),
		(5, '20180620 03:00:00 PM', '');
GO
SELECT * FROM Customer
GO
SELECT * FROM Reservation
GO