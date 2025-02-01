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