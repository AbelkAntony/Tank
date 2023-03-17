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
        public float playerMoveSpeed = 600f;
        private float moveDirection;

        // shooting
        public BulletController bulletPrefab;
        public Transform gunPoint;

        //ui
        public GameOverController gameOver;
        public RestartButtonController restart;
        public UiControllerScore uiScore;
        public UiControllerLife uiLife;


        public int life;
        private int score;
        public static bool alive;

        private void Start()
        {
            Time.timeScale = 1;
            uiLife.UpdateLife(life);
            uiScore.UpdateScore(score);
            alive = true;
            gameOver.SetGameOver();
            restart.SetRestart();
            
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
                alive = false;
                gameOver.SetGameOver();
                restart.SetRestart();
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
