using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float force;
    Vector3 moveDir;
    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        moveDir = new Vector3(horizontal, 0 , vertical);
    }

    private void FixedUpdate()
    {
        if(moveDir != Vector3.zero)
        rb.AddForce(moveDir * force, ForceMode.Force);
    }
}
