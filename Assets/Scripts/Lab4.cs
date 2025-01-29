using UnityEngine;

public class Lab4 : MonoBehaviour
{
    void Start()
    {
        float playerHealth = 100.0f;
        float enemyHealth = 100.0f;
        float playerMana = 20.0f;
        float enemyMana = 200.0f;

        if (playerHealth > enemyHealth)
        {
            Debug.Log("Player has more health than enemy");
        }
        else if (playerHealth < enemyHealth)
        {
            Debug.Log("Enemy has more health than player");
        }
        else
        {
            Debug.Log("Player and enemy have the exact same health!");
        }

        if (playerMana > enemyMana)
        {
            Debug.Log("Player has more mana than enemy");
        }
        else if (playerMana < enemyMana)
        {
            Debug.Log("Enemy has more mana than player");
        }
        else
        {
            Debug.Log("Player and enemy have the exact same mana!");
        }
    }
}
