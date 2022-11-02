using System;

namespace SortCollection
{
    public class QuickSort : ISortCollection
    {
        public QuickSort()
        {
            /*
             * Quick Sort Algorithm
             * 1. Choose the highest index value has pivot
             * 2. Take two variables to point left and right of the list excluding pivot
             * 3. left points to the low index
             * 4. right points to the high
             * 5. while value at left is less than pivot move right
             * 6. while value at right is greater than pivot move left
             * 7. if both step 5 and step 6 does not match swap left and right
             * 8. if left ≥ right, the point where they met is new pivot
             */
        }

        public int[] Sort(int[] numArray)
        {
            return Partition(numArray);
        }

        private static int[] Partition(int[] numArray)
        {
            if (numArray.Length < 2)
            {
                return numArray;

            }
            else if (numArray.Length < 3)
            {
                if (numArray[0] > numArray[1])
                {
                    return new int[] { numArray[1], numArray[0] };
                }
            }

            int pivotIndex = numArray.Length - 1;
            int leftIndex = 0;
            int rightIndex = 1;
            int[] res = new int[numArray.Length];
            int[] leftArray;
            int[] rightArray;



            
            for (; leftIndex < numArray.Length; leftIndex++)
            {
                if (numArray[leftIndex] > numArray[pivotIndex])
                {
                    for (rightIndex = leftIndex+1; rightIndex < numArray.Length; rightIndex++)
                    {
                        if (numArray[rightIndex] < numArray[pivotIndex])
                        {
                            int temp = numArray[leftIndex];
                            numArray[leftIndex] = numArray[rightIndex];
                            numArray[rightIndex] = temp;
                            break;
                        }

                        if (rightIndex == pivotIndex)
                        {
                            int temp = numArray[leftIndex];
                            numArray[leftIndex] = numArray[pivotIndex];
                            numArray[pivotIndex] = temp;
                            pivotIndex = leftIndex;
                            break;
                        }
                    }
                }

                if(rightIndex == pivotIndex)
                {
                    break;
                }
            }

            leftArray = new int[pivotIndex];
            rightArray = new int[numArray.Length - pivotIndex];
            for (int i = 0; i < numArray.Length; i++)
            {
                if (i < leftArray.Length)
                {
                    leftArray[i] = numArray[i];
                }
                else
                {
                    rightArray[i - leftArray.Length] = numArray[i];
                }
            }
            return ArrayConcat(Partition(leftArray), Partition(rightArray));

        }

        private static int[] ArrayConcat(int[] array1, int[] array2)
        {
            int[] newArray = new int[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                newArray[i] = array1[i];
            }
            for(int i = 0; i < array2.Length; i++)
            {
                newArray[array1.Length + i] = array2[i];
            }

            return newArray;
        }
    }
}

