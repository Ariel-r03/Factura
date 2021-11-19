

Use Northwind
go
Execute Factura 10248

Alter procedure Reporte_Factura
@OrderID int
as
Select o.OrderID,
o.OrderDate,
c.CompanyName as NombreCliente,
(e.FirstName + ' '+e.LastName) as NombreVendedor,
o.ShipCity,
o.ShipCountry,
(Select round(SUM((od.UnitPrice * od.Quantity)- (od.UnitPrice * od.Quantity * od.Discount)),2)
as Total
from [Order Details] od where od.OrderID = @OrderID) as SubTotal,
((Select round(SUM((od.UnitPrice * od.Quantity)- (od.UnitPrice * od.Quantity * od.Discount)),2)
as Total
from [Order Details] od where od.OrderID = @OrderID) * 1.15) as TotalIVA
from Orders o inner join Customers c
on c.CustomerID = o.CustomerID
inner join Employees e
on e.EmployeeID = o.EmployeeID
where o.OrderID = @OrderID

Alter procedure Reporte_Detalle_Factura
@OrderID int
as
Select od.ProductID,
       p.ProductName,
	   od.UnitPrice,
	   od.Quantity,
	   od.Discount,
((od.UnitPrice * od.Quantity)- (od.UnitPrice * od.Quantity * od.Discount))
 as SubTotal
from [Order Details] od
inner join Products p on
p.ProductID = od.ProductID
 where od.OrderID = @OrderID


Execute Reporte_Factura 10250
Execute Reporte_Detalle_Factura 10250

Create login unisistemas with password = 'sistemas123'
go
sp_adduser unisistemas, unisistemas
go
sp_addrolemember  db_owner, unisistemas