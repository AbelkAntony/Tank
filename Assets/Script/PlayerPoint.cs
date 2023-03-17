using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoint : MonoBehaviour
{
    public int point = 0;
    

    public void AddPoint()
    {
        point = point +1;
    }

    public void ResetPoint()
    {
        point = 0;
    }

    
}
