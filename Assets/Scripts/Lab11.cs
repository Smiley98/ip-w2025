using UnityEngine;

public class Lab11 : MonoBehaviour
{
    void Start()
    {
        int n = 5;
        if (n % 2 == 0)
        {
            Debug.Log("Even :)");
        }
        else
        {
            Debug.Log("Odd :(");
        }
    }
}
