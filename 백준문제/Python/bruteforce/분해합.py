n = int(input())
m = []
ns = 0
result = 0
for i in range(1, n):
    val = list(map(int, str(i)))
    ns = i + sum(val)
    if ns == n:
        result = i
        break

print(result)


