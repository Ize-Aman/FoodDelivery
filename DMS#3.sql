CREATE database CSDB;
USE CSDB;

--create the tables

-- Table: Customer
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
	UserName VARCHAR(30) UNIQUE NOT NULL,
	Password VARCHAR(10) NOT NULL,
    F_Name VARCHAR(100) NOT NULL CHECK (F_Name NOT LIKE '%[^a-zA-Z ]%'),
    L_Name VARCHAR(100) NOT NULL CHECK (L_Name NOT LIKE '%[^a-zA-Z ]%'),
    Phone VARCHAR(10) NOT NULL CHECK (LEN(Phone) = 10 AND Phone NOT LIKE '%[^0-9]%'),
    Email VARCHAR(100) Check (Email like '%_@__%.com'),
    Gender CHAR(1) NOT NULL CHECK (Gender IN ('M', 'F')),
    Address TEXT NOT NULL,
	UserType CHAR(1) NOT NULL CHECK(UserType IN ('C', 'A'))
);

select * from Users
where Gender = 'm';

-- Table: Restaurant
CREATE TABLE Restaurant (
    RestaurantID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL CHECK (Name NOT LIKE '%[^a-zA-Z ]%'),
    Location TEXT NOT NULL,
    Phone VARCHAR(10) NOT NULL CHECK (LEN(Phone) = 10 AND Phone NOT LIKE '%[^0-9]%')
);

-- Table: Menu (Weak Entity dependent on Restaurant)
CREATE TABLE Menu (
    MenuID INT NOT NULL IDENTITY(1,1),
    RestaurantID INT NOT NULL,
    Name VARCHAR(100) NOT NULL CHECK (Name NOT LIKE '%[^a-zA-Z ]%'),
    Price DECIMAL(6, 2),
    Description TEXT,
    PRIMARY KEY (MenuID, RestaurantID),
    FOREIGN KEY (RestaurantID) REFERENCES Restaurant(RestaurantID)
);

-- Table: [Order] (ORDER is a reserved key word)
CREATE TABLE [Order] (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT NULL,
    RestaurantID INT NOT NULL,
    TotalCost DECIMAL(6, 2),
    FOREIGN KEY (CustomerID) REFERENCES Users(UserID),
    FOREIGN KEY (RestaurantID) REFERENCES Restaurant(RestaurantID)
);

-- Table: Driver
CREATE TABLE Driver (
    DriverID INT PRIMARY KEY IDENTITY(1,1),
    F_Name VARCHAR(100) NOT NULL CHECK (F_Name NOT LIKE '%[^a-zA-Z ]%'),
    L_Name VARCHAR(100) NOT NULL CHECK (L_Name NOT LIKE '%[^a-zA-Z ]%'),
    Phone VARCHAR(10) NOT NULL CHECK (LEN(Phone) = 10 AND Phone NOT LIKE '%[^0-9]%'),
    Salary DECIMAL(7, 2)
);


-- Table: Vehicle (Weak Entity dependent on Driver)
CREATE TABLE Vehicle (
    VehicleID INT NOT NULL IDENTITY(1,1),
    DriverID INT NOT NULL,
    Name VARCHAR(100) NOT NULL CHECK (Name NOT LIKE '%[^a-zA-Z ]%'),
    PlateNumber VARCHAR(20) NOT NULL CHECK (LEN(PlateNumber) = 6 AND PlateNumber NOT LIKE '%[^0-9]%'),
    PRIMARY KEY (VehicleID, DriverID),
    FOREIGN KEY (DriverID) REFERENCES Driver(DriverID)
);

-- Table: Delivery
CREATE TABLE Delivery (
    DeliveryID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    DriverID INT NOT NULL,
    DeliveryTime DATETIME,
    Status VARCHAR(50) CHECK (Status IN ('Delivering', 'Delivered', 'Canceled', 'Not Paid')),
    FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
    FOREIGN KEY (DriverID) REFERENCES Driver(DriverID)
);

-- Junction Table: CustomerMenu
CREATE TABLE CustomerMenu (
    CustomerID INT NOT NULL,
    MenuID INT NOT NULL,
    RestaurantID INT NOT NULL,
    PRIMARY KEY (CustomerID, MenuID, RestaurantID),
    FOREIGN KEY (CustomerID) REFERENCES Users(UserID),
    FOREIGN KEY (MenuID, RestaurantID) REFERENCES Menu(MenuID, RestaurantID)
);

-- Junction Table: OrderMenu
CREATE TABLE OrderMenu (
    OrderID INT NOT NULL,
    MenuID INT NOT NULL,
    RestaurantID INT NOT NULL,
    PRIMARY KEY (OrderID, MenuID, RestaurantID),
    FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
    FOREIGN KEY (MenuID, RestaurantID) REFERENCES Menu(MenuID, RestaurantID)
);

-- Insert into Customer
INSERT INTO Users (UserName, Password, F_Name, L_Name, Phone, Email, Gender, Address, UserType) VALUES
('John', '0000', 'John', 'Doe', '1234567890', 'john.doe@gmail.com', 'M', '123 Main St', 'C'),
('Jane','0000', 'Jane', 'Smith', '0987654321', 'jane.smith@gmail.com', 'F', '456 Oak Ave','C'),
('Emily', '0000', 'Emily', 'Brown', '1122334455', 'emily.brown@gmail.com', 'F', '789 Maple Rd','c'),
('Michael', '0000', 'Michael', 'Johnson', '2233445566', 'michael.johnson@gmail.com', 'M', '321 Cedar Ln', 'c'),
('Sophia', '0000', 'Sophia', 'Davis', '3344556677', 'sophia.davis@gmail.com', 'F', '654 Birch Blvd', 'c'),
('Willson', '0000', 'David', 'Wilson', '4455667788', 'david.wilson@gmail.com', 'M', '987 Spruce St', 'c'),
('Olivia', '0000', 'Olivia', 'Martinez', '5566778899', 'olivia.martinez@gmail.com', 'F', '147 Palm Dr', 'c'),
('Ethan', '0000', 'Ethan', 'Clark', '6677889900', 'ethan.clark@gmail.com', 'M', '369 Aspen Rd', 'c'),
('Liam', '0000', 'Liam', 'Taylor', '7788990011', 'liam.taylor@gmail.com', 'M', '258 Pine St', 'c'),
('Emma', '0000', 'Emma', 'Anderson', '8899001122', 'emma.anderson@gmail.com', 'F', '147 Palm Dr', 'c');
select * from Users;

INSERT INTO Users(UserName, Password, F_Name, L_Name, Phone, Email, Gender, Address, UserType) VALUES
('Aman', '1', 'Ammanuel', 'Tesfahun', '0909090909', 'unknown@gmail.com', 'M', 'Somewhere', 'A'),
('Aymen', '2', 'Aymen', 'Abdo', '0909090909', 'unknown@gmail.com', 'M', 'Somewhere', 'A'),
('Henok', '3', 'Henok', 'Mesfin', '0909090909', 'unknown@gmail.com', 'F', 'Somewhere', 'A');

-- Insert into Restaurant
INSERT INTO Restaurant (Name, Location, Phone) VALUES
('Pizza Palace', '789 Elm St', '5551234567'),
('Sushi World', '456 Pine Rd', '5559876543'),
('Burger Town', '123 King St', '5551112222'),
('Taco Haven', '321 Queen St', '5552223333'),
('Pasta Paradise', '654 Prince Ave', '5553334444'),
('BBQ Bliss', '987 Duke St', '5554445555');

SELECT * from Restaurant;

-- Insert into Menu
INSERT INTO Menu (RestaurantID, Name, Price, Description) VALUES
(1, 'Margherita Pizza', 10.99, 'Classic pizza with fresh tomatoes and basil'),
(1, 'Pepperoni Pizza', 12.99, 'Spicy pepperoni and mozzarella cheese'),
(1, 'Veggie Pizza', 11.49, 'Loaded with fresh vegetables and cheese'),
(2, 'California Roll', 15.99, 'Fresh sushi roll with crab and avocado'),
(2, 'Dragon Roll', 18.99, 'Eel, cucumber, and avocado sushi roll'),
(2, 'Spicy Tuna Roll', 14.49, 'Tuna with spicy mayo and cucumber'),
(3, 'Cheeseburger', 8.99, 'Juicy beef patty with cheese and toppings'),
(3, 'Veggie Burger', 7.99, 'Grilled vegetable patty with lettuce and tomato'),
(3, 'Bacon Burger', 9.99, 'Beef patty topped with crispy bacon and cheese'),
(4, 'Beef Taco', 3.99, 'Seasoned beef in a soft tortilla'),
(4, 'Chicken Taco', 4.49, 'Grilled chicken with salsa and cheese'),
(5, 'Spaghetti Bolognese', 13.99, 'Pasta with a rich meat sauce'),
(5, 'Fettuccine Alfredo', 12.99, 'Creamy Alfredo sauce with fettuccine'),
(6, 'BBQ Ribs', 19.99, 'Tender ribs with smoky BBQ sauce'),
(6, 'Pulled Pork Sandwich', 10.99, 'Slow-cooked pork on a toasted bun');

SELECT * from Menu;

-- Insert into [Order]
INSERT INTO [Order] (CustomerID, RestaurantID, TotalCost) VALUES
(1, 1, 25.98),
(2, 2, 34.98),
(3, 3, 16.98),
(4, 4, 12.99),
(5, 5, 25.98),
(6, 6, 30.99),
(7, 1, 18.49),
(8, 2, 20.49),
(9, 3, 15.49),
(10, 4, 22.49);

SELECT * from [Order];

-- Insert into Driver
INSERT INTO Driver (F_Name, L_Name, Phone, Salary) VALUES
('Alex', 'Johnson', '5554443333', 3000.0),
('Jamie', 'Lee', '5556667777', 3200.0),
('Taylor', 'Green', '5558889999', 3100.0),
('Chris', 'White', '5559991111', 2800.0),
('Morgan', 'Black', '5550002222', 2900.0);

select * from Driver;


-- Insert into Vehicle
INSERT INTO Vehicle (DriverID, Name, PlateNumber) VALUES
(1, 'Toyota Prius', '123456'),
(2, 'Honda Civic', '654321'),
(3, 'Ford Transit', '789012'),
(4, 'Chevrolet Bolt', '345678'),
(5, 'Nissan Leaf', '901234');

select * from Vehicle;

-- Insert into Delivery
INSERT INTO Delivery (OrderID, DriverID, DeliveryTime, Status) VALUES
(1, 1, GETDATE(), 'Delivered'),
(2, 2, GETDATE(), 'Delivering'),
(3, 3, GETDATE(), 'Delivering'),
(4, 4, GETDATE(), 'Delivered'),
(5, 5, GETDATE(), 'Delivered'),
(6, 1, GETDATE(), 'Delivering'),
(7, 2, GETDATE(), 'Delivering'),
(8, 3, GETDATE(), 'Delivered'),
(9, 4, GETDATE(), 'Canceled'),
(10, 5, GETDATE(), 'Delivered');

select * from Delivery;

-- Insert into CustomerMenu
INSERT INTO CustomerMenu (CustomerID, MenuID, RestaurantID) VALUES
(1, 1, 1),
(1, 2, 1),
(2, 4, 2),
(2, 5, 2),
(3, 7, 3),
(3, 8, 3),
(4, 10, 4),
(5, 12, 5),
(6, 13, 5),
(7, 15, 6),
(8, 3, 1),
(9, 6, 2),
(10, 9, 3);

select * from CustomerMenu;
