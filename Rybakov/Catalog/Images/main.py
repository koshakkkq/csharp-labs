import os
j = 1
for _, _, files in os.walk('.'):
    for name in files:
        if name[0] == 'Б':
            os.rename(name, 'car'+str(j)+'.jpg')
            j += 1