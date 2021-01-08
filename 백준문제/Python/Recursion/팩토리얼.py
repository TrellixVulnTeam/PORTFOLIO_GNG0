def recursion_fact(n):
    if n == 1 or n == 0:
        return 1
    return  n * recursion_fact(n-1)

n = int(input())
print(recursion_fact(n))