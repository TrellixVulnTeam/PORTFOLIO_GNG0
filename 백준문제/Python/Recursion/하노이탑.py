def path(N, START, GOAL):
    print(f"{START} {GOAL}")

def hanoi(N, START, GOAL, TEMP):
    if N == 1:
        path(N, START, GOAL)
    else:
        hanoi(N-1,START,TEMP,GOAL)
        # N-1개의 원반을 A->B로 보조 기둥 C를 이용하여 옮긴다.
        path(N,START,GOAL)
        # 제일 큰 원반을 A->C로 옮긴다
        hanoi(N-1,TEMP, GOAL, START)
        # N-1개의 원반을 B->C 로 보조 기둥A를 이용하여 옮긴다.

hanoi(3,1,3,2)