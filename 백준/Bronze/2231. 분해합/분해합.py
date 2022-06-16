# BAEKJOON 2231
# 분해합

N = int(input())
N_list = []

def decompose(n):
    a, m = 0, n
    while n != 0:
        a = int(a + (n % 10))
        n = int(n / 10)
    return int(a + m)

def findSum(A):
    for i in range(A):
        if N == decompose(i):
            return i
    return 0
        
print(findSum(N))