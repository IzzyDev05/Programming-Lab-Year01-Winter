using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivty = 100f;

    private Transform playerBody;
    private float xRotation = 0f;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;

        playerBody = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    private void Update() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivty * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivty * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -74, 74);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
