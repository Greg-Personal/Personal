counter = 3
numbers = Hash.new
result = 0

until counter >= 1000
	numbers {:counter => counter}
	counter+=3
end

counter = 5

until counter >= 1000
	numbers {:counter => counter}
	counter+=5
end

numbers.each { |a,b| result += b }

print result
