--https://www.codewars.com/kata/590ba881fe13cfdcc20001b4/sql--

select name, country
from travelers 
where country not in ('USA', 'Mexico', 'Canada')