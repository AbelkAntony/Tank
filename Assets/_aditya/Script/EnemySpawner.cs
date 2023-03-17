using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tank.Aditya
{
    public class EnemySpawner : MonoBehaviour
    {
        public EnemyController enemyPrefab;
        public Transform player;
        private Vector3 randomPosition;
        private int choice;
        private float timer = 0;
        private float spawnDuration = 3 ;
        private void Update()
        {
            if (Time.time > timer)
            {
                timer = Time.time + spawnDuration;
                choice = Random.Range(0, 2);
                if(choice == 0)
                {
                    HorizontalSpawn();
                }
                else
                {
                    VerticalSpawn();
                }
                EnemyController enemy = Instantiate(enemyPrefab, randomPosition , transform.rotation);
                enemy.player = player;
            }
        }
        private void HorizontalSpawn()
        {
            float x = Random.Range(0, 2);
            if(x==0)
            {
                x = -4f; 
            }
            else
            {
                x = 4f;
            }
            float y = Random.Range(-6f, 6f);
            randomPosition = new (x, y, 0);
        }
        private void VerticalSpawn()
        {
            float y = Random.Range(0, 2);
            if(y==0)
            {
                y = -6f;
            }
            else
            {
                y = 6f;
            }
            float x = Random.Range(-4f, 4f);
            randomPosition = new(x, y, 0);
        }
    }
}
