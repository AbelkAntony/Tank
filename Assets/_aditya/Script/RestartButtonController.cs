using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tank.Aditya
{
    public class RestartButtonController : MonoBehaviour
    {
        // Start is called before the first frame update
        public void SetRestart()
        {
            if(PlayerController.alive == true)
            {
                gameObject.SetActive(false);
            }
            else if(PlayerController.alive == false)
            {
                gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
        public void NewGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
