using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace collectionAss
{
   
    internal class Program
    {
        public static void ReverseInPlace( ArrayList arr)
        {
            int start = 0;
            int end = arr.Count - 1;

            while (start < end)
            {
                
                object temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                
                start++;
                end--;
            }

        }
        static void Main(string[] args)
        {


            #region part02
            #region Q01
            /*1.You are given an ArrayList containing a sequence of elements. 
                try to reverse the order of elements in the ArrayList in-place(in the same arrayList)
                without using the built-in Reverse.Implement a function that takes the ArrayList
                as input and modifies it to have the reversed order of elements.*/
            ArrayList arrayList = new ArrayList() {1,2,3,4,5,6,7 };
            ReverseInPlace(arrayList);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            #endregion

            #endregion
        
}
    }
}
