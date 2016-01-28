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

# 3. update dic
scores["ZhangSan"]=20;
print scores;

# 4.traverse key in dic
d = {
    'Adam': 95,
    'Lisa': 85,
    'Bart': 59
}
for key in d:
    print key+':', d[key] #d.get(key)

# 5. remove the item by given key
d.pop('Adam');
print d

# 6.clear dic
d.clear();
print d;
