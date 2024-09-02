using System.Security.Principal;

namespace training{
    public class Utils {
        public static int[] randomNumber(int size, int min, int max){
        Random random = new Random();
        int [] array = new int[size];

        for (int i=0; i<size; i++){
            array[i] = random.Next(min,max+1);
        }
        return array;
        }   
        public static List<int> sortDescending(List<int> array){
            for (int i=0; i<array.Count; i++){
                for (int j = 0; j<array.Count-1; j++){
                    if (array[j] < array[j+1]){
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            } // bubble sort
            return array;
        }

        public static int findSecondElement (List<int> array){
            int secondElement = 0;
            for (int i = 0; i<array.Count; i++){
                if (array[i] != array[i+1]){
                    secondElement = array[i+1];
                    break;
                }
            }
            return secondElement;
        }
    }
}