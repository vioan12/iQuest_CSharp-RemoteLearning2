CREATE DATABASE HotelReservations
GO
USE HotelReservations
CREATE TABLE Customer (  
    Id			INT				IDENTITY (1, 1) NOT NULL PRIMARY KEY,  
    Name		NVARCHAR(255)	NOT NULL,  
    Password 	NVARCHAR(255)	NOT NULL,
	Address		NVARCHAR(255)	NOT NULL
);  
GO  
CREATE TABLE Reservation (  
    Id				INT			IDENTITY (1, 1) NOT NULL PRIMARY KEY,  
    CustomerId		INT			NOT NULL FOREIGN KEY REFERENCES Customer(Id),  
    CheckInDate		DATETIME	NOT NULL,  
    CheckOutDate	DATETIME	NULL
);
GO
INSERT INTO Customer VALUES  
	(N'Toma Ciprian', N'ae6OQ5pnfdA=', N'1832 Johnstown Road'),
	(N'Preda Sofia', N'0JQPRys4RXw=', N'1895 Locust View Drive'),
	(N'Grigore Stoica', N'9dcSqLOACXU=', N'2754 Johnstown Road'),
	(N'Diaconescu David Alexandru', N'9dcSqLOACXU=', N'535 Richland Avenue'),
	(N'Mazilescu Lidia', N'0JQPRys4RXw=', N'1212 Johnstown Road');


GO
INSERT INTO Reservation VALUES  
		(1, '20120918 03:00:00 PM', '20120920 03:00:00 PM'),
		(3, '20180422 03:00:00 PM', '20180428 03:00:00 PM'),
		(2, '20180401 03:00:00 PM', '20180409 03:00:00 PM'),
		(4, '20180403 03:00:00 PM', '20180408 03:00:00 PM'),
		(4, '20180417 03:00:00 PM', '20180421 03:00:00 PM'),
		(5, '20180401 03:00:00 PM', '20180410 03:00:00 PM');
GO
SELECT * FROM Customer
GO
SELECT * FROM Reservation
GO