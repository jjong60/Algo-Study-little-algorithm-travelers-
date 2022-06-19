# BAEKJOON 10773
# 제로

K = int(input())
stack = []
for _ in range(K):
    a = int(input())
    if a != 0:
        stack.append(a)
    elif a == 0:
        stack.pop()

print(sum(stack))