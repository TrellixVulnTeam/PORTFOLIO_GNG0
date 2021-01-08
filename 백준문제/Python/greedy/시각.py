# 정수 N 이 주어진다
# N은 시간 0 <= N <= 23
# N:59:59 까지 3이 몇개 들어있을까?

n = int(input())
cnt = 0

for h in range(n + 1):
    for m in range(60):
        for s in range(60):
            if '3' in str(h) + str(m) + str(s):
                cnt += 1
print(cnt)


