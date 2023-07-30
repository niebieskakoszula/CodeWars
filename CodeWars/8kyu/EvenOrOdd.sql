--https://www.codewars.com/kata/53da3dbb4a5168369a0000fe--

SELECT number, 
(case
  when number % 2 = 0 then "Even"
  else "Odd"
end) AS is_even 
FROM Numbers