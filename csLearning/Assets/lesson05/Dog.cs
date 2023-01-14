using UnityEngine;

public class Dog : MonoBehaviour
{
    // Attributes
    string Breed;
    int Age;
    string Color;

    // Functions
    public Dog(string Breed, int Age, string Color)
    {
        this.Breed = Breed;
        this.Age = Age;
        this.Color = Color;
    }

    // Properties
    private string getBreed()
    {
        return Breed;
    }

    private int getAge()
    {
        return Age;
    }
    private string getColor()
    {
        return Color;
    }

    private void printDetails()
    {
        Debug.Log("Details of the Dog are: ");
        Debug.Log("Breed: " + this.getBreed() );
        Debug.Log("Color: " + this.getColor() );
        Debug.Log("Age: " + this.getAge() );
    }

    // Start is called before the first frame update
    void Start()
    {
        Dog tony = new Dog("Ract", 2, "White");
        tony.printDetails();
    }
}
