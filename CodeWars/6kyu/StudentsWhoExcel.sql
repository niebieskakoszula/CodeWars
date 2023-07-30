--https://www.codewars.com/kata/649421e15e89dc1ca27e5fb3/sql--

select s.id as student_id, s.name, (Science.score - Math.score) as score_difference
from (select score, student_id from courses where course_name = 'Science') as Science 
  inner join (select score, student_id from courses where course_name = 'Math') as Math on Science.student_id = Math.student_id
  inner join students as s on s.id = Science.student_id
where (Science.score - Math.score) > 0
order by 3 desc, s.id asc
