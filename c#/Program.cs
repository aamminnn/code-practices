using training;
public class Program {
    public static void Main(String[] args) {
        System.Console.WriteLine("Hello, World!");

        // 1
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
    }

    
}
