--https://www.codewars.com/kata/580d08b5c049aef8f900007c--

select customer.customer_id, customer.email, 
count(payment.payment_id) as payments_count,
sum(payment.amount::float) as total_amount
from customer inner join payment on customer.customer_id = payment.customer_id
group by customer.customer_id
order by sum(payment.amount) desc, count(payment.payment_id) desc
limit 10