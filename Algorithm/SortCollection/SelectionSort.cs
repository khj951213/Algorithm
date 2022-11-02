using System;
namespace SortCollection
{
    public class SelectionSort :ISortCollection
    {
        public SelectionSort()
        {
        }

        public int[] Sort(int[] intArr)
        {
            for(int i = 0; i < intArr.Length-1; i++)
            {
                for(int j = i+1; j < intArr.Length; j++)
                {
                    if (intArr[i] > intArr[j])
                    {
                        int temp = intArr[i];
                        intArr[i] = intArr[j];
                        intArr[j] = temp;
                    }
                }
            }

            return intArr;
        }

        
    }
}

