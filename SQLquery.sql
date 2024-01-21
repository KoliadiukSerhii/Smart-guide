-- Creating a SmartGuide database
CREATE DATABASE SmartGuide;
GO
USE SmartGuide;
GO

-- Users Table
CREATE TABLE Users (
    id INT PRIMARY KEY IDENTITY(1,1),
    email VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    isAdmin BIT NOT NULL
);

-- Locations Table
CREATE TABLE Locations (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255) NOT NULL,
    description TEXT
);

-- Point of Interest Table
CREATE TABLE PointOfInterest (
    id INT PRIMARY KEY IDENTITY(1,1),
    location_id INT REFERENCES Locations(id),
    name VARCHAR(255) NOT NULL,
    description TEXT,
    route VARCHAR(255),
    CONSTRAINT FK_Poi_Location FOREIGN KEY (location_id) REFERENCES Locations(id)
);

-- Routes Table
CREATE TABLE Routes (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255) NOT NULL,
    description TEXT,
    start_location INT REFERENCES Locations(id),
    end_location INT REFERENCES Locations(id),
    CONSTRAINT FK_Route_StartLocation FOREIGN KEY (start_location) REFERENCES Locations(id),
    CONSTRAINT FK_Route_EndLocation FOREIGN KEY (end_location) REFERENCES Locations(id)
);

-- Establishments Table
CREATE TABLE Establishments (
    id INT PRIMARY KEY IDENTITY(1,1),
    location_id INT REFERENCES Locations(id),
    name VARCHAR(255) NOT NULL,
    category VARCHAR(255),
    description TEXT,
    rating INT,
    CONSTRAINT FK_Establishment_Location FOREIGN KEY (location_id) REFERENCES Locations(id)
);

-- Reviews Table
CREATE TABLE Reviews (
    id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT REFERENCES Users(id),
    poi_id INT REFERENCES PointOfInterest(id),
    description TEXT,
    rating INT,
    CONSTRAINT FK_Review_User FOREIGN KEY (user_id) REFERENCES Users(id),
    CONSTRAINT FK_Review_Poi FOREIGN KEY (poi_id) REFERENCES PointOfInterest(id)
);
