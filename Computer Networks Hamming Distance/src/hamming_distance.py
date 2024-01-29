string1 = "1010101"
string2 = "1001001"


def hamming_distance_calculator(str1,str2):
        str1 = str(str1)
        str2 = str(str2)
        if not len_equality_checker(str1,str2) : raise ValueError ("different length")
        counter = 0
        for i in range(len(str2)):
                i = int(i)
                if str1[i] != str2[i]:
                        counter += 1
        return(counter)


def len_equality_checker(x,y):
        
        if len(x) == len(y) and x.isdigit() and y.isdigit() : return True
        return False


# print(hamming_distance_calculator(string1,string2))