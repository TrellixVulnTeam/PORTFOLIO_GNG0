n = int(input())
w = []
k = []
for i in range(n):
    x, y = map(int, input().split())
    w.append(x)
    k.append(y)

l = []
for i in range(n):
    count = 1
    for j in range(n):
        if i == j:
            continue
        if w[i] < w[j] and k[i] < k[j]:
            count +=1
    l.append(str(count))
print(' '.join(l))





