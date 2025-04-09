using UnityEngine;

public class Animal
{
    public virtual void Greet()
    {
        Debug.Log("Placeholder");
    }
}

public class Dog : Animal
{
    public override void Greet()
    {
        Debug.Log("WOOF WOOF!!");
    }
}

public class Cat : Animal
{
    public override void Greet()
    {
        Debug.Log("Meowwwww");
    }
}

public class Lab14 : MonoBehaviour
{
    void Start()
    {
        Animal[] animals = { new Dog(), new Cat() };
        for (int i = 0; i < animals.Length; i++)
            animals[i].Greet();
    }
}
