using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPhis : MonoBehaviour
{
    [SerializeField] float sensUp;
    [SerializeField] float sensHor;
    [SerializeField] GameObject player;
    float xRot;
    float yRot;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensUp*100* Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensHor*100* Time.deltaTime;

        yRot += mouseX;
        xRot -= mouseY;

        xRot = Mathf.Clamp(xRot, -90, 90);
        print(xRot);

        transform.rotation = Quaternion.Euler(xRot, yRot, 0);
        player.transform.rotation = Quaternion.Euler(0, yRot, 0);
    }
}
