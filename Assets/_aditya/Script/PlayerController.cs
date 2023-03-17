using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tank.Aditya
{
    public class PlayerController : MonoBehaviour
    {
        // movement
        public float moveSpeed = 600f;
        private float moveDirection;

        // shooting
        public BulletController bulletPrefab;
        public Transform gunPoint;

        public int life;

        private static bool alive = true;

        private void Update()
        {
            Movement();
            Shooting();
        }

        private void Shooting()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bulletPrefab, gunPoint.position, gunPoint.rotation);
            }
        }

        private void Movement()
        {
            moveDirection = Input.GetAxisRaw("Horizontal");
            //transform.RotateAround(Vector3.zero, Vector3.forward, -moveDirection * Time.deltaTime * moveSpeed);
            transform.eulerAngles += Vector3.forward * -moveDirection * moveSpeed * Time.deltaTime;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(collision.gameObject);
            life--;
            if(life < 1)
            {
                Time.timeScale = 0;
                alive = false;
                
            }
        }
    }
}
