using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals03 : MonoBehaviour
{
    int score = 10;

    // Start is called before the first frame update
    void Start()
    {
        // scorePrint();
        switchScore();
    }

    void scorePrint()
    {

        if(score < 33)
        {
            Debug.Log("You failed with score of " + score);
        }
        else if(score >= 33 && score <= 80)
        {
            Debug.Log("You passed with the score of " + score);
        }
        else
        {
            Debug.Log("You passed with the best score of " + score);
        }
    }

    
    void switchScore()
    {
        switch(score)
        {

            case 33:
            {
                Debug.Log("Score is " + score);
                break;
            }
            
            case 90:
            {
                Debug.Log("Score is " + score);
                break;
            }
            
            default:
            {
                Debug.Log("Invalid score");
                break;
            }
        }
    }
}
