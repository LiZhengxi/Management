-- Salary insert trigger --
IF (object_id('TGR_SALARY_INSERT', 'tr') is not null)
    DROP TRIGGER TGR_SALARY_INSERT
GO

CREATE TRIGGER TGR_SALARY_INSERT   
ON [dbo].[Salary]   
FOR INSERT    
AS
UPDATE [dbo].[Salary]  SET createOn = GETDATE()
GO

-- Salary update trigger -- 

IF (object_id('TGR_SALARY_UPDATE', 'tr') is not null)
    DROP TRIGGER TGR_SALARY_UPDATE
GO

CREATE TRIGGER TGR_SALARY_UPDATE   
ON [dbo].[Salary]   
FOR UPDATE     
AS
UPDATE [dbo].[Salary]  SET updateOn = GETDATE()
GO

-- User insert trigger 
IF (object_id('TGR_USER_INSERT', 'tr') is not null)
    DROP TRIGGER TGR_USER_INSERT
GO

CREATE TRIGGER TGR_USER_INSERT   
ON [dbo].[User]   
FOR INSERT    
AS
UPDATE [dbo].[User]  SET createOn = GETDATE()
GO

-- Update user trigger -- 
IF (object_id('TGR_USER_UPDATE', 'tr') is not null)
    DROP TRIGGER TGR_USER_UPDATE
GO

CREATE TRIGGER TGR_USER_UPDATE   
ON [dbo].[User]   
FOR UPDATE     
AS
UPDATE [dbo].[User]  SET updateOn = GETDATE()
GO
