x = []
y = []
tx = ty = 0
for i in range(3):
    x_num,y_num = input().split()
    x.append(x_num)
    y.append(y_num)

for i in range(3):
    if x.count(x[i]) == 1:
        tx = x[i]
        break

for i in range(3):
    if y.count(y[i]) == 1:
        ty = y[i]
        break;
print(tx,ty)





