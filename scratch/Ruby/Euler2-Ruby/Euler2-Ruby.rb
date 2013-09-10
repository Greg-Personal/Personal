numbers = [1, 2]
counter = 2
result = 0

until counter > 4000000
	counter = numbers.reverse[0] + numbers.reverse[1]
	numbers << counter if counter < 4000000
end

numbers.each { |x| result += x if x % 2 == 0}

puts result