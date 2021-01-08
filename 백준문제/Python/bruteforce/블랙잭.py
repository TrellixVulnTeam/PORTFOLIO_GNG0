n , value = map(int,input().split())
card = list(map(int,input().split()))
sum_list = []
for i in range(2, n):
    for j in range(0, i-1):
        for k in range(j+1, i):
            val = card[i] + card[j] + card[k]
            if val <= value:
                sum_list.append(val)
print(max(sum_list))
