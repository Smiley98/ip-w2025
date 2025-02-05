using UnityEngine;

public class Lab5 : MonoBehaviour
{
    void Start()
    {
        // for-loops have 3 parts: 1. Counter Creation. 2. Counter Check. 3. Counter Change.

        Debug.Log("Counting up by 1 from 1 to 10");
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("Counting to: " +  i);
        }

        Debug.Log("Counting up by 2 from 0 to 8");
        for (int i = 0; i < 10; i += 2)
        {
            Debug.Log("Counting to: " + i);
        }

        Debug.Log("Counting down by 1 from 5 to 1");
        for (int i = 5; i > 0; i--)
        {
            Debug.Log("Counting to: " + i);
        }

        Debug.Log("Counting down by 1 from 5 to 0");
        for (int i = 5; i >= 0; i--)
        {
            Debug.Log("Counting to: " + i);
        }
    }
}
