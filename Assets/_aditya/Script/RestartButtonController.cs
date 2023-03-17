using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tank.Aditya
{
    public class RestartButtonController : MonoBehaviour
    {
        // Start is called before the first frame update
        public void SetRestart(bool value)
        {
            gameObject.SetActive(value);
            if(value)
            {
                Time.timeScale = 0; 
            }
        }
        public void NewGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
