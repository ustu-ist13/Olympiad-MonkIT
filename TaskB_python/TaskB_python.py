place = input()

row = int(place[0:-1])
row = 0 if 1 <= row <= 2 else 1 if 3 <= row <= 20 else 2

position = place[-1].lower()

window = "window"
aisle = "aisle"
neither = "neither"

switch = [
    {   # a bc d
        window: ["a", "d"],
        aisle: ["b", "c"]
    },
    {   # ab cd ef
        window: ["a", "f"],
        aisle: ["b", "c", "d", "e"]
    },
    {   #abc defg hjk
        window: ["a", "k"],
        aisle: ["c", "d", "g", "h"]
    },
]

print(window if position in switch[row][window] else aisle if position in switch[row][aisle] else neither)
