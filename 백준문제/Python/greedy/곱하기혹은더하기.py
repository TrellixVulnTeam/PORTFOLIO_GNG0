# 숫자로만 이루어진 문자열을 입력으로 받는다
# 각숫자 사이에 연산자를 넣어서 최대값을 만든다.
# 모든연산은 왼쪽부터 이루어진다.

data = input()
result = int(data[0])

for i in range(1, len(data)):
    num = int(data[i])
    if num <= 1 or result <= 1:
        result += num
    else :
        result *= num
print(result)











