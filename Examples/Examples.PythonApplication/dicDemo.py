scores={
	'Vincent':100,
	'May':90,
	'Lisa':60,
	'Paul':65,
	'Lance':90	
};

# 1.get value by given key in the dic
print scores.get('May')

# 2.get keys by given value in the dic
excllentStudents='';
for k,v in scores.items():
	if v==90:
		excllentStudents+= k+' ';
print excllentStudents

