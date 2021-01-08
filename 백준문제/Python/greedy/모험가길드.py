# 모험가의 공포도가 주어진다
# 그룹을 구성하기위해 공포도가 X인 모험가는 반드시 X명이상 구성
# 그룹수의 최댓값
n = input()
data = list(map(int,input().split()))
data.sort()
list = []
cnt = 0
for i in range(int(n)):
    list.append(data[i])
    if len(list) == max(list):
       cnt += 1
       list = []
print(list)
print(cnt)







