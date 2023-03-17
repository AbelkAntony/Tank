using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tank.Aditya
{
    public class BulletController : MonoBehaviour
    {
        public float moveSpeed;
        public float aliveTime;
        public static bool isKill = false;

        private void Start()
        {
            Destroy(gameObject, aliveTime);
        }

        // Update is called once per frame
        private void Update()
        {
            transform.position += moveSpeed * Time.deltaTime * transform.right;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            isKill = true;
        }
        //private void OnCollisionEnter2D(Collision2D collision)
        //{
        //    // destroy collion and bullet
        //}
    }
}
