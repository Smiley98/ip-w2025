using UnityEngine;
using System.Collections.Generic;

public class Lab12 : MonoBehaviour
{
    int[] FindOdd(int[] numbers)
    {
        // Tally our odd numbers so we know how big our output array must be!
        int oddCount = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 1)
                oddCount++;
        }
        int[] oddNumbers = new int[oddCount];

        int oddIndex = 0;
        // Now that we know the amount of odd numbers, we can add them to the array!
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 1)
            {
                oddNumbers[oddIndex] = numbers[i];
                oddIndex++;
            }
        }

        return oddNumbers;
    }

    List<int> FindOddList(int[] numbers)
    {
        List<int> odd = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 1)
            {
                // Lists can be advantageous over arrays because we can add & remove dynamically!
                odd.Add(numbers[i]);
            }
        }
        return odd;
    }

    void Start()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int[] odd = FindOdd(numbers);
        for (int i = 0; i < odd.Length; i++)
            Debug.Log(odd[i]);

        List<int> oddList = FindOddList(numbers);
        oddList.RemoveAt(1);
        // Remove middle element before outputting to showcase the power of lists!

        for (int i = 0; i < oddList.Count; i++)
            Debug.Log(oddList[i]);
    }
}
