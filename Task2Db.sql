CREATE TABLE Category
(
    Id   int PRIMARY KEY IDENTITY,
    Name nvarchar(255) NOT NULL
);

CREATE TABLE Product
(
    Id   int PRIMARY KEY IDENTITY,
    Name nvarchar(255) NOT NULL
);

CREATE TABLE ProductCategory
(
    ProductId  int,
    CategoryId int,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Product (Id),
    FOREIGN KEY (CategoryId) REFERENCES Category (Id)
);