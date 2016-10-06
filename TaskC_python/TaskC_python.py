input()

sections = [int(x) for x in input().split()]
sums = [sum(sections[x: x + 3]) for x in range(0, len(sections) - 2)]
max_sum = max(sums)

print(max_sum, sums.index(max_sum) + 2)
