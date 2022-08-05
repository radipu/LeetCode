using System;

namespace Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            //Merge both Arrays First
            int[] nums3 = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, 0, nums3, 0, nums1.Length);
            Array.Copy(nums2, 0, nums3, nums1.Length, nums2.Length);

            Array.Sort(nums3);

            double median;
            if (nums3.Length % 2 == 0)
            {
                int midIndex = nums3.Length / 2;
                int med1 = nums3[midIndex - 1];
                int med2 = nums3[midIndex];
                median = (med1 + med2) / 2.0;
            }
            else
            {
                median = nums3[nums3.Length / 2];
            }

            return median;

            //Linear Search using Two Pointers
            //int n1 = nums1.Length;
            //int n2 = nums2.Length;
            //int totalLength = n1 + n2;
            //int i = 0;
            //int j = 0;
            //int m1 = -1;
            //int m2 = -1;
            //int medianLength = totalLength % 2 == 0
            //    ? (totalLength + 1) / 2
            //    : totalLength / 2;
            //for (int count = 0; count <= medianLength; count++)
            //{
            //    m2 = m1;

            //    if (i != n1 && j != n2)
            //    {
            //        m1 = (nums1[i] > nums2[j])
            //            ? nums2[j++]
            //            : nums1[i++];
            //    }
            //    else if (i < n1)
            //    {
            //        m1 = nums1[i++];
            //    }
            //    else
            //    {
            //        m1 = nums2[j++];
            //    }
            //}

            //double median = totalLength % 2 == 0
            //    ? (m1 + m2) / 2.0
            //    : m1;

            //return median;

            //Binary Search
            //if (nums1.Length > nums2.Length)
            //    return FindMedianSortedArrays(nums2, nums1);

            //int nums1Length = nums1.Length;
            //int nums2Length = nums2.Length;

            //int low = 0;
            //int high = nums1.Length;
            //while (low <= high)
            //{
            //    int partitionNums1 = (low + high) / 2;
            //    int partitionNums2 = (nums1Length + nums2Length + 1) / 2 - partitionNums1;

            //    int nums1MaxLeftNums1 = partitionNums1 == 0 ? int.MinValue : nums1[partitionNums1 - 1];
            //    int nums2MaxLeftNums2 = partitionNums2 == 0 ? int.MinValue : nums2[partitionNums2 - 1];
            //    int nums1MinRightNums1 = partitionNums1 == nums1Length ? int.MaxValue : nums1[partitionNums1];
            //    int nums2MinRightNums2 = partitionNums2 == nums2Length ? int.MaxValue : nums2[partitionNums2];

            //    if (nums1MaxLeftNums1 <= nums2MinRightNums2 && nums2MaxLeftNums2 <= nums1MinRightNums1)
            //    {
            //        if ((nums1Length + nums2Length) % 2 == 0)
            //            return (Math.Max(nums1MaxLeftNums1, nums2MaxLeftNums2) +
            //                    Math.Min(nums1MinRightNums1, nums2MinRightNums2)) / 2d;
            //        else
            //            return Math.Max(nums1MaxLeftNums1, nums2MaxLeftNums2);
            //    }

            //    if (nums1MaxLeftNums1 > nums2MinRightNums2)
            //    {
            //        high = partitionNums1 - 1;
            //    }
            //    else if (nums2MaxLeftNums2 > nums1MinRightNums1)
            //    {
            //        low = partitionNums1 + 1;
            //    }
            //}

            //return 0d;
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 900 };
            int[] nums2 = { 2, 13, 17, 30, 45 };
            Console.Write("Median is " + FindMedianSortedArrays(nums1, nums2));
        }
    }
}
