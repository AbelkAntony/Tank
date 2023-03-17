using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tank.Aditya
{
    
    public class EnemyController : MonoBehaviour
    {
        private int enemyLife;
        [SerializeField] private GameObject player;
        [SerializeField] private float moveSpeed;
        [SerializeField] private PlayerController _player;
        // Update is called once per frame
        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
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
                _player.UpdateScore();
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
        public void SetPlayer(GameObject _player)
        {
            player = _player;
        }
        public void SetPlayerScore(PlayerController player)
        {
            _player = player;
        }
    }
}
