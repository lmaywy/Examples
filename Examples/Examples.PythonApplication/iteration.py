#zip()??????? list ???? list
L = ['Adam', 'Lisa', 'Bart', 'Paul']
for index, name in zip(range(1,len(L)+1),L):
    print index, '-', name

d = { 'Adam': 95, 'Lisa': 85, 'Bart': 59, 'Paul': 74 }
sum = 0.0
for k, v in d.items():
    sum = sum + v
    print k+":",v
print 'average', ':', sum/len(d)

a=d.itervalues();
b=d.values();
c=d.iteritems();
