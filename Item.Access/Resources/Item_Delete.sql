 -- =============================================  
-- Author:  Manoy, Mark Andrew
-- Create date:   
-- Description: Updates Item.
-- Updated by: 
-- =============================================  
BEGIN  
SELECT TOP 1000 [Id]
      ,[Name]
      ,[Manufacturer]
      ,[Cost]
      ,[TypeId]
      ,[SubTypeId]
  FROM [MARKY_20151212].[dbo].[ItemInfo]
  WHERE Id = @Id
END  