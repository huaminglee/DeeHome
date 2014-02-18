create	procedure [dbo].[pro_VisitContentPaging]
@pageIndex int,
@pageSize int,
@EmployeeId nvarchar(50),
@TotalRecords int output
as
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize

select * from (
Select Row_Number() over(order by RevisitDateTime) rowNumber ,
[RevisitContent] as RevisitContent,
[RevisitDateTime] as RevisitTime
from Revisit r,InformationAssistant i
where r.InformationAssistantId = i.InformationAssistantId
and i.EmployeeId = @EmployeeId
and CONVERT(varchar(100), r.RevisitDateTime, 111)=CONVERT(varchar(100), getdate(), 111)
) as tempTable
where rowNumber between @startRow and @lastRow
order by RevisitTime desc

select @TotalRecords=count(*) 
from Revisit r,InformationAssistant i
where r.InformationAssistantId = i.InformationAssistantId
and i.EmployeeId = @EmployeeId
and CONVERT(varchar(100), r.RevisitDateTime, 111)=CONVERT(varchar(100), getdate(), 111)
return @TotalRecords
GO