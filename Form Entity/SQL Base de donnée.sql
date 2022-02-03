create database entity
go
use entity

create table client(
	id int primary key identity,
	nom varchar(20),
	prenom varchar(20),
)

create table commande (
	id int primary key identity,
	DateCmd datetime,
	montant float,
	idClient int foreign key references client(id),
)

select * from commande

insert into client values('Client 1','11')
insert into client values('Client 2','22')
insert into client values('Client 3','33')
insert into client values('Client 4','44')