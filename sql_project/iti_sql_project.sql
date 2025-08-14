

create database ITI_Project;
use ITI_Project;

go 
create table customers (
 customer_id int primary key identity ,
 fullName varchar(255) not null ,
 mobile varchar(11) unique ,
 email varchar(255) unique 
);

go 
create table orders (
order_id int primary key ,
order_date date  default getdate(),
cust_idFK int foreign key (cust_idFK)references  customers(customer_id)
);


create table products(
product_id int primary key ,
productName varchar(255),
productPrice int 
);

create table orderDetails (
ord_id int  foreign key (ord_id) references orders(order_id) not null ,
pro_id int  foreign key (pro_id) references products(product_id) not null ,
quantity int check ( quantity > 1) ,
primary key (ord_id , pro_id )
);
go

insert into [dbo].[customers] (fullName  , mobile  ,email  )
values  ('Martina', '01000000004', 'ghyjk@gmail.com '),
		('Mina '  , '10000023455', 'geehjk@gmail.com ') ,
		('ALi '   ,  '01023456789' , 'ghjkss@gmail.com '),
		('Alaa',    '01022222234' , 'ghjssk@gmail.com '),
		('dalia ',  '01099994456' , 'ghbhjk@gmail.com ');

go 



insert into [dbo].[orders](order_id ,order_date, cust_idFK )
values
(1,'2009-4-4' ,1 ),
(2,'2020-3-3', 2 ),
(3,'2023-9-9' , 2 ),
(4,'2025-3-3' , 2), 
(5,'2024-6-6' ,4);
 go 

insert into  products(product_id  ,productName ,productPrice ) 
values (1 , 'jar ' ,  40 ), 
 (2 , 'bag ' ,  60 ) ,
 (3 , 'book ' ,  30 ) ,
 (4 , 'pen ' ,  20 ) ,
 (5 , 'notebook ' ,  90 ) ,
 (6 , 'pencil ' ,  80 ) ;

 go

 
insert into  orderDetails (ord_id  ,pro_id  ,quantity )
values ( 1, 1, 5),
( 3, 1, 5),
( 3, 6, 5),
( 5, 5, 5);


----select and join 
select * from products ;

select order_date , quantity  from orders o
inner join [dbo].[orderDetails] od
on o.order_id = od.ord_id ;


select * from products p
left outer join [dbo].[orderDetails] od 
on  p.product_id = od.pro_id ;



-- agregate funciton

select count(*) from products  as [count of products ];
go 

select sum(productPrice) from [dbo].[products]as [total price  ];

select avg([order_id])from [dbo].[orders]as [avg number of orders ];





-- ** by MarTina Mina ** -- 