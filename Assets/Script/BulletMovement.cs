using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;

    private Vector3 direction;


    private void Start()
    {
        direction = GameObject.Find("Gun").transform.position;
    }
    void Update()
    {
        //direction = GameObject.Find("Player").transform.position;
        transform.Translate(direction * bulletSpeed * Time.deltaTime);
    }
}
