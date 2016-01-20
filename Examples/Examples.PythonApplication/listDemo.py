lst=[1,2,3,4,5,6,7]
# 1.access element by index in order 
print 'access element by index in order'
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
while(i>=0):
    print lst[i];
    i=i-1;

# remove an element
lst.remove(3);
lst.pop(-1);
print lst;
