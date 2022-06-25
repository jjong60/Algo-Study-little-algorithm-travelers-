# BAEKJOON 11650
# 좌표 정렬하기

N = int(input())
N_list = []

for _ in range(N):
    a, b = map(int, input().split())
    N_list.append((a, b))
    
N_list.sort()

for i in range(N):
    print(N_list[i][0], N_list[i][1])