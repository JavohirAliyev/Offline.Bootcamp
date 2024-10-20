







namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public int FindMissingNumber(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i-1] + 1)
            {
                return nums[i];
            }
        }

        return 0;
    }

    public int FindPeakElement(int[] nums)
    {
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
            {
                return i;
            }
        }

        return 0;
    }

    public bool IsArraySorted(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i-1])
            {
                return false;
            }
        }

        return true;
    }

    public int MaxValueInArray(int[] array)
    {
        var max = array[0];
        foreach(var i in array)
            if(i > max)
                max = i;

        return max;
    }

    public void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
    {
        int i = 0;
        int j = 0;
        while(i < m){
            if(nums1[i] > nums2[j]){
                
            }
        }
    }

    public int RemoveDuplicates(int[] array)
    {
        int n = array.Length;
        for(int i = 1; i < array.Length - 1; i++){
            if(array[i] == array[i - 1]){
                array[i] = array[i + 1]
                n--;
            }
        }

        return n;
    }

    public int[] ReverseArray(int[] array)
    {
        for(int i = 0; i < array.Length / 2; i++)
        {
            (array[i], array[array.Length - i - 1]) = (array[array.Length - i - 1], array[i]);
        }

        return array;
    }

    public void RotateArray(int[] array, int k)
    {
        throw new NotImplementedException();
    }

    public int[] SortArrayByParity(int[] nums)
    {
        throw new NotImplementedException();
    }

    public int SumOfEvenNumbers(int[]? array)
    {
        int sum = 0;
        for(int i = 0; i< array.Length; i++){
            if(array[i] % 2 == 0)
                sum += array[i];
        }

        return sum;
    }
}