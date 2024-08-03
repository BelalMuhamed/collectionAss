using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Numerics;

namespace collectionAss
{
    public interface IIndexed<T>
    {
        T this[int index] { get; set; }
    }


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
        public static List<int> ReturnEven(List<int> list)
        {
            List<int> result = new List<int>();

            if (list.Count > 0) 
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        result.Add(list[i]);
                    }
                    
                }
            }
            return result;


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

            
            #region Q02
            /*2.You are given a list of integers. 
             Your task is to find and return a new list containing only the even numbers from the given list.*/
            Console.Clear();
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            List<int> EvenNums = ReturnEven(list);
            foreach (var item in EvenNums)
            {
                Console.WriteLine(item);
            }


            #endregion


            #endregion

        }
    }
}
