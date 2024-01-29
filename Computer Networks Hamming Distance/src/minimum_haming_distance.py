from hamming_distance import hamming_distance_calculator


def list_len_checker(items:list, n:int):
    for i in items:
        if len(i) == n : pass
        else : return False
    return True


def find_min_hamming_distance(items:list,n:int):
    if not list_len_checker(items,n): raise ValueError("out of range length")
    else:
        distances = []
        for i in range(len(items)):
            str1 = items[i]
            for j in range(len(items)):
                if i != j: 
                    str2 = items[j]
                    distance = hamming_distance_calculator(str1,str2)
                    distances.append(distance)
        if len(distances)==0: raise ValueError("null list")
        else: return min(distances)


items = ["1101000011010011","1011101111111001","0011111101010001","0001010010000100","0011100010100111",]

print(find_min_hamming_distance(items,16))

