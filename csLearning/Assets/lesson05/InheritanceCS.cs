using UnityEngine;

namespace StudyOops
{
    public class InheritanceCS : MonoBehaviour
    {
        int myAge = 21;
    }

    public class Child : InheritanceCS
    {
        void Display()
        {
            InheritanceCS oops = new InheritanceCS();
            Debug.Log("Age: " + oops.myAge);
        }

        void Start()
        {
            Display();
        }
    }
    
}
