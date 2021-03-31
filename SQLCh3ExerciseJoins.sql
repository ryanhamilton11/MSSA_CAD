USE TSQLV4;

--Exercise 2
SELECT Customers.custid, Customers.companyname, Orders.orderid, Orders.orderdate
FROM Sales.Customers
	INNER JOIN Sales.Orders
		ON Customers.custid = Orders.custid;


--Exercise 3
SELECT C.custid, COUNT(DISTINCT O.orderid) AS numorders, SUM(OD.qty) AS totalqty
FROM Sales.Customers AS C 
	INNER JOIN Sales.Orders AS O 
		ON O.custid = C.custid 
	INNER JOIN Sales.OrderDetails AS OD 
		ON OD.orderid = O.orderid 
WHERE C.country = N'USA' 
GROUP BY C.custid; 


--Exercise 4
SELECT C.custid, C.companyname, O.orderid, O.orderdate 
FROM Sales.Customers AS C 
	LEFT OUTER JOIN Sales.Orders AS O 
		ON O.custid = C.custid;