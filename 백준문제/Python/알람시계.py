# 알람 시계
H, m = map(int, input().split(' '))
M = m - 45
if M < 0 :
    M = m + 60 - 45
    if H > 0 :
        H -= 1
    else:
        H = 23
print("{} {}".format(H,M))