using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tank.Aditya
{
    public class EnemySpawner : MonoBehaviour
    {
        public EnemyController enemyPrefab;
        public Transform player;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EnemyController enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
                enemy.player = player;
            }
        }
    }
}
