using System;
namespace SortCollection
{
    public class BubbleSort : ISortCollection
    {
        
        public BubbleSort()
        {

        }

        public int[] Sort(int[] intArr)
        {
            for(int i = 0; i < intArr.Length; i++)
            {
                for(int j = 0; j < intArr.Length - i - 1; j++)
                {
                    if (intArr[j] > intArr[j + 1])
                    {
                        int temp = intArr[j];
                        intArr[j] = intArr[j + 1];
                        intArr[j + 1] = temp;
                    }
                }
            }
            return intArr;
        }
    }
}

