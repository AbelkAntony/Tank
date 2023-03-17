using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tank.Aditya
{
    public class PlayerController : MonoBehaviour
    {
        // movement
        [SerializeField] private float playerMoveSpeed = 600f;
        private float moveDirection;

        // shooting
        [SerializeField] private BulletController bulletPrefab;
        [SerializeField] private Transform gunPoint;

        //ui
        [SerializeField] private GameOverController gameOver;
        [SerializeField] private RestartButtonController restart;
        [SerializeField] private UiControllerScore uiScore;
        [SerializeField] private UiControllerLife uiLife;


        [SerializeField] private int life;
        private int score;
        private bool alive;

        private void Start()
        {
            Time.timeScale = 1;
            uiLife.UpdateLife(life);
            uiScore.UpdateScore(score);
            gameOver.SetGameOver(false);
            restart.SetRestart(false);
            
        }

        private void Update()
        {
            Movement();
            Shooting();
            if(BulletController.isKill == true)
            {
                UpdateScore();
            }
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
            transform.eulerAngles += Vector3.forward * -moveDirection * playerMoveSpeed * Time.deltaTime;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(collision.gameObject);
            life--;
            uiLife.UpdateLife(life);
            if (life < 1)
            {
                //Time.timeScale = 0;
                gameOver.SetGameOver(true);
                restart.SetRestart(true);
            }
        }
        public void UpdateScore()
        {
            score = score+1;
            uiScore.UpdateScore(score);
            BulletController.isKill = false;
        }
        
    }
}
