def factorial_iteraive(n):
    result = 1

    for i in range(1, n + 1):
        result *= i
    return result

def factrorial_reCursive(n):
    if n <= 1 :
        return 1
    #n! = n * (n-1)!를 그대로 코드로 작성
    return n * factrorial_reCursive(n-1)

print('반복적으로 구현:', factorial_iteraive(5))
print('재귀적으로 구현:', factrorial_reCursive(5))