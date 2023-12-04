using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Transform player;
    public Transform cameraTransform;

    public float sensitivity = 100f; 

    float rotationX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -65f, 65f);

        cameraTransform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);

        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 moveDirection = (cameraTransform.forward * verticalMovement) + (cameraTransform.right * horizontalMovement);
        moveDirection.y = 0f;

        player.Translate(moveDirection * Time.deltaTime, Space.World);
    }
}
