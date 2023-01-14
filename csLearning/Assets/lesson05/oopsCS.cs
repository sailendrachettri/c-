using UnityEngine;

public class oopsCS : MonoBehaviour
{
    int age = 21;

    void Start()
    {
        printAge();
    }

    void printAge()
    {
        Debug.Log("Age: " + age);
    }
}
