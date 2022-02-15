a = 5
m = 4096
 
r = input("Сообщение:")
 
Y = [0] * 4
Y[0] = 3190
for i in range(1,4):
    Y[i] = (a * Y[i-1]) % m
 
g = ""
for i in range(len(Y)):
    g += chr(Y[i]%26+97)
print(g)
 
s = ""
n = 0
for i in range(len(r)):
    s += chr((ord(r[i]) ^ ord(g[n]))+411)
    if n == 7:
        n = 0
print(s)
p = ""
n = 0
for i in range(len(r)):
    p += chr((ord(r[i]) % ord(g[n]))+411)
    if n == 7:
        n = 0
