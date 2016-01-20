lst=[1,2,3,4,5,6,7]
# 1.access element by index in order 
print lst[0];
for x in lst:
    print x;

# 2.access element by index in inverse order
print lst[-1];
lenth=len(lst);
i=length-1;
while(i>=0):
    print lst[i];

# remove an element
lst.remove(3);
lst.pop(-1);
print lst;
