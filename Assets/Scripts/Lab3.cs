using UnityEngine;

public class Lab3 : MonoBehaviour
{
    void Start()
    {
        // TODO -- create a total of 5 different stats (right now there are 2 different stats)
        float playerHealth = 100.0f;
        float playerDamage = 25.0f;
        float enemyHealth = 50.0f;
        float enemyDamage = 10.0f;

        // TODO -- log all stats at the start of the battle
        Debug.Log("Begin battle! Initial stats:");
        Debug.Log("Player has " + playerHealth + " health and deals " + playerDamage + " damage.");
        Debug.Log("Enemy has " + enemyHealth + " health and deals " + enemyDamage + " damage.");

        // TODO -- simulate 3 turns, and log all (meaningful) stat changes
        Debug.Log("Turn 1:");
        playerHealth -= enemyDamage;
        enemyHealth -= playerDamage;
        Debug.Log("Player takes " + enemyDamage + " damage. Player now has " + playerHealth + " health.");
        Debug.Log("Enemy takes " + playerDamage + " damage. Enemy now has " + enemyHealth + " health.");

        // TODO -- log all stats at the end of the battle
        Debug.Log("End battle. Final stats:");
    }
}
