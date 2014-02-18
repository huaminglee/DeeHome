create	procedure [dbo].[pro_AllListPaging]
@pageIndex int,
@pageSize int,
@InformationLevel nvarchar(50),
@input nvarchar(500),
@EmployeeId nvarchar(500)
as
declare @startRow int
declare @lastRow int
declare @sql nvarchar(max)
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from 
(
select Row_Number() over(order by VisitDateTime) rowNumber ,
	   InformationAssistantId as gridColumnIndex,
       InformationAssistantName as gridColumnName,
       i.PhoneNumber as gridColumnPhone,Type as gridColumnType,
       Company as gridColumnCompany,City as gridColumnCity,
       InformationLevel as gridColumnLevel,
       InformationAssistantName as gridColumnInformationAssistant,
       e.Name as EmployeeName,
       datediff(hour,getdate(),VisitDateTime) as gridColumnleftRevisitTime,
       VisitDateTime 
       From InformationAssistant i left outer join Employee e
       on i.EmployeeId = e.EmployeeId
       where (InformationLevel = @InformationLevel 
       or @InformationLevel = 'InforAllList')
       and i.EmployeeId = @EmployeeId
       and (InformationAssistantName like '%'+@input+'%' 
       or i.PhoneNumber like  '%'+@input+'%'
       or [Type] like '%'+@input+'%'
       or Company like '%'+@input+'%'
       or City like '%'+@input+'%'
       or InformationLevel like '%'+@input+'%'
       or ReVisitTime like '%'+@input+'%'
       or e.Name like '%'+@input+'%'
       or InformationAssistantName like '%'+@input+'%'
       or @input = '')
) as tempTable
where rowNumber between @startRow and @lastRow
order by gridColumnleftRevisitTime,VisitDateTime
GO
