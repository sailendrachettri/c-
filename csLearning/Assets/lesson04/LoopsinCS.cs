using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsinCS : MonoBehaviour
{
    List<string> Players = new List<string>() {"Sailendra", "Topzer", "Neelam"};
    // Start is called before the first frame update
    void Start()
    {
        // for(int i = 0; i < 10; i++)   
        // {
        //     Debug.Log("Iteration " + i);
        // }

        foreach(string player in Players)
        {
            Debug.Log(player);
        }
    }
}
