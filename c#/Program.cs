using System.Xml.XPath;
using training;
public class Program {
    public static void Main(String[] args) {
        System.Console.WriteLine("Hello, World!");

        // 1. 2nd largest element in array
        int arraySize = 10; // Size of the array
        int minValue = 1;   // Minimum value for random numbers
        int maxValue = 100; // Maximum value for random numbers
        int[] randomArray = Utils.randomNumber(arraySize, minValue, maxValue);
        List<int> myarray = new List<int> (randomArray);
        Console.WriteLine("Unsorted Array: " + string.Join(", ", myarray));
        List<int> sortedArray = Utils.sortDescending(myarray);
        Console.WriteLine("Unsorted Array: " + string.Join(", ", sortedArray));
        int secondElement = Utils.findSecondElement(sortedArray);
        System.Console.WriteLine("second element: "+ secondElement);

        //2 Array multiplication
        int [,] matrixA = {
            {1,2,3},
            {4,5,6}
        };
        int [,] matrixB = {
            {1,2},
            {3,4},
            {5,6}
        };
        System.Console.WriteLine("Matrix A");
        Matrix.displayMatrix(matrixA);
        System.Console.WriteLine("Matrix B");
        Matrix.displayMatrix(matrixB);
        int [,] result = Matrix.multiplyMatrix(matrixA, matrixB);
        Matrix.displayMatrix(result);

        //3 Palindrome
        int num = 1010;
        System.Console.WriteLine("Palindrome "+num);
        bool palindrome_result = Palindrome.palindrome(num);
        System.Console.WriteLine(palindrome_result);
    }

    
}
