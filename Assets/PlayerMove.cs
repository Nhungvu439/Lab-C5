using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(h * 5f * Time.deltaTime, 0, 0);
    }
}
