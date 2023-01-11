using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeOfVariables : MonoBehaviour
{
    // Class level scope
    int classLevelScope = 10;
    // Start is called before the first frame update

    void Start()
    {
        Debug.Log(classLevelScope);
    }
}
