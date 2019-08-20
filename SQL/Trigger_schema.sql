-- Salary insert trigger --
IF (object_id('TGR_SALARY_INSERT', 'tr') IS NOT NULL)
    DROP TRIGGER TGR_SALARY_INSERT
GO

CREATE TRIGGER TGR_SALARY_INSERT   
ON [dbo].[Salary]   
FOR INSERT    
AS

DECLARE @Id BIGINT
SELECT @Id= id FROM inserted  
UPDATE [dbo].[Salary]  SET createOn = GETDATE()
WHERE id = @Id
GO

-- Salary update trigger -- 

IF (object_id('TGR_SALARY_UPDATE', 'tr') IS NOT NULL)
    DROP TRIGGER TGR_SALARY_UPDATE
GO

CREATE TRIGGER TGR_SALARY_UPDATE   
ON [dbo].[Salary]   
FOR UPDATE     
AS
DECLARE @Id BIGINT 
SELECT @Id =id FROM deleted
UPDATE [dbo].[Salary]  SET updateOn = GETDATE()
WHERE id = @Id
GO

-- User insert trigger 
IF (object_id('TGR_USER_INSERT', 'tr') IS NOT NULL)
    DROP TRIGGER TGR_USER_INSERT
GO

CREATE TRIGGER TGR_USER_INSERT   
ON [dbo].[User]   
FOR INSERT    
AS
DECLARE @Id BIGINT 
SELECT @Id = id FROM Inserted
UPDATE [dbo].[User]  SET createOn = GETDATE()
WHERE id = @Id
GO

-- Update user trigger -- 
IF (object_id('TGR_USER_UPDATE', 'tr') IS NOT NULL)
    DROP TRIGGER TGR_USER_UPDATE
GO

CREATE TRIGGER TGR_USER_UPDATE   
ON [dbo].[User]   
FOR UPDATE     
AS
DECLARE @Id BIGINT 
SELECT @Id = id FROM deleted
UPDATE [dbo].[User]  SET updateOn = GETDATE()
WHERE id = @Id
GO
