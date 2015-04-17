#this is the orders and orderdetail table script code in sqlite database;

# Introduction #

Add your content here.


# Details #

```
CREATE TABLE "Orders"(
[OrderID] nvarchar(40) PRIMARY KEY ON CONFLICT Rollback REFERENCES [OrderDetail] ([OrderID]) On Delete CASCADE On Update CASCADE
,[Name] nvarchar(80)
,[Tel] nvarchar(30)
,[Email] nvarchar(60)
,[Zip] nvarchar(12)
,[Adress] nvarchar(80)
,[Content] nvarchar(255)
,[OrderDate] datetime
,[EndDate] datetime
,[State] int
,[MemberID] nvarchar(40)
   
)

CREATE TABLE "OrderDetail"(
[DetailID] nvarchar(40) PRIMARY KEY DESC ON CONFLICT Rollback
,[OrderID] nvarchar(40) REFERENCES [Orders] ([OrderID])
,[ProductID] nvarchar(40)
,[Amount] int
   
)

```