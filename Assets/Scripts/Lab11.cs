using UnityEngine;

public class Lab11 : MonoBehaviour
{
    bool IsEven(int n)
    {
        // % means "modulus".
        // Modulus calculates the remainder of a division.
        // If we want to know whether a number is even, we can check if its divisible by 2!
        return n % 2 == 0;
    }

    void Start()
    {
        // Display even vs odd numbers 1-10
        for (int i = 1; i <= 10; i++)
        {
            if (IsEven(i))
            {
                Debug.Log(i + " is even :)");
            }
            else
            {
                Debug.Log(i + " is odd :(");
            }
        }
    }
}
