namespace training{
    public class Palindrome{
        public static bool palindrome(int num){
            // convert int to string
            string num_s = num.ToString();

            // split string to char
            char[] num_c = num_s.ToCharArray();

            // read string from front to back
            string result = "";
            string result_reverse = "";

            for (int i=0; i<num_c.Length; i++){
                result += num_c[i];
            }

            // read string from back to front
            for (int i = num_c.Length-1; i>=0; i--){
                result_reverse += num_c[i];
            }
            
            // if result == result reverse, true, else false
            if (result == result_reverse){
                return true;
            }
            else{
                return false;
            }
        }
    }
}