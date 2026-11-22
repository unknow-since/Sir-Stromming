using UnityEngine;

public class Mouselook : MonoBehaviour
{




    public float sensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Camera looks up and down
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Player rotates left and right
        playerBody.Rotate(Vector3.up * mouseX);
    }
}