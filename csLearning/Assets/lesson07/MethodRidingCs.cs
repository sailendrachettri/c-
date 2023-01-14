using UnityEngine;

namespace StudyOopsMethodOverriding
{
    public class Plant
    {
        public virtual void tree()
        {
            Debug.Log("I am groot in plant class.");
        }
    }

    public class MangoTree : Plant
    {
        public override void tree()
        {
            Debug.Log("I am tree in MongoTree class.");
        }
    }

    public class MethodRidingCs : MonoBehaviour
    {
        void Start()
        {
            Plant plant = new Plant();
            plant.tree();

            plant = new MangoTree();
            plant.tree();

            print("Hello World");
        }
    }
}
