using UnityEngine;

public class CollisionPhysics : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Random.insideUnitCircle.normalized * 10.0f;
    }

    // When we begin a physics-based collision (moves objects so they don't overlap)
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " began colliding with " +  collision.gameObject.name);
    }

    // When we end a physics-based collision (moves objects so they don't overlap)
    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " ended colliding with " +  collision.gameObject.name);
    }
}
