Delete from LineItem;
Delete from Invoice;
Delete from CustomerPayment;
Delete from ProductCategory;
Delete from Product;
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
`CustomerPaymentId` INTEGER NOT NULL,
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


--Insert into productcategory & customer before executed queries for test