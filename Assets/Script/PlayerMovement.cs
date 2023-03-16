using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveDirection;

    public float moveSpeed = 600f;
    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, moveDirection * Time.fixedDeltaTime * moveSpeed);
    }
}
