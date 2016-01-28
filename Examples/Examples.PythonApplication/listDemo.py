lst=[1,2,3,4,5,6,7]
# 1.access element by index in order 
print 'access element by index in order';
print lst[0];
print 'traverse element by index in order '
for x in lst:
    print x;

# 2.access element by index in inverse order
print 'access element by index in inverse order'
print lst[-1];
length=len(lst);
i=length-1;
print 'traverse element by index in inverse order'
while i>=0:
    print lst[i];
    i=i-1;


# 3.add element
lst.append(8);
lst.insert(0,0);
print lst;

# 4.remove an element
lst.remove(3);
lst.pop(-1);
print lst;

# 5.replace an element from list
lst[-1]=5;
print lst;

# 6.sort list
lst.sort();
print lst;

# 7.reverse list
lst.append(3)
print lst;
lst.reverse();
print lst;

# 8.count given an value in the list
times=lst.count(5);
print times;

# 9.extend list with given list/tuple
lst.extend([10,11])
print lst;

# 10. generate list using while,also call sum to calculate total value
L = [];
x=1;
while x<=100:
    L.append(x*x);
    x=x+1;
print sum(L)