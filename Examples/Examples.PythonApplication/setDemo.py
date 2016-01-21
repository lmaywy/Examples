# set demos
# *set: no order,no duplicated value,value should be immutable
# 1.intial set by given list
s = set(['Adam', 'Lisa', 'Bart', 'Paul'])
print s;

# 2.initial set with duplicated values
s1 = set(['A', 'B', 'C', 'C']) ;
print len(s1); #remove duplicated values and count the length
print s1;

# 3.check value in set(case sensitive)
print 'A' in s1;
print 'a' in s1;

# 4.traverse value in set
for letter in s1:
    print letter;

s = set([('Adam', 95), ('Lisa', 85), ('Bart', 59)])
for x in s:
    print x[0]+":",x[1]

# 5.set features
months = set(['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'])
x1 = 'Feb'
x2 = 'Sun'

if x1 in months:
    print 'x1: ok'
else:
    print 'x1: error'

if x2 in months:
    print 'x2: ok'
else:
    print 'x2: error'

# 6.add value to set
s1.add("D");
print s1;

# 7.revmoe value in set
s1.remove("B");  #exist value
#s1.remove("E");  #not exist value,throw keyerror

