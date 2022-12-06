select * from People
where LastName = N'ყიფიანი'

select  * from People
order by BirthDate asc, Height desc

insert into People (Name,LastName,BirthDate,IsMarried,Description,Height,PrivateNumber)
values (N'რატი',N'ყიფიანი','2003-05-19',0,'test',1.8,'01001011011')

insert into People (Name,LastName,BirthDate,IsMarried,Description,Height,PrivateNumber)
values (N'ლევან',N'ყიფიანი','2003-05-23',0,'test',1.9,'01001011011')

update People
set Description = 'Changed Description'
where Id = 2

delete from People
Where Id = 2

select * from People
where Id in (1,3)

