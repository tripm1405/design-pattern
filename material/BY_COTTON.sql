-- Reset DATABASE
USE MASTER 
GO
DROP DATABASE IF EXISTS BY_COTTON 
GO
CREATE DATABASE BY_COTTON 
GO
USE BY_COTTON 
GO

-- CREATE TABLE
DROP TABLE IF EXISTS Product
GO
CREATE TABLE Product (
	code INT IDENTITY(1,1),
	name NVARCHAR(64),
	image VARCHAR(128),
	amount INT,
	price INT,

	CONSTRAINT PK_Product PRIMARY KEY (code)
) 
GO

DROP TABLE IF EXISTS Account
GO
CREATE TABLE Account (
	username VARCHAR(64),
	password VARCHAR(128),
	email VARCHAR(128),
	name NVARCHAR(64),
	gender BIT, -- (0: Female, 1: Male)
	address NVARCHAR(256),
	create_at DATETIME,

	CONSTRAINT PK_Account PRIMARY KEY (username)
)
GO

DROP TABLE IF EXISTS Customer 
GO
CREATE TABLE Customer (
	phone VARCHAR(16),
	account VARCHAR(64), -- Account.username

	CONSTRAINT PK_Customer PRIMARY KEY (phone)
)
GO

DROP TABLE IF EXISTS Invoice 
GO
CREATE TABLE Invoice (
	code INT,
	customer VARCHAR(16), -- Customer.code
	create_at DATETIME,

	CONSTRAINT PK_Invoice PRIMARY KEY (code)
)
GO

DROP TABLE IF EXISTS Refund
GO
CREATE TABLE Refund (
	code INT IDENTITY(1, 1),
	amount INT,
	price INT,
	create_at DATETIME,

	CONSTRAINT PK_Refund PRIMARY KEY (code)
)
GO

DROP TABLE IF EXISTS InvoiceDetail
GO
CREATE TABLE InvoiceDetail (
	code INT IDENTITY(1, 1),
	invoice INT, -- Invoice.code
	product INT, -- Product.code
	amount INT,
	price INT,
	refund INT,

	CONSTRAINT PK_InvoiceDetail PRIMARY KEY (invoice, product)
)
GO

-- CREATE FOREIGN KEY
ALTER TABLE Customer ADD
CONSTRAINT FK_Customer_Account FOREIGN KEY (account) REFERENCES Account(username)
GO

ALTER TABLE Invoice ADD
CONSTRAINT FK_Invoice_Customer FOREIGN KEY (customer) REFERENCES Customer(phone)
GO

ALTER TABLE InvoiceDetail ADD
CONSTRAINT FK_InvoiceDetail_Invoice FOREIGN KEY (invoice) REFERENCES Invoice(code),
CONSTRAINT FK_InvoiceDetail_Product FOREIGN KEY (product) REFERENCES Product(code),
CONSTRAINT FK_InvoiceDetail_Refund FOREIGN KEY (refund) REFERENCES Refund(code)
GO

-- CREATE TRIGGER
CREATE TRIGGER invoiceAdd
ON InvoiceDetail
AFTER INSERT
AS
BEGIN
	DECLARE @product INT, @amount INT;
	SET @product = (SELECT product FROM inserted);
	SET @amount = (SELECT amount FROM inserted);

	UPDATE Product
	SET amount = amount - @amount
	WHERE code = @product;
END
GO

DROP TRIGGER IF EXISTS refundAdd
GO

CREATE TRIGGER refundAdd
ON InvoiceDetail
AFTER UPDATE
AS
BEGIN
	DECLARE @refund INT, @product INT;
	SET @product = (SELECT product FROM inserted);
	SET @refund = (SELECT refund FROM inserted);

	IF (@refund IS NOT NULL)
	BEGIN
		DECLARE @amount INT;
		SET @amount = (SELECT amount FROM Refund WHERE code = @refund);

		UPDATE Product
		SET amount = amount + @amount
		WHERE code = @product;

		SELECT * FROM Refund WHERE code = @refund;
	END
END
GO

-- CREATE PROCEDURE
DROP PROC IF EXISTS invoiceInsert
GO
CREATE PROC invoiceInsert (@code INT, @customer VARCHAR(16))
AS
BEGIN
	INSERT INTO Invoice (code, customer, create_at) VALUES
	(@code, @customer, GETDATE());
END
GO

-- CREATE FUNCTION
DROP FUNCTION IF EXISTS turnover_d
GO
CREATE FUNCTION turnover_d(@d DATE)
RETURNS TABLE
AS
RETURN (
	SELECT ISNULL(SUM(amount * price), 0) as total
	FROM InvoiceDetail ID
	JOIN Invoice I ON I.code = ID.invoice
	WHERE create_at = @d
)
GO

DROP FUNCTION IF EXISTS turnover_s
GO
CREATE FUNCTION turnover_s(@s DATE, @e DATE)
RETURNS TABLE
AS
RETURN (
	SELECT ISNULL(SUM(amount * price), 0) as total
	FROM InvoiceDetail ID
	JOIN Invoice I ON I.code = ID.invoice
	WHERE create_at >= @s AND create_at < @e
)
GO

DROP FUNCTION IF EXISTS invoiceCreate
GO
CREATE FUNCTION invoiceCreate(@customer VARCHAR(16))
RETURNS INT
AS
BEGIN
	DECLARE @code INT;
	SET @code = (SELECT COUNT(*) FROM Invoice) + 1;

	EXEC invoiceInsert @code, @customer;

	RETURN @code;
END
GO

DROP FUNCTION IF EXISTS getAccountByUsername
GO
CREATE FUNCTION getAccountByUsername(@username VARCHAR(64))
RETURNS TABLE
RETURN (
	SELECT * 
	FROM Account 
	WHERE username = @username
)
GO

-- INSERT DATA
INSERT INTO Product(name, image, amount, price) VALUES
(N'Quần da', 'quan-da.png', 3, 2000000),
(N'Áo ba lỗ', 'ao-ba-lo.png', 12, 35000),
(N'Áo len', 'ao-len.png', 5, 190000),
(N'Quần jean', 'quan-jean.png',14, 140000),
(N'Mũ vành', 'mu-vanh.png', 24, 40000),
(N'Giày da lộn', 'giay-da-lon.png', 6, 520000),
(N'Túi giấy', 'tui-giay.png',34, 20000),
(N'Găng hở ngón', 'gang-ho-ngon.png',8, 60000),
(N'Tất ngắn', 'tat-ngan.png', 18, 30000),
(N'Khăn choàng', 'khan-choang.png', 5, 170000)
GO

INSERT INTO Account(username, password, name, email, gender, address, create_at) VALUES
('tranthanhlam', '123456', N'Trần Thanh Lâm', 'lam.tran.15@gmail.com', 1, N'213 Trần Tuấn Khải, Phường 7, District 5, Ho Chi Minh City', '2022/11/06 16:27'),
('nguyenthianhtuyet', '123456', N'Nguyễn Thị Ánh Tuyết', NULL, 0, N'23 Đường Nguyễn Hữu Thọ, Khu đô thị Sunrise City, Tân Hưng, District 7, Ho Chi Minh City', '2022/11/07 07:14'),
('lenhatnam', '123456', N'Lê Nhật Nam', NULL, 1, N'76 Lê Lai, Bến Thành, District 1, Ho Chi Minh City', '2022/11/07 13:43')
GO

INSERT INTO Customer(account, phone) VALUES
('tranthanhlam', '0956235124'),
(NULL, '03326584958'),
('nguyenthianhtuyet', '0851236548'),
('lenhatnam', '0954812563'),
(NULL, '03326532549')
GO

INSERT INTO Invoice(code, customer, create_at) VALUES
(1, '0956235124', '2022/11/06 17:53'),
(2, '03326584958', '2022/11/06 20:26'),
(3, '0851236548', '2022/11/07 11:32'),
(4, '03326532549', '2022/11/08 15:12')
GO

INSERT INTO Refund(amount, price, create_at) VALUES
(1, 35000, '2022/11/10 11:28')
GO

INSERT INTO InvoiceDetail(invoice, product, amount, price, refund) VALUES
(1, 1, 1, 2200000, NULL)
GO
INSERT INTO InvoiceDetail(invoice, product, amount, price, refund) VALUES
(1, 8, 1, 66000, NULL)
GO
INSERT INTO InvoiceDetail(invoice, product, amount, price, refund) VALUES
(2, 3, 1, 209000, NULL)
GO
INSERT INTO InvoiceDetail(invoice, product, amount, price, refund) VALUES
(3, 5, 2, 44000, NULL)
GO
INSERT INTO InvoiceDetail(invoice, product, amount, price, refund) VALUES
(3, 8, 1, 66000, NULL)
GO
INSERT INTO InvoiceDetail(invoice, product, amount, price, refund) VALUES
(3, 9, 1, 33000, NULL)
GO
INSERT INTO InvoiceDetail(invoice, product, amount, price, refund) VALUES
(4, 2, 1, 38500, 1)
GO