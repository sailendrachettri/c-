using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StudyOops
{
    public class Student
    {
        private string studentName;
        private int studentAge;

        public string Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }

        public int Age
        {
            get
            {
                return studentAge;
            }
            set
            {
                studentAge = value;
            }

        }
    }

    public class EncapsulationInCs : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Student student = new Student();

            student.Name = "Raju";
            student.Age = 21;
            
            Debug.Log("Name: " + student.Name);
            Debug.Log("Age: " + student.Age);
        }
    }
}
