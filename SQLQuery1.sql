use AdventureWorks2019
go

select ProductID, Name, Color, ListPrice
from Production.Product

select ProductID, Name, Color, ListPrice
from Production.Product
where ListPrice != 0

select ProductID, Name, Color, ListPrice
from Production.Product
where Color is NULL

select ProductID, Name, Color, ListPrice
from Production.Product
where Color is not NULL

select ProductID, Name, Color, ListPrice
from Production.Product
where Color is not NULL and ListPrice > 0

select Name + ' ' + Color as [Name And Color]
from Production.Product
where Color is not NULL

select 'NAME: ' + Name + ' -- CLOLR: ' + Color as [Name And Color]
from Production.Product
where Color in ('black', 'silver')

select ProductID, Name
from Production.Product
where ProductID between 400 and 500

select ProductID, Name, Color
from Production.Product
where  Color in ('black', 'blue')

select Name
from Production.Product
where  Name like 'S%'

select Name, ListPrice
from Production.Product
order by ListPrice

select Name, ListPrice
from Production.Product
where Name like 'a%' or Name like 's%'
order by Name

select Name, ListPrice
from Production.Product
where Name like 'spo[^k]%'
order by Name

select distinct Color
from Production.Product
order by color desc

select distinct ProductSubcategoryID, Color
from Production.Product
where ProductSubcategoryID is not null and color is not null
order by ProductSubcategoryID