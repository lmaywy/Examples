#L[a:b:c]
#a: start index?optional
#b:end index,optional
#c:get one item from every c items
L = range(1, 101)

print L[:10] #????0-9??
print L[2::3] #??L?3???
print L[4:50:5] #????50???5???
print L[:] #????L???
print L[::] #????L???
print L[-10:] #????10??
print L[4::5][-10:] #??10?5????

#slice string: stirng also can treat as list
def firstCharUpper(s):
    return s[0].upper()+s[1:].lower()

print firstCharUpper('hellO')
print firstCharUpper('sunday')
print firstCharUpper('september')
