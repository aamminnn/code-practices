namespace training{
    public class Matrix{
        public static void displayMatrix (int [,] matrix){
            int rows = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for (int i = 0; i<rows; i++){
                for (int j = 0; j<col; j++){
                    System.Console.Write(matrix[i,j] + " ");
                }
                System.Console.WriteLine();
            }
        }

        public static int [,] multiplyMatrix (int [,] matrixA, int[,] matrixB) {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            if (colsA != rowsB){
                throw new InvalidOperationException("Cannot like this array not same size");
            }

            int [,] result = new int [rowsA,colsB]; 

            for (int i = 0; i < rowsA; i++){
                for (int j = 0; j<colsB; j++){
                    result[i,j] = 0;
                    for (int k = 0; k<rowsB; k++) {
                        result[i,j] += matrixA[i,k] * matrixB[k,j];
                    }
                }
            }

            return result;
        }

        
    }
}