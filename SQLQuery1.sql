use Liblary
--DROP TABLE [Authors]

CREATE TABLE [Authors] (
	[id] INT IDENTITY PRIMARY KEY,
	[first_name] NVARCHAR(50) NOT NULL,
	[last_name] NVARCHAR(50) NOT NULL,
)
INSERT INTO [Authors] ([first_name], [last_name])
	VALUES (N'Лев',  N'Толстой'), (N'Айзек',  N'Азимов'), (N'Иван', N'Ефремов');

	Create table[Books](
	[id] INT IDENTITY PRIMARY KEY,
	[Title] NVARCHAR(50) NOT NULL,
	[Pages] int NOT NULL,
	[Publisher] NVARCHAR(50) NOT NULL,
	[Author_ID] int references Authors(id) NOT NULL,
	)
	INSERT INTO [Books]([Title], [Pages], [Publisher], [Author_ID])
	VALUES (N'qwer',  100, 'ыфв', 1), (N'qqq',  100, 'йцу', 1), (N'q2222',  100, 'ыпв', 2), (N'wwww',  100, 'ллл', 2), (N'eeee',  100, 'ддд', 3);