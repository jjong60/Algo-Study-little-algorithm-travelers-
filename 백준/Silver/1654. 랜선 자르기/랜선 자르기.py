# BAEKJOON 1654
# 이진탐색, 보고 풀었음;(왜 내가 한 방식대로는 안될까)

K, N = map(int, input().split()) # 입력받기
lan_list = [] # 랜선 리스트

for _ in range(K): # K개의 랜선 입력받기
    lan_list.append(int(input()))

start, end = 1, max(lan_list) # 시작과 끝지점

while start <= end: # 양쪽끝에서 시작해서 만나는 지점 (이진탐색)
    mid = (start + end) // 2
    sum_lan = 0
    for i in lan_list: # K번 반복
        sum_lan += int(i // mid) # 자르고 난 뒤의 랜선 개수
    if sum_lan >= N: # 자른 개수가 N보다 더 많다면 더 크게 잘라야함 (이 조건이 없어서 실패한듯)
        start = mid + 1
    else:
        end = mid - 1

print(end)