create procedure [dbo].[pro_UnSubordinateMessengerList]
@pageIndex int,
@pageSize int
as
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select gridColumnInformationAssistantId,gridColumnName,gridColumnPhone,gridColumnType
	   ,gridColumnCompany,gridColumnCity,gridColumnLevel from(
	select Row_number() over(order by InformationAssistantId) rowNumber,
			InformationAssistantId as gridColumnInformationAssistantId,
			InformationAssistantName as gridColumnName,
			PhoneNumber as gridColumnPhone,
			[Type] as gridColumnType,
			Company as gridColumnCompany,
			City as gridColumnCity,
			InformationLevel as gridColumnLevel
			From InformationAssistant
			where EmployeeId is null
			) as tempTable
where rowNumber between @startRow and @lastRow
GO