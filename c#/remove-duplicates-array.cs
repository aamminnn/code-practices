using System.Drawing;

namespace training{
    public class Duplicate{
        public static int[] sortAscending(int [] n){
            // we got list n unsorted
            // sort using bubble sort
            for (int i=0; i<n.Length; i++ ){
                // loop each element
                for (int j=1; j<n.Length; j++){
                    // loop the element after
                    if (n[i]>n[j]){ //compare both element
                        int temp = n[i];
                        n[i]= n[j];
                        n[j]=temp;
                    }
                }
            }
            // return sorted list
            return n;
        }

        public static int[] generateRandomList(int size, int min, int max){
            Random random = new Random();
            int [] array = new int[size];
            for (int i=0; i<size; i++){
                array[i] = random.Next(min, max);
            }

            return array;
        }

        public static int[] removeDuplicate(int[] n){
            // need to create new List. Array is fixed size
            List<int> newList = new List<int>();
            for (int i = 0; i<n.Length; i++){
                if (!newList.Contains(n[i])){
                    newList.Add(n[i]);
                }
            }
            return newList.ToArray();
        }

        public static void printArray(int [] n){
            for (int i = 0; i<n.Length; i++){
                System.Console.Write(n[i]+" ");
            }
            System.Console.WriteLine();
        }
    }
}