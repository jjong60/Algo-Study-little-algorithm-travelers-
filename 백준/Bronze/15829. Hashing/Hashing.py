# BAEKJOON 15829
# Hashing

L = int(input())
L_list = list(input())
sum = 0
for i in range(L):
    sum = sum + (ord(L_list[i]) % 96) * (31 ** i)
print(sum % 1234567891)