--https://www.codewars.com/kata/5e5f09dc0a17be0023920f6f/sql--

select capital 
from countries
where continent in ('Africa', 'Afrika')
and country like 'E%'
order by capital asc
limit 3