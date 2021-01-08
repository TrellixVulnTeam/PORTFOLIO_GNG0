import math
case = int(input())
# 두 원이 일치하는경우 = -1
# d == 0 , r1 == r2
# 두 원이 한점에서 만나는 경우(외접),(내접) = 1
# 가장 큰수 = 나머지 두수의 합

# 두 원이 만나지 않는 경우(외접),(내접) = 0
# 가장 큰수 > 나머지 두수의 합

for i in range(case):
    x1,y1,r1,x2,y2,r2 = map(int,input().split())
    d = math.sqrt((x1 - x2)**2 + (y1 - y2)**2)
    R = [r1,r2,d]
    m = max(R)
    R.remove(m)
    if d == 0 and r1 == r2:
        print(-1)
    elif m == R[0] + R[1]:
        print(1)
    elif m > R[0] + R[1]:
        print(0)
    else:
        print(2)
