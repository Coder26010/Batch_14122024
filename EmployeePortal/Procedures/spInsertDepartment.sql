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


Create Procedure [dbo].[spGetAllDepartments]
@PageSize int = 3,
@PageNo int = 1
AS
BEGIN

Declare @TotalCount int = (Select count(SystemNumber) from TDEPARTMENT)

select SystemNumber,DCode,Name,Description,RecordCreationDate,@TotalCount as TotalRecords 
from TDEPARTMENT
Order by SystemNumber
Offset (@PageNo - 1)*@PageSize rows fetch next @PageSize rows only
END

---------------------------------------------------------------------------------------

Create Proc spGetDepartment
@DepartmentId Int
AS
BEGIN
  
  IF EXISTS(Select 1 from TDEPARTMENT where  SystemNumber = @DepartmentId)
  BEGIN
     Select SystemNumber,DCode,Name,ISNULL(Description,'') as Description from TDEPARTMENT where  SystemNumber = @DepartmentId
	return
  END
   
   Select 'notfount' as StatusCode
END

------------------------------------------------------------------------------------------
Create Procedure spDeleteDepartment
@SystemNumber int
AS
BEGIN
Delete from TDEPARTMENT where SystemNumber = @SystemNumber
END

--------------------------------------------------------------------------------------------


Create Proc [dbo].[spUpdateDepartment]
@DepartmentId Int,
@DepartmentCode Varchar(6),
@DepartmentName Varchar(50),
@Description varchar(200) = null
AS
BEGIN
  
  IF NOT EXISTS(Select 1 from TDEPARTMENT where DCode = @DepartmentCode and SystemNumber <> @DepartmentId)
  BEGIN
    Update TDEPARTMENT Set DCode = @DepartmentCode, Name = @DepartmentName,
	Description = @Description Where SystemNumber = @DepartmentId;
	
	Select 'updated' as StatusCode

	return
  END
   
   Select 'exists' as StatusCode
END
--------------------------------------------------------------------------------------------



