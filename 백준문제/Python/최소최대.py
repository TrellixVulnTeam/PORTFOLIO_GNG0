N = int(input())
cnt = 0
sum = 0
for i in range(N):
    str = input()
    for j in str:
        if j == 'O':
            cnt += 1
            sum += cnt
        else:
            cnt = 0
    print(sum)
    sum = 0
    cnt = 0





