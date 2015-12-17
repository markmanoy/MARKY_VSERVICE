 -- =============================================  
-- Author:  Manoy, Mark Andrew
-- Create date:   
-- Description: Updates Item.
-- Updated by: 
-- =============================================  
BEGIN  
INSERT INTO [dbo].[ItemInfo]
           ([Name]
           ,[Manufacturer]
           ,[Cost]
           ,[TypeId]
           ,[SubTypeId])
     VALUES
           (@Name
           ,@Manufacturer
           ,@Cost
           ,@TypeId
           ,@SubTypeId)
END  