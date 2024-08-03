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

        static int FirstNonRepeatedCharacterIndex(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            Dictionary<char, (int count, int index)> charCountMap = new Dictionary<char, (int, int)>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (charCountMap.ContainsKey(c))
                {
                    charCountMap[c] = (charCountMap[c].count + 1, charCountMap[c].index);
                }
                else
                {
                    charCountMap[c] = (1, i);
                }
            }

            foreach (var kvp in charCountMap)
            {
                if (kvp.Value.count == 1)
                {
                    return kvp.Value.index;
                }
            }
            return -1;
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


            #region Q03
            /* 3.implement a custom list called FixedSizeList<T> with a predetermined capacity.This list 
             * should not allow more elements than its capacity 
             * and should provide clear messages if one tries to exceed it or access invalid indices.
             Requirements:
             1.Create a generic class named FixedSizeList<T>.
             2.	Implement a constructor that takes the fixed capacity of the list as a
             parameter.
             3.Implement an Add method that adds an element to the list, but throws an exception 
            if the list is already full.
            4.Implement a Get method that retrieves an element at a specific index in the list but 
            throws an exception for invalid indices.*/
            try
            {
                FixedSizeList<int> fixedSize = new FixedSizeList<int>(2);
                fixedSize.Add(1);
                fixedSize.Add(2);
                //fixedSize.Add(2);    for test try catch

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }

            #endregion



            #region Q04
            /*4-Given a string, find the first non-repeated character in it and return its index.
             * If there is no such character, return -1. Hint you can use dictionary*/
            #endregion
            string input = "GGhhhlmmni";
            int index = FirstNonRepeatedCharacterIndex(input);
            Console.WriteLine(index);

            #endregion

        }
    }
}
