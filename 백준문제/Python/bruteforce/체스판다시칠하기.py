# MN개의 단위 정사각형으로 나누어져 있는 M*N 크기의 보드를 찾았다
# 체스판은 검은색과 흰색이 번갈아서 칠해져 있어야 한다
# 이 정의를 따르면 체스판을 색칠하는 경우는 두 가지뿐이다
# 하나는 맨 왼쪽 위 칸이 흰색인 경우, 하나는 검은색인 경우이다.
# 보드를 잘라서 8*8 크기의 체스판으로 만들려고 한다.
# 다시 칠해야 하는 정사각형의 최소 개수
# N과 M은 8보다 크거나 같고, 50보다 작거나 같은 자연수이다
# 첫째 줄에 N과 M이 주어진다
# 시간제한 2
# 8 8
# WBWBWBWB
# BWBWBWBW
# WBWBWBWB
# BWBBBWBW
# WBWBWBWB
# BWBWBWBW
# WBWBWBWB
# BWBWBWBW
# 10 13
# BBBBBBBBWBWBW
# BBBBBBBBBWBWB
# BBBBBBBBWBWBW
# BBBBBBBBBWBWB
# BBBBBBBBWBWBW
# BBBBBBBBBWBWB
# BBBBBBBBWBWBW
# BBBBBBBBBWBWB
# WWWWWWWWWWBWB
# WWWWWWWWWWBWB
n , m = map(int, input().split())
chess = []
for _ in range(n):
    chess.append(input())

cnt_arr = []
for i in range(n-7):  # i, j 는 꼭지점이 될수있는 점
    for j in range(m-7):
        # 이점 들로부터 8 * 8 크기를 탐색. Count가 최소한이 되야하기때문에 모든지점을 다 탐색한다.
        cntB = 0
        cntW = 0
        # 두가지의 경우를 조사한다
        # 꼭지점이 = B,W일때
        for a in range(8):
            for b in range(8):
                if (a + b) % 2 == 0:
                    if chess[a + i][b + j] == 'B':
                        continue
                else:
                    if chess[a + i][b + j] != 'B':
                        continue
                cntB += 1
        for a in range(8):
            for b in range(8):
                if (a + b) % 2 == 0:
                    if chess[a + i][b + j] == 'W':
                        continue
                else:
                    if chess[a + i][b + j] != 'W':
                        continue
                cntW += 1
        cnt_arr.append(cntW)
        cnt_arr.append(cntB)
print(min(cnt_arr))



