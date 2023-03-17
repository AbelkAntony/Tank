using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tank.Aditya
{
    public class UiControllerScore : MonoBehaviour
    {

        public Text ScoreCount;
        public void UpdateScore(int score)
        {
            ScoreCount.text = score.ToString();
        }
    }
}
