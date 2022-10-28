using System;
namespace SortCollection
{
    public class BubbleSort
    {
        
        public BubbleSort()
        {

        }

        public static int[] Build(int[] intArr)
        {
            for(int i = 0; i < intArr.Length; i++)
            {
                for(int j = 0; j < intArr.Length - i - 1; j++)
                {
                    int temp = intArr[j];
                    intArr[j] = intArr[j + 1];
                    intArr[j + 1] = temp;
                }
            }
            return intArr;
        }
    }
}

