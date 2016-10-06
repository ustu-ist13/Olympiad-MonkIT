n, k = [int(x) for x in input().split()]
bumbums = [int(x) for x in input().split()]

print(sum({x - k for x in bumbums if x > k}), sum({k - x for x in bumbums if k > x}))
