import random

unsorted_array = []
for x in range(10):
    x = random.randint(1,99)
    unsorted_array.append(x)
print(unsorted_array)

# 1. sort and take 2nd element only if case no duplicate element
# example (5,2,6,1,0,7)
n = len(unsorted_array)
for x in range(n):
    for y in range(n-1):
        if unsorted_array[y] < unsorted_array[y+1]:
            unsorted_array[y], unsorted_array[y+1] = unsorted_array[y+1], unsorted_array[y]

sorted_array = unsorted_array
print(sorted_array) # which is now sorted

for i in range(n):
    if sorted_array[i] != sorted_array[i+1]:
        print('2nd largerst element: ', sorted_array[i+1])
        break
    continue

