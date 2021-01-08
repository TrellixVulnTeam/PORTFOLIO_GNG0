# N x M 크기의 얼음틀이 존재
# 구멍이 뚫려있는 부분은 0, 칸막이가 존재하는 부분은 1로 표시
# 구멍이 뚫려 있는 부분끼리 상,하,좌,우 붙어있는 경우 서로 연결된것으로 간주

def dfs(x , y):
    # 주어진 범위를 벗어나는 경우에는 즉시 종료
    if x <= -1 or x >= n or y <= -1 or y >= m:
        return False
    if graph[x][y] == 0:
        graph[x][y] = 1
        # 상,하,좌,우 위치들도 모두 재귀적 호출
        dfs(x - 1, y)
        dfs(x, y - 1)
        dfs(x + 1, y)
        dfs(x, y + 1)
        return True
    return False

n, m = map(int, input().split())
graph = []
for i in range(n):
      graph.append(list(map(int, input())))

cnt = 0
for i in range(n):
    for j in range(m):
        if dfs(i,j) == True:
            cnt += 1
print(cnt)





