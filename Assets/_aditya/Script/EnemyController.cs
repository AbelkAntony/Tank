using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tank.Aditya
{
    
    public class EnemyController : MonoBehaviour
    {
        private int enemyLife;
        public Transform player;
        public float moveSpeed;

        // Update is called once per frame
        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }

        public void SetEnemyLife(int value)
        {
            Debug.Log("enemy Life" + value.ToString());
            enemyLife = value;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            UpdateEnemyLife();
            if(GetEnemyLife()<0)
            {
                Destroy(gameObject);
                BulletController.isKill = true;
            }
        }
        public void UpdateEnemyLife()
        {
            enemyLife--;
        }
        public int GetEnemyLife()
        {
            return enemyLife;
        }
    }
}
