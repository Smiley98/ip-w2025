using UnityEngine;

public class Lab6 : MonoBehaviour
{
    void Start()
    {
        // An array of 10 numbers
        float[] numbers = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f, 7.7f, 8.8f, 9.9f, 10.0f };
        
        // We access arrays using indices which are integers corresponding to the position of each value
        Debug.Log("We have " + numbers.Length + " numbers in our array.");
        Debug.Log("First number is " + numbers[0]);
        Debug.Log("Second number is " + numbers[1]);
        Debug.Log("Third number is " + numbers[2]);
        Debug.Log("Fourth number is " + numbers[3]);
        Debug.Log("Fifth number is " + numbers[4]);
        Debug.Log("Sixth number is " + numbers[5]);
        Debug.Log("Seventh number is " + numbers[6]);
        Debug.Log("Eighth number is " + numbers[7]);
        Debug.Log("Nineth number is " + numbers[8]);
        Debug.Log("Tenth number is " + numbers[9]);

        // Generally we write for-loops that start from zero and go till < n is because of arrays!
        for (int i = 0; i < numbers.Length; i++)
        {
            float number = numbers[i];
            Debug.Log("Number at index " + i + " is " + number);
        }

        // We can use square-brackets [] to read AND write to arrays
        numbers[0] = 69.0f;
        numbers[1] = 420.0f;
        numbers[2] = 666.0f;
        numbers[3] = 1337.0f;
        numbers[4] = 9001.0f;

        Debug.Log("Outputing newly-formed meme numbers");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}
