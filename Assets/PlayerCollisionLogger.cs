using UnityEngine;

public class PlayerCollisionLogger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Va chạm (Collision) với: " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Đi vào Trigger với: " + other.gameObject.name);
    }
}
