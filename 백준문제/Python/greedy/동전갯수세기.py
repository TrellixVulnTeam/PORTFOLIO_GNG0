N = 1260
cnt = 0
array = [500,100,50,10]

for coin in array:
    cnt += N // coin
    N = N % coin
print(cnt)