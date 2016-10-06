import re

count = int(input())
regex = re.compile("The Machinegunners played (\S+) game, scored (\d+) goals, and conceded (\d+) goals.")
groups = [regex.match(input()).groups() for x in range(0, count)]
tests = [{"place": x[0], "scored": int(x[1]), "conceded": int(x[2])} for x in groups]

for test in tests:
    min_s = test["conceded"] - test["scored"] + 1
    min_s = 30 if min_s > 30 else 0 if min_s < 0 else min_s

    max_s = 30 + test["conceded"] - test["scored"]
    max_s -= int(max_s > test["conceded"]) if test["place"] == "home" else int(test["scored"] == 30)
    max_s = 30 if max_s > 30 else 0 if max_s < 0 else max_s

    print(min_s, max_s)
