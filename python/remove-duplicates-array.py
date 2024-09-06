import random

def sort_ascending(n:list):
    for i in range(len(n)):
        for j in range(len(n)-1):
            if n[j] > n[j+1]:
                n[j],n[j+1] = n[j+1],n[j]
    return n


def remove_duplicate(n:list):
    result = []
    for i in n:
        if i not in result:
            result.append(i)
    return result

arr = []
for x in range(10):
    x = random.randint(11,99)
    arr.append(x)
print('Unsorted Array: ',arr)

sorted_arr = sort_ascending(arr)
print(sorted_arr)

result = remove_duplicate(sorted_arr)
print(result)