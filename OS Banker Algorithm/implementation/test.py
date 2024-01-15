from BankerAlgorithm import is_safe

processes = [0, 1, 2, 3, 4]
max_need = [
    [7, 5, 3],
    [3, 2, 2],
    [9, 0, 2],
    [2, 2, 2],
    [4, 3, 3]
]
allocated = [
    [0, 1, 0],
    [2, 0, 0],
    [3, 0, 2],
    [2, 1, 1],
    [0, 0, 2]
]

available = [3, 3, 2]

if is_safe(processes, available, max_need, allocated):
    print("The system is in a safe state.")
else:
    print("The system is in an unsafe state.")