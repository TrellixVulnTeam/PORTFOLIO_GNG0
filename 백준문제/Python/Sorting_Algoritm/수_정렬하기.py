# 삽입정렬은 자신보다 앞의 원소가 큰지 작은지 비교
# 2번째는 1번째와, 3번째는 2번째,1번째와 큰지 작은지 비교
# 4번째는 3,2,1과비교
# 5번째는 4,3,2,1과 비교
# n번째는 n-1,n-2,.....1과 비교

def InsertSorting(number):
    for i in range(1 , len(number)):
        for j in range(i , -1, -1):
            if number[j + 1] < number[j]:
                number[j],number[j + 1] = number[j + 1],number[j]

n = int(input())
number = []
for _ in range(n):
    number.append(int(input()))

InsertSorting(number)

for i in range(n):
    print(number[i])