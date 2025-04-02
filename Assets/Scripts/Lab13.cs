using UnityEngine;

// Lab Exercise 9:
// Use classes to re-create the behaviour from lab exercise 2.
// Add 3 additional variables to the Fighter class and carry out the battle simulation!
public class Fighter
{
    public float health;
    public float damage;
}

public class Lab13 : MonoBehaviour
{
    void Start()
    {
        Fighter player = new Fighter();
        Fighter enemy = new Fighter();
        player.health = 100.0f;
        player.damage = 25.0f;
        enemy.health = 50.0f;
        enemy.damage = 10.0f;
    }
}
