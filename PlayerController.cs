using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController character_controller;
    public float move_speed = 5.0f;
    private Vector2 move_input = Vector2.zero;

    public Camera cam;
    public Transform orientation;
    void Start()
    {
        character_controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetMoveInput(InputAction.CallbackContext context)
    {
        move_input = context.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        Vector3 dir = new(move_input.x, 0, move_input.y);

        var cam_position = new Vector3(cam.transform.position.x, transform.position.y, cam.transform.position.z);
        Vector3 view_direction = transform.position - cam_position;

        orientation.forward = view_direction;

        dir = (orientation.right * move_input.x + orientation.forward * move_input.y).normalized;

        character_controller.Move(move_speed * Time.deltaTime * dir);

    }
}
