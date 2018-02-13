Delete from LineItem;
Delete from Invoice;
Delete from CustomerPayment;
Delete from Product;
Delete from ProductCategory;
Delete from Customer;

DROP TABLE LineItem;
DROP TABLE Invoice;
DROP TABLE CustomerPayment;
DROP TABLE ProductCategory;
DROP TABLE Product;
DROP TABLE Customer;

CREATE TABLE `LineItem` (
`LineItemId` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
`InvoiceId` INTEGER NOT NULL,
`ProductId` INTEGER NOT NULL,
FOREIGN KEY (`InvoiceId`) REFERENCES `Invoice`(`InvoiceId`),
FOREIGN KEY (`ProductId`) REFERENCES `Product`(`ProductId`)
);


CREATE TABLE `Invoice` (
`InvoiceId` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
`CustomerId` INTEGER NOT NULL,
`CustomerPaymentId` INTEGER,
`InvoiceDate`  TEXT NOT NULL,
FOREIGN KEY (`CustomerId`) REFERENCES `Customer`(`CustomerId`),
FOREIGN KEY (`CustomerPaymentId`) REFERENCES `CustomerPayment`(`CustomerPaymentId`)
);

CREATE TABLE `CustomerPayment` (
`CustomerPaymentId` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
`CustomerId` INTEGER NOT NULL,
`Account` INTEGER NOT NULL,
`PaymentTypeName`  TEXT NOT NULL,
FOREIGN KEY (`CustomerId`) REFERENCES `Customer`(`CustomerId`)
);

CREATE TABLE `ProductCategory` (
`ProductCategoryId` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
`CategoryName` INTEGER NOT NULL
);


CREATE TABLE `Product` (
`ProductId` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
`Title` TEXT NOT NULL,
`Description` TEXT NOT NULL,
`Price`   INTEGER NOT NULL,
`Quantity`   INTEGER NOT NULL,
`ProductCategoryId` INTEGER NOT NULL,
`CustomerId` INTEGER NOT NULL,
`DateCreated`   TEXT NOT NULL,
FOREIGN KEY (`CustomerId`) REFERENCES `Customer`(`CustomerId`),
FOREIGN KEY (`ProductCategoryId`) REFERENCES `ProductCategory`(`ProductCategoryId`)

);


CREATE TABLE `Customer` (
`CustomerId` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
`FirstName` TEXT NOT NULL,
`LastName` TEXT NOT NULL,
`StreetAddress`   TEXT NOT NULL,
`City`   TEXT NOT NULL,
`State` TEXT NOT NULL,
`Zip` TEXT NOT NULL,
`Phone` TEXT NOT NULL
);


INSERT INTO Customer VALUES(null,'Tim', 'Mit', '100 a street','Nashville', 'TN', '456764','1122234321' );
INSERT INTO CustomerPayment VALUES(null,1,897654,'Amex');
INSERT INTO Invoice VALUES(null,1,1,'02/12/2018');
INSERT INTO ProductCategory VALUES(null, 'Lawn Care');
INSERT INTO Product VALUES(null,'Hand Shovel', 'Plastic handle', 4.99, 10,1,1,'02/01/2018');
INSERT INTO LineItem VALUES(null,1,1);


INSERT INTO Customer VALUES(null,'Lee', 'Walt', '10 ab street','Nashville', 'TN', '8378378','8792234321' );
INSERT INTO Customer VALUES(null,'Jean-Luc', 'Picard', '101 b street','Memphis', 'TN', '87909922','6198675309' );
INSERT INTO Customer VALUES(null,'Jimmy', 'John', '204 c street','Denver', 'CO', '99800733','7198839203' );
INSERT INTO Customer VALUES(null,'Marcus', 'Aurelius', '788 River Road','Atlanta', 'GA', '99800733','7198839203' );
INSERT INTO Customer VALUES(null,'John', 'Johnston', '79001 Twin blvd','Dover', 'DE', '49850763','4178837303' );



INSERT INTO CustomerPayment VALUES(null,1,897654,'Amex');
INSERT INTO CustomerPayment VALUES(null,1,897654,'Visa');
INSERT INTO CustomerPayment VALUES(null,2,976809,'Mastercard');
INSERT INTO CustomerPayment VALUES(null,2,976809,'Visa');
INSERT INTO CustomerPayment VALUES(null,3,276390,'Mastercard');
INSERT INTO CustomerPayment VALUES(null,3,276390,'Amex');
INSERT INTO CustomerPayment VALUES(null,4,342619,'Amex');
INSERT INTO CustomerPayment VALUES(null,4,342619,'Mastercard');
INSERT INTO CustomerPayment VALUES(null,5,767688,'Visa');
INSERT INTO CustomerPayment VALUES(null,5,767688,'Amex');




INSERT INTO Invoice VALUES(null,2,2,'02/08/2018');
INSERT INTO Invoice VALUES(null,3,null,'02/04/2018');
INSERT INTO Invoice VALUES(null,4,2,'02/03/2018');
INSERT INTO Invoice VALUES(null,5,1,'02/02/2018');
INSERT INTO Invoice VALUES(null,5,null,'06/02/2017');
INSERT INTO Invoice VALUES(null,5,1,'05/02/2017');



INSERT INTO ProductCategory VALUES(null, 'Kitchen');
INSERT INTO ProductCategory VALUES(null, 'Furniture');




INSERT INTO Product VALUES(null,'Shovel', '5foot', 9.99, 10,1,1,'02/01/2018');
INSERT INTO Product VALUES(null,'Lawn Mower', 'Good for cutting grass', 85.99, 5,1,1,'01/01/2017');
INSERT INTO Product VALUES(null,'Cutting Board', 'Good to cut on', 3.99, 50,2,2,'01/21/2017');
INSERT INTO Product VALUES(null,'Utensil Set', 'Full set, knives, spoons, forks', 12.99, 30,2,2,'3/03/2017');
INSERT INTO Product VALUES(null,'Couch', 'Furry and comfy', 120.99, 3,3,3,'01/25/2018');
INSERT INTO Product VALUES(null,'Chair', 'To sit on', 16.50,15,3,3,'02/01/2018');
INSERT INTO Product VALUES(null,'Garden Fencing', '4 foot', 12.50, 30,1,4,'11/15/2017');
INSERT INTO Product VALUES(null,'Lemon Juicer', 'Perfect for orange juice and lemonade', 2.50, 100,2,4,'02/01/2018');
INSERT INTO Product VALUES(null,'Spatula', 'Plastic', 8.50, 60,3,5,'10/01/2017');
INSERT INTO Product VALUES(null,'Ladel', 'Plastic', 7.99, 50,3,5,'12/01/2017');



INSERT INTO LineItem VALUES(null,1,2);
INSERT INTO LineItem VALUES(null,1,3);
INSERT INTO LineItem VALUES(null,2,4);
INSERT INTO LineItem VALUES(null,2,5);
INSERT INTO LineItem VALUES(null,2,6);
INSERT INTO LineItem VALUES(null,3,6);
INSERT INTO LineItem VALUES(null,3,7);
INSERT INTO LineItem VALUES(null,4,7);
INSERT INTO LineItem VALUES(null,4,8);
INSERT INTO LineItem VALUES(null,5,8);
INSERT INTO LineItem VALUES(null,5,9);
INSERT INTO LineItem VALUES(null,5,9);
INSERT INTO LineItem VALUES(null,5,10);
INSERT INTO LineItem VALUES(null,5,8);
INSERT INTO LineItem VALUES(null,3,5);
INSERT INTO LineItem VALUES(null,3,10);
INSERT INTO LineItem VALUES(null,2,4);
INSERT INTO LineItem VALUES(null,2,3);
INSERT INTO LineItem VALUES(null,1,1);



























