use inventoryDB;

select * from Users;

drop table Products;

CREATE TABLE Products
(
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50),
    CostPrice DECIMAL(10,2),
    SellingPrice DECIMAL(10,2),
    Quantity INT,
    ReorderLevel INT,
    Status NVARCHAR(20),
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(30) NOT NULL,   -- e.g. Staff, Cashier
    Phone NVARCHAR(20),
    Status NVARCHAR(20),          -- Active / Inactive
    CreatedAt DATETIME DEFAULT GETDATE()
);
