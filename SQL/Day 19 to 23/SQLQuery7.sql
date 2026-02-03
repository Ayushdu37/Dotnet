use College

Create table CustomerMaster(
	CustomerID int primary key,
	CustomerName varchar(100),
	CustomerPhone varchar(20),
	CustomerCity varchar(50)
)

Create table SalesPersonMaster(
	SalesPersonID int identity primary key,
	SalesPersonName varchar(100)
)

Create table ProductMaster(
	ProductId int identity primary key,
	ProductName varchar(100)
)

Create table OrderMaster(
	OrderId int primary key,
	OrderDate Date,
	CustomerID int,
	SalesPersonID int,
	foreign key (CustomerID) references CustomerMaster(CustomerID),
	foreign key (SalesPersonID) references SalesPersonMaster(SalesPersonID)
)

Create table OrderDetails(
	OrderDetailID INT IDENTITY PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice INT,
    FOREIGN KEY (OrderID) REFERENCES OrderMaster(OrderID),
    FOREIGN KEY (ProductID) REFERENCES ProductMaster(ProductID)
);

INSERT INTO CustomerMaster (CustomerID, CustomerName, CustomerPhone, CustomerCity)
VALUES 
(1,'Ravi Kumar', '9876543210', 'Chennai'),
(2,'Priya Sharma', '9123456789', 'Bangalore'),
(3,'John Peter', '9988776655', 'Hyderabad');

INSERT INTO SalesPersonMaster (SalesPersonName)
VALUES 
('Pavan'),
('Man'),
('Navneeth'),
('Raman');

INSERT INTO ProductMaster (ProductName)
VALUES 
('Laptop'),
('Mouse'),
('Keyboard'),
('Monitor');

INSERT INTO OrderMaster (OrderID, OrderDate, CustomerID, SalesPersonID)
VALUES
(101, '2024-01-05', 1, 1),
(102, '2024-01-06', 2, 1),
(103, '2024-01-10', 1, 2),
(104, '2024-02-01', 3, 1),
(105, '2024-02-10', 2, 2);

INSERT INTO OrderMaster (OrderID, OrderDate, CustomerID, SalesPersonID)
VALUES
(1, '2024-01-01', 1, 3), -- Pavan
(2, '2024-01-02', 1, 4), -- Man
(3, '2024-01-03', 1, 5), -- Navneeth
(4, '2024-01-04', 1, 6); -- Raman


INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES
(1, 1, 1, 55000),
(1, 2, 1, 10000);

INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES
(2, 1, 1, 10000),
(2, 2, 1, 800),
(2, 3, 2, 1200);

INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES
(3, 3, 1, 1200);

INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES
(4, 1, 1, 55000),
(4, 3, 1, 1200);
    


SELECT 
    o.OrderID,
    SUM(od.Quantity * od.UnitPrice) AS TotalSales
FROM OrderMaster o
JOIN OrderDetails od 
    ON o.OrderID = od.OrderID
GROUP BY o.OrderID
ORDER BY TotalSales DESC
OFFSET 2 ROWS
FETCH NEXT 1 ROW ONLY;

SELECT 
    sp.SalesPersonName,
    SUM(od.Quantity * od.UnitPrice) AS TotalSales
FROM SalesPersonMaster sp
JOIN OrderMaster o
    ON sp.SalesPersonID = o.SalesPersonID
JOIN OrderDetails od
    ON o.OrderID = od.OrderID
GROUP BY sp.SalesPersonName
HAVING SUM(od.Quantity * od.UnitPrice) > 60000;

SELECT DISTINCT
    UPPER(c.CustomerName) AS CustomerName,
    MONTH(o.OrderDate) AS OrderMonth
FROM OrderMaster o
JOIN CustomerMaster c
    ON o.CustomerID = c.CustomerID
WHERE 
    MONTH(o.OrderDate) = 1
    AND YEAR(o.OrderDate) = 2024;
