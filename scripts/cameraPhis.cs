using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPhis : MonoBehaviour
{
    [SerializeField] float sens;
    [SerializeField] GameObject player;
    float xRot;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens*100* Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sens*100* Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90, 90);
        print(xRot);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        player.transform.Rotate(Vector3.up * mouseX*1.5f);
    }
}
