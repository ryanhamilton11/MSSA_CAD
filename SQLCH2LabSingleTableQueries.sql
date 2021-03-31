USE TSQLV4

--Question 1: Who are our customers in North America?
SELECT COUNT(country)
	FROM Sales.Customers
	WHERE country IN ('USA', 'Mexico', 'Canada');


--Question 2: What orders were placed in April, 2015?
SELECT *
	FROM Sales.Orders
	WHERE orderdate BETWEEN '20150401' AND '20150430';


--Question 3: What cheeses do we sell?
SELECT *
	FROM Production.Products
	WHERE categoryid = 4;


-- Question 4: What employees (employee id only) shipped products to Germany in December?
SELECT empid
	FROM Sales.Orders
	WHERE shipcountry = 'Germany'
		AND MONTH(shippeddate) = '12';


-- Question 5: We have an issue with product 19. I need to know the total amount and the net amount of all orders for product 19 where the customer took a discount.
SELECT  (unitprice * qty) AS 'Total Amount', (unitprice * qty * (1 - discount)) AS 'Net Amount'
	FROM Sales.OrderDetails
	WHERE productid = 19
		AND discount > 0.0;


-- Question 6: I need a list of employees by title, first name, and last name.
SELECT empid, title, firstname, lastname
	FROM HR.Employees;


-- Question 7: I need a list of our customers and the first name only of the customer representative.
SELECT companyname,
	TRIM (SUBSTRING (contactname, CHARINDEX(', ', contactname)+1, LEN(contactname)-CHARINDEX(', ', contactname))) AS contact
	FROM Sales.Customers;


--Question 8: Give me a list of our customer contacts alphabetically by last name.
SELECT contactname
	FROM Sales.Customers
	ORDER BY contactname;


--Question 9: You sell some kind of dried fruit that I liked very much. However, it is discontinued. What is its name?
SELECT * FROM Production.Categories;
SELECT productname, productid
	FROM Production.Products
	WHERE categoryid = 7
		AND discontinued = 1;


--Question 10: How many days old are you today?
DECLARE @dateofbirth DATETIME
SET @dateofbirth = '19910705'
DECLARE @currentdate DATETIME
SET @currentdate = getdate()
SELECT DATEDIFF(DAY, @dateofbirth, @currentdate) AS dayold;