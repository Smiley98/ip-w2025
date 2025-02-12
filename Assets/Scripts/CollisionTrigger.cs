using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.green;
    }
}
