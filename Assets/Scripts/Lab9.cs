using UnityEngine;

public class Lab9 : MonoBehaviour
{
    // Searches the numbers array for the number number.
    // If number is found, return its position (index ie 0, 1, 2, 3, etc).
    // Otherwise, return -1 (since indices cannot be negative, indicating it wasn't found).
    int LinearSearch(int[] numbers, int number)
    {
        // loop through the numbers array
        // within the loop, check if the current number (numbers[i]) is equal to the desired number
        // if so, return its position (i)
        // otherwise return -1
        return -1;
    }

    void Start()
    {
        int[] numbers = { 17, 23, 5, 11, 2, 29, 3 };

        int positionOf2 = LinearSearch(numbers, 2);     // Should be 4
        int positionOf123 = LinearSearch(numbers, 2);   // Should be -1
        Debug.Log("Position of 2 (should be 4): " + positionOf2);
        Debug.Log("Position of 123 (should be -1): " + positionOf123);
    }
}
