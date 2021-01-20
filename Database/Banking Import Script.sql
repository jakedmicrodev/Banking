--select *
--from [dbo].[CheckingBills]
--where [Date] between '1/1/2019' and '1/31/2019'
--and [Amount] < 0
--order by [Date], [Amount] desc

--select *
--from [dbo].[BillsSpending]
--where [Date] between '1/1/2019' and '1/31/2019'
--order by [Date], [Amount] asc

select *
from [dbo].[SubCategories]

select *
from [dbo].[CheckingJake]
where [Date] = '1/2/2019'

select *
from [dbo].[JakeSpending]
where [Date] = '1/2/2019'

--insert into [dbo].[Spending]
--select c.[Id], sc.[Id], cs.[Date], cs.[Location], cs.[Payee], cs.[Description], a.Id, cs.Amount
--from [dbo].[CombinedSpending] cs
--inner join Categories c on cs.[Master Category] = c.Name
--inner join SubCategories sc on cs.Subcategory = sc.Name
--inner join Accounts a on cs.[Payment Method] = a.Name
--order by cs.[Date]


--merge [dbo].[Categories] as Target
--using (select distinct [Master Category]
--from [CombinedSpending]) as Source
--on (Target.[Name] = Source.[Master Category])
--when not matched then insert ([Name]) values (Source.[Master Category]);

--merge [dbo].[SubCategories] as Target
--using (select distinct [Subcategory]
--from [CombinedSpending]) as Source
--on (Target.[Name] = Source.[Subcategory])
--when not matched then insert ([Name]) values (Source.[Subcategory]);

--merge [dbo].[Accounts] as Target
--using (select distinct [Payment Method]
--from [CombinedSpending]) as Source
--on (Target.[Name] = Source.[Payment Method])
--when not matched then insert ([Name]) values (Source.[Payment Method]);

select c.Name as 'Category', sum(Amount) AS 'Amount'
from [dbo].[Spending] s
inner join [dbo].[Categories] c on s.CategoryId = c.Id
where s.[Date] between '11/1/2020' and '11/30/2020'
Group by c.Name
order by c.Name

select c.Name as 'Sub Category', sum(Amount) AS 'Amount'
from [dbo].[Spending] s
inner join [dbo].[SubCategories] c on s.SubCategoryId = c.Id
where s.[Date] between '11/1/2020' and '11/30/2020'
Group by c.Name
order by c.Name

SELECT c.[Name] AS [Sub Category]
      ,s.[Date]
      ,s.[Location]
      ,s.[Payee]
      ,s.[Description]
      ,a.Name AS [Account]
      ,[Amount]
from [dbo].[Spending] s
inner join [dbo].[SubCategories] c on s.SubCategoryId = c.Id
inner join [dbo].[Accounts] a on s.AccountId = a.Id
where [SubCategoryId] = 26
and s.[Date] between '11/1/2020' and '11/30/2020'

 --select *
 --from [dbo].[SubCategories]



