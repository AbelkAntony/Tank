using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tank.Aditya
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private EnemyController enemyPrefab;
        [SerializeField] private GameObject player;
        [SerializeField] private PlayerController _player;
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
                enemy.SetPlayer(player);
                int value = Random.Range(1, 4);
                enemy.SetEnemyLife(value);
                enemy.SetPlayerScore(_player);
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
