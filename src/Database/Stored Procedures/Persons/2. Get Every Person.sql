CREATE Procedure [dbo].[GetEveryPerson]
As

	SELECT
		[code],
		[name],
		[surname],
		[id_number]
	FROM
		[dbo].[Persons]