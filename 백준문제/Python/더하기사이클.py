N = int(input())
A = N // 10
B = N % 10
cnt = 0
while 1:
    result = B * 10 + ((A + B) % 10)
    cnt += 1
    if result == N:
        break;
    A = result // 10
    B = result % 10
print(cnt)
