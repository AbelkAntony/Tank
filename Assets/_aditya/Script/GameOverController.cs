using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tank.Aditya
{
    public class GameOverController : MonoBehaviour
    {
       
        public void SetGameOver()
        {
            if(PlayerController.alive == true)
            {
                gameObject.SetActive(false); 
            }
            else if(PlayerController.alive == false)
            {
                gameObject.SetActive(true);
            }
        }
    }
}
