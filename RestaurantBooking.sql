CREATE DATABASE RestaurantBooking
USE RestaurantBooking;
GO
/*
Created		12/25/2024
Modified		12/25/2024
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/


Create table [USER]
(
	[ID_USER] Char(5) NOT NULL, UNIQUE ([ID_USER]),
	[USERNAME] Varchar(100) NOT NULL, UNIQUE ([USERNAME]),
	[PASSWORD] Varchar(100) NOT NULL,
	[NAME] Nvarchar(255) NULL,
	[EMAIL] Varchar(100) NOT NULL, UNIQUE ([EMAIL]),
	[DATE] Datetime NULL,
	[BIO] Nvarchar(255) NULL,
	[PHONE] Char(15) NULL,
	[ADDRESS] Nvarchar(255) NULL,
	[GENDER] Char(10) NULL,
	[BIRTHDAY] Datetime NULL,
Primary Key ([ID_USER])
) 
go
Create table [RESTAURANT]
(
	[ID_RES] Char(10) NOT NULL, UNIQUE ([ID_RES]),
	[NAME] Nvarchar(100) NOT NULL,
	[LOCATION] Nvarchar(255) not null,
	[PHONE] Char(15) NOT NULL, UNIQUE ([PHONE]),
	[BIO] Nvarchar(255) NULL,
	[DETAIL] Nvarchar(255) NULL,
	[PRICE] Float NULL,
	[OPEN] Datetime NOT NULL,
	[CLOSE] Datetime NOT NULL,
Primary Key ([ID_RES])
) 
go

Create table [MENUITEM]
(
	[ID_ITEM] Integer NOT NULL, UNIQUE ([ID_ITEM]),
	[ITEM] Nvarchar(255) NOT NULL,
	[DESCRIPTION] Nvarchar(255) NULL,
	[PRICE] Float NOT NULL,
	[ID_RES] Char(10) NOT NULL,
Primary Key ([ID_ITEM])
) 
go

Create table [RESERVATION]
(
	[ID_RESERVATION] Integer NOT NULL, UNIQUE ([ID_RESERVATION]),
	[ID_USER] Char(5) NOT NULL,
	[DATE_RESERVATION] Datetime NULL,
	[NUMBERS_OF_GUEST] Integer NULL,
	[ID_SER] Integer NOT NULL,
	[NOTE] NVARCHAR(255),
Primary Key ([ID_RESERVATION],[ID_USER])
) 
go

Create table [SERVICE]
(
	[ID_SER] Integer NOT NULL, UNIQUE ([ID_SER]),
	[ID_RES] Char(10) NOT NULL,
	[NAME_SER] Nvarchar(255) NULL,
	[PRICE] Float NULL,
	[DESCRIPTION] Nvarchar(255) NULL,
Primary Key ([ID_SER])
) 
go

Create table [CANCELLATION]
(
	[ID_CAN] Integer NOT NULL, UNIQUE ([ID_CAN]),
	[DATE_CAN] Datetime NULL,
	[ID_RESERVATION] Integer NOT NULL,
	[ID_USER] Char(5) NOT NULL,
Primary Key ([ID_CAN],[ID_RESERVATION],[ID_USER])
) 
go
Create table [REVIEW]
(
    [ID_REVIEW] Integer NOT NULL, UNIQUE ([ID_REVIEW]),
    [ID_USER] Integer NOT NULL,
    [RATING] Integer NULL,
    [COMMENT] Nvarchar(255) NULL,
	[DATE_REVIEW] DATETIME,
    [ID_SER] Integer NOT NULL,
Primary Key ([ID_REVIEW])
) 
go

Alter table [RESERVATION] add  foreign key([ID_USER]) references [USER] ([ID_USER])  on update no action on delete no action 
go
Alter table [PAYMENT] add  foreign key([ID_USER]) references [USER] ([ID_USER])  on update no action on delete no action 
go
Alter table [MENUITEM] add  foreign key([ID_RES]) references [RESTAURANT] ([ID_RES])  on update no action on delete no action 
go
Alter table [SERVICE] add  foreign key([ID_RES]) references [RESTAURANT] ([ID_RES])  on update no action on delete no action 
go
Alter table [PAYMENT] add  foreign key([ID_RESERVATION],[ID_USER]) references [RESERVATION] ([ID_RESERVATION],[ID_USER])  on update no action on delete no action 
go
Alter table [CANCELLATION] add  foreign key([ID_RESERVATION],[ID_USER]) references [RESERVATION] ([ID_RESERVATION],[ID_USER])  on update no action on delete no action 
go
Alter table [RESERVATION] add  foreign key([ID_SER]) references [SERVICE] ([ID_SER])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go
-- Users (20 records)
INSERT INTO [USER] ([ID_USER], [USERNAME], [PASSWORD], [NAME], [EMAIL], [DATE], [BIO], [PHONE], [ADDRESS], [GENDER], [BIRTHDAY]) VALUES
('U0001', 'john_doe', 'pass123', 'John Doe', 'john@email.com', '2024-01-01', 'Food lover', '1234567890     ', '123 Main St', 'Male      ', '1990-05-15'),
('U0002', 'jane_smith', 'pass456', 'Jane Smith', 'jane@email.com', '2024-01-02', 'Foodie', '2345678901     ', '456 Oak Ave', 'Female    ', '1992-08-20'),
('U0003', 'mike_brown', 'pass789', 'Mike Brown', 'mike@email.com', '2024-01-03', 'Gourmet', '3456789012     ', '789 Pine Rd', 'Male      ', '1988-03-10'),
('U0004', 'sarah_wilson', 'pass321', 'Sarah Wilson', 'sarah@email.com', '2024-01-04', 'Chef', '4567890123     ', '321 Elm St', 'Female    ', '1995-11-25'),
('U0005', 'david_lee', 'pass654', 'David Lee', 'david@email.com', '2024-01-05', 'Food critic', '5678901234     ', '654 Maple Dr', 'Male      ', '1987-07-30'),
('U0006', 'lisa_wang', 'pass987', 'Lisa Wang', 'lisa@email.com', '2024-01-06', 'Food blogger', '6789012345     ', '987 Cedar Ln', 'Female    ', '1993-04-12'),
('U0007', 'tom_miller', 'pass147', 'Tom Miller', 'tom@email.com', '2024-01-07', 'Food enthusiast', '7890123456     ', '147 Birch Rd', 'Male      ', '1991-09-08'),
('U0008', 'emma_davis', 'pass258', 'Emma Davis', 'emma@email.com', '2024-01-08', 'Restaurant lover', '8901234567     ', '258 Pine St', 'Female    ', '1994-02-17'),
('U0009', 'alex_kim', 'pass369', 'Alex Kim', 'alex@email.com', '2024-01-09', 'Food explorer', '9012345678     ', '369 Oak Rd', 'Male      ', '1989-06-22'),
('U0010', 'amy_chen', 'pass741', 'Amy Chen', 'amy@email.com', '2024-01-10', 'Cuisine lover', '0123456789     ', '741 Maple St', 'Female    ', '1996-12-05'),
('U0011', 'peter_zhang', 'pass852', 'Peter Zhang', 'peter@email.com', '2024-01-11', 'Food adventurer', '1234567891     ', '852 Cedar Ave', 'Male      ', '1986-10-14'),
('U0012', 'sophie_lee', 'pass963', 'Sophie Lee', 'sophie@email.com', '2024-01-12', 'Restaurant explorer', '2345678902     ', '963 Elm Rd', 'Female    ', '1997-01-28'),
('U0013', 'ryan_wang', 'pass159', 'Ryan Wang', 'ryan@email.com', '2024-01-13', 'Food lover', '3456789013     ', '159 Birch St', 'Male      ', '1992-07-19'),
('U0014', 'olivia_chen', 'pass357', 'Olivia Chen', 'olivia@email.com', '2024-01-14', 'Foodie', '4567890124     ', '357 Pine Ave', 'Female    ', '1990-03-23'),
('U0015', 'william_liu', 'pass486', 'William Liu', 'william@email.com', '2024-01-15', 'Gourmet', '5678901235     ', '486 Oak Ln', 'Male      ', '1988-11-09'),
('U0016', 'emily_wu', 'pass729', 'Emily Wu', 'emily@email.com', '2024-01-16', 'Chef', '6789012346     ', '729 Maple Rd', 'Female    ', '1995-05-16'),
('U0017', 'kevin_zhou', 'pass153', 'Kevin Zhou', 'kevin@email.com', '2024-01-17', 'Food critic', '7890123457     ', '153 Cedar St', 'Male      ', '1993-08-27'),
('U0018', 'grace_lin', 'pass264', 'Grace Lin', 'grace@email.com', '2024-01-18', 'Food blogger', '8901234568     ', '264 Elm Ave', 'Female    ', '1991-04-30'),
('U0019', 'jason_yang', 'pass375', 'Jason Yang', 'jason@email.com', '2024-01-19', 'Food enthusiast', '9012345679     ', '375 Birch Ln', 'Male      ', '1987-12-11'),
('U0020', 'lucy_zhang', 'pass486', 'Lucy Zhang', 'lucy@email.com', '2024-01-20', 'Restaurant lover', '0123456780     ', '486 Pine Rd', 'Female    ', '1994-09-07');

-- Restaurants (20 records)
INSERT INTO [RESTAURANT] ([ID_RES], [NAME], [LOCATION], [PHONE], [BIO], [DETAIL], [PRICE], [OPEN], [CLOSE]) VALUES
('RES0000001', 'Golden Dragon', '123 Asian Street', '1111111111     ', 'Authentic Chinese cuisine', 'Traditional dishes', 50.00, '10:00', '22:00'),
('RES0000002', 'Bella Italia', '456 European Road', '2222222222     ', 'Italian fine dining', 'Pasta and pizza specialist', 75.00, '11:00', '23:00'),
('RES0000003', 'Sushi Master', '789 Japanese Ave', '3333333333     ', 'Premium sushi restaurant', 'Fresh seafood daily', 100.00, '11:30', '22:30'),
('RES0000004', 'Le Bistro', '321 French Street', '4444444444     ', 'Classic French cuisine', 'Romantic atmosphere', 120.00, '12:00', '23:00'),
('RES0000005', 'Taco Fiesta', '654 Mexican Road', '5555555555     ', 'Authentic Mexican food', 'Spicy specialties', 40.00, '10:30', '21:30'),
('RES0000006', 'Thai Orchid', '987 Thai Avenue', '6666666666     ', 'Traditional Thai cuisine', 'Spicy and aromatic', 55.00, '11:00', '22:00'),
('RES0000007', 'Mumbai Spice', '147 Indian Street', '7777777777     ', 'Indian restaurant', 'Rich curries', 60.00, '11:30', '22:30'),
('RES0000008', 'Seoul Kitchen', '258 Korean Road', '8888888888     ', 'Korean BBQ specialist', 'Traditional Korean', 80.00, '12:00', '23:00'),
('RES0000009', 'Mediterranean', '369 Greek Avenue', '9999999999     ', 'Mediterranean cuisine', 'Healthy options', 65.00, '11:00', '22:00'),
('RES0000010', 'Steakhouse', '741 American St', '1010101010     ', 'Premium steakhouse', 'Finest cuts', 150.00, '16:00', '23:00'),
('RES0000011', 'Dim Sum Palace', '852 Asian Road', '1212121212     ', 'Hong Kong style', 'Dim sum specialist', 45.00, '08:00', '20:00'),
('RES0000012', 'Pasta Paradise', '963 Italian Ave', '1313131313     ', 'Italian restaurant', 'Homemade pasta', 70.00, '11:30', '22:30'),
('RES0000013', 'Tokyo Ramen', '159 Japanese St', '1414141414     ', 'Ramen specialist', 'Authentic ramen', 35.00, '11:00', '21:00'),
('RES0000014', 'Paris Cafe', '357 French Road', '1515151515     ', 'French cafe', 'Pastries and coffee', 40.00, '08:00', '19:00'),
('RES0000015', 'Tequila Grill', '486 Mexican Ave', '1616161616     ', 'Mexican grill', 'Fresh ingredients', 55.00, '11:30', '22:30'),
('RES0000016', 'Bangkok Street', '729 Thai Street', '1717171717     ', 'Street food style', 'Authentic flavors', 45.00, '11:00', '22:00'),
('RES0000017', 'Curry House', '153 Indian Road', '1818181818     ', 'Indian cuisine', 'Various curries', 50.00, '11:30', '22:30'),
('RES0000018', 'BBQ King', '264 Korean Ave', '1919191919     ', 'Korean BBQ', 'Premium meat', 90.00, '16:00', '23:00'),
('RES0000019', 'Greek Islands', '375 Greek Street', '2020202020     ', 'Greek restaurant', 'Fresh seafood', 75.00, '11:00', '22:00'),
('RES0000020', 'Burger Joint', '486 American Rd', '2121212121     ', 'Gourmet burgers', 'Premium beef', 45.00, '11:00', '23:00');

-- Menu Items (4 items per restaurant = 80 records)
INSERT INTO [MENUITEM] ([ID_ITEM], [ITEM], [DESCRIPTION], [PRICE], [ID_RES]) VALUES
-- Golden Dragon (Chinese Restaurant)
(1, 'Kung Pao Chicken', 'Spicy diced chicken with peanuts', 18.99, 'RES0000001'),
(2, 'Dim Sum Platter', 'Assorted steamed dumplings', 24.99, 'RES0000001'),
(3, 'Peking Duck', 'Whole roasted duck with pancakes', 45.99, 'RES0000001'),
(4, 'Hot Pot', 'Traditional Chinese hot pot with broth', 35.99, 'RES0000001'),
(5, 'Mapo Tofu', 'Spicy tofu with minced pork', 16.99, 'RES0000001'),
(6, 'Spring Rolls', 'Crispy vegetable spring rolls', 12.99, 'RES0000001'),

-- Bella Italia (Italian Restaurant)
(7, 'Margherita Pizza', 'Classic tomato and mozzarella', 16.99, 'RES0000002'),
(8, 'Fettuccine Alfredo', 'Creamy pasta with parmesan', 19.99, 'RES0000002'),
(9, 'Osso Buco', 'Braised veal shanks with risotto', 32.99, 'RES0000002'),
(10, 'Tiramisu', 'Classic Italian coffee dessert', 9.99, 'RES0000002'),
(11, 'Lasagna', 'Layered pasta with meat sauce', 21.99, 'RES0000002'),
(12, 'Caprese Salad', 'Fresh mozzarella and tomatoes', 14.99, 'RES0000002'),

-- Sushi Master (Japanese Restaurant)
(13, 'Sushi Deluxe', 'Chefs selection of premium sushi', 35.99, 'RES0000003'),
(14, 'Dragon Roll', 'Eel and avocado special roll', 22.99, 'RES0000003'),
(15, 'Tempura Udon', 'Noodle soup with tempura', 18.99, 'RES0000003'),
(16, 'Sashimi Platter', 'Assorted fresh sashimi', 42.99, 'RES0000003'),
(17, 'Miso Black Cod', 'Grilled marinated black cod', 28.99, 'RES0000003'),
(18, 'Yakitori', 'Grilled chicken skewers', 15.99, 'RES0000003'),

-- Le Bistro (French Restaurant)
(19, 'Coq au Vin', 'Braised chicken in wine', 32.99, 'RES0000004'),
(20, 'Beef Bourguignon', 'Classic beef stew', 34.99, 'RES0000004'),
(21, 'French Onion Soup', 'Traditional onion soup', 12.99, 'RES0000004'),
(22, 'Ratatouille', 'Provençal vegetable dish', 24.99, 'RES0000004'),
(23, 'Crème Brûlée', 'Classic French dessert', 11.99, 'RES0000004'),
(24, 'Escargots', 'Garlic butter snails', 16.99, 'RES0000004'),

-- Taco Fiesta (Mexican Restaurant)
(25, 'Street Tacos', 'Authentic Mexican tacos', 14.99, 'RES0000005'),
(26, 'Enchiladas', 'Chicken enchiladas with mole', 16.99, 'RES0000005'),
(27, 'Guacamole', 'Fresh avocado dip', 9.99, 'RES0000005'),
(28, 'Chile Rellenos', 'Stuffed poblano peppers', 18.99, 'RES0000005'),
(29, 'Carne Asada', 'Grilled marinated steak', 22.99, 'RES0000005'),
(30, 'Churros', 'Mexican cinnamon dessert', 8.99, 'RES0000005'),

-- Thai Orchid (Thai Restaurant)
(31, 'Pad Thai', 'Classic noodle dish', 15.99, 'RES0000006'),
(32, 'Green Curry', 'Spicy coconut curry', 17.99, 'RES0000006'),
(33, 'Tom Yum Soup', 'Spicy and sour soup', 12.99, 'RES0000006'),
(34, 'Mango Sticky Rice', 'Sweet coconut dessert', 9.99, 'RES0000006'),
(35, 'Papaya Salad', 'Spicy green papaya salad', 11.99, 'RES0000006'),
(36, 'Satay Chicken', 'Grilled chicken skewers', 13.99, 'RES0000006'),

-- Mumbai Spice (Indian Restaurant)
(37, 'Butter Chicken', 'Creamy tomato curry', 18.99, 'RES0000007'),
(38, 'Biryani', 'Aromatic rice dish', 20.99, 'RES0000007'),
(39, 'Naan Bread', 'Fresh baked bread', 4.99, 'RES0000007'),
(40, 'Palak Paneer', 'Spinach with cheese', 16.99, 'RES0000007'),
(41, 'Tandoori Chicken', 'Clay oven roasted chicken', 19.99, 'RES0000007'),
(42, 'Gulab Jamun', 'Sweet milk balls', 6.99, 'RES0000007'),

-- Seoul Kitchen (Korean Restaurant)
(43, 'Bulgogi', 'Marinated beef BBQ', 24.99, 'RES0000008'),
(44, 'Bibimbap', 'Mixed rice bowl', 16.99, 'RES0000008'),
(45, 'Kimchi Stew', 'Spicy fermented cabbage stew', 15.99, 'RES0000008'),
(46, 'Korean Fried Chicken', 'Crispy glazed chicken', 18.99, 'RES0000008'),
(47, 'Seafood Pancake', 'Savory seafood pancake', 17.99, 'RES0000008'),
(48, 'Tteokbokki', 'Spicy rice cakes', 13.99, 'RES0000008'),

-- Mediterranean (Greek Restaurant)
(49, 'Moussaka', 'Layered eggplant dish', 19.99, 'RES0000009'),
(50, 'Greek Salad', 'Traditional vegetable salad', 12.99, 'RES0000009'),
(51, 'Souvlaki', 'Grilled meat skewers', 17.99, 'RES0000009'),
(52, 'Spanakopita', 'Spinach pie', 14.99, 'RES0000009'),
(53, 'Grilled Octopus', 'Tender grilled octopus', 25.99, 'RES0000009'),
(54, 'Baklava', 'Sweet phyllo dessert', 8.99, 'RES0000009'),

-- Steakhouse (American Steakhouse)
(55, 'Ribeye Steak', 'Prime grade beef', 45.99, 'RES0000010'),
(56, 'Lobster Tail', 'Grilled lobster', 49.99, 'RES0000010'),
(57, 'Creamed Spinach', 'Classic side dish', 11.99, 'RES0000010'),
(58, 'Mashed Potatoes', 'Creamy potatoes', 9.99, 'RES0000010'),
(59, 'Caesar Salad', 'Classic salad', 12.99, 'RES0000010'),
(60, 'Cheesecake', 'New York style', 10.99, 'RES0000010'),

-- Dim Sum Palace (Hong Kong Style)
(61, 'Har Gow', 'Shrimp dumplings', 8.99, 'RES0000011'),
(62, 'Siu Mai', 'Pork dumplings', 7.99, 'RES0000011'),
(63, 'BBQ Pork Buns', 'Steamed buns', 6.99, 'RES0000011'),
(64, 'Egg Tarts', 'Sweet pastry', 5.99, 'RES0000011'),
(65, 'Rice Rolls', 'Steamed rice rolls', 9.99, 'RES0000011'),
(66, 'Chicken Feet', 'Braised chicken feet', 7.99, 'RES0000011'),

-- Pasta Paradise (Italian)
(67, 'Carbonara', 'Classic pasta dish', 18.99, 'RES0000012'),
(68, 'Seafood Linguine', 'Mixed seafood pasta', 24.99, 'RES0000012'),
(69, 'Gnocchi', 'Potato dumplings', 17.99, 'RES0000012'),
(70, 'Risotto', 'Mushroom risotto', 19.99, 'RES0000012'),
(71, 'Bruschetta', 'Tomato appetizer', 11.99, 'RES0000012'),
(72, 'Panna Cotta', 'Italian dessert', 8.99, 'RES0000012'),

-- Tokyo Ramen (Japanese Ramen)
(73, 'Tonkotsu Ramen', 'Pork bone broth', 15.99, 'RES0000013'),
(74, 'Miso Ramen', 'Miso based soup', 14.99, 'RES0000013'),
(75, 'Gyoza', 'Pan-fried dumplings', 8.99, 'RES0000013'),
(76, 'Karaage', 'Japanese fried chicken', 12.99, 'RES0000013'),
(77, 'Rice Bowl', 'Topped with pork', 13.99, 'RES0000013'),
(78, 'Green Tea Ice Cream', 'Traditional dessert', 6.99, 'RES0000013'),

-- Paris Cafe (French Cafe)
(79, 'Croissant', 'Butter croissant', 4.99, 'RES0000014'),
(80, 'Quiche Lorraine', 'Savory tart', 12.99, 'RES0000014'),
(81, 'Pain au Chocolat', 'Chocolate pastry', 5.99, 'RES0000014'),
(82, 'French Toast', 'Classic breakfast', 11.99, 'RES0000014'),
(83, 'Croque Monsieur', 'Ham and cheese sandwich', 13.99, 'RES0000014'),
(84, 'Macarons', 'Assorted flavors', 8.99, 'RES0000014'),

-- Tequila Grill (Mexican Grill)
(85, 'Fajitas', 'Sizzling meat plate', 21.99, 'RES0000015'),
(86, 'Quesadillas', 'Cheese filled tortilla', 14.99, 'RES0000015'),
(87, 'Nachos Supreme', 'Loaded nachos', 16.99, 'RES0000015'),
(88, 'Fish Tacos', 'Grilled fish tacos', 17.99, 'RES0000015'),
(89, 'Burrito Bowl', 'Rice and beans bowl', 15.99, 'RES0000015'),
(90, 'Sopapillas', 'Mexican pastry', 7.99, 'RES0000015'),

-- Bangkok Street (Thai Street Food)
(91, 'Pad See Ew', 'Stir-fried noodles', 14.99, 'RES0000016'),
(92, 'Red Curry', 'Spicy coconut curry', 16.99, 'RES0000016'),
(93, 'Spring Rolls', 'Fresh rolls', 8.99, 'RES0000016'),
(94, 'Basil Chicken', 'Spicy stir-fry', 15.99, 'RES0000016'),
(95, 'Pineapple Fried Rice', 'Thai style rice', 16.99, 'RES0000016'),
(96, 'Thai Tea', 'Sweet milk tea', 4.99, 'RES0000016'),

-- Curry House (Indian Curry)
(97, 'Chicken Tikka', 'Tandoori chicken', 17.99, 'RES0000017'),
(98, 'Dal Makhani', 'Creamy lentils', 14.99, 'RES0000017'),
(99, 'Samosas', 'Stuffed pastries', 6.99, 'RES0000017'),
(100, 'Lamb Curry', 'Spicy lamb dish', 20.99, 'RES0000017'),
(101, 'Vegetable Korma', 'Mild curry', 15.99, 'RES0000017'),
(102, 'Mango Lassi', 'Yogurt drink', 4.99, 'RES0000017'),

-- BBQ King (Korean BBQ)
(103, 'Galbi', 'Marinated short ribs', 28.99, 'RES0000018'),
(104, 'Pork Belly', 'Grilled pork', 22.99, 'RES0000018'),
(105, 'Army Stew', 'Spicy soup', 24.99, 'RES0000018'),
(106, 'Stone Bowl Rice', 'Crispy rice bowl', 16.99, 'RES0000018'),
(107, 'Japchae', 'Glass noodles', 15.99, 'RES0000018'),
(108, 'Soju', 'Korean alcohol', 12.99, 'RES0000018'),

-- Greek Islands (Greek Restaurant)
(109, 'Grilled Lamb Chops', 'Herb marinated lamb', 29.99, 'RES0000019'),
(110, 'Seafood Platter', 'Mixed grilled seafood', 34.99, 'RES0000019'),
(111, 'Dolmades', 'Stuffed grape leaves', 12.99, 'RES0000019'),
(112, 'Greek Dips Trio', 'Assorted dips', 14.99, 'RES0000019'),
(113, 'Gyro Plate', 'Mixed meats', 18.99, 'RES0000019'),
(114, 'Greek Salad', 'Fresh vegetables with feta cheese', 10.99, 'RES0000019'),
--Burger Joint
(115, 'Classic Cheeseburger', 'Beef patty with cheddar cheese', 9.99, 'RES0000020'),
(116, 'Bacon Cheeseburger', 'Beef patty, bacon, and cheddar', 12.99, 'RES0000020'),
(117, 'Veggie Burger', 'Plant-based patty with lettuce and tomato', 11.49, 'RES0000020'),
(118, 'Double Patty Burger', 'Two beef patties with cheese and sauce', 14.99, 'RES0000020'),
(119, 'BBQ Burger', 'Beef patty with BBQ sauce and onion rings', 13.49, 'RES0000020'),
(120, 'Spicy Chicken Burger', 'Crispy chicken patty with spicy mayo', 10.99, 'RES0000020'),
(121, 'Mushroom Swiss Burger', 'Beef patty with Swiss cheese and mushrooms', 12.49, 'RES0000020'),
(122, 'Breakfast Burger', 'Beef patty, egg, and bacon', 13.99, 'RES0000020'),
(123, 'Loaded Fries', 'Fries topped with cheese, bacon, and sauce', 7.99, 'RES0000020'),
(124, 'Milkshake', 'Vanilla, chocolate, or strawberry', 5.49, 'RES0000020');


INSERT INTO [SERVICE] ([ID_SER], [ID_RES], [NAME_SER], [PRICE], [DESCRIPTION]) VALUES
(1, 'RES0000001', 'Private Room', 100.00, 'Private dining room for up to 10 people'),
(2, 'RES0000001', 'Chef Table', 150.00, 'Interactive dining with chef'),
(3, 'RES0000002', 'Outdoor Seating', 50.00, 'Comfortable outdoor dining area'),
(4, 'RES0000002', 'Wine Pairing', 120.00, 'Sommelier-selected wine pairings'),
(5, 'RES0000003', 'Kids Area', 30.00, 'Play area for kids'),
(6, 'RES0000003', 'Buffet Service', 80.00, 'All-you-can-eat buffet'),
(7, 'RES0000004', 'Takeaway', 20.00, 'Quick takeaway service'),
(8, 'RES0000004', 'Cocktail Bar', 70.00, 'Exclusive cocktails and drinks'),
(9, 'RES0000005', 'Parking Valet', 40.00, 'Secure parking valet service'),
(10, 'RES0000005', 'Group Discount', 60.00, 'Discount for groups of 10+'),
(11, 'RES0000006', 'Birthday Package', 100.00, 'Special birthday celebration setup'),
(12, 'RES0000006', 'Catering', 150.00, 'Off-site catering service'),
(13, 'RES0000007', 'Pet Friendly', 30.00, 'Pet-friendly dining area'),
(14, 'RES0000007', 'Free WiFi', 10.00, 'Unlimited high-speed WiFi'),
(15, 'RES0000008', 'Live Band', 120.00, 'Live music performance'),
(16, 'RES0000008', 'Open Bar', 150.00, 'Unlimited drinks for events'),
(17, 'RES0000009', 'Custom Menu', 90.00, 'Personalized menu for events'),
(18, 'RES0000009', 'Photography', 110.00, 'Professional event photography'),
(19, 'RES0000010', 'Decoration', 70.00, 'Themed decorations for events'),
(20, 'RES0000010', 'Kids Party', 50.00, 'Kids birthday party setup'),
(21, 'RES0000011', 'Exclusive Lounge', 200.00, 'Private lounge for VIP guests'),
(22, 'RES0000011', 'Wine Tasting', 130.00, 'Exclusive wine tasting experience'),
(23, 'RES0000012', 'Corporate Setup', 150.00, 'Corporate meeting setup'),
(24, 'RES0000012', 'High Tea', 90.00, 'Elegant high tea service'),
(25, 'RES0000013', 'Poolside Dining', 120.00, 'Dining by the pool'),
(26, 'RES0000013', 'Shuttle Service', 60.00, 'Transportation to/from restaurant'),
(27, 'RES0000014', 'Cooking Class', 100.00, 'Learn to cook signature dishes'),
(28, 'RES0000014', 'Table Games', 30.00, 'Board games at your table'),
(29, 'RES0000015', 'Custom Cake', 80.00, 'Personalized cakes for events'),
(30, 'RES0000015', 'DJ Night', 150.00, 'Live DJ performance'),
(31, 'RES0000016', 'Exclusive Dining', 180.00, 'Luxurious private dining'),
(32, 'RES0000016', 'Open Kitchen', 50.00, 'Watch the chefs at work'),
(33, 'RES0000017', 'Karaoke Room', 100.00, 'Private karaoke room'),
(34, 'RES0000017', 'Event Host', 120.00, 'Professional event hosting'),
(35, 'RES0000018', 'Rooftop Dining', 200.00, 'Scenic rooftop dining experience'),
(36, 'RES0000018', 'Special Menu', 90.00, 'Seasonal special menu'),
(37, 'RES0000019', 'Wine Cellar Access', 150.00, 'Exclusive wine cellar access'),
(38, 'RES0000019', 'Boat Dining', 300.00, 'Dine on a private boat'),
(39, 'RES0000020', 'Party Setup', 80.00, 'Birthday party decoration'),
(40, 'RES0000020', 'Live Music', 120.00, 'Live band performance');


-- Reservations (2 per user = 40 records)
INSERT INTO [RESERVATION] ([ID_RESERVATION], [ID_USER], [DATE_RESERVATION], [NUMBERS_OF_GUEST], [ID_SER])
VALUES
(1, 'U0001', '2024-01-20 18:00', 4, 1),
(2, 'U0001', '2024-02-01 19:00', 2, 3),
(3, 'U0002', '2024-01-15 20:00', 3, 5),
(4, 'U0002', '2024-03-10 18:30', 5, 8),
(5, 'U0003', '2024-01-25 19:00', 2, 10),
(6, 'U0003', '2024-02-15 20:00', 6, 12),
(7, 'U0004', '2024-02-05 18:00', 4, 14),
(8, 'U0004', '2024-02-20 19:30', 3, 16),
(9, 'U0005', '2024-01-28 19:00', 2, 18),
(10, 'U0005', '2024-03-02 20:00', 5, 20),
(11, 'U0006', '2024-01-18 18:00', 4, 22),
(12, 'U0006', '2024-03-08 19:00', 3, 24),
(13, 'U0007', '2024-02-12 19:30', 2, 26),
(14, 'U0007', '2024-02-22 20:00', 4, 28),
(15, 'U0008', '2024-01-30 18:00', 6, 30),
(16, 'U0008', '2024-03-05 19:00', 3, 32),
(17, 'U0009', '2024-02-10 19:30', 4, 34),
(18, 'U0009', '2024-02-25 18:00', 2, 36),
(19, 'U0010', '2024-01-15 19:00', 5, 38),
(20, 'U0010', '2024-02-20 20:00', 4, 40),
(21, 'U0011', '2024-01-25 18:00', 3, 2),
(22, 'U0011', '2024-03-01 19:30', 6, 4),
(23, 'U0012', '2024-02-15 20:00', 4, 6),
(24, 'U0012', '2024-02-28 18:00', 5, 8),
(25, 'U0013', '2024-01-20 19:00', 3, 10),
(26, 'U0013', '2024-03-10 20:00', 4, 12),
(27, 'U0014', '2024-02-18 18:30', 2, 14),
(28, 'U0014', '2024-02-25 19:30', 6, 16),
(29, 'U0015', '2024-01-22 20:00', 4, 18),
(30, 'U0015', '2024-03-05 18:00', 5, 20),
(31, 'U0016', '2024-01-30 19:00', 3, 22),
(32, 'U0016', '2024-03-15 19:30', 6, 24),
(33, 'U0017', '2024-02-08 18:00', 4, 26),
(34, 'U0017', '2024-02-28 19:00', 2, 28),
(35, 'U0018', '2024-01-18 19:30', 3, 30),
(36, 'U0018', '2024-03-02 20:00', 5, 32),
(37, 'U0019', '2024-02-15 18:00', 6, 34),
(38, 'U0019', '2024-02-20 19:00', 3, 36),
(39, 'U0020', '2024-02-10 19:30', 4, 38),
(40, 'U0020', '2024-02-25 20:00', 5, 40);


INSERT INTO [PAYMENT] ([ID_PAYMENT], [AMOUNT], [DATE_PAYMENT], [METHOD], [ID_RESERVATION], [ID_USER]) VALUES
(1, 250.00, '2024-01-20', 'C', 1, 'U0001'),
(2, 180.00, '2024-02-01', 'D', 2, 'U0001'),
(3, 220.00, '2024-01-15', 'C', 3, 'U0002'),
(4, 300.00, '2024-03-10', 'D', 4, 'U0002'),
(5, 150.00, '2024-01-25', 'C', 5, 'U0003'),
(6, 400.00, '2024-02-15', 'D', 6, 'U0003'),
(7, 240.00, '2024-02-05', 'C', 7, 'U0004'),
(8, 210.00, '2024-02-20', 'D', 8, 'U0004'),
(9, 130.00, '2024-01-28', 'C', 9, 'U0005'),
(10, 320.00, '2024-03-02', 'D', 10, 'U0005'),
(11, 180.00, '2024-01-18', 'C', 11, 'U0006'),
(12, 270.00, '2024-03-08', 'D', 12, 'U0006'),
(13, 190.00, '2024-02-12', 'C', 13, 'U0007'),
(14, 290.00, '2024-02-22', 'D', 14, 'U0007'),
(15, 350.00, '2024-01-30', 'C', 15, 'U0008'),
(16, 250.00, '2024-03-05', 'D', 16, 'U0008'),
(17, 200.00, '2024-02-10', 'C', 17, 'U0009'),
(18, 180.00, '2024-02-25', 'D', 18, 'U0009'),
(19, 220.00, '2024-01-15', 'C', 19, 'U0010'),
(20, 260.00, '2024-02-20', 'D', 20, 'U0010'),
(21, 300.00, '2024-01-25', 'C', 21, 'U0011'),
(22, 180.00, '2024-03-01', 'D', 22, 'U0011'),
(23, 250.00, '2024-02-15', 'C', 23, 'U0012'),
(24, 230.00, '2024-02-28', 'D', 24, 'U0012'),
(25, 190.00, '2024-01-20', 'C', 25, 'U0013'),
(26, 330.00, '2024-03-10', 'D', 26, 'U0013'),
(27, 280.00, '2024-02-18', 'C', 27, 'U0014'),
(28, 220.00, '2024-02-25', 'D', 28, 'U0014'),
(29, 310.00, '2024-01-22', 'C', 29, 'U0015'),
(30, 200.00, '2024-03-05', 'D', 30, 'U0015'),
(31, 230.00, '2024-01-30', 'C', 31, 'U0016'),
(32, 260.00, '2024-03-15', 'D', 32, 'U0016'),
(33, 180.00, '2024-02-08', 'C', 33, 'U0017'),
(34, 250.00, '2024-02-28', 'D', 34, 'U0017'),
(35, 240.00, '2024-01-18', 'C', 35, 'U0018'),
(36, 300.00, '2024-03-02', 'D', 36, 'U0018'),
(37, 320.00, '2024-02-15', 'C', 37, 'U0019'),
(38, 280.00, '2024-02-20', 'D', 38, 'U0019'),
(39, 320.00, '2024-02-15', 'C', 39, 'U0020'),
(40, 280.00, '2024-02-20', 'D', 40, 'U0020');


-- Cancellations (10 random cancellations)
INSERT INTO [CANCELLATION] ([ID_CAN], [DATE_CAN], [REFUND_AMOUNT], [ID_RESERVATION], [ID_USER]) VALUES
(1, '2024-01-19', 200.00, 1, 'U0001'),
(2, '2024-01-31', 150.00, 5, 'U0003'),
(3, '2024-02-05', 175.00, 10, 'U0005'),
(4, '2024-02-08', 225.00, 15, 'U0008'),
(5, '2024-02-10', 160.00, 20, 'U0010'),
(6, '2024-02-12', 190.00, 25, 'U0013'),
(7, '2024-02-14', 210.00, 30, 'U0015'),
(8, '2024-02-16', 180.00, 33, 'U0017'),
(9, '2024-02-18', 195.00, 36, 'U0018'),
(10, '2024-02-19', 205.00, 39, 'U0020');

SELECT DISTINCT NAME_SER AS NameService
FROM SERVICE
WHERE NAME_SER IS NOT NULL;