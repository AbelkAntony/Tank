using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tank.Aditya
{
    public class EnemyController : MonoBehaviour
    {
        public Transform player;
        public float moveSpeed;

        // Update is called once per frame
        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
    }
}
