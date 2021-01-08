# DFS 깊이우선탐색
# 스택자료구조를 이용하고, 재귀함수를 이용해보자.

def dfs(graph, v, visited):
    visited[v] = True # 방문 체크
    print(v,end=' ')  # 출력
    # graph[1]안에 [2,3,8]
    # i = 2, 3, 8 방문하지 않았다면 dfs다시
    for i in graph[v]:
        if not visited[i]:
            dfs(graph, i , visited)

graph =[
    [],
    [2,3,8],
    [1,7],
    [1,4,5],
    [3,5],
    [3,4],
    [7],
    [2,6,8],
    [1,7]
]

visited = [False] * 9
dfs(graph,1,visited)

