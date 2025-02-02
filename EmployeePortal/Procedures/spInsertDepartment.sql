USE [ADOEXAMPLEDB]
GO
CREATE TABLE [dbo].[TDEPARTMENT](
	[SystemNumber] [int] IDENTITY(1,1) NOT NULL,
	[DCode] [varchar](6) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](200) NULL,
	[RecordCreationDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SystemNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[DCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TDEPARTMENT] ADD  DEFAULT (getdate()) FOR [RecordCreationDate]
-----------------------------------------------------------------------------------------


Create Proc spInsertDepartment
@Dcode varchar(6),
@Name varchar(50),
@Des Varchar(200) = Null
AS
BEGIN
  IF NOT EXISTS(select 1 from TDEPARTMENT where DCode = @Dcode)
   BEGIN
     INSERT INTO TDEPARTMENT (DCode,Name,Description)
	 VALUES (@Dcode,@Name,@Des);
	 select 'create' as StatusCode
	 return
   END;

   select 'exists' as StatusCode
   return
END;
--------------------------------------------------------------------------------------------


Create Procedure spGetAllDepartments
AS
BEGIN
select SystemNumber,DCode,Name,Description,RecordCreationDate from TDEPARTMENT
END;

------------------------------------------------------------------------------------------
Create Procedure spDeleteDepartment 10
@SystemNumber int
AS
BEGIN
Delete from TDEPARTMENT where SystemNumber = @SystemNumber
END



