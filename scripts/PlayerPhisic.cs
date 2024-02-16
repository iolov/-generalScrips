using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhisic : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody _rb;
    [SerializeField]private Transform _tr;
    float HInput;
    float VInput;
    Vector3 moveDir;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Movement();
    }
    void FixedUpdate()
    {
        Move();
    }
    private void Movement()
    {
        HInput = Input.GetAxisRaw("Horizontal");
        VInput = Input.GetAxisRaw("Vertical");
    }
    private void Move()
    {
        moveDir = _tr.forward * VInput + _tr.right * HInput;
        _rb.AddForce(moveDir.normalized * speed, ForceMode.Force);
    }
}
