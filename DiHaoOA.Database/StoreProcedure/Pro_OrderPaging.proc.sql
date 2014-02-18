Create procedure [dbo].[pro_OrdersPaging]
@pageIndex int,
@pageSize int,
@orderStatus nvarchar(50),
@input nvarchar(500),
@EmployeeId nvarchar(50)
as
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from(
select Row_Number() over(order by o.OrderId desc) rowNumber,
	  o.OrderId,
	  c.CustomerId,
	  o.OrderNumber as orderNumber,
	  o.OrderStatus orderStatus,
	  c.CompanyName,
	  o.RecordDate as RecordDate,
	  c.DecorationAddress as decorateAddress,
      i.InformationAssistantName as InformationAssistantName,
	  e.Name as BAName,
	  d.Name as DesignerName,
	  c.City as city
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where o.orderStatus = @orderStatus
   and  c.EmployeeId = @EmployeeId
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderStatus like '%'+@input+'%'
   or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or c.ContactPersonNumber like '%'+@input+'%' 
   or c.ContactPerson2Number like '%'+@input+'%' 
   or c.ContactPerson3Number like '%'+@input+'%' 
   or @input='')
  )as tempTable
where rowNumber between @startRow and @lastRow

GO
