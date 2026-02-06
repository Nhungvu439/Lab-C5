using UnityEngine;

public class PlayerCC_Movement : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -20f;

    private CharacterController controller;
    private Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 🔴 DÙNG WORLD AXIS
        Vector3 move = new Vector3(h, 0, v);
        controller.Move(move * speed * Time.deltaTime);

        if (controller.isGrounded)
        {
            velocity.y = -2f;
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }

        controller.Move(velocity * Time.deltaTime);
    }
}
