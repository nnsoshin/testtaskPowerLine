
CREATE TABLE `customers` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `customers` VALUES (1,'Max'),(2,'Pavel'),(3,'Ivan'),(4,'Leonid');

CREATE TABLE `orders` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CustomerId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `customer_fk_idx` (`CustomerId`),
  CONSTRAINT `customer_fk` FOREIGN KEY (`CustomerId`) REFERENCES `customers` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `orders` VALUES (1,2),(2,4);

SELECT Customers.Name FROM Customers left join Orders on(Orders.CustomerId = Customers.Id) group by Customers.Id HAVING count(Orders.CustomerId) = 0;

