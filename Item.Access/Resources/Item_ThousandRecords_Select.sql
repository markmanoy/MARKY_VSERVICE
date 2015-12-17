 -- =============================================  
-- Author:  Manoy, Mark Andrew
-- Create date:   
-- Description: Select Items.
-- Updated by: 
-- =============================================  
SELECT TOP 1000 [Id]
      ,[Name]
      ,[Manufacturer]
      ,[Cost]
      ,[TypeId]
      ,[SubTypeId]
  FROM [MARKY_20151212].[dbo].[ItemInfo]
  WHERE NAME LIKE '%' + @Name + '%'
  ORDER BY ID