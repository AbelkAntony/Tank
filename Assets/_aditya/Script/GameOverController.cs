using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tank.Aditya
{
    public class GameOverController : MonoBehaviour
    {
       
        public void SetGameOver(bool value)
        {
            gameObject.SetActive(value);           
        }
    }
}
