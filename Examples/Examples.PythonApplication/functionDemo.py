# define a function: to sum the square value in the list 
def square_of_sum(L):
    s = [x*x for x in L]
    return sum(s)

print square_of_sum([1, 2, 3, 4, 5])
print square_of_sum([-5, 0, 5, 15, 25])

#ax*x+bx+c=0 to cacluate x value
import math
def quadratic_equation(a, b, c):
    x=[];
    t=math.sqrt(b*b-4*a*c);
    x.append((-b+t)/(2*a));
    x.append((-b-t)/(2*a));
    return x
print quadratic_equation(2, 3, 0)
print quadratic_equation(1, -6, 5)

#recursion: eg:hanoi
def move(n, a, b, c):
    if n ==1:
        print a, '-->', c
        return
    move(n-1, a, c, b)
    print a, '-->', c
    move(n-1, b, a, c)
move(4, 'A', 'B', 'C')

# default value for parameter, the parameter which has default value should be list in the last
def greet(name='World'):
    print 'Hello,',name,'.'

greet()
greet('Bart')

# flexible parameters,actually the parameter dealed as a tuple inside the function
def average(*args):
    sum=0.0;
    if len(args)==0:
        return sum;
    for x in args:
      sum=sum+x;
    return sum/len(args)

print average()
print average(1, 2)
print average(1, 2, 2, 3, 4)