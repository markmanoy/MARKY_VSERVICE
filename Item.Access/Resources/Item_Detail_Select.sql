 -- =============================================  
-- Author:  Manoy, Mark Andrew
-- Create date:   
-- Description: Selects Item by Id.
-- Updated by: 
-- =============================================  
SELECT TOP 1000 [Id]
      ,[Name]
      ,[Manufacturer]
      ,[Cost]
      ,[TypeId]
      ,[SubTypeId]
  FROM [MARKY_20151212].[dbo].[ItemInfo]
  WHERE Id = @Id