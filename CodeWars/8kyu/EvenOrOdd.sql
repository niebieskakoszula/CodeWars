SELECT number, 
(case
  when number % 2 = 0 then "Even"
  else "Odd"
end) AS is_even 
FROM Numbers