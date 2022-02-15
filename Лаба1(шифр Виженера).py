
a = input("Введите сообщение:")
b = input("Введите ключ:")
b *= len(a) // len(b) + 1
c =''

for i, j in enumerate(a):
    g = (ord(j) + ord(b[i]))
    c += chr(g % 26 + 65)
print( "Зашифрованное слово:", c , end = " ")
 



