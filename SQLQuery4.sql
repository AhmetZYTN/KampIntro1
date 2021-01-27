--select
select ContactName adi,CompanyName yesg,City ewywry from Customers

Select * from Customers where City = 'LONDON'


select * from Products where CategoryID=1 or CategoryID=3


select * from Products where CategoryID=1 or UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products where CategoryID=2

select CategoryId,count(*) from Products where UnitPrice>20 group by CategoryId having count(*)<10


select Products.ProductID, Products.ProductName, products.UnitPrice, Categories.CategoryID, 
Categories.CategoryName from Products inner join Categories on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null