# 첫째 줄에 공간의 크기를 나타내는 N이 주어짐 1<= N <= 100
# 둘째 줄에 여행가 A가 이동할 계획서에 내용이 주어짐 1 <= 이동횟수 <= 100
# 최종 도착지점 X,Y좌표를 나타내어라
# 시작점 (1,1)



n = int(input())
plans = input().split()
x,y = 1,1

# 동 북 서 남
dx = [0, -1, 0, 1]
dy = [1, 0, -1, 0]
move_around = ['R', 'U', 'L', 'D']

for plan in plans:
    index = move_around.index(plan)
    nx = x + dx[index] #다음 위치
    ny = y + dy[index] #다음 위치
    if nx < 1 or nx > n or ny < 1 or ny > n:
        continue
    x,y = nx, ny
print(x,y)
