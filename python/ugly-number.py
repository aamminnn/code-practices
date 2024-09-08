def ugly_number(n:int):
    if n == 1:
        return True
    elif n%2 == 0 and n/2 <=5:
        return True
    elif n%3 == 0 and n/3 <=5:
        return True
    elif n%5 == 0 and n/5 >= 5:
        return True
    else:
        return False


n = 14
print("Ugly number ",n)
result = ugly_number(n)
print(result)

