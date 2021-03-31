--SQL CHAPTER 2 EXERCISE
USE TSQLV4;

--Exercise 1: Write a qurey against the Sales.Orders table that returns orders placed in June 2015.
SELECT orderid, orderdate, custid, empid
	FROM Sales.Orders
	WHERE orderdate BETWEEN '2015/05/31' AND '2015/07/01'
	ORDER BY orderid;

--Exercise 2: Write a query against Sales.Orders table that returns orders placed on the last day of the month.
SELECT orderid, orderdate, custid, empid
	FROM Sales.Orders
	WHERE orderdate = EOMONTH(orderdate);

--Exercise 3: Write a query against the HR.Employees table that returns employees with a last name contaioning the letter e twice or more.
SELECT empid, firstname, lastname
	FROM HR.Employees
	WHERE lastname LIKE'%e%e%';

--Exercise 4: Write a query against the Sales.OrderDetails table that returns orders with a total value (quantity * unitprice) greter than 10,000, sorted by the total value.
SELECT orderid, SUM(qty*unitprice) AS totalvalue
	FROM Sales.OrderDetails
	GROUP BY orderid
	HAVING SUM(qty*unitprice) > 10000
	ORDER BY totalvalue DESC;