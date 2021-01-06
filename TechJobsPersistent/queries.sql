--Part 1
/*Id  - int AI PK, Name longtext, EmployerId int
--Part 2
select * from employers where Location = 'St. Louis City'
--Part 3
select s.Name,s.Description from skills as s
inner join jobskills as js
on s.Id = js.Skillid
order by s.Name