using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num1 = 10;
        int num2 = 5;

        addition(num1, num2);
        subtraction(num1, num2);
        division(num1, num2);
        multiplication(num1, num2);
    }

    void addition(int num1, int num2)
    {
        int result = num1 + num2;
        Debug.Log("Addition of " + num1 + " and " + num2 + " is " + result);
    }

    void multiplication(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log("Multiplication of " + num1 + " and " + num2 + " is " + result);
    }

    void division(int num1, int num2)
    {
        int result = num1 / num2;
        Debug.Log("Division of " + num1 + " and " + num2 + " is " + result);
    }
    void subtraction(int num1, int num2)
    {
        int result = num1 - num2;
        Debug.Log("Difference of " + num1 + " and " + num2 + " is " + result);
    }
}
