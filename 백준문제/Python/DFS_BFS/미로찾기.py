# N x M크기 미로 , 탈출구 n,m
# 갈수없는곳 = 0, 있는곳 = 1로 표시.
# 탈출하기 위해 최소한의 경로
from collections import deque

def bfs(x,y):
    queue = deque()
    # 선입선출
    queue.append((x,y))
    # queue 빌때 까지
    while queue:
        x, y = queue.popleft()
        # 상,하,좌,우
        for i in range(4):
            nx = x + dx[i]
            ny = y + dy[i]
            # 범위초과시
            if nx < 0 or ny < 0 or nx >= n or ny >= m:
                continue
            # 0일 때
            if graph[nx][ny] == 0:
                continue
            # 값이 = 1이면
            if graph[nx][ny] == 1:
                # 현재 값 = 이전의 값 + 1
                graph[nx][ny] = graph[x][y] + 1
                # nx,ny추가하고
                queue.append((nx,ny))
    #출력은 가장 마지막.
    return graph[n-1][m-1]

n , m = map(int,input().split())
graph = []
for i in range(n):
    graph.append(list(map(int,input())))
# 동 서 남 북
dx = [1, -1, 0, 0]
dy = [0, 0, 1, -1]

print(bfs(0,0))