using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tank.Aditya
{
    public class UiControllerLife : MonoBehaviour
    {
        [SerializeField] private Text lifeCount;
        
        public void UpdateLife(int life)
        {
            lifeCount.text = life.ToString(); 
        }
       
    }
}
