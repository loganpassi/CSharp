CREATE VIEW [dbo].[FullPerson]
	AS SELECT [p].[PersonId] as PersonId, [p].[FirstName], [p].[LastName],
			  [a].[Id] as AddressId, [a].[StreetAddress], [a].[City], [a].[State], [a].[ZipCode] 
	FROM dbo.Person p

	left join dbo.Address
	a on p.[PersonId] = a.PersonId
