using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPhis : MonoBehaviour
{
    [SerializeField] float sens = 100;
    [SerializeField] GameObject player;
    float xRot;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90, 90);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        player.transform.Rotate(Vector3.up * mouseX*1.5f);
    }
}
