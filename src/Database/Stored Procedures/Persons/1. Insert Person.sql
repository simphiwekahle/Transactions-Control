CREATE PROCEDURE [dbo].[InsertNewPerson]
	@code INT OUTPUT,
	@name VARCHAR(50),
	@surname VARCHAR(50),
	@id_number VARCHAR(50)
AS
BEGIN

    SET NOCOUNT ON;
    
    INSERT INTO [dbo].[Persons](
		[name],
		[surname],
		[id_number])
	VALUES(
		@name,
		@surname,
		@id_number);

	SET @code = SCOPE_IDENTITY();

END