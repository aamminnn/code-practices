using System.Xml.XPath;

namespace training{
    public class UglyNumber{
        public static bool checkUglyNumber(int n){
            if (n == 1){
                return true;
            }
            else if (n%2 == 0 && n/2 <= 5){
                return true;
            }
            else if (n%3 == 0 && n/3 <= 5){
                return true;
            }
            else if (n%5 == 0 && n/5 <= 5){
                return true;
            }
            else{
                return false;
            }
        }
    }
}