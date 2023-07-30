--https://www.codewars.com/kata/52fba66badcd10859f00097e/sql--

select str, TRANSLATE(str, 'aeiouAEIOU', '') as res
from disemvowel;