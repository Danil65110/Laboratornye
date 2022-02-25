import random 
from random import randint
a = list(input())
b = len(a)
i = int(0)
k = []
while i<b: 
    k.append(i)
    i+=1

random.shuffle(k)
print(a)
print(k)

outtxt = {}

i = 0
while i<b:
     x = int(k[i])
     z = a[i]
     o.append(z)
     
     i+=1
print(o)

i = 0
d = []
while i<b:
    x = int(k[i])
    z = o[i]
    d.append(z)
    i+=1
print(d)