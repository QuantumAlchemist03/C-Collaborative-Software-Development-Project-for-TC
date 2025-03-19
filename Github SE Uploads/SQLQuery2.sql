CREATE TABLE Event(
    EventID INT PRIMARY KEY IDENTITY(1,1),
    EventName NVARCHAR(100),
    EventDate DATE,
    EventTime TIME,
    Description NVARCHAR(500)
);


