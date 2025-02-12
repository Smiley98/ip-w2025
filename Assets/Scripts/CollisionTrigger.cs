using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    // When we begin a proximity-based collision (no physics response)
    void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }

    // When we end a proximity-based collision (no physics response)
    void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.green;
    }
}
