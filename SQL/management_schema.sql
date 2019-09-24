
-- Please don't change the order of the table delete  -- 

IF EXISTS ((SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'User') )
BEGIN
DROP TABLE [User]
END 


IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Revenue')
BEGIN 
DROP  TABLE REVENUE
END

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Salary')
BEGIN
ALTER TABLE [Salary] DROP CONSTRAINT [FK_Salary_Employee]
DROP TABLE [Salary]
END

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Employee')
BEGIN
ALTER TABLE [Employee] DROP CONSTRAINT [FK_Employee_Altelier]
DROP TABLE [Employee]
END

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Department_Altelier')
BEGIN
ALTER TABLE [Department_Altelier] DROP CONSTRAINT [FK_Department_Altelier_Department]
ALTER TABLE [Department_Altelier] DROP CONSTRAINT [FK_Department_Altelier_Altelier]
DROP TABLE [Department_Altelier]
END

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Altelier')
BEGIN
DROP TABLE [Altelier]
END

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Department') 
BEGIN 
DROP TABLE DEPARTMENT 
END 


CREATE TABLE [User](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[createBy] [bigint] NULL,
	[createOn] [datetime] NULL,
	[updateBy] [bigint] NULL, 
	[updateOn] [datetime] NULL,  
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[authority] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [Revenue](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[createBy] [bigint] NULL,
	[createOn] [datetime] NULL,
	[updateBy] [bigint] NULL, 
	[updateOn] [datetime] NULL,  
	[year] [int] NOT NULL,
	[month] [int] NOT NULL,
	[number] [bigint] NULL,
	[regularWorkingTime][float],
 CONSTRAINT [PK_Revenue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [Department](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[department_name] [nchar](10) NULL,
	[isWorkshop] [bit] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[Altelier](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[alterlier_name] [nchar](10) NOT NULL,
	[alterlier_propotion] [float] NULL,
 CONSTRAINT [PK_Altelier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Department_Altelier](
	[id][bigint] IDENTITY(1,1) NOT NULL,
	[department_id][bigint] NOT NULL,
	[altelier_id][bigint] NOT NULL,
	 CONSTRAINT [PK_Department_Altelier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY] 
ALTER TABLE [dbo].[Department_Altelier]  WITH CHECK ADD  CONSTRAINT [FK_Department_Altelier_Department] FOREIGN KEY([department_id])
REFERENCES [dbo].[Department] ([id])
ON DELETE CASCADE
ALTER TABLE [dbo].[Department_Altelier]  WITH CHECK ADD  CONSTRAINT [FK_Department_Altelier_Altelier] FOREIGN KEY([altelier_id])
REFERENCES [dbo].[Altelier] ([id])
ON DELETE CASCADE


CREATE TABLE [dbo].[Employee](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[altelier_id] [bigint] NOT NULL,
	[employee_name] [nchar](10) NOT NULL,
	[haveDorm] [bit], 
	[haveSeniorityPay][float],
	[haveTransportAllowance][bit],
	[havePaySocialSecurity][bit],
	[isTeamLeader][bit]
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Altelier] FOREIGN KEY([altelier_id])
REFERENCES [dbo].[Altelier] ([id])
ON DELETE CASCADE

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Altelier]


CREATE TABLE [dbo].[Salary](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[createBy] [bigint] NULL,
	[createOn] [datetime] NULL,
	[updateBy] [bigint] NULL, 
	[updateOn] [datetime] NULL,  
	[year] [int] NOT NULL,
	[month] [int] NOT NULL,
	[employee_id] [bigint] NOT NULL,
	[day_workingTime] [float] NULL,
	[night_workingTime] [float] NULL,
	[holiday_workingTime] [float] NULL,
	[score] [int] NULL,
	[deduction][float],
	[attendanceBonus][float],
	[electricityCharge][float]
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([id])
ON DELETE CASCADE

ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Employee]
GO


