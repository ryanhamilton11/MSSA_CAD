--SQL CHAPTER 2 QUIZ


-- Question 1: List all the Customers located in Germany.
SELECT contactname
	FROM Sales.Customers
	WHERE country = 'Germany';


--Question 2: Count all the Customers with "Jr." in their name (contactname)
SELECT SUM(CHARINDEX('Jr.', contactname)) AS MiddleNameJr
	FROM Sales.Customers;

--Question 3: What are the three highest priced Products that we sell?
SELECT TOP (3) unitprice, productname 
	FROM Production.Products
	ORDER BY unitprice DESC;


--Question 4: What is the total quantity of all products that were sold?
SELECT COUNT(qty)
	FROM Sales.OrderDetails;


--Question 5: What were the top 10 products by quantity that were sold?
SELECT TOP (10) productid, qty
	FROM Sales.OrderDetails
	ORDER BY qty DESC;



--EC 1: Give the counts of how many Orders each employee (empid) took - from most orders to least orders.
SELECT COUNT(empid) AS OrderCount
	FROM Sales.Orders
	WHERE empid >= 1
	ORDER BY OrderCount DESC;

--EC 2: What are all the different prices I have charged for product id 11 over the years? I don't care about the dates, I just want a list of the prices.