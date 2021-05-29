DROP TABLE [Authors]
CREATE TABLE [Authors] (
	[id] INT IDENTITY PRIMARY KEY,
	[first_name] NVARCHAR(50) NOT NULL,
	[last_name] NVARCHAR(50) NOT NULL,
)
INSERT INTO [Authors] ([first_name], [last_name])
	VALUES (N'Лев',  N'Толстой'), (N'Айзек',  N'Азимов'), (N'Иван', N'Ефремов');