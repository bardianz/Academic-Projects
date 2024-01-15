def calculate_need(n,m,max_need,allocated):
    need = []
    for i in range(n):
        row = []
        for j in range(m):
            row.append(max_need[i][j] - allocated[i][j])
        need.append(row)
    return need


def is_safe(processes, available, max_need, allocated):
    n = len(processes)
    m = len(available)
    finish = [False] * n
    work = available[:]
    need = calculate_need(n,m,max_need,allocated)

    count = 0
    while count < n:
        found = False
        for p in range(n):
            if not finish[p]:
                flag = True
                for j in range(m):
                    if need[p][j] > work[j]:
                        flag = False
                        break
                if flag:
                    for j in range(m):
                        work[j]+=allocated[p][j]
                    finish[p] = True
                    found = True
                    count += 1
        if not found:
            return False
    return True

