create	procedure [dbo].[pro_AllListPagingForManager]
@pageIndex int,
@pageSize int,
@input nvarchar(max),
@BlackEmployeeId nvarchar(50),
@TotalRecords int output
as
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from 
(
select Row_Number() over(order by InformationAssistantId) rowNumber ,
       'False' as IsSelected,
	   InformationAssistantId as gridColumnIndex,
       InformationAssistantName as gridColumnName,
	   i.PhoneNumber as IaPhoneNumber,
       [Type] as gridColumnType,
       Company as gridColumnCompany,City as gridColumnCity,
       InformationLevel as gridColumnLevel,
       InformationAssistantName as gridColumnInformationAssistant,
       e.Name as EmployeeName
      From InformationAssistant i, Employee e
      where i.EmployeeId = e.EmployeeId
      and i.EmployeeId != @BlackEmployeeId
      and (InformationAssistantName like '%'+@input+'%'
      or [Type] like '%'+@input+'%'
      or Company like '%'+@input+'%'
      or InformationLevel like '%'+@input+'%'
      or InformationAssistantName like '%'+@input+'%'
      or e.Name like '%'+@input+'%'
      or @input = '')
) as tempTable
where rowNumber between @startRow and @lastRow


select @TotalRecords = count(*) 
      From InformationAssistant i, Employee e
      where i.EmployeeId = e.EmployeeId
      and i.EmployeeId != @BlackEmployeeId
      and (InformationAssistantName like '%'+@input+'%'
      or [Type] like '%'+@input+'%'
      or Company like '%'+@input+'%'
      or InformationLevel like '%'+@input+'%'
      or InformationAssistantName like '%'+@input+'%'
      or e.Name like '%'+@input+'%'
      or @input = '')
return @TotalRecords
GO
