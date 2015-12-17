 -- =============================================  
-- Author:  Manoy, Mark Andrew
-- Create date:   
-- Description: Adds Item.
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