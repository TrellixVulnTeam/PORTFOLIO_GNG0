n, k = map(int,input().split())
cnt = 0
while True:
    # n에서 k로 나누어떨어지는 수 중 가장 가까운 수
    # 예를들어 n=14 k=3이면 target = (14//3)*3 = 12
    # n이 target의 수가 되려면 2(n-target)번이 되어야 한다.
    target = (n//k) * k
    cnt += (n - target)
    n = target
    if n < k :
        break
    cnt += 1
    n //= k
cnt += (n-1)
print(cnt)