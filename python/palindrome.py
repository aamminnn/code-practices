def palindrome(x:int):
    # split x
    str_x = str(x)

    # append to list
    list_x = list(str_x)

    # print element from front to back
    string = ''
    reverse_string = ''
    for char in list_x:
        string += char
    
    # print element back to front
    for char in reversed(list_x):
        reverse_string += char
    # if same, true, else false
    if string == reverse_string:
        result = True
    else:
        result = False

    # return boolean
    return result

num = 506
print('palindrome ',num)
result = palindrome(num)
print(result)