--https://www.codewars.com/kata/54ff3102c1bad923760001f3/sql--

select str, 
  length(str) 
    - length(
        replace(replace(replace(replace(replace(
            lower(str), 'a', ''), 'e', ''), 'i', ''), 'o', ''), 'u', '')
    )
AS res
from getcount