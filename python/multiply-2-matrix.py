

def multiply_matrices(matrixA, matrixB):
    # the idea of this is for example when we refer to 2X2 matrix,
    # we label the first element (1,1) 1st row 1st column
    # second element (1,2) 1st row 2nd column
    # third element (2,1) 2nd row 1st colummn
    # fourth element (2,2) 2nd row 2nd column
    result = [[0 for _ in range(len(matrixB[0]))] for _ in range(len(matrixA))]
    for i in range(len(matrixA)): #rows in matrixA
        for j in range(len(matrixB[0])): # columns in matrixB because rows matrixA X columns matrixB
            for k in range(len(matrixB)): # rows in matrixB, iterate for each rows in matrixB
                result[i][j] += matrixA[i][k] * matrixB[k][j]
    return result


matrixA = [
    [1,2,3],
    [4,5,6]
]

matrixB = [
    [1,2],
    [3,4],
    [5,6]
]

print('matrixA = ',matrixA)
print('matrixB = ',matrixB)
matrix = multiply_matrices(matrixA, matrixB)
print('result = ', matrix)