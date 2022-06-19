# BAEKJOON 10250
# ACM호텔

T = int(input())

for _ in range(T):
    H, W, N = map(int, input().split())
    floor = N % H
    num   = N // H + 1
    if N % H == 0:
        floor = H
        num   = N // H

    print(floor * 100 + num) 