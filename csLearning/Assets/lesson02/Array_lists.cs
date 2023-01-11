using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_lists : MonoBehaviour
{

    // Array decelaration
    int[] RollNumbers = new int[5];
    // string[] RollNumbers = new string[5];
    // float[] RollNumbers = new float[5];
    // char[] RollNumbers = new char[5];
    
    // List decelaration
    // List<int> myList = new List<int>();
    List<int> myList = new List<int>() {10, 12, 14, 16, 18, 20};
    

    // Start is called before the first frame update
    void Start()
    {
        // RollNumbers[0] = 110;
        // RollNumbers[1] = 210;
        // Debug.Log("RollNumbers[0]: " + RollNumbers[0]);
        // Debug.Log("RollNumbers[1]: " + RollNumbers[1]);
        // Debug.Log("Length of an Array: " + RollNumbers.Length);
        
        myList.Add(22);
        Debug.Log("myList count: " + myList.Count);
    }
}
