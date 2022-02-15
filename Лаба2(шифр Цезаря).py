alfavit = 'АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ'
sm = int(input('Шаг шифровки: '))    
me = input("Сообщение для шифровки: ").upper()    
itog = ''
for i in me:
    m = alfavit.find(i)    
    new_m = m + sm
    if i in alfavit:
        itog += alfavit[new_m]  
    else:
        itog += i
print (itog)


message = input(me).upper()
itog = ''

for i in message:
    m = alfavit.find(i)
    new_m = m + sm
    if i in alfavit:
        itog += alfavit[new_m]
    else:
        itog += i
print(itog)       
