using UnityEngine;

public class Lab2 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Math operations with whole-numbers");
        int a = 3;
        int b = 4;
        int sum1 = a + b;
        int dif1 = a - b;
        int product1 = a * b;
        int quotient1 = a / b; // <-- 0 because int can only be whole numbers, so its rounded down
        Debug.Log("Sum of " + a + " plus " + b + " is " + sum1);
        Debug.Log("Difference of " + a + " minus " + b + " is " + dif1);
        Debug.Log("Product of " + a + " times " + b + " is " + product1);
        Debug.Log("Quotient of " + a + " divided " + b + " is " + quotient1);
        Debug.Log("");

        Debug.Log("Math operations with decimal-numbers");
        float c = 3.0f;
        float d = 4.0f;
        float sum2 = c + d;
        float dif2 = c - d;
        float product2 = c * d;
        float quotient2 = c / d;
        Debug.Log("Sum of " + c + " plus " + d + " is " + sum2);
        Debug.Log("Difference of " + c + " minus " + d + " is " + dif2);
        Debug.Log("Product of " + c + " times " + d + " is " + product2);
        Debug.Log("Quotient of " + c + " divided " + d + " is " + quotient2);
        Debug.Log("");
    }
}
