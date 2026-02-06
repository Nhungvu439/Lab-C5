using UnityEngine;

public class Physics3D_DemoLogger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(">>> TRIGGER với: " + other.gameObject.name);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(">>> COLLISION với: " + collision.gameObject.name);
    }
}
